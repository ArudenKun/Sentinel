using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using AsyncAwaitBestPractices;
using Sentinel.Common.Utilities;

namespace Sentinel.Localization;

public class Localizer : Singleton<Localizer>
{
    private readonly WeakEventManager _cultureChangedEventManager = new();
    private readonly IReadOnlyList<CultureInfo> _cultures;

    public Localizer()
    {
        _cultures = Locale
            .GetCultures()
            .Select(x => string.IsNullOrWhiteSpace(x.Name) ? new CultureInfo("en-US") : x)
            .DistinctBy(x => x.Name)
            .ToList()
            .AsReadOnly();
    }

    public event EventHandler CultureChanged
    {
        add => _cultureChangedEventManager.AddEventHandler(value);
        remove => _cultureChangedEventManager.RemoveEventHandler(value);
    }

    private void OnCultureChanged() =>
        _cultureChangedEventManager.RaiseEvent(Instance, EventArgs.Empty, nameof(CultureChanged));

    public static IReadOnlyList<CultureInfo> Cultures => Instance._cultures;

    public static CultureInfo Culture
    {
        get => CultureInfo.CurrentUICulture;
        set => ChangeCulture(value);
    }

    public static string Get(string key) => Locale.GetString(key);

    public static void ChangeCulture(CultureInfo culture)
    {
        CultureInfo.CurrentCulture = culture;
        CultureInfo.CurrentUICulture = culture;
        Instance.OnCultureChanged();
    }
}
