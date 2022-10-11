using System;
using Verse;
using RimWorld;

namespace MorrowRim
{
    class IncidentWorker_GiveQuest_Corprus : IncidentWorker
    {
        protected override bool CanFireNowSub(IncidentParms parms)
        {
			if (!base.CanFireNowSub(parms) || !ModSettings_Utility.MorrowRim_SettingEnableCorprusRefugee())
			{
				return false;
			}
			if (this.def.questScriptDef != null)
			{
				if (!this.def.questScriptDef.CanRun(parms.points))
				{
					return false;
				}
			}
			else if (parms.questScriptDef != null && !parms.questScriptDef.CanRun(parms.points))
			{
				return false;
			}
			return PawnsFinder.AllMapsCaravansAndTravelingTransportPods_Alive_FreeColonists_NoCryptosleep.Any<Pawn>();
		}

		protected override bool TryExecuteWorker(IncidentParms parms)
		{
			QuestScriptDef questScriptDef;
			if ((questScriptDef = this.def.questScriptDef) == null)
			{
				questScriptDef = (parms.questScriptDef ?? NaturalRandomQuestChooser.ChooseNaturalRandomQuest(parms.points, parms.target));
			}
			QuestScriptDef questDef = questScriptDef;
			this.GiveQuest(parms, questDef);
			return true;
		}

		protected virtual void GiveQuest(IncidentParms parms, QuestScriptDef questDef)
		{
			Quest quest = QuestUtility.GenerateQuestAndMakeAvailable(questDef, parms.points);
			if (!quest.hidden && questDef.sendAvailableLetter)
			{
				QuestUtility.SendLetterQuestAvailable(quest);
			}
		}
	}
}
