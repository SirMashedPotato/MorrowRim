using Verse;
using Verse.AI;

namespace MorrowRim
{
    class ThinkNode_ConditionalHideFromAshStorm_Humanlike : ThinkNode_Conditional
    {

        protected override bool Satisfied(Pawn pawn)
        {
            return MorrowRim_ModSettings.SettingEnableAshStormHidingHumanlike
                && pawn.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.MorrowRim_AshBuildup) != null
                && pawn.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.MorrowRim_AshBuildup).Severity >= MorrowRim_ModSettings.SettingEnableAshStormHidingMin
                && pawn.Map != null && WeatherUtilityAsh.WeatherIsAshStorm(pawn.Map);
        }
    }
}
