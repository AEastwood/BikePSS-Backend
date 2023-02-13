using BikePSS.Core.WebSocket;
using BikePSS.Models.Message;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace BikePSS.Core
{
    internal class Loader
    {
        public static Backend backend { get; set; }

        // List of WebSockets
        private static List<WebSocketJSON>? WebSockets = new();

        // Initialise the loader
        internal void Init()
        {
            Console.Title = "BikePSS";

            string? json = Properties.Resources.ResourceManager.GetString("websockets");

            if (json == null) return;

            try
            {
                WebSockets = JsonConvert.DeserializeObject<List<WebSocketJSON>>(json);
                WebSockets?.ForEach(webSocket =>
                    {
                        new Thread(() =>
                        {
                            Thread.CurrentThread.IsBackground = true;
                            WebSocketsServer.Start(webSocket);
                        }).Start();
                    });

                string[] handlers = { "Settings" };

                foreach (var handler in handlers)
                    LoadHandlers(handler);

                LoadBackend();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to parse JSON: {0}", ex.Message);
            }
        }

        // Load Peripherals
        private void LoadBackend()
        {
            backend = new Backend();
        }

        // Load Handlers
        private static void LoadHandlers(string prefix)
        {
            var query = from types in Assembly.GetExecutingAssembly().GetTypes() where types.IsClass && types.Namespace == $"BikePSS.MessageHandlers.{prefix}" select types;

            query.ToList().ForEach(t =>
            {
                if (t.Name == "<>o__0") return;

                var r = new Regex(@"(?<=[A-Z])(?=[A-Z][a-z])|(?<=[^A-Z])(?=[A-Z]) |(?<=[A-Za-z])(?=[^A-Za-z])", RegexOptions.IgnorePatternWhitespace);

                string type = r.Replace(t.Name, "_").Replace("_Handler", "").ToLower();
                string handler = t.Name;

                MessageTypes.AddMessageType(type, $"BikePSS.MessageHandlers.{prefix}.{handler}");
            });
        }
    }
}
