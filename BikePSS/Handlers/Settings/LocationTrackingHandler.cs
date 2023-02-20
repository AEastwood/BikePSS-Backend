using BikePSS.Controllers.Peripherals.Bluetooth;
using BikePSS.Models.Message;

namespace BikePSS.Handlers.Settings
{
    internal class LocationTrackingHandler
    {
        // Handler
        public LocationTrackingHandler(Message message)
        {
            BluetoothController.Toggle((bool)message.GetValue("enabled"));
        }
    }
}
