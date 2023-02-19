using System.Diagnostics;

namespace BikePSS.Core.CLI
{
    internal class CLI
    {

        // Excecute /bin/bash command
        internal static bool Execute(string arguments, string command = "/bin/bash")
        {
            ProcessStartInfo startInfo = new()
            {
                FileName = command,
                Arguments = arguments,
            };
            Process proc = new() { StartInfo = startInfo, };
            return proc.Start();
        }
    }

}
