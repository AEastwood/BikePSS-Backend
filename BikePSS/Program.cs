using BikePSS.Core;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "BikePSS";
        Console.WriteLine("BikePSS Starting");

        Loader.Init();
    }
}