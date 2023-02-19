using BikePSS.Controllers.Peripherals.Bluetooth;
using BikePSS.Models.Message;

namespace BikePSS.MessageHandlers.Settings
{
    internal class LocationTrackingHandler
    {
        // Handler
        internal LocationTrackingHandler(Message message)
        {
            BluetoothController.Toggle((bool)message.GetValue("enabled"));
        }
    }
}
