using BikePSS.Models.Message;

namespace BikePSS.Controllers.Peripherals.DashCams
{
    internal class DashCamsController
    {
        internal static void Toggle(bool enabled)
        {
            switch (enabled)
            {
                case true:
                    Console.WriteLine("Dash Cams Enabled");
                    break;

                default:
                    Console.WriteLine("Dash Cams Disabled");
                    break;
            }
        }

    }
}
