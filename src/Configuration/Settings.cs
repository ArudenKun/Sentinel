using System.Globalization;
using System.Text.Json.Serialization;
using Cogwheel;
using CommunityToolkit.Mvvm.ComponentModel;
using Sentinel.Common.Extensions;
using Sentinel.Common.Helpers;
using Sentinel.Common.JsonConverters;
using Sentinel.Dependency;

namespace Sentinel.Configuration;

[INotifyPropertyChanged]
public sealed partial class Settings : SettingsBase, ISingletonDependency
{
    public Settings()
        : base(PathHelper.RootDir.CombinePath("settings.json"), SettingsJsonContext.Default) { }

    [ObservableProperty]
    [JsonConverter(typeof(CultureInfoJsonConverter))]
    public partial CultureInfo Language { get; set; } = CultureInfo.CurrentUICulture;

    [JsonSerializable(typeof(Settings))]
    [JsonSourceGenerationOptions(WriteIndented = true, UseStringEnumConverter = true)]
    private sealed partial class SettingsJsonContext : JsonSerializerContext;
}
