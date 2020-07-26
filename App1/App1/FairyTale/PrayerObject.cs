using System;
namespace App1.FairyTale
{
    public class PrayerObject
    {
        public string Object = String.Empty;
        public string Emoji = String.Empty;
        public string ImageDescription = String.Empty;

        public PrayerObject(string obj, string emoji, string imageDescription)
        {
            Object = obj;
            Emoji = emoji;
            ImageDescription = imageDescription;
        }
    }
}
