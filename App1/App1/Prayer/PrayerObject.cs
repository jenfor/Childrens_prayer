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
        public int NrEmoji = 1;
        private List<EmojiObject> _emojis;

        public string ImageDescription = String.Empty;

        public PrayerObject(string obj1, List<EmojiObject> emojis, string obj2, string obj3, string obj4, string obj5, int nrEmoji)
        {
            ObjectFirstForm = obj1;
            ObjectSecondForm = obj2;
            ObjectThirdForm = obj3;
            ObjectFourthForm = obj4;
            ObjectFifthForm = obj5;

            NrEmoji = nrEmoji;
            _emojis = emojis;

        }

        public string GetEmoij(int nrEmojis)
        {
            var random = new Random();
            string emojis = String.Empty;
            for(int i = 0; i < nrEmojis; i++)
            {
                var newEmoij = _emojis[random.Next(_emojis.Count)].Emoji;
                if (emojis == String.Empty)
                {
                    emojis += newEmoij;
                }
                else
                {
                    while (emojis.Contains(newEmoij))
                    {
                        newEmoij = _emojis[random.Next(_emojis.Count)].Emoji;
                    }

                    emojis += newEmoij;
                }
            }

            return emojis;
        }
    }
}
