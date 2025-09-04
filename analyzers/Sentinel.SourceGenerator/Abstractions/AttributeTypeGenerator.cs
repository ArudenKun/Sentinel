using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;
using Sentinel.SourceGenerator.Common;

namespace Sentinel.SourceGenerator.Abstractions;

internal abstract class AttributeTypeGenerator<TAttribute>
    : AttributeMemberGenerator<TAttribute, TypeDeclarationSyntax>
    where TAttribute : Attribute
{
    protected abstract (string GeneratedCode, DiagnosticDetail? Error) GenerateCode(
        Compilation compilation,
        SyntaxNode node,
        INamedTypeSymbol symbol,
        AttributeData attributeData,
        AnalyzerConfigOptions options
    );

    protected sealed override (string GeneratedCode, DiagnosticDetail? Error) GenerateCode(
        Compilation compilation,
        SyntaxNode node,
        ISymbol symbol,
        AttributeData attributeData,
        AnalyzerConfigOptions options
    ) => GenerateCode(compilation, node, (INamedTypeSymbol)symbol, attributeData, options);
}
