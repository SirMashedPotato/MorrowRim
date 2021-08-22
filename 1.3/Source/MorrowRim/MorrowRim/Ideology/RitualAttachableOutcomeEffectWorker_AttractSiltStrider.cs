using System;
using System.Collections.Generic;
using Verse;
using RimWorld;

namespace MorrowRim
{
    class RitualAttachableOutcomeEffectWorker_AttractSiltStrider : RitualAttachableOutcomeEffectWorker
    {
		public override void Apply(Dictionary<Pawn, int> totalPresence, LordJob_Ritual jobRitual, OutcomeChance outcome, out string extraOutcomeDesc, ref LookTargets letterLookTargets)
		{
			extraOutcomeDesc = null;

            if (Rand.Chance(0.5f))
            {
				IncidentParms parms = new IncidentParms
				{
					target = jobRitual.Map,
				};
				if (IncidentDef.Named("MorrowRim_SiltStriderAttacted").Worker.TryExecute(parms))
				{
					extraOutcomeDesc = this.def.letterInfoText;
				}
			}
		}
	}
}
