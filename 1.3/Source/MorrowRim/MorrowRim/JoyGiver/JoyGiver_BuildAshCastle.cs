using System;
using System.Collections.Generic;
using Verse;
using Verse.AI;
using RimWorld;

namespace MorrowRim
{
    class JoyGiver_BuildAshCastle : JoyGiver
    {

		public override Job TryGiveJob(Pawn pawn)
		{
            if (ModSettings_Utility.MorrowRim_SettingEnableAshCastles())
            {

				if (pawn.WorkTypeIsDisabled(WorkTypeDefOf.Construction) && !pawn.story.traits.HasTrait(TraitDef.Named("MorrowRim_AshLover")))
				{
					Log.Message("Construction disabled, and doesn't have ash lover trait, for " + pawn.Name);
					return null;
				}
				if (!JoyUtility.EnjoyableOutsideNow(pawn, null))
				{
					Log.Message("Outside disabled for " + pawn.Name);
					return null;
				}
				if (!ModSettings_Utility.MorrowRim_SettingEnableAshCastlesDuringAshStorm() && WeatherUtilityAsh.WeatherIsAshStorm(pawn.Map))
				{
					Log.Message("Ash storm disabled for " + pawn.Name);
					return null;
				}
				IntVec3 c = JoyGiver_BuildAshCastle.TryFindAshCastleBuildCell(pawn);
				if (!c.IsValid)
				{
					Log.Message("Failed to find cell for " + pawn.Name);
					return null;
				}
				return JobMaker.MakeJob(this.def.jobDef, c);
			}
			return null;
		}

		private static IntVec3 TryFindAshCastleBuildCell(Pawn pawn)
		{
			Region rootReg;
			if (!CellFinder.TryFindClosestRegionWith(pawn.GetRegion(RegionType.Set_Passable), TraverseParms.For(pawn, Danger.Deadly, TraverseMode.ByPawn, false, false, false), (Region r) => r.Room.PsychologicallyOutdoors, 100, out rootReg, RegionType.Set_Passable))
			{
				return IntVec3.Invalid;
			}
			IntVec3 result = IntVec3.Invalid;
			RegionTraverser.BreadthFirstTraverse(rootReg, (Region from, Region r) => r.District == rootReg.District, delegate (Region r)
			{
				for (int i = 0; i < 5; i++)
				{
					IntVec3 randomCell = r.RandomCell;
					if (JoyGiver_BuildAshCastle.IsGoodAshCastleCell(randomCell, pawn))
					{
						result = randomCell;
						return true;
					}
				}
				return false;
			}, 30, RegionType.Set_Passable);
			return result;
		}

		private static bool IsGoodAshCastleCell(IntVec3 c, Pawn pawn)
		{
			if (!c.GetTerrain(pawn.Map).affordances.Contains(TerrainAffordanceDefOf.MorrowRim_AshCastle))
			{
				return false;
			}
			if (!c.GetThingList(pawn.Map).NullOrEmpty())
            {
				return false;
            }
			if (c.IsForbidden(pawn))
			{
				return false;
			}
			if (c.GetEdifice(pawn.Map) != null)
			{
				return false;
			}
			for (int i = 0; i < 9; i++)
			{
				IntVec3 c2 = c + GenAdj.AdjacentCellsAndInside[i];
				if (!c2.InBounds(pawn.Map))
				{
					return false;
				}
				if (!c2.Standable(pawn.Map))
				{
					return false;
				}
				if (pawn.Map.reservationManager.IsReservedAndRespected(c2, pawn))
				{
					return false;
				}
			}
			List<Thing> list = pawn.Map.listerThings.ThingsOfDef(ThingDefOf.MorrowRim_AshCastle);
			for (int j = 0; j < list.Count; j++)
			{
				if (list[j].Position.InHorDistOf(c, ModSettings_Utility.MorrowRim_SettingEnableAshCastlesMinDistance()))
				{
					return false;
				}
			}
			return true;
		}
	}
}
