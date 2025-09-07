using Sentinel.SourceGenerator.Generators.Markup.ExtensionInfos;

namespace Sentinel.SourceGenerator.Generators.Markup.Generators.StyleSetterGenerators;

public class BindingStyleSetterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string GetExtension(PropertyExtensionInfo info)
    {
        if (info.ValueType.Name == "IBinding")
            return $"//Skipped {info.ExtensionName} because already exist in value setters";

        //direct type access
        var extensionText =
            $"    public static global::Avalonia.Markup.Declarative.Style<{info.ReturnType}> {info.ExtensionName}{info.GenericArg}(this global::Avalonia.Markup.Declarative.Style<{info.ReturnType}> style, global::Avalonia.Data.IBinding binding){info.GenericConstraint}{Helper.NewLine}"
            + $"        => style._addSetter({info.ControlTypeName}.{info.MemberName}Property, binding);";

        return extensionText;
    }
}
