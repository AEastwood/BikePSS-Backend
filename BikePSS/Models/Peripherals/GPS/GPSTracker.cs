namespace BikePSS.Models.Peripherals.GPS
{
    internal class GPSTracker
    {
        // Current Location
        public Dictionary<string, double>? CurrentPosition { get; set; }

        // Module Loaded
        public bool ModuleLoaded { get; set; } = false;

    }
}
