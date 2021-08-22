﻿using System;
using System.Collections.Generic;
using System.Linq;
using RimWorld.Planet;
using Verse;
using RimWorld;
using RimWorld.QuestGen;

namespace MorrowRim
{
    class QuestNode_Root_CorrusRefugeeJoins_WalkIn : QuestNode_Root_WandererJoin
    {
		protected override void RunInt()
		{
			base.RunInt();
			Quest quest = QuestGen.quest;
			quest.Delay(TimeoutTicks, delegate
			{
				quest.End(QuestEndOutcome.Fail, 0, null, null, QuestPart.SignalListenMode.OngoingOnly, false);
			}, null, null, null, false, null, null, false, null, null, null, false, QuestPart.SignalListenMode.OngoingOnly);
		}

		public override Pawn GeneratePawn()
		{
			Slate slate = QuestGen.slate;
			Gender? fixedGender = null;
			PawnGenerationRequest request;
			if (!slate.TryGet<PawnGenerationRequest>("overridePawnGenParams", out request, false))
			{
				request = new PawnGenerationRequest(RimWorld.PawnKindDefOf.Villager, null, PawnGenerationContext.NonPlayer, -1, true, false, false, false, true, false, 20f, false, true, true, true, false, false, false, false, 0f, 0f, null, 1f, null, null, null, null, null, null, null, fixedGender, null, null, null, null, null, false, false, false);
			}
			Pawn pawn = PawnGenerator.GeneratePawn(request);
			InflictCorprus(pawn);
			if (!pawn.IsWorldPawn())
			{
				Find.WorldPawns.PassToWorld(pawn, PawnDiscardDecideMode.Decide);
			}
			return pawn;
		}

		private void InflictCorprus(Pawn pawn)
        {
            if (Rand.Chance(ModSettings_Utility.MorrowRim_SettingEnableCorprusRefugeeChance()))
            {
				pawn.health.AddHediff(HediffDefOf.MorrowRim_Corprus, null, null, null).Severity = Rand.Range(0.0f, ModSettings_Utility.MorrowRim_SettingEnableCorprusRefugeeSeverity()+0.1f);
			}
        }

		protected override void AddSpawnPawnQuestParts(Quest quest, Map map, Pawn pawn)
		{
			this.signalAccept = QuestGenUtility.HardcodedSignalWithQuestID("Accept");
			this.signalReject = QuestGenUtility.HardcodedSignalWithQuestID("Reject");
			quest.Signal(this.signalAccept, delegate
			{
				quest.SetFaction(Gen.YieldSingle<Pawn>(pawn), Faction.OfPlayer, null);
				quest.PawnsArrive(Gen.YieldSingle<Pawn>(pawn), null, map.Parent, null, false, null, null, null, null, null, false, false, true);
				quest.End(QuestEndOutcome.Success, 0, null, null, QuestPart.SignalListenMode.OngoingOnly, false);
			}, null, QuestPart.SignalListenMode.OngoingOnly);
			quest.Signal(this.signalReject, delegate
			{
				quest.GiveDiedOrDownedThoughts(pawn, PawnDiedOrDownedThoughtsKind.DeniedJoining, null);
				quest.End(QuestEndOutcome.Fail, 0, null, null, QuestPart.SignalListenMode.OngoingOnly, false);
			}, null, QuestPart.SignalListenMode.OngoingOnly);
		}

		public override void SendLetter(Quest quest, Pawn pawn)
		{
			TaggedString label = "MorrowRim_LetterLabelCorprusRefugeeJoins".Translate(pawn.Named("PAWN")).AdjustedFor(pawn, "PAWN", true);
			TaggedString text = "LetterCorprusRefugeeJoins".Translate(pawn.Named("PAWN"), HediffDefOf.MorrowRim_Corprus).AdjustedFor(pawn, "PAWN", true);
			QuestNode_Root_WandererJoin_WalkIn.AppendCharityInfoToLetter("JoinerCharityInfo".Translate(pawn), ref text);
			PawnRelationUtility.TryAppendRelationsWithColonistsInfo(ref text, ref label, pawn);
			ChoiceLetter_AcceptJoiner choiceLetter_AcceptJoiner = (ChoiceLetter_AcceptJoiner)LetterMaker.MakeLetter(label, text, LetterDefOf.AcceptJoiner, null, null);
			choiceLetter_AcceptJoiner.signalAccept = this.signalAccept;
			choiceLetter_AcceptJoiner.signalReject = this.signalReject;
			choiceLetter_AcceptJoiner.quest = quest;
			choiceLetter_AcceptJoiner.StartTimeout(TimeoutTicks);
			Find.LetterStack.ReceiveLetter(choiceLetter_AcceptJoiner, null);
		}

		public static void AppendCharityInfoToLetter(TaggedString charityInfo, ref TaggedString letterText)
		{
			if (ModsConfig.IdeologyActive)
			{
				IEnumerable<Pawn> source = IdeoUtility.AllColonistsWithCharityPrecept();
				if (source.Any<Pawn>())
				{
					letterText += "\n\n" + charityInfo + "\n\n" + "PawnsHaveCharitableBeliefs".Translate() + ":";
					foreach (IGrouping<Ideo, Pawn> grouping in from c in source
															   group c by c.Ideo)
					{
						letterText += "\n  - " + "BelieversIn".Translate(grouping.Key.name.Colorize(grouping.Key.Color), grouping.Select((Pawn f) => f.NameShortColored.Resolve()).ToCommaList(false, false));
					}
				}
			}
		}

		private const int TimeoutTicks = 60000;

		public const float RelationWithColonistWeight = 20f;

		private string signalAccept;

		private string signalReject;
	}
}
