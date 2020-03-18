using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Languages
{
    public interface Language
    {
        string NewFairyTale { get; }
        string ShareFairyTale { get; }
        string BackFairyTale { get; }
        string ContinueFairyTale { get; }

        string Warning { get; }
        string Deletion { get; }
        string Yes { get; }
        string No { get; }

        string ExchangeString { get; }

        string WasNamed { get; }
        string HadA { get; }
        string A { get; }
        string WhoWasCalled { get; }
        string They { get; }
        string ThatEverything { get; }
        string Was { get; }
        string It { get; }
        string Dots { get; }

        string Dot { get; }
        string Space { get; }
        string Comma { get; }
        string NewLine { get; }

        Dictionary<string, string> Animals { get; }
        Dictionary<string, string> Places { get; }
        Dictionary<string, string> Events { get; }

        List<string> FairyTaleStarts { get; }
        List<string> Relationships { get; }
        List<string> Adjectives { get; }
        List<string> Actions { get; }
        List<string> Conditions { get; }
        List<string> Verb { get; }
        List<string> Circumstances { get; }
        List<string> Gender { get; }
        List<string> Conversions { get; }
        List<string> Continuations { get; }
    }
}
