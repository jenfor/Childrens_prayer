using App1.Languages;
using System;
using System.Collections.Generic;
using System.Text;

namespace App1.FairyTale
{
    public class TheFairyTale
    {
        public FairyTalePage PresentPage = new FairyTalePage();
        public int PageNr = 0;
        private List<FairyTalePage> pageList = new List<FairyTalePage>();
        
        private FairyTaleCharacter fairyTaleCharacter1 = null;
        private FairyTaleCharacter fairyTaleCharacter2 = null;
        private FairyTalePlace fairyTalePalce = null;
        private FairyTaleEvent fairyTaleEvent = null;

        private List<String> thisFairyTaleEmojis = new List<string>();

        public TheFairyTale(Language language)
        {
            WriteFairyTale(language);
            ViewNextPage(language);
        }

        public void WriteFairyTale(Language language)
        {
            PageNr = 0;
            pageList.Clear();
            thisFairyTaleEmojis.Clear();

            GetFairyTaleCharacters(language);

            fairyTalePalce = GetFairyTalePlace(language);
            fairyTaleEvent = GetFairyTaleEvent(language);

            pageList.Add(CreatePage(PresentFairyTaleCharacter1(language), fairyTaleCharacter1.Emoji, string.Empty));
            thisFairyTaleEmojis.Add(fairyTaleCharacter1.Emoji);

            pageList.Add(CreatePage(PresentFairyTaleCharacter2(language), fairyTaleCharacter2.Emoji, string.Empty));
            thisFairyTaleEmojis.Add(fairyTaleCharacter2.Emoji);

            pageList.Add(CreatePage(PresentFairyTalePlace(language), fairyTalePalce.Emoji, string.Empty)); 
            thisFairyTaleEmojis.Add(fairyTalePalce.Emoji);

            pageList.Add(CreatePage(PresentFairyTaleEvent(language), fairyTaleCharacter1.Emoji + fairyTaleEvent.Emoji, string.Empty));
            thisFairyTaleEmojis.Add(fairyTaleEvent.Emoji);

            pageList.Add(CreatePage(String.Empty, fairyTaleEvent.Emoji + fairyTaleCharacter2.Emoji, PresentFairyTaleContinuation(language)));
            thisFairyTaleEmojis.Add(fairyTaleCharacter1.Emoji);
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
                pageList.Add(CreatePage(string.Empty, GetRandomFairyTaleEmojis(), 
                    language.ExchangeString.Replace(StringReplacer.Character1_Animal, fairyTaleCharacter1.Animal)
                    .Replace(StringReplacer.Character1_Name, fairyTaleCharacter1.Name)
                    .Replace(StringReplacer.Character2_Animal, fairyTaleCharacter2.Animal)
                    .Replace(StringReplacer.Character2_Name, fairyTaleCharacter2.Name)));
            }

            PresentPage = pageList[PageNr];
            PageNr++;
        }

        private void GetFairyTaleCharacters(Language language)
        {
            fairyTaleCharacter1 = GetFairyTaleCharacter(language);
            fairyTaleCharacter2 = GetFairyTaleCharacter(language);

            while (fairyTaleCharacter1.Name.Equals(fairyTaleCharacter2.Name))
            {
                fairyTaleCharacter2 = GetFairyTaleCharacter(language);
            }
        }

        public FairyTaleCharacter GetFairyTaleCharacter(Language language)
        {           
            var animals = new List<string>(language.Animals.Keys);
            var animal = GetWords(animals);
            return new FairyTaleCharacter(animal, GetWords(language.CharacterAdjectives), GetWords(language.Gender), GetWords(language.Relationships), language.Animals[animal]);
        }

        public FairyTalePlace GetFairyTalePlace(Language language)
        {
            var places = new List<string>(language.Places.Keys);
            var place = GetWords(places);
            return new FairyTalePlace(GetWords(language.Verb2), GetWords(language.PlaceAdjectives), place, GetWords(language.Circumstances), GetWords(language.Verb1), language.Places[place]);
        }

        public FairyTaleEvent GetFairyTaleEvent(Language language)
        {
            var events = new List<string>(language.Events.Keys);
            var e = GetWords(events);
            return new FairyTaleEvent(e, GetWords(language.Actions), language.Events[e]);
        }

        public string GetRandomFairyTaleEmojis()
        {
            var emoji1 = CreateAndSkipEqualEmojis(null, thisFairyTaleEmojis); 
            var emoji2 = CreateAndSkipEqualEmojis(emoji1, thisFairyTaleEmojis); 

            return emoji1 + emoji2;
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

            return emoji1 + emoji2 + emoji3;
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

        public FairyTalePage CreatePage(string text, string emoji, string placeholder)
        {
            var page = new FairyTalePage();
            page.Text = text;
            page.Emoji = emoji;
            page.Palceholder = placeholder;
            return page;
        }

        public string GetFairytaleString(Language language)
        {
            var sb = new StringBuilder();

            foreach(var page in pageList)
            {
                sb.Append(page.Text);
                sb.Append(page.Emoji);
                sb.Append(language.NewLine);
                sb.Append(language.NewLine);

            }
            return sb.ToString();
        }

        public string PresentFairyTaleCharacter1(Language language)
        {
            var sb = new StringBuilder();

            sb.Append(GetWords(language.FairyTaleStarts) + language.Space);
            sb.Append(
                fairyTaleCharacter1.Adjective + language.Space + fairyTaleCharacter1.Animal + language.Space + language.WasNamed
                        + fairyTaleCharacter1.Name + language.Dot
            );
            return sb.ToString();
        }

        public string PresentFairyTaleCharacter2(Language language)
        {
            var sb = new StringBuilder();

            sb.Append(
                fairyTaleCharacter1.Gender + language.HadA + fairyTaleCharacter2.Adjective
                        + language.Space + fairyTaleCharacter2.RelationShip + language.Comma + language.A + fairyTaleCharacter2.Animal + language.WhoWasCalled + fairyTaleCharacter2.Name + language.Dot
            );

            return sb.ToString();
        }

        public string PresentFairyTalePlace(Language language)
        {
            var sb = new StringBuilder();

            sb.Append(
                fairyTaleCharacter1.Name + language.And + fairyTaleCharacter2.Name + language.Space + fairyTalePalce.Verb + language.Space + fairyTalePalce.Action + language.ThatEverything + fairyTalePalce.Place
                 + language.Was + fairyTalePalce.Condition + language.Dot + language.NewLine + language.NewLine
            );

            sb.Append(fairyTalePalce.Circumstance.Replace(StringReplacer.Place_Condition, fairyTalePalce.Condition).Replace(StringReplacer.Place, fairyTalePalce.Place) + language.Dot);

            return sb.ToString();
        }

        public string PresentFairyTaleEvent(Language language)
        {
            var sb = new StringBuilder();

            sb.Append(fairyTaleCharacter1.Name + language.Space + fairyTaleEvent.Conversion.Replace(StringReplacer.Place, fairyTalePalce.Place) + language.Dot + language.NewLine + language.NewLine);
            sb.Append(fairyTaleCharacter1.Gender + language.Space + fairyTaleEvent.Event.Replace(StringReplacer.Character1_Gender, fairyTaleCharacter1.Gender.ToLower()) + language.Dot);

            return sb.ToString();
        }

        public string PresentFairyTaleContinuation(Language language)
        {
            var sb = new StringBuilder();

            sb.Append(GetWords(language.Continuations).Replace(StringReplacer.Character1_Gender, fairyTaleCharacter1.Gender) + language.Space + fairyTaleCharacter2.Name + language.Dots + language.NewLine + language.NewLine
                + language.ExchangeString.Replace(StringReplacer.Character1_Animal, fairyTaleCharacter1.Animal)
                    .Replace(StringReplacer.Character1_Name, fairyTaleCharacter1.Name)
                    .Replace(StringReplacer.Character2_Animal, fairyTaleCharacter2.Animal)
                    .Replace(StringReplacer.Character2_Name, fairyTaleCharacter2.Name));

            return sb.ToString();
        }

        public string GetWords(List<string> wordList)
        {
            var random = new Random();
            var word = wordList[random.Next(wordList.Count)];
            return word;
        }
    }

    public class FairyTalePage
    {
        public string Text = string.Empty;
        public string Emoji = string.Empty;
        public string Palceholder = string.Empty;
    }
}
