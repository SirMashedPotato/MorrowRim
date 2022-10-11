using System;
using Verse;
using RimWorld;

namespace MorrowRim
{
    class CompProperties_AbilityManhunterPawnSkip : CompProperties_AbilityEffect
	{
		public CompProperties_AbilityManhunterPawnSkip()
		{
			this.compClass = typeof(CompAbilityEffect_ManhunterPawnSkip);
		}

		public PawnKindDef pawnDef;

		public int number;

		public int radius = 2;
	}
}
