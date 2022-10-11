using System;
using System.Collections.Generic;
using Verse;
using RimWorld;

namespace MorrowRim
{
    class CompTargetable_VesselRadius : CompTargetable
    {
		private int radius = 3;

		protected override bool PlayerChoosesTarget
		{
			get
			{
				return false;
			}
		}

		protected override TargetingParameters GetTargetingParameters()
		{
			return new TargetingParameters
			{
				canTargetPawns = true,
				canTargetMechs = false,
				canTargetBuildings = false,
				validator = ((TargetInfo x) => base.BaseTargetValidator(x.Thing))
			};
		}

		public override IEnumerable<Thing> GetTargets(Thing targetChosenByPlayer = null)
		{
			if (this.parent.MapHeld == null)
			{
				yield break;
			}
			TargetingParameters tp = this.GetTargetingParameters();
			int radius = GenRadial.NumCellsInRadius(this.radius);
			for (int i = 0; i != radius; i++)
			{
				IntVec3 tile = this.parent.Position + GenRadial.RadialPattern[i];
				if (tile.InBounds(this.parent.Map))
				{
					foreach(Thing thing in tile.GetThingList(this.parent.Map))
                    {
						if (thing is Pawn)
						{
							Pawn pawn = thing as Pawn;
							if (tp.CanTarget(pawn, null))
							{
								yield return pawn;
							}
						}
					}
				}
			}
			List<Pawn>.Enumerator enumerator = default(List<Pawn>.Enumerator);
			yield break;
		}
	}
}
