using System.Text;
using Microsoft.CodeAnalysis;
using Sentinel.SourceGenerator.Generators.Markup.ExtensionInfos;

namespace Sentinel.SourceGenerator.Generators.Markup.Generators;

public sealed class ExtensionGroupGenerator(
    string groupName,
    Func<INamedTypeSymbol, IEnumerable<IMemberExtensionInfo>> membersQuery,
    params ExtensionGeneratorBase[] generators
)
{
    public string GroupName { get; } = groupName;

    public string? Generate(INamedTypeSymbol avaloniaControlType, out int generationsCount)
    {
        generationsCount = 0;

        var sb = new StringBuilder();
        foreach (var extensionInfo in membersQuery(avaloniaControlType))
        {
            sb.Append($"    // {extensionInfo.MemberName}{Helper.NewLine}");

            foreach (var generator in generators)
            {
                var extensionCode = generator.GetExtension(extensionInfo);
                if (!string.IsNullOrWhiteSpace(extensionCode))
                {
                    sb.Append(Helper.NewLine);
                    sb.Append($"    /*{generator.GetType().Name}*/{Helper.NewLine}");
                    sb.Append(extensionCode + Helper.NewLine);
                    generationsCount++;
                }
            }

            sb.Append(Helper.NewLine);
            sb.Append(Helper.NewLine);
        }

        return generationsCount == 0 ? null : sb.ToString();
    }
}
