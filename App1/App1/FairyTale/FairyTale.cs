using System;
using System.Collections.Generic;
using System.Text;

namespace App1.FairyTale
{
    public class TheFairyTale
    {
        private List<String> animals = new List<String>();
        private Dictionary<String, String> characterEmojis = new Dictionary<String, String>();
        private List<String> relationships = new List<String>();
        private List<String> adjectives = new List<String>();
        private List<String> actions = new List<String>();
        private List<String> conditions = new List<String>();
        private List<String> places = new List<String>();
        private Dictionary<String, String> placeEmojis = new Dictionary<String, String>();
        private List<String> verb = new List<String>(); 
        private List<String> circumstances = new List<String>();
        private List<String> gender = new List<String>();
        private List<String> conversions = new List<String>();
        private List<String> events = new List<String>();
        private Dictionary<String, String> eventEmojis = new Dictionary<String, String>();
        private List<String> continuations = new List<String>();
        private List<String> fairyTaleStarts = new List<String>();
        private List<Page> pageList = new List<Page>();
        private List<String> thisFairytaleEmojis = new List<string>();

        private String dot = ". ";
        private String space = " ";
        private String comma = ", ";

        FairyTaleCharacter fairyTaleCharacter1 = null;
        FairyTaleCharacter fairyTaleCharacter2 = null;
        FairyTalePlace fairyTalePalce = null;
        FairyTaleEvent fairyTaleEvent = null;

        public Page presentPage = new Page();
        public int pageNr = 0;

        public TheFairyTale()
        {
            InitLists();
            
            fairyTaleCharacter1 = GetFairyTaleCharacter();
            fairyTaleCharacter2 = GetFairyTaleCharacter();
            fairyTalePalce = GetFairyTalePlace();
            fairyTaleEvent = GetFairyTaleEvent();

            WriteFairyTale();
            TurnThePage();
        }

        public void ViewPreviousPage()
        {
            if (pageNr > 1)
            {
                pageNr -= 2;
                presentPage = pageList[pageNr];
                pageNr++;
            }
        }

        public void TurnThePage()
        {
            if (pageNr < pageList.Count)
            {
                presentPage = pageList[pageNr];
                pageNr++;
            }
            else
            {
                pageList.Add(CreatePage("Radera detta och skriv fortsättingen på sagan här.", GetRandomFairytaleEmojis()));
                presentPage = pageList[pageNr];
                pageNr++;
            }
        }

        public string GetRandomFairytaleEmojis()
        {
            var random = new Random();
            var emoji1 = thisFairytaleEmojis[random.Next(thisFairytaleEmojis.Count)];
            var emoji2 = thisFairytaleEmojis[random.Next(thisFairytaleEmojis.Count)];

            while(emoji1.Equals(emoji2))
            {
                emoji2 = thisFairytaleEmojis[random.Next(thisFairytaleEmojis.Count)];
            }

            return emoji1 + emoji2;
        }

        public FairyTaleCharacter GetFairyTaleCharacter()
        {
            var animal = GetWords(animals);
            return new FairyTaleCharacter(animal, GetWords(adjectives), GetWords(gender), GetWords(relationships), characterEmojis[animal]);
        }

        public FairyTalePlace GetFairyTalePlace()
        {
            var place = GetWords(places);
            return new FairyTalePlace(GetWords(verb), GetWords(conditions), place, GetWords(circumstances), GetWords(actions), placeEmojis[place]);
        }

        public FairyTaleEvent GetFairyTaleEvent()
        {
            var e = GetWords(events);
            return new FairyTaleEvent(e, GetWords(conversions), eventEmojis[e]);
        }

        public void WriteFairyTale()
        {
            thisFairytaleEmojis.Clear();

            pageList.Add(CreatePage(PresentFairyTaleCharacter1(), fairyTaleCharacter1.Emoji));
            thisFairytaleEmojis.Add(fairyTaleCharacter1.Emoji);

            pageList.Add(CreatePage(PresentFairyTaleCharacter2(), fairyTaleCharacter2.Emoji));
            thisFairytaleEmojis.Add(fairyTaleCharacter2.Emoji);

            pageList.Add(CreatePage(PresentFairyTalePlace(), fairyTalePalce.Emoji));
            thisFairytaleEmojis.Add(fairyTalePalce.Emoji);

            pageList.Add(CreatePage(PresentFairyTaleEvent(), fairyTaleEvent.Emoji));
            thisFairytaleEmojis.Add(fairyTaleEvent.Emoji);

            pageList.Add(CreatePage(PresentFairyTaleContinuation(), fairyTaleCharacter2.Emoji));
            thisFairytaleEmojis.Add(fairyTaleCharacter1.Emoji);
        }

        public Page CreatePage(String text, String emoji)
        {
            var page = new Page();
            page.Text = text;
            page.Emoji = emoji;
            return page;
        }

        public String PresentFairyTaleCharacter1()
        {
            var sb = new StringBuilder();

            sb.Append(GetWords(fairyTaleStarts) + space);
            sb.Append(
                fairyTaleCharacter1.Adjective + space + fairyTaleCharacter1?.Animal + space + "som hette "
                        + fairyTaleCharacter1?.Name + dot
            );
            return sb.ToString();
        }

        public String PresentFairyTaleCharacter2()
        {
            var sb = new StringBuilder();

            sb.Append(
                fairyTaleCharacter1?.Gender + " hade en " + fairyTaleCharacter2?.Adjective
                        + space + fairyTaleCharacter2.RelationShip + comma + "en " + fairyTaleCharacter2?.Animal + " som kallades för " + fairyTaleCharacter2?.Name + dot
            );

            return sb.ToString();
        }

        public String PresentFairyTalePlace()
        {
            var sb = new StringBuilder();

            sb.Append(
                "De två " + fairyTalePalce.Verb + space + fairyTalePalce.Action + " att allt " + fairyTalePalce.Place
                 + " var " + fairyTalePalce.Condition + dot
            );

            sb.Append("Det " + GetWords(circumstances) + dot);

            return sb.ToString();
        }

        public String PresentFairyTaleEvent()
        {
            var sb = new StringBuilder();

            sb.Append(fairyTaleCharacter1?.Name + space + fairyTaleEvent.Conversion + dot);
            sb.Append(fairyTaleCharacter1?.Gender + space + fairyTaleEvent.Event + dot);

            return sb.ToString();
        }

        public String PresentFairyTaleContinuation()
        {
            var sb = new StringBuilder();

            sb.Append(GetWords(continuations) + space + fairyTaleCharacter2?.Name + "..." + "\n \nRadera detta och skriv fortättningen av sagan här.");

            return sb.ToString();
        }

        public string GetWords(List<String> wordList)
        {
            var random = new Random();
            var word = wordList[random.Next(wordList.Count)];
            return word;
        }


        private void InitLists()
        {
            fairyTaleStarts.Add("Det fanns en gång en");
            fairyTaleStarts.Add("För ca 100 år sedan levde en");
            fairyTaleStarts.Add("En gång fanns det en");
            fairyTaleStarts.Add("Vissa tror inte det är sant, men en gång för länge sedan fanns det en");
            fairyTaleStarts.Add("Långt, långt härifrån fanns det en gång en");
            fairyTaleStarts.Add("I en förtrollad värld fanns det en gång en");
            fairyTaleStarts.Add("I en annan tid än vår levde en gång en");
            fairyTaleStarts.Add("I en värld där ingen människa satt ännu sin fot levde en gång en");
            fairyTaleStarts.Add("Utan att någon människa kände till det fanns det en gång en");
            fairyTaleStarts.Add("Långt borta från all uppmärksamhet levde en gång en");
            fairyTaleStarts.Add("I en värld väldigt olik vår levde en gång en");
            fairyTaleStarts.Add("Bakom en hemlig dörr, i ett stort sett bortglömt hus, gömmer sig en hel värld. I den världen levde en gång en");
            fairyTaleStarts.Add("I ett låtsasland, som bara finns i vår fantasi, levde en gång en");
            fairyTaleStarts.Add("Inte långt härifrån bodde en gång en");
            fairyTaleStarts.Add(
            "Precis under din säng, den sängen du brukar sova i, finns det ett litet, litet hål."
                    + " Det hålet är så litet att ingen människa kan se det, men inuti det finns det en hel värld."
                    + " I den världen bodde en gång en ");

            gender.Add("Hon");
            gender.Add("Han");

            animals.Add("ekorre");
            characterEmojis.Add("ekorre", "\U0001F43F");

            animals.Add("igelkott");
            characterEmojis.Add("igelkott", "\U0001F994");

            animals.Add("fladdermus");
            characterEmojis.Add("fladdermus", "\U0001F987");

            animals.Add("skunk");
            characterEmojis.Add("skunk", "\U0001F9A8");

            animals.Add("grävling");
            characterEmojis.Add("grävling", "\U0001F9A1");

            animals.Add("duva");
            characterEmojis.Add("duva", "\U0001F54A");

            animals.Add("örn");
            characterEmojis.Add("örn", "\U0001F985");

            animals.Add("gräsand");
            characterEmojis.Add("gräsand", "\U0001F986");

            animals.Add("svan");
            characterEmojis.Add("svan", "\U0001F9A2");

            animals.Add("påfågel");
            characterEmojis.Add("påfågel", "\U0001F99A");

            animals.Add("papegoja");
            characterEmojis.Add("papegoja", "\U0001F99C");

            animals.Add("uggla");
            characterEmojis.Add("uggla", "\U0001F989");

            animals.Add("spindel");
            characterEmojis.Add("spindel", "\U0001F577");

            animals.Add("skorpion");
            characterEmojis.Add("skorpion", "\U0001F982");

            animals.Add("larv");
            characterEmojis.Add("larv", "\U0001F41B");

            animals.Add("orm");
            characterEmojis.Add("orm", "\U0001F40D");

            animals.Add("hamster");
            characterEmojis.Add("hamster", "\U0001F439");

            animals.Add("sköldpadda");
            characterEmojis.Add("sköldpadda", "\U0001F422");

            animals.Add("katt");
            characterEmojis.Add("katt", "\U0001F431");

            animals.Add("snigel");
            characterEmojis.Add("snigel", "\U0001F40C");

            animals.Add("groda");
            characterEmojis.Add("groda", "\U0001F438");

            animals.Add("nyckelpiga");
            characterEmojis.Add("nyckelpiga", "\U0001F41E");

            animals.Add("fågel");
            characterEmojis.Add("fågel", "\U0001F426");

            animals.Add("myra");
            characterEmojis.Add("myra", "\U0001F41C");

            animals.Add("näbbmus");
            characterEmojis.Add("näbbmus", "\U0001F42D");

            animals.Add("kyckling");
            characterEmojis.Add("kyckling", "\U0001F425");

            animals.Add("pingvin");
            characterEmojis.Add("pingvin", "\U0001F427");

            animals.Add("koala");
            characterEmojis.Add("koala", "\U0001F428");

            /*animals?.Add("höna")
            characterEmojis.Add("höna", "\U0001F414")*/

            animals.Add("apa");
            characterEmojis.Add("apa", "\U0001F412");

            animals.Add("hund");
            characterEmojis.Add("hund", "\U0001F436");

            animals.Add("panda");
            characterEmojis.Add("panda", "\U0001F43C");

            animals.Add("kanin");
            characterEmojis.Add("kanin", "\U0001F407");

            animals.Add("råtta");
            characterEmojis.Add("råtta", "\U0001F401");

            animals.Add("get");
            characterEmojis.Add("get", "\U0001F410");

            adjectives.Add("glad");
            adjectives.Add("fin");
            adjectives.Add("rolig");
            adjectives.Add("busig");
            adjectives.Add("lustig");
            adjectives.Add("bussig");
            adjectives.Add("smart");
            adjectives.Add("nervös");
            adjectives.Add("listig");
            adjectives.Add("nyfiken");
            adjectives.Add("vilsen");
            adjectives.Add("populär");
            adjectives.Add("gladlynt");

            relationships.Add("vän");
            relationships.Add("ovän");
            relationships.Add("fiende");
            relationships.Add("kompis");

            actions.Add("leka");
            actions.Add("låtsas");
            actions.Add("påstå");
            actions.Add("lura i alla de kände");
            actions.Add("få alla att tro");
            actions.Add("intala varandra");
            actions.Add("säga");

            conditions.Add("som i ett stort krig");
            conditions.Add("fredligt");
            conditions.Add("ljuvligt");
            conditions.Add("besvärligt");
            conditions.Add("underbart");
            conditions.Add("förfärligt");
            conditions.Add("lite underligt");
            conditions.Add("lite knasigt");

            places.Add("på jorden");
            placeEmojis.Add("på jorden", "\U0001F30D");

            places.Add("på deras planet");
            placeEmojis.Add("på deras planet", "\U0001FA90");

            places.Add("i deras stad");
            placeEmojis.Add("i deras stad", "\U0001F306");

            places.Add("i deras land");
            placeEmojis.Add("i deras land", "\U0001F304");

            places.Add("i deras hembygd");
            placeEmojis.Add("i deras hembygd", "\U0001F3DEU");

            places.Add("i deras by");
            placeEmojis.Add("i deras by", "\U0001F3D8");

            places.Add("i skogen, där de bodde,");
            placeEmojis.Add("i skogen", "\U0001F333");

            verb.Add("brukade");
            verb.Add("verkade tycka om att");
            verb.Add("gillade att");
            verb.Add("trodde att de kunde");

            circumstances.Add("var det ibland också, men inte just nu");
            circumstances.Add("var det också vid vissa tillfällen, faktiskt också just nu");
            circumstances.Add("var det inte i verkligheten, inte just nu iallafall");
            circumstances.Add("var det inte, verkligheten var långt där ifrån");
            circumstances.Add("var det också, men för en som inte kände till det var det svårt att tro");

            conversions.Add("ville ta tag i saker och få någonting nytt att hända");
            conversions.Add("ville genomföra sina egna planer");
            conversions.Add("ville hitta på någonting riktigt busigt");
            conversions.Add("hade kommit på någonting riktigt roligt");
            conversions.Add("hade kommit på en ny spännande ide");
            conversions.Add("ville pröva någonting nytt");
            conversions.Add("ville testa en ny ide");
            conversions.Add("ville förverkliga en av sina egna ideer");
            conversions.Add("ville göra en stor förändring i sitt liv");
            conversions.Add("ville se till att saker och ting förändrades");
            conversions.Add("ville ge alla en stor överraskning");

            events.Add("hade bestämt sig för att ordna en stor låtsasfest dit alla skulle vara bjudna");
            eventEmojis.Add("hade bestämt sig för att ordna en stor låtsasfest dit alla skulle vara bjudna", "\U0001F382");

            events.Add("började packa en väska för att det skulle se ut som att det var dags att ge sig ut på en längre resa");
            eventEmojis.Add("började packa en väska för att det skulle se ut som att det var dags att ge sig ut på en längre resa", "\U0001F45C");

            events.Add("började med att säga till alla att det var en mycket viktig dag idag");
            eventEmojis.Add("började med att säga till alla att det var en mycket viktig dag idag", "\U0001F338	");

            events.Add("påstod att om alla samarbetade kunde de tilsammans bygga en rymdraket");// toDo: Byt till olika substantiv
            eventEmojis.Add("påstod att om alla samarbetade kunde de tilsammans bygga en rymdraket", "\U0001F6F8");

            events.Add("trodde att det var lätt som en plätt att bygga en egen bil");// toDo: Byt till olika substantiv
            eventEmojis.Add("trodde att det var lätt som en plätt att bygga en egen bil", "\U0001F698");

            events.Add("menade att det var möjligt att bygga städer på havsbotten");
            eventEmojis.Add("menade att det var möjligt att bygga städer på havsbotten", "\U0001F30A");

            events.Add("ville starta en ny sorts godisfabrik");
            eventEmojis.Add("ville starta en ny sorts godisfabrik", "\U0001F36C" + "\U0001F36D");

            events.Add("låtsades att han var stor nog att börja i skolan redan nu");// toDo: ändra han till gender
            eventEmojis.Add("låtsades att han var stor nog att börja i skolan redan nu", "\U0001F3EB");

            events.Add("hade kommit på iden att sätta segel på ryggen");
            eventEmojis.Add("hade kommit på iden att sätta segel på ryggen", "\U0001F32C");

            events.Add("hade bestämt sig för att uppfinna vingar som fungerade för alla");
            eventEmojis.Add("hade bestämt sig för att uppfinna vingar som fungerade för alla", "\U0001F4B8");

            events.Add("ville ordna en flygkurs för alla");
            eventEmojis.Add("ville ordna en flygkurs för alla", "\U0001F6E9");

            events.Add("tänkte klä ut sig till en god fe och dela ut tre önskningar");
            eventEmojis.Add("tänkte klä ut sig till en god fe och dela ut tre önskningar", "\U0001FA84");

            events.Add("trodde det var enkelt att bygga ett stort slott av sandkorn");
            eventEmojis.Add("trodde det var enkelt att bygga ett stort slott av sandkorn", "\U0001F3F0");

            events.Add("ville bevisa att det fortfarande fanns levande drakar");
            eventEmojis.Add("ville bevisa att det fortfarande fanns levande drakar", "\U0001F409	");

            events.Add("hade hittat en lampa som det kunde vara en ande i");
            eventEmojis.Add("hade hittat en lampa som det kunde vara en ande i", "\U0001FA94");

            events.Add("trodde sig ha hittat en ny väg till månen");
            eventEmojis.Add("trodde sig ha hittat en ny väg till månen", "\U0001F314");

            events.Add("hade hittat platsen där regnbågen börjar");
            eventEmojis.Add("hade hittat platsen där regnbågen börjar", "\U0001F308");


            continuations.Add("Då visade det sig att");
            continuations.Add("Då började");
            continuations.Add("Då sa");
            continuations.Add("Då ville");
            continuations.Add("Då vägrade");
            continuations.Add("Då kom");
            continuations.Add("Då visade");
        }
    }

    public class Page
    {
        public String Text = "Det var en gång en höna...";
        public String Emoji = String.Empty;
    }
}
