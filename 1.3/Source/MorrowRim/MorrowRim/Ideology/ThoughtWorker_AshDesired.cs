using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Linq;
using Verse;
using RimWorld;

namespace MorrowRim
{
	public class ThoughtWorker_AshDesired : ThoughtWorker_Precept
	{
		private readonly List<String> ashTerrain = new List<string>
		{ 
            //MorrowRim
            "MorrowRim_Ash", "MorrowRim_StonyAsh", "MorrowRim_SoftAsh", "MorrowRim_SandyAsh", 
            //MorrowRim - Blighted
            "MorrowRim_BlightedAsh", "MorrowRim_BlightedStonyAsh",
            //Swamp
            "MorrowRim_WateryAsh",
            //Grazelands
            "MorrowRim_AshySoil",
            //Volcanic
            "MorrowRim_VolcanicAsh", "MorrowRim_RichVolcanicAsh", "MorrowRim_VolcanicGravel", "MorrowRim_VolcanicSand"
		};

		protected override ThoughtState ShouldHaveThought(Pawn p)
		{
			return p.Spawned;
		}

		protected override ThoughtState CurrentStateInternal(Pawn p)
		{
			if (!base.CurrentStateInternal(p).Active || p.surroundings == null)
			{
				return ThoughtState.Inactive;
			}
			return ThoughtState.ActiveAtStage(this.ThoughtStageIndex(p));
		}

		private int ThoughtStageIndex(Pawn p)
		{
			float percentage = GetAshTerrain(p);
			//stages
			if(percentage == 1f)
            {
				return 0;
            }
			if (percentage > 0.9f)
			{
				return 1;
			}
			if (percentage > 0.75f)
			{
				return 2;
			}
			if (percentage > 0.60f)
			{
				return 3;
			}
			if (percentage > 0.45f)
			{
				return 4;
			}
			if (percentage > 0.30f)
			{
				return 5;
			}
			if (percentage > 0.15f)
			{
				return 6;
			}
			if (percentage < 0.15f && percentage != 0f)
			{
				return 7;
			}
			if (percentage == 0f)
			{
				return 8;
			}
			return 4;
		}

		private float GetAshTerrain(Pawn p)
        {
			float num = 0;
			int radius = GenRadial.NumCellsInRadius(Radius);
			float trueRadius = radius;
			for (int i = 0; i != radius; i++)
			{
				IntVec3 tile = p.Position + GenRadial.RadialPattern[i];
				if (tile.InBounds(p.Map))
				{
					if (ashTerrain.Contains(tile.GetTerrain(p.Map).defName))
					{
						num++;
					}
				}
				else
                {
					trueRadius--;
                }
			}
			Log.Message("Pawn: " + p + ", % " + num / trueRadius);
			return num / trueRadius;
		}

		private const int Radius = 10;

	}
}
