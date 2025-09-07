using System.Collections.Immutable;
using H;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Sentinel.SourceGenerator.Attributes;
using Sentinel.SourceGenerator.Common;
using Sentinel.SourceGenerator.Common.Extensions;

namespace Sentinel.SourceGenerator.Generators.Markup;

[Generator]
public sealed class Generator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        // Local Classes
        var classDeclarations = context
            .SyntaxProvider.CreateSyntaxProvider(
                predicate: static (syntaxNode, _) => syntaxNode is ClassDeclarationSyntax,
                transform: static (ctx, _) => GetSemanticTarget(ctx)
            )
            .Where(static c => c is not null);

        context.RegisterSourceOutput(
            classDeclarations,
            static (spc, data) =>
            {
                var code = GenerateBuilder(data);
                if (!string.IsNullOrEmpty(code))
                {
                    spc.AddSource(
                        $"{data!.ToString().RemoveIllegalFileNameCharacters()}.Builder.g.cs",
                        code!
                    );
                }
            }
        );

        // External Classes
        var attribute = context
            .SyntaxProvider.ForAttributeWithMetadataName(
                typeof(GenerateMarkupExtensionsForAssemblyAttribute).FullName!,
                static (_, _) => true,
                static (ctx, _) => GetSemanticTarget(ctx)
            )
            .SelectMany((assemblies, _) => assemblies)
            .Collect()
            .Select(
                (assemblies, _) =>
                    assemblies
                        .Distinct<IAssemblySymbol>(SymbolEqualityComparer.Default)
                        .ToImmutableArray()
            );

        context.RegisterSourceOutput(
            attribute,
            static (spc, assemblies) =>
            {
                foreach (var assembly in assemblies)
                {
                    GetClasses(spc, assembly);
                }
            }
        );

        context.RegisterPostInitializationOutput(pi =>
        {
            pi.AddSource(
                $"{typeof(GenerateMarkupExtensionsForAssemblyAttribute).FullName}.g.cs",
                Resources.GenerateMarkupExtensionsForAssemblyAttribute_cs.AsString()
            );
        });
    }

    private static INamedTypeSymbol? GetSemanticTarget(GeneratorSyntaxContext context)
    {
        var classDecl = (ClassDeclarationSyntax)context.Node;
        var symbol = context.SemanticModel.GetDeclaredSymbol(classDecl);

        if (symbol != null && symbol.InheritsFrom("Avalonia.Visual"))
        {
            return symbol;
        }

        return null;
    }

    private static ImmutableArray<IAssemblySymbol> GetSemanticTarget(
        GeneratorAttributeSyntaxContext context
    )
    {
        var assemblies = new HashSet<IAssemblySymbol>(SymbolEqualityComparer.Default);

        foreach (var attribute in context.Attributes)
        {
            if (
                attribute?.AttributeClass?.Name == "GenerateMarkupExtensionsForAssemblyAttribute"
                && attribute.ConstructorArguments.Length > 0
                && attribute.ConstructorArguments[0].Value is INamedTypeSymbol iNamedTypeSymbol
            )
            {
                assemblies.Add(iNamedTypeSymbol.ContainingAssembly);
            }
        }

        return [.. assemblies];
    }

    private static void GetClasses(SourceProductionContext spc, IAssemblySymbol symbol)
    {
        var generator = new GeneratorHost();

        foreach (var publicClass in symbol.GlobalNamespace.GetPublicClasses())
        {
            if (publicClass.InheritsFrom("Avalonia.Visual"))
            {
                var extensionCode = generator.GenerateExtensions(publicClass);

                if (extensionCode != null)
                {
                    spc.AddSource(
                        $"{publicClass.ToString().RemoveIllegalFileNameCharacters()}.g.cs",
                        extensionCode
                    );
                }

                var builderCode = GenerateBuilder(publicClass);
                if (builderCode is not null)
                {
                    spc.AddSource(
                        $"{publicClass.ToString().RemoveIllegalFileNameCharacters()}.Builder.g.cs",
                        builderCode
                    );
                }
            }
        }
    }

    private static string? GenerateBuilder(INamedTypeSymbol? namedTypeSymbol)
    {
        if (namedTypeSymbol is null)
            return null;

        if (namedTypeSymbol.IsAbstract)
        {
            return null;
        }

        var name = namedTypeSymbol.Name;
        var controlType = namedTypeSymbol.ToFullDisplayString();

        var builder = new SourceStringBuilder(namedTypeSymbol);

        builder.NamespaceBlockBrace(
            "Avalonia.Markup.Declarative",
            () =>
            {
                builder.Line("public static partial class Builders");
                builder.BlockBrace(() =>
                {
                    builder.Line($"public static {controlType} {name}() => new();");
                    builder.Line(
                        $"public static {controlType} {name}(out {controlType} @ref) => @ref = new();"
                    );
                });
            }
        );

        return builder.ToString();
    }
}
