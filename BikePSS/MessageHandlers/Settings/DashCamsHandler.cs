﻿using BikePSS.Controllers.Peripherals;
using BikePSS.Models.Message;

namespace BikePSS.MessageHandlers.Settings
{
    internal class DashCamsHandler
    {
        // Handler
        public DashCamsHandler(Message message)
        {
            DashCamsController.Toggle((bool)message.GetValue("enabled"));
        }
    }
}