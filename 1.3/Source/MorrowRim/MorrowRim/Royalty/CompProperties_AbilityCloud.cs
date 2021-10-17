using System;
using Verse;
using RimWorld;
namespace MorrowRim
{
    class CompProperties_AbilityCloud : CompProperties_AbilityEffect
	{
		public CompProperties_AbilityCloud()
		{
			this.compClass = typeof(CompAbilityEffect_Cloud);
		}

		public ThingDef cloudDef;

		public float smokeRadius;
	}
}
