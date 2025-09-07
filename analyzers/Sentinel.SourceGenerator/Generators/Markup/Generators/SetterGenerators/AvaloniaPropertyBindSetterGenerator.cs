using Sentinel.SourceGenerator.Generators.Markup.ExtensionInfos;

namespace Sentinel.SourceGenerator.Generators.Markup.Generators.SetterGenerators;

public sealed class AvaloniaPropertyBindSetterGenerator
    : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string GetExtension(PropertyExtensionInfo info) =>
        $"public static {info.ReturnType} {info.ExtensionName}{info.GenericArg}(this {info.ReturnType} control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) {info.GenericConstraint} {Helper.NewLine}"
        + $"   => control._set({info.ControlTypeName}.{info.MemberName}Property, avaloniaProperty, bindingMode, converter, overrideView);";
}
