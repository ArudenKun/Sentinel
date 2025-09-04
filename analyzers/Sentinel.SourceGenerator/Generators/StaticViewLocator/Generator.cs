using H;
using H.Generators.Extensions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using Sentinel.SourceGenerator.Abstractions;
using Sentinel.SourceGenerator.Attributes;
using Sentinel.SourceGenerator.Common;
using Sentinel.SourceGenerator.Common.Extensions;

namespace Sentinel.SourceGenerator.Generators.StaticViewLocator;

[Generator]
internal sealed class Generator : AttributeTypeGenerator<StaticViewLocatorAttribute>
{
    private const string ViewModelSuffix = "ViewModel";

    protected override IEnumerable<FileWithName> StaticSources { get; } =
    [
        new(
            typeof(StaticViewLocatorAttribute).FullName!,
            Resources.StaticViewLocatorAttribute_cs.AsString()
        ),
    ];

    protected override (string GeneratedCode, DiagnosticDetail? Error) GenerateCode(
        Compilation compilation,
        SyntaxNode node,
        INamedTypeSymbol symbol,
        AttributeData attributeData,
        AnalyzerConfigOptions options
    )
    {
        var viewModelSymbols = new List<INamedTypeSymbol>();
        GetViewModelsFromAssembly(symbol.ContainingNamespace, viewModelSymbols);

        var attribute = attributeData.MapToType<StaticViewLocatorAttribute>();

        string? nsFrom = null;
        string? nsTo = null;
        string? suffixFrom = null;
        string? suffixTo = null;
        if (
            !string.IsNullOrEmpty(attribute.ViewToViewModelNamespaceRule)
            && attribute.ViewToViewModelNamespaceRule!.Contains("->")
        )
        {
            var parts = attribute.ViewToViewModelNamespaceRule!.Split(
                ["->"],
                StringSplitOptions.None
            );
            if (parts.Length == 2)
            {
                nsFrom = parts[0].Trim();
                nsTo = parts[1].Trim();
            }
        }

        if (
            !string.IsNullOrEmpty(attribute.ViewToViewModelSuffixRule)
            && attribute.ViewToViewModelSuffixRule!.Contains("->")
        )
        {
            var parts = attribute.ViewToViewModelSuffixRule!.Split(["->"], StringSplitOptions.None);
            if (parts.Length == 2)
            {
                suffixFrom = parts[0].Trim();
                suffixTo = parts[1].Trim();
            }
        }

        var controlViewSymbol = compilation.GetTypeByMetadataName("Avalonia.Controls.Control");

        if (controlViewSymbol is null)
        {
            return (
                string.Empty,
                new DiagnosticDetail(
                    GuidPolyfill.CreateVersion7().ToString(),
                    "Package",
                    "Failed to find Avalonia",
                    "Please install the avalonia package"
                )
            );
        }

        var source = new SourceStringBuilder(symbol);

        source.Line("using System;");
        source.Line("using System.Collections.Generic;");
        source.Line("using Avalonia.Controls;");
        source.PartialTypeBlockBrace(() =>
        {
            source.Line(
                $"private static readonly IReadOnlyDictionary<Type, Func<Control>> ViewFactory = new Dictionary<Type, Func<Control>>({viewModelSymbols.Count})"
            );
            source.BlockDecl(() =>
            {
                foreach (var viewModelSymbol in viewModelSymbols)
                {
                    var namespaceNameViewModel =
                        viewModelSymbol.ContainingNamespace.ToDisplayString();
                    var classNameViewModel = viewModelSymbol.Name;

                    // 应用命名空间筛选器
                    if (attribute.IncludeNamespaces is { Length: > 0 })
                    {
                        if (
                            !attribute.IncludeNamespaces.Any(ns =>
                                namespaceNameViewModel.StartsWith(ns)
                            )
                        )
                        {
                            continue;
                        }
                    }

                    if (attribute.ExcludeNamespaces is { Length: > 0 })
                    {
                        if (
                            attribute.ExcludeNamespaces.Any(ns =>
                                namespaceNameViewModel.StartsWith(ns)
                            )
                        )
                        {
                            continue;
                        }
                    }

                    if (viewModelSymbol.ContainingSymbol is INamedTypeSymbol)
                    {
                        continue;
                    }

                    string viewNamespace;
                    var viewName = classNameViewModel;

                    // Apply namespace rule (if specified) or default transformation
                    if (!string.IsNullOrEmpty(nsFrom) && !string.IsNullOrEmpty(nsTo))
                    {
                        viewNamespace = namespaceNameViewModel.Replace(nsTo!, nsFrom!);
                    }
                    else
                    {
                        // Default: ViewModels -> Views
                        viewNamespace = namespaceNameViewModel.Replace("ViewModels", "Views");
                    }

                    // Apply suffix rule (if specified) or default transformation
                    if (!string.IsNullOrEmpty(suffixFrom) && !string.IsNullOrEmpty(suffixTo))
                    {
                        viewName = classNameViewModel.Replace(suffixTo!, suffixFrom!);
                    }
                    else
                    {
                        // Default: ViewModel -> View, but handle special cases
                        if (classNameViewModel.EndsWith("ViewModel"))
                        {
                            var baseName = classNameViewModel.Substring(
                                0,
                                classNameViewModel.Length - "ViewModel".Length
                            );
                            // For MainWindow, remove ViewModel completely; for others, add View
                            if (baseName.EndsWith("Window"))
                            {
                                viewName = baseName;
                            }
                            else
                            {
                                viewName = baseName + "View";
                            }
                        }
                    }

                    var classNameView = $"{viewNamespace}.{viewName}";
                    var viewSymbol = compilation.GetTypeByMetadataName(classNameView);
                    var isValidView =
                        viewSymbol is not null && viewSymbol.InheritsFrom(controlViewSymbol);

                    source.Line(
                        !isValidView
                            ? $"[typeof({viewModelSymbol.ToFullDisplayString()})] = () => new TextBlock() {{ Text = \"Not Found: {classNameView}\" }},"
                            : $"[typeof({viewModelSymbol.ToFullDisplayString()})] = () => new {viewSymbol!.ToFullDisplayString()}(),"
                    );
                }
            });
        });

        return (source.ToString(), null);
    }

    private static void GetViewModelsFromAssembly(
        INamespaceSymbol namespaceSymbol,
        List<INamedTypeSymbol> viewModels
    )
    {
        foreach (var member in namespaceSymbol.GetMembers())
        {
            switch (member)
            {
                case INamedTypeSymbol namedType:
                {
                    if (
                        namedType.Name.EndsWith(ViewModelSuffix)
                        && namedType
                            is { IsAbstract: false, DeclaredAccessibility: Accessibility.Public }
                    )
                    {
                        viewModels.Add(namedType);
                    }

                    // Recursively process nested types
                    foreach (var nestedType in namedType.GetTypeMembers())
                    {
                        if (
                            nestedType.Name.EndsWith(ViewModelSuffix)
                            && nestedType
                                is {
                                    IsAbstract: false,
                                    DeclaredAccessibility: Accessibility.Public
                                }
                        )
                        {
                            viewModels.Add(nestedType);
                        }
                    }

                    break;
                }
                case INamespaceSymbol nestedNamespace:
                    GetViewModelsFromAssembly(nestedNamespace, viewModels);
                    break;
            }
        }
    }
}
