using Verse;

namespace MorrowRim
{
    public class CompProperties_GasOnDestroy : CompProperties
    {
		public CompProperties_GasOnDestroy()
		{
			this.compClass = typeof(Comp_GasOnDestroy);
		}

		public GasType gasType;
		public float radius = 3f;
	}
}
