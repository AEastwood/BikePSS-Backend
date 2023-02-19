using BikePSS.Core.WebSocket;
using BikePSS.Models.Message;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace BikePSS.Core
{
    internal class Loader
    {
        internal static Backend Backend = new Backend();

        // List of WebSockets
        private static List<WebSocketJSON>? WebSockets = new();

        // Initialise the loader
        internal static void Init()
        {
            Backend.Init();

            try
            {
                string? json = Properties.Resources.ResourceManager.GetString("internal.websockets");

                if (json == null) return;

                WebSockets = JsonConvert.DeserializeObject<List<WebSocketJSON>>(json);
                WebSockets?.ForEach(webSocket =>
                {
                    new Thread(() =>
                    {
                        Thread.CurrentThread.IsBackground = true;
                        WebSocketsServer.Start(webSocket);
                    }).Start();
                });

                LoadHandlers();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to init backend", ex.Message);
                Console.Read();
            }
        }

        // Load Handlers
        private static void LoadHandlers()
        {
            foreach (var handler in MessageHandlers())
            {
                var query = from types in Assembly.GetExecutingAssembly().GetTypes() where types.IsClass && types.Namespace == $"BikePSS.MessageHandlers.{handler}" select types;

                query.ToList().ForEach(t =>
                {
                    if (t.Name == "<>o__0") return;

                    MessageTypes.AddMessageType(
                        MessageHandlersRegex().Replace(t.Name, "_").Replace("_Handler", "").ToLower(),
                        $"BikePSS.MessageHandlers.{handler}.{t.Name}"
                    );
                });
            }
        }

        // Available Message Handlers
        private static string[] MessageHandlers() => new string[] { "Settings" };

        // Message Handlers Regex
        private static Regex MessageHandlersRegex()
        {
            return new Regex("(?<=[A-Z])(?=[A-Z][a-z])|(?<=[^A-Z])(?=[A-Z]) |(?<=[A-Za-z])(?=[^A-Za-z])", RegexOptions.IgnorePatternWhitespace);
        }
    }
}
