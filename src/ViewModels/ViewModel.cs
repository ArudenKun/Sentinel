using CommunityToolkit.Mvvm.ComponentModel;

namespace Sentinel.ViewModels;

public abstract class ViewModel : ObservableObject
{
    public string AppTitle { get; } = nameof(Sentinel);
}
