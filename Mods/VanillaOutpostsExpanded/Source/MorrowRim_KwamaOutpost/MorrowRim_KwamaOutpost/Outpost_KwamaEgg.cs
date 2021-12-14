using System.Collections.Generic;
using System.Linq;
using Outposts;
using MorrowRim;
using RimWorld;
using RimWorld.Planet;
using Verse;

namespace MorrowRim_KwamaOutpost
{
    public class Outpost_KwamaEgg : Outpost
    {

        public static int maxDistance = 5;  //make setting in main assembly

        public static float DistanceFromKwamaNest(int tile)
        {
            WorldGrid worldGrid = Find.WorldGrid;
            WorldObjectsHolder worldObjectsHolder = Find.WorldObjects;
            List<Settlement> kwamaSettlements = new List<Settlement>(worldObjectsHolder.SettlementBases.Where(x => x.Faction.def == MorrowRim.FactionDefOf.MorrowRim_Kwama));
            float distance = -1f;
            for (int i = 0; i != kwamaSettlements.Count; i++)
            {
                float distance2 = worldGrid.ApproxDistanceInTiles(tile, kwamaSettlements[i].Tile);
                if (distance == -1 || distance > distance2) distance = distance2;
            }
            return distance;
        }

        public static bool CloseEnough(float distance)
        {
            return distance <= maxDistance;
        }

        public static string CanSpawnOnWith(int tile, List<Pawn> pawns) => !CloseEnough(DistanceFromKwamaNest(tile)) ? "MorrowRimOutposts.MustBeMade.KwamaNest".Translate(maxDistance) : null;

        public static string RequirementsString(int tile, List<Pawn> pawns) =>
            Requirement("MorrowRimOutposts.MustBeMade.KwamaNest".Translate(maxDistance), CloseEnough(DistanceFromKwamaNest(tile)));
    }
}
