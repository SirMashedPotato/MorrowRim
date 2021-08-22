using System;
using Verse;
using Verse.AI;
using RimWorld;

namespace MorrowRim
{
    class JobGiver_HideFromAshStorm : ThinkNode_JobGiver
    {
		//Modified from SeekSafeTemperature
		protected override Job TryGiveJob(Pawn pawn)
		{
			if (pawn.Position.Roofed(pawn.Map))
			{
				return JobMaker.MakeJob(JobDefOf.MorrowRim_Wait_DuringAshstorm, 500, true);
			}
			Region region = ClosestRegionWithinShelter(pawn.Position, pawn.Map, TraverseParms.For(pawn, Danger.Deadly, TraverseMode.ByPawn, false, false, false), RegionType.Set_Passable);
			if (region != null)
			{
				return JobMaker.MakeJob(JobDefOf.MorrowRim_GotoSafeFromAshstorm, region.RandomCell);
			}
			return null;
		}

		private static Region ClosestRegionWithinShelter(IntVec3 root, Map map, TraverseParms traverseParms, RegionType traversableRegionTypes = RegionType.Set_Passable)
		{
			Region region = root.GetRegion(map, traversableRegionTypes);
			if (region == null)
			{
				return null;
			}
			RegionEntryPredicate entryCondition = (Region from, Region r) => r.Allows(traverseParms, false);
			Region foundReg = null;
			RegionProcessor regionProcessor = delegate (Region r)
			{
				if (r.IsDoorway)
				{
					return false;
				}
				if (r.Room.OpenRoofCount == 0)
				{
					foundReg = r;
					return true;
				}
				return false;
			};
			RegionTraverser.BreadthFirstTraverse(region, entryCondition, regionProcessor, 9999, traversableRegionTypes);
			return foundReg;
		}
	}
}
