namespace BikePSS.Models.Peripherals.GPS
{
    internal class GPSTracker
    {
        // Current Location
        internal Dictionary<string, double>? CurrentPosition { get; set; }

        // Constructor
        internal GPSTracker()
        {
            this.SetCurrentPosition(
                this.GetCurrentPosition()
            );

            Console.WriteLine("GPS Tracker:");
            Console.WriteLine("\tUnit: Loaded");
        }

        // Get Current Location6
        internal Dictionary<string, double> GetCurrentPosition()
        {
            return new Dictionary<string, double>()
            {
                { "lat", 12.3456 },
                { "lng", 13.4567 }
            };
        }

        // Get Current Location
        private void SetCurrentPosition(Dictionary<string, double> position)
        {
            this.CurrentPosition = position;
        }
    }
}
