using System;
using Verse;
using RimWorld;

namespace MorrowRim
{
    [DefOf]
    public static class ThingDefOf
    {
        static ThingDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(ThingDefOf));
        }

        public static ThingDef MorrowRim_SiltStrider;
        public static ThingDef MorrowRim_CliffRacer;
        public static ThingDef MorrowRim_RetchingNetch;
        public static ThingDef MorrowRim_AlbinoGuar;
        public static ThingDef MorrowRim_Shalk;
        public static ThingDef MorrowRim_AshHopper;
        public static ThingDef MorrowRim_NixOx;
        public static ThingDef MorrowRim_FungalShalk;

        public static ThingDef Gas_RetchingNetch;
        public static ThingDef Gas_Corprus;
        public static ThingDef MorrowRim_Gas_Ash;

        public static ThingDef MorrowRim_CorprusStalker;

        //silt strider shells
        public static ThingDef MorrowRim_SiltStriderShell;

        //kwama
        public static ThingDef MorrowRim_KwamaNest;
        public static ThingDef MorrowRim_KwamaEgg;
        public static ThingDef MorrowRim_KwamaEggSac;
        public static ThingDef KwamaTunnelSpawner;
        public static ThingDef MorrowRim_FungalMash;

        public static ThingDef MorrowRim_KwamaScrib;
        public static ThingDef MorrowRim_KwamaForager;
        public static ThingDef MorrowRim_KwamaWorker;
        public static ThingDef MorrowRim_KwamaWarrior;

        //wild plants
        public static ThingDef MorrowRim_MuckSponge;
        public static ThingDef MorrowRim_AshYam_Wild;
        public static ThingDef MorrowRim_HackleLo_Wild;
        public static ThingDef MorrowRim_CorkBulb_Wild;
        public static ThingDef MorrowRim_Scathecraw_Wild;
        public static ThingDef MorrowRim_Kreshweed_Wild;

        //other plants
        public static ThingDef MorrowRim_ScribCabbage;

        //Items
        public static ThingDef MorrowRim_RawScribCabbage;
    }
}
