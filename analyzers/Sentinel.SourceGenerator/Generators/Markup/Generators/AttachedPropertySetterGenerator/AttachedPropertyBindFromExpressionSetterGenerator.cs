using Sentinel.SourceGenerator.Generators.Markup.ExtensionInfos;

namespace Sentinel.SourceGenerator.Generators.Markup.Generators.AttachedPropertySetterGenerator;

public sealed class AttachedPropertyBindFromExpressionSetterGenerator
    : ExtensionGeneratorBase<AttachedPropertyExtensionInfo>
{
    protected override string GetExtension(AttachedPropertyExtensionInfo info) =>
        $"""
            public static {info.ReturnType} {info.ExtensionName}{info.GenericArg}(this {info.ReturnType} control, Func<{info.ValueTypeSource}> func, Action<{info.ValueTypeSource}>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)
                where T : {info.AttachedPropertyHostTypeName} {Helper.NewLine}
                => control._set({info.ControlTypeName}.{info.MemberName}Property, func, onChanged, expression);
            """;
}
