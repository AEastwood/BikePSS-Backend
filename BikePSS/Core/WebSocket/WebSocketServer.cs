using System.Net;
using System.Net.Sockets;
using System.Text;

namespace BikePSS.Core.WebSocket
{
    internal class WebSocketServer
    {

        // Constructor
        public WebSocketServer() { }

        // Start WebSocket Server
        public void Start()
        {
            try
            {
                TcpListener server = new(
                    IPAddress.Parse("127.0.0.1"),
                    6969
                );

                server.Start();

                TcpClient client = server.AcceptTcpClient();
                NetworkStream stream = client.GetStream();

                while (true)
                {
                    while (!stream.DataAvailable)
                    {
                        byte[] bytes = new byte[client.Available];
                        stream.Read(bytes, 0, bytes.Length);

                        Console.WriteLine(Encoding.UTF8.GetString(bytes));
                    }
                }
            }
            catch { }

        }

    }
}
