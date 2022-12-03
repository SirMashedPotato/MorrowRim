using Verse;

namespace MorrowRim
{
    class MorrowRim_ModSettings : ModSettings
    {
        private static MorrowRim_ModSettings _instance;

        /* ==========[GETTERS]========== */

        /* Ash storms */
        public static bool SettingEnableLightingEffects => _instance.MorrowRim_SettingEnableLightingEffects;
        public static bool SettingEnableAshEffects => _instance.MorrowRim_SettingEnableAshEffects;
        public static int SettingAshFilledEye => _instance.MorrowRim_SettingAshFilledEye;
        public static int SettingAshCloggedServo => _instance.MorrowRim_SettingAshCloggedServo;
        public static bool SettingAshIgnoreResistance => _instance.MorrowRim_SettingAshIgnoreResistance;
        public static float SettingAshBuildupMultiplier => _instance.MorrowRim_SettingAshBuildupMultiplier;
        public static int SettingAshPlantDamage => _instance.MorrowRim_SettingAshPlantDamage;
        public static int SettingAshPlantChance => _instance.MorrowRim_SettingAshPlantChance;
        public static bool SettingAshOnlySownPlants => _instance.MorrowRim_SettingAshOnlySownPlants;
        public static bool SettingAshPreventVisitors => _instance.MorrowRim_SettingAshPreventVisitors;
        public static bool SettingAshRegrowth => _instance.MorrowRim_SettingAshRegrowth;
        public static int SettingAshTurbineDamage => _instance.MorrowRim_SettingAshTurbineDamage;

        /* Blight storms */
        public static bool SettingEnableBlightEffects => _instance.MorrowRim_SettingEnableBlightEffects;
        public static int SettingBlightPlantChance => _instance.MorrowRim_SettingBlightPlantChance;
        public static int SettingBlightAnimalChance => _instance.MorrowRim_SettingBlightAnimalChance;
        public static bool SettingBlightAnimalIgnoreScaling => _instance.MorrowRim_SettingBlightAnimalIgnoreScaling;
        public static int SettingBlightAnimalNumber => _instance.MorrowRim_SettingBlightAnimalNumber;
        public static int SettingBlightPlantNumber => _instance.MorrowRim_SettingBlightPlantNumber;
        public static float SettingBlightAnimalMultiplier => _instance.MorrowRim_SettingBlightAnimalMultiplier;

        /* Volcanic storms */
        public static bool SettingEnableFireEffects => _instance.MorrowRim_SettingEnableFireEffects;
        public static bool SettingFireOnlySownPlants => _instance.MorrowRim_SettingFireOnlySownPlants;
        public static int SettingFireBurnChance => _instance.MorrowRim_SettingFireBurnChance;
        public static int SettingFireFirePawnChance => _instance.MorrowRim_SettingFireFirePawnChance;
        public static int SettingFireFirePlantChance => _instance.MorrowRim_SettingFireFirePlantChance;

        /* Biomes */
        public static bool SettingBiomeEnableAshlands => _instance.MorrowRim_SettingBiomeEnableAshlands;
        public static bool SettingBiomeEnableBlightedAshlands => _instance.MorrowRim_SettingBiomeEnableBlightedAshlands;
        public static bool SettingBiomeEnableAshlandsSwamp => _instance.MorrowRim_SettingBiomeEnableAshlandsSwamp;
        public static bool SettingBiomeEnableGrazelands => _instance.MorrowRim_SettingBiomeEnableGrazelands;
        public static bool SettingBiomeEnableVolcanicAshlands => _instance.MorrowRim_SettingBiomeEnableVolcanicAshlands;
        public static bool SettingBiomeEnablePlantsOutside => _instance.MorrowRim_SettingBiomeEnablePlantsOutside;
        public static bool SettingBiomeDisableSwampBeaches => _instance.MorrowRim_SettingBiomeDisableSwampBeaches;
        public static bool SettingBiomeSwitchToDumbLava => _instance.MorrowRim_SettingBiomeSwitchToDumbLava;
        public static float SettingBiomeMultiplier => _instance.MorrowRim_SettingBiomeMultiplier;
        public static bool SettingBiomePolarShift => _instance.MorrowRim_SettingBiomePolarShift;

        /* Kwama */
        public static bool SettingForceKwamaNatural => _instance.MorrowRim_SettingForceKwamaNatural;
        public static int SettingKwamaMinDistance => _instance.MorrowRim_SettingKwamaMinDistance;
        public static int SettingKwamaMaxNests => _instance.MorrowRim_SettingKwamaMaxNests;
        public static bool SettingKwamaEnableGen => _instance.MorrowRim_SettingKwamaEnableGen;
        public static bool SettingEnablePredatorAvoidKwama => _instance.MorrowRim_SettingEnablePredatorAvoidKwama;
        public static bool SettingKwamaEnableTrojanHostile => _instance.MorrowRim_SettingKwamaEnableTrojanHostile;
        public static bool SettingKwamaNestReproducing => _instance.MorrowRim_SettingKwamaNestReproducing;
        public static bool SettingKwamaMining => _instance.MorrowRim_SettingKwamaMining;

        /* Incidents */
        public static bool SettingEnableKwamaNestEmerging => _instance.MorrowRim_SettingEnableKwamaNestEmerging;
        public static bool SettingEnableKwamaTrojanInfestation => _instance.MorrowRim_SettingEnableKwamaTrojanInfestation;
        public static bool SettingEnableCliffRacerEvents => _instance.MorrowRim_SettingEnableCliffRacerEvents;
        public static bool SettingEnableSiltStriderEvent => _instance.MorrowRim_SettingEnableSiltStriderEvent;
        public static bool SettingEnableAlbinoGuarEvent => _instance.MorrowRim_SettingEnableAlbinoGuarEvent;
        public static bool SettingEnableCliffRacerExtinction => _instance.MorrowRim_SettingEnableCliffRacerExtinction;
        public static bool SettingEnableSiltStriderExtinction => _instance.MorrowRim_SettingEnableSiltStriderExtinction;
        public static bool SettingEnableCorprusExtinction => _instance.MorrowRim_SettingEnableCorprusExtinction;
        public static bool SettingEnableCorprusRefugee => _instance.MorrowRim_SettingEnableCorprusRefugee;
        public static float SettingEnableCorprusRefugeeChance => _instance.MorrowRim_SettingEnableCorprusRefugeeChance;
        public static float SettingEnableCorprusRefugeeSeverity => _instance.MorrowRim_SettingEnableCorprusRefugeeSeverity;
        public static bool SettingEnablePermaAshStorm => _instance.MorrowRim_SettingEnablePermaAshStorm;
        public static bool SettingEnablePermaAshStormOnlyAshlands => _instance.MorrowRim_SettingEnablePermaAshStormOnlyAshlands;
        public static bool SettingEnablePermaAshStormOnlyAshStorms => _instance.MorrowRim_SettingEnablePermaAshStormOnlyAshStorms;
        public static bool SettingEnableTrueCliffRacerExtinction => _instance.MorrowRim_SettingEnableTrueCliffRacerExtinction;
        public static int SettingEnableTrueCliffRacerExtinctionCount => _instance.MorrowRim_SettingEnableTrueCliffRacerExtinctionCount;
        public static bool SettingEnableTrueCliffRacerExtinctionAlert => _instance.MorrowRim_SettingEnableTrueCliffRacerExtinctionAlert;

        /* Behaviour */
        public static bool SettingEnableScribBehaviour => _instance.MorrowRim_SettingEnableScribBehaviour;
        public static bool SettingEnableInsectPollutionStimulus => _instance.MorrowRim_SettingEnableInsectPollutionStimulus;
        public static bool SettingEnableScampInsults => _instance.MorrowRim_SettingEnableScampInsults;
        public static bool SettingEnableAshStormHiding => _instance.MorrowRim_SettingEnableAshStormHiding;
        public static float SettingEnableAshStormHidingMin => _instance.MorrowRim_SettingEnableAshStormHidingMin;
        public static bool SettingEnableAshStormHidingHumanlike => _instance.MorrowRim_SettingEnableAshStormHidingHumanlike;
        public static bool SettingEnableAshCastles => _instance.MorrowRim_SettingEnableAshCastles;
        public static bool SettingEnableAshCastlesDuringAshStorm => _instance.MorrowRim_SettingEnableAshCastlesDuringAshStorm;
        public static float SettingEnableAshCastlesMinDistance => _instance.MorrowRim_SettingEnableAshCastlesMinDistance;

        /* Notifications */
        public static bool SettingEnableAshBuildupNotifications => _instance.MorrowRim_SettingEnableAshBuildupNotifications;
        public static bool SettingEnableAshBuildupNotifications_Colonist => _instance.MorrowRim_SettingEnableAshBuildupNotifications_Colonist;
        public static float SettingEnableAshBuildupNotifications_ColonistThreshold => _instance.MorrowRim_SettingEnableAshBuildupNotifications_ColonistThreshold;
        public static bool SettingEnableAshBuildupNotifications_Animals => _instance.MorrowRim_SettingEnableAshBuildupNotifications_Animals;
        public static float SettingEnableAshBuildupNotifications_AnimalsThreshold => _instance.MorrowRim_SettingEnableAshBuildupNotifications_AnimalsThreshold;
        public static bool SettingEnableAshBuildupNotifications_Friendly => _instance.MorrowRim_SettingEnableAshBuildupNotifications_Friendly;
        public static float SettingEnableAshBuildupNotifications_FriendlyThreshold => _instance.MorrowRim_SettingEnableAshBuildupNotifications_FriendlyThreshold;


        /* Integration */
        public static bool SettingVFIChitinIntegration => _instance.MorrowRim_SettingVFIChitinIntegration;
        public static bool SettingZombielandIntegration => _instance.MorrowRim_SettingZombielandIntegration;

        /* ==========[SETTINGS]========== */
        public bool MorrowRim_SettingEnableLightingEffects = MorrowRim_SettingEnableLightingEffects_def;
        public bool MorrowRim_SettingEnableAshEffects = MorrowRim_SettingEnableAshEffects_def;
        public int MorrowRim_SettingAshFilledEye = MorrowRim_SettingAshFilledEye_def;
        public int MorrowRim_SettingAshCloggedServo = MorrowRim_SettingAshCloggedServo_def;
        public bool MorrowRim_SettingAshIgnoreResistance = MorrowRim_SettingAshIgnoreResistance_def;
        public float MorrowRim_SettingAshBuildupMultiplier = MorrowRim_SettingAshBuildupMultiplier_def;
        public int MorrowRim_SettingAshPlantDamage = MorrowRim_SettingAshPlantDamage_def;
        public int MorrowRim_SettingAshPlantChance = MorrowRim_SettingAshPlantChance_def;
        public bool MorrowRim_SettingAshOnlySownPlants = MorrowRim_SettingAshOnlySownPlants_def;
        public bool MorrowRim_SettingAshPreventVisitors = MorrowRim_SettingAshPreventVisitors_def;
        public bool MorrowRim_SettingAshRegrowth = MorrowRim_SettingAshRegrowth_def;
        public int MorrowRim_SettingAshTurbineDamage = MorrowRim_SettingAshTurbineDamage_def;

        public bool MorrowRim_SettingEnableBlightEffects = MorrowRim_SettingEnableBlightEffects_def;
        public int MorrowRim_SettingBlightPlantChance = MorrowRim_SettingBlightPlantChance_def;
        public int MorrowRim_SettingBlightAnimalChance = MorrowRim_SettingBlightAnimalChance_def;
        public bool MorrowRim_SettingBlightAnimalIgnoreScaling = MorrowRim_SettingBlightAnimalIgnoreScaling_def;
        public int MorrowRim_SettingBlightAnimalNumber = MorrowRim_SettingBlightAnimalNumber_def;
        public int MorrowRim_SettingBlightPlantNumber = MorrowRim_SettingBlightPlantNumber_def;
        public float MorrowRim_SettingBlightAnimalMultiplier = MorrowRim_SettingBlightAnimalMultiplier_def;

        public bool MorrowRim_SettingEnableFireEffects = MorrowRim_SettingEnableFireEffects_def;
        public bool MorrowRim_SettingFireOnlySownPlants = MorrowRim_SettingFireOnlySownPlants_def;
        public int MorrowRim_SettingFireBurnChance = MorrowRim_SettingFireBurnChance_def;
        public int MorrowRim_SettingFireFirePawnChance = MorrowRim_SettingFireFirePawnChance_def;
        public int MorrowRim_SettingFireFirePlantChance = MorrowRim_SettingFireFirePlantChance_def;

        public bool MorrowRim_SettingBiomeEnableAshlands = MorrowRim_SettingBiomeEnableAshlands_def;
        public bool MorrowRim_SettingBiomeEnableBlightedAshlands = MorrowRim_SettingBiomeEnableBlightedAshlands_def;
        public bool MorrowRim_SettingBiomeEnableAshlandsSwamp = MorrowRim_SettingBiomeEnableAshlandsSwamp_def;
        public bool MorrowRim_SettingBiomeEnableGrazelands = MorrowRim_SettingBiomeEnableGrazelands_def;
        public bool MorrowRim_SettingBiomeEnableVolcanicAshlands = MorrowRim_SettingBiomeEnableVolcanicAshlands_def;
        public bool MorrowRim_SettingBiomeEnablePlantsOutside = MorrowRim_SettingBiomeEnablePlantsOutside_def;
        public bool MorrowRim_SettingBiomeDisableSwampBeaches = MorrowRim_SettingBiomeDisableSwampBeaches_def;
        public bool MorrowRim_SettingBiomeSwitchToDumbLava = MorrowRim_SettingBiomeSwitchToDumbLava_def;
        public float MorrowRim_SettingBiomeMultiplier = MorrowRim_SettingBiomeMultiplier_def;
        public bool MorrowRim_SettingBiomePolarShift = MorrowRim_SettingBiomePolarShift_def;

        public bool MorrowRim_SettingForceKwamaNatural = MorrowRim_SettingForceKwamaNatural_def;
        public int MorrowRim_SettingKwamaMinDistance = MorrowRim_SettingKwamaMinDistance_def;
        public int MorrowRim_SettingKwamaMaxNests = MorrowRim_SettingKwamaMaxNests_def;
        public bool MorrowRim_SettingKwamaEnableGen = MorrowRim_SettingKwamaEnableGen_def;
        public bool MorrowRim_SettingEnablePredatorAvoidKwama = MorrowRim_SettingEnablePredatorAvoidKwama_def;
        public bool MorrowRim_SettingKwamaEnableTrojanHostile = MorrowRim_SettingKwamaEnableTrojanHostile_def;
        public bool MorrowRim_SettingKwamaNestReproducing = MorrowRim_SettingKwamaNestReproducing_def;
        public bool MorrowRim_SettingKwamaMining = MorrowRim_SettingKwamaMining_def;

        public bool MorrowRim_SettingEnableKwamaNestEmerging = MorrowRim_SettingEnableKwamaNestEmerging_def;
        public bool MorrowRim_SettingEnableKwamaTrojanInfestation = MorrowRim_SettingEnableKwamaTrojanInfestation_def;
        public bool MorrowRim_SettingEnableCliffRacerEvents = MorrowRim_SettingEnableCliffRacerEvents_def;
        public bool MorrowRim_SettingEnableSiltStriderEvent = MorrowRim_SettingEnableSiltStriderEvent_def;
        public bool MorrowRim_SettingEnableAlbinoGuarEvent = MorrowRim_SettingEnableAlbinoGuarEvent_def;
        public bool MorrowRim_SettingEnableCliffRacerExtinction = MorrowRim_SettingEnableCliffRacerExtinction_def;
        public bool MorrowRim_SettingEnableSiltStriderExtinction = MorrowRim_SettingEnableSiltStriderExtinction_def;
        public bool MorrowRim_SettingEnableCorprusExtinction = MorrowRim_SettingEnableCorprusExtinction_def;
        public bool MorrowRim_SettingEnableCorprusRefugee = MorrowRim_SettingEnableCorprusRefugee_def;
        public float MorrowRim_SettingEnableCorprusRefugeeChance = MorrowRim_SettingEnableCorprusRefugeeChance_def;
        public float MorrowRim_SettingEnableCorprusRefugeeSeverity = MorrowRim_SettingEnableCorprusRefugeeSeverity_def;
        public bool MorrowRim_SettingEnablePermaAshStorm = MorrowRim_SettingEnablePermaAshStorm_def;
        public bool MorrowRim_SettingEnablePermaAshStormOnlyAshlands = MorrowRim_SettingEnablePermaAshStormOnlyAshlands_def;
        public bool MorrowRim_SettingEnablePermaAshStormOnlyAshStorms = MorrowRim_SettingEnablePermaAshStormOnlyAshStorms_def;
        public bool MorrowRim_SettingEnableTrueCliffRacerExtinction = MorrowRim_SettingEnableTrueCliffRacerExtinction_def;
        public int MorrowRim_SettingEnableTrueCliffRacerExtinctionCount = MorrowRim_SettingEnableTrueCliffRacerExtinctionCount_def;
        public bool MorrowRim_SettingEnableTrueCliffRacerExtinctionAlert = MorrowRim_SettingEnableTrueCliffRacerExtinctionAlert_def;

        public bool MorrowRim_SettingEnableScribBehaviour = MorrowRim_SettingEnableScribBehaviour_def;
        public bool MorrowRim_SettingEnableScampBehaviour = MorrowRim_SettingEnableScampBehaviour_def;
        public bool MorrowRim_SettingEnableInsectPollutionStimulus = MorrowRim_SettingEnableInsectPollutionStimulus_def;
        public bool MorrowRim_SettingEnableScampInsults = MorrowRim_SettingEnableScampInsults_def;
        public bool MorrowRim_SettingEnableAshStormHiding = MorrowRim_SettingEnableAshStormHiding_def;
        public float MorrowRim_SettingEnableAshStormHidingMin = MorrowRim_SettingEnableAshStormHidingMin_def;
        public bool MorrowRim_SettingEnableAshStormHidingHumanlike = MorrowRim_SettingEnableAshStormHidingHumanlike_def;
        public bool MorrowRim_SettingEnableAshCastles = MorrowRim_SettingEnableAshCastles_def;
        public bool MorrowRim_SettingEnableAshCastlesDuringAshStorm = MorrowRim_SettingEnableAshCastlesDuringAshStorm_def;
        public float MorrowRim_SettingEnableAshCastlesMinDistance = MorrowRim_SettingEnableAshCastlesMinDistance_def;

        public bool MorrowRim_SettingEnableAshBuildupNotifications = MorrowRim_SettingEnableAshBuildupNotifications_def;
        public bool MorrowRim_SettingEnableAshBuildupNotifications_Colonist = MorrowRim_SettingEnableAshBuildupNotifications_Colonist_def;
        public float MorrowRim_SettingEnableAshBuildupNotifications_ColonistThreshold = MorrowRim_SettingEnableAshBuildupNotifications_ColonistThreshold_def;
        public bool MorrowRim_SettingEnableAshBuildupNotifications_Animals = MorrowRim_SettingEnableAshBuildupNotifications_Animals_def;
        public float MorrowRim_SettingEnableAshBuildupNotifications_AnimalsThreshold = MorrowRim_SettingEnableAshBuildupNotifications_AnimalsThreshold_def;
        public bool MorrowRim_SettingEnableAshBuildupNotifications_Friendly = MorrowRim_SettingEnableAshBuildupNotifications_Friendly_def;
        public float MorrowRim_SettingEnableAshBuildupNotifications_FriendlyThreshold = MorrowRim_SettingEnableAshBuildupNotifications_FriendlyThreshold_def;

        public bool MorrowRim_SettingVFIChitinIntegration = MorrowRim_SettingVFIChitinIntegration_def;
        public bool MorrowRim_SettingZombielandIntegration = MorrowRim_SettingZombielandIntegration_def;

        /* ==========[DEFUALTS]========== */
        private static readonly bool MorrowRim_SettingEnableLightingEffects_def = true;
        private static readonly bool MorrowRim_SettingEnableAshEffects_def = true;
        private static readonly int MorrowRim_SettingAshFilledEye_def = 25;
        private static readonly int MorrowRim_SettingAshCloggedServo_def = 20;
        private static readonly bool MorrowRim_SettingAshIgnoreResistance_def = false;
        private static readonly float MorrowRim_SettingAshBuildupMultiplier_def = 1f;
        private static readonly int MorrowRim_SettingAshPlantDamage_def = 2;
        private static readonly int MorrowRim_SettingAshPlantChance_def = 10;
        private static readonly bool MorrowRim_SettingAshOnlySownPlants_def = false;
        private static readonly bool MorrowRim_SettingAshPreventVisitors_def = false;
        private static readonly bool MorrowRim_SettingAshRegrowth_def = true;
        private static readonly int MorrowRim_SettingAshTurbineDamage_def = 1;

        private static readonly bool MorrowRim_SettingEnableBlightEffects_def = true;
        private static readonly int MorrowRim_SettingBlightPlantChance_def = 10;
        private static readonly int MorrowRim_SettingBlightAnimalChance_def = 10;
        private static readonly bool MorrowRim_SettingBlightAnimalIgnoreScaling_def = false;
        private static readonly int MorrowRim_SettingBlightAnimalNumber_def = 1;
        private static readonly int MorrowRim_SettingBlightPlantNumber_def = 5;
        private static readonly float MorrowRim_SettingBlightAnimalMultiplier_def = 0.3f;

        private static readonly bool MorrowRim_SettingEnableFireEffects_def = true;
        private static readonly bool MorrowRim_SettingFireOnlySownPlants_def = false;
        private static readonly int MorrowRim_SettingFireBurnChance_def = 5;
        private static readonly int MorrowRim_SettingFireFirePawnChance_def = 5;
        private static readonly int MorrowRim_SettingFireFirePlantChance_def = 1;

        private static readonly bool MorrowRim_SettingBiomeEnableAshlands_def = true;
        private static readonly bool MorrowRim_SettingBiomeEnableBlightedAshlands_def = true;
        private static readonly bool MorrowRim_SettingBiomeEnableAshlandsSwamp_def = true;
        private static readonly bool MorrowRim_SettingBiomeEnableGrazelands_def = true;
        private static readonly bool MorrowRim_SettingBiomeEnableVolcanicAshlands_def = true;
        private static readonly bool MorrowRim_SettingBiomeEnablePlantsOutside_def = true;
        private static readonly bool MorrowRim_SettingBiomeDisableSwampBeaches_def = true;
        private static readonly bool MorrowRim_SettingBiomeSwitchToDumbLava_def = false;
        private static readonly float MorrowRim_SettingBiomeMultiplier_def = 1f;
        private static readonly bool MorrowRim_SettingBiomePolarShift_def = false;

        private static readonly bool MorrowRim_SettingForceKwamaNatural_def = true;
        private static readonly int MorrowRim_SettingKwamaMinDistance_def = 5;
        private static readonly int MorrowRim_SettingKwamaMaxNests_def = 5;
        private static readonly bool MorrowRim_SettingKwamaEnableGen_def = true;
        private static readonly bool MorrowRim_SettingEnablePredatorAvoidKwama_def = true;
        private static readonly bool MorrowRim_SettingKwamaEnableTrojanHostile_def = true;
        private static readonly bool MorrowRim_SettingKwamaNestReproducing_def = true;
        private static readonly bool MorrowRim_SettingKwamaMining_def = true;

        private static readonly bool MorrowRim_SettingEnableKwamaNestEmerging_def = true;
        private static readonly bool MorrowRim_SettingEnableKwamaTrojanInfestation_def = true;
        private static readonly bool MorrowRim_SettingEnableCliffRacerEvents_def = true;
        private static readonly bool MorrowRim_SettingEnableAlbinoGuarEvent_def = true;
        private static readonly bool MorrowRim_SettingEnableSiltStriderEvent_def = true;
        private static readonly bool MorrowRim_SettingEnableCliffRacerExtinction_def = false;
        private static readonly bool MorrowRim_SettingEnableSiltStriderExtinction_def = false;
        private static readonly bool MorrowRim_SettingEnableCorprusExtinction_def = false;
        private static readonly bool MorrowRim_SettingEnableCorprusRefugee_def = true;
        private static readonly float MorrowRim_SettingEnableCorprusRefugeeChance_def = 0.5f;
        private static readonly float MorrowRim_SettingEnableCorprusRefugeeSeverity_def = 0.1f;
        private static readonly bool MorrowRim_SettingEnablePermaAshStorm_def = false;
        private static readonly bool MorrowRim_SettingEnablePermaAshStormOnlyAshlands_def = true;
        private static readonly bool MorrowRim_SettingEnablePermaAshStormOnlyAshStorms_def = false;
        private static readonly bool MorrowRim_SettingEnableTrueCliffRacerExtinction_def = true;
        private static readonly int MorrowRim_SettingEnableTrueCliffRacerExtinctionCount_def = 10000;
        private static readonly bool MorrowRim_SettingEnableTrueCliffRacerExtinctionAlert_def = true;

        private static readonly bool MorrowRim_SettingEnableScribBehaviour_def = true;
        private static readonly bool MorrowRim_SettingEnableScampBehaviour_def = true;
        private static readonly bool MorrowRim_SettingEnableInsectPollutionStimulus_def = false;
        private static readonly bool MorrowRim_SettingEnableScampInsults_def = true;
        private static readonly bool MorrowRim_SettingEnableAshStormHiding_def = true;
        private static readonly float MorrowRim_SettingEnableAshStormHidingMin_def = 0f;
        private static readonly bool MorrowRim_SettingEnableAshStormHidingHumanlike_def = false;
        private static readonly bool MorrowRim_SettingEnableAshCastles_def = true;
        private static readonly bool MorrowRim_SettingEnableAshCastlesDuringAshStorm_def = false;
        private static readonly float MorrowRim_SettingEnableAshCastlesMinDistance_def = 12f;

        private static readonly bool MorrowRim_SettingEnableAshBuildupNotifications_def = true;
        private static readonly bool MorrowRim_SettingEnableAshBuildupNotifications_Colonist_def = true;
        private static readonly float MorrowRim_SettingEnableAshBuildupNotifications_ColonistThreshold_def = 0.5f;
        private static readonly bool MorrowRim_SettingEnableAshBuildupNotifications_Animals_def = true;
        private static readonly float MorrowRim_SettingEnableAshBuildupNotifications_AnimalsThreshold_def = 0.5f;
        private static readonly bool MorrowRim_SettingEnableAshBuildupNotifications_Friendly_def = true;
        private static readonly float MorrowRim_SettingEnableAshBuildupNotifications_FriendlyThreshold_def = 0.5f;

        private static readonly bool MorrowRim_SettingVFIChitinIntegration_def = false;
        private static readonly bool MorrowRim_SettingZombielandIntegration_def = true;

        public MorrowRim_ModSettings()
        {
            _instance = this;
        }

        /* ==========[SAVING]========== */

        public override void ExposeData()
        {
            Scribe_Values.Look(ref MorrowRim_SettingEnableLightingEffects, "MorrowRim_SettingEnableLightingEffects", MorrowRim_SettingEnableLightingEffects_def);
            Scribe_Values.Look(ref MorrowRim_SettingEnableAshEffects, "MorrowRim_SettingEnableAshEffects", MorrowRim_SettingEnableAshEffects_def);
            Scribe_Values.Look(ref MorrowRim_SettingAshFilledEye, "MorrowRim_SettingAshFilledEye", MorrowRim_SettingAshFilledEye_def);
            Scribe_Values.Look(ref MorrowRim_SettingAshCloggedServo, "MorrowRim_SettingAshCloggedServo", MorrowRim_SettingAshCloggedServo_def);
            Scribe_Values.Look(ref MorrowRim_SettingAshIgnoreResistance, "MorrowRim_SettingAshIgnoreResistance", MorrowRim_SettingAshIgnoreResistance_def);
            Scribe_Values.Look(ref MorrowRim_SettingAshBuildupMultiplier, "MorrowRim_SettingAshBuildupMultiplier", MorrowRim_SettingAshBuildupMultiplier_def);
            Scribe_Values.Look(ref MorrowRim_SettingAshPlantDamage, "MorrowRim_SettingAshPlantDamage", MorrowRim_SettingAshPlantDamage_def);
            Scribe_Values.Look(ref MorrowRim_SettingAshPlantChance, "MorrowRim_SettingAshPlantChance", MorrowRim_SettingAshPlantChance_def);
            Scribe_Values.Look(ref MorrowRim_SettingAshOnlySownPlants, "MorrowRim_SettingAshOnlySownPlants", MorrowRim_SettingAshOnlySownPlants_def);
            Scribe_Values.Look(ref MorrowRim_SettingAshPreventVisitors, "MorrowRim_SettingAshPreventVisitors", MorrowRim_SettingAshPreventVisitors_def);
            Scribe_Values.Look(ref MorrowRim_SettingAshRegrowth, "MorrowRim_SettingAshRegrowth", MorrowRim_SettingAshRegrowth_def);
            Scribe_Values.Look(ref MorrowRim_SettingAshTurbineDamage, "MorrowRim_SettingAshTurbineDamage", MorrowRim_SettingAshTurbineDamage_def);

            Scribe_Values.Look(ref MorrowRim_SettingEnableBlightEffects, "MorrowRim_SettingEnableBlightEffects", MorrowRim_SettingEnableBlightEffects_def);
            Scribe_Values.Look(ref MorrowRim_SettingBlightPlantChance, "MorrowRim_SettingBlightPlantChance", MorrowRim_SettingBlightPlantChance_def);
            Scribe_Values.Look(ref MorrowRim_SettingBlightAnimalChance, "MorrowRim_SettingBlightAnimalChance", MorrowRim_SettingBlightAnimalChance_def);
            Scribe_Values.Look(ref MorrowRim_SettingBlightAnimalIgnoreScaling, "MorrowRim_SettingBlightAnimalIgnoreScaling", MorrowRim_SettingBlightAnimalIgnoreScaling_def);
            Scribe_Values.Look(ref MorrowRim_SettingBlightAnimalNumber, "MorrowRim_SettingBlightAnimalNumber", MorrowRim_SettingBlightAnimalNumber_def);
            Scribe_Values.Look(ref MorrowRim_SettingBlightPlantNumber, "MorrowRim_SettingBlightPlantNumber", MorrowRim_SettingBlightPlantNumber_def);
            Scribe_Values.Look(ref MorrowRim_SettingBlightAnimalMultiplier, "MorrowRim_SettingBlightAnimalMultiplier", MorrowRim_SettingBlightAnimalMultiplier_def);

            Scribe_Values.Look(ref MorrowRim_SettingEnableFireEffects, "MorrowRim_SettingEnableFireEffects", MorrowRim_SettingEnableFireEffects_def);
            Scribe_Values.Look(ref MorrowRim_SettingFireBurnChance, "MorrowRim_SettingFireBurnChance", MorrowRim_SettingFireBurnChance_def);
            Scribe_Values.Look(ref MorrowRim_SettingFireFirePawnChance, "MorrowRim_SettingFireFirePawnChance", MorrowRim_SettingFireFirePawnChance_def);
            Scribe_Values.Look(ref MorrowRim_SettingFireFirePlantChance, "MorrowRim_SettingFireFirePlantChance", MorrowRim_SettingFireFirePlantChance_def);
            Scribe_Values.Look(ref MorrowRim_SettingFireOnlySownPlants, "MorrowRim_SettingFireOnlySownPlants", MorrowRim_SettingFireOnlySownPlants_def);

            Scribe_Values.Look(ref MorrowRim_SettingBiomeEnableAshlands, "MorrowRim_SettingBiomeEnableAshlands", MorrowRim_SettingBiomeEnableAshlands_def);
            Scribe_Values.Look(ref MorrowRim_SettingBiomeEnableBlightedAshlands, "MorrowRim_SettingBiomeEnableBlightedAshlands", MorrowRim_SettingBiomeEnableBlightedAshlands_def);
            Scribe_Values.Look(ref MorrowRim_SettingBiomeEnableAshlandsSwamp, "MorrowRim_SettingBiomeEnableAshlandsSwamp", MorrowRim_SettingBiomeEnableAshlandsSwamp_def);
            Scribe_Values.Look(ref MorrowRim_SettingBiomeEnableGrazelands, "MorrowRim_SettingBiomeEnableGrazelands", MorrowRim_SettingBiomeEnableGrazelands_def);
            Scribe_Values.Look(ref MorrowRim_SettingBiomeEnableVolcanicAshlands, "MorrowRim_SettingBiomeEnableVolcanicAshlands", MorrowRim_SettingBiomeEnableVolcanicAshlands_def);
            Scribe_Values.Look(ref MorrowRim_SettingBiomeEnablePlantsOutside, "MorrowRim_SettingBiomeEnablePlantsOutside", MorrowRim_SettingBiomeEnablePlantsOutside_def);
            Scribe_Values.Look(ref MorrowRim_SettingBiomeDisableSwampBeaches, "MorrowRim_SettingBiomeDisableSwampBeaches", MorrowRim_SettingBiomeDisableSwampBeaches_def);
            Scribe_Values.Look(ref MorrowRim_SettingBiomeSwitchToDumbLava, "MorrowRim_SettingBiomeSwitchToDumbLava", MorrowRim_SettingBiomeSwitchToDumbLava_def);
            Scribe_Values.Look(ref MorrowRim_SettingBiomeMultiplier, "MorrowRim_SettingBiomeMultiplier", MorrowRim_SettingBiomeMultiplier_def);
            Scribe_Values.Look(ref MorrowRim_SettingBiomePolarShift, "MorrowRim_SettingBiomePolarShift", MorrowRim_SettingBiomePolarShift_def);

            Scribe_Values.Look(ref MorrowRim_SettingForceKwamaNatural, "MorrowRim_SettingForceKwamaNatural", MorrowRim_SettingForceKwamaNatural_def);
            Scribe_Values.Look(ref MorrowRim_SettingKwamaMinDistance, "MorrowRim_SettingKwamaMinDistance", MorrowRim_SettingKwamaMinDistance_def);
            Scribe_Values.Look(ref MorrowRim_SettingKwamaMaxNests, "MorrowRim_SettingKwamaMaxNests", MorrowRim_SettingKwamaMaxNests_def);
            Scribe_Values.Look(ref MorrowRim_SettingKwamaEnableGen, "MorrowRim_SettingKwamaEnableGen", MorrowRim_SettingKwamaEnableGen_def);
            Scribe_Values.Look(ref MorrowRim_SettingEnablePredatorAvoidKwama, "MorrowRim_SettingEnablePredatorAvoidKwama", MorrowRim_SettingEnablePredatorAvoidKwama_def);
            Scribe_Values.Look(ref MorrowRim_SettingKwamaEnableTrojanHostile, "MorrowRim_SettingKwamaEnableTrojanHostile", MorrowRim_SettingKwamaEnableTrojanHostile_def);
            Scribe_Values.Look(ref MorrowRim_SettingKwamaNestReproducing, "MorrowRim_SettingKwamaNestReproducing", MorrowRim_SettingKwamaNestReproducing_def);
            Scribe_Values.Look(ref MorrowRim_SettingKwamaMining, "MorrowRim_SettingKwamaMining", MorrowRim_SettingKwamaMining_def);

            Scribe_Values.Look(ref MorrowRim_SettingEnableKwamaNestEmerging, "MorrowRim_SettingEnableKwamaNestEmerging", MorrowRim_SettingEnableKwamaNestEmerging_def);
            Scribe_Values.Look(ref MorrowRim_SettingEnableKwamaTrojanInfestation, "MorrowRim_SettingEnableKwamaTrojanInfestation", MorrowRim_SettingEnableKwamaTrojanInfestation_def);
            Scribe_Values.Look(ref MorrowRim_SettingEnableCliffRacerEvents, "MorrowRim_SettingEnableCliffRacerEvents", MorrowRim_SettingEnableCliffRacerEvents_def);
            Scribe_Values.Look(ref MorrowRim_SettingEnableAlbinoGuarEvent, "MorrowRim_SettingEnableAlbinoGuarEvent", MorrowRim_SettingEnableAlbinoGuarEvent_def);
            Scribe_Values.Look(ref MorrowRim_SettingEnableSiltStriderEvent, "MorrowRim_SettingEnableSiltStriderEvent", MorrowRim_SettingEnableSiltStriderEvent_def);
            Scribe_Values.Look(ref MorrowRim_SettingEnableCliffRacerExtinction, "MorrowRim_SettingEnableCliffRacerExtinction", MorrowRim_SettingEnableCliffRacerExtinction_def);
            Scribe_Values.Look(ref MorrowRim_SettingEnableSiltStriderExtinction, "MorrowRim_SettingEnableSiltStriderExtinction", MorrowRim_SettingEnableSiltStriderExtinction_def);
            Scribe_Values.Look(ref MorrowRim_SettingEnableCorprusExtinction, "MorrowRim_SettingEnableCorprusExtinction", MorrowRim_SettingEnableCorprusExtinction_def);
            Scribe_Values.Look(ref MorrowRim_SettingEnableCorprusRefugee, "MorrowRim_SettingEnableCorprusRefugee", MorrowRim_SettingEnableCorprusRefugee_def);
            Scribe_Values.Look(ref MorrowRim_SettingEnableCorprusRefugeeChance, "MorrowRim_SettingEnableCorprusRefugeeChance", MorrowRim_SettingEnableCorprusRefugeeChance_def);
            Scribe_Values.Look(ref MorrowRim_SettingEnableCorprusRefugeeSeverity, "MorrowRim_SettingEnableCorprusRefugeeSeverity", MorrowRim_SettingEnableCorprusRefugeeSeverity_def);
            Scribe_Values.Look(ref MorrowRim_SettingEnablePermaAshStorm, "MorrowRim_SettingEnablePermaAshStorm", MorrowRim_SettingEnablePermaAshStorm_def);
            Scribe_Values.Look(ref MorrowRim_SettingEnablePermaAshStormOnlyAshlands, "MorrowRim_SettingEnablePermaAshStormOnlyAshlands", MorrowRim_SettingEnablePermaAshStormOnlyAshlands_def);
            Scribe_Values.Look(ref MorrowRim_SettingEnablePermaAshStormOnlyAshStorms, "MorrowRim_SettingEnablePermaAshStormOnlyAshStorms", MorrowRim_SettingEnablePermaAshStormOnlyAshStorms_def);
            Scribe_Values.Look(ref MorrowRim_SettingEnableTrueCliffRacerExtinction, "MorrowRim_SettingEnableTrueCliffRacerExtinction", MorrowRim_SettingEnableTrueCliffRacerExtinction_def);
            Scribe_Values.Look(ref MorrowRim_SettingEnableTrueCliffRacerExtinctionCount, "MorrowRim_SettingEnableTrueCliffRacerExtinctionCount", MorrowRim_SettingEnableTrueCliffRacerExtinctionCount_def);
            Scribe_Values.Look(ref MorrowRim_SettingEnableTrueCliffRacerExtinctionAlert, "MorrowRim_SettingEnableTrueCliffRacerExtinctionAlert", MorrowRim_SettingEnableTrueCliffRacerExtinctionAlert_def);

            Scribe_Values.Look(ref MorrowRim_SettingEnableScribBehaviour, "MorrowRim_SettingEnableScribBehaviour", MorrowRim_SettingEnableScribBehaviour_def);
            Scribe_Values.Look(ref MorrowRim_SettingEnableScampBehaviour, "MorrowRim_SettingEnableScampBehaviour", MorrowRim_SettingEnableScampBehaviour_def);
            Scribe_Values.Look(ref MorrowRim_SettingEnableInsectPollutionStimulus, "MorrowRim_SettingEnableInsectPollutionStimulus", MorrowRim_SettingEnableInsectPollutionStimulus_def);
            Scribe_Values.Look(ref MorrowRim_SettingEnableScampInsults, "MorrowRim_SettingEnableScampInsults", MorrowRim_SettingEnableScampInsults_def);
            Scribe_Values.Look(ref MorrowRim_SettingEnableAshStormHiding, "MorrowRim_SettingEnableAshStormHiding", MorrowRim_SettingEnableAshStormHiding_def);
            Scribe_Values.Look(ref MorrowRim_SettingEnableAshStormHidingMin, "MorrowRim_SettingEnableAshStormHidingMin", MorrowRim_SettingEnableAshStormHidingMin_def);
            Scribe_Values.Look(ref MorrowRim_SettingEnableAshStormHidingHumanlike, "MorrowRim_SettingEnableAshStormHidingHumanlike", MorrowRim_SettingEnableAshStormHidingHumanlike_def);
            Scribe_Values.Look(ref MorrowRim_SettingEnableAshCastles, "MorrowRim_SettingEnableAshCastles", MorrowRim_SettingEnableAshCastles_def);
            Scribe_Values.Look(ref MorrowRim_SettingEnableAshCastlesDuringAshStorm, "MorrowRim_SettingEnableAshCastlesDuringAshStorm", MorrowRim_SettingEnableAshCastlesDuringAshStorm_def);
            Scribe_Values.Look(ref MorrowRim_SettingEnableAshCastlesMinDistance, "MorrowRim_SettingEnableAshCastlesMinDistance", MorrowRim_SettingEnableAshCastlesMinDistance_def);

            Scribe_Values.Look(ref MorrowRim_SettingEnableAshBuildupNotifications, "MorrowRim_SettingEnableAshBuildupNotifications", MorrowRim_SettingEnableAshBuildupNotifications_def);
            Scribe_Values.Look(ref MorrowRim_SettingEnableAshBuildupNotifications_Colonist, "MorrowRim_SettingEnableAshBuildupNotifications_Colonist", MorrowRim_SettingEnableAshBuildupNotifications_Colonist_def);
            Scribe_Values.Look(ref MorrowRim_SettingEnableAshBuildupNotifications_ColonistThreshold, "MorrowRim_SettingEnableAshBuildupNotifications_ColonistThreshold", MorrowRim_SettingEnableAshBuildupNotifications_ColonistThreshold_def);
            Scribe_Values.Look(ref MorrowRim_SettingEnableAshBuildupNotifications_Animals, "MorrowRim_SettingEnableAshBuildupNotifications_Animals", MorrowRim_SettingEnableAshBuildupNotifications_Animals_def);
            Scribe_Values.Look(ref MorrowRim_SettingEnableAshBuildupNotifications_Animals, "MorrowRim_SettingEnableAshBuildupNotifications_Animals", MorrowRim_SettingEnableAshBuildupNotifications_Animals_def);
            Scribe_Values.Look(ref MorrowRim_SettingEnableAshBuildupNotifications_Friendly, "MorrowRim_SettingEnableAshBuildupNotifications_Friendly", MorrowRim_SettingEnableAshBuildupNotifications_Friendly_def);
            Scribe_Values.Look(ref MorrowRim_SettingEnableAshBuildupNotifications_FriendlyThreshold, "MorrowRim_SettingEnableAshBuildupNotifications_FriendlyThreshold", MorrowRim_SettingEnableAshBuildupNotifications_FriendlyThreshold_def);

            Scribe_Values.Look(ref MorrowRim_SettingVFIChitinIntegration, "MorrowRim_SettingVFIChitinIntegration", MorrowRim_SettingVFIChitinIntegration_def);
            Scribe_Values.Look(ref MorrowRim_SettingZombielandIntegration, "MorrowRim_SettingZombielandIntegration", MorrowRim_SettingZombielandIntegration_def);

            base.ExposeData();
        }

        /* ==========[RESETTING]========== */

        public static void ResetSettings()
        {
            ResetSettings_Ash();
            ResetSettings_Blight();
            ResetSettings_Fire();
            ResetSettings_Biome();
            ResetSettings_Kwama();
            ResetSettings_Incident();
            ResetSettings_ModIntegration();
            ResetSettings_AnimalBehaviour();
            ResetSettings_Notification();
        }

        public static void ResetSettings_Ash()
        {
            _instance.MorrowRim_SettingAshBuildupMultiplier = MorrowRim_SettingAshBuildupMultiplier_def;
            _instance.MorrowRim_SettingAshCloggedServo = MorrowRim_SettingAshCloggedServo_def;
            _instance.MorrowRim_SettingAshFilledEye = MorrowRim_SettingAshFilledEye_def;
            _instance.MorrowRim_SettingAshIgnoreResistance = MorrowRim_SettingAshIgnoreResistance_def;
            _instance.MorrowRim_SettingAshPlantChance = MorrowRim_SettingAshPlantChance_def;
            _instance.MorrowRim_SettingAshPlantDamage = MorrowRim_SettingAshPlantDamage_def;
            _instance.MorrowRim_SettingEnableAshEffects = MorrowRim_SettingEnableAshEffects_def;
            _instance.MorrowRim_SettingEnableLightingEffects = MorrowRim_SettingEnableLightingEffects_def;
            _instance.MorrowRim_SettingAshOnlySownPlants = MorrowRim_SettingAshOnlySownPlants_def;
            _instance.MorrowRim_SettingAshPreventVisitors = MorrowRim_SettingAshPreventVisitors_def;
            _instance.MorrowRim_SettingAshRegrowth = MorrowRim_SettingAshRegrowth_def;
            _instance.MorrowRim_SettingAshTurbineDamage = MorrowRim_SettingAshTurbineDamage_def;
        }

        public static void ResetSettings_Blight()
        {
            _instance.MorrowRim_SettingBlightPlantChance = MorrowRim_SettingBlightPlantChance_def;
            _instance.MorrowRim_SettingEnableBlightEffects = MorrowRim_SettingEnableBlightEffects_def;
            _instance.MorrowRim_SettingBlightAnimalChance = MorrowRim_SettingBlightAnimalChance_def;
            _instance.MorrowRim_SettingBlightAnimalIgnoreScaling = MorrowRim_SettingBlightAnimalIgnoreScaling_def;
            _instance.MorrowRim_SettingBlightAnimalNumber = MorrowRim_SettingBlightAnimalNumber_def;
            _instance.MorrowRim_SettingBlightPlantNumber = MorrowRim_SettingBlightPlantNumber_def;
            _instance.MorrowRim_SettingBlightAnimalMultiplier = MorrowRim_SettingBlightAnimalMultiplier_def;
        }

        public static void ResetSettings_Fire()
        {
            _instance.MorrowRim_SettingEnableFireEffects = MorrowRim_SettingEnableFireEffects_def;
            _instance.MorrowRim_SettingFireBurnChance = MorrowRim_SettingFireBurnChance_def;
            _instance.MorrowRim_SettingFireFirePawnChance = MorrowRim_SettingFireFirePawnChance_def;
            _instance.MorrowRim_SettingFireFirePlantChance = MorrowRim_SettingFireFirePlantChance_def;
            _instance.MorrowRim_SettingFireOnlySownPlants = MorrowRim_SettingFireOnlySownPlants_def;
        }

        public static void ResetSettings_Biome()
        {
            _instance.MorrowRim_SettingBiomeEnableAshlands = MorrowRim_SettingBiomeEnableAshlands_def;
            _instance.MorrowRim_SettingBiomeEnableBlightedAshlands = MorrowRim_SettingBiomeEnableBlightedAshlands_def;
            _instance.MorrowRim_SettingBiomeEnableAshlandsSwamp = MorrowRim_SettingBiomeEnableAshlandsSwamp_def;
            _instance.MorrowRim_SettingBiomeEnableGrazelands = MorrowRim_SettingBiomeEnableGrazelands_def;
            _instance.MorrowRim_SettingBiomeEnableVolcanicAshlands = MorrowRim_SettingBiomeEnableVolcanicAshlands_def;
            _instance.MorrowRim_SettingBiomeEnablePlantsOutside = MorrowRim_SettingBiomeEnablePlantsOutside_def;
            _instance.MorrowRim_SettingBiomeDisableSwampBeaches = MorrowRim_SettingBiomeDisableSwampBeaches_def;
            _instance.MorrowRim_SettingBiomeSwitchToDumbLava = MorrowRim_SettingBiomeSwitchToDumbLava_def;
            _instance.MorrowRim_SettingBiomeMultiplier = MorrowRim_SettingBiomeMultiplier_def;
            _instance.MorrowRim_SettingBiomePolarShift = MorrowRim_SettingBiomePolarShift_def;
        }

        public static void ResetSettings_Kwama()
        {
            _instance.MorrowRim_SettingForceKwamaNatural = MorrowRim_SettingForceKwamaNatural_def;
            _instance.MorrowRim_SettingKwamaMinDistance = MorrowRim_SettingKwamaMinDistance_def;
            _instance.MorrowRim_SettingKwamaMaxNests = MorrowRim_SettingKwamaMaxNests_def;
            _instance.MorrowRim_SettingKwamaEnableGen = MorrowRim_SettingKwamaEnableGen_def;
            _instance.MorrowRim_SettingEnablePredatorAvoidKwama = MorrowRim_SettingEnablePredatorAvoidKwama_def;
            _instance.MorrowRim_SettingKwamaEnableTrojanHostile = MorrowRim_SettingKwamaEnableTrojanHostile_def;
            _instance.MorrowRim_SettingKwamaNestReproducing = MorrowRim_SettingKwamaNestReproducing_def;
            _instance.MorrowRim_SettingKwamaMining = MorrowRim_SettingKwamaMining_def;
        }

        public static void ResetSettings_Incident()
        {
            _instance.MorrowRim_SettingEnableKwamaNestEmerging = MorrowRim_SettingEnableKwamaNestEmerging_def;
            _instance.MorrowRim_SettingEnableKwamaTrojanInfestation = MorrowRim_SettingEnableKwamaTrojanInfestation_def;
            _instance.MorrowRim_SettingEnableCliffRacerEvents = MorrowRim_SettingEnableCliffRacerEvents_def;
            _instance.MorrowRim_SettingEnableAlbinoGuarEvent = MorrowRim_SettingEnableAlbinoGuarEvent_def;
            _instance.MorrowRim_SettingEnableSiltStriderEvent = MorrowRim_SettingEnableSiltStriderEvent_def;
            _instance.MorrowRim_SettingEnableCliffRacerExtinction = MorrowRim_SettingEnableCliffRacerExtinction_def;
            _instance.MorrowRim_SettingEnableSiltStriderExtinction = MorrowRim_SettingEnableSiltStriderExtinction_def;
            _instance.MorrowRim_SettingEnableCorprusExtinction = MorrowRim_SettingEnableCorprusExtinction_def;
            _instance.MorrowRim_SettingEnableCorprusRefugee = MorrowRim_SettingEnableCorprusRefugee_def;
            _instance.MorrowRim_SettingEnableCorprusRefugeeChance = MorrowRim_SettingEnableCorprusRefugeeChance_def;
            _instance.MorrowRim_SettingEnableCorprusRefugeeSeverity = MorrowRim_SettingEnableCorprusRefugeeSeverity_def;
            _instance.MorrowRim_SettingEnablePermaAshStorm = MorrowRim_SettingEnablePermaAshStorm_def;
            _instance.MorrowRim_SettingEnablePermaAshStormOnlyAshlands = MorrowRim_SettingEnablePermaAshStormOnlyAshlands_def;
            _instance.MorrowRim_SettingEnablePermaAshStormOnlyAshStorms = MorrowRim_SettingEnablePermaAshStormOnlyAshStorms_def;
            _instance.MorrowRim_SettingEnableTrueCliffRacerExtinction = MorrowRim_SettingEnableTrueCliffRacerExtinction_def;
            _instance.MorrowRim_SettingEnableTrueCliffRacerExtinctionCount = MorrowRim_SettingEnableTrueCliffRacerExtinctionCount_def;
            _instance.MorrowRim_SettingEnableTrueCliffRacerExtinctionAlert = MorrowRim_SettingEnableTrueCliffRacerExtinctionAlert_def;
        }

        public static void ResetSettings_AnimalBehaviour()
        {
            _instance.MorrowRim_SettingEnableScribBehaviour = MorrowRim_SettingEnableScribBehaviour_def;
            _instance.MorrowRim_SettingEnableScampBehaviour = MorrowRim_SettingEnableScampBehaviour_def;
            _instance.MorrowRim_SettingEnableInsectPollutionStimulus = MorrowRim_SettingEnableInsectPollutionStimulus_def;
            _instance.MorrowRim_SettingEnableScampInsults = MorrowRim_SettingEnableScampInsults_def;
            _instance.MorrowRim_SettingEnableAshStormHiding = MorrowRim_SettingEnableAshStormHiding_def;
            _instance.MorrowRim_SettingEnableAshStormHidingMin = MorrowRim_SettingEnableAshStormHidingMin_def;
            _instance.MorrowRim_SettingEnableAshStormHidingHumanlike = MorrowRim_SettingEnableAshStormHidingHumanlike_def;
            _instance.MorrowRim_SettingEnableAshCastles = MorrowRim_SettingEnableAshCastles_def;
            _instance.MorrowRim_SettingEnableAshCastlesDuringAshStorm = MorrowRim_SettingEnableAshCastlesDuringAshStorm_def;
            _instance.MorrowRim_SettingEnableAshCastlesMinDistance = MorrowRim_SettingEnableAshCastlesMinDistance_def;
        }

        public static void ResetSettings_Notification()
        {
            _instance.MorrowRim_SettingEnableAshBuildupNotifications = MorrowRim_SettingEnableAshBuildupNotifications_def;
            _instance.MorrowRim_SettingEnableAshBuildupNotifications_Colonist = MorrowRim_SettingEnableAshBuildupNotifications_Colonist_def;
            _instance.MorrowRim_SettingEnableAshBuildupNotifications_ColonistThreshold = MorrowRim_SettingEnableAshBuildupNotifications_ColonistThreshold_def;
            _instance.MorrowRim_SettingEnableAshBuildupNotifications_Animals = MorrowRim_SettingEnableAshBuildupNotifications_Animals_def;
            _instance.MorrowRim_SettingEnableAshBuildupNotifications_AnimalsThreshold = MorrowRim_SettingEnableAshBuildupNotifications_AnimalsThreshold_def;
            _instance.MorrowRim_SettingEnableAshBuildupNotifications_Friendly = MorrowRim_SettingEnableAshBuildupNotifications_Friendly_def;
            _instance.MorrowRim_SettingEnableAshBuildupNotifications_FriendlyThreshold = MorrowRim_SettingEnableAshBuildupNotifications_FriendlyThreshold_def;
        }

        public static void ResetSettings_ModIntegration()
        {
            _instance.MorrowRim_SettingVFIChitinIntegration = MorrowRim_SettingVFIChitinIntegration_def;
            _instance.MorrowRim_SettingZombielandIntegration = MorrowRim_SettingZombielandIntegration_def;
        }

        public static void ResetSettings_Zombieland()
        {
            _instance.MorrowRim_SettingZombielandIntegration = MorrowRim_SettingZombielandIntegration_def;
        }
    }
}
