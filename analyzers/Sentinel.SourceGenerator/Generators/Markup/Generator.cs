using System.Collections.Immutable;
using H;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Sentinel.SourceGenerator.Attributes;

namespace Sentinel.SourceGenerator.Generators.Markup;

[Generator]
public sealed class Generator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        // Local Classes
        // var classDeclarations = context
        //     .SyntaxProvider.CreateSyntaxProvider(
        //         predicate: static (syntaxNode, _) => syntaxNode is ClassDeclarationSyntax,
        //         transform: static (ctx, _) => GetSemanticTarget(ctx)
        //     )
        //     .Where(static c => c is not null);
        //
        // context.RegisterSourceOutput(
        //     classDeclarations,
        //     static (spc, data) =>
        //     {
        //         var generator = new GeneratorHost();
        //         var extensionsCode = generator.GenerateExtensions(data!);
        //         if (
        //             !string.IsNullOrWhiteSpace(extensionsCode)
        //             || !string.IsNullOrEmpty(extensionsCode)
        //         )
        //         {
        //             spc.AddSource(
        //                 $"{data!.ToString().RemoveIllegalFileNameCharacters()}.g.cs",
        //                 extensionsCode!
        //             );
        //         }
        //
        //         var builderCode = generator.GenerateBuilder(data);
        //         if (!string.IsNullOrWhiteSpace(builderCode) || !string.IsNullOrEmpty(builderCode))
        //         {
        //             spc.AddSource(
        //                 $"{data!.ToString().RemoveIllegalFileNameCharacters()}.Builder.g.cs",
        //                 builderCode!
        //             );
        //         }
        //     }
        // );

        // External Classes
        var extensionAttributes = context
            .SyntaxProvider.ForAttributeWithMetadataName(
                typeof(GenerateMarkupExtensionsForAssemblyAttribute).FullName!,
                static (_, _) => true,
                static (ctx, _) => GetMarkupSemanticTarget(ctx)
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
            extensionAttributes,
            static (spc, assemblies) =>
            {
                foreach (var assembly in assemblies)
                {
                    GetClasses(spc, assembly);
                }
            }
        );

        // BUilder
        var builderAttributes = context
            .SyntaxProvider.ForAttributeWithMetadataName(
                typeof(GenerateMarkupBuilderForAssemblyAttribute).FullName!,
                static (_, _) => true,
                static (ctx, _) => GetMarkupBuilderSemanticTarget(ctx)
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
            builderAttributes,
            static (spc, assemblies) =>
            {
                foreach (var assembly in assemblies)
                {
                    GetBuilderClasses(spc, assembly);
                }
            }
        );

        context.RegisterPostInitializationOutput(pi =>
        {
            pi.AddSource(
                $"{typeof(GenerateMarkupExtensionsForAssemblyAttribute).FullName}.g.cs",
                Resources.GenerateMarkupExtensionsForAssemblyAttribute_cs.AsString()
            );

            pi.AddSource(
                $"{typeof(GenerateMarkupBuilderForAssemblyAttribute).FullName}.g.cs",
                Resources.GenerateMarkupBuilderForAssemblyAttribute_cs.AsString()
            );
        });
    }

    // private static INamedTypeSymbol? GetSemanticTarget(GeneratorSyntaxContext context)
    // {
    //     var classDecl = (ClassDeclarationSyntax)context.Node;
    //     var symbol = context.SemanticModel.GetDeclaredSymbol(classDecl);
    //     if (symbol != null && symbol.InheritsFrom("Avalonia.Visual"))
    //     {
    //         return symbol;
    //     }
    //
    //     return null;
    // }

    private static ImmutableArray<IAssemblySymbol> GetMarkupSemanticTarget(
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

    private static ImmutableArray<IAssemblySymbol> GetMarkupBuilderSemanticTarget(
        GeneratorAttributeSyntaxContext context
    )
    {
        var assemblies = new HashSet<IAssemblySymbol>(SymbolEqualityComparer.Default);
        foreach (var attribute in context.Attributes)
        {
            if (
                attribute?.AttributeClass?.Name == "GenerateMarkupBuilderForAssemblyAttribute"
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

                if (extensionCode is not null)
                {
                    spc.AddSource(
                        $"{publicClass.ToString().RemoveIllegalFileNameCharacters()}.g.cs",
                        extensionCode
                    );
                }

                var builderCode = generator.GenerateBuilder(publicClass);
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

    private static void GetBuilderClasses(SourceProductionContext spc, IAssemblySymbol symbol)
    {
        var generator = new GeneratorHost();

        foreach (var publicClass in symbol.GlobalNamespace.GetPublicClasses())
        {
            if (publicClass.InheritsFrom("Avalonia.Visual"))
            {
                var builderCode = generator.GenerateBuilder(publicClass);
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
}
