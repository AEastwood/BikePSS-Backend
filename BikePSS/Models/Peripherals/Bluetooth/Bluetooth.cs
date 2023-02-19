using BikePSS.Core;
using HashtagChris.DotNetBlueZ;

namespace BikePSS.Models.Peripherals.Bluetooth
{
    internal class Bluetooth
    {
        // Enabled State
        internal bool Enabled { get; private set; } = false;

        // State of Events Registered
        private bool EventsRegistered { get; set; } = false;

        // Idapter1 Bluetooth Adapter instance
        private IAdapter1? BluetoothAdapter { get; set; }

        // Constructor
        internal Bluetooth()
        {
            if (!Loader.Backend.Environment.IsLinux) return;

            this.GetAdapter();
        }

        // Connec to bluetooth
        internal void Connect()
        {
            if (BluetoothAdapter == null)
            {
                ConnectFailed();
                return;
            }

            if (!EventsRegistered)
                this.RegisterEvents();
        }

        // Failed Connection
        private static void ConnectFailed()
        {
            Console.WriteLine("Failed to init Bluetooth");
        }

        // Get Bluetooth Adapter
        private async void GetAdapter(bool forceReconnect = false)
        {
            if (BluetoothAdapter != null && !forceReconnect) return;

            BluetoothAdapter = (await BlueZManager.GetAdaptersAsync()).FirstOrDefault();
        }

        // Register Event Listeners
        private void RegisterEvents()
        {
            //BluetoothAdapter.Connected += DeviceConnectedAsync();
            //BluetoothAdapter.Disconnected += DeviceDisconnectedAsync();
            //BluetoothAdapter.ServicesResolved += DeviceServicesResolvedAsync();

            EventsRegistered = true;
        }
    }
}
