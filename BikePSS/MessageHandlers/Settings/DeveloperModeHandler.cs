using BikePSS.Controllers.Peripherals.Bluetooth;
using BikePSS.Models.Message;

namespace BikePSS.MessageHandlers.Settings
{
    internal class DeveloperModeHandler
    {
        // Handler
        internal DeveloperModeHandler(Message message)
        {
            BluetoothController.Toggle((bool)message.GetValue("enabled"));
        }
    }
}
