using System;
using System.Runtime.InteropServices;

using Xunit;

public class RunningOnOS
{
    private bool InWindows { get { return Environment.OSVersion.VersionString.Contains("Win"); } }

    // Build container before test run from Developer powershell (Ctrl+`):
    // docker build -t testenv -f testenv.Dockerfile .
    [SkippableFact]
    public void IsRunningOnLinux()
    {
        Skip.If(InWindows, "Linux test, skip if in Windows environment");
        Assert.True(RuntimeInformation.IsOSPlatform(OSPlatform.Linux));
    }

    [SkippableFact]
    public void IsRunningOnWindows()
    {
        Skip.IfNot(InWindows, "Windows test, skip if in linux environment");
        Assert.True(RuntimeInformation.IsOSPlatform(OSPlatform.Windows));
    }

}
