namespace BikePSS.Controllers.Peripherals
{
    internal class MediaController
    {

        // Set Media Volume
        public static void AdjustVolume(int level)
        {

        }

        // Pause Media
        public static void Pause()
        {

        }

        // Play Media
        public static void Play()
        {

        }

        // Rewind Media
        public static void Rewind()
        {

        }

        // Skip Media
        public static void Skip()
        {

        }

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
