using BikePSS.Controllers.Peripherals;
using BikePSS.Models.Message;

namespace BikePSS.MessageHandlers.Settings
{
    internal class MediaHandler
    {
        //Handler
        public MediaHandler(Message message)
        {
            MediaController.Toggle((bool)message.GetValue("enabled"));
        }

    }
}
