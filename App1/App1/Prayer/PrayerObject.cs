using System;
using System.Collections.Generic;

namespace App1.Prayer
{
    public class PrayerObject
    {
        public string ObjectFirstForm = String.Empty;
        public string ObjectSecondForm = String.Empty;
        public string ObjectThirdForm = String.Empty;
        public string ObjectFourthForm = String.Empty;
        public string ObjectFifthForm = String.Empty;
        private List<EmojiObject> _emojis;

        public string ImageDescription = String.Empty;

        public PrayerObject(string obj1, List<EmojiObject> emojis, string obj2, string obj3, string obj4, string obj5)
        {
            ObjectFirstForm = obj1;
            ObjectSecondForm = obj2;
            ObjectThirdForm = obj3;
            ObjectFourthForm = obj4;
            ObjectFifthForm = obj5;

            _emojis = emojis;

        }

        public string GetEmoij()
        {
            var random = new Random();
            var emoji = _emojis[random.Next(_emojis.Count)];
            return emoji.Emoji;
        }
    }
}
