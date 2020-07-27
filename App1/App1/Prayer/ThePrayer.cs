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

            //fairyTalePalce = GetFairyTalePlace(language);
            //fairyTaleEvent = GetFairyTaleEvent(language);

            //pageList.Add(CreatePage(PresentFairyTaleCharacter1(language), fairyTaleCharacter1.Emoji, fairyTaleCharacter1.Name, string.Empty, PageNr, 1));
            //thisFairyTaleEmojis.Add(fairyTaleCharacter1.Emoji + "," + fairyTaleCharacter1.Name);

            //pageList.Add(CreatePage(PresentFairyTaleCharacter2(language), fairyTaleCharacter2.Emoji, fairyTaleCharacter2.Name, string.Empty, PageNr+1, 1));
            //thisFairyTaleEmojis.Add(fairyTaleCharacter2.Emoji + "," + fairyTaleCharacter2.Name); ;

            //pageList.Add(CreatePage(PresentFairyTalePlace(language), fairyTalePalce.Emoji, fairyTalePalce.ImageDescription, string.Empty, PageNr+2)); 
            //thisFairyTaleEmojis.Add(fairyTalePalce.Emoji + "," + fairyTalePalce.ImageDescription);

            //pageList.Add(CreatePage(PresentFairyTaleEvent(language), fairyTaleCharacter1.Emoji + fairyTaleEvent.Emoji,
            //fairyTaleCharacter1.Name + language.And + fairyTaleEvent.ImageDescription, string.Empty, PageNr+3, 2));
            //thisFairyTaleEmojis.Add(fairyTaleEvent.Emoji + "," + fairyTaleEvent.ImageDescription);

            //pageList.Add(CreatePage(String.Empty, fairyTaleEvent.Emoji + fairyTaleCharacter2.Emoji, fairyTaleEvent.ImageDescription + language.And + fairyTaleCharacter2.Name,
            //PresentFairyTaleContinuation(language) + language.TapHere, PageNr+4, 2));

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
                // var s = GetRandomFairyTaleEmojis(language).Split(',');

                /* pageList.Add(CreatePage(string.Empty, s[0], s[1],
                     language.ExchangeString.Replace(StringReplacer.Character1_Animal, fairyTaleCharacter1.Animal)
                     .Replace(StringReplacer.Character1_Name, fairyTaleCharacter1.Name)
                     .Replace(StringReplacer.Character2_Animal, fairyTaleCharacter2.Animal)
                     .Replace(StringReplacer.Character2_Name, fairyTaleCharacter2.Name), PageNr, 2));*/
                return;
            }

            PresentPage = pageList[PageNr];
            PresentPage.IsShown = true;

            PageNr++;
        }

        //private void GetFairyTaleCharacters(Language language)
        //{
            
            //fairyTaleCharacter1 = GetFairyTaleCharacter(language);
            //fairyTaleCharacter2 = GetFairyTaleCharacter(language);

           /* while (fairyTaleCharacter1.Name.Equals(fairyTaleCharacter2.Name))
            {
                fairyTaleCharacter2 = GetFairyTaleCharacter(language);
            }*/
        //}

       /* public FairyTaleCharacter GetFairyTaleCharacter(Language language)
        {
       prayerObject
            var animals = new List<string>(language.Animals.Keys);
            var animal = GetWords(animals);
            var relation = GetWords(language.Relationships);
            string adjectiv = String.Empty;

            if(language.BadRelationships.Contains(relation))
            {
                adjectiv = GetWords(language.BadRelationshipsAdjectives);
            }
            else
            {
                adjectiv = GetWords(language.CharacterAdjectives);
            }

            return new FairyTaleCharacter(animal, adjectiv, GetWords(language.Gender), relation, language.Animals[animal]);
        }*/

      /* public FairyTalePlace GetFairyTalePlace(Language language)
        {
            var places = new List<string>(language.Places.Keys);
            var place = GetWords(places);

            var imageInfo = language.Places[place].Split(',');

            return new FairyTalePlace(GetWords(language.Verb2), GetWords(language.PlaceAdjectives), place, GetWords(language.Circumstances),
                GetWords(language.Verb1), imageInfo[0], imageInfo[1]);
        }*/

        /* public FairyTaleEvent GetFairyTaleEvent(Language language)
        {
            var events = new List<string>(language.Events.Keys);
            var e = GetWords(events);
            var imageInfo = language.Events[e].Split(',');
            return new FairyTaleEvent(e, GetWords(language.Actions), imageInfo[0], imageInfo[1]);
        }*/

        public PrayerObject GetPrayerObject(Language language)
        {
            var random = new Random();
            var prayerObject = language.PrayerObjects[random.Next(language.PrayerObjects.Count)];
            return prayerObject;
        }

        /*public string GetRandomFairyTaleEmojis(Language language)
        {
            var emoji1 = CreateAndSkipEqualEmojis(null, thisFairyTaleEmojis); 
            var emoji2 = CreateAndSkipEqualEmojis(emoji1, thisFairyTaleEmojis); 

            return emoji1.Split(',')[0] + emoji2.Split(',')[0] + "," + emoji1.Split(',')[1] + language.And + emoji2.Split(',')[1];
        }*/

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

        /* public string PresentFairyTaleCharacter1(Language language)
         {
             var sb = new StringBuilder();

             //sb.Append(GetWords(language.FairyTaleStarts) + language.Space)
             /*sb.Append(
                 fairyTaleCharacter1.Adjective + language.Space + fairyTaleCharacter1.Animal + language.Space + language.WasNamed
                         + fairyTaleCharacter1.Name + language.Dot*/
        //);
        //return sb.ToString();
        //}

        /*public string PresentFairyTaleCharacter2(Language language)
        {
            var sb = new StringBuilder();

            /*sb.Append(
                fairyTaleCharacter1.Gender + language.HadA + fairyTaleCharacter2.Adjective
                        + language.Space + fairyTaleCharacter2.RelationShip + language.Comma + language.A + fairyTaleCharacter2.Animal + language.WhoWasCalled + fairyTaleCharacter2.Name + language.Dot
            );*/

        //return sb.ToString();
        //}

        /*public string PresentFairyTalePlace(Language language)
        {
            var sb = new StringBuilder();

            /*sb.Append(
                fairyTaleCharacter1.Name + language.And + fairyTaleCharacter2.Name + language.Space + fairyTalePalce.Verb + language.Space + fairyTalePalce.Action + language.ThatEverything
                + fairyTalePalce.Place + language.Was + fairyTalePalce.Condition + language.Dot
            );*/

        //sb.Append(fairyTalePalce.Circumstance.Replace(StringReplacer.Place_Condition, fairyTalePalce.Condition).Replace(StringReplacer.Place, fairyTalePalce.Place) + language.Dot);

        //return sb.ToString();
        //}

        //public string PresentFairyTaleEvent(Language language)
        //{
        //var sb = new StringBuilder();

        /* sb.Append(fairyTaleEvent.Action.Replace(StringReplacer.Place, fairyTalePalce.Place).Replace(StringReplacer.Character1_Name, fairyTaleCharacter1.Name) + language.Dot);
         sb.Append(fairyTaleCharacter1.Gender + language.Space + fairyTaleEvent.Event.Replace(StringReplacer.Character1_Gender, fairyTaleCharacter1.Gender.ToLower()).Replace(StringReplacer.Place, fairyTalePalce.Place) + language.Dot);
        */
        //return sb.ToString();
        //}

        //public string PresentFairyTaleContinuation(Language language)
        //{
        //var sb = new StringBuilder();

        //sb.Append(GetWords(language.Continuations).Replace(StringReplacer.Character1_Gender, fairyTaleCharacter1.Gender) + language.Space + fairyTaleCharacter2.Name + language.Dots);

        //return sb.ToString();
        //}

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
