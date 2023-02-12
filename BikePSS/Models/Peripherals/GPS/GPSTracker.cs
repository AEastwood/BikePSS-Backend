namespace BikePSS.Models.Peripherals.GPS
{
    internal class GPSTracker
    {
        // Current Location
        public Dictionary<string, double>? CurrentLocation { get; set; }

        // Constructor
        public GPSTracker()
        {
            this.SetCurrentLocation(12.3456, 23.4567);
        }

        // Get Current Location
        public void SetCurrentLocation(double lat, double lng)
        {
            this.CurrentLocation = new Dictionary<string, double>()
            {
                { "lat", lat },
                { "lng", lng }
            };
        }
    }
}
