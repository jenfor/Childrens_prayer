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

        public PrayerObject PrayerObject = null;
        
        //public FairyTaleCharacter fairyTaleCharacter1 = null;
        //public FairyTaleCharacter fairyTaleCharacter2 = null;
        //public FairyTalePlace fairyTalePalce = null;
        //public FairyTaleEvent fairyTaleEvent = null;

        private List<String> thisPrayerEmojis = new List<string>();

        public ThePrayer(Language language)
        {
            WritePrayer(language);
            ViewNextPage(language);
        }

        public void WritePrayer(Language language)
        {
            PageNr = 0;
            pageList.Clear();
            thisPrayerEmojis.Clear();

            PrayerObject = GetPrayerObject(language);

            pageList.Add(CreatePage(PrayerStart(language), PrayerObject.Emoji, PrayerObject.ImageDescription, string.Empty, PageNr, 1));
            thisPrayerEmojis.Add(PrayerObject.Emoji + "," + PrayerObject.ImageDescription);
            pageList.Add(CreatePage(SecondPrayerPage(language), PrayerObject.Emoji, PrayerObject.ImageDescription, string.Empty, PageNr+1, 1));
            pageList.Add(CreatePage(ThirdPrayerPage(language), PrayerObject.Emoji, PrayerObject.ImageDescription, string.Empty, PageNr + 2, 1));
            pageList.Add(CreatePage(FourthPrayerPage(language), language.LoveEmoji, PrayerObject.ImageDescription, string.Empty, PageNr + 3, 1));

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

        public PrayerObject GetPrayerObject(Language language)
        {
            var random = new Random();
            var prayerObject = language.PrayerObjects[random.Next(language.PrayerObjects.Count)];
            return prayerObject;
        }

        public string GetRandomEmojis(Language language)
        {            
            var allEmojis = new List<String>();
            allEmojis.AddRange(new List<string>(language.Animals.Values));
            allEmojis.AddRange(new List<string>(language.Places.Values));
            allEmojis.AddRange(new List<string>(language.Events.Values));

            var emoji1 = CreateAndSkipEqualEmojis(null, allEmojis);
            var emoji2 = CreateAndSkipEqualEmojis(emoji1, allEmojis); 
            var emoji3 = CreateAndSkipEqualEmojis(emoji2, allEmojis);

            return emoji1.Split(',')[0] + emoji2.Split(',')[0] + emoji3.Split(',')[0];
        } 

        private string CreateAndSkipEqualEmojis(string emoji1, List<String> allEmojis)
        {
            var random = new Random();
            var emoji2 = allEmojis[random.Next(allEmojis.Count)];

            while (emoji2.Equals(emoji1))
            {
                emoji2 = allEmojis[random.Next(allEmojis.Count)];
            }

            return emoji2;
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
            sb.Append(language.God + language.Space +
                GetWords(language.GodCareVerb) + language.Space
                + language.All + language.Space
                + PrayerObject.ObjectFirstForm + language.Dot
                );

            return sb.ToString();
        }

        public string SecondPrayerPage(Language language)
        {
            var sb = new StringBuilder();
            sb.Append(language.TodayHeThinks + language.Space +
                PrayerObject.ObjectSecondForm + language.Dot
                );

            return sb.ToString();
        }

        public string ThirdPrayerPage(Language language)
        {
            var sb = new StringBuilder();
            sb.Append(language.GodWantsAll + language.Dot
                ).Replace(StringReplacer.PrayerObject3, PrayerObject.ObjectThirdForm);

            return sb.ToString();
        }

        public string FourthPrayerPage(Language language)
        {
            var sb = new StringBuilder();
            sb.Append(PrayerObject.ObjectFourthForm +language.Space + language.DoYouThink);

            return sb.ToString();
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
