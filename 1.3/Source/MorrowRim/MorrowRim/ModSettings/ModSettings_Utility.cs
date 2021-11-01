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

        /* basic */

        public static bool MorrowRim_SettingEnableLightingEffects()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingEnableLightingEffects;
        }


        /* ash */

        public static bool MorrowRim_SettingEnableAshEffects()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingEnableAshEffects;
        }

        public static int MorrowRim_SettingAshFilledEye()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingAshFilledEye;
        }

        public static int MorrowRim_SettingAshCloggedServo()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingAshCloggedServo;
        }

        public static bool MorrowRim_SettingAshIgnoreResistance()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingAshIgnoreResistance;
        }

        public static float MorrowRim_SettingAshBuildupMultiplier()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingAshBuildupMultiplier;
        }

        public static int MorrowRim_SettingAshPlantDamage()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingAshPlantDamage;
        }

        public static int MorrowRim_SettingAshPlantChance()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingAshPlantChance;
        }

        public static bool MorrowRim_SettingAshOnlySownPlants()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingAshOnlySownPlants;
        }

        public static bool MorrowRim_SettingAshPreventVisitors()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingAshPreventVisitors;
        }

        public static bool MorrowRim_SettingAshRegrowth()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingAshRegrowth;
        }

        public static int MorrowRim_SettingAshTurbineDamage()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingAshTurbineDamage;
        }

        /* blight */

        public static bool MorrowRim_SettingEnableBlightEffects()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingEnableBlightEffects;
        }

        public static bool MorrowRim_SettingBlightAnimalIgnoreScaling()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingBlightAnimalIgnoreScaling;
        }

        public static int MorrowRim_SettingBlightAnimalNumber()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingBlightAnimalNumber;
        }

        public static int MorrowRim_SettingBlightAnimalChance()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingBlightAnimalChance;
        }

        public static int MorrowRim_SettingBlightPlantNumber()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingBlightPlantNumber;
        }

        public static int MorrowRim_SettingBlightPlantChance()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingBlightPlantChance;
        }

        public static float MorrowRim_SettingBlightAnimalMultiplier()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingBlightAnimalMultiplier;
        }

        /* volcanic */

        public static bool MorrowRim_SettingEnableFireEffects()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingEnableFireEffects;
        }

        public static bool MorrowRim_SettingFireOnlySownPlants()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingFireOnlySownPlants;
        }

        public static int MorrowRim_SettingFireBurnChance()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingFireBurnChance;
        }

        public static int MorrowRim_SettingFireFirePawnChance()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingFireFirePawnChance;
        }

        public static int MorrowRim_SettingFireFirePlantChance()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingFireFirePlantChance;
        }

        /* biomes */

        public static bool MorrowRim_SettingBiomeEnableAshlands()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingBiomeEnableAshlands;
        }

        public static bool MorrowRim_SettingBiomeEnableBlightedAshlands()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingBiomeEnableBlightedAshlands;
        }

        public static bool MorrowRim_SettingBiomeEnableAshlandsSwamp()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingBiomeEnableAshlandsSwamp;
        }

        public static bool MorrowRim_SettingBiomeEnablePlantsOutside()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingBiomeEnablePlantsOutside;
        }

        public static bool MorrowRim_SettingBiomeDisableSwampBeaches()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingBiomeDisableSwampBeaches;
        }

        public static bool MorrowRim_SettingBiomeSwitchToDumbLava()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingBiomeSwitchToDumbLava;
        }

        public static float MorrowRim_SettingBiomeMultiplier()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingBiomeMultiplier;
        }

        public static bool MorrowRim_SettingBiomePolarShift()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingBiomePolarShift;
        }

        /* incidents */

        public static bool MorrowRim_SettingEnableCliffRacerEvents()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingEnableCliffRacerEvents;
        }

        public static bool MorrowRim_SettingEnableSiltStriderEvent()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingEnableSiltStriderEvent;
        }

        public static bool MorrowRim_SettingEnableAlbinoGuarEvent()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingEnableAlbinoGuarEvent;
        }

        public static bool MorrowRim_SettingEnableKwamaNestEmerging()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingEnableKwamaNestEmerging;
        }

        public static bool MorrowRim_SettingEnableKwamaTrojanInfestation()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingEnableKwamaTrojanInfestation;
        }

        public static bool MorrowRim_SettingEnableCliffRacerExtinction()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingEnableCliffRacerExtinction;
        }

        public static bool MorrowRim_SettingEnableSiltStriderExtinction()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingEnableSiltStriderExtinction;
        }

        public static bool MorrowRim_SettingEnableCorprusExtinction()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingEnableCorprusExtinction;
        }

        public static bool MorrowRim_SettingEnableCorprusRefugee()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingEnableCorprusRefugee;
        }

        public static float MorrowRim_SettingEnableCorprusRefugeeChance()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingEnableCorprusRefugeeChance;
        }

        public static float MorrowRim_SettingEnableCorprusRefugeeSeverity()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingEnableCorprusRefugeeSeverity;
        }

        public static bool MorrowRim_SettingEnablePermaAshStorm()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingEnablePermaAshStorm;
        }

        public static bool MorrowRim_SettingEnablePermaAshStormOnlyAshlands()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingEnablePermaAshStormOnlyAshlands;
        }

        public static bool MorrowRim_SettingEnablePermaAshStormOnlyAshStorms()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingEnablePermaAshStormOnlyAshStorms;
        }

        /* kwama */

        public static bool MorrowRim_SettingForceKwamaNatural()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingForceKwamaNatural;
        }

        public static int MorrowRim_SettingKwamaMinDistance()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingKwamaMinDistance;
        }

        public static int MorrowRim_SettingKwamaMaxNests()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingKwamaMaxNests;
        }

        public static bool MorrowRim_SettingKwamaEnableGen()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingKwamaEnableGen;
        }

        public static bool MorrowRim_SettingEnablePredatorAvoidKwama()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingEnablePredatorAvoidKwama;
        }

        public static bool MorrowRim_SettingKwamaEnableTrojanHostile()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingKwamaEnableTrojanHostile;
        }

        public static bool MorrowRim_SettingKwamaNestReproducing()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingKwamaNestReproducing;
        }

        public static bool MorrowRim_SettingKwamaMining()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingKwamaMining;
        }

        /* animal behaviour */

        public static bool MorrowRim_SettingEnableScribBehaviour()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingEnableScribBehaviour;
        }

        public static bool MorrowRim_SettingEnableScampBehaviour()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingEnableScampBehaviour;
        }

        public static bool MorrowRim_SettingEnableScampInsults()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingEnableScampInsults;
        }

        public static bool MorrowRim_SettingEnableAshStormHiding()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingEnableAshStormHiding;
        }

        public static float MorrowRim_SettingEnableAshStormHidingMin()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingEnableAshStormHidingMin;
        }

        public static bool MorrowRim_SettingEnableAshStormHidingHumanlike()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingEnableAshStormHidingHumanlike;
        }

        /* notifications */

        public static bool MorrowRim_SettingEnableAshBuildupNotifications()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingEnableAshBuildupNotifications;
        }

        public static bool MorrowRim_SettingEnableAshBuildupNotifications_Colonist()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingEnableAshBuildupNotifications_Colonist;
        }

        public static float MorrowRim_SettingEnableAshBuildupNotifications_ColonistThreshold()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingEnableAshBuildupNotifications_ColonistThreshold;
        }

        public static bool MorrowRim_SettingEnableAshBuildupNotifications_Animals()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingEnableAshBuildupNotifications_Animals;
        }

        public static float MorrowRim_SettingEnableAshBuildupNotifications_AnimalsThreshold()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingEnableAshBuildupNotifications_AnimalsThreshold;
        }

        public static bool MorrowRim_SettingEnableAshBuildupNotifications_Friendly()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingEnableAshBuildupNotifications_Friendly;
        }

        public static float MorrowRim_SettingEnableAshBuildupNotifications_FriendlyThreshold()
        {
            return LoadedModManager.GetMod<MorrowRim_Mod>().GetSettings<MorrowRim_ModSettings>().MorrowRim_SettingEnableAshBuildupNotifications_FriendlyThreshold;
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
