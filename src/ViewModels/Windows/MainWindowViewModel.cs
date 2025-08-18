using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;
using Mvvm.Navigation;
using Sentinel.Views.Pages;
using Wpf.Ui;
using Wpf.Ui.Controls;

namespace Sentinel.ViewModels.Windows;

public sealed partial class MainWindowViewModel : ViewModel, IActivatable
{
    public MainWindowViewModel(
        INavigationService navigationService,
        ISnackbarService snackbarService,
        IContentDialogService contentDialogService
    )
    {
        NavigationService = navigationService;
        SnackbarService = snackbarService;
        ContentDialogService = contentDialogService;
    }

    public INavigationService NavigationService { get; }
    public ISnackbarService SnackbarService { get; }
    public IContentDialogService ContentDialogService { get; }
    public ObservableCollection<NavigationViewItem> Pages { get; } =
    [
        new()
        {
            Content = "Home",
            Icon = new SymbolIcon { Symbol = SymbolRegular.Home24 },
            TargetPageType = typeof(HomeView),
        },
    ];

    public ObservableCollection<NavigationViewItem> Footers { get; } =
    [
        new()
        {
            Content = "Settings",
            Icon = new SymbolIcon { Symbol = SymbolRegular.Settings24 },
            TargetPageType = typeof(SettingView),
        },
    ];

    [RelayCommand]
    private void ShowException()
    {
        SnackbarService.Show(
            "Test",
            "Test Message",
            ControlAppearance.Info,
            null,
            TimeSpan.FromSeconds(5)
        );
        // throw new NotImplementedException("Testing");
    }

    public void Activate()
    {
        NavigationService.Navigate(typeof(HomeView));
    }

    public void Deactivate() { }
}
