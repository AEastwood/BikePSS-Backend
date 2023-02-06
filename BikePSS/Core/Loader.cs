using BikePSS.Core.WebSocket;
using Newtonsoft.Json;
using System.Reflection;

namespace BikePSS.Core
{
    internal class Loader
    {

        private static List<WebSocketJSON>? WebSockets = new();

        // Initialise the loader
        internal static void Init()
        {
            string? json = Properties.Resources.ResourceManager.GetString("websockets");

            if (json == null) return;

            try
            {
                WebSockets = JsonConvert.DeserializeObject<List<WebSocketJSON>>(json);

                WebSockets?.ForEach(webSocket => WebSocketsServer.Start(webSocket));
            }
            catch(Exception ex)
            {
                Console.WriteLine("Unable to parse JSON: {0}", ex.Message);
            }
        }

    }
}
