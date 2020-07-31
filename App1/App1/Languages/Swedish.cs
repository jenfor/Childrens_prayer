using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using App1.Prayer;

namespace App1.Languages
{
    public class Swedish : Language
    {
        public string BackToStart => "Tillbaka till start";
        public string ShareFairyTale => "Dela bönen";
        public string BackFairyTale => "Tillbaka";
        public string ContinueFairyTale => "Fortsätt";
        public string ViewFairyTale => "Visa hela bönen";
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

        public string InformationExchangeString => "Nu är det din tur att skriva mer om ";
                    //+ StringReplacer.Character1_Name + " och "
                   // + StringReplacer.Character2_Name + "." + NewLine + NewLine
                    //+ "Tryck på sagotexten på den här sidan och börja skriv!";

        public string ExchangeString => "Tryck här och skriv om ";
                    //+ StringReplacer.Character1_Name + " och "
                    //+ StringReplacer.Character2_Name + Dot;

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

        // Addition A childs prayer
        public string God => "Gud";
        public string All => "alla";
        public string TodayHeThinks => "Idag tänker han särskilt mycket på";
        public string GodWantsAll => "Gud vill att " + StringReplacer.PrayerObject3 + " ska ha "/*ett bra liv "*/ + StringReplacer.PrayerObject5 + " många fina upplevelser";
        public string DoYouThink => "tänker du särskilt på idag?";
        public string GodLoves => "Gud älskar";
        public string WhenGodMeets => "När Gud möter " + StringReplacer.PrayerObject2
                                + " vill han att " + StringReplacer.PrayerObject3
                                + " ska förstå hur " + StringReplacer.PrayerObject4;
        public string GodHides => "Ibland gömmer sig Gud bakom " + StringReplacer.Hide + " och leker kurragömma med " + StringReplacer.PrayerObject2;
        public string GodIs => "Gud finns överallt";



        public List<string> GodCareVerb => new List<string>()
        {
            "älskar",
            "möter",
            "bryr sig om"
        };

        public List<PrayerObject> Prayer1Objects => new List<PrayerObject>()
        {
            {new PrayerObject("människor",Humans,"oss människor", "alla människor", "Vilken människa" , "bra liv med", 1) },
            {new PrayerObject("på jorden",Earth,"vår jord", "alla på jorden", "Vad på jorden" , "bra liv med",1) },
            {new PrayerObject("som är som dig", Children, "dig", "du", "Vad", "ett bra live med",2)},
            {new PrayerObject("dina vänner", Children ,"en vän", "alla dina vänner", "Vilken vän", "bra liv med", 2)},
            {new PrayerObject("i din familj", Families , "din familj", "alla i din familj", "Vem", "ett bra liv med", 1)},
            {new PrayerObject("djur", Animals , "ett djur", "alla djur", "Vilket djur", "bra liv med", 1)},
            {new PrayerObject("växter", Plants , "en växt", "alla växter", "Vilken växt", "bra liv som kan ge", 1)},
            {new PrayerObject("i hela världen", Earth , "vår värld", "alla i hela världen", "Vad i världen", "bra liv med", 1)},
            {new PrayerObject("hav", Seas, "ett hav", "alla hav", "Vilket hav", "bra liv som kan ge", 1)},
            {new PrayerObject("sjöar", Lakes , "en sjö", "alla sjöar", "Vilken sjö", "bra liv som kan ge",1)},
            {new PrayerObject("träd", Trees, "ett träd", "alla träd", "Vilket träd", "bra liv som kan ge", 1)},
        };

        public List<PrayerObject> Prayer2Objects => new List<PrayerObject>()
        {
            {new PrayerObject("alla människor", Humans ,"en männska", "hon", "underbar hon är", String.Empty, 1) },
            {new PrayerObject("dig", Children, "dig", "du", "underbar du är", String.Empty, 1)},
            {new PrayerObject("alla dina vänner", Humans , "dina vänner", "de", "underbara de är", String.Empty, 1)},
            {new PrayerObject("din familj", Families , "din familj", "ni", "underbara ni är", String.Empty, 1)},
        };

        public List<EmojiObject> Animals => new List<EmojiObject>
        {
            {new EmojiObject( "en ekorre", "\U0001F43F") },
            {new EmojiObject("en igelkott", "\U0001F994")},
            {new EmojiObject("en duva", "\U0001F54A")},
            //{new EmojiObject("en påfågel", "\U0001F99A")},
            {new EmojiObject("en uggla", "\U0001F989")},
            {new EmojiObject(" en larv", "\U0001F41B")},
            {new EmojiObject("en hamnster", "\U0001F439")},
            {new EmojiObject("en sköldpadda", "\U0001F422")},
            {new EmojiObject("en snigel", "\U0001F40C")},
            {new EmojiObject("en groda", "\U0001F438")},
            {new EmojiObject("en nyckelpiga", "\U0001F41E")},
            {new EmojiObject("en myra", "\U0001F41C")},
            {new EmojiObject("en kyckling", "\U0001F425")},
            {new EmojiObject("en koala", "\U0001F428")},
            {new EmojiObject("en apa", "\U0001F412")},
            {new EmojiObject("en kanin", "\U0001F407")},
            {new EmojiObject("en råtta ", "\U0001F401")},
            {new EmojiObject("ett bi", "\U0001F41D")},
            {new EmojiObject("en fjäril", "\U0001F98B")},
            {new EmojiObject("en hund", "🐕‍🦺")},
            {new EmojiObject("en katt", "🐈")},
            {new EmojiObject("en ko", "🐄")},
        };

        public List<EmojiObject> Hides => new List<EmojiObject>
        {
            {new EmojiObject( "en blomma", "\U0001F337") },
            {new EmojiObject("ett träd", "\U0001F333")},
            {new EmojiObject("en leksak", "\U0001F9F8")},
            {new EmojiObject("en frukt", "\U0001F34F")},
            {new EmojiObject("ett moln", "\U0001F325")},
            {new EmojiObject("ett djur", "\U0001F408")},
            {new EmojiObject("en grönsak", "\U0001F955")},
            {new EmojiObject("en glass", "\U0001F366")},
            {new EmojiObject("en pusselbit", "\U0001F9E9")},//Problem android
        };

        public List<EmojiObject> Plants => new List<EmojiObject>
        {
            {new EmojiObject( "ett träd", "\U0001F333") },
            {new EmojiObject( "en palm", "\U0001F334") },
            {new EmojiObject( "en planta", "\U0001F331") },
            {new EmojiObject( "en planta", "\U0001F340") },
            {new EmojiObject( "en kaktus", "\U0001F335") },
            {new EmojiObject( "en visnande blomma", "\U0001F940") },
            {new EmojiObject( "en solros", "\U0001F33B") },
            {new EmojiObject( "en tulpan", "\U0001F337") },
            {new EmojiObject( "en hibiscus", "\U0001F33A") },
            {new EmojiObject( "en ros", "\U0001F339") },
            {new EmojiObject( "en körsbärsblomma", "\U0001F339") },
        };

        public List<EmojiObject> Fruits => new List<EmojiObject>
        {
            {new EmojiObject( "vindruvor", "\U0001F347") },
            {new EmojiObject( "en vattenmelon", "\U0001F349") },
            {new EmojiObject( "en citron", "\U0001F34B") },
            {new EmojiObject( "en banan", "\U0001F34C") },
            {new EmojiObject( "en annanas", "\U0001F34D") },
            {new EmojiObject( "ett äpple", "\U0001F34F") },
            {new EmojiObject( "en jordgubbe", "\U0001F353") },
        };

        public List<EmojiObject> Vegetables => new List<EmojiObject>
        {
            {new EmojiObject( "en avocado", "\U0001F951") },
            {new EmojiObject( "en morot", "\U0001F955") },
            {new EmojiObject( "en majskolv", "\U0001F33D") },
            {new EmojiObject( "en gurka", "\U0001F952") },
            {new EmojiObject( "en lök", "\U0001F9C5") },
        };

        public List<EmojiObject> Trees => new List<EmojiObject>
        {
            {new EmojiObject( "ett träd", "\U0001F333") },
            {new EmojiObject( "en palm", "\U0001F334") },
            {new EmojiObject( "en gran", "\U0001F332") },
        };

        public List<EmojiObject> Families => new List<EmojiObject>
        {
            {new EmojiObject( "en familj", "👨‍👩‍👦‍👦") },
            {new EmojiObject( "en familj", "👩‍👦‍👦") },
            {new EmojiObject( "en familj", " 👨‍👦‍👦") },

        };

        public List<EmojiObject> Children => new List<EmojiObject>
        {
            //{new EmojiObject( "en flicka", "🧎🏻‍♀️ 1") },
            //{new EmojiObject( "en flicka", "🧎🏼‍♀️ 2") },
           //{new EmojiObject( "en flicka", "🧎🏽‍♀️ 3" ) },
            //{new EmojiObject( "en flicka", "🧎🏾‍♀️ 4") },
            //{new EmojiObject( "en flicka", "🧎🏿‍♀️ 5") },
            //{new EmojiObject( "en flicka", "🧎‍♂️ 6") },

            //{new EmojiObject( "en pojke", "🧎🏻 1") },
            //{new EmojiObject( "en pojke", "🧎🏼 2") },
            //{new EmojiObject( "en pojke", "🧎🏽 3") },
            //{new EmojiObject( "en pojke", "🧎🏽 4") },
            //{new EmojiObject( "en pojke", "🧎🏾 5") },
            //{new EmojiObject( "en pojke", "🧎🏿 6") },

            {new EmojiObject( "en pojke", "🚶‍♂️") }, // Funkar!!
            {new EmojiObject( "en pojke", "🚶🏻‍♂️") },
            {new EmojiObject( "en pojke", "🚶🏼‍♂️") },// funkar!!
            {new EmojiObject( "en pojke", "🚶🏽‍♂️") }, // Funkar!!
            {new EmojiObject( "en pojke", "🚶🏾‍♂️") }, // Funkar!!
            {new EmojiObject( "en pojke", "🚶🏿‍♂️") },

            {new EmojiObject( "en flicka", "🚶‍♀") }, // Funkar!!
            {new EmojiObject( "en flicka", "🚶🏻‍♀️") }, // Funkar!!
            {new EmojiObject( "en flicka", "🚶🏼‍♀️") }, // Funkar!!
            {new EmojiObject( "en flicka", "🚶🏽‍♀️") }, // Funkar!!
            {new EmojiObject( "en flicka", "🚶🏾‍♀️") }, // Funkar!!
            {new EmojiObject( "en flicka", "🚶🏿‍♀️") },

           // {new EmojiObject( "en pojke", "🧍 7") },
           // {new EmojiObject( "en pojke", "🧍🏻 8") },
           // {new EmojiObject( "en pojke", "🧍🏼 9") },
            //{new EmojiObject( "en pojke", "🧍🏽 10") },
           // {new EmojiObject( "en pojke", "🧍🏾 11") },
            //{new EmojiObject( "en pojke", "🧍🏿 12") },

           // {new EmojiObject( "en flicka", "🧍‍♀️ 13") },
           // {new EmojiObject( "en flicka", "🧍🏻‍♀️ 14" ) },
            //{new EmojiObject( "en flicka", "🧍🏼‍♀️ 15") },
            //{new EmojiObject( "en flicka", "🧍🏽‍♀️ 16") },
            //{new EmojiObject( "en flicka", "🧍🏾‍♀️ 17") },
           // {new EmojiObject( "en flicka", "🧍🏿‍♀️ 18") },
        };

        public List<EmojiObject> Seas => new List<EmojiObject>
        {
            {new EmojiObject( "the sea", "💧") },
            {new EmojiObject( "the sea", "🌊") },

        };

        public List<EmojiObject> Lakes => new List<EmojiObject>
        {
            {new EmojiObject( "a lake", "💦") },
            {new EmojiObject( "the sea", "💧") },
        };

        public List<EmojiObject> Humans => new List<EmojiObject>
        {
            {new EmojiObject( "en kvinna och en man som håller varandra i handen", "👩🏻‍🤝‍👨🏼") },
            {new EmojiObject( "en kvinna och en man som håller varandra i handen", "👩🏻‍🤝‍👨🏼") },
            {new EmojiObject( "en kvinna och en man som håller varandra i handen", "👩🏻‍🤝‍👨🏼") },
            {new EmojiObject( "en kvinna och en man som håller varandra i handen", "👩🏼‍🤝‍👨🏿") },
            {new EmojiObject( "en kvinna och en man som håller varandra i handen", "👩🏾‍🤝‍👨🏼") },
            {new EmojiObject( "en kvinna och en man som håller varandra i handen", "👩🏿‍🤝‍👨🏻") },
            {new EmojiObject( "en kvinna och en man som håller varandra i handen", "👩🏻‍🤝‍👨🏿") },
            {new EmojiObject( "en kvinna och en man som håller varandra i handen", "👩🏽‍🤝‍👨🏼") },

           // {new EmojiObject( "en flicka", "🧎🏻‍♀️") },
            //{new EmojiObject( "en flicka", "🧎🏼‍♀️") },
           // {new EmojiObject( "en flicka", "🧎🏽‍♀️") },
           // {new EmojiObject( "en flicka", "🧎🏾‍♀️") },
            //{new EmojiObject( "en flicka", "🧎🏿‍♀️") },
            //{new EmojiObject( "en flicka", "🧎‍♂️") },

            //{new EmojiObject( "en pojke", "🧎🏻") },
            //{new EmojiObject( "en pojke", "🧎🏼") },
            //{new EmojiObject( "en pojke", "🧎🏽") },
            //{new EmojiObject( "en pojke", "🧎🏽") },
            //{new EmojiObject( "en pojke", "🧎🏾") },
            //{new EmojiObject( "en pojke", "🧎🏿") },

            //{new EmojiObject( "en pojke", "🚶‍♂️") },
            //{new EmojiObject( "en pojke", "🚶🏻‍♂️") },
            //{new EmojiObject( "en pojke", "🚶🏼‍♂️") },
            //{new EmojiObject( "en pojke", "🚶🏽‍♂️") },
            //{new EmojiObject( "en pojke", "🚶🏾‍♂️") },
            //{new EmojiObject( "en pojke", "🚶🏿‍♂️") },

            //{new EmojiObject( "en flicka", "🚶‍♀️") },
            //{new EmojiObject( "en flicka", "🚶🏻‍♀️") },
            //{new EmojiObject( "en flicka", "🚶🏼‍♀️") },
            //{new EmojiObject( "en flicka", "🚶🏽‍♀️") },
            //{new EmojiObject( "en flicka", "🚶🏾‍♀️") },
            //{new EmojiObject( "en flicka", "🚶🏿‍♀️") },

            //{new EmojiObject( "en pojke", "🧍") },
            //{new EmojiObject( "en pojke", "🧍🏻") },
            //{new EmojiObject( "en pojke", "🧍🏼") },
            //{new EmojiObject( "en pojke", "🧍🏽") },
            //{new EmojiObject( "en pojke", "🧍🏾") },
            //{new EmojiObject( "en pojke", "🧍🏿") },

            //{new EmojiObject( "en flicka", "🧍‍♀️") },
            //{new EmojiObject( "en flicka", "🧍🏻‍♀️") },
            //{new EmojiObject( "en flicka", "🧍🏼‍♀️") },
            //{new EmojiObject( "en flicka", "🧍🏽‍♀️") },
            //{new EmojiObject( "en flicka", "🧍🏾‍♀️") },
            //{new EmojiObject( "en flicka", "🧍🏿‍♀️") },
        };

        public List<EmojiObject> Earth => new List<EmojiObject>
        {
            {new EmojiObject( "jorden", "\U0001F30D") },
            {new EmojiObject( "jorden", "\U0001F30E") },
            {new EmojiObject( "jorden", "\U0001F30F") },
        };

        public List<EmojiObject> Toys => new List<EmojiObject>
        {
           { new EmojiObject( "en leksak","\U0001FA81")}, // TYvärr verkar ingen leksak fungera i android
            //{ new EmojiObject( "en leksak","\U0001F9F8")},
        };

        public List<EmojiObject> Flower => new List<EmojiObject>
        {
            { new EmojiObject( "en körsbärsblomma","🌸")},
            { new EmojiObject( "en ros","🌹")},
            { new EmojiObject( "en ros","🥀")},
            { new EmojiObject( "en hibiscus","🌺")},
            { new EmojiObject( "en solros" ,"🌻")},
            { new EmojiObject( "en blomma" , "🌼")},
            { new EmojiObject( "en tulpan" ,"🌷")},
        };

        public List<EmojiObject> IceCream => new List<EmojiObject>
        {
            {new EmojiObject( "en glass" , "\U0001F366")},
        };

        public string LoveEmoji => "\U0001F60D";

    }
}
