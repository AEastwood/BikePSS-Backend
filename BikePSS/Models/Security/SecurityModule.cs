using BikePSS.Controllers.Components.FuelPump;
using BikePSS.Controllers.Components.Solenoid;
using BikePSS.Models.Authentication;

namespace BikePSS.Models.Security
{
    internal class SecurityModule
    {
        // Security Module Enabled
        public bool Enabled { get; set; } = true;

        // Fuel Pump
        public FuelPump FuelPump { get; set; }

        // Has Key
        public bool HasKey { get; set; } = false;

        // Is Authenticated
        public bool IsAuthenticated { get; set; } = false;

        // Key
        public Key Key { get; set; }

        // Hardened Mode
        public bool HardenedMode { get; set; } = false;

        // Solenoid
        public Solenoid Solenoid { get; set; }

    }
}
