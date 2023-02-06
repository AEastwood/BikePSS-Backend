using WebSocketSharp;
using WebSocketSharp.Server;

namespace BikePSS.Core.WebSocket
{
    internal class HandleMessage : WebSocketBehavior
    {
        protected override void OnMessage(MessageEventArgs e)
        {
            Console.WriteLine(e.Data);
            Send(e.Data);
        }
    }

    internal class WebSocketsServer
    {

        // IP Address
        private readonly string ipAddress = "127.0.0.1";

        // Port
        private readonly int port = 6969;

        // Constructor
        public WebSocketsServer() { }

        // Start WebSocket Server
        public void Start()
        {
            WebSocketServer webSocketServer = new(
                string.Format("ws://{0}:{1}", ipAddress, port)
            );

            webSocketServer.AddWebSocketService<HandleMessage>("/api");

            webSocketServer.Start();
            Console.Read();
        }

    }
}
