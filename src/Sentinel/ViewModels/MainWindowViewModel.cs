using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using Microsoft.Extensions.DependencyInjection;
using Sentinel.Configuration;
using Sentinel.Dependency;
using Sentinel.Models.Messages;
using SukiUI.Dialogs;
using SukiUI.Toasts;

namespace Sentinel.ViewModels;

[DependencyLifetime(ServiceLifetime.Singleton)]
public sealed partial class MainWindowViewModel : ViewModel, IRecipient<SplashFinishedMessage>
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

        ViewModel = serviceProvider.GetRequiredService<SplashViewModel>();
        Messenger.Register(this);
    }

    public ISukiToastManager ToastManager { get; }
    public ISukiDialogManager DialogManager { get; }
    public Settings Settings { get; }

    [ObservableProperty]
    public partial ViewModel ViewModel { get; set; }

    public void Receive(SplashFinishedMessage message)
    {
        ViewModel = _serviceProvider.GetRequiredService<MainViewModel>();
    }
}
