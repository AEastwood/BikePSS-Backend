using BikePSS.Controllers.Peripherals.DashCams;
using BikePSS.Models.Message;

namespace BikePSS.Handlers.Settings
{
    internal class DashCamsHandler
    {
        // Handler
        public DashCamsHandler(Message message)
        {
            DashCamsController.Toggle((bool)message.GetValue("enabled"));
        }
    }
}
