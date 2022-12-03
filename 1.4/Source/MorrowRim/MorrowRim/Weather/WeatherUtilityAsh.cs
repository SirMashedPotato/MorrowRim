using System;
using System.Collections.Generic;
using UnityEngine;
using Verse;
using RimWorld;
using System.Reflection.Emit;
using System.Linq;

namespace MorrowRim
{
    class WeatherUtilityAsh
    {
        /* main calls */


        public static void DoAshDamageToPawn(Pawn p)
        {
            //Is mechanical, try inflict clogged servos, then return
            if (WeatherUtilityAsh.CheckAshCloggedServos(p) && !WeatherUtilityAsh.IsInResistantTent_Servo(p))
            {
                WeatherUtilityAsh.TriggerAshCloggedServos(p);
                return;
            }

            //try inflict filled eyes
            if (WeatherUtilityAsh.CheckAshFilledEyes(p) && !WeatherUtilityAsh.IsInResistantTent_Eye(p))
            {
                BodyPartRecord part = WeatherUtilityAsh.GetAshFilledEyes(p);
                if (part != null)
                {
                    WeatherUtilityAsh.TriggerAshFilledEyes(p, part);
                }
            }

            //check apparel
            if (p.RaceProps.Humanlike && WeatherUtilityAsh.CheckApparel(p))
            {
                return;
            }

            //check if buildup is blocked
            if (!WeatherUtilityAsh.CanBreathe(p) || WeatherUtilityAsh.HasImmunityHediff(p))
            {
                return;
            }

            if (p.RaceProps.Humanlike)
            {
                //check for blocking trait
                if (WeatherUtilityAsh.HasImmunityTrait(p))
                {
                    return;
                }

                if (ModsConfig.BiotechActive && WeatherUtilityAsh.HasImmunityGene(p))
                {
                    return;
                }
            }

            

            //check for blocking gene
            

            //extra check for Zombieland, done in code to make it toggleable
            if (WeatherUtilityAsh.ZombielandCheck(p))
            {
                return;
            }

            //tent check for ashlander yurt
            if (WeatherUtilityAsh.IsInResistantTent_Hediff(p))
            {
                return;
            }

            //actual ash buildup
            if (MorrowRim_ModSettings.SettingAshIgnoreResistance || (!WeatherUtilityAsh.IsImmuneToAsh(p) && !WeatherUtilityAsh.ExtendedImmuneToAshCheck(p)))
            {
                WeatherUtilityAsh.IncreaseAshBuildup(p);
            }
        }

        /* ========== generic checks ========== */

        public static bool WeatherIsAshStorm(Map map)
        {
            return map.weatherManager.curWeather.GetModExtension<WeatherProperties>() != null
                && map.weatherManager.curWeather.GetModExtension<WeatherProperties>().isAshStorm;
        }

        public static bool IsValidTarget(Thing t)
        {
            return t.Spawned && !t.Position.Roofed(t.Map) && !t.Position.Fogged(t.Map);
        }

        public static bool IsValidCell(IntVec3 x, Map m)
        {
            return !x.Roofed(m) && !x.Fogged(m);
        }

        public static bool IsImmuneToAsh(Thing t)
        {
            var extendedRaceProps = ExtendedRaceProperties.Get(t.def);
            return extendedRaceProps != null && extendedRaceProps.ashResistant == AshResistant.Resistant;
        }

        public static bool IsMechanicalToAsh(Thing t)
        {
            var extendedRaceProps = ExtendedRaceProperties.Get(t.def);
            return extendedRaceProps != null && extendedRaceProps.ashResistant == AshResistant.Mechanical;
        }

        /* ========== pawns ========== */

        public static bool ExtendedImmuneToAshCheck(Pawn p)
        {
            return p.RaceProps.FleshType == FleshTypeDefOf.Insectoid || p.RaceProps.FleshType.defName == "ROM_StrangeFlesh" ||
                !p.def.race.body.HasPartWithTag(BodyPartTagDefOf.BreathingPathway) || !p.def.race.body.HasPartWithTag(BodyPartTagDefOf.BreathingSource);
        }

        //check for zombieland zombies
        public static bool ZombielandCheck(Pawn p)
        {
            return ModSettings_Utility.CheckZombieland() && MorrowRim_ModSettings.SettingZombielandIntegration && p.def.defName == "Zombie";
        }

        /* servos */

        public static bool CheckAshCloggedServos(Pawn p)
        {
            return IsMechanicalToAsh(p) || p.RaceProps.FleshType == FleshTypeDefOf.Mechanoid
                /* mod specific checks */
                || p.RaceProps.FleshType.defName == "Android" || p.RaceProps.FleshType.defName == "ChJDroid" || p.def.defName == "ChjAndroid";
        }

        public static void TriggerAshCloggedServos(Pawn p)
        {
            if (Rand.Chance(ModSettings_Utility.SettingToFloat(MorrowRim_ModSettings.SettingAshCloggedServo)))
            {
                BodyPartRecord part = p.RaceProps.body.AllParts.RandomElement();
                p.health.AddHediff(HediffDefOf.MorrowRim_AshCloggedServo, part);
            }
            return;
        }

        /* apparel */

        //for mod conmpatability, should swap to patching in modExtension
        private static readonly string[] apparelList = new string[] {
            /*Rimatomics*/ 
            "Apparel_RadiationMask", "Apparel_MoppMaskDesert", "Apparel_MoppMaskWoodland", "Apparel_MoppMaskSnow"
        };

        //for checking if ash buildup is triggered, doesn't need to specifically check eyes
        public static bool CheckApparel(Pawn p)
        {
            return p.apparel.BodyPartGroupIsCovered(BodyPartGroupDefOf.FullHead) || p.apparel.WornApparel.Any(x => IsImmuneToAsh(x))
                || p.apparel.WornApparel.Any(x => apparelList.Contains(x.def.defName.ToString()));
        }

        /* eyes */

        //checks to see if target is likely to be valid
        public static bool CheckAshFilledEyes(Pawn p)
        {
            return (!p.def.race.Humanlike && p.RaceProps.body.GetPartsWithTag(BodyPartTagDefOf.SightSource) != null) 
                || (p.def.race.Humanlike && p.RaceProps.body.GetPartsWithTag(BodyPartTagDefOf.SightSource) != null 
                && !p.apparel.BodyPartGroupIsCovered(BodyPartGroupDefOf.Eyes) && !p.apparel.BodyPartGroupIsCovered(BodyPartGroupDefOf.UpperHead) && !p.apparel.BodyPartGroupIsCovered(BodyPartGroupDefOf.FullHead));
        }

        //ensures thing is actually an eye
        public static BodyPartRecord GetAshFilledEyes(Pawn p)
        {
            List<BodyPartRecord> parts =  p.RaceProps.body.GetPartsWithTag(BodyPartTagDefOf.SightSource).Where(x => x.Label.Contains("eye") || x.Label.Contains("Eye")).ToList();
            if (!parts.NullOrEmpty())
            {
                return parts.RandomElement();
            }
            return null;
        }

        public static void TriggerAshFilledEyes(Pawn p, BodyPartRecord part)
        {
            if (Rand.Chance(ModSettings_Utility.SettingToFloat(MorrowRim_ModSettings.SettingAshFilledEye)))
            {
                if (part != null && !p.health.hediffSet.PartIsMissing(part))
                {
                    p.health.AddHediff(HediffDefOf.MorrowRim_AshInEyes, part);
                }
            }
        }

        /* misc pawn */

        public static bool CanBreathe(Pawn p)
        {
            return p.RaceProps.body.GetPartsWithTag(BodyPartTagDefOf.BreathingSource) != null;
        }

        public static bool HasImplant(Pawn p)
        {
            return p.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.MorrowRim_BionicFilter) != null;
        }

        /* New version of HasImplant
         * checks for any hediff with the extendedRaceProps extension
         */

        public static bool HasImmunityHediff(Pawn p)
        {
            foreach(Hediff h in p.health.hediffSet.hediffs)
            {
                var extendedRaceProps = ExtendedRaceProperties.Get(h.def);
                if (extendedRaceProps != null && extendedRaceProps.ashResistant == AshResistant.Resistant)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool HasImmunityTrait(Pawn p)
        {
            foreach (Trait t in p.story.traits.allTraits)
            {
                var extendedRaceProps = ExtendedRaceProperties.Get(t.def);
                if (extendedRaceProps != null && extendedRaceProps.ashResistant == AshResistant.Resistant)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool HasImmunityGene(Pawn p)
        {
            return p.genes.HasGene(GeneDefOf.MorrowRim_AshResistance);
        }

        //Tent checks

        public static bool IsInResistantTent_Thought(Pawn p)
        {
            var currBed = p.CurrentBed();
            if (currBed == null) return false; ;
            var modExt = currBed.def.GetModExtension<YurtModExtension>();
            return modExt != null && modExt.negateAshThought;
        }
        public static bool IsInResistantTent_Servo(Pawn p)
        {
            var currBed = p.CurrentBed();
            if (currBed == null) return false; ;
            var modExt = currBed.def.GetModExtension<YurtModExtension>();
            return modExt != null && modExt.negateAshServo;
        }

        public static bool IsInResistantTent_Eye(Pawn p)
        {
            var currBed = p.CurrentBed();
            if (currBed == null) return false; ;
            var modExt = currBed.def.GetModExtension<YurtModExtension>();
            return modExt != null && modExt.negateAshEye;
        }

        public static bool IsInResistantTent_Hediff(Pawn p)
        {
            var currBed = p.CurrentBed();
            if (currBed == null) return false; ;
            var modExt = currBed.def.GetModExtension<YurtModExtension>();
            return modExt != null && modExt.negateAshBuildup;
        }

        public static void IncreaseAshBuildup(Pawn p)
        {
            float num = 0.01f * MorrowRim_ModSettings.SettingAshBuildupMultiplier;
            num /= (p.BodySize / p.health.capacities.GetLevel(PawnCapacityDefOf.Breathing));
            if (num != 0f)
            {
                float num2 = Mathf.Lerp(0.85f, 1.15f, Rand.ValueSeeded(p.thingIDNumber ^ 74374237));
                num *= num2;
                HealthUtility.AdjustSeverity(p, HediffDefOf.MorrowRim_AshBuildup, num);
                DoNotification(p, num, p.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.MorrowRim_AshBuildup).Severity);
            }
        }

        public static void DoNotification(Pawn p, float sevInc, float sevCur)
        {
            if (MorrowRim_ModSettings.SettingEnableAshBuildupNotifications && p != null)
            {
                //player colonists
                if (p.IsColonist && MorrowRim_ModSettings.SettingEnableAshBuildupNotifications_Colonist &&
                    sevCur - sevInc < MorrowRim_ModSettings.SettingEnableAshBuildupNotifications_ColonistThreshold && sevCur > MorrowRim_ModSettings.SettingEnableAshBuildupNotifications_ColonistThreshold)
                {
                    ActualNotification(p, sevCur);
                    return;
                }
                //player animals
                if (p.AnimalOrWildMan() && p.Faction != null && p.Faction.IsPlayer && MorrowRim_ModSettings.SettingEnableAshBuildupNotifications_Animals &&
                    sevCur - sevInc < MorrowRim_ModSettings.SettingEnableAshBuildupNotifications_AnimalsThreshold && sevCur > MorrowRim_ModSettings.SettingEnableAshBuildupNotifications_AnimalsThreshold)
                {
                    ActualNotification(p, sevCur);
                    return;
                }
                //friendly pawns
                if (p.Faction != null && !p.Faction.HostileTo(Faction.OfPlayer) && MorrowRim_ModSettings.SettingEnableAshBuildupNotifications_Friendly &&
                    sevCur - sevInc < MorrowRim_ModSettings.SettingEnableAshBuildupNotifications_FriendlyThreshold && sevCur > MorrowRim_ModSettings.SettingEnableAshBuildupNotifications_FriendlyThreshold)
                {
                    ActualNotification(p, sevCur);
                    return;
                }
            }
        }

        public static void ActualNotification(Pawn p, float sev)
        {
            Messages.Message("MorrowRim_AshBuildupNotification".Translate(p, sev.ToStringPercent()), p, MessageTypeDefOf.NegativeHealthEvent, true);
        }

        /* ========== plants ========== */

        public static bool IsWindPlant(Thing thing)
        {
            return thing is Building && Rand.RangeInclusive(1, 10) > 7 
                && (thing.def.defName.Equals("WindTurbine") || thing.def.defName.Equals("Windmill"));
        }

        public static void DamageWindPlant(Thing thing)
        {
            DamageInfo info = new DamageInfo
            {
                Def = DamageDefOf.Deterioration,
            };
            //takes damage 14 times becuase of building size
            info.SetAmount(Rand.Gaussian(MorrowRim_ModSettings.SettingAshTurbineDamage));
            thing.TakeDamage(info);
        }

        public static bool IsActualPlant(Thing thing)
        {
            return thing is Plant;
        }

        public static bool IsValidPlant(Plant plant)
        {
            return !IsImmuneToAsh(plant) && Rand.Chance(ModSettings_Utility.SettingToFloat(MorrowRim_ModSettings.SettingAshPlantChance));
        }

        public static bool IsSownPlant(Plant plant)
        {
            return plant.sown;
        }

        public static void DamagePlant(Plant plant)
        {
            DamageInfo info = new DamageInfo
            {
                Def = DamageDefOf.Deterioration
            };
            info.SetAmount(Rand.Gaussian(MorrowRim_ModSettings.SettingAshPlantDamage));
            if (plant.def == ThingDefOf.MorrowRim_MuckSponge && !MorrowRim_ModSettings.SettingAshIgnoreResistance)
            {
                info.SetAmount(info.Amount / 2);
            }
            plant.TakeDamage(info);
        }
    }
}