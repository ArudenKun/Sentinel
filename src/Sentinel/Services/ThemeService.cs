using Avalonia.Collections;
using Avalonia.Media;
using Avalonia.Styling;
using R3;
using Sentinel.Configuration;
using Sentinel.Dependency;
using Sentinel.Models;
using SukiUI;
using SukiUI.Enums;
using SukiUI.Models;
using ZLinq;

namespace Sentinel.Services;

public sealed class ThemeService : ISingletonDependency, IDisposable
{
    private readonly SukiTheme _sukiTheme;
    private readonly Settings _settings;
    private readonly IDisposable _subscriptions;

    public ThemeService(Settings settings)
    {
        _sukiTheme = SukiTheme.GetInstance();
        _settings = settings;

        _subscriptions = Disposable.Combine(
            _settings.UI.ObservePropertyChanged(x => x.Theme).Subscribe(ChangeTheme),
            _settings
                .UI.ObservePropertyChanged(x => x.ThemeColor)
                .Subscribe(colorThemeDisplayName =>
                {
                    if (!string.IsNullOrWhiteSpace(colorThemeDisplayName))
                        ChangeColorTheme(ResolveColorTheme(colorThemeDisplayName));
                })
        );
    }

    public Theme CurrentTheme => _settings.UI.Theme;

    public SukiColorTheme CurrentColorTheme => ResolveColorTheme(_settings.UI.ThemeColor);

    public IAvaloniaReadOnlyList<SukiColorTheme> ColorThemes => _sukiTheme.ColorThemes;

    public void Initialize()
    {
        _sukiTheme.AddColorThemes(
            [
                new SukiColorTheme(
                    "Pink",
                    new Color(255, 255, 20, 147),
                    new Color(255, 255, 192, 203)
                ),
            ]
        );
        ChangeTheme(_settings.UI.Theme);
        ChangeColorTheme(ResolveColorTheme(_settings.UI.ThemeColor));
    }

    public void ChangeTheme(Theme theme)
    {
        _settings.UI.Theme = theme;

        var variant = theme switch
        {
            Theme.Default => ThemeVariant.Default,
            Theme.Light => ThemeVariant.Light,
            Theme.Dark => ThemeVariant.Dark,
            _ => throw new ArgumentOutOfRangeException(nameof(theme), theme, null),
        };

        _sukiTheme.ChangeBaseTheme(variant);
    }

    public void ChangeColorTheme(SukiColorTheme colorTheme)
    {
        _settings.UI.ThemeColor = colorTheme.DisplayName;
        _sukiTheme.ChangeColorTheme(colorTheme);
    }

    private SukiColorTheme ResolveColorTheme(string? displayName)
    {
        if (string.IsNullOrWhiteSpace(displayName))
            return SukiTheme.DefaultColorThemes[SukiColor.Blue];

        return _sukiTheme
                .ColorThemes.AsValueEnumerable()
                .FirstOrDefault(theme =>
                    theme.DisplayName.Equals(displayName, StringComparison.OrdinalIgnoreCase)
                )
            ?? SukiTheme.DefaultColorThemes[SukiColor.Blue];
    }

    public void Dispose() => _subscriptions.Dispose();
}
