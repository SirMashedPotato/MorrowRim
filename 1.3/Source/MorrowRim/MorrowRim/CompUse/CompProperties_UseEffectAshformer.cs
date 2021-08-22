using System;
using Verse;
using RimWorld;

namespace MorrowRim
{
    class CompProperties_UseEffectAshformer : CompProperties_UseEffectArtifact
    {
        public CompProperties_UseEffectAshformer()
        {
            this.compClass = typeof(CompUseEffect_Ashformer);
        }
    }
}
