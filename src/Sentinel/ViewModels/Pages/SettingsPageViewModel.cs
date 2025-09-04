using Avalonia.Collections;
using Lucide.Avalonia;
using Microsoft.Extensions.DependencyInjection;
using Sentinel.Configuration;
using Sentinel.Dependency;
using Sentinel.Services;
using SukiUI.Models;

namespace Sentinel.ViewModels.Pages;

[DependencyLifetime(ServiceLifetime.Singleton)]
public sealed class SettingsPageViewModel : PageViewModel
{
    private readonly ThemeService _themeService;

    public SettingsPageViewModel(Settings settings, ThemeService themeService)
    {
        Settings = settings;
        _themeService = themeService;

        IsVisibleOnSideMenu = false;
    }

    public override int Index => -1;
    public override string DisplayName => "Settings";
    public override LucideIconKind IconKind => LucideIconKind.Settings;

    public Settings Settings { get; }

    public IAvaloniaReadOnlyList<SukiColorTheme> ColorThemes => _themeService.ColorThemes;
}
