using Sentinel.SourceGenerator.Generators.Markup.ExtensionInfos;

namespace Sentinel.SourceGenerator.Generators.Markup.Generators.SetterGenerators;

public class BindFromExpressionSetterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string GetExtension(PropertyExtensionInfo info) =>
        $"public static {info.ReturnType} {info.ExtensionName}{info.GenericArg}(this {info.ReturnType} control, Func<{info.ValueTypeSource}> func, Action<{info.ValueTypeSource}>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) {info.GenericConstraint} {Helper.NewLine}"
        + $"   => control._set({info.ControlTypeName}.{info.MemberName}Property, func, onChanged, expression);";
}
