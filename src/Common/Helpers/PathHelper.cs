using System;
using Sentinel.Common.Extensions;

namespace Sentinel.Common.Helpers;

public static class PathHelper
{
    public static readonly string RootDir = AppDomain.CurrentDomain.BaseDirectory;
    public static readonly string LogsDir = RootDir.CombinePath("logs");
    public static readonly string LogPath = LogsDir.CombinePath("log.txt");
    public static readonly string CacheDir = RootDir.CombinePath("cache");
}
