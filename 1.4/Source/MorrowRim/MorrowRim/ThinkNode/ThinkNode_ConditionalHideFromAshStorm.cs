using Verse;
using Verse.AI;

namespace MorrowRim
{
    class ThinkNode_ConditionalHideFromAshStorm : ThinkNode_Conditional
    {

        protected override bool Satisfied(Pawn pawn)
        {
            return MorrowRim_ModSettings.SettingEnableAshStormHiding
                && pawn.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.MorrowRim_AshBuildup) != null
                && pawn.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.MorrowRim_AshBuildup).Severity >= MorrowRim_ModSettings.SettingEnableAshStormHidingMin
                && pawn.Map != null && WeatherUtilityAsh.WeatherIsAshStorm(pawn.Map);
        }
    }
}
