using BikePSS.Core;

internal class Program
{
    private static void Main(string[] args)
    {
        Loader loader = new();
        loader.Init();

        Console.WriteLine("BikePSS Started");
        Console.Read();
    }
}