using Avalonia.Data.Converters;
using Sentinel.Common.Extensions;
using ZLinq;

namespace Sentinel.Converters;

public static class EnumConverters
{
    public static readonly IValueConverter ToCollection = new FuncValueConverter<
        object?,
        IEnumerable<Enum>?
    >(value => value?.GetType().GetAllValues());

    public static readonly IValueConverter ParseString = new FuncValueConverter<object?, Enum?>(
        value =>
            value
                ?.GetType()
                .GetAllValues()
                .AsValueEnumerable()
                .FirstOrDefault(@enum => Equals(@enum, value))
    );
}
