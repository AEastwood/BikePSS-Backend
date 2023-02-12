using BikePSS.Controllers.Peripherals;
using BikePSS.Models.Message;

namespace BikePSS.MessageHandlers.Settings
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
