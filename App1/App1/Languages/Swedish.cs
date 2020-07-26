using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Languages
{
    public class Swedish : Language
    {
        public string BackToStart => "Tillbaka till start";
        public string ShareFairyTale => "Dela sagan";
        public string BackFairyTale => "Tillbaka";
        public string ContinueFairyTale => "Fortsätt";
        public string ViewFairyTale => "Visa/Dela sagan";
        public string NewImage => "Byt bild";

        public string VersionOption => "Vilken sorts saga vill du skriva?";

        public string BackToStartPageWarning => "Är du säker på att du vill gå tillbaka till startmenyn?" + NewLine + NewLine + "Den här bönen kommer att tas bort.";
        public string Warning => "Varning";
        public string Question => "Fråga";
        public string Information => "Nu är det din tur";

        public string Deletion => "Är du säker på att du vill ta bort den här bönen och läsa en ny?";
        public string Short => "En kort saga";
        public string Long => "En lång saga";

        public string Yes => "Ja";
        public string No => "Nej";

        public string TapHere => "Tryck här och skriv!";

        public string InformationExchangeString => "Nu är det din tur att skriva mer om " 
                    + StringReplacer.Character1_Name + " och "
                    + StringReplacer.Character2_Name + "." + NewLine + NewLine
                    + "Tryck på sagotexten på den här sidan och börja skriv!";

        public string ExchangeString => "Tryck här och skriv om " 
                    + StringReplacer.Character1_Name + " och "
                    + StringReplacer.Character2_Name + Dot;

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
        public String NewLine => "\n";

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
            {"på jorden", "\U0001F30D" + ",jorden"},
            {"på deras planet", "\U0001FA90" + ",deras planet"},// ToDo: Fix this emoji
            {"i deras stad", "\U0001F306" + ",staden"},
            {"i deras land", "\U0001F304" + ",en bild från deras land"},
            {"i deras hembygd", "\U0001F3DE" + ",hembygden"},
            {"i deras by", "\U0001F3D8" + ",byn"},
            {"i skogen", "\U0001F333" + ",ett träd från skogen"}
        };
        
        public Dictionary<string, string> Events => new Dictionary<string, string>()
        {
            {"hade bestämt sig för att ordna en stor låtsasfest dit alla skulle vara bjudna",
                "\U0001F382" + ",en tårta"},
            {"började packa en väska för att det skulle se ut som att " + StringReplacer.Character1_Gender + " var på väg ut på en längre resa"
                , "\U0001F45C" + ",en väska"},
            {"började med att säga till alla att det var en mycket viktig dag idag",
                "\U0001F338" + ",en blomma"},
            {"påstod att om alla samarbetade kunde de tilsammans bygga ett rymdskepp",
                "\U0001F6F8"  + ",ett rymdskepp"},
            {"trodde att det var lätt som en plätt att bygga en bil",
                "\U0001F698" + ",en bil"},
            {"menade att det var möjligt att bygga städer på havsbotten",
                "\U0001F30A"  + ",en havsvåg"},
            {"ville starta en ny sorts godisfabrik",
                "\U0001F36C" + "\U0001F36D"  + ",godiset"},
            {"låtsades att " + StringReplacer.Character1_Gender +" var stor nog att börja i skolan redan nu",
                "\U0001F3EB" + ",skolan"},
            {"hade kommit på idén att sätta segel på ryggen",
                "\U0001F32C"  + ",vinden"},
            {"hade bestämt sig för att uppfinna vingar som fungerade för alla",
                "\U0001F4B8" + ",pengar med vingar"},
            {"ville ordna en flygkurs för alla",
                "\U0001F6E9"  + ",ett flygplan"},
            //{"tänkte klä ut sig till en god fe och dela ut tre önskningar", "\U0001FA84" + ", ett trollspö"},// ToDo: Fix this emoji
            {"trodde det var enkelt att bygga ett stort slott av sandkorn",
                "\U0001F3F0" + ",ett stort slott"},
            {"ville ta reda på om det fortfarande fanns levande drakar",
                "\U0001F409"  + ",en drake"},
            //{"hade hittat en lampa som det kunde vara en ande i", "\U0001FA94"},// ToDo: Fix this emoji
            {"trodde sig ha hittat en ny väg till månen",
                "\U0001F314" + ",månen"},
            {"hade hittat platsen där regnbågen börjar",
                "\U0001F308" + ",regnbågen"}
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
            "I en värld där ingen människa ännu satt sin fot levde en gång en",
            "Utan att någon människa kände till det fanns det en gång en",
            "Långt borta från all uppmärksamhet levde en gång en",
            "I en värld väldigt olik vår levde en gång en",
            "Bakom en hemlig dörr, i ett stort sett bortglömt hus, gömmer sig en hel värld. I den världen levde en gång en",
            "I ett låtsasland, som bara finns i vår fantasi, levde en gång en",
            "Inte långt härifrån bodde en gång en",
            "Precis under din säng finns det ett litet hål."
                    + " Det är så litet att ingen människa kan se det, men inuti finns det en hel värld."
                    + " I den världen bodde en"
        };

        public List<string> Relationships => new List<string>()
        {
            "vän",
            "ovän",
            "fiende",
            "kompis"
        };

        public List<string> BadRelationships => new List<string>()
        {
            "ovän",
            "fiende",
        };

        public List<string> CharacterAdjectives => new List<string>()
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

        public List<string> BadRelationshipsAdjectives => new List<string>()
        {
            "dum",
            "arg",
            "elak",
        };

        public List<string> Verb1 => new List<string>()
        {
            "leka",
            "låtsas",
            "påstå",
            "lura i alla de kände",
            "få alla att tro",
            "övertala varandra",
            "säga"
        };

        public List<string> PlaceAdjectives => new List<string>()
        {
            "möjligt",
            "ljuvligt",
            "besvärligt",
            "underbart",
            "förfärligt",
            "underligt",
            "lite knasigt"
        };

        public List<string> Verb2 => new List<string>()
        {
            "brukade",
            "tyckte om att",
            "gillade att",
            "ville"
        };

        public List<string> Circumstances => new List<string>()
        {
            //"Ibland var det " + StringReplacer.Place_Condition + " " + StringReplacer.Place + " också, men inte just nu",
            //"Det var faktiskt " + StringReplacer.Place_Condition + " " + StringReplacer.Place + " också",
            //"Men det var inte " + StringReplacer.Place_Condition + " " + StringReplacer.Place + ", inte just nu iallafall",
            //"Men det var inte " + StringReplacer.Place_Condition + " " + StringReplacer.Place + " nu, verkligheten var långt därifrån",
            //"Det var på sätt och vis " + StringReplacer.Place_Condition + " " + StringReplacer.Place + " också, men för vissa det var svårt att tro",

            "Det kunde vara " + StringReplacer.Place_Condition + " " + StringReplacer.Place + " på många sätt",
            "Men det var inte så " + StringReplacer.Place_Condition + " " + StringReplacer.Place + " idag",
        };

        public List<string> Gender => new List<string>()
        {
            "Hon",
            "Han"
        };

        public List<string> Actions => new List<string>()
        {
            "Just idag ville " + StringReplacer.Character1_Name + " ta tag i saker och få någonting nytt att hända",
            StringReplacer.Character1_Name + " ville genomföra sina egna planer",
            "Idag ville " + StringReplacer.Character1_Name + " hitta på någonting riktigt busigt",
            StringReplacer.Character1_Name + " hade kommit på någonting riktigt roligt",
            StringReplacer.Character1_Name + " hade kommit på en ny spännande idé",
            "Idag skulle " + StringReplacer.Character1_Name + " pröva någonting nytt",
            StringReplacer.Character1_Name + " skulle testa en ny idé",
            StringReplacer.Character1_Name + " ville förverkliga en av sina egna drömmar",
            StringReplacer.Character1_Name + " ville göra en stor förändring i sitt liv",
            StringReplacer.Character1_Name + " ville se till att saker och ting förändrades",
            "Idag ville " +StringReplacer.Character1_Name + " ge alla en stor överraskning",
        };

        public List<string> Continuations => new List<string>()
        {
            "Då började",
            "Då sa",
            "Då ville",
            "Då vägrade",
            "Då kom",
            "Då visade"
        };

        // Addition A childs prayer
        public string God => "Gud";
        public string All => "alla";

        public List<string> GodCareVerb => new List<string>()
        {
            "älskar",
            "möter",
            "bryr sig om"
        };

        public Dictionary<string, string> Loves_MeetsList => new Dictionary<string, string>()
        {
            {"på jorden", "\U0001F30D" + ", "},
            {"dig", "\U0001FA90" + ", "},
            {"dina vänner", "\U0001F306" + ", "},
            {"i din familj", "\U0001F304" + ", "},
            {"djuren", "\U0001F3DE" + ", "},
            {"växterna", "\U0001F3D8" + ", "},
            {"i hela världen", "\U0001F30D" + ", "},
            {"haven", "\U0001F30D" + ", "},
            {"sjöarna", "\U0001F30D" + ", "},
            {"träden", "\U0001F30D" + ", "},
        };
    }
}
