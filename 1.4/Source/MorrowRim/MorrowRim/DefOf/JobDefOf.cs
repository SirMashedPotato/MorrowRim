using System;
using Verse;
using RimWorld;

namespace MorrowRim
{
    [DefOf]
    public static class JobDefOf
    {
        static JobDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(JobDefOf));
        }

        public static JobDef MorrowRim_GotoSafeFromAshstorm;
        public static JobDef MorrowRim_Wait_DuringAshstorm;

    }
}
