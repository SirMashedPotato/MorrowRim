using RimWorld;
using Verse;

namespace MorrowRim
{
    [DefOf]
    public static class GeneDefOf
    {
        static GeneDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(GeneDefOf));
        }

        [MayRequireBiotech]
        public static GeneDef MorrowRim_AshResistance;
    }
}