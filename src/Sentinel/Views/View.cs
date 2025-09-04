using Avalonia.Interactivity;
using Avalonia.Markup.Declarative;
using Sentinel.ViewModels;

namespace Sentinel.Views;

public abstract class View<TViewModel> : ViewBase
    where TViewModel : ViewModel
{
    protected View()
        : base(true) { }

    protected TViewModel ViewModel
    {
        get =>
            DataContext as TViewModel
            ?? throw new InvalidCastException(
                $"DataContext is null or not of the expected type '{typeof(TViewModel).FullName}'."
            );
        set => DataContext = value;
    }

    protected override void OnDataContextChanged(EventArgs e)
    {
        base.OnDataContextChanged(e);
        if (DataContext is not null)
        {
            Initialize();
        }
    }

    protected override void OnLoaded(RoutedEventArgs e)
    {
        base.OnLoaded(e);
        ViewModel.OnLoaded();
    }

    protected override void OnUnloaded(RoutedEventArgs e)
    {
        base.OnUnloaded(e);
        ViewModel.OnUnloaded();
    }

    protected abstract object Build(TViewModel vm);

    protected override object Build() => Build(ViewModel);
}
