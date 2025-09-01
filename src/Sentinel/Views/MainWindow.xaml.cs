using Mvvm.Navigation;
using Sentinel.ViewModels;

namespace Sentinel.Views;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
[ViewFor<MainWindowViewModel>(
    ViewModel = true,
    ViewModelConstructor = true,
    ViewLifetime = ServiceLifetime.Singleton,
    ViewModelLifetime = ServiceLifetime.Singleton
)]
public partial class MainWindow
{
    public MainWindow()
    {
        InitializeComponent();
    }
}
