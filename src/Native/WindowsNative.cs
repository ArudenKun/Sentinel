using System;

namespace Sentinel.Native;

public class WindowsNative : INative
{
    public string GetOSVersionString() => $"Windows {Environment.OSVersion}";
}
