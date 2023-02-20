using BikePSS.Core;
using HashtagChris.DotNetBlueZ;

namespace BikePSS.Controllers.Peripherals.Bluetooth
{
    internal class BluetoothController
    {
        // Connec to bluetooth
        internal static void Connect()
        {
            if (Loader.Backend.Bluetooth.BluetoothAdapter == null)
            {
                ConnectFailed();
                return;
            }

            Console.WriteLine("\tConnection: Connected");

            if (!Loader.Backend.Bluetooth.EventsRegistered)
                RegisterEvents();
        }

        // Failed Connection
        private static void ConnectFailed()
        {
            Console.WriteLine("Failed to init Bluetooth");
        }

        // Get Bluetooth Adapter
        internal async static void GetAdapter(bool forceReconnect = false)
        {
            if (Loader.Backend.Bluetooth.BluetoothAdapter != null && !forceReconnect) return;

            Loader.Backend.Bluetooth.BluetoothAdapter = (await BlueZManager.GetAdaptersAsync()).FirstOrDefault();
        }

        // Init
        public static void Init()
        {
            Console.WriteLine("Bluetooth:");

            if (!Loader.Backend.Environment.IsLinux)
            {
                Console.Write("\tConnection: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Disconnected\n");
                Console.ResetColor();

                Console.Write("\tEnabled: ");
                Console.ForegroundColor = (Loader.Backend.Bluetooth.Enabled) ? ConsoleColor.Green : ConsoleColor.Red;
                Console.Write("{0}\n", Loader.Backend.Bluetooth.Enabled.ToString());
                Console.ResetColor();
                return;
            }

            BluetoothController.GetAdapter();
        }

        // Register Event Listeners
        private static void RegisterEvents()
        {
            //BluetoothAdapter.Connected += DeviceConnectedAsync();
            //BluetoothAdapter.Disconnected += DeviceDisconnectedAsync();
            //BluetoothAdapter.ServicesResolved += DeviceServicesResolvedAsync();

            Loader.Backend.Bluetooth.Enabled = true;
        }

        // Toggle Bluetooth
        internal static void Toggle(bool enabled)
        {
            switch (enabled)
            {
                case true:
                    Loader.Backend.Bluetooth.Enabled = true;
                    break;

                default:
                    Loader.Backend.Bluetooth.Enabled = false;
                    break;
            }
        }

    }
}
