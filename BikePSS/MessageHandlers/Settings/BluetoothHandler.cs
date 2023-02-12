using BikePSS.Controllers.Peripherals;
using BikePSS.Models.Message;

namespace BikePSS.MessageHandlers.Settings
{
    internal class BluetoothHandler
    {
        // Handler
        public BluetoothHandler(Message message)
        {
            BluetoothController.Toggle((bool)message.GetValue("enabled"));
        }
    }
}
