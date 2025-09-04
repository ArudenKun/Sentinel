using Avalonia.Collections;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Sentinel.Configuration;
using Sentinel.Dependency;
using Sentinel.ViewModels.Pages;
using ZLinq;

namespace Sentinel.ViewModels;

[DependencyLifetime(ServiceLifetime.Singleton)]
public sealed partial class MainViewModel : ViewModel
{
    private readonly ILogger<MainViewModel> _logger;

    public MainViewModel(
        Settings settings,
        IEnumerable<PageViewModel> pageViewModels,
        ILogger<MainViewModel> logger
    )
    {
        Settings = settings;
        _logger = logger;
        Pages = new AvaloniaList<PageViewModel>(pageViewModels);

        foreach (var page in Pages)
        {
            logger.LogInformation("Page: {Name} {Type}", page.DisplayName, page.GetType().FullName);
        }

        Page = Pages.AsValueEnumerable().First();
    }

    public Settings Settings { get; }

    public IAvaloniaReadOnlyList<PageViewModel> Pages { get; }

    [ObservableProperty]
    public partial PageViewModel Page { get; set; }

    [RelayCommand]
    private void ShowSettings()
    {
        _logger.LogInformation("Showing settings");
        Page = Pages.AsValueEnumerable().First(x => x is SettingsPageViewModel);
    }
}
