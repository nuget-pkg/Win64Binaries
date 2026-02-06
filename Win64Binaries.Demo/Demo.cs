using Global;
using static Global.EasyObjectClassic;
using System.Text;
using System.IO;

// ReSharper disable once CheckNamespace
namespace Demo;

// ReSharper disable once ArrangeTypeModifiers
static class Program
{
    // ReSharper disable once ArrangeTypeMemberModifiers
    static void Main(string[] args)
    {
        Echo(new { args });
        //Echo(Win64Binaries.Add2(11, 22));
        string instDir = Win64Binaries.InstallBinaries();
        Echo(instDir, "instDir");
        //string output = Sys.GetProcessStdout(Encoding.UTF8, "bash", "-c", $"find '{instDir}'");
        //Echo(output, "output");
        string wget2 = Path.Combine(instDir, "wget2", "wget2.exe");
        Echo(File.Exists(wget2));
        Sys.RunCommand(wget2, "-nc", "-T", "8", "https://github.com/msys2/msys2-installer/releases/download/2025-12-13/msys2-x86_64-20251213.exe");
   }
}
