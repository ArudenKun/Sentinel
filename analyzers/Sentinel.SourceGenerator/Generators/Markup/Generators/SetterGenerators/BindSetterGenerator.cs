using Sentinel.SourceGenerator.Generators.Markup.ExtensionInfos;

namespace Sentinel.SourceGenerator.Generators.Markup.Generators.SetterGenerators;

public class BindSetterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string? GetExtension(PropertyExtensionInfo info)
    {
        // skip IBinding properties to avoid duplicates from other generators
        if (info.ValueType.Name == "IBinding")
            return null;

        return $"    public static {info.ReturnType} {info.ExtensionName}{info.GenericArg}(this {info.ReturnType} control, global::Avalonia.Data.IBinding binding){info.GenericConstraint}{Helper.NewLine}"
            + $"        => control._set({info.ControlTypeName}.{info.MemberName}Property, binding);";
    }
}
