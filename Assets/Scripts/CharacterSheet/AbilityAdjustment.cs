using System;

namespace Pocruga.OOPT.CharacterSheet 
{
    public class AbilityAdjustment
    {
        public AbilityType Type { get; private set; }

        public int Value { get; private set; }
        
        public AbilityAdjustment(AbilityType type, int value) 
        {
            Type = type;
            Value = value;
        }

        // Format "{sign}{value} {abbreviation}", e.g. "+2 DEX", "-2 CON"
        public override string ToString()
        {
            return string.Format("{0}{1} {2}", Value >= 0 ? "+" : string.Empty, Value, Type.GetAbbrev());
        }
    }
}
