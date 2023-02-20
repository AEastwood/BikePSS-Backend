using BikePSS.Controllers.Peripherals.Media;
using BikePSS.Models.Message;

namespace BikePSS.Handlers.Settings
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
