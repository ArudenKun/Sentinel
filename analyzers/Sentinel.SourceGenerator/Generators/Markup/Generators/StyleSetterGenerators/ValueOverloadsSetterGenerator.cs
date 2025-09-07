using Microsoft.CodeAnalysis;
using Sentinel.SourceGenerator.Generators.Markup.ExtensionInfos;

namespace Sentinel.SourceGenerator.Generators.Markup.Generators.StyleSetterGenerators;

public class ValueOverloadsStyleSetterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string GetExtension(PropertyExtensionInfo info)
    {
        var extensionText = "";
        // overloads for primitive types like margin
        if (
            !info.ValueType.ContainingNamespace.ToString().StartsWith("System")
            && info.ValueType.IsValueType
            && info.ValueType.GetMembers()
                .OfType<IMethodSymbol>()
                .Count(m => m.MethodKind == MethodKind.Constructor) > 1
        )
        {
            foreach (
                var constructor in info
                    .ValueType.GetMembers()
                    .OfType<IMethodSymbol>()
                    .Where(m => m.MethodKind == MethodKind.Constructor)
            )
            {
                var ps = constructor.Parameters;
                if (ps.Length == 0)
                {
                    continue;
                }
                var argDefs = string.Join(
                    ", ",
                    ps.Select(x => $"{x.Type.GetFullTypeName()} {x.Name}")
                );
                var argVals = string.Join(", ", ps.Select(x => x.Name));
                ;

                extensionText +=
                    $"    public static global::Avalonia.Markup.Declarative.Style<{info.ReturnType}> {info.ExtensionName}{info.GenericArg}(this global::Avalonia.Markup.Declarative.Style<{info.ReturnType}> style, {argDefs}){info.GenericConstraint}{Helper.NewLine}"
                    + $"        => style._addSetter({info.ControlTypeName}.{info.MemberName}Property, new {info.ValueTypeSource}({argVals}));{Helper.NewLine}";
            }
        }
        return extensionText;
    }
}
