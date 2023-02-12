using BikePSS.Controllers.Peripherals;
using BikePSS.Models.Message;

namespace BikePSS.MessageHandlers.Settings
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
