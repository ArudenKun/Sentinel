using CommunityToolkit.Mvvm.ComponentModel;
using Sentinel.Common.Extensions;
using Sentinel.Common.Helpers;
using Sentinel.Models;

namespace Sentinel.Configuration;

public sealed partial class DatabaseSettings : ObservableObject
{
    [ObservableProperty]
    public partial DatabaseType Type { get; set; } = DatabaseType.Sqlite;

    [ObservableProperty]
    public partial string ConnectionString { get; set; } =
        AppHelper.DataDir.CombinePath($"{AppHelper.Name}.db");

    partial void OnTypeChanged(DatabaseType value)
    {
        Console.WriteLine($"TypeChanged: {value}");
    }
}
