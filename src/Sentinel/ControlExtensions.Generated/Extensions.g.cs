using Avalonia.Controls;
using Avalonia.Markup.Xaml.MarkupExtensions;
using Avalonia.Styling;

namespace Avalonia.Markup.Declarative;

public static class Extensions
{
    public static T DynamicResource<T>(this T control, AvaloniaProperty prop, object resourceKey)
        where T : Control
    {
        control[!prop] = new DynamicResourceExtension(resourceKey);
        return control;
    }

    public static Style DynamicResource(this Style style, AvaloniaProperty prop, object resourceKey)
    {
        style.Setters.Add(
            new Setter() { Property = prop, Value = new DynamicResourceExtension(resourceKey) }
        );
        return style;
    }
}
