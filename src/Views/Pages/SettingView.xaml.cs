using System.Windows.Controls;
using Mvvm.Navigation;
using Sentinel.ViewModels.Pages;

namespace Sentinel.Views.Pages;

[ViewFor<SettingViewModel>(
    ViewModel = true,
    ViewModelConstructor = true,
    ViewLifetime = ServiceLifetime.Singleton,
    ViewModelLifetime = ServiceLifetime.Singleton
)]
public partial class SettingView
{
    public SettingView()
    {
        InitializeComponent();
    }
}
