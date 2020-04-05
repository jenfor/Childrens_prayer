using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Languages
{
    public class Swedish : Language
    {
        public string NewFairyTale => "Ny saga";
        public string ShareFairyTale => "Dela sagan";
        public string BackFairyTale => "Tillbaka";
        public string ContinueFairyTale => "Fortsätt";
        public string VersionOption => "Vill du skriva en kort saga?";

        public string BackToStartPageWarning => "Är du säker på att du vill gå tillbaka till startsidan? Den här sagan kommer raderas.";
        public string Warning => "Varning";
        public string Question => "Fråga";
        public string Deletion => "Är du säker på att du vill radera den här sagan och skapa en ny?";
        public string Yes => "Ja";
        public string No => "Nej";

        public string ExchangeString => "Nu är det din tur att använda din fantasi för att skriva fortsättningen på sagan här.";
        public string WasNamed => "som hette ";
        public string HadA => " hade en ";
        public string A => "en ";
        public string WhoWasCalled => " som kallades för ";
        public string And => " och ";
        public string ThatEverything => " att allt ";
        public string Was => " var ";
        public string Dots => "...";
        public String Dot => ". ";
        public String Space => " ";
        public String Comma => ", ";
        public String NewLine => "\n ";

        public Dictionary<string, string> Animals => new Dictionary<string, string>()
        {
            { "ekorre", "\U0001F43F" },
            {"igelkott", "\U0001F994"},
            {"fladdermus", "\U0001F987"},
            //{"skunk", "\U0001F9A8"},
            //{"grävling", "\U0001F9A1"},
            {"duva", "\U0001F54A"},
            {"örn", "\U0001F985"},
            {"gräsand", "\U0001F986"},
            //{"svan", "\U0001F9A2"},
            {"påfågel", "\U0001F99A"},
            //{"papegoja", "\U0001F99C"},
            {"uggla", "\U0001F989"},
            {"spindel", "\U0001F577"},
            {"skorpion", "\U0001F982"},
            {"larv", "\U0001F41B"},
            {"orm", "\U0001F40D"},
            {"hamster", "\U0001F439"},
            {"sköldpadda", "\U0001F422"},
            {"katt", "\U0001F431"},
            {"snigel", "\U0001F40C"},
            {"groda", "\U0001F438"},
            {"nyckelpiga", "\U0001F41E"},
            {"fågel", "\U0001F426"},
            {"myra", "\U0001F41C"},
            {"näbbmus", "\U0001F42D"},
            {"kyckling", "\U0001F425"},
            {"pingvin", "\U0001F427"},
            {"koala", "\U0001F428"},
            //{"höna", "\U0001F414"},
            {"apa", "\U0001F412"},
            {"hund", "\U0001F436"},
            {"panda", "\U0001F43C"},
            {"kanin", "\U0001F407"},
            {"råtta", "\U0001F401"},
            {"get", "\U0001F410"},
            {"fjäril", "\U0001F98B"},
        }; 
        
        public Dictionary<string, string> Places => new Dictionary<string, string>()
        {
            {"på jorden", "\U0001F30D"},
            //{"på deras planet", "\U0001FA90"},// ToDo: Fix this emoji
            {"i deras stad", "\U0001F306"},
            {"i deras land", "\U0001F304"},
            {"i deras hembygd", "\U0001F3DE"},
            {"i deras by", "\U0001F3D8"},
            {"i skogen, där de bodde,", "\U0001F333"}
        };
        
        public Dictionary<string, string> Events => new Dictionary<string, string>()
        {
            {"hade bestämt sig för att ordna en stor låtsasfest dit alla skulle vara bjudna", "\U0001F382" },
            {"började packa en väska för att det skulle se ut som att det var dags att ge sig ut på en längre resa", "\U0001F45C"},
            {"började med att säga till alla att det var en mycket viktig dag idag", "\U0001F338"},
            {"påstod att om alla samarbetade kunde de tilsammans bygga ett rymdskepp", "\U0001F6F8"},
            {"trodde att det var lätt som en plätt att bygga en egen bil", "\U0001F698"},
            {"menade att det var möjligt att bygga städer på havsbotten", "\U0001F30A"},
            {"ville starta en ny sorts godisfabrik", "\U0001F36C" + "\U0001F36D"},
            {"låtsades att " + StringReplacer.Character1_Gender +" var stor nog att börja i skolan redan nu", "\U0001F3EB"},
            {"hade kommit på idén att sätta segel på ryggen", "\U0001F32C"},
            {"hade bestämt sig för att uppfinna vingar som fungerade för alla", "\U0001F4B8"},
            {"ville ordna en flygkurs för alla", "\U0001F6E9"},
            {"tänkte klä ut sig till en god fe och dela ut tre önskningar", "\U0001FA84"},// ToDo: Fix this emoji
            {"trodde det var enkelt att bygga ett stort slott av sandkorn", "\U0001F3F0"},
            {"ville bevisa att det fortfarande fanns levande drakar", "\U0001F409"},
            {"hade hittat en lampa som det kunde vara en ande i", "\U0001FA94"},// ToDo: Fix this emoji
            {"trodde sig ha hittat en ny väg till månen", "\U0001F314"},
            {"hade hittat platsen där regnbågen börjar", "\U0001F308"}
        };

        public List<string> FairyTaleStarts => new List<string>()
        {
            "Det fanns en gång en",
            "För ca 100 år sedan levde en",
            "En gång fanns det en",
            "Vissa tror inte det är sant, men en gång för länge sedan fanns det en",
            "Långt, långt härifrån fanns det en gång en",
            "I en förtrollad värld fanns det en gång en",
            "I en annan tid än vår levde en gång en",
            "I en värld där ingen människa satt ännu sin fot levde en gång en",
            "Utan att någon människa kände till det fanns det en gång en",
            "Långt borta från all uppmärksamhet levde en gång en",
            "I en värld väldigt olik vår levde en gång en",
            "Bakom en hemlig dörr, i ett stort sett bortglömt hus, gömmer sig en hel värld. I den världen levde en gång en",
            "I ett låtsasland, som bara finns i vår fantasi, levde en gång en",
            "Inte långt härifrån bodde en gång en",
            "Precis under din säng finns det ett litet hål."
                    + " Det hålet är så litet att ingen människa kan se det, men inuti det finns det en hel värld."
                    + " I den världen bodde en gång en"
        };

        public List<string> Relationships => new List<string>()
        {
             "vän",
            "ovän",
            "fiende",
            "kompis"
        };

        public List<string> Adjectives => new List<string>()
        {
            "glad",
            "fin",
            "rolig",
            "busig",
            "lustig",
            "bussig",
            "smart",
            "nervös",
            "listig",
            "nyfiken",
            "vilsen",
            "populär",
            "gladlynt"
        };

        public List<string> Actions => new List<string>()
        {
            "leka",
            "låtsas",
            "påstå",
            "lura i alla de kände",
            "få alla att tro",
            "övertala varandra",
            "säga"
        };

        public List<string> Conditions => new List<string>()
        {
            "som i ett stort krig",
            "fredligt",
            "ljuvligt",
            "besvärligt",
            "underbart",
            "förfärligt",
            "lite underligt",
            "lite knasigt"
        };

        public List<string> Verb => new List<string>()
        {
            "brukade",
            "verkade tycka om att",
            "gillade att",
            "trodde att de kunde"
        };

        public List<string> Circumstances => new List<string>()
        {
            "Det var det ibland också, men inte just nu",
            "Det var det också vid vissa tillfällen, faktiskt också just nu",
            "Men det var det inte i verkligheten, inte just nu iallafall",
            "Men det var det inte, verkligheten var långt där ifrån",
            "Det var det också, men för en som inte kände till det var det svårt att tro",
        };

        public List<string> Gender => new List<string>()
        {
            "Hon",
            "Han"
        };

        public List<string> Conversions => new List<string>()
        {
            "ville ta tag i saker och få någonting nytt att hända",
            "ville genomföra sina egna planer",
            "ville hitta på någonting riktigt busigt",
            "hade kommit på någonting riktigt roligt",
            "hade kommit på en ny spännande idé",
            "ville pröva någonting nytt",
            "ville testa en ny idé",
            "ville förverkliga en av sina egna idéer",
            "ville göra en stor förändring i sitt liv",
            "ville se till att saker och ting förändrades",
            "ville ge alla en stor överraskning",
        };

        public List<string> Continuations => new List<string>()
        {
            "Då visade det sig att",
            "Då började",
            "Då sa",
            "Då ville",
            "Då vägrade",
            "Då kom",
            "Då visade"
        };
    }
}
