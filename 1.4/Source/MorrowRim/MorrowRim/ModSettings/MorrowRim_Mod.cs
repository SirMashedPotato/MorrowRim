using UnityEngine;
using Verse;
using System;

namespace MorrowRim
{
    class MorrowRim_Mod : Mod
    {
        MorrowRim_ModSettings settings;
        public MorrowRim_Mod(ModContentPack contentPack) : base(contentPack)
        {
            this.settings = GetSettings<MorrowRim_ModSettings>();
        }

        public override string SettingsCategory() => "MorrowRim - Ashlands & Core";

        private int page = 0;

        private static Vector2 scrollPosition = Vector2.zero;

        public override void DoSettingsWindowContents(Rect inRect)
        {

            var firstColumnWidth = (inRect.width - Listing.ColumnSpacing) * 3.5f / 5f;
            var secondColumnWidth = inRect.width - Listing.ColumnSpacing - firstColumnWidth;

            var outerRect = new Rect(inRect.x, inRect.y, firstColumnWidth, inRect.height);
            var innerRect = new Rect(0f, 0f, firstColumnWidth - 24f, inRect.height * 2);
            Widgets.BeginScrollView(outerRect, ref scrollPosition, innerRect, true);

            var listing_Standard = new Listing_Standard();
            listing_Standard.Begin(innerRect);

            //get page
            switch (page)
            {
                case 1:
                    listing_Standard = SettingsPage_Ash(listing_Standard);
                    break;

                case 2:
                    listing_Standard = SettingsPage_Blight(listing_Standard);
                    break;
                case 3:
                    listing_Standard = SettingsPage_Fire(listing_Standard);
                    break;

                case 4:
                    listing_Standard = SettingsPage_Biome(listing_Standard);
                    break;

                case 5:
                    listing_Standard = SettingsPage_Kwama(listing_Standard);
                    break;

                case 6:
                    listing_Standard = SettingsPage_Incident(listing_Standard);
                    break;

                case 7:
                    listing_Standard = SettingsPage_AnimalBehaviour(listing_Standard);
                    break;

                case 8:
                    listing_Standard = SettingsPage_Notification(listing_Standard);
                    break;

                case 9:
                    listing_Standard = SettingsPage_ModIntegration(listing_Standard);
                    break;

                default:
                    listing_Standard = SettingsPage_Default(listing_Standard);
                    break;
            }

            listing_Standard.End();
            Widgets.EndScrollView();
            base.DoSettingsWindowContents(inRect);

            //buttons pane
            outerRect.x += firstColumnWidth + Listing.ColumnSpacing;
            outerRect.width = secondColumnWidth;

            listing_Standard = new Listing_Standard();
            listing_Standard.Begin(outerRect);
            SettingsButtons(listing_Standard);
            listing_Standard.End();
        }

        private Listing_Standard SettingsButtons(Listing_Standard listing_Standard)
        {
            listing_Standard.Gap();

            Rect rectPageDefault = listing_Standard.GetRect(30f);
            TooltipHandler.TipRegion(rectPageDefault, "MorrowRim_PageDefault".Translate());
            if (Widgets.ButtonText(rectPageDefault, "MorrowRim_PageDefault".Translate(), true, true, true))
            {
                page = 0;
            }
            listing_Standard.Gap();

            Rect rectPageAsh = listing_Standard.GetRect(30f);
            TooltipHandler.TipRegion(rectPageAsh, "MorrowRim_PageAsh".Translate());
            if (Widgets.ButtonText(rectPageAsh, "MorrowRim_PageAsh".Translate(), true, true, true))
            {
                page = 1;
            }
            listing_Standard.Gap();

            Rect rectPageBlight = listing_Standard.GetRect(30f);
            TooltipHandler.TipRegion(rectPageBlight, "MorrowRim_PageBlight".Translate());
            if (Widgets.ButtonText(rectPageBlight, "MorrowRim_PageBlight".Translate(), true, true, true))
            {
                page = 2;
            }
            listing_Standard.Gap();

            if (ModSettings_Utility.CheckVolcanicAshlands())
            {
                Rect rectPageFire = listing_Standard.GetRect(30f);
                TooltipHandler.TipRegion(rectPageFire, "MorrowRim_PageFire".Translate());
                if (Widgets.ButtonText(rectPageFire, "MorrowRim_PageFire".Translate(), true, true, true))
                {
                    page = 3;
                }
                listing_Standard.Gap();
            }

            Rect rectPageBiome = listing_Standard.GetRect(30f);
            TooltipHandler.TipRegion(rectPageBiome, "MorrowRim_PageBiome".Translate());
            if (Widgets.ButtonText(rectPageBiome, "MorrowRim_PageBiome".Translate(), true, true, true))
            {
                page = 4;
            }
            listing_Standard.Gap();

            Rect rectPageKwama = listing_Standard.GetRect(30f);
            TooltipHandler.TipRegion(rectPageKwama, "MorrowRim_PageKwama".Translate());
            if (Widgets.ButtonText(rectPageKwama, "MorrowRim_PageKwama".Translate(), true, true, true))
            {
                page = 5;
            }
            listing_Standard.Gap();

            Rect rectPageIncident = listing_Standard.GetRect(30f);
            TooltipHandler.TipRegion(rectPageIncident, "MorrowRim_PageIncident".Translate());
            if (Widgets.ButtonText(rectPageIncident, "MorrowRim_PageIncident".Translate(), true, true, true))
            {
                page = 6;
            }
            listing_Standard.Gap();

            Rect rectPageAnimalBehaviour = listing_Standard.GetRect(30f);
            TooltipHandler.TipRegion(rectPageAnimalBehaviour, "MorrowRim_PageAnimalBehaviour".Translate());
            if (Widgets.ButtonText(rectPageAnimalBehaviour, "MorrowRim_PageAnimalBehaviour".Translate(), true, true, true))
            {
                page = 7;
            }
            listing_Standard.Gap();

            Rect rectPageNotification = listing_Standard.GetRect(30f);
            TooltipHandler.TipRegion(rectPageNotification, "MorrowRim_PageNotification".Translate());
            if (Widgets.ButtonText(rectPageNotification, "MorrowRim_PageNotification".Translate(), true, true, true))
            {
                page = 8;
            }
            listing_Standard.Gap();

            Rect rectPageModIntegration = listing_Standard.GetRect(30f);
            TooltipHandler.TipRegion(rectPageModIntegration, "MorrowRim_PageModIntegration".Translate());
            if (Widgets.ButtonText(rectPageModIntegration, "MorrowRim_PageModIntegration".Translate(), true, true, true))
            {
                page = 9;
            }
            listing_Standard.Gap();

            listing_Standard.GapLine();
            listing_Standard.Gap();

            //reset
            Rect rectDefault = listing_Standard.GetRect(30f);
            TooltipHandler.TipRegion(rectDefault, "MorrowRim_ResetDefault".Translate());
            if (Widgets.ButtonText(rectDefault, "MorrowRim_ResetDefault".Translate(), true, true, true))
            {
                MorrowRim_ModSettings.ResetSettings();
            }
            listing_Standard.Gap();
            ResetButtonForPage(listing_Standard);

            return listing_Standard;
        }

        private void ResetButtonForPage(Listing_Standard listing_Standard)
        {
            Rect rectDefault = listing_Standard.GetRect(30f);
            switch (page)
            {
                case 1:
                    listing_Standard.Gap();
                    TooltipHandler.TipRegion(rectDefault, "MorrowRim_ResetAsh".Translate());
                    if (Widgets.ButtonText(rectDefault, "MorrowRim_ResetAsh".Translate(), true, true, true))
                    {
                        MorrowRim_ModSettings.ResetSettings_Ash();
                    }
                    break;

                case 2:
                    listing_Standard.Gap();
                    TooltipHandler.TipRegion(rectDefault, "MorrowRim_ResetBlight".Translate());
                    if (Widgets.ButtonText(rectDefault, "MorrowRim_ResetBlight".Translate(), true, true, true))
                    {
                        MorrowRim_ModSettings.ResetSettings_Blight();
                    }
                    break;
                case 3:
                    listing_Standard.Gap();
                    TooltipHandler.TipRegion(rectDefault, "MorrowRim_ResetFire".Translate());
                    if (Widgets.ButtonText(rectDefault, "MorrowRim_ResetFire".Translate(), true, true, true))
                    {
                        MorrowRim_ModSettings.ResetSettings_Fire();
                    }
                    break;

                case 4:
                    listing_Standard.Gap();
                    TooltipHandler.TipRegion(rectDefault, "MorrowRim_ResetBiomeh".Translate());
                    if (Widgets.ButtonText(rectDefault, "MorrowRim_ResetBiome".Translate(), true, true, true))
                    {
                        MorrowRim_ModSettings.ResetSettings_Biome();
                    }
                    break;

                case 5:
                    listing_Standard.Gap();
                    TooltipHandler.TipRegion(rectDefault, "MorrowRim_ResetKwama".Translate());
                    if (Widgets.ButtonText(rectDefault, "MorrowRim_ResetKwama".Translate(), true, true, true))
                    {
                        MorrowRim_ModSettings.ResetSettings_Kwama();
                    }
                    break;

                case 6:
                    listing_Standard.Gap();
                    TooltipHandler.TipRegion(rectDefault, "MorrowRim_ResetIncident".Translate());
                    if (Widgets.ButtonText(rectDefault, "MorrowRim_ResetIncident".Translate(), true, true, true))
                    {
                        MorrowRim_ModSettings.ResetSettings_Incident();
                    }
                    break;

                case 7:
                    listing_Standard.Gap();
                    TooltipHandler.TipRegion(rectDefault, "MorrowRim_ResetAnimalBehaviour".Translate());
                    if (Widgets.ButtonText(rectDefault, "MorrowRim_ResetAnimalBehaviour".Translate(), true, true, true))
                    {
                        MorrowRim_ModSettings.ResetSettings_AnimalBehaviour();
                    }
                    break;

                case 8:
                    listing_Standard.Gap();
                    TooltipHandler.TipRegion(rectDefault, "MorrowRim_ResetNotification".Translate());
                    if (Widgets.ButtonText(rectDefault, "MorrowRim_ResetNotification".Translate(), true, true, true))
                    {
                        MorrowRim_ModSettings.ResetSettings_Notification();
                    }
                    break;

                case 9:
                    listing_Standard.Gap();
                    TooltipHandler.TipRegion(rectDefault, "MorrowRim_ResetModIntegration".Translate());
                    if (Widgets.ButtonText(rectDefault, "MorrowRim_ResetModIntegration".Translate(), true, true, true))
                    {
                        MorrowRim_ModSettings.ResetSettings_ModIntegration();
                    }
                    break;

                default:
                    break;
            }
        }

        //Specific pages

        private Listing_Standard SettingsPage_Default(Listing_Standard listing_Standard)
        {
            listing_Standard.Label("MorrowRim_PageDefault".Translate());
            listing_Standard.GapLine();
            listing_Standard.Gap();

            /* Presets */
            listing_Standard.Label("MorrowRim_PagePresets".Translate());
            listing_Standard.GapLine();
            listing_Standard.Gap();
            //buttons

            Rect rectPresetPeaceful = listing_Standard.GetRect(30f);
            TooltipHandler.TipRegion(rectPresetPeaceful, "MorrowRim_SettingPreset_PeacefulDesc".Translate());
            if (Widgets.ButtonText(rectPresetPeaceful, "MorrowRim_SettingPreset_Peaceful".Translate(), true, true, true))
            {
                ModSettings_Presets.PresetSettings_Peaceful(settings);
            }
            listing_Standard.Gap();

            Rect rectPresetAdapted = listing_Standard.GetRect(30f);
            TooltipHandler.TipRegion(rectPresetAdapted, "MorrowRim_SettingPreset_AdpatedAshlandsDesc".Translate());
            if (Widgets.ButtonText(rectPresetAdapted, "MorrowRim_SettingPreset_AdpatedAshlands".Translate(), true, true, true))
            {
                ModSettings_Presets.PresetSettings_AdaptedAshlands(settings);
            }
            listing_Standard.Gap();

            Rect rectPresetHellscape = listing_Standard.GetRect(30f);
            TooltipHandler.TipRegion(rectPresetHellscape, "MorrowRim_SettingPreset_VolcanicHellscapeDesc".Translate());
            if (Widgets.ButtonText(rectPresetHellscape, "MorrowRim_SettingPreset_VolcanicHellscape".Translate(), true, true, true))
            {
                ModSettings_Presets.PresetSettings_VolcanicHellscape(settings);
            }
            listing_Standard.Gap();

            Rect rectPresetDagothDead = listing_Standard.GetRect(30f);
            TooltipHandler.TipRegion(rectPresetDagothDead, "MorrowRim_SettingPreset_DagothDead_Tooltip".Translate());
            if (Widgets.ButtonText(rectPresetDagothDead, "MorrowRim_SettingPreset_DagothDead".Translate(), true, true, true))
            {
                ModSettings_Presets.PresetSettings_DagothDead(settings);
            }
            listing_Standard.Gap();

            if (ModSettings_Utility.CheckZombieland())
            {
                Rect rectPresetZombieland = listing_Standard.GetRect(30f);
                TooltipHandler.TipRegion(rectPresetZombieland, "MorrowRim_SettingPreset_Zombieland_Tooltip".Translate());
                if (Widgets.ButtonText(rectPresetZombieland, "MorrowRim_SettingPreset_Zombieland".Translate(), true, true, true))
                {
                    ModSettings_Presets.PresetSettings_Zombieland(settings);
                }
                listing_Standard.Gap();
            }

            listing_Standard.GapLine();

            listing_Standard.Gap();

            Rect rectDefault = listing_Standard.GetRect(30f);
            TooltipHandler.TipRegion(rectDefault, "MorrowRim_ResetPreset".Translate());
            if (Widgets.ButtonText(rectDefault, "MorrowRim_ResetPreset".Translate(), true, true, true))
            {
                ModSettings_Presets.PresetResetSettings(settings);
            }

            return listing_Standard;
        }

        private Listing_Standard SettingsPage_Ash(Listing_Standard listing_Standard)
        {
            listing_Standard.Label("MorrowRim_PageAsh".Translate());
            listing_Standard.GapLine();
            listing_Standard.Gap();

            //settings
            listing_Standard.CheckboxLabeled("MorrowRim_SettingEnableLightingEffects".Translate(), ref settings.MorrowRim_SettingEnableLightingEffects);
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("MorrowRim_SettingEnableAshEffects".Translate(), ref settings.MorrowRim_SettingEnableAshEffects, "MorrowRim_SettingEnableAshEffects_Tooltip".Translate());
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("MorrowRim_SettingAshIgnoreResistance".Translate(), ref settings.MorrowRim_SettingAshIgnoreResistance);
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("MorrowRim_SettingAshOnlySownPlants".Translate(), ref settings.MorrowRim_SettingAshOnlySownPlants);
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("MorrowRim_SettingAshPreventVisitors".Translate(), ref settings.MorrowRim_SettingAshPreventVisitors);
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("MorrowRim_SettingAshRegrowth".Translate(), ref settings.MorrowRim_SettingAshRegrowth, "MorrowRim_SettingAshRegrowth_Tooltip".Translate());
            listing_Standard.Gap();

            listing_Standard.GapLine();

            listing_Standard.Label("MorrowRim_SettingAshFilledEye".Translate() + " (" + settings.MorrowRim_SettingAshFilledEye + "%)");
            settings.MorrowRim_SettingAshFilledEye = (int)Math.Round(listing_Standard.Slider(settings.MorrowRim_SettingAshFilledEye, 0, 100) / 5.0) * 5;
            listing_Standard.Gap();

            listing_Standard.Label("MorrowRim_SettingAshCloggedServo".Translate() + " (" + settings.MorrowRim_SettingAshCloggedServo + "%)");
            settings.MorrowRim_SettingAshCloggedServo = (int)Math.Round(listing_Standard.Slider(settings.MorrowRim_SettingAshCloggedServo, 0, 100) / 5.0) * 5;
            listing_Standard.Gap();

            listing_Standard.Label("MorrowRim_SettingAshBuildupMultiplier".Translate() + " (" + settings.MorrowRim_SettingAshBuildupMultiplier + "x)");
            settings.MorrowRim_SettingAshBuildupMultiplier = (float)Math.Round(listing_Standard.Slider(settings.MorrowRim_SettingAshBuildupMultiplier, 0.1f, 100) * 10) / 10;
            listing_Standard.Gap();

            listing_Standard.Label("MorrowRim_SettingAshPlantDamage".Translate() + " (" + settings.MorrowRim_SettingAshPlantDamage + " damage)");
            settings.MorrowRim_SettingAshPlantDamage = (int)(listing_Standard.Slider(settings.MorrowRim_SettingAshPlantDamage, 0, 200));
            listing_Standard.Gap();

            listing_Standard.Label("MorrowRim_SettingAshPlantChance".Translate() + " (" + settings.MorrowRim_SettingAshPlantChance + "%)");
            settings.MorrowRim_SettingAshPlantChance = (int)Math.Round(listing_Standard.Slider(settings.MorrowRim_SettingAshPlantChance, 0, 100) / 5.0) * 5;
            listing_Standard.Gap();

            listing_Standard.Label("MorrowRim_SettingAshTurbineDamage".Translate() + " (" + (settings.MorrowRim_SettingAshTurbineDamage * 7 / 2) + " damage)");
            settings.MorrowRim_SettingAshTurbineDamage = (int)(listing_Standard.Slider(settings.MorrowRim_SettingAshTurbineDamage, 0, 25));
            listing_Standard.Gap();

            return listing_Standard;
        }

        private Listing_Standard SettingsPage_Blight(Listing_Standard listing_Standard)
        {
            listing_Standard.Label("MorrowRim_PageBlight".Translate());
            listing_Standard.GapLine();
            listing_Standard.Gap();

            //settings
            listing_Standard.CheckboxLabeled("MorrowRim_SettingEnableBlightEffects".Translate(), ref settings.MorrowRim_SettingEnableBlightEffects);
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("MorrowRim_SettingBlightAnimalIgnoreScaling".Translate(), ref settings.MorrowRim_SettingBlightAnimalIgnoreScaling);
            listing_Standard.Gap();

            listing_Standard.Label("MorrowRim_SettingBlightAnimalMultiplier".Translate() + " (" + settings.MorrowRim_SettingBlightAnimalMultiplier + "x)");
            settings.MorrowRim_SettingBlightAnimalMultiplier = (float)Math.Round(listing_Standard.Slider(settings.MorrowRim_SettingBlightAnimalMultiplier, 0.1f, 100) * 10) / 10;
            listing_Standard.Gap();

            listing_Standard.Label("MorrowRim_SettingBlightAnimalChance".Translate() + " (" + settings.MorrowRim_SettingBlightAnimalChance + "%)");
            settings.MorrowRim_SettingBlightAnimalChance = (int)Math.Round(listing_Standard.Slider(settings.MorrowRim_SettingBlightAnimalChance, 0, 100) / 5.0) * 5;
            listing_Standard.Gap();

            listing_Standard.Label("MorrowRim_SettingBlightAnimalNumber".Translate() + " (" + settings.MorrowRim_SettingBlightAnimalNumber + ")");
            settings.MorrowRim_SettingBlightAnimalNumber = (int)(listing_Standard.Slider(settings.MorrowRim_SettingBlightAnimalNumber, 1, 100));
            listing_Standard.Gap();

            listing_Standard.Label("MorrowRim_SettingBlightPlantChance".Translate() + " (" + settings.MorrowRim_SettingBlightPlantChance + "%)");
            settings.MorrowRim_SettingBlightPlantChance = (int)Math.Round(listing_Standard.Slider(settings.MorrowRim_SettingBlightPlantChance, 0, 100) / 5.0) * 5;
            listing_Standard.Gap();

            listing_Standard.Label("MorrowRim_SettingBlightPlantNumber".Translate() + " (" + settings.MorrowRim_SettingBlightPlantNumber + ")");
            settings.MorrowRim_SettingBlightPlantNumber = (int)(listing_Standard.Slider(settings.MorrowRim_SettingBlightPlantNumber, 1, 100));
            listing_Standard.Gap();

            return listing_Standard;
        }

        private Listing_Standard SettingsPage_Fire(Listing_Standard listing_Standard)
        {
            listing_Standard.Label("MorrowRim_PageFire".Translate());
            listing_Standard.GapLine();
            listing_Standard.Gap();

            //settings
            listing_Standard.CheckboxLabeled("MorrowRim_SettingEnableFireEffects".Translate(), ref settings.MorrowRim_SettingEnableFireEffects);
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("MorrowRim_SettingFireOnlySownPlants".Translate(), ref settings.MorrowRim_SettingFireOnlySownPlants);
            listing_Standard.Gap();

            listing_Standard.Label("MorrowRim_SettingFireBurnChance".Translate() + " (" + settings.MorrowRim_SettingFireBurnChance + "%)");
            settings.MorrowRim_SettingFireBurnChance = (int)Math.Round(listing_Standard.Slider(settings.MorrowRim_SettingFireBurnChance, 0, 100) / 5.0) * 5;
            listing_Standard.Gap();

            listing_Standard.Label("MorrowRim_SettingFireFirePawnChance".Translate() + " (" + settings.MorrowRim_SettingFireFirePawnChance + "%)");
            settings.MorrowRim_SettingFireFirePawnChance = (int)Math.Round(listing_Standard.Slider(settings.MorrowRim_SettingFireFirePawnChance, 0, 100) / 5.0) * 5;
            listing_Standard.Gap();

            listing_Standard.Label("MorrowRim_SettingFireFirePlantChance".Translate() + " (" + settings.MorrowRim_SettingFireFirePlantChance + "%)");
            settings.MorrowRim_SettingFireFirePlantChance = (int)Math.Round(listing_Standard.Slider(settings.MorrowRim_SettingFireFirePlantChance, 0, 100) / 5.0) * 5;
            listing_Standard.Gap();

            return listing_Standard;
        }

        private Listing_Standard SettingsPage_Biome(Listing_Standard listing_Standard)
        {
            listing_Standard.Label("MorrowRim_PageBiome".Translate());
            listing_Standard.GapLine();
            listing_Standard.Gap();

            //settings
            listing_Standard.CheckboxLabeled("MorrowRim_SettingBiomeEnableAshlands".Translate(), ref settings.MorrowRim_SettingBiomeEnableAshlands);
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("MorrowRim_SettingBiomeEnableBlightedAshlands".Translate(), ref settings.MorrowRim_SettingBiomeEnableBlightedAshlands);
            listing_Standard.Gap();

            if (ModSettings_Utility.CheckAshlandsSwamp())
            {
                listing_Standard.CheckboxLabeled("MorrowRim_SettingBiomeEnableAshlandsSwamp".Translate(), ref settings.MorrowRim_SettingBiomeEnableAshlandsSwamp);
                listing_Standard.Gap();
            }

            if (ModSettings_Utility.CheckAshlandsSwamp())
            {
                listing_Standard.CheckboxLabeled("MorrowRim_SettingBiomeEnableAshlandsSwamp".Translate(), ref settings.MorrowRim_SettingBiomeEnableAshlandsSwamp);
                listing_Standard.Gap();
            }

            if (ModSettings_Utility.CheckGrazelands())
            {
                listing_Standard.CheckboxLabeled("MorrowRim_SettingBiomeEnableGrazelands".Translate(), ref settings.MorrowRim_SettingBiomeEnableGrazelands);
                listing_Standard.Gap();
            }

            if (ModSettings_Utility.CheckVolcanicAshlands())
            {
                listing_Standard.CheckboxLabeled("MorrowRim_SettingBiomeEnableVolcanicAshlands".Translate(), ref settings.MorrowRim_SettingBiomeEnableVolcanicAshlands);
                listing_Standard.Gap();
            }

            listing_Standard.Label("MorrowRim_SettingBiomeMultiplier".Translate() + " (" + settings.MorrowRim_SettingBiomeMultiplier + "x)");
            settings.MorrowRim_SettingBiomeMultiplier = (int)Math.Round(listing_Standard.Slider(settings.MorrowRim_SettingBiomeMultiplier, 0f, 5f) / 0.1) * 0.1f;

            listing_Standard.CheckboxLabeled("MorrowRim_SettingBiomePolarShift".Translate(), ref settings.MorrowRim_SettingBiomePolarShift, "MorrowRim_SettingBiomePolarShift_Tooltip".Translate());
            listing_Standard.Gap();

            listing_Standard.GapLine();

            if (ModSettings_Utility.CheckAshlandsSwamp())
            {
                listing_Standard.CheckboxLabeled("MorrowRim_SettingBiomeDisableSwampBeaches".Translate(), ref settings.MorrowRim_SettingBiomeDisableSwampBeaches);
                listing_Standard.Gap();
            }

            if (ModSettings_Utility.CheckVolcanicAshlands())
            {
                listing_Standard.CheckboxLabeled("MorrowRim_SettingBiomeSwitchToDumbLava".Translate(), ref settings.MorrowRim_SettingBiomeSwitchToDumbLava, "MorrowRim_SettingBiomeSwitchToDumbLava_Tooltip".Translate());
                listing_Standard.Gap();
            }

            listing_Standard.GapLine();

            if (ModSettings_Utility.CheckBiomesPatch())
            {
                listing_Standard.CheckboxLabeled("MorrowRim_SettingBiomeEnablePlantsOutside".Translate(), ref settings.MorrowRim_SettingBiomeEnablePlantsOutside);
                listing_Standard.Gap();
            }

            return listing_Standard;
        }

        private Listing_Standard SettingsPage_Incident(Listing_Standard listing_Standard)
        {
            listing_Standard.Label("MorrowRim_PageIncident".Translate());
            listing_Standard.GapLine();
            listing_Standard.Gap();

            //settings
            listing_Standard.CheckboxLabeled("MorrowRim_SettingEnableAlbinoGuarEvent".Translate(), ref settings.MorrowRim_SettingEnableAlbinoGuarEvent);
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("MorrowRim_SettingEnableCliffRacerEvents".Translate(), ref settings.MorrowRim_SettingEnableCliffRacerEvents);
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("MorrowRim_SettingEnableKwamaNestEmerging".Translate(), ref settings.MorrowRim_SettingEnableKwamaNestEmerging);
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("MorrowRim_SettingEnableSiltStriderEvent".Translate(), ref settings.MorrowRim_SettingEnableSiltStriderEvent);
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("MorrowRim_SettingEnableKwamaTrojanInfestation".Translate(), ref settings.MorrowRim_SettingEnableKwamaTrojanInfestation);
            listing_Standard.Gap();

            listing_Standard.GapLine();
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("MorrowRim_SettingEnableCorprusRefugee".Translate(), ref settings.MorrowRim_SettingEnableCorprusRefugee);
            listing_Standard.Gap();

            listing_Standard.Label("MorrowRim_SettingEnableCorprusRefugeeChance".Translate() + " (" + settings.MorrowRim_SettingEnableCorprusRefugeeChance * 100 + "%)");
            settings.MorrowRim_SettingEnableCorprusRefugeeChance = (float)Math.Round(listing_Standard.Slider(settings.MorrowRim_SettingEnableCorprusRefugeeChance, 0.05f, 1f) * 20) / 20;

            listing_Standard.Label("MorrowRim_SettingEnableCorprusRefugeeSeverity".Translate() + " (" + settings.MorrowRim_SettingEnableCorprusRefugeeSeverity * 100 + "%)");
            settings.MorrowRim_SettingEnableCorprusRefugeeSeverity = (float)Math.Round(listing_Standard.Slider(settings.MorrowRim_SettingEnableCorprusRefugeeSeverity, 0.05f, 0.95f) * 20) / 20;

            listing_Standard.GapLine();
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("MorrowRim_SettingEnableTrueCliffRacerExtinction".Translate(), ref settings.MorrowRim_SettingEnableTrueCliffRacerExtinction, "MorrowRim_SettingEnableTrueCliffRacerExtinction_Tooltip".Translate());
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("MorrowRim_SettingEnableTrueCliffRacerExtinctionAlert".Translate(), ref settings.MorrowRim_SettingEnableTrueCliffRacerExtinctionAlert, "MorrowRim_SettingEnableTrueCliffRacerExtinctionAlert".Translate());
            listing_Standard.Gap();

            listing_Standard.Label("MorrowRim_SettingEnableTrueCliffRacerExtinctionCount".Translate() + " (" + settings.MorrowRim_SettingEnableTrueCliffRacerExtinctionCount + ")");
            settings.MorrowRim_SettingEnableTrueCliffRacerExtinctionCount = (int)Math.Round(listing_Standard.Slider(settings.MorrowRim_SettingEnableTrueCliffRacerExtinctionCount, 1000, 100000) / 1000) * 1000;
            listing_Standard.Gap();

            listing_Standard.GapLine();
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("MorrowRim_SettingEnableCliffRacerExtinction".Translate(), ref settings.MorrowRim_SettingEnableCliffRacerExtinction, "MorrowRim_SettingEnableCliffRacerExtinction_Tooltip".Translate());
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("MorrowRim_SettingEnableSiltStriderExtinction".Translate(), ref settings.MorrowRim_SettingEnableSiltStriderExtinction, "MorrowRim_SettingEnableSiltStriderExtinction_Tooltip".Translate());
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("MorrowRim_SettingEnableCorprusExtinction".Translate(), ref settings.MorrowRim_SettingEnableCorprusExtinction, "MorrowRim_SettingEnableCorprusExtinction_Tooltip".Translate());
            listing_Standard.Gap();

            listing_Standard.GapLine();
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("MorrowRim_SettingEnablePermaAshStorm".Translate(), ref settings.MorrowRim_SettingEnablePermaAshStorm, "MorrowRim_SettingEnablePermaAshStorm_Tooltip".Translate());
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("MorrowRim_SettingEnablePermaAshStormOnlyAshlands".Translate(), ref settings.MorrowRim_SettingEnablePermaAshStormOnlyAshlands, "MorrowRim_SettingEnablePermaAshStormOnlyAshlands_Tooltip".Translate());
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("MorrowRim_SettingEnablePermaAshStormOnlyAshStorms".Translate(), ref settings.MorrowRim_SettingEnablePermaAshStormOnlyAshStorms);
            listing_Standard.Gap();

            return listing_Standard;
        }

        private Listing_Standard SettingsPage_Kwama(Listing_Standard listing_Standard)
        {
            listing_Standard.Label("MorrowRim_PageKwama".Translate());
            listing_Standard.GapLine();
            listing_Standard.Gap();

            //settings
            listing_Standard.CheckboxLabeled("MorrowRim_SettingKwamaEnableGen".Translate(), ref settings.MorrowRim_SettingKwamaEnableGen);
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("MorrowRim_SettingKwamaNestReproducing".Translate(), ref settings.MorrowRim_SettingKwamaNestReproducing);
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("MorrowRim_SettingKwamaMining".Translate(), ref settings.MorrowRim_SettingKwamaMining);
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("MorrowRim_SettingEnablePredatorAvoidKwama".Translate(), ref settings.MorrowRim_SettingEnablePredatorAvoidKwama);
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("MorrowRim_SettingForceKwamaNatural".Translate(), ref settings.MorrowRim_SettingForceKwamaNatural);
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("MorrowRim_SettingKwamaEnableTrojanHostile".Translate(), ref settings.MorrowRim_SettingKwamaEnableTrojanHostile);
            listing_Standard.Gap();

            listing_Standard.Label("MorrowRim_SettingKwamaMinDistance".Translate() + " (" + settings.MorrowRim_SettingKwamaMinDistance + " tiles)");
            settings.MorrowRim_SettingKwamaMinDistance = (int)(listing_Standard.Slider(settings.MorrowRim_SettingKwamaMinDistance, 0, 100));
            listing_Standard.Gap();

            listing_Standard.Label("MorrowRim_SettingKwamaMaxNests".Translate() + " (" + settings.MorrowRim_SettingKwamaMaxNests + " nests)");
            settings.MorrowRim_SettingKwamaMaxNests = (int)(listing_Standard.Slider(settings.MorrowRim_SettingKwamaMaxNests, 1, 20));
            listing_Standard.Gap();

            return listing_Standard;
        }

        private Listing_Standard SettingsPage_ModIntegration(Listing_Standard listing_Standard)
        {
            listing_Standard.Label("MorrowRim_PageModIntegration".Translate());
            listing_Standard.GapLine();
            listing_Standard.Label("MorrowRim_ModIntegrationText1".Translate());
            listing_Standard.Label("MorrowRim_ModIntegrationText2".Translate());
            listing_Standard.GapLine();
            listing_Standard.Gap();

            //settings
            if (ModSettings_Utility.CheckVFEInsects())
            {
                listing_Standard.CheckboxLabeled("MorrowRim_SettingVFIChitinIntegration".Translate(), ref settings.MorrowRim_SettingVFIChitinIntegration, "MorrowRim_SettingVFIChitinIntegration_Tooltip".Translate());
                listing_Standard.Gap();
            }

            if (ModSettings_Utility.CheckZombieland())
            {
                listing_Standard.CheckboxLabeled("MorrowRim_SettingZombielandIntegration".Translate(), ref settings.MorrowRim_SettingZombielandIntegration);
                listing_Standard.Gap();
            }

            return listing_Standard;
        }

        private Listing_Standard SettingsPage_AnimalBehaviour(Listing_Standard listing_Standard)
        {
            listing_Standard.Label("MorrowRim_PageAnimalBehaviour".Translate());
            listing_Standard.GapLine();
            listing_Standard.Gap();

            //settings
            listing_Standard.CheckboxLabeled("MorrowRim_SettingEnableAshStormHidingHumanlike".Translate(), ref settings.MorrowRim_SettingEnableAshStormHidingHumanlike, "MorrowRim_SettingEnableAshStormHidingHumanlike_Tooltip".Translate());
            listing_Standard.Gap();
            listing_Standard.CheckboxLabeled("MorrowRim_SettingEnableAshStormHiding".Translate(), ref settings.MorrowRim_SettingEnableAshStormHiding, "MorrowRim_SettingEnableAshStormHiding_Tooltip".Translate());
            listing_Standard.Gap();

            listing_Standard.Label("MorrowRim_SettingEnableAshStormHidingMin".Translate() + " (" + settings.MorrowRim_SettingEnableAshStormHidingMin * 100 + "%)");
            settings.MorrowRim_SettingEnableAshStormHidingMin = (float)Math.Round(listing_Standard.Slider(settings.MorrowRim_SettingEnableAshStormHidingMin, 0f, 1f) * 20) / 20;

            listing_Standard.GapLine();
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("MorrowRim_SettingEnableAshCastles".Translate(), ref settings.MorrowRim_SettingEnableAshCastles);
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("MorrowRim_SettingEnableAshCastlesDuringAshStorm".Translate(), ref settings.MorrowRim_SettingEnableAshCastlesDuringAshStorm);
            listing_Standard.Gap();

            listing_Standard.Label("MorrowRim_SettingEnableAshCastlesMinDistance".Translate() + " (" + settings.MorrowRim_SettingEnableAshCastlesMinDistance + " tiles)");
            settings.MorrowRim_SettingEnableAshCastlesMinDistance = (float)Math.Round(listing_Standard.Slider(settings.MorrowRim_SettingEnableAshCastlesMinDistance, 1f, 50f) * 10) / 10;

            listing_Standard.GapLine();
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("MorrowRim_SettingEnableScampInsults".Translate(), ref settings.MorrowRim_SettingEnableScampInsults);
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("MorrowRim_SettingEnableScribBehaviour".Translate(), ref settings.MorrowRim_SettingEnableScribBehaviour);
            listing_Standard.Gap();

            listing_Standard.GapLine();
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("MorrowRim_SettingEnableInsectPollutionStimulus".Translate(), ref settings.MorrowRim_SettingEnableInsectPollutionStimulus);
            listing_Standard.Gap();

            listing_Standard.GapLine();
            listing_Standard.Gap();

            return listing_Standard;
        }

        private Listing_Standard SettingsPage_Notification(Listing_Standard listing_Standard)
        {
            listing_Standard.Label("MorrowRim_PageNotification".Translate());
            listing_Standard.GapLine();
            listing_Standard.Gap();

            //settings
            listing_Standard.CheckboxLabeled("MorrowRim_SettingEnableAshBuildupNotifications".Translate(), ref settings.MorrowRim_SettingEnableAshStormHiding);
            listing_Standard.Gap();

            //colonist
            listing_Standard.CheckboxLabeled("MorrowRim_SettingEnableAshBuildupNotifications_Colonist".Translate(), ref settings.MorrowRim_SettingEnableAshBuildupNotifications_Colonist);
            listing_Standard.Gap();

            listing_Standard.Label("MorrowRim_SettingEnableAshBuildupNotifications_ColonistThreshold".Translate() + " (" + settings.MorrowRim_SettingEnableAshBuildupNotifications_ColonistThreshold * 100 + "%)");
            settings.MorrowRim_SettingEnableAshBuildupNotifications_ColonistThreshold = (float)Math.Round(listing_Standard.Slider(settings.MorrowRim_SettingEnableAshBuildupNotifications_ColonistThreshold, 0.05f, 1f) * 20) / 20;

            //animal
            listing_Standard.CheckboxLabeled("MorrowRim_SettingEnableAshBuildupNotifications_Animals".Translate(), ref settings.MorrowRim_SettingEnableAshBuildupNotifications_Animals);
            listing_Standard.Gap();

            listing_Standard.Label("MorrowRim_SettingEnableAshBuildupNotifications_AnimalsThreshold".Translate() + " (" + settings.MorrowRim_SettingEnableAshBuildupNotifications_AnimalsThreshold * 100 + "%)");
            settings.MorrowRim_SettingEnableAshBuildupNotifications_AnimalsThreshold = (float)Math.Round(listing_Standard.Slider(settings.MorrowRim_SettingEnableAshBuildupNotifications_AnimalsThreshold, 0.05f, 1f) * 20) / 20;

            //animal
            listing_Standard.CheckboxLabeled("MorrowRim_SettingEnableAshBuildupNotifications_Friendly".Translate(), ref settings.MorrowRim_SettingEnableAshBuildupNotifications_Friendly);
            listing_Standard.Gap();

            listing_Standard.Label("MorrowRim_SettingEnableAshBuildupNotifications_FriendlyThreshold".Translate() + " (" + settings.MorrowRim_SettingEnableAshBuildupNotifications_FriendlyThreshold * 100 + "%)");
            settings.MorrowRim_SettingEnableAshBuildupNotifications_FriendlyThreshold = (float)Math.Round(listing_Standard.Slider(settings.MorrowRim_SettingEnableAshBuildupNotifications_FriendlyThreshold, 0.05f, 1f) * 20) / 20;


            listing_Standard.GapLine();

            return listing_Standard;
        }
    
    }
}
