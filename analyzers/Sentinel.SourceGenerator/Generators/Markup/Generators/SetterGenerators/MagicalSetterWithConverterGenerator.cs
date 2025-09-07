using Sentinel.SourceGenerator.Generators.Markup.ExtensionInfos;

namespace Sentinel.SourceGenerator.Generators.Markup.Generators.SetterGenerators;

public sealed class MagicalSetterWithConverterGenerator
    : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string GetExtension(PropertyExtensionInfo info) =>
        $"[Obsolete]{Helper.NewLine}"
        + $"public static {info.ReturnType} {info.ExtensionName}<TValue{(!info.IsGeneric ? "" : "," + info.ReturnType)}>"
        + $"(this {info.ReturnType} control, "
        + $"TValue value, FuncValueConverter<TValue, {info.ValueTypeSource}> converter, BindingMode? bindingMode = null, object? bindingSource = null,"
        + $" [CallerArgumentExpression(nameof(value))] string? ps = null) {info.GenericConstraint} {Helper.NewLine}"
        + $"=> control._setEx({info.ControlTypeName}.{info.MemberName}Property, ps, () => control.{info.ExtensionName} = converter.TryConvert(value)!, bindingMode, converter, bindingSource);";
}
