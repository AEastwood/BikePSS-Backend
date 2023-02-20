using BikePSS.Controllers.Peripherals.Bluetooth;
using BikePSS.Models.Message;

namespace BikePSS.Handlers.Settings
{
    internal class SpeedLoggingHandler
    {
        // Handler
        public SpeedLoggingHandler(Message message)
        {
            BluetoothController.Toggle((bool)message.GetValue("enabled"));
        }
    }
}
