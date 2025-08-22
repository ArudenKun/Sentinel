using System;

namespace Sentinel.Native;

// ReSharper disable once InconsistentNaming
public class MacOSNative : INative
{
    public string GetOSVersionString() => $"MacOS {Environment.OSVersion}";
}
