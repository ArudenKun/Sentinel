using Sentinel.SourceGenerator.Generators.Markup.ExtensionInfos;

namespace Sentinel.SourceGenerator.Generators.Markup.Generators.SetterGenerators;

public class MagicalSetterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string GetExtension(PropertyExtensionInfo info) =>
        $"[Obsolete]{Helper.NewLine}"
        + $"public static {info.ReturnType} {info.ExtensionName}{info.GenericArg}"
        + $"(this {info.ReturnType} control,"
        + $"{info.ValueTypeSource} value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null,"
        + $" [CallerArgumentExpression(nameof(value))] string? ps = null) {info.GenericConstraint} {Helper.NewLine}"
        + $"=> control._setEx({info.ControlTypeName}.{info.MemberName}Property, ps, () => control.{info.MemberName} = value!, bindingMode, converter, bindingSource);";
}
