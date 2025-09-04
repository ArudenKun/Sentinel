using Microsoft.CodeAnalysis;

namespace Sentinel.SourceGenerator.Common.Extensions;

internal static class SymbolExtensions
{
    public static string NamespaceOrEmpty(this ISymbol symbol) =>
        symbol.ContainingNamespace.IsGlobalNamespace
            ? string.Empty
            : string.Join(".", symbol.ContainingNamespace.ConstituentNamespaces);

    /// <summary>
    /// Returns a fully qualified type name including the global:: prefix.
    /// </summary>
    public static string ToFullDisplayString(this ISymbol symbol) =>
        symbol.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);

    public static bool InheritsFrom(this ITypeSymbol? type, ITypeSymbol? baseType)
    {
        while (type is not null)
        {
            if (SymbolEqualityComparer.Default.Equals(type, baseType))
                return true;

            type = type.BaseType;
        }
        return false;
    }
}
