using BikePSS.Models.Peripherals.Bluetooth;
using BikePSS.Models.Peripherals.GPS;
using System.Runtime.InteropServices;

namespace BikePSS.Core
{
    internal class Backend
    {
        public Bluetooth Bluetooth { get; set; }

        public GPSTracker GPS { get; set; }

        // Constructor
        public Backend()
        {
            if (!RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                Console.WriteLine("Operating System is not Linux, unideal conditions detected. Unwanted behaviour may occur.");

            Bluetooth = new Bluetooth();
            GPS = new GPSTracker();
        }
    }

}
