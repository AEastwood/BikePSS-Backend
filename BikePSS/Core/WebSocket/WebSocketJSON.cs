namespace BikePSS.Core.WebSocket
{
    internal class WebSocketJSON
    {
        public string? Handler { get; set; } = "HandleMessage";
        public string? IpAddress { get; set; } = "127.0.0.1";
        public string? Path { get; set; }
        public int? Port { get; set; } = 6969;
    }
}
