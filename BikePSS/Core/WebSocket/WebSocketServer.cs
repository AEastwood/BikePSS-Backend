using BikePSS.Core.MessageHandler;
using WebSocketSharp.Server;

namespace BikePSS.Core.WebSocket
{
    internal class WebSocketsServer
    {
        // Start WebSocket Server
        public static void Start(WebSocketJSON webSocket)
        {
            WebSocketServer webSocketServer = new(
                string.Format("ws://{0}:{1}", webSocket.IpAddress, webSocket.Port)
            );

            webSocketServer.AddWebSocketService<HandleMessage>(webSocket.Path);

            webSocketServer.Start();
            Console.Read();
        }

    }
}
