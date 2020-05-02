using System;
using System.Collections.Generic;
using System.Text;

namespace App1.FairyTale
{
    public class FairyTalePlace
    {

        public string Verb = String.Empty;
        public string Condition = String.Empty;
        public string Place = String.Empty;
        public string Circumstance = String.Empty;
        public string Action = String.Empty;
        public string Emoji = String.Empty;
        public string ImageDescription;


        public FairyTalePlace(string verb, string condition, string place, string circumstance, string action, string emoji, string imageDespription)
        {
            Verb = verb;
            Condition = condition;
            Place = place;
            Circumstance = circumstance;
            Action = action;
            Emoji = emoji;
            ImageDescription = imageDespription;
        }
    }

}
