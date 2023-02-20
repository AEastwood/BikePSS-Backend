using BikePSS.Core;
using System.Runtime.InteropServices;

namespace BikePSS.Controllers.Backend.Environment
{
    internal class EnvironmentController
    {
        // Init Environment Controller
        public static void Init()
        {
            Loader.Backend.Environment.IsLinux = RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
            Loader.Backend.Environment.SystemID = libc.hwid.HwId.Generate();

            Console.WriteLine("Environment:");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\tOS: {0}", RuntimeInformation.OSDescription);
            Console.ResetColor();

            if (!Loader.Backend.Environment.IsLinux)
            {
                Console.Write(" - ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("(Limited Features)");
                Console.ResetColor();
            }
        }

    }
}
