﻿using System.Text;
using System.Xml.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace Sentinel.SourceGenerator.Generators.Markup;

internal static class Helper
{
    internal const string NewLine = "\r\n";

    private static readonly char[] InvalidHintNameChars =
    [
        '<',
        '>',
        ':',
        '"',
        '/',
        '\\',
        '|',
        '?',
        '*',
    ];

    private static readonly string[] IgnoreAvaloniaProperties =
    [
        "CornerRadiusProperty",
        "BorderThicknessProperty",
        "ContentProperty",
    ];

    internal static bool IsNotConflictingExtension(this IFieldSymbol field) =>
        !IgnoreAvaloniaProperties.Contains(field.Name);

    internal static bool IsNotConflictingExtension(this IPropertySymbol property) =>
        !IgnoreAvaloniaProperties.Contains(property.Name);

    internal static string? CleanIdentifier(this string name, bool @namespace = false)
    {
        // trim off leading and trailing whitespace
        name = name.Trim();

        if (string.IsNullOrEmpty(name))
        {
            return null;
        }

        var sb = new StringBuilder();
        if (!SyntaxFacts.IsIdentifierStartCharacter(name[0]))
        {
            // the first characters
            sb.Append('_');
        }

        foreach (var ch in name)
        {
            if (SyntaxFacts.IsIdentifierPartCharacter(ch) || @namespace && ch == '.')
            {
                sb.Append(ch);
            }
        }

        var result = sb.ToString();

        if (SyntaxFacts.GetKeywordKind(result) != SyntaxKind.None)
        {
            result = '@' + result;
        }

        if (@namespace)
        {
            var newResult = string.Empty;
            foreach (var chunk in result.Split('.'))
            {
                if (!string.IsNullOrEmpty(newResult))
                {
                    newResult += '.';
                }

                if (SyntaxFacts.GetKeywordKind(chunk) != SyntaxKind.None)
                {
                    newResult += '@' + chunk;
                }
                else
                {
                    newResult += chunk;
                }
            }

            return newResult;
        }

        return result;
    }

    internal static string RemoveIllegalFileNameCharacters(this string fileName)
    {
        return string.Concat(
            fileName.Select(c => InvalidHintNameChars.Contains(c) || char.IsControl(c) ? '_' : c)
        );
    }

    internal static string RemoveTrailingProperty(this string source)
    {
        if (source.EndsWith("Property"))
        {
            source = source.Substring(0, source.Length - "Property".Length);
        }

        return source;
    }

    internal static bool HasPublicSetter(this IPropertySymbol? property)
    {
        return property?.SetMethod != null
            && property.SetMethod.DeclaredAccessibility == Accessibility.Public;
    }

    internal static IEnumerable<INamedTypeSymbol> GetPublicClasses(this INamespaceSymbol sym)
    {
        foreach (INamedTypeSymbol typeMember in sym.GetTypeMembers())
        {
            if (
                typeMember.DeclaredAccessibility == Accessibility.Public
                && typeMember.TypeKind == TypeKind.Class
            )
                yield return typeMember;
        }

        foreach (INamespaceSymbol namespaceMember in sym.GetNamespaceMembers())
        {
            foreach (INamedTypeSymbol publicClass in GetPublicClasses(namespaceMember))
            {
                if (
                    publicClass.DeclaredAccessibility == Accessibility.Public
                    && publicClass.TypeKind == TypeKind.Class
                )
                    yield return publicClass;
            }
        }
    }

    internal static bool InheritsFrom(this INamedTypeSymbol type, string baseType)
    {
        while (type.BaseType != null)
        {
            if (type.BaseType.ToString() == baseType)
                return true;

            type = type.BaseType;
        }

        return false;
    }

    internal static string? GetDocumentation(this IFieldSymbol field)
    {
        var docs = "";
        var propertyName = field.Name.RemoveTrailingProperty();

        if (field.AssociatedSymbol != null)
        {
            propertyName = field.AssociatedSymbol!.MetadataName;
        }
        else if (field.IsAttachedPropertyField())
        {
            propertyName = "Set" + propertyName;
        }

        var property = field
            .ContainingType.GetMembers(propertyName)
            //.OfType<IPropertySymbol>()
            .FirstOrDefault();

        if (property != null)
        {
            docs = property.GetDocumentationCommentXml();
            if (!string.IsNullOrEmpty(docs))
            {
                docs = GetSummary(docs!);
            }
        }

        static string? GetSummary(string comment)
        {
            try
            {
                var element = XElement.Parse(comment);
                var summary = element
                    .Element("summary")
                    ?.Value.Trim()
                    .Replace("\n", "")
                    .Replace("\r", "");
                return summary;
            }
            catch (Exception)
            {
                // ignored
            }

            return null;
        }

        return docs;
    }

    internal static string? GetDocumentation(this IPropertySymbol property)
    {
        var docs = property.GetDocumentationCommentXml();

        if (!string.IsNullOrEmpty(docs))
        {
            docs = GetSummary(docs!);
        }

        static string? GetSummary(string comment)
        {
            try
            {
                var element = XElement.Parse(comment);
                var summary = element.Element("summary")?.Value.Trim();
                return summary;
            }
            catch (Exception)
            {
                // ignored
            }

            return null;
        }

        return docs;
    }

    internal static bool IsAvaloniaPropertyField(this IFieldSymbol field)
    {
        if (field.GetAttributes().Any(x => x.AttributeClass?.Name == "ObsoleteAttribute"))
            return false;

        if (
            field.Type.Name.StartsWith("DirectProperty")
            || field.Type.Name.StartsWith("StyledProperty")
            ||
            //some attached properties Mapped to properties of controls, i.e. TextBlock.TextWrapping
            //so we need to add direct Extensions for them, additionally to AttachedProperty extensions
            //field.Type.Name.StartsWith("AttachedProperty") ||
            field.Type.Name.StartsWith("AvaloniaProperty")
        )
        {
            return !field.IsReadOnlyField();
        }

        return false;
    }

    internal static bool IsReadOnlyField(this IFieldSymbol field)
    {
        var controlType = field.ContainingType;
        var propertyName = field.Name.RemoveTrailingProperty();

        if (field.AssociatedSymbol != null)
        {
            propertyName = field.AssociatedSymbol.Name.RemoveTrailingProperty();
        }

        var symbol = controlType?.GetMembers(propertyName).FirstOrDefault();

        if (symbol is IPropertySymbol prop)
        {
            return !prop.HasPublicSetter();
        }

        return true;
    }

    internal static bool IsAttachedPropertyField(this IFieldSymbol field)
    {
        if (field.GetAttributes().Any(x => x.AttributeClass?.Name == "ObsoleteAttribute"))
            return false;

        if (field.Type.Name.StartsWith("AttachedProperty"))
        {
            return !field.IsReadOnlyAttachedField();
        }

        return false;
    }

    internal static bool IsReadOnlyAttachedField(this IFieldSymbol field)
    {
        var controlType = field.ContainingType;
        var setterMethodName = "Set" + field.Name.RemoveTrailingProperty();

        var methodInfo = controlType?.GetMembers(setterMethodName).FirstOrDefault();

        if (methodInfo is IMethodSymbol method)
        {
            return !(method.DeclaredAccessibility == Accessibility.Public && method.IsStatic);
        }

        return false;
    }

    internal static List<string> GetNamespaces(this INamedTypeSymbol type)
    {
        var namespaces = new HashSet<string>();

        void AddNamespace(INamespaceSymbol? ns)
        {
            if (ns == null || ns.IsGlobalNamespace)
                return;
            namespaces.Add(ns.ToDisplayString());
        }

        void CollectFromType(ITypeSymbol? t)
        {
            if (t == null)
                return;
            if (t is INamedTypeSymbol named)
            {
                AddNamespace(named.ContainingNamespace);
                foreach (var arg in named.TypeArguments)
                    CollectFromType(arg);
            }
            else if (t is IArrayTypeSymbol arr)
            {
                CollectFromType(arr.ElementType);
            }
            else if (t is IPointerTypeSymbol ptr)
            {
                CollectFromType(ptr.PointedAtType);
            }
        }

        foreach (var member in type.GetMembers())
        {
            switch (member)
            {
                case IPropertySymbol prop:
                    CollectFromType(prop.Type);
                    foreach (var param in prop.Parameters)
                        CollectFromType(param.Type);
                    break;
                case IMethodSymbol method:
                    CollectFromType(method.ReturnType);
                    foreach (var param in method.Parameters)
                        CollectFromType(param.Type);
                    break;
                case IFieldSymbol field:
                    CollectFromType(field.Type);
                    break;
                case IEventSymbol evt:
                    CollectFromType(evt.Type);
                    break;
            }
        }

        // Also add the type's own namespace
        AddNamespace(type.ContainingNamespace);

        return [.. namespaces];
    }

    internal static bool IsAvaloniaProperty(this IPropertySymbol property)
    {
        if (
            property.ContainingType.GetMembers(property.Name + "Property").FirstOrDefault()
            is not IFieldSymbol field
        )
            return false;

        if (field.GetAttributes().Any(x => x.AttributeClass?.Name == "ObsoleteAttribute"))
            return false;

        if (
            field.Type.Name.StartsWith("DirectProperty")
            || field.Type.Name.StartsWith("StyledProperty")
            ||
            //some attached properties Mapped to properties of controls, i.e. TextBlock.TextWrapping
            //so we need to add direct Extensions for them, additionally to AttachedProperty extensions
            field.Type.Name.StartsWith("AttachedProperty")
            || field.Type.Name.StartsWith("AvaloniaProperty")
        )
        {
            return !IsReadOnlyField(field);
        }

        return false;
    }

    internal static bool IsCommonProperty(this IPropertySymbol property)
    {
        if (property.GetAttributes().Any(x => x.AttributeClass?.Name == "ObsoleteAttribute"))
            return false;

        return !IsReadOnly(property);
    }

    internal static bool IsReadOnly(this IPropertySymbol property)
    {
        return !property.HasPublicSetter();
    }

    internal static bool IsAcceptableStyledField(this IFieldSymbol field)
    {
        if (field.GetAttributes().Any(x => x.AttributeClass?.Name == "ObsoleteAttribute"))
            return false;

        if (
            field.Type.Name.StartsWith("StyledProperty")
            || field.Type.Name.StartsWith("AttachedProperty")
        )
            return !IsReadOnlyField(field);

        return false;
    }

    internal static bool IsStyledElement(this INamedTypeSymbol controlType)
    {
        return controlType.AllInterfaces.Any(x => x.Name == "IStyleable");
    }

    internal static IEnumerable<ISymbol> GetAllMembers(this INamedTypeSymbol type)
    {
        var seen = new HashSet<string>();
        var stack = new Stack<INamedTypeSymbol>();
        stack.Push(type);

        while (stack.Count > 0)
        {
            var current = stack.Pop();
            foreach (var member in current.GetMembers())
            {
                // Avoid duplicates by signature
                if (seen.Add(member.ToDisplayString()))
                    yield return member;
            }

            if (current.BaseType != null)
                stack.Push(current.BaseType);

            foreach (var iface in current.Interfaces)
                stack.Push(iface);
        }
    }

    internal static readonly SymbolDisplayFormat FullyQualifiedGlobalFormat = new(
        globalNamespaceStyle: SymbolDisplayGlobalNamespaceStyle.Included,
        typeQualificationStyle: SymbolDisplayTypeQualificationStyle.NameAndContainingTypesAndNamespaces,
        genericsOptions: SymbolDisplayGenericsOptions.IncludeTypeParameters
            | SymbolDisplayGenericsOptions.IncludeVariance,
        miscellaneousOptions: SymbolDisplayMiscellaneousOptions.EscapeKeywordIdentifiers
            | SymbolDisplayMiscellaneousOptions.IncludeNullableReferenceTypeModifier
    );

    internal static string GetFullTypeName(this ITypeSymbol symbol)
    {
        var fullName = symbol.ToDisplayString(FullyQualifiedGlobalFormat);

        if (!fullName.EndsWith("?") && symbol.NullableAnnotation == NullableAnnotation.Annotated)
        {
            fullName += "?";
        }

        return fullName;
    }

    internal static ITypeSymbol GetLastGenericArgument(this ITypeSymbol type)
    {
        if (type is INamedTypeSymbol nts)
        {
            if (nts.TypeArguments.Length > 0)
            {
                return nts.TypeArguments.Last();
            }
        }

        return type;
    }

    public static bool IsOrInheritsFrom(this ITypeSymbol? symbol, ITypeSymbol? baseOrInterface)
    {
        if (symbol == null || baseOrInterface == null)
            return false;

        // exact match
        if (SymbolEqualityComparer.Default.Equals(symbol, baseOrInterface))
            return true;

        // walk base types
        for (var current = symbol.BaseType; current != null; current = current.BaseType)
        {
            if (SymbolEqualityComparer.Default.Equals(current, baseOrInterface))
                return true;
        }

        // check interfaces
        return symbol.AllInterfaces.Any(i =>
            SymbolEqualityComparer.Default.Equals(i, baseOrInterface)
        );
    }
}
