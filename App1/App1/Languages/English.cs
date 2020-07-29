using System;
using System.Collections.Generic;
using System.Text;
using App1.Prayer;

namespace App1.Languages
{
    public class English: Language
    {
        public string BackToStart => "Back to start";
        public string ShareFairyTale => "Share the prayer";
        public string BackFairyTale => "Back";
        public string ContinueFairyTale => "Continue";
        public string ViewFairyTale => "View/Share";
        public string NewImage => "Change";

        public string VersionOption => "What kind of fairy tale do you want to write?";

        public string Warning => "Warning";
        public string Question => "Question";
        public string Information => "It is your turn";

        public string BackToStartPageWarning => "Are you sure you want to go back to start?" + NewLine + NewLine + "This prayer will be deleted!";
        public string Deletion => "Are you sure you want to delete this prayer and create a new one?";

        public string TapHere => "Tap here to write!";

        public string Yes => "Yes";
        public string No => "No";
        public string Short => "A short fairy tale";
        public string Long => "A long fairy tale";

        public string InformationExchangeString => "Now it's your turn to write about "
                + StringReplacer.Character1_Name + " and "
                + StringReplacer.Character2_Name + "." + NewLine + NewLine
                    + "Tap the fairy tale text you see in this page and start writing!";

        public string ExchangeString => "Tap here to write about " + 
                         StringReplacer.Character1_Name + " and " +
                         StringReplacer.Character2_Name + Dot;

        public string WasNamed => "called ";
        public string HadA => " had a ";
        public string A => "a ";
        public string WhoWasCalled => " called ";
        public string And => " and ";
        public string ThatEverything => " that everything ";
        public string Was => " was ";

        public string Dots => "...";
        public String Dot => ". ";
        public String Space => " ";
        public String Comma => ", ";
        public String NewLine => "\n";

        public string God => "God";
        public string All => "all";
        public string TodayHeThinks => "Today he thinks especially of";
        public string GodWantsAll => "God wants " + StringReplacer.PrayerObject3 + " to have a good life with many wonderful experiences";
        public string DoYouThink => "do you think about today?";
        public string GodLoves => "God loves";
        public string WhenGodMeets => "When God meets with " + StringReplacer.PrayerObject2
                                        + " he wants " + StringReplacer.PrayerObject3
                                        + " to understand how " + StringReplacer.PrayerObject4;
        public string GodHides => "Sometimes God hides behind " + StringReplacer.Hide + " and playes hide and seek with " + StringReplacer.PrayerObject2;
        public string GodIs => "God is everywhere";

        public List<string> GodCareVerb => new List<string>()
        {
            "loves",
            "meets",
            "cares about"
        };

        public List<PrayerObject> Prayer1Objects => new List<PrayerObject>()
        {
            {new PrayerObject("all the humans","\U0001F9CD" + "\U0001F6B6" /* U+200D U+2640 U+FE0F*/ ,"one human", "all of the humans", "What human" ) },
            {new PrayerObject("the earth","\U0001F30D","the earth", "all of the earth", "What on earth" ) },
            {new PrayerObject("of you", "\U0001F9CE"/* U+200D U+2640 U+FE0F"*/ , "you", "you", "What")},
            {new PrayerObject("your friends", "\U0001F6B6" + "\U0001F9CE"  /* U+200D U+2640 U+FE0F*/  , "one friend", "all of your friends", "What friend")},
            {new PrayerObject("your family", "\U0001F468"/* U+200D U+1F469 U+200D U+1F467 U+200D U+1F466"*/ , "someone in your family", "all of your family", "Who")},
            {new PrayerObject("the animals", "\U0001F404" , "one animal", "all animals", "What animal")},
            {new PrayerObject("the plants", "\U0001F940" , "one plant", "all plants", "What plant")},
            {new PrayerObject("the world", "\U0001F30D" , "our world", "all of our world", "What in the world")},
            {new PrayerObject("the sea", "\U0001F30A" , "the sea", "all of the sea", "What sea")},
            {new PrayerObject("the lakes", "\U0001F4A6" , "one lake", "all lakes", "What lake")},
            {new PrayerObject("the trees", "\U0001F333" , "one tree", "all trees", "What tree")},
        };

        public List<PrayerObject> Prayer2Objects => new List<PrayerObject>()
        {
            {new PrayerObject("you", "\U0001F9CE"/* U+200D U+2640 U+FE0F"*/ , "you", "you", "wonderful you are")},
            {new PrayerObject("all your friends", "\U0001F6B6" + "\U0001F9CE"  /* U+200D U+2640 U+FE0F*/  , "your friends", "them", "wonderful they are")},// ToDo: slumpa fram han eller hon
            {new PrayerObject("your family", "\U0001F468"/* U+200D U+1F469 U+200D U+1F467 U+200D U+1F466"*/ , "your family", "you", "wonderful you are")},
        };

        public List<EmojiObject> Animal => new List<EmojiObject>
        {
            {new EmojiObject( "a squirrel", "\U0001F43F") },
            {new EmojiObject("a hedgehog", "\U0001F994")},
            {new EmojiObject("a dove", "\U0001F54A")},
            {new EmojiObject("a swan", "\U0001F9A2")},
            {new EmojiObject("a peacock", "\U0001F99A")},
            {new EmojiObject("an owl", "\U0001F989")},
            {new EmojiObject("a larva", "\U0001F41B")},
            {new EmojiObject("a snake", "\U0001F40D")},
            {new EmojiObject("a hamster", "\U0001F439")},
            {new EmojiObject("a turtle", "\U0001F422")},
            {new EmojiObject("a cat", "\U0001F431")},
            {new EmojiObject("a snail", "\U0001F40C")},
            {new EmojiObject("a frog", "\U0001F438")},
            {new EmojiObject("a ladybug", "\U0001F41E")},
            {new EmojiObject("an ant", "\U0001F41C")},
            {new EmojiObject("a chicken", "\U0001F425")},
            {new EmojiObject("a koala", "\U0001F428")},
            {new EmojiObject("a monkey", "\U0001F412")},
            {new EmojiObject("a rabbit", "\U0001F407")},
            {new EmojiObject("a rat", "\U0001F401")},
            {new EmojiObject("a honeybee", "\U0001F41D")},
            {new EmojiObject("a butterfly", "\U0001F98B")},
        };

        public List<EmojiObject> Hides => new List<EmojiObject>
        {
            {new EmojiObject( "a squirrel", "\U0001F43F") },
            {new EmojiObject("a hedgehog", "\U0001F994")},
            {new EmojiObject("a dove", "\U0001F54A")},
            {new EmojiObject("a swan", "\U0001F9A2")},
            {new EmojiObject("a peacock", "\U0001F99A")},
            {new EmojiObject("an owl", "\U0001F989")},
            {new EmojiObject("a larva", "\U0001F41B")},
            {new EmojiObject("a hamster", "\U0001F439")},
            {new EmojiObject("a turtle", "\U0001F422")},
            {new EmojiObject("a cat", "\U0001F431")},
            {new EmojiObject("a snail", "\U0001F40C")},
            {new EmojiObject("a frog", "\U0001F438")},
            {new EmojiObject("a ladybug", "\U0001F41E")},
            {new EmojiObject("an ant", "\U0001F41C")},
            {new EmojiObject("a chicken", "\U0001F425")},
            {new EmojiObject("a koala", "\U0001F428")},
            {new EmojiObject("a monkey", "\U0001F412")},
            {new EmojiObject("a rabbit", "\U0001F407")},
            {new EmojiObject("a rat", "\U0001F401")},
            {new EmojiObject("a honeybee", "\U0001F41D")},
            {new EmojiObject("a butterfly", "\U0001F98B")},
        };

        public string LoveEmoji => "\U0001F60D";

    }
}
