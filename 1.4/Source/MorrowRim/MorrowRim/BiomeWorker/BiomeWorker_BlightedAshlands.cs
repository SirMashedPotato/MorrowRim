﻿using System;
using RimWorld.Planet;
using RimWorld;

namespace MorrowRim
{
    public class BiomeWorker_BlightedAshlands : BiomeWorker
    {
        public override float GetScore(Tile tile, int tileID)
        {
            if (!MorrowRim_ModSettings.SettingBiomeEnableBlightedAshlands)
            {
                return -100f;
            }
            if (tile.WaterCovered)
            {
                return -100f;
            }
            //standard BiomeWorker
            if (!MorrowRim_ModSettings.SettingBiomePolarShift)
            {
                if (tile.temperature <= 0 - 10f)
                {
                    return 0f;
                }
                if ((tile.rainfall < 400f) || (tile.rainfall >= 500f))
                {
                    return 0f;
                }
                return (22.5f + (tile.temperature - 20f) * 2.2f + (tile.rainfall - 600f) / 100f) * MorrowRim_ModSettings.SettingBiomeMultiplier;
            }
            //polar BiomeWorker
            if (tile.temperature > -10f)
            {
                return 0f;
            }
            if (tile.rainfall < 600f)
            {
                return 0f;
            }
            return -tile.temperature * MorrowRim_ModSettings.SettingBiomeMultiplier;
        }

    }
}