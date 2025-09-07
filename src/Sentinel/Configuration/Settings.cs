using System.Text.Json.Serialization;
using Cogwheel;
using CommunityToolkit.Mvvm.ComponentModel;
using Sentinel.Common.Helpers;
using Sentinel.Dependency;
using Serilog.Events;

namespace Sentinel.Configuration;

[ObservableObject]
public sealed partial class Settings : SettingsBase, ISingletonDependency, IDisposable
{
    public Settings()
        : base(AppHelper.SettingsPath, SettingsJsonContext.Default)
    {
        Load();
    }

    [ObservableProperty]
    public partial LogEventLevel LogLevel { get; set; } =
        AppHelper.IsDebug ? LogEventLevel.Verbose : LogEventLevel.Information;

    [ObservableProperty]
    public partial DateTime LastUpdateCheck { get; set; }

    [ObservableProperty]
    public partial DatabaseSettings Database { get; set; } = new();

    [ObservableProperty]
    // ReSharper disable once InconsistentNaming
    public partial UISettings UI { get; set; } = new();

    public void Dispose() => Save();

    [JsonSerializable(typeof(Settings))]
    [JsonSourceGenerationOptions(WriteIndented = true, UseStringEnumConverter = true)]
    private sealed partial class SettingsJsonContext : JsonSerializerContext;
}
