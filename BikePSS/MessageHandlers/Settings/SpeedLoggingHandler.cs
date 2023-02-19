using BikePSS.Controllers.Peripherals.Bluetooth;
using BikePSS.Models.Message;

namespace BikePSS.MessageHandlers.Settings
{
    internal class SpeedLoggingHandler
    {
        // Handler
        internal SpeedLoggingHandler(Message message)
        {
            BluetoothController.Toggle((bool)message.GetValue("enabled"));
        }
    }
}
