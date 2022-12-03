using Verse;
using RimWorld;

namespace MorrowRim
{
    class ThinkNode_ConditionalScribCabbage : ThinkNode_ConditionalPawnKind
    {

        protected override bool Satisfied(Pawn pawn)
        {
            return pawn.kindDef == this.pawnKind && MorrowRim_ModSettings.SettingEnableScribBehaviour;
        }
    }
}
