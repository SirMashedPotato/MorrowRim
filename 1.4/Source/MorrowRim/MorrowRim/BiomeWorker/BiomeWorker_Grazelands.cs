using RimWorld.Planet;
using RimWorld;
using Verse;
using Verse.Noise;

namespace MorrowRim
{
    public class BiomeWorker_Grazelands : BiomeWorker
    {
        public int perlinSeed = 35;
        public float perlinCulling = 0.5f;

        public override float GetScore(Tile tile, int tileID)
        {
            if (!MorrowRim_ModSettings.SettingBiomeEnableGrazelands)
            {
                return -100f;
            }
            if (tile.WaterCovered)
            {
                return -100f;
            }
            if (tile.swampiness > 0.5f)
            {
                return 0f;
            }
            if (tile.hilliness == Hilliness.Mountainous || tile.hilliness == Hilliness.Impassable)
            {
                return 0f;
            }

            Perlin perlin = new Perlin(0.1, 10, 0.6, 12, perlinSeed, QualityMode.Low);
            float perlinValue = perlin.GetValue(Find.WorldGrid.GetTileCenter(tileID));

            if (perlinValue <= perlinCulling)
            {
                return 0f;
            }

            float chance = BiomeWorker_Ashlands.AshlandsBiomeWorker(tile, tileID);
            return chance <= 0f ? 0f : chance + 1;
        }
    }
}