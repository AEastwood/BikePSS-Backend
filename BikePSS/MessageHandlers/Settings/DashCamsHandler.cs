using BikePSS.Controllers.Peripherals.DashCams;
using BikePSS.Models.Message;

namespace BikePSS.MessageHandlers.Settings
{
    internal class DashCamsHandler
    {
        // Handler
        internal DashCamsHandler(Message message)
        {
            DashCamsController.Toggle((bool)message.GetValue("enabled"));
        }
    }
}
