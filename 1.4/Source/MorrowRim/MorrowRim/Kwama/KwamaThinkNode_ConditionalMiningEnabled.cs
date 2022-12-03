using System;
using Verse;
using Verse.AI;
using RimWorld;

namespace MorrowRim.Kwama
{
    class KwamaThinkNode_ConditionalMiningEnabled : ThinkNode_Conditional
    {
		protected override bool Satisfied(Pawn pawn)
		{
			return pawn.def == ThingDefOf.MorrowRim_KwamaWorker && MorrowRim_ModSettings.SettingKwamaMining;
		}

		public string pawnKind;
	}
}
