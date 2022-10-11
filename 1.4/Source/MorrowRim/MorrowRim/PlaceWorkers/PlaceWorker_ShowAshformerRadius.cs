using System;
using UnityEngine;
using Verse;
using RimWorld;
using System.Collections.Generic;

namespace MorrowRim
{
    class PlaceWorker_ShowAshformerRadius : PlaceWorker
    {
		public override void DrawGhost(ThingDef def, IntVec3 center, Rot4 rot, Color ghostCol, Thing thing = null)
		{
			GenDraw.DrawRadiusRing(center, 5);
			int radius = GenRadial.NumCellsInRadius(5);
			List<IntVec3> cells = new List<IntVec3> { };
			for (int i = 0; i != radius; i++)
			{
				IntVec3 tile = center + GenRadial.RadialPattern[i];
				if (tile.InBounds(thing.Map))
				{
					switch (tile.GetTerrain(thing.Map).defName)
					{
						//soil
						case "Soil":
						case "MossyTerrain":
						case "MorrowRim_BlightedAsh":
						case "MorrowRim_AshySoil":
						//sand
						case "Sand":
						case "SoftSand":
						case "MorrowRim_BlightedCrackedGround":
						//gravel
						case "Gravel":
						case "MorrowRim_BlightedStonyAsh":
						//rich soil
						case "SoilRich":
						//ash enhancement
						case "MorrowRim_Ash":
						case "MorrowRim_VolcanicAsh":
							cells.Add(tile);
							break;
						default:
							break;
					}
				}
			}
			GenDraw.DrawFieldEdges(cells, Color.green);
		}
    }
}
