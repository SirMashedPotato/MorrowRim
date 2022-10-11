using System;
using System.Collections.Generic;
using UnityEngine;
using Verse;
using RimWorld;
using System.Reflection.Emit;
using System.Linq;


namespace MorrowRim
{
    class Gas_AshStave : Gas
    {
        private int tickerInterval = 0;
        private int tickerMax = 120;
        public override void Tick()
        {
            base.Tick();
            try
            {
                if (tickerInterval >= tickerMax)
                {
                    HashSet<Thing> hashSet = new HashSet<Thing>(this.Position.GetThingList(this.Map));
                    if (hashSet != null)
                    {
                        foreach (Thing thing in hashSet)
                        {
                            if(thing is Pawn)
                            {
                                WeatherUtilityAsh.DoAshDamageToPawn(thing as Pawn);
                            }
                        }
                    }
                    tickerInterval = 0;
                }
                tickerInterval++;
            }
            catch (NullReferenceException e)
            {

            }
        }
    }
}

