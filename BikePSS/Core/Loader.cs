using BikePSS.Controllers.Backend;
using BikePSS.Controllers.Handlers;
using BikePSS.Core.WebSocket;
using Newtonsoft.Json;

namespace BikePSS.Core
{
    internal class Loader
    {
        // Backend
        internal static Backend Backend;

        // State Resumed From File
        internal static bool StateResumed = false;

        // List of WebSockets
        private static List<WebSocketJSON>? WebSockets = new();

        // Initialise the loader
        internal static void Init()
        {
            if (!File.Exists($"{BackendController.CurrentPath}\\backend"))
                Backend = new Backend();
            else
            {
                Backend = BackendController.LoadState();
                StateResumed = true;
            }

            BackendController.Init();

            try
            {
                File.WriteAllText($"{BackendController.CurrentPath}\\backend", JsonConvert.SerializeObject(Backend));

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

                MessageHandlersController.Load();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to init backend {0}", ex.Message);
                Console.Read();
            }
        }



    }
}
