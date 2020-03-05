using System;
using System.Collections.Generic;
using System.Text;

namespace App1.FairyTale
{
    public class FairyTaleEvent
    {
        public string Conversion = String.Empty;
        public string Event = String.Empty;
        public string Emoji = String.Empty;

        public FairyTaleEvent(string events, string conversions,  string emoji)
        {
            Conversion = conversions;
            Event = events;
            Emoji = emoji;
        }
    }
}
