﻿using Verse;
using RimWorld;

namespace MorrowRim
{
    public class Comp_GasOnDestroy : ThingComp
    {
		private CompProperties_GasOnDestroy Props
		{
			get
			{
				return (CompProperties_GasOnDestroy)this.props;
			}
		}

        public override void PostDestroy(DestroyMode mode, Map previousMap)
        {
            if (parent is Plant p)
            {
                if (p.def.plant.Harvestable)
                {
                    GasUtility.AddGas(parent.Position, previousMap, Props.gasType, Props.radius);
                }
            }
            base.PostDestroy(mode, previousMap);
        }
    }
}
