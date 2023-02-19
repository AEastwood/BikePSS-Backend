using BikePSS.Controllers.Peripherals.Media;
using BikePSS.Models.Message;

namespace BikePSS.MessageHandlers.Settings
{
    internal class MediaHandler
    {
        //Handler
        internal MediaHandler(Message message)
        {
            MediaController.Toggle((bool)message.GetValue("enabled"));
        }

    }
}
