using Verse;

namespace MorrowRim
{
    class ModSettings_Utility
    {

        public static float SettingToFloat(int setting)
        {
            float f = setting;
            return f / 100;
        }

        /* mod integration */

        public static bool CheckBiomesPatch()
        {
            return LoadedModManager.RunningModsListForReading.Any(x => x.Name == "MorrowRim - Biomes Patch");
        }

        public static bool CheckAshlandsSwamp()
        {
            return LoadedModManager.RunningModsListForReading.Any(x => x.Name == "MorrowRim - Ashlands Swamp");
        }

        public static bool CheckGrazelands()
        {
            return LoadedModManager.RunningModsListForReading.Any(x => x.Name == "MorrowRim - Grazelands");
        }

        public static bool CheckVolcanicAshlands()
        {
            return LoadedModManager.RunningModsListForReading.Any(x => x.Name == "MorrowRim - Volcanic Ashlands");
        }

        public static bool CheckVFEInsects()
        {
            return LoadedModManager.RunningModsListForReading.Any(x => x.Name == "Vanilla Factions Expanded - Insectoids");
        }

        public static bool MorrowRim_SettingVFIChitinIntegration()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingVFIChitinIntegration;
        }

        public static bool CheckZombieland()
        {
            return LoadedModManager.RunningModsListForReading.Any(x => x.Name == "Zombieland");
        }

        public static bool MorrowRim_SettingZombielandIntegration()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingZombielandIntegration;
        }
    }
}
