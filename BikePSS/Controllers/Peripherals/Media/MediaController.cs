namespace BikePSS.Controllers.Peripherals.Media
{
    internal class MediaController
    {

        // Set Media Volume
        internal static void AdjustVolume(int level)
        {

        }

        // Pause Media
        internal static void Pause()
        {

        }

        // Play Media
        internal static void Play()
        {

        }

        // Rewind Media
        internal static void Rewind()
        {

        }

        // Skip Media
        internal static void Skip()
        {

        }

        // Toggle Media Enabled
        internal static void Toggle(bool enabled)
        {
            switch (enabled)
            {
                case true:
                    Console.WriteLine("Media Enabled");
                    break;

                default:
                    Console.WriteLine("Media Disabled");
                    break;
            }
        }
    }
}
