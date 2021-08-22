using RimWorld;
using RimWorld.Planet;
using Verse;

namespace MorrowRim
{
	//placeholder for testing
    class BiomeWorker_GlaciatedAshlands : BiomeWorker
	{
		public override float GetScore(Tile tile, int tileID)
		{
			if (tile.WaterCovered)
			{
				return -100f;
			}
			if (tile.temperature > -10f)
			{
				return 0f;
			}
			return Rand.Range(5, 20);
		}
	}
}
