using System;
using System.Collections.Generic;
using UnityEngine;
using Verse;
using RimWorld;
using System.Reflection.Emit;
using System.Linq;

namespace MorrowRim
{
    public class WeatherEvent_AshDamage : WeatherEvent
    {
        public WeatherEvent_AshDamage(Map map) : base(map)
        {
        }

        public override bool Expired
        {
            get
            {
                return this.age > this.duration;
            }
        }

        public override void FireEvent()
        {
            if (!MorrowRim_ModSettings.SettingEnableAshEffects) return;

            //for plants, first to avoid out of bounds exception
            IntVec3[] vecs = new IntVec3[map.AllCells.Where(x => WeatherUtilityAsh.IsValidCell(x, this.map)).Count()];
            vecs = map.AllCells.Where(x => WeatherUtilityAsh.IsValidCell(x, this.map)).InRandomOrder().ToArray();
            foreach (IntVec3 cell in vecs)
            {
                DoAshDamageToPlant(cell);
            }

            //for pawns, in a try catch incase a pawn dies during, which can cause an out of bounds exception
            try
            {
                List<Pawn> allPawnsSpawned = map.mapPawns.AllPawnsSpawned;
                for (int i = 0; i != allPawnsSpawned.Count(); i++)
                {
                    if (WeatherUtilityAsh.IsValidTarget(allPawnsSpawned[i]))
                    {
                        WeatherUtilityAsh.DoAshDamageToPawn(allPawnsSpawned[i]);
                    }
                }
            }
            catch(ArgumentOutOfRangeException)
            {
                Log.Message("Ash damage fire event had argument out of bounds exception occur, may have ended prematurely. This is completely safe to ignore.");
            }
        }

        public void DoAshDamageToPlant(IntVec3 vec)
        {
            List<Thing> thingList = vec.GetThingList(this.map);
            foreach(Thing t in thingList)
            {
                if (WeatherUtilityAsh.IsActualPlant(t))
                {
                    Plant p = t as Plant;
                    if (MorrowRim_ModSettings.SettingAshIgnoreResistance || WeatherUtilityAsh.IsValidPlant(p))
                    {
                        if (MorrowRim_ModSettings.SettingAshOnlySownPlants && !WeatherUtilityAsh.IsSownPlant(p))
                        {
                            return;
                        }
                        WeatherUtilityAsh.DamagePlant(p);
                    }
                    return;
                }
                if(WeatherUtilityAsh.IsWindPlant(t) && Rand.Chance(0.5f))
                {
                    WeatherUtilityAsh.DamageWindPlant(t);
                    return;
                }
            }
        }

        public override void WeatherEventTick()
        {
            this.age++;
        }

        //variables
        private int age;
        private int duration;
    }
}
