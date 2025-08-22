using System;

namespace Sentinel.Native;

public class LinuxNative : INative
{
    public string GetOSVersionString() => $"Linux {Environment.OSVersion}";
}
