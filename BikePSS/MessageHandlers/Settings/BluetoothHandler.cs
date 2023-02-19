using BikePSS.Controllers.Peripherals.Bluetooth;
using BikePSS.Models.Message;

namespace BikePSS.MessageHandlers.Settings
{
    internal class BluetoothHandler
    {
        // Handler
        internal BluetoothHandler(Message message)
        {
            BluetoothController.Toggle((bool)message.GetValue("enabled"));
        }
    }
}
