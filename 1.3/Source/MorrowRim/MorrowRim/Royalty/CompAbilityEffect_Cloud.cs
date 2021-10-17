using System;
using Verse;
using RimWorld;

namespace MorrowRim
{
    class CompAbilityEffect_Cloud : CompAbilityEffect
    {
		public new CompProperties_AbilityCloud Props
		{
			get
			{
				return (CompProperties_AbilityCloud)this.props;
			}
		}

		public override void Apply(LocalTargetInfo target, LocalTargetInfo dest)
		{
			base.Apply(target, dest);
			GenExplosion.DoExplosion(target.Cell, this.parent.pawn.MapHeld, this.Props.smokeRadius, DamageDefOf.Smoke, null, -1, -1f, null, null, null, null, Props.cloudDef, 1f, 1, false, null, 0f, 1, 0f, false, null, null);
		}

		public override void DrawEffectPreview(LocalTargetInfo target)
		{
			GenDraw.DrawRadiusRing(target.Cell, this.Props.smokeRadius);
		}
	}
}
