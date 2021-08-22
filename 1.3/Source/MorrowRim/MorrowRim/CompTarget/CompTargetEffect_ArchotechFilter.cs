using System;
using Verse;
using RimWorld;

namespace MorrowRim
{
    class CompTargetEffect_ArchotechFilter : CompTargetEffect
    {
		public override void DoEffectOn(Pawn user, Thing target)
		{
			Pawn pawn = (Pawn)target;
			if (pawn.Dead || pawn.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.MorrowRim_ArchotechFilter) != null)
			{
				return;
			}

            if (WeatherUtilityAsh.CanBreathe(pawn))
            {
				pawn.health.AddHediff(HediffDefOf.MorrowRim_ArchotechFilter);
                if (pawn.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.MorrowRim_AshBuildup) != null)
                { 
					pawn.health.RemoveHediff(pawn.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.MorrowRim_AshBuildup));
                }
			}
		}
	}
}
