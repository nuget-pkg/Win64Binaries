using System;
using System.IO;

// ReSharper disable once CheckNamespace
namespace Global;

// ReSharper disable once InconsistentNaming
public static class Win64Binaries
{
    public const string Version = "v2026.0207.0956.36";
    public static string InstallBinaries()
    {
        string instRoot = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
            ".ProgramData",
            "Win64Binaries");
        string instDir = Installer.InstallZipFromURL(
            $"https://github.com/nuget-pkg/Win64Binaries/releases/download/Win64Binaries.{Version}/Win64Binaries.zip",
           instRoot,
            $"Win64Binaries.{Version}");
        return instDir;
    }
}
