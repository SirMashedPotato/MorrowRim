﻿using System;
using UnityEngine;
using Verse;
using RimWorld;

namespace MorrowRim
{
    class PlaceWorker_ShowVesselRadius : PlaceWorker
    {
        public override void DrawGhost(ThingDef def, IntVec3 center, Rot4 rot, Color ghostCol, Thing thing = null)
        {
            GenDraw.DrawRadiusRing(center, 3);
        }
    }
}
