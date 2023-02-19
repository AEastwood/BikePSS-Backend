using BikePSS.Models.Message;

namespace BikePSS.MessageHandlers.Settings
{
    internal class ServiceModeHandler
    {
        // Handler
        internal ServiceModeHandler(Message message)
        {
            Console.WriteLine(message.Type);
        }


    }
}
