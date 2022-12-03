using System;
using Verse;
using RimWorld;
using RimWorld.Planet;

namespace MorrowRim
{
    public static class TrueCliffRacerExtinctionCheck
    {
        public static bool GetWorld(out World world)
        {
            world = Find.World;
            return world != null;
        }

        public static bool IsExtinct()
        {
            if (GetWorld(out World world))
            {
                return world.GetComponent<WorldComponent_CliffRacerTracker>().ExtinctionReached()
                    && MorrowRim_ModSettings.SettingEnableTrueCliffRacerExtinction;
            }
            return false;
        }

        public static float CurrentCount()
        {
            if (GetWorld(out World world))
            {
                return world.GetComponent<WorldComponent_CliffRacerTracker>().cliffRacerDeaths;
            }
            return 0;
        }

        public static string PercentageProgress()
        {
            float target = MorrowRim_ModSettings.SettingEnableTrueCliffRacerExtinctionCount;
            return ((float)CurrentCount() / (float)target).ToStringPercent();
        }
    }

    public class WorldComponent_CliffRacerTracker : WorldComponent
    {
        public WorldComponent_CliffRacerTracker(World world) : base(world)
        {

        }

        public override void ExposeData()
        {
            Scribe_Values.Look(ref cliffRacerDeaths, "MorrowRim_CurrentCliffRacerDeaths", 0);
            base.ExposeData();
        }

        public void IncrementDeaths(Corpse corpse = null)
        {
            if (!ExtinctionReached())
            {
                cliffRacerDeaths++;
                if (ExtinctionReached())
                {
                    Find.LetterStack.ReceiveLetter("MorrowRim_TrueCliffRacerExtinctionCompletion_Label".Translate(), "MorrowRim_TrueCliffRacerExtinctionCompletion_Description".Translate(), LetterDefOf.PositiveEvent, corpse);
                    return;
                }
                if (cliffRacerDeaths%500f == 0f)
                {
                    Messages.Message("MorrowRim_TrueCliffRacerExtinctionProgress".Translate(), corpse, MessageTypeDefOf.PositiveEvent, true);
                }
            }
        }

        public bool ExtinctionReached()
        {
            return cliffRacerDeaths >= MorrowRim_ModSettings.SettingEnableTrueCliffRacerExtinctionCount;
        }

        public float cliffRacerDeaths = 0;
    }
}
