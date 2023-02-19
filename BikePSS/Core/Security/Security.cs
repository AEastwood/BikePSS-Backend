using BikePSS.Controllers.Components.FuelPump;
using BikePSS.Controllers.Components.Solenoid;
using BikePSS.Models.Authentication;

namespace BikePSS.Core.Security
{
    internal class Security
    {
        // Security Module Enabled
        internal bool Enabled { get; set; } = true;

        // Fuel Pump
        internal FuelPump FuelPump { get; set; }

        // Has Key
        internal bool HasKey { get; set; } = false;

        // Is Authenticated
        internal bool IsAuthenticated { get; private set; } = false;

        // Key
        internal Key Key { get; set; }

        // HardenedMode
        internal bool HardenedMode { get; set; } = false;

        // Solenoid
        internal Solenoid Solenoid { get; set; }

        // Constructor
        internal Security()
        {
            this.FuelPump = new FuelPump();
            this.Key = new Key(Loader.Backend.Environment.SystemID);
            this.Solenoid = new Solenoid();

            Console.WriteLine("Security:");

            if (!this.HasKey)
            {
                Console.WriteLine("\tKey: Not Present");
            }
        }

    }
}
