using Microsoft.CodeAnalysis;
using Sentinel.SourceGenerator.Generators.Markup.ExtensionInfos;

namespace Sentinel.SourceGenerator.Generators.Markup.Generators.SetterGenerators;

public class ValueOverloadsSetterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
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
                    Helper.NewLine
                    + $"    public static {info.ReturnType} {info.ExtensionName}{info.GenericArg}(this {info.ReturnType} control, {argDefs}){info.GenericConstraint}{Helper.NewLine}"
                    + $"        => control._set(() => control.{info.MemberName} = new {info.ValueTypeSource}({argVals}));";
            }
        }
        return extensionText;
    }
}
