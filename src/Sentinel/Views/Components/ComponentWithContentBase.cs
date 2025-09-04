using Avalonia;
using Avalonia.Markup.Declarative;

namespace Sentinel.Views.Components;

public abstract class ComponentWithContentBase : ComponentBase
{
    public static readonly StyledProperty<object?> ContentProperty = AvaloniaProperty.Register<
        ComponentWithContentBase,
        object?
    >(nameof(Content));

    public object? Content
    {
        get => GetValue(ContentProperty);
        set => SetValue(ContentProperty, value);
    }
}
