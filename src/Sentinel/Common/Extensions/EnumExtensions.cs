using ZLinq;

namespace Sentinel.Common.Extensions;

public static class EnumExtensions
{
    public static IEnumerable<Enum> GetAllValues(this Enum @enum) => @enum.GetType().GetAllValues();

    public static IEnumerable<Enum> GetAllValues(this Type t, bool orderByName = false)
    {
        if (!t.IsEnum)
            throw new ArgumentException($"{nameof(t)} must be an enum type");

        var names = orderByName
            ? Enum.GetNames(t)
                .AsValueEnumerable()
                .OrderBy(e => e.ToString(), StringComparer.Ordinal)
                .ToArray()
            : Enum.GetNames(t).AsValueEnumerable().ToArray();

        foreach (var name in names)
        {
            yield return (Enum)Enum.Parse(t, name);
        }
    }

    public static IEnumerable<TEnum> GetAllValues<TEnum>(bool orderByName = false)
        where TEnum : struct, Enum
    {
        var values = Enum.GetValues<TEnum>();
        return orderByName
            ? values.OrderBy(e => e.ToString(), StringComparer.Ordinal).ToArray()
            : values;
    }
}
