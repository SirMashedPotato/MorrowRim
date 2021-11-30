using System;
using Verse;
using RimWorld;

namespace MorrowRim
{
    class CompCollapser : ThingComp
	{
		public override void CompTickRare()
		{
			int num = GenMath.RoundRandom(0.15f * (parent.Map.windManager.WindSpeed));
			if (WeatherUtilityAsh.WeatherIsAshStorm(parent.Map)) num *= 3;
			if (num > 0)
			{
				this.parent.TakeDamage(new DamageInfo(DamageDefOf.Rotting, (float)num, 0f, -1f, null, null, null, DamageInfo.SourceCategory.ThingOrUnknown, null, true, true));
			}
		}
	}
}
