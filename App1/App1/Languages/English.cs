using System;
using System.Collections.Generic;
using System.Text;
using App1.Prayer;

namespace App1.Languages
{
    public class English: Language
    {
        public string BackToStart => "To start";
        public string ShareFairyTale => "Share prayer";
        public string BackFairyTale => "Back";
        public string ContinueFairyTale => "Continue";
        public string ViewFairyTale => "View prayer";

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

        public string InformationExchangeString => "Now it's your turn to write";// about "
                //+ StringReplacer.Character1_Name + " and "
                //+ StringReplacer.Character2_Name + "." + NewLine + NewLine
                   // + "Tap the fairy tale text you see in this page and start writing!";

        public string ExchangeString => "Tap here to write";// about " + 
                         //StringReplacer.Character1_Name + " and " +
                         //StringReplacer.Character2_Name + Dot;

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
        public string GodWantsAll => "God wants " + StringReplacer.PrayerObject3 + " to have " + StringReplacer.PrayerObject5 + " many wonderful experiences";
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
            "meets with",
            "cares about"
        };

        public List<PrayerObject> Prayer1Objects => new List<PrayerObject>()
        {
            {new PrayerObject("all the humans", Children ,"us", "all of us", "Who", "good lives with", 2 ) },
            {new PrayerObject("the earth",Earth,"our earth", "everyone on earth", "What", "a good lives with",1)},
            {new PrayerObject("you", Children, "you", "you", "What", "a good life with",1)},
            {new PrayerObject("all of your friends", Children , "a friend", "all of your friends", "Who", "good lives with",2)},
            {new PrayerObject("your family", Families , "your family", "all of your family", "Who", "a good life with",1 )},
            {new PrayerObject("all the animals", Animals, "an animal", "all animals", "What animal", "good lives with",1)},
            {new PrayerObject("all the plants", Plants , "a plant", "all plants", "What plant", "good lives. He wants them to be able to give us",1)},
            {new PrayerObject("the world", Earth , "our world", "everyone in our world", "What", "good lives with",1)},
            {new PrayerObject("the sea", Seas , "the sea", "all of the sea", "What sea", "a good life. He wants it to be able to give us",1 )},
            {new PrayerObject("all the lakes", Lakes , "a lake", "all lakes", "What lake", "good lives.  He wants them to be able to give us",1)},
            {new PrayerObject("all the trees", Trees , "a tree", "all trees", "What tree", "good lives.  He wants them to be able to give us",1)},
        };

        public List<PrayerObject> Prayer2Objects => new List<PrayerObject>()
        {
            {new PrayerObject("you", Children , "you", "you", "wonderful you are", String.Empty, 1)},
            {new PrayerObject("all your friends", Humans , "your friends", "them", "wonderful they are", String.Empty,1)},
            {new PrayerObject("your family", Families , "your family", "you", "wonderful you are", String.Empty,1)},
        };

        public List<EmojiObject> Animals => new List<EmojiObject>
        {
            {new EmojiObject( "a squirrel", "\U0001F43F") },
            {new EmojiObject("a hedgehog", "\U0001F994")},
            {new EmojiObject("a dove", "\U0001F54A")},
            //{new EmojiObject("a swan", "\U0001F9A2")},
            {new EmojiObject("a peacock", "\U0001F99A")},
            {new EmojiObject("an owl", "\U0001F989")},
            {new EmojiObject("a larva", "\U0001F41B")},
            {new EmojiObject("a hamster", "\U0001F439")},
            {new EmojiObject("a turtle", "\U0001F422")},
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
            {new EmojiObject("a dog", "🐕‍🦺")},
            {new EmojiObject("a cat", "🐈")},
            {new EmojiObject("a cow", "🐄")},

        };

        public List<EmojiObject> Plants => new List<EmojiObject>
        {
            {new EmojiObject( "a tree", "\U0001F333") },
            {new EmojiObject( "a palm tree", "\U0001F334") },
            {new EmojiObject( "a seedling", "\U0001F331") },
            {new EmojiObject( "a four leaf clover", "\U0001F340") },
            {new EmojiObject( "a cactus", "\U0001F335") },
            {new EmojiObject( "a wilted flower", "\U0001F940") },
            {new EmojiObject( "a sunflower", "\U0001F33B") },
            {new EmojiObject( "a tulip", "\U0001F337") },
            {new EmojiObject( "a hibiscus", "\U0001F33A") },
            {new EmojiObject( "a rose", "\U0001F339") },
            {new EmojiObject( "a cherry blossom", "\U0001F339") },
        };

        public List<EmojiObject> Fruits => new List<EmojiObject>
        {
            {new EmojiObject( "grapes", "\U0001F347") },
            {new EmojiObject( "a watermelon", "\U0001F349") },
            {new EmojiObject( "a lemon", "\U0001F34B") },
            {new EmojiObject( "a banana", "\U0001F34C") },
            {new EmojiObject( "a pineapple", "\U0001F34D") },
            {new EmojiObject( "a apple", "\U0001F34F") },
            {new EmojiObject( "a strawberry", "\U0001F353") },
        };

        public List<EmojiObject> Vegetables => new List<EmojiObject>
        {
            {new EmojiObject( "an avocado", "\U0001F951") },
            {new EmojiObject( "an carrot", "\U0001F955") },
            {new EmojiObject( "an ear of corn", "\U0001F33D") },
            {new EmojiObject( "a cucumber", "\U0001F952") },
            {new EmojiObject( "an onion", "\U0001F9C5") },
        };

        public List<EmojiObject> Trees => new List<EmojiObject>
        {
            {new EmojiObject( "a tree", "\U0001F333") },
            {new EmojiObject( "a palm tree", "\U0001F334") },
            {new EmojiObject( "an evergreen tree", "\U0001F332") },
        };

        public List<EmojiObject> Families => new List<EmojiObject>
        {
            {new EmojiObject( "a family", "👨‍👩‍👦‍👦") },
            {new EmojiObject( "a family", "👩‍👦‍👦") },
            {new EmojiObject( "a family", " 👨‍👦‍👦") },
        };

        public List<EmojiObject> Children => new List<EmojiObject>
        {
            //{new EmojiObject( "a girl", "🧎🏻‍♀️ 1") },
            //{new EmojiObject( "a girl", "🧎🏼‍♀️" ) },
            //{new EmojiObject( "a girl", "🧎🏽‍♀️") },
            //{new EmojiObject( "a girl", "🧎🏾‍♀️") },
            //{new EmojiObject( "a girl", "🧎🏿‍♀️") },
            //{new EmojiObject( "a girl", "🧎‍♂️") },

            /*{new EmojiObject( "a boy", "🧎🏻") },
            {new EmojiObject( "a boy", "🧎🏼") },
            {new EmojiObject( "a boy", "🧎🏽") },
            {new EmojiObject( "a boy", "🧎🏽") },
            {new EmojiObject( "a boy", "🧎🏾") },
            {new EmojiObject( "a boy", "🧎🏿") },
            */

            {new EmojiObject( "a boy", "🚶‍♂️") },
            {new EmojiObject( "a boy", "🚶🏻‍♂️") },
            {new EmojiObject( "a boy", "🚶🏼‍♂️") },
            {new EmojiObject( "a boy", "🚶🏽‍♂️") },
            {new EmojiObject( "a boy", "🚶🏾‍♂️") },
            {new EmojiObject( "a boy", "🚶🏿‍♂️") },

            {new EmojiObject( "a girl", "🚶‍♀️") },
            {new EmojiObject( "a girl", "🚶🏻‍♀️") },
            {new EmojiObject( "a girl", "🚶🏼‍♀️") },
            {new EmojiObject( "a girl", "🚶🏽‍♀️") },
            {new EmojiObject( "a girl", "🚶🏾‍♀️") },
            {new EmojiObject( "a girl", "🚶🏿‍♀️") },

            /*{new EmojiObject( "a boy", "🧍") },
            {new EmojiObject( "a boy", "🧍🏻") },
            {new EmojiObject( "a boy", "🧍🏼") },
            {new EmojiObject( "a boy", "🧍🏽") },
            {new EmojiObject( "a boy", "🧍🏾") },
            {new EmojiObject( "a boy", "🧍🏿") },

            {new EmojiObject( "a girl", "🧍‍♀️") },
            {new EmojiObject( "a girl", "🧍🏻‍♀️") },
            {new EmojiObject( "a girl", "🧍🏼‍♀️") },
            {new EmojiObject( "a girl", "🧍🏽‍♀️") },
            {new EmojiObject( "a girl", "🧍🏾‍♀️") },
            {new EmojiObject( "a girl", "🧍🏿‍♀️") },*/
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
            {new EmojiObject( "a woman and a man holding hands", "👩🏻‍🤝‍👨🏼") },
            {new EmojiObject( "a woman and a man holding hands", "👩🏻‍🤝‍👨🏼") },
            {new EmojiObject( "a woman and a man holding hands", "👩🏻‍🤝‍👨🏼") },
            {new EmojiObject( "a woman and a man holding hands", "👩🏼‍🤝‍👨🏿") },
            {new EmojiObject( "a woman and a man holding hands", "👩🏾‍🤝‍👨🏼") },
            {new EmojiObject( "a woman and a man holding hands", "👩🏿‍🤝‍👨🏻") },
            {new EmojiObject( "a woman and a man holding hands", "👩🏻‍🤝‍👨🏿") },
            {new EmojiObject( "a woman and a man holding hands", "👩🏽‍🤝‍👨🏼") },

            //{new EmojiObject( "a girl", "🧎🏼‍♀️") },
            //{new EmojiObject( "a girl", "🧎🏽‍♀️") },
            //{new EmojiObject( "a girl", "🧎🏾‍♀️") },
            //{new EmojiObject( "a girl", "🧎🏿‍♀️") },
            //{new EmojiObject( "a girl", "🧎‍♂️") },

            //{new EmojiObject( "a boy", "🧎🏻") },
            //{new EmojiObject( "a boy", "🧎🏼") },
            //{new EmojiObject( "a boy", "🧎🏽") },
            //{new EmojiObject( "a boy", "🧎🏽") },
            //{new EmojiObject( "a boy", "🧎🏾") },
            //{new EmojiObject( "a boy", "🧎🏿") },

            /*{new EmojiObject( "a boy", "🚶‍♂️") },
            {new EmojiObject( "a boy", "🚶🏻‍♂️") },
            {new EmojiObject( "a boy", "🚶🏼‍♂️") },
            {new EmojiObject( "a boy", "🚶🏽‍♂️") },
            {new EmojiObject( "a boy", "🚶🏾‍♂️") },
            {new EmojiObject( "a boy", "🚶🏿‍♂️") },

            {new EmojiObject( "a girl", "🚶‍♀️") },
            {new EmojiObject( "a girl", "🚶🏻‍♀️") },
            {new EmojiObject( "a girl", "🚶🏼‍♀️") },
            {new EmojiObject( "a girl", "🚶🏽‍♀️") },
            {new EmojiObject( "a girl", "🚶🏾‍♀️") },
            {new EmojiObject( "a girl", "🚶🏿‍♀️") },

            {new EmojiObject( "a boy", "🧍") },
            {new EmojiObject( "a boy", "🧍🏻") },
            {new EmojiObject( "a boy", "🧍🏼") },
            {new EmojiObject( "a boy", "🧍🏽") },
            {new EmojiObject( "a boy", "🧍🏾") },
            {new EmojiObject( "a boy", "🧍🏿") },

            {new EmojiObject( "a girl", "🧍‍♀️") },
            {new EmojiObject( "a girl", "🧍🏻‍♀️") },
            {new EmojiObject( "a girl", "🧍🏼‍♀️") },
            {new EmojiObject( "a girl", "🧍🏽‍♀️") },
            {new EmojiObject( "a girl", "🧍🏾‍♀️") },
            {new EmojiObject( "a girl", "🧍🏿‍♀️") },
            */
        };

        public List<EmojiObject> Earth => new List<EmojiObject>
        {
            {new EmojiObject( "the earth", "\U0001F30D") },
            {new EmojiObject( "the earth", "\U0001F30E") },
            {new EmojiObject( "the earth", "\U0001F30F") },

        };

        public List<EmojiObject> Toys => new List<EmojiObject>
        {
            { new EmojiObject( "a toy","\U0001FA81")},
            { new EmojiObject( "a toy","\U0001F9F8")},
        };

        public List<EmojiObject> Flower => new List<EmojiObject>
        {
            { new EmojiObject( "a cherry blossom","🌸")},
            { new EmojiObject( "a rose","🌹")},
            { new EmojiObject( "a rose","🥀")},
            { new EmojiObject( "a hibiscus","🌺")},
            { new EmojiObject( "a sunflower" ,"🌻")},
            { new EmojiObject( "a floweer" , "🌼")},
            { new EmojiObject( "a tulip" ,"🌷")},
        };

        public List<EmojiObject> IceCream => new List<EmojiObject>
        {
            {new EmojiObject( "an icecream" , "\U0001F366")},
        };

        public List<EmojiObject> Hides => new List<EmojiObject>
        {
            {new EmojiObject( "a flower", "\U0001F337") },
            {new EmojiObject("a tree", "\U0001F333")},
            {new EmojiObject("a toy", "\U0001F9F8")},
            {new EmojiObject("a toy", "\U0001FA81")},
            {new EmojiObject("a fruit", "\U0001F34F")},
            {new EmojiObject("a cloud", "\U0001F325")},
            {new EmojiObject("an animal", "🐕‍🦺")},
            {new EmojiObject("a vegetable", "\U0001F955")},
            {new EmojiObject("an icecream", "\U0001F366")},
            {new EmojiObject("a piece of a puzzle", "\U0001F9E9")},
        };

        public string LoveEmoji => "\U0001F60D";

    }
}
