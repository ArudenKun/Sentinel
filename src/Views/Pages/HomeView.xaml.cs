using Mvvm.Navigation;
using Sentinel.ViewModels.Pages;

namespace Sentinel.Views.Pages;

[ViewFor<HomeViewModel>(
    ViewModel = true,
    ViewModelConstructor = true,
    ViewLifetime = ServiceLifetime.Transient,
    ViewModelLifetime = ServiceLifetime.Transient
)]
public partial class HomeView
{
    public HomeView()
    {
        InitializeComponent();
    }
}
