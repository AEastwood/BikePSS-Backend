using BikePSS.Controllers.Peripherals;
using BikePSS.Models.Message;

namespace BikePSS.MessageHandlers.Settings
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
