using Sentinel.SourceGenerator.Generators.Markup.ExtensionInfos;

namespace Sentinel.SourceGenerator.Generators.Markup.Generators.StyleSetterGenerators;

public class ValueStyleSetterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string GetExtension(PropertyExtensionInfo info)
    {
        //    public static Style<TElement> Background<TElement>(this Style<TElement> style, Brush brush) where TElement : TemplatedControl =>
        //        AddSetter(style, new Setter(TemplatedControl.BackgroundProperty, brush));

        if (info.ValueTypeSource.ToString() == "IBinding")
        {
            return "// Skipped as return type is IBinding";
        }

        //direct type access
        var extensionText =
            $"    public static global::Avalonia.Markup.Declarative.Style<{info.ReturnType}> {info.ExtensionName}{info.GenericArg}(this global::Avalonia.Markup.Declarative.Style<{info.ReturnType}> style, {info.ValueTypeSource} value){info.GenericConstraint}{Helper.NewLine}"
            + $"        => style._addSetter({info.ControlTypeName}.{info.MemberName}Property!, value!);";

        return extensionText;
    }
}
