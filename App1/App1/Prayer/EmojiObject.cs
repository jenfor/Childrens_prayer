using System;
namespace App1.Prayer
{
    public class EmojiObject
    {
        public string Emoji = String.Empty;
        public string ImageDescription = String.Empty;

        public EmojiObject(string imageDescription, string emoji)
        {
            Emoji = emoji;
            ImageDescription = imageDescription;
        }
    }
}
