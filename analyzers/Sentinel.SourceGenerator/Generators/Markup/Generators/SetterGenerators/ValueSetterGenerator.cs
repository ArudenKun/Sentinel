using Sentinel.SourceGenerator.Generators.Markup.ExtensionInfos;

namespace Sentinel.SourceGenerator.Generators.Markup.Generators.SetterGenerators;

public class ValueSetterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string GetExtension(PropertyExtensionInfo info) =>
        $"    /// <summary>{info.Comment}</summary>{Helper.NewLine}"
        + $"    public static {info.ReturnType} {info.ExtensionName}{info.GenericArg}(this {info.ReturnType} control, {info.ValueTypeSource} value){info.GenericConstraint}{Helper.NewLine}"
        + $"        => control._set(() => control.{info.MemberName} = value!);";
}
