using System;
using System.Collections.Generic;
using System.Text;
using App1.Prayer;

namespace App1.Languages
{
    public interface Language
    {
        string BackToStart { get; }
        string ShareFairyTale { get; }
        string ViewFairyTale { get; }
        string BackFairyTale { get; }
        string ContinueFairyTale { get; }

        string VersionOption { get; }

        string BackToStartPageWarning { get; }
        string Warning { get; }
        string Question { get; }
        string Information { get; }

        string TapHere { get; }

        string Deletion { get; }
        string Yes { get; }
        string No { get; }
        string Short { get; }
        string Long { get; }

        string ExchangeString { get; }
        string InformationExchangeString { get; }

        string WasNamed { get; }
        string HadA { get; }
        string A { get; }
        string WhoWasCalled { get; }
        string And { get; }
        string ThatEverything { get; }
        string Was { get; }
        string Dots { get; }

        string Dot { get; }
        string Space { get; }
        string Comma { get; }
        string NewLine { get; }

        string God { get; }
        string TodayHeThinks { get; }
        string GodWantsAll { get; }
        string All { get; }
        string DoYouThink { get; }
        string GodLoves { get; }
        string WhenGodMeets { get; }
        string GodHides { get; }
        string GodIs { get; }

        List<string> GodCareVerb { get; }
        List<PrayerObject> Prayer1Objects { get; }
        List<PrayerObject> Prayer2Objects { get; }
        List<EmojiObject> Hides { get; }
        List<EmojiObject> Animals { get; }

        string LoveEmoji { get; }


    }
}
