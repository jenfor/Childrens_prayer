using System;
namespace App1.Prayer
{
    public class PrayerObject
    {
        public string ObjectFirstForm = String.Empty;
        public string ObjectSecondForm = String.Empty;
        public string ObjectThirdForm = String.Empty;
        public string Emoji = String.Empty;

        public string ImageDescription = String.Empty;

        public PrayerObject(string obj1, string emoji, string obj2, string obj3)
        {
            ObjectFirstForm = obj1;
            Emoji = emoji;
            ObjectSecondForm = obj2;
            ObjectThirdForm = obj3;
        }
    }
}
