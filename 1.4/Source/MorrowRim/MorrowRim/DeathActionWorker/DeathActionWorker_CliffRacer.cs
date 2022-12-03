using Verse;
using RimWorld.Planet;

namespace MorrowRim
{
    public class DeathActionWorker_CliffRacer : DeathActionWorker
    {
        public override void PawnDied(Corpse corpse)
        {
            if(corpse.InnerPawn.Faction == null && MorrowRim_ModSettings.SettingEnableTrueCliffRacerExtinction)
            {
                World world = Find.World;
                if(world != null)
                {
                    world.GetComponent<WorldComponent_CliffRacerTracker>().IncrementDeaths(corpse);
                }
            }
        }
    }
}