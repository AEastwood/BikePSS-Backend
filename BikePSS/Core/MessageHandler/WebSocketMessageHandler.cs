using WebSocketSharp.Server;
using WebSocketSharp;

namespace BikePSS.Core.MessageHandler
{
    internal class HandleMessage : WebSocketBehavior
    {
        protected override void OnMessage(MessageEventArgs e)
        {
            Console.WriteLine(e.Data);
            Send(e.Data);
        }
    }

}
