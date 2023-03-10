using BikePSS.Core;
using BikePSS.Models.Message;
using Newtonsoft.Json;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace BikePSS.Handlers
{
    internal class HandleMessage : WebSocketBehavior
    {
        // On Message Event
        protected override void OnMessage(MessageEventArgs e)
        {
            try
            {
                Message message = JsonConvert.DeserializeObject<Message>(e.Data);

                if (MessageTypes.Allowed(message.Type))
                {
                    message.Handle();
                    Send(JsonConvert.SerializeObject(Loader.Backend));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
    }

}
