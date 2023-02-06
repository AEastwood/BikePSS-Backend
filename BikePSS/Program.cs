using BikePSS.Core.WebSocket;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "BikePSS";
        Console.WriteLine("BikePSS Starting");

        WebSocketsServer server = new();
        server.Start();

        while (true)
        {
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Waiting for WebSockets");
        }
    }
}