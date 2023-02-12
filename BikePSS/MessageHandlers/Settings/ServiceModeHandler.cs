using BikePSS.Models.Message;

namespace BikePSS.MessageHandlers.Settings
{
    internal class ServiceModeHandler
    {
        // Handler
        public ServiceModeHandler(Message message)
        {
            Console.WriteLine(message.Type);
        }


    }
}
