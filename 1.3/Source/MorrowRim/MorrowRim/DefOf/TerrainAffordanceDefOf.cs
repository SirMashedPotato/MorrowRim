using System;
using Verse;
using RimWorld;

namespace MorrowRim
{
    [DefOf]
    public static class TerrainAffordanceDefOf
    {
        static TerrainAffordanceDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(TerrainAffordanceDefOf));
        }

        public static TerrainAffordanceDef MorrowRim_AshCastle;
    }
}
