using BikePSS.Models.Peripherals.Bluetooth;
using BikePSS.Models.Peripherals.GPS;
using BikePSS.Models.Environment;
using BikePSS.Models.Security;

namespace BikePSS.Core
{
    internal class Backend
    {
        // Bluetooth Module
        public Bluetooth Bluetooth { get; set; }

        // Environment Module
        public BackendEnvironment Environment { get; set; }

        // GPS Module
        public GPSTracker GPS { get; set; }

        // Security Module
        public SecurityModule Security { get; set; }
    }

}
