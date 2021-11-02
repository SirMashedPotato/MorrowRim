using System;
using System.Collections.Generic;
using Verse;
using Verse.AI;
using RimWorld;

namespace MorrowRim.Kwama
{
	class JobGiver_CleanHive : ThinkNode_JobGiver
	{

        protected override Job TryGiveJob(Pawn pawn)
        {
            Predicate<Thing> predicate = (Thing t) => t.def.category == ThingCategory.Filth && HasJobOnThing(pawn, t);
            Thing thing = GenClosest.ClosestThingReachable(ClosestHive(pawn).Position, pawn.Map, ThingRequest.ForGroup(ThingRequestGroup.Filth), PathEndMode.OnCell, TraverseParms.For(pawn, Danger.Deadly, TraverseMode.ByPawn, false), 5f, predicate);
            Job result;
            if (thing == null)
            {
                result = null;
            }
            else
            {
                result = JobMaker.MakeJob(RimWorld.JobDefOf.Clean, thing);
            }
            return result;
        }

        private Thing ClosestHive(Pawn pawn)
        {
            Thing t = (KwamaNest)GenClosest.ClosestThingReachable(pawn.Position, pawn.Map, ThingRequest.ForDef(ThingDefOf.MorrowRim_KwamaNest), PathEndMode.Touch, TraverseParms.For(pawn, Danger.Deadly, TraverseMode.ByPawn, false), 30f, (Thing x) => x.Faction == pawn.Faction, null, 0, 30, false, RegionType.Set_Passable, false);
            return t;
        }

        private int MinTicksSinceThickened = 600;

        public bool HasJobOnThing(Pawn pawn, Thing t, bool forced = false)
        {
            Filth filth = t as Filth;
            if (filth == null)
            {
                return false;
            }
            return pawn.CanReserve(t, 1, -1, null, forced) && filth.TicksSinceThickened >= this.MinTicksSinceThickened;
        }
    }
}
