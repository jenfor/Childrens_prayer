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
        public string ViewFairyTale => "Visa/Dela hela bönen";
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

        // Addition A childs prayer
        public string God => "Gud";
        public string All => "alla";
        public string TodayHeThinks => "Idag tänker han särskilt mycket på";
        public string GodWantsAll => "Gud vill att " + StringReplacer.PrayerObject3 + " ska ha ett bra liv med många fina upplevelser";
        public string DoYouThink => "tänker du särskilt på idag?";
        public string GodLoves => "Gud älskar";
        public string WhenGodMeets => "När Gud möter " + StringReplacer.PrayerObject2
                                + " vill han att " + StringReplacer.PrayerObject3
                                + " ska förstår hur " + StringReplacer.PrayerObject4;
        public string GodHides => "Ibland gömmer sig Gud bakom " + StringReplacer.Hide + " och leker kurragömma med " + StringReplacer.PrayerObject2;
        public string GodIs => "Gud finns överallt";



        public List<string> GodCareVerb => new List<string>()
        {
            "älskar",
            "möter",
            "bryr sig om"
        };

        //U+1F6B6 U+200D U+2640 U+FE0F
        string personWithBlondHair = ""
  + (char)int.Parse("1F6B6200D2640FE0F".Substring(0, 4), NumberStyles.HexNumber)
  + (char)int.Parse("1F6B6200D2640FE0F".Substring(4, 4), NumberStyles.HexNumber)
  + (char)int.Parse("1F6B6200D2640FE0F".Substring(8, 4), NumberStyles.HexNumber)
  + (char)int.Parse("1F6B6200D2640FE0F".Substring(12, 4), NumberStyles.HexNumber)
;

        public List<PrayerObject> Prayer1Objects => new List<PrayerObject>()
        {
            //{new PrayerObject("människor","\U0001F9CD" /* U+200D U+2640 U+FE0F*/ + "\U0001F6B6" /* U+200D U+2642 U+FE0F*/,"en människa", "alla människor", "Vilken människa" ) },
            //{new PrayerObject("på jorden","\U0001F30D","vår jord", "alla på jorden", "Vad på jorden" ) },
            {new PrayerObject("som är som dig", personWithBlondHair, "dig", "du", "Vad")},
            //{new PrayerObject("dina vänner", "\U0001F6B6" + "\U0001F9CE"  /*U+1F9CE U+200D U+2640 U+FE0F U+200D U+2640 U+FE0F*/ ,"en vän", "alla dina vänner", "Vilken vän")},
            //{new PrayerObject("i din familj", "\U0001F468"/* U+200D U+1F469 U+200D U+1F467 U+200D U+1F466"*/ , "en i din familj", "alla i din familj", "Vem")},
            //{new PrayerObject("djuren", "\U0001F404" , "ett djur", "alla djur", "Vilket djur")},
            //{new PrayerObject("växterna", "\U0001F940" , "en växt", "alla växter", "Vilken växt")},
            //{new PrayerObject("hela världen", "\U0001F30D" , "vår värld", "alla i hela världen", "Vad i världen")},
            //{new PrayerObject("haven", "\U0001F30A" , "ett hav", "alla hav", "Vilket hav")},
            //{new PrayerObject("sjöarna", "\U0001F4A6" , "en sjö", "alla sjöar", "Vilken sjö")},
            //{new PrayerObject("träden", "\U0001F333" , "ett träd", "alla träd", "Vilket träd")},
        };

        public List<PrayerObject> Prayer2Objects => new List<PrayerObject>()
        {
            {new PrayerObject("alla människor","\U0001F9CD" + "\U0001F6B6" /* U+200D U+2640 U+FE0F*/ ,"en männska", "hon", "underbar hon är" ) },
            {new PrayerObject("dig", "\U0001F9CE"/* U+200D U+2640 U+FE0F"*/ , "dig", "du", "du är")},
            {new PrayerObject("alla dina vänner", "\U0001F6B6" + "\U0001F9CE"  /* U+200D U+2640 U+FE0F*/  , "dina vänner", "de", "underbara de är")},// ToDo: slumpa fram han eller hon
            {new PrayerObject("din familj", "\U0001F468"/* U+200D U+1F469 U+200D U+1F467 U+200D U+1F466"*/ , "din familj", "ni", "underbara ni är")},
        };

        public List<EmojiObject> Animal => new List<EmojiObject>
        {
            {new EmojiObject( "en ekorre", "\U0001F43F") },
            {new EmojiObject("en igelkott", "\U0001F994")},
            {new EmojiObject("en duva", "\U0001F54A")},
            {new EmojiObject("en svan", "\U0001F9A2")},
            {new EmojiObject("en påfågel", "\U0001F99A")},
            {new EmojiObject("en uggla", "\U0001F989")},
            {new EmojiObject(" en larv", "\U0001F41B")},
            {new EmojiObject("en orm", "\U0001F40D")},
            {new EmojiObject("en hamnster", "\U0001F439")},
            {new EmojiObject("en sköldpadda", "\U0001F422")},
            {new EmojiObject("en katt", "\U0001F431")},
            {new EmojiObject("en snigel", "\U0001F40C")},
            {new EmojiObject("en groda", "\U0001F438")},
            {new EmojiObject("en nyckelpiga", "\U0001F41E")},
            {new EmojiObject("en myra", "\U0001F41C")},
            {new EmojiObject("en kyckling", "\U0001F425")},
            {new EmojiObject("en koala", "\U0001F428")},
            {new EmojiObject("en apa", "\U0001F412")},
            {new EmojiObject("en kanin", "\U0001F407")},
            {new EmojiObject("en råtta ", "\U0001F401")},
            {new EmojiObject("honeybee", "\U0001F41D")},
            {new EmojiObject("ett bi", "\U0001F98B")},
        };

        public List<EmojiObject> Hides => new List<EmojiObject>
         {
            {new EmojiObject( "en ekorre", "\U0001F43F") },
            {new EmojiObject("en igelkott", "\U0001F994")},
            {new EmojiObject("en duva", "\U0001F54A")},
            {new EmojiObject("en svan", "\U0001F9A2")},
            {new EmojiObject("en påfågel", "\U0001F99A")},
            {new EmojiObject("en uggla", "\U0001F989")},
            {new EmojiObject(" en larv", "\U0001F41B")},
            {new EmojiObject("en hamnster", "\U0001F439")},
            {new EmojiObject("en sköldpadda", "\U0001F422")},
            {new EmojiObject("en katt", "\U0001F431")},
            {new EmojiObject("en snigel", "\U0001F40C")},
            {new EmojiObject("en groda", "\U0001F438")},
            {new EmojiObject("en nyckelpiga", "\U0001F41E")},
            {new EmojiObject("en myra", "\U0001F41C")},
            {new EmojiObject("en kyckling", "\U0001F425")},
            {new EmojiObject("en koala", "\U0001F428")},
            {new EmojiObject("en apa", "\U0001F412")},
            {new EmojiObject("en kanin", "\U0001F407")},
            {new EmojiObject("en råtta ", "\U0001F401")},
            {new EmojiObject("honeybee", "\U0001F41D")},
            {new EmojiObject("ett bi", "\U0001F98B")},
        };

        public string LoveEmoji => "\U0001F60D";

    }
}
