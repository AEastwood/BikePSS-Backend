using System.Runtime.InteropServices;

namespace BikePSS.Core.Environment
{
    internal class Environment
    {

        // Check if is Linux
        internal bool IsLinux { get; set; } = false;

        // System ID
        internal string SystemID { get; set; }

        // Constructor
        internal Environment()
        {
            this.IsLinux = this.SetEnvironment();
            this.SetSystemID();
            Console.WriteLine("Environment:");
            if (!this.IsLinux)
                Console.WriteLine("\tOS: {0} - (Limited Features)", RuntimeInformation.OSDescription);
        }

        // Set Environment is Linux
        private bool SetEnvironment()
        {
            return RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
        }

        // Set System ID
        private void SetSystemID()
        {
            this.SystemID = libc.hwid.HwId.Generate();
        }
    }
}
