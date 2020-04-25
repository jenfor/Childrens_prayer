using System;
using System.Collections.Generic;
using System.Text;

namespace App1.FairyTale
{
    public class FairyTaleEvent
    {
        public string Action = String.Empty;
        public string Event = String.Empty;
        public string Emoji = String.Empty;

        public FairyTaleEvent(string events, string action,  string emoji)
        {
            Action = action;
            Event = events;
            Emoji = emoji;
        }
    }
}
