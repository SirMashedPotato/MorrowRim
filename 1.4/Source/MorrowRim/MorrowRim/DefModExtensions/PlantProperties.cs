using Verse;
using RimWorld;
using System.Collections.Generic;

namespace MorrowRim
{
    class PlantProperties : DefModExtension
    {
        public bool forceOntoTerrain = false;
        public bool whitelist = true;   //then terrainList is terrains that plant is allowed to grow on
        public List<TerrainDef> terrainList = new List<TerrainDef>();
        public bool ashLover = false;   //Enhances growth during an ash storm via a Harmony patch.
        public float ashLoverDegree = 0.1f;
        public static PlantProperties Get(Def def)
        {
            return def.GetModExtension<PlantProperties>();
        }
    }
}
