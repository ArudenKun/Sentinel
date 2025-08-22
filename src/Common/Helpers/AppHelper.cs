using System;

namespace Sentinel.Common.Helpers;

public static class AppHelper
{
    public static readonly string Name = nameof(Sentinel);

    public static readonly Version Version =
        typeof(AppHelper).Assembly.GetName().Version ?? new Version(0, 0, 0);

    public static readonly string VersionString = "v" + Version;
}
