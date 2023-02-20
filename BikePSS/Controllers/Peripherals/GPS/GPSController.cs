using BikePSS.Core;

namespace BikePSS.Controllers.Peripherals.Navigation
{
    internal class GPSController
    {

        // Init
        public static void Init()
        {
            SetCurrentPosition(
                GetCurrentPosition()
            );

            Console.WriteLine("GPS Tracker:");

            Console.Write("\tModule: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Not Present\n");
            Console.ResetColor();
        }

        // Get Current Location6
        internal static Dictionary<string, double> GetCurrentPosition()
        {
            Dictionary<string, double> position = new Dictionary<string, double>()
            {
                { "lat", 12.3456 },
                { "lng", 13.4567 }
            };

            Console.Write("\tPosition: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Unable To Fix\n");
            Console.ResetColor();

            return position;
        }

        // Load GPS Module
        private static void LoadModule()
        {
            
        }

        // Get Current Location
        private static void SetCurrentPosition(Dictionary<string, double> position)
        {
            Loader.Backend.GPS.CurrentPosition = position;
        }

        // Set Route
        internal static void SetRoute(float lat, float lng)
        {
        }

    }
}
