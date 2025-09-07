using Avalonia.Collections;
using CommunityToolkit.Mvvm.ComponentModel;
using Lucide.Avalonia;
using Microsoft.Extensions.DependencyInjection;
using R3;
using Sentinel.Common.Extensions;
using Sentinel.Configuration;
using Sentinel.Dependency;
using Sentinel.Models;
using Sentinel.Services;
using SukiUI.Models;

namespace Sentinel.ViewModels.Pages;

[DependencyLifetime(ServiceLifetime.Singleton)]
public sealed partial class SettingsPageViewModel : PageViewModel
{
    private readonly ThemeService _themeService;

    public SettingsPageViewModel(Settings settings, ThemeService themeService)
    {
        Settings = settings;
        _themeService = themeService;

        IsVisibleOnSideMenu = false;

        Settings
            .Database.ObservePropertyChanged(x => x.Type)
            .Subscribe(x =>
            {
                IsSqlite = x is DatabaseType.Sqlite;
                IsSqlServer = x is DatabaseType.SqlServer;
            })
            .AddTo(this);
    }

    public override int Index => -1;
    public override string DisplayName => "Settings";
    public override LucideIconKind IconKind => LucideIconKind.Settings;

    public Settings Settings { get; }

    public IAvaloniaReadOnlyList<SukiColorTheme> ColorThemes => _themeService.ColorThemes;

    [ObservableProperty]
    public partial bool IsSqlite { get; set; }

    [ObservableProperty]
    public partial bool IsSqlServer { get; set; }
}
