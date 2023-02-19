using BikePSS.Core;

namespace BikePSS.Controllers.Peripherals.Bluetooth
{
    internal class BluetoothController
    {
        // Toggle Bluetooth
        internal static void Toggle(bool enabled)
        {
            switch (enabled)
            {
                case true:
                    Console.WriteLine("Bluetooth Enabled");
                    break;

                default:
                    Console.WriteLine("Bluetooth Disabled");
                    break;
            }
        }

    }
}
