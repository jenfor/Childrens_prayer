using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Languages
{
    public interface Language
    {
        String ExchangeString { get; }

        String WasNamed { get; }
        String HadA { get; }
        String A { get; }
        String WhoWasCalled { get; }
        String They { get; }
        String ThatEverything { get; }
        String Was { get; }
        String It { get; }
        String Dots { get; }

        String Dot { get; }
        String Space { get; }
        String Comma { get; }
        String NewLine { get; }

        Dictionary<String, String> Animals { get; }
        Dictionary<String, String> Places { get; }
        Dictionary<String, String> Events { get; }

        List<String> FairyTaleStarts { get; }
        List<String> Relationships { get; }
        List<String> Adjectives { get; }
        List<String> Actions { get; }
        List<String> Conditions { get; }
        List<String> Verb { get; }
        List<String> Circumstances { get; }
        List<String> Gender { get; }
        List<String> Conversions { get; }
        List<String> Continuations { get; }
    }
}
