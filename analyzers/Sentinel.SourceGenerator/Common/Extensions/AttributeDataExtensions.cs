using Microsoft.CodeAnalysis;

namespace Sentinel.SourceGenerator.Common.Extensions;

internal static class AttributeDataExtensions
{
    public static T MapToType<T>(this AttributeData attributeData)
        where T : Attribute
    {
        T attribute;
        if (attributeData is { AttributeConstructor: not null, ConstructorArguments.Length: > 0 })
        {
            attribute = (T)
                Activator.CreateInstance(
                    typeof(T),
                    attributeData.GetActualConstructorParams().ToArray()
                );
        }
        else
        {
            attribute = (T)Activator.CreateInstance(typeof(T));
        }

        foreach (var p in attributeData.NamedArguments)
        {
            typeof(T).GetField(p.Key).SetValue(attribute, p.Value.Value);
        }

        return attribute;
    }

    private static IEnumerable<object?> GetActualConstructorParams(this AttributeData attributeData)
    {
        foreach (var arg in attributeData.ConstructorArguments)
        {
            if (arg.Kind == TypedConstantKind.Array)
            {
                // Assume they are strings, but the array that we get from this
                // should actually be of type of the objects within it, be it strings or ints
                // This is definitely possible with reflection, I just don't know how exactly.
                yield return arg.Values.Select(a => a.Value).OfType<string>().ToArray();
            }
            else
            {
                yield return arg.Value;
            }
        }
    }
}
