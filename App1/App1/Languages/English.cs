using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Languages
{
    public class English: Language
    {
        public string BackToStart => "Back to start";
        public string ShareFairyTale => "Share the fairy tale";
        public string BackFairyTale => "Back";
        public string ContinueFairyTale => "Continue";
        public string ViewFairyTale => "View/Share fairy tale";
        public string NewImage => "Change";

        public string VersionOption => "What kind of fairy tale do you want to write?";

        public string Warning => "Warning";
        public string Question => "Question";
        public string Information => "It is your turn";

        public string BackToStartPageWarning => "Are you sure you want to go back to start?" + NewLine + NewLine + "This story will be deleted!";
        public string Deletion => "Are you sure you want to delete this fairy tale and create a new one?";

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

        public Dictionary<string, string> Animals => new Dictionary<string, string>()
        {
            { "squirrel", "\U0001F43F" },
            {"hedgehog", "\U0001F994"},
            {"bat", "\U0001F987"},
            //{"skunk", "\U0001F9A8"}, // Todo: find better emoji
            //{"badger", "\U0001F9A1"}, // Todo: find better emoji
            {"dove", "\U0001F54A"},
            //{"eagle", "\U0001F985"},// Todo: needs an instead of a
            {"duck", "\U0001F986"},
            //{"swan", "\U0001F9A2"}, // Todo: find better emoji
            //{"peacock", "\U0001F99A"}, // Todo: find better emoji
            //{"parrot", "\U0001F99C"}, // Todo: find better emoji
            //{"owl", "\U0001F989"}, // Todo: needs an instead of a
            {"spider", "\U0001F577"},
            {"skorpion", "\U0001F982"},
            {"larva", "\U0001F41B"},
            {"snake", "\U0001F40D"},
            {"hamster", "\U0001F439"},
            {"turtle", "\U0001F422"},
            {"cat", "\U0001F431"},
            {"snail", "\U0001F40C"},
            {"frog", "\U0001F438"},
            {"ladybug", "\U0001F41E"},
            {"bird", "\U0001F426"},
            //{"ant", "\U0001F41C"}, // Todo: needs an instead of a
            {"shrew", "\U0001F42D"},
            {"chicken", "\U0001F425"},
            {"penguin", "\U0001F427"},
            {"koala", "\U0001F428"},
            //{"hen", "\U0001F414"}, // Todo: find better emoji
            {"monkey", "\U0001F412"},
            {"dog", "\U0001F436"},
            {"panda", "\U0001F43C"},
            {"rabbit", "\U0001F407"},
            {"rat", "\U0001F401"},
            {"goat", "\U0001F410"},
            {"honeybee", "\U0001F41D"},
            {"cricket", "\U0001F997"},
            {"butterfly", "\U0001F98B"},
        };

        public Dictionary<string, string> Places => new Dictionary<string, string>()
        {
            {"on earth", "\U0001F30D"},
            //{"on their planet", "\U0001FA90"}, // ToDo: Fix this emoji
            {"in their city", "\U0001F306"},
            {"in their country", "\U0001F304"},
            {"in their hometown", "\U0001F3DE"},
            {"in their village", "\U0001F3D8"},
            {"in their forest", "\U0001F333"}
        };

        public Dictionary<string, string> Events => new Dictionary<string, string>()
        {
            {"had decided to organize a big party where everyone should be invited", "\U0001F382"},
            {"wanted it to look like " + StringReplacer.Character1_Gender+ " was going for a long journey. That's why " + StringReplacer.Character1_Gender + " started to pack a bag", "\U0001F45C"},
            {"started by telling everyone that this was a very important day", "\U0001F338"},
            {"said: \n- Let's build a space ship together", "\U0001F6F8"},
            {"thought it was easy to build a new car", "\U0001F698"},
            {"thought it was possible to build a citiy on the seabed", "\U0001F30A"},
            {"wanted to start a new sort of candy factory", "\U0001F36C" + "\U0001F36D"},
            {"said " + StringReplacer.Character1_Gender + " was big enough to start school", "\U0001F3EB"}, 
            {"wanted to put sails on everyone's backs", "\U0001F32C"},
            {"had decided to invent wings that could make everyone and everything fly", "\U0001F4B8"},
            {"wanted to arrange a flight course for everyone", "\U0001F6E9"},
            //{"planned to dress up as a good fairy and hand out three wishes", "\U0001FA84"},// ToDo: Fix this emoji
            {"thought it was easy to build a large castle out of sand", "\U0001F3F0"},
            {"wanted to prove that the dragons still were alive", "\U0001F409"},
            //{"had found a lamp in where it might be a genie", "\U0001FA94"},// ToDo: Fix this emoji
            {"thought " + StringReplacer.Character1_Gender + " had found a new way to the moon", "\U0001F314"}, 
            {"had found the place where the rainbow starts", "\U0001F308"}
        };

        public List<string> FairyTaleStarts => new List<string>()
        {
            "Once upon a time there was a",
            "Some don't think this is true, but once upon a time there was a",
            "Far, far from here, there once was a",
            "In an enchanted world there once lived a",
            "In a another time there once lived a",
            "In a world where no human yet has taken a single step, there once lived a",
            "Without any human knowledge there once lived a",
            "Far away from all kind of attention there once was a",
            "In a very odd world there once lived a",
            "Behind a secret door, in a forgotten house, a whole world is hidden. In there, there once lived a",
            "In an imaginable world there once lived a",
            "Not far from here, there once lived a",
            "Right under your bed there is a small hole. "
                + "No human eye has seen it, but inside there is a whole world."
                + "In there, there once lived a"
        };

        public List<string> Relationships => new List<string>()
        {
            "friend",
            "enemy",
            "buddy"
        };

        public List<string> BadRelationships => new List<string>()
        {
            "enemy",
        };

        public List<string> CharacterAdjectives => new List<string>()
        {
            "happy",
            "nice",
            "funny",
            "worried",
            "smart",
            "nervous",
            "clever",
            "curious",
            "wandering",
            "popular",
            "cheerful",
            "healthy",
        };

        public List<string> BadRelationshipsAdjectives => new List<string>()
        {
            "stupid",
            //"angry", //ToDo: needs an
            "mean",
        };

        public List<string> Verb1 => new List<string>()
        {
            "pretend",
            "fool everyone",
            "tell eachother",
            "say"
        };

        public List<string> PlaceAdjectives => new List<string>()
        {
            "lovely",
            "wonderful",
            "terrible",
        };

        public List<string> Verb2 => new List<string>()
        {
            "used to",
            "seemed to",
            "liked to",
            "tried to",
            "wanted to"

        };

        public List<string> Circumstances => new List<string>()
        {
           // "Right now life actually happend to be " + StringReplacer.Place_Condition + " " + StringReplacer.Place,
           // "Right now life seemed to be " + StringReplacer.Place_Condition + " " + StringReplacer.Place +", but for some it was hard to believe",
           // "But right now life certainly wasn't " + StringReplacer.Place_Condition  + " " + StringReplacer.Place,
           // "But right now life wasn't " + StringReplacer.Place_Condition  + " " + StringReplacer.Place + ", reality was far from it",

            "It could be " + StringReplacer.Place_Condition + " " + StringReplacer.Place + " in many different ways",
            "But it wasn't " + StringReplacer.Place_Condition + " " + StringReplacer.Place + " today",
        };

        public List<string> Gender => new List<string>()
        {
            "He",
            "She"
        };

        public List<string> Actions => new List<string>()
        {
            "Today " + StringReplacer.Character1_Name + " wanted to try something new",
            StringReplacer.Character1_Name + " had new plans",
            StringReplacer.Character1_Name + " had come up with something new",
            "Today " + StringReplacer.Character1_Name + " had got a fun idea",
            StringReplacer.Character1_Name + " had got an exciting idea",
            "Today " + StringReplacer.Character1_Name + " wanted to try something new",
            StringReplacer.Character1_Name + " wanted to try a new idea",
            StringReplacer.Character1_Name + " wanted to make a big change",
            "Today " + StringReplacer.Character1_Name + " wanted to give everyone a big surprise",
        };

        public List<string> Continuations => new List<string>()
        {
            "It turned out to be",
            "It started with",
            StringReplacer.Character1_Gender + " said that", 
            StringReplacer.Character1_Gender + " wanted to let",
            StringReplacer.Character1_Gender + " refused to let",
            "But"
        };
    }
}
