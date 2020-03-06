using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Languages
{
    public interface Language
    {
        String ExchangeString { get; }

        String WasNamed { get; }//"som hette "
        String HadA { get; }//" hade en "
        String A { get; }//"en "
        String WhoWasCalled { get; }//" som kallades för "
        String They { get; }//"De två "
        String ThatEverything { get; }//" att allt "
        String Was { get; }//" var "
        String It { get; }//"Det "
        String Dots { get; }// "..."

        String Dot { get; }
        String Space { get; }
        String Comma { get; }

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
