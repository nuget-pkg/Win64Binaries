using System;
using System.IO;

// ReSharper disable once CheckNamespace
namespace Global;

// ReSharper disable once InconsistentNaming
public static class Win64Binaries
{
    public static string InstallBinaries()
    {
        string instRoot = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
            ".ProgramData",
            "Win64Binaries");
        string instDir = Installer.InstallZipFromURL(
            "https://github.com/nuget-pkg/Win64Binaries/releases/download/Win64Binaries.v2026.0207.0956.36/Win64Binaries.zip",
           instRoot,
            "Win64Binaries");
        return instDir;
    }
}
