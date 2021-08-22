using System;
using System.Collections.Generic;
using UnityEngine;
using Verse;
using RimWorld;
using System.Reflection.Emit;
using System.Linq;

namespace MorrowRim
{
	public class IncidentWorker_SiltStrider_Single : IncidentWorker
	{
		protected override bool CanFireNowSub(IncidentParms parms)
		{
			Map map = (Map)parms.target;
			IntVec3 intVec;
			return this.TryFindEntryCell(map, out intVec);
		}

		//
		protected override bool TryExecuteWorker(IncidentParms parms)
		{
			Map map = (Map)parms.target;
			IntVec3 intVec;
			if (!this.TryFindEntryCell(map, out intVec))
			{
				return false;
			}
			Verse.PawnKindDef siltStrider = PawnKindDefOf.MorrowRim_SiltStrider;
			IntVec3 invalid = IntVec3.Invalid;
			if (!RCellFinder.TryFindRandomCellOutsideColonyNearTheCenterOfTheMap(intVec, map, 10f, out invalid))
			{
				invalid = IntVec3.Invalid;
			}
			Pawn pawn = null;
			IntVec3 loc = CellFinder.RandomClosewalkCellNear(intVec, map, 10, null);
			pawn = PawnGenerator.GeneratePawn(siltStrider, null);
			GenSpawn.Spawn(pawn, loc, map, Rot4.Random, WipeMode.Vanish, false);
			if (invalid.IsValid)
			{
				pawn.mindState.forcedGotoPosition = CellFinder.RandomClosewalkCellNear(invalid, map, 10, null);
			}
			
			Find.LetterStack.ReceiveLetter("LetterLabelSiltStriderPasses".Translate(siltStrider.label).CapitalizeFirst(), "LetterSiltStriderAttracted".Translate(siltStrider.label), LetterDefOf.PositiveEvent, pawn, null, null);
			return true;
		}
		//

		private bool TryFindEntryCell(Map map, out IntVec3 cell)
		{
			return RCellFinder.TryFindRandomPawnEntryCell(out cell, map, CellFinder.EdgeRoadChance_Animal + 0.2f, false, null);
		}
	}
}
