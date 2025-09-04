using Sentinel.Common.Extensions;

namespace Sentinel.Common.Helpers;

public static class AppHelper
{
    public const string Name = nameof(Sentinel);

    public static bool IsDebug
#if DEBUG
        => true;
#else
        => false;
#endif

    public static readonly string AppDir = AppDomain.CurrentDomain.BaseDirectory;

    public static readonly string RoamingDir = Environment.GetFolderPath(
        Environment.SpecialFolder.ApplicationData
    );

    public static readonly string DataDir =
        File.Exists(AppDir.CombinePath("data")) || IsDebug
            ? AppDir.CombinePath("data")
            : RoamingDir.CombinePath(Name);

    public static readonly string LogsDir = DataDir.CombinePath("logs");

    public static readonly string SettingsPath = DataDir.CombinePath("settings.json");
}
