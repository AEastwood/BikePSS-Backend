using BikePSS.Controllers.Backend.Environment;
using BikePSS.Controllers.Peripherals.Bluetooth;
using BikePSS.Controllers.Peripherals.Navigation;
using BikePSS.Controllers.Security;
using BikePSS.Core;
using BikePSS.Models.Environment;
using BikePSS.Models.Peripherals.Bluetooth;
using BikePSS.Models.Peripherals.GPS;
using BikePSS.Models.Security;
using Newtonsoft.Json;

namespace BikePSS.Controllers.Backend
{
    internal class BackendController
    {
        // Current Binary Directory Path
        internal static string CurrentPath = System.Reflection.Assembly.GetExecutingAssembly().Location.Replace("BikePSS.dll", "");

        // Initialise the backend
        internal static void Init()
        {
            Console.Title = "BikePSS";

            if (!Loader.StateResumed)
            {
                Loader.Backend.Environment = new BackendEnvironment();
                Loader.Backend.Security = new SecurityModule();
                Loader.Backend.Bluetooth = new Bluetooth();
                Loader.Backend.GPS = new GPSTracker();
            }

            EnvironmentController.Init();
            SecurityController.Init();
            BluetoothController.Init();
            GPSController.Init();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nBackend Initialised");
            Console.ResetColor();

            SaveState(Loader.Backend);

        }

        // Load State
        public static Core.Backend LoadState()
        {
            string backendJsonPath = File.ReadAllText($"{CurrentPath}\\backend");
            return JsonConvert.DeserializeObject<Core.Backend>(backendJsonPath);
        }

        // Save State of Backend
        internal static void SaveState(Core.Backend backend) => File.WriteAllText($"{CurrentPath}\\backend", JsonConvert.SerializeObject(backend));
    }
}
