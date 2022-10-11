using Verse;
using RimWorld;

namespace MorrowRim
{
    public class ExtendedRaceProperties : DefModExtension
    {
        public AshResistant ashResistant;

        public bool StrangeButcher = false;

        public static ExtendedRaceProperties Get(Def def)
        {
            return def.GetModExtension<ExtendedRaceProperties>();
        }
    }
}
