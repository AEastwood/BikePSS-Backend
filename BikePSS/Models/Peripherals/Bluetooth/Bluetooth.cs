using HashtagChris.DotNetBlueZ;

namespace BikePSS.Models.Peripherals.Bluetooth
{
    internal class Bluetooth
    {
        // Enabled State
        public bool Enabled = false;

        // State of Events Registered
        public bool EventsRegistered = false;

        // Idapter1 Bluetooth Adapter instance
        public IAdapter1? BluetoothAdapter { get; set; }

    }
}
