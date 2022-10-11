using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Verse;
using Verse.AI;
using RimWorld;

namespace MorrowRim
{
    class CompAbilityEffect_ManhunterPawnSkip : CompAbilityEffect
    {

        public new CompProperties_AbilityManhunterPawnSkip Props
        {
            get
            {
                return (CompProperties_AbilityManhunterPawnSkip)this.props;
            }
        }

        public override void Apply(LocalTargetInfo target, LocalTargetInfo dest)
        {
            base.Apply(target, dest);

            for (int i = 0; i < Props.number; i++)
            {
                IntVec3 loc = CellFinder.RandomClosewalkCellNear(target.Cell, this.parent.pawn.MapHeld, Props.radius, null);
                ((Pawn)GenSpawn.Spawn(PawnGenerator.GeneratePawn(Props.pawnDef, null), loc, this.parent.pawn.MapHeld, WipeMode.Vanish)).mindState.mentalStateHandler.TryStartMentalState(MentalStateDefOf.ManhunterPermanent);
            }
        }

        public override void DrawEffectPreview(LocalTargetInfo target)
        {
            GenDraw.DrawRadiusRing(target.Cell, Props.radius);
        }
    }
}
