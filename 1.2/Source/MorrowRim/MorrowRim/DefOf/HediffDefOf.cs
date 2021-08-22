using System;
using Verse;
using RimWorld;

namespace MorrowRim
{
    [DefOf]
    public static class HediffDefOf
    {
        static HediffDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(HediffDefOf));
        }

        public static HediffDef MorrowRim_AshBuildup;
        public static HediffDef MorrowRim_Corprus;
        public static HediffDef MorrowRim_CorprusPermanent;
        public static HediffDef MorrowRim_CorprusSurvived;
        public static HediffDef MorrowRim_AshCloggedServo;
        public static HediffDef MorrowRim_BionicFilter;
        public static HediffDef MorrowRim_AshInEyes;
        public static HediffDef MorrowRim_HiddenInsulted;
        public static HediffDef MorrowRim_ArchotechFilter;
    }
}
