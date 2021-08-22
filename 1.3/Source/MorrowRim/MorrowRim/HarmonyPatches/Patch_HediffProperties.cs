using System.Collections.Generic;
using Verse;
using RimWorld;
using HarmonyLib;

namespace MorrowRim
{

    public static class Patch_HediffProperties
    {

        [HarmonyPatch(typeof(HediffDef), nameof(HediffDef.SpecialDisplayStats))]
        public static class CheckHediffProtective
        {
            //doesn't bother displaying if the hediff doesn't protect
            public static void Postfix(HediffDef __instance, ref IEnumerable<StatDrawEntry> __result)
            {
                var extendedRaceProps = ExtendedRaceProperties.Get(__instance);
                if (extendedRaceProps != null && extendedRaceProps.ashResistant == AshResistant.Resistant)
                {
                    __result = __result.AddItem(new StatDrawEntry(StatCategoryDefOf.BasicsImportant, "MorrowRim_AshProtection".Translate(), "MorrowRim_AshResistant_Resistant".Translate(),
                   "MorrowRim_AshResistant_DescriptionHediff".Translate(), 2619));
                }
            }
        }
    }
}