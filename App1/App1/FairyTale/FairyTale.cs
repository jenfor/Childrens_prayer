using System;
using System.Collections.Generic;
using System.Text;

namespace App1.FairyTale
{
    public class TheFairyTale
    {
        private List<String> animals = new List<String>();
        private Dictionary<String, String> emojis = new Dictionary<String, String>();

        private List<String> relationships = new List<String>();
        private List<String> adjectives = new List<String>();
        private List<String> actions = new List<String>();
        private List<String> conditions = new List<String>();
        private List<String> places = new List<String>();
        private List<String> verb = new List<String>();
        private List<String> circumstances = new List<String>();
        private List<String> gender = new List<String>();
        private List<String> conversions = new List<String>();
        private List<String> events = new List<String>();
        private List<String> continuations = new List<String>();
        private List<String> fairyTaleStarts = new List<String>();
        private List<Page> pageList = new List<Page>();
        private List<String> thisFairytaleEmojis = new List<string>();

        private String dot = ". ";
        private String space = " ";
        private String comma = ", ";

        FairyTaleCharacter fairyTaleCharacter1 = null;
        FairyTaleCharacter fairyTaleCharacter2 = null;

        public Page presentPage = new Page();
        private int pageNr = 0;

        public TheFairyTale()
        {
            InitLists();
            
            fairyTaleCharacter1 = GetFairyTaleCharacter();
            fairyTaleCharacter2 = GetFairyTaleCharacter();

            WriteFairyTale();
            TurnThePage();
        }

        public void ViewLastPage()
        {
            if (pageNr > 1)
            {
                pageNr = pageNr-2;
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
                pageList.Add(CreatePage("Radera detta och skriv fortsättingen på sagan här.", GetRandomFairytaleEmoji()));
                presentPage = pageList[pageNr];
                pageNr++;
            }
        }

        public string GetRandomFairytaleEmoji()
        {
            var random = new Random();
            var emoji = thisFairytaleEmojis[random.Next(thisFairytaleEmojis.Count)];
            return emoji;
        }

        public FairyTaleCharacter GetFairyTaleCharacter()
        {
            var fairyTaleCharacter = new FairyTaleCharacter();
            fairyTaleCharacter.animal = GetWords(animals);
            fairyTaleCharacter.adjective = GetWords(adjectives);
            fairyTaleCharacter.name = fairyTaleCharacter.GetFairyTaleName();
            fairyTaleCharacter.gender = GetWords(gender);
            fairyTaleCharacter.relationShip = GetWords(relationships);
            fairyTaleCharacter.emoji = emojis[fairyTaleCharacter.animal];

            return fairyTaleCharacter;
        }

        public void WriteFairyTale()
        {
            thisFairytaleEmojis.Clear();
            pageList.Add(CreatePage(PresentFairyTaleCharacter1(), fairyTaleCharacter1.emoji));
            thisFairytaleEmojis.Add(fairyTaleCharacter1.emoji);
            pageList.Add(CreatePage(PresentFairyTaleCharacter2(), fairyTaleCharacter2.emoji));
            thisFairytaleEmojis.Add(fairyTaleCharacter2.emoji);
            pageList.Add(CreatePage(PresentFairyTalePlace(), fairyTaleCharacter1.emoji));
            thisFairytaleEmojis.Add(fairyTaleCharacter1.emoji);
            pageList.Add(CreatePage(PresentFairyTaleEvent(), fairyTaleCharacter2.emoji));
            thisFairytaleEmojis.Add(fairyTaleCharacter2.emoji);
            pageList.Add(CreatePage(PresentFairyTalecontinuation(), fairyTaleCharacter1.emoji));
            thisFairytaleEmojis.Add(fairyTaleCharacter1.emoji);

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
                fairyTaleCharacter1?.adjective + space + fairyTaleCharacter1?.animal + space + "som hette "
                        + fairyTaleCharacter1?.name + dot
            );
            return sb.ToString();
        }

        public String PresentFairyTaleCharacter2()
        {
            var sb = new StringBuilder();

            sb.Append(
                fairyTaleCharacter1?.gender + " hade en " + fairyTaleCharacter2?.adjective
                        + space + fairyTaleCharacter2?.relationShip + comma + "en " + fairyTaleCharacter2?.animal + " som kallades för " + fairyTaleCharacter2?.name + dot
            );

            return sb.ToString();
        }

        public String PresentFairyTalePlace()
        {
            var sb = new StringBuilder();

            sb.Append(
                "De två " + GetWords(verb) + space + GetWords(actions) + " att allt " + GetWords(
                    places
                ) + " var " + GetWords(conditions) + dot
            );

            sb.Append("Det " + GetWords(circumstances) + dot);

            return sb.ToString();
        }

        public String PresentFairyTaleEvent()
        {
            var sb = new StringBuilder();

            sb.Append(fairyTaleCharacter1?.name + space + GetWords(conversions) + dot);
            sb.Append(fairyTaleCharacter1?.gender + space + GetWords(events) + dot);

            return sb.ToString();
        }

        public String PresentFairyTalecontinuation()
        {
            var sb = new StringBuilder();

            sb.Append(GetWords(continuations) + space + fairyTaleCharacter2?.name + "..." + "\n \n Radera detta och skriv fortättningen av sagan här.");

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

            animals.Add("larv");
            emojis.Add("larv", "\U0001F41B");

            animals.Add("orm");
            emojis.Add("orm", "\U0001F40D");

            animals.Add("hamster");
            emojis.Add("hamster", "\U0001F439");

            animals.Add("sköldpadda");
            emojis.Add("sköldpadda", "\U0001F422");

            animals.Add("katt");
            emojis.Add("katt", "\U0001F431");

            animals.Add("snigel");
            emojis.Add("snigel", "\U0001F40C");

            animals.Add("groda");
            emojis.Add("groda", "\U0001F438");

            animals.Add("nyckelpiga");
            emojis.Add("nyckelpiga", "\U0001F41E");

            animals.Add("fågel");
            emojis.Add("fågel", "\U0001F426");

            animals.Add("myra");
            emojis.Add("myra", "\U0001F41C");

            animals.Add("näbbmus");
            emojis.Add("näbbmus", "\U0001F42D");

            animals.Add("kyckling");
            emojis.Add("kyckling", "\U0001F425");

            animals.Add("pingvin");
            emojis.Add("pingvin", "\U0001F427");

            animals.Add("koala");
            emojis.Add("koala", "\U0001F428");

            /*animals?.Add("höna")
            emojis.Add("höna", "\U0001F414")*/

            animals.Add("apa");
            emojis.Add("apa", "\U0001F412");

            animals.Add("hund");
            emojis.Add("hund", "\U0001F436");

            animals.Add("panda");
            emojis.Add("panda", "\U0001F43C");

            animals.Add("kanin");
            emojis.Add("kanin", "\U0001F407");

            animals.Add("råtta");
            emojis.Add("råtta", "\U0001F401");

            animals.Add("get");
            emojis.Add("get", "\U0001F410");

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
            places.Add("på deras planet");
            places.Add("i deras stad");
            places.Add("i deras land");
            places.Add("i deras hembygd");
            places.Add("i deras by");
            places.Add("i skogen, där de bodde,");

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
            events.Add("började packa en väska för att det skulle se ut som att det var dags att ge sig ut på en längre resa");
            events.Add("började med att säga till alla att det var en mycket viktig dag idag");
            events.Add("påstod att om alla samarbetade kunde de tilsammans bygga en rymdraket");// toDo: Byt till olika substantiv
            events.Add("trodde att det var lätt som en plätt att bygga en egen bil");// toDo: Byt till olika substantiv
            events.Add("menade att det var möjligt att bygga städer på havsbotten");
            events.Add("ville starta en ny sorts godisfabrik");
            events.Add("låtsades att han var stor nog att börja i skolan redan nu");// toDo: ändra han till gender
            events.Add("hade kommit på iden att sätta segel på ryggen");
            events.Add("hade bestämt sig för att uppfinna vingar som fungerade för alla");
            events.Add("ville ordna en flygkurs för alla");
            events.Add("tänkte klä ut sig till en god fe och dela ut tre önskningar");
            events.Add("trodde det var enkelt att bygga ett stort slott av sandkorn");
            events.Add("ville bevisa att det fortfarande fanns levande drakar");
            events.Add("hade hittat en flaska som det kunde vara en ande i");
            events.Add("trodde sig ha hittat en ny väg till månen");
            events.Add("hade hittat platsen där regnbågen börjar");

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
