using System;
using System.Collections.Generic;
using RimWorld;
using RimWorld.Planet;
using UnityEngine;
using Verse;

namespace MorrowRim
{
    class Alert_CliffRacerExtinction : Alert
    {
        public Alert_CliffRacerExtinction()
        {
            this.defaultLabel = "MorrowRim_Alert_CliffRacerExtinction".Translate();
            this.defaultPriority = AlertPriority.Medium;
        }

        public override AlertReport GetReport()
        {
            return ModSettings_Utility.MorrowRim_SettingEnableTrueCliffRacerExtinction() && ModSettings_Utility.MorrowRim_SettingEnableTrueCliffRacerExtinctionAlert() ? AlertReport.Active : AlertReport.Inactive;
        }

        public override TaggedString GetExplanation()
        {
            
            return "MorrowRim_Alert_CliffRacerExtinctionDescription".Translate(TrueCliffRacerExtinctionCheck.PercentageProgress(), TrueCliffRacerExtinctionCheck.CurrentCount(), ModSettings_Utility.MorrowRim_SettingEnableTrueCliffRacerExtinctionCount());
        }
    }
}
