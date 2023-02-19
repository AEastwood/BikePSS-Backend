using BikePSS.Models.Peripherals.Bluetooth;
using BikePSS.Models.Peripherals.GPS;

namespace BikePSS.Core
{
    internal class Backend
    {
        // Bluetooth Module
        internal Bluetooth Bluetooth { get; set; }

        // Environment Module
        internal Environment.Environment Environment { get; set; }

        // GPS Module
        internal GPSTracker GPS { get; set; }

        // Security Module
        internal Security.Security Security { get; set; }

        // Initialise the backend
        internal void Init()
        {
            Console.Title = "BikePSS";

            this.SetEnvironment();
            this.SetSecurity();
            this.SetBluetooth();
            this.SetGPS();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nBackend Initialised");
            Console.ResetColor();
        }

        // Set Bluetooth Module
        private void SetBluetooth()
        {
            Bluetooth = new Bluetooth();

            if (Loader.Backend.Environment.IsLinux)
                Bluetooth.Connect();
        }

        // Set Environment
        private void SetEnvironment()
        {
            Environment = new Environment.Environment();
        }

        // Set GPS
        private void SetGPS()
        {
            GPS = new GPSTracker();
        }

        // Set Security
        private void SetSecurity()
        {
            Security = new Security.Security();
        }

    }

}
