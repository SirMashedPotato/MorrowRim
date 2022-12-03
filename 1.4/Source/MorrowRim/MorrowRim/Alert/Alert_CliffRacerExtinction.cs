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
            return MorrowRim_ModSettings.SettingEnableTrueCliffRacerExtinction && MorrowRim_ModSettings.SettingEnableTrueCliffRacerExtinctionAlert ? AlertReport.Active : AlertReport.Inactive;
        }

        public override TaggedString GetExplanation()
        {
            
            return "MorrowRim_Alert_CliffRacerExtinctionDescription".Translate(TrueCliffRacerExtinctionCheck.PercentageProgress(), TrueCliffRacerExtinctionCheck.CurrentCount(), MorrowRim_ModSettings.SettingEnableTrueCliffRacerExtinctionCount);
        }
    }
}
