using App1.Languages;
using System;
using System.Collections.Generic;
using System.Text;

namespace App1.FairyTale
{
    public class TheFairyTale
    {
        public Page PresentPage = new Page();
        public int PageNr = 0;
        private List<Page> pageList = new List<Page>();
        
        private FairyTaleCharacter fairyTaleCharacter1 = null;
        private FairyTaleCharacter fairyTaleCharacter2 = null;
        private FairyTalePlace fairyTalePalce = null;
        private FairyTaleEvent fairyTaleEvent = null;

        private List<String> thisFairytaleEmojis = new List<string>();

        public TheFairyTale(Language language)
        {
            WriteFairyTale(language);
            ViewNextPage(language);
        }

        public void WriteFairyTale(Language language)
        {
            PageNr = 0;
            pageList.Clear();
            thisFairytaleEmojis.Clear();

            fairyTaleCharacter1 = GetFairyTaleCharacter(language);
            fairyTaleCharacter2 = GetFairyTaleCharacter(language);
            fairyTalePalce = GetFairyTalePlace(language);
            fairyTaleEvent = GetFairyTaleEvent(language);

            pageList.Add(CreatePage(PresentFairyTaleCharacter1(language), fairyTaleCharacter1.Emoji, string.Empty));
            thisFairytaleEmojis.Add(fairyTaleCharacter1.Emoji);

            pageList.Add(CreatePage(PresentFairyTaleCharacter2(language), fairyTaleCharacter2.Emoji, string.Empty));
            thisFairytaleEmojis.Add(fairyTaleCharacter2.Emoji);

            pageList.Add(CreatePage(PresentFairyTalePlace(language), fairyTalePalce.Emoji, string.Empty)); 
            thisFairytaleEmojis.Add(fairyTalePalce.Emoji);

            pageList.Add(CreatePage(PresentFairyTaleEvent(language), fairyTaleCharacter1.Emoji + fairyTaleEvent.Emoji, string.Empty));
            thisFairytaleEmojis.Add(fairyTaleEvent.Emoji);

            pageList.Add(CreatePage(String.Empty, fairyTaleEvent.Emoji + fairyTaleCharacter2.Emoji, PresentFairyTaleContinuation(language)));
            thisFairytaleEmojis.Add(fairyTaleCharacter1.Emoji);
        }

        public void ViewPreviousPage()
        {
            if (PageNr >= 2)
            {
                PageNr -= 2;
                PresentPage = pageList[PageNr];
                PageNr++;
            }
        }

        public void ViewNextPage(Language language)
        {
            if (PageNr >= pageList.Count)
            {
                pageList.Add(CreatePage(string.Empty, GetRandomFairyTaleEmojis(), language.ExchangeString));
            }

            PresentPage = pageList[PageNr];
            PageNr++;
        }

        public FairyTaleCharacter GetFairyTaleCharacter(Language language)
        {           
            var animals = new List<string>(language.Animals.Keys);
            var animal = GetWords(animals);
            return new FairyTaleCharacter(animal, GetWords(language.Adjectives), GetWords(language.Gender), GetWords(language.Relationships), language.Animals[animal]);
        }

        public FairyTalePlace GetFairyTalePlace(Language language)
        {
            var places = new List<string>(language.Places.Keys);
            var place = GetWords(places);
            return new FairyTalePlace(GetWords(language.Verb), GetWords(language.Conditions), place, GetWords(language.Circumstances), GetWords(language.Actions), language.Places[place]);
        }

        public FairyTaleEvent GetFairyTaleEvent(Language language)
        {
            var events = new List<string>(language.Events.Keys);
            var e = GetWords(events);
            return new FairyTaleEvent(e, GetWords(language.Conversions), language.Events[e]);
        }

        public string GetRandomFairyTaleEmojis()
        {
            var emoji1 = CreateAndSkipEqualEmojis(null, thisFairytaleEmojis); 
            var emoji2 = CreateAndSkipEqualEmojis(emoji1, thisFairytaleEmojis); 

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

        public Page CreatePage(string text, string emoji, string placeholder)
        {
            var page = new Page();
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
                language.They + fairyTalePalce.Verb + language.Space + fairyTalePalce.Action + language.ThatEverything + fairyTalePalce.Place
                 + language.Was + fairyTalePalce.Condition + language.Dot
            );

            sb.Append(language.It + fairyTalePalce.Circumstance.Replace("---", fairyTalePalce.Condition) + language.Dot);

            return sb.ToString();
        }

        public string PresentFairyTaleEvent(Language language)
        {
            var sb = new StringBuilder();

            sb.Append(fairyTaleCharacter1.Name + language.Space + fairyTaleEvent.Conversion + language.Dot);
            sb.Append(fairyTaleCharacter1.Gender + language.Space + fairyTaleEvent.Event.Replace("---", fairyTaleCharacter1.Gender.ToLower()) + language.Dot);

            return sb.ToString();
        }

        public string PresentFairyTaleContinuation(Language language)
        {
            var sb = new StringBuilder();

            sb.Append(GetWords(language.Continuations).Replace("---", fairyTaleCharacter1.Gender) + language.Space + fairyTaleCharacter2.Name + language.Dots + language.NewLine + language.NewLine + language.Space + language.ExchangeString);

            return sb.ToString();
        }

        public string GetWords(List<string> wordList)
        {
            var random = new Random();
            var word = wordList[random.Next(wordList.Count)];
            return word;
        }
    }

    public class Page
    {
        public string Text = string.Empty;
        public string Emoji = string.Empty;
        public string Palceholder = string.Empty;
    }
}
