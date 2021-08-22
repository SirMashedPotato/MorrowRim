using System;
using Verse;
using Verse.Sound;
using RimWorld;

namespace MorrowRim
{
    class CompUseEffect_Ashformer : CompUseEffect_Artifact
    {
		new public CompProperties_UseEffectAshformer Props
		{
			get
			{
				return (CompProperties_UseEffectAshformer)this.props;
			}
		}

		public override void DoEffect(Pawn usedBy)
		{
			base.DoEffect(usedBy);
			int radius = GenRadial.NumCellsInRadius(5);
			for(int i = 0; i != radius; i++)
				{
				IntVec3 tile = parent.Position + GenRadial.RadialPattern[i];
				if (tile.InBounds(parent.Map))
				{
					TerrainDef terrainTo = null;
					switch (tile.GetTerrain(parent.Map).defName)
                    {
						//soil
						case "Soil":
						case "MossyTerrain":
						case "MorrowRim_BlightedAsh":
						case "MorrowRim_AshySoil":
							terrainTo = TerrainDef.Named("MorrowRim_Ash");
							break;
						//sand
						case "Sand":
						case "SoftSand":
						case "MorrowRim_BlightedCrackedGround":
							terrainTo = TerrainDef.Named("MorrowRim_SandyAsh");
							break;
						//gravel
						case "Gravel":
						case "MorrowRim_BlightedStonyAsh":
							terrainTo = TerrainDef.Named("MorrowRim_StonyAsh");
							break;
						//rich soil
						case "SoilRich":
							terrainTo = TerrainDef.Named("MorrowRim_SoftAsh");
							break;
						//ash enhancement
						case "MorrowRim_Ash":
							terrainTo = TerrainDef.Named("MorrowRim_SoftAsh");
							break;
						case "MorrowRim_VolcanicAsh":
							terrainTo = TerrainDef.Named("MorrowRim_RichVolcanicAsh");
							break;
						default:
							break;
					}
					if(terrainTo != null)
                    {
						FleckMaker.ThrowDustPuff(tile, parent.Map, 1f);
						parent.Map.terrainGrid.SetTerrain(tile, terrainTo);
                    }
				}
			}
		}
	}
}
