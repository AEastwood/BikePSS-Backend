using BikePSS.Controllers.Peripherals.Bluetooth;
using BikePSS.Models.Message;

namespace BikePSS.Handlers.Settings
{
    internal class DeveloperModeHandler
    {
        // Handler
        public DeveloperModeHandler(Message message)
        {
            BluetoothController.Toggle((bool)message.GetValue("enabled"));
        }
    }
}
