using BikePSS.Controllers.Components.FuelPump;
using BikePSS.Controllers.Components.Solenoid;
using BikePSS.Core;
using BikePSS.Models.Authentication;

namespace BikePSS.Controllers.Security
{
    internal class SecurityController
    {
        // Init
        public static void Init()
        {
            Loader.Backend.Security.FuelPump = new FuelPump();
            Loader.Backend.Security.Key = new Key(Loader.Backend.Environment.SystemID);
            Loader.Backend.Security.Solenoid = new Solenoid();

            Console.WriteLine("Security:");
            
            SetAuthenticated();
            SetHasKey();
        }

        // Check if key is valid
        internal static void CheckKey(Key key) => Loader.Backend.Security.IsAuthenticated = false;

        // Change if security is enabled or not
        private static void SetEnabled(bool enabled) => Loader.Backend.Security.Enabled = enabled;

        // Check if the bike has a valid key
        private static void SetAuthenticated()
        {
            Console.Write("\tAuthenticated: ");

            if (!Loader.Backend.Security.IsAuthenticated)
            {
                Loader.Backend.Security.IsAuthenticated = false;
                Console.ForegroundColor = (Loader.Backend.Security.IsAuthenticated) ? ConsoleColor.Green : ConsoleColor.Red;
                Console.Write("{0}\n", Loader.Backend.Security.IsAuthenticated);
                Console.ResetColor();
                return;
            }

            Loader.Backend.Security.HasKey = true;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Present\n");
            Console.ResetColor();
        }

        // Check if the bike has a valid key
        private static void SetHasKey()
        {
            Console.Write("\tKey: ");

            if (!Loader.Backend.Security.HasKey)
            {
                Loader.Backend.Security.HasKey = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Not Present\n");
                Console.ResetColor();
                return;
            }

            Loader.Backend.Security.HasKey = true;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Present\n");
            Console.ResetColor();
        }

    }
}
