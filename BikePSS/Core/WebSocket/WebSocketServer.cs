using BikePSS.Handlers;
using WebSocketSharp.Server;

namespace BikePSS.Core.WebSocket
{
    internal class WebSocketsServer
    {

        // Start WebSocket Server
        internal static void Start(WebSocketJSON webSocket)
        {
            string connectionString = string.Format("ws://{0}:{1}", webSocket.IpAddress, webSocket.Port);

            WebSocketServer webSocketServer = new(connectionString);

            webSocketServer.AddWebSocketService<HandleMessage>(webSocket.Path);
            webSocketServer.Start();
        }

    }
}
