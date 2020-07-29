using App1.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App1.Prayer
{
    public class ThePrayer
    { 
       public AChildsPrayerPage PresentPage = new AChildsPrayerPage();
        public int PageNr = 0;
        public int LastComputerPreperdPage = 4;
        private List<AChildsPrayerPage> pageList = new List<AChildsPrayerPage>();

        private int prayerVersion = 0;
        public PrayerObject PrayerObject = null;
        public EmojiObject HideEmoji = null;

        public ThePrayer(Language language)
        {
            WritePrayer(language);
            ViewNextPage(language);
        }

        public void WritePrayer(Language language)
        {
            PageNr = 0;
            pageList.Clear();

            var random = new Random();
            prayerVersion = random.Next(2);

            switch (prayerVersion)
            {
                case 0:
                    PrayerObject = GetPrayerObject(language.Prayer1Objects);

                    pageList.Add(CreatePage(PrayerStart(language), PrayerObject.GetEmoij(), PrayerObject.ImageDescription, string.Empty, PageNr, 1));
                    pageList.Add(CreatePage(SecondPrayerPage(language), PrayerObject.GetEmoij(), PrayerObject.ImageDescription, string.Empty, PageNr + 1, 1));
                    pageList.Add(CreatePage(ThirdPrayerPage(language), PrayerObject.GetEmoij(), PrayerObject.ImageDescription, string.Empty, PageNr + 2, 1));
                    pageList.Add(CreatePage(FourthPrayerPage(language), language.LoveEmoji, PrayerObject.ImageDescription, string.Empty, PageNr + 3, 1));
                    break;
                case 1:
                    PrayerObject = GetPrayerObject(language.Prayer2Objects);
                    HideEmoji = GetEmoji(language.Hides);

                    pageList.Add(CreatePage(PrayerStart(language), PrayerObject.GetEmoij(), PrayerObject.ImageDescription, string.Empty, PageNr, 1));
                    pageList.Add(CreatePage(SecondPrayerPage(language), PrayerObject.GetEmoij(), PrayerObject.ImageDescription, string.Empty, PageNr + 1, 1));
                    pageList.Add(CreatePage(ThirdPrayerPage(language), HideEmoji.Emoji, PrayerObject.ImageDescription, string.Empty, PageNr + 2, 1));
                    pageList.Add(CreatePage(FourthPrayerPage(language), language.LoveEmoji, PrayerObject.ImageDescription, string.Empty, PageNr + 3, 1));
                    break;
            }

            LastComputerPreperdPage = pageList.Count -1;
        }

        public bool ViewPreviousPage()
        {
            if (PageNr >= 2)
            {
                PageNr -= 2;
                PresentPage = pageList[PageNr];
                PageNr++;
                return true;
            }

            return false;
        }

        public void ViewNextPage(Language language)
        {
            if (PageNr >= pageList.Count)
            {
                return;
            }

            PresentPage = pageList[PageNr];
            PresentPage.IsShown = true;

            PageNr++;
        }

        public PrayerObject GetPrayerObject(List<PrayerObject> prayer1Objects)
        {
            var random = new Random();
            var prayerObject = prayer1Objects[random.Next(prayer1Objects.Count)];
            return prayerObject;
        }

        public string GetRandomEmojis(Language language)
        {            
            var allEmojis = new List<EmojiObject>();
            allEmojis.AddRange(new List<EmojiObject>(language.Animals));
            allEmojis.AddRange(new List<EmojiObject>(language.Hides));

            var emoji1 = CreateAndSkipEqualEmojis(null, allEmojis);
            var emoji2 = CreateAndSkipEqualEmojis(emoji1, allEmojis); 
            var emoji3 = CreateAndSkipEqualEmojis(emoji2, allEmojis);

            return emoji1 + emoji2 + emoji3;
        } 

        private string CreateAndSkipEqualEmojis(string emoji1, List<EmojiObject> allEmojis)
        {
            var random = new Random();
            var emoji2 = allEmojis[random.Next(allEmojis.Count)];

            while (emoji2.Equals(emoji1))
            {
                emoji2 = allEmojis[random.Next(allEmojis.Count)];
            }

            return emoji2.Emoji;
        }

        public AChildsPrayerPage CreatePage(string text, string emoji, string imageDescription, string placeholder, int pageNr, int nrOfEmoji)
        {
            var page = new AChildsPrayerPage();
            page.Text = text;
            page.Emoji = emoji;
            page.NrOfEmoji = nrOfEmoji;
            page.ImageDescription = imageDescription;
            page.Palceholder = placeholder;
            page.PageNr = pageNr;
            return page;
        }

        public string GetPrayerString(Language language)
        {
            var sb = new StringBuilder(); 
            var pagesToUse = pageList.Where(x => x.IsShown);

            foreach (var page in pagesToUse)
            {
                if(!page.Text.Equals(string.Empty))
                {
                    sb.Append(page.Text);
                    sb.Append(page.Emoji);
                    sb.Append(language.NewLine);
                    sb.Append(language.NewLine);
                }
            }
            return sb.ToString();
        }

        public string PrayerStart(Language language)
        {
            var sb = new StringBuilder();
            switch (prayerVersion)
            {
                case 0:
                    sb.Append(language.God + language.Space +
                GetWords(language.GodCareVerb) + language.Space
                + language.All + language.Space
                + PrayerObject.ObjectFirstForm + language.Dot
                );
                    break;
                case 1:
                    sb.Append(language.GodLoves + language.Space
                        + PrayerObject.ObjectFirstForm + language.Dot
                    );

                    break;
            }

            return sb.ToString();
        }

        public string SecondPrayerPage(Language language)
        {
            var sb = new StringBuilder();
            switch (prayerVersion)
            {
                case 0:
                    sb.Append(language.TodayHeThinks + language.Space +
                        PrayerObject.ObjectSecondForm + language.Dot
                    );
                    break;
                case 1:
                    sb.Append(language.WhenGodMeets
                        .Replace(StringReplacer.PrayerObject2, PrayerObject.ObjectSecondForm)
                        .Replace(StringReplacer.PrayerObject3, PrayerObject.ObjectThirdForm)
                        .Replace(StringReplacer.PrayerObject4, PrayerObject.ObjectFourthForm)
                        + language.Dot);
                    break;
            }

            return sb.ToString();
        }

        public string ThirdPrayerPage(Language language)
        {
            var sb = new StringBuilder();
            switch (prayerVersion)
            {
                case 0:
                    sb.Append(language.GodWantsAll + language.Dot
                ).Replace(StringReplacer.PrayerObject3, PrayerObject.ObjectThirdForm)
                .Replace(StringReplacer.PrayerObject5, PrayerObject.ObjectFifthForm);
                    break;
                case 1:
                    sb.Append(language.GodHides
                        .Replace(StringReplacer.Hide, HideEmoji.ImageDescription)
                        .Replace(StringReplacer.PrayerObject2, PrayerObject.ObjectSecondForm)
                        + language.Dot);
                    break;
            }
            return sb.ToString();
        }

        public string FourthPrayerPage(Language language)
        {
            var sb = new StringBuilder();
            switch (prayerVersion)
            {
                case 0:
                    sb.Append(PrayerObject.ObjectFourthForm +language.Space + language.DoYouThink);
                    break;
                case 1:
                    sb.Append(language.GodIs + language.Dot
                        );
                    break;
            }
            return sb.ToString();
        }

        public EmojiObject GetEmoji(List<EmojiObject> emojiList)
        {
            var random = new Random();
            var emoji = emojiList[random.Next(emojiList.Count)];
            return emoji;
        }

        public string GetWords(List<string> wordList)
        {
            var random = new Random();
            var word = wordList[random.Next(wordList.Count)];
            return word;
        }
    }

    public class AChildsPrayerPage
    {
        public string Text = string.Empty;
        public string Emoji = string.Empty;
        public string ImageDescription = String.Empty;
        public int NrOfEmoji = 0;
        public string Palceholder = string.Empty;
        public int PageNr = 0;
        public bool IsShown = false;
    }
}
