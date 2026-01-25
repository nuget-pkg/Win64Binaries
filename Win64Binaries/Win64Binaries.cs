using System;
using System.IO;

// ReSharper disable once CheckNamespace
namespace Global;

// ReSharper disable once InconsistentNaming
public static class Win64Binaries
{
    public static int Add2(int a, int b)
    {
        return a + b;
    }
    public static string InstallBinaries()
    {
        string instRoot = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
            ".ProgramData",
            "Win64Binaries");
        string instDir = Installer.InstallResourceZip(
            typeof(Win64Binaries).Assembly,
            instRoot,
            "Win64Binaries:Programs.resource");
        instDir = instDir.Replace("\\", "/");
        return instDir;
    }
}
