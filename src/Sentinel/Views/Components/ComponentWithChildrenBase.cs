using Avalonia;
using Avalonia.Markup.Declarative;

namespace Sentinel.Views.Components;

public abstract class ComponentWithChildrenBase : ComponentBase
{
    public static readonly StyledProperty<Avalonia.Controls.Controls> ChildrenProperty =
        AvaloniaProperty.Register<ComponentWithChildrenBase, Avalonia.Controls.Controls>(
            nameof(Children),
            []
        );

    public Avalonia.Controls.Controls Children
    {
        get => GetValue(ChildrenProperty);
        set => SetValue(ChildrenProperty, value);
    }
}
