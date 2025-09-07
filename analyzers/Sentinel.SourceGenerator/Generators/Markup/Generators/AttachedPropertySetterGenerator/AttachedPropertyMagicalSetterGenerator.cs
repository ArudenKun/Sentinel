using Sentinel.SourceGenerator.Generators.Markup.ExtensionInfos;

namespace Sentinel.SourceGenerator.Generators.Markup.Generators.AttachedPropertySetterGenerator;

public sealed class AttachedPropertyMagicalSetterGenerator
    : ExtensionGeneratorBase<AttachedPropertyExtensionInfo>
{
    protected override string GetExtension(AttachedPropertyExtensionInfo info) =>
        $"public static T {info.ExtensionName}<T>"
        + $"(this T control, "
        + $"{info.ValueTypeSource} value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null,"
        + $" [CallerArgumentExpression(nameof(value))] string? ps = null)"
        + $" where T : {info.AttachedPropertyHostTypeName}{Helper.NewLine}"
        + $" => control._setEx({info.ControlTypeName}.{info.MemberName}Property, ps, () => {info.ControlTypeName}.Set{info.MemberName}(control, value), bindingMode, converter, bindingSource);";
}
