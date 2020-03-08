using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Languages
{
    public class English: Language
    {
        public string ExchangeString => "\n \nNow its your time to use your imagination write the rest of the fairytale.";
        public string WasNamed => "called ";
        public string HadA => " had a ";
        public string A => "a ";
        public string WhoWasCalled => " called ";
        public string They => "They ";
        public string ThatEverything => " that everything ";
        public string Was => " was ";
        public string It => "It ";
        public string Dots => "...";
        public String Dot => ". ";
        public String Space => " ";
        public String Comma => ", ";

        public Dictionary<string, string> Animals => new Dictionary<string, string>()
        {
            { "squirrel", "\U0001F43F" },
            {"hedgehog", "\U0001F994"},
            {"bat", "\U0001F987"},
            //{"skunk", "\U0001F9A8"},
            //{"badger", "\U0001F9A1"},
            {"dove", "\U0001F54A"},
            {"eagle", "\U0001F985"},
            {"duck", "\U0001F986"},
            //{"swan", "\U0001F9A2"},
            //{"peacock", "\U0001F99A"},
            //{"parrot", "\U0001F99C"},
            {"owl", "\U0001F989"},
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
            {"ant", "\U0001F41C"},
            {"shrew", "\U0001F42D"},
            {"chicken", "\U0001F425"},
            {"penguin", "\U0001F427"},
            {"koala", "\U0001F428"},
            //{"hen", "\U0001F414"},
            {"monkey", "\U0001F412"},
            {"dog", "\U0001F436"},
            {"panda", "\U0001F43C"},
            {"rabbit", "\U0001F407"},
            {"rat", "\U0001F401"},
            {"goat", "\U0001F410"},
        };

        public Dictionary<string, string> Places => new Dictionary<string, string>()
        {
            {"on earth", "\U0001F30D"},
            {"on their planet", "\U0001FA90"}, // ToDo: Fix this emoji
            {"in their city", "\U0001F306"},
            {"in their country", "\U0001F304"},
            {"their hometown", "\U0001F3DEU"}, // ToDo: Fix this emoji
            {"in their village", "\U0001F3D8"},
            {"in their forest", "\U0001F333"}
        };

        public Dictionary<string, string> Events => new Dictionary<string, string>()
        {
            {"had decided to organize a big party where everyone should be invited", "\U0001F382" },
            {"started packing a bag to make it look like it was time to embark on a longer journey", "\U0001F45C"},
            {"started by telling everyone that it was a very important day today", "\U0001F338"},
            {"said that if everyone cooperated they could build a space ship together", "\U0001F6F8"},
            {"thought it was easy to build a car on your own", "\U0001F698"},
            {"meant that it was possible to build cities on the seabed", "\U0001F30A"},
            {"wanted to start a new kind of candy factory", "\U0001F36C" + "\U0001F36D"},
            {"pretended to already be big enough to start school", "\U0001F3EB"},
            {"had come up with the idea of ​​putting sails on their backs", "\U0001F32C"},
            {"had decided to invent wings that worked for everyone", "\U0001F4B8"},
            {"wanted to arrange a flight course for everyone", "\U0001F6E9"},
            {"planned to dress up as a good fairy and hand out three wishes", "\U0001FA84"},
            {"thought it was easy to build a large castle out of sand", "\U0001F3F0"},
            {"wanted to prove that there still were living dragons", "\U0001F409"},
            {"had found a lamp where it could be a genie", "\U0001FA94"},
            {"thought to have found a new way to the moon", "\U0001F314"},
            {"had found the place where the rainbow starts", "\U0001F308"}
        };

        public List<string> FairyTaleStarts => new List<string>()
        {
            "Once upon a time",
           // "About 100 years ago, one lived", // ToDo: Fix this!
            "Once upon a time there was a",
            "Some do not think this is true, but once upon a time there was a",
            "Far, far from here, there once was a",
            "In an enchanted world, there once was a",
            "In a different time than ours, there once lived a",
            "In a world where no human yet has taken a step, there once lived a",
            "Without anyone's knowledge, there once was a",
            "Far away from all kind of attention there once lived a",
            "In a very different world there once lived a",
            "Behind a secret door, in a forgotten house, a whole world is hidden. In this world there once lived a",
            "In a pretended land, which exists only in our imagination, there once lived a",
            "Not far from here there once lived a",
            "Right under your bed, the bed you usually sleep in, there is a small, small hole. "
                + "The hole is that small that no human eye yet has seen it, but anyway there is a whole world inside."
                + "In that world there once lived a "
        };

        public List<string> Relationships => new List<string>()
        {
            "friend",
            "fiend",
            "enemy",
            "buddy"
        };

        public List<string> Adjectives => new List<string>()
        {
            "happy",
            "nice",
            "funny",
            //"rowdy",
            //"pally",
            "smart",
            "nervous",
            "clever",
            "curious",
            "wandering",
            "popular",
            "cheerful",
            "messy"
        };

        public List<string> Actions => new List<string>()
        {
            "play",
            "pretend",
            "state",
            "fool everyone they knew",
            "make everyone believe",
            "persuade eachother",
            "say"
        };

        public List<string> Conditions => new List<string>()
        {
            "like in a big war",
            "peaceful",
            "lovely",
            "difficult",
            "wonderful",
            "terrible",
            "a little weird",
            "a little cranky"
        };

        public List<string> Verb => new List<string>()
        {
            "used to",
            "seemed to like to",
            "liked to",
            "thought they could"
        };

        public List<string> Circumstances => new List<string>() // ToDo: Add adjective in this
        {
            "sometimes was, but not right now", 
            "sometimes was, actually even now",
            "wasn't in reality, especially not right now",
            "wasn't, the reality was far from it",
            "actually was right now, but for someone who didn't know it was hard to believe",
        };

        public List<string> Gender => new List<string>()
        {
            "He",
            "She"
        };

        public List<string> Conversions => new List<string>()
        {
            "wanted something new to come to pass",
            "wanted to follow new plans",
            "wanted to come up with something really messy",
            "got a really fun idea",
            "hhad got a really exciting idea",
            "wanted to try something new",
            "wanted to try a new idea",
            //"wanted to realize one of their own ideas", //ToDo: Fix this!
            "wanted to make a big change",
            "wanted to make a big change",
            "wanted to give everyone a big surprise",
        };

        public List<string> Continuations => new List<string>()
        {
            "It turned out to be",
            "It started with",
            "Someone said that",
            "Someone wanted to let",
            "Someone refused to let",
            "Someone didn't want to let",
            "But"
        };
    }
}
