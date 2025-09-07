using System.Collections.Immutable;
using System.Text;
using Microsoft.CodeAnalysis;
using Sentinel.SourceGenerator.Generators.Markup.ExtensionInfos;
using Sentinel.SourceGenerator.Generators.Markup.Generators;
using Sentinel.SourceGenerator.Generators.Markup.Generators.AttachedPropertySetterGenerator;
using Sentinel.SourceGenerator.Generators.Markup.Generators.EventGenerators;
using Sentinel.SourceGenerator.Generators.Markup.Generators.SetterGenerators;
using Sentinel.SourceGenerator.Generators.Markup.Generators.StyleSetterGenerators;

namespace Sentinel.SourceGenerator.Generators.Markup;

public sealed class GeneratorHost
{
    private readonly List<ExtensionGroupGenerator> _groupGenerators =
    [
        new(
            "Properties",
            t =>
                t.GetMembers()
                    .OfType<IFieldSymbol>()
                    .Where(x => x.IsAvaloniaPropertyField() && x.IsNotConflictingExtension())
                    .Select(x => new PropertyExtensionInfo(x)),
            new ValueSetterGenerator(),
            new BindFromExpressionSetterGenerator(),
            new ValueOverloadsSetterGenerator(),
            //obsolete candidates
            new MagicalSetterGenerator(),
            new BindSetterGenerator(),
            new AvaloniaPropertyBindSetterGenerator(),
            new MagicalSetterWithConverterGenerator()
        ),
        new(
            "Attached Properties",
            t =>
                t.GetMembers()
                    .OfType<IFieldSymbol>()
                    .Where(x => x.IsAttachedPropertyField() && x.IsNotConflictingExtension())
                    .Select(x => new AttachedPropertyExtensionInfo(x))
                    .Where(x =>
                    {
                        var props = t.GetMembers().OfType<IMethodSymbol>();

                        var found = props.FirstOrDefault(y =>
                            y.Name.RemoveTrailingProperty()
                            == "Set" + x.MemberName.RemoveTrailingProperty()
                        );

                        if (found != null)
                        {
                            var paramType = found.Parameters[0].Type;

                            var tName = t.IsOrInheritsFrom(paramType);

                            return tName;
                        }

                        return false;
                    }),
            new AttachedPropertyBindFromExpressionSetterGenerator(),
            new AttachedPropertyMagicalSetterGenerator()
        ),
        new(
            "Common Properties",
            t =>
                t.GetMembers()
                    .OfType<IPropertySymbol>()
                    .Where(x =>
                        !x.IsAvaloniaProperty()
                        && x.IsCommonProperty()
                        && x.IsNotConflictingExtension()
                    )
                    .Select(x => new PropertyExtensionInfo(x)),
            new ValueSetterGenerator()
        ),
        new(
            "Events",
            t =>
                t.GetAllMembers()
                    .OfType<IEventSymbol>()
                    .Where(x =>
                        x.DeclaredAccessibility == Accessibility.Public
                        && SymbolEqualityComparer.Default.Equals(x.ContainingType, t)
                    )
                    .Select(x => new EventExtensionInfo(x)),
            new ActionToEventGenerator()
        ),
        new(
            "Styles",
            t =>
                !t.IsStyledElement()
                    ? []
                    : t.GetMembers()
                        .OfType<IFieldSymbol>()
                        .Where(x => x.IsAcceptableStyledField() && x.IsNotConflictingExtension())
                        .Select(x => new PropertyExtensionInfo(x)),
            new ValueStyleSetterGenerator(),
            new BindingStyleSetterGenerator(),
            new ValueOverloadsStyleSetterGenerator()
        ),
    ];

    public string? GenerateExtensions(INamedTypeSymbol controlType)
    {
        var extensionGroups = _groupGenerators
            .Select(x =>
            {
                var extensions = x.Generate(controlType, out var generationsCount);
                return (x.GroupName, Extensions: extensions, Amount: generationsCount);
            })
            .ToImmutableList();

        //skip types without extensions
        if (extensionGroups.All(x => x.Amount == 0))
            return null;

        var sb = new StringBuilder();
        sb.Append("#nullable enable" + Helper.NewLine);
        sb.Append(Helper.NewLine);
        sb.AppendLine("using System.Runtime.CompilerServices;");
        sb.AppendLine("using Avalonia.Controls;");
        sb.AppendLine("using Avalonia.Controls.Templates;");
        sb.AppendLine("using Avalonia.Data;");
        sb.AppendLine("using Avalonia.Data.Converters;");
        sb.AppendLine("using Avalonia.Layout;");
        sb.AppendLine("using Avalonia.Styling;");
        sb.Append(Helper.NewLine);
        sb.Append("namespace Avalonia.Markup.Declarative;" + Helper.NewLine);
        sb.Append(Helper.NewLine);
        sb.Append(
            $"public static partial class {controlType.Name.CleanIdentifier()}Extensions"
                + Helper.NewLine
        );
        sb.Append("{" + Helper.NewLine);

        foreach (var group in extensionGroups.Where(x => x.Extensions != null))
        {
            sb.Append(
                $"    //================= {group.GroupName} ======================//"
                    + Helper.NewLine
            );
            sb.Append(group.Extensions + Helper.NewLine);
        }

        sb.Append("}");

        return sb.ToString();
    }
}
