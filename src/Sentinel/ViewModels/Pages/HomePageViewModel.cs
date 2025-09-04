using Lucide.Avalonia;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Sentinel.Dependency;

namespace Sentinel.ViewModels.Pages;

[DependencyLifetime(ServiceLifetime.Singleton)]
public sealed partial class HomePageViewModel : PageViewModel
{
    private readonly ILogger<HomePageViewModel> _logger;

    public HomePageViewModel(ILogger<HomePageViewModel> logger)
    {
        _logger = logger;
    }

    public override int Index => 1;
    public override string DisplayName => "Home";
    public override LucideIconKind IconKind => LucideIconKind.House;
}
