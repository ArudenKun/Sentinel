using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.DependencyInjection;
using Sentinel.Configuration;
using Sentinel.Dependency;
using SukiUI.Dialogs;
using SukiUI.Toasts;

namespace Sentinel.ViewModels;

[DependencyLifetime(ServiceLifetime.Singleton)]
public sealed partial class MainWindowViewModel : ViewModel
{
    private readonly IServiceProvider _serviceProvider;

    public MainWindowViewModel(
        ISukiToastManager toastManager,
        ISukiDialogManager dialogManager,
        Settings settings,
        IServiceProvider serviceProvider
    )
    {
        _serviceProvider = serviceProvider;
        ToastManager = toastManager;
        DialogManager = dialogManager;
        Settings = settings;

        ViewModel = serviceProvider.GetRequiredService<MainViewModel>();
    }

    public ISukiToastManager ToastManager { get; }
    public ISukiDialogManager DialogManager { get; }
    public Settings Settings { get; }

    [ObservableProperty]
    public partial ViewModel ViewModel { get; set; }
}
