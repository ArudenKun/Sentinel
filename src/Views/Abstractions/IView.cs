using Sentinel.ViewModels;

namespace Sentinel.Views.Abstractions;

public interface IView<out TViewModel>
    where TViewModel : ViewModel
{
    TViewModel DataContext { get; }
    TViewModel ViewModel { get; }
}
