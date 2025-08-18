using Mvvm.Navigation;
using Sentinel.ViewModels.Windows;
using Wpf.Ui;
using Wpf.Ui.Abstractions;
using Wpf.Ui.Appearance;
using Wpf.Ui.Controls;

namespace Sentinel.Views.Windows;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
[ViewFor<MainWindowViewModel>(
    ViewLifetime = ServiceLifetime.Singleton,
    ViewModelLifetime = ServiceLifetime.Singleton,
    ViewModel = true,
    ViewModelConstructor = true
)]
public sealed partial class MainWindow : INavigationWindow
{
    partial void BeforeInitializeComponent()
    {
        SystemThemeWatcher.Watch(this);
    }

    partial void AfterInitializeComponent()
    {
        ViewModel.NavigationService.SetNavigationControl(RootNavigation);
        ViewModel.SnackbarService.SetSnackbarPresenter(SnackbarPresenter);
        ViewModel.ContentDialogService.SetDialogHost(RootContentDialog);
    }

    public INavigationView GetNavigation() => RootNavigation;

    public bool Navigate(Type pageType) => RootNavigation.Navigate(pageType);

    public void SetServiceProvider(IServiceProvider serviceProvider) =>
        RootNavigation.SetServiceProvider(serviceProvider);

    public void SetPageService(INavigationViewPageProvider navigationViewPageProvider) =>
        RootNavigation.SetPageProviderService(navigationViewPageProvider);

    public void ShowWindow() => Show();

    public void CloseWindow() => Close();
}
