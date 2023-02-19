namespace BikePSS.Core.WebSocket
{
    internal class WebSocketJSON
    {
        // Handler
        public string? Handler { get; set; } = "HandleMessage";

        // IP Address
        public string? IpAddress { get; set; } = "127.0.0.1";

        // Path
        public string? Path { get; set; }

        // Port
        public int? Port { get; set; }
    }
}
