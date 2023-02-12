using BikePSS.Models.Peripherals.Bluetooth;
using BikePSS.Models.Peripherals.GPS;

namespace BikePSS.Core
{
    internal class Backend
    {
        public Bluetooth Bluetooth { get; set; }

        public GPSTracker GPS { get; set; }

        // Constructor
        public Backend()
        {
            Bluetooth = new Bluetooth();
            GPS = new GPSTracker();
        }
    }

}
