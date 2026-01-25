using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using Global;
using static Global.EasyObject;

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
        string instRoot = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".ProgramData", "Win64Binaries");
        string installDir = Installer.InstallResourceZip(typeof(Win64Binaries).Assembly, instRoot, "Win64Binaries:Win64Binaries.resource");
        return installDir;
    }
}
