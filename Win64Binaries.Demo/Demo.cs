using Global;
using static Global.EasyObjectClassic;
using System.Text;

// ReSharper disable once CheckNamespace
namespace Demo;

// ReSharper disable once ArrangeTypeModifiers
static class Program
{
    // ReSharper disable once ArrangeTypeMemberModifiers
    static void Main(string[] args)
    {
        Echo(new { args });
        Echo(Win64Binaries.Add2(11, 22));
        string instDir = Win64Binaries.InstallBinaries();
        Echo(instDir, "instDir");
        string output = Sys.GetProcessStdout(Encoding.UTF8, "bash", "-c", $"find '{instDir}'");
        Echo(output, "output");
   }
}
