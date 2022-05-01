using System.Collections.Generic;

namespace Pocruga.OOPT.CharacterSheet 
{
    public class Ability 
    {
        private List<AbilityAdjustment> adjustments = new List<AbilityAdjustment>();

        public AbilityType Type {get; private set;}

        private int Value {get;}

        public Ability(AbilityType type) => Type = type;

        public void AddAdjustment(AbilityAdjustment adjustment) {
            adjustments.Add(adjustment);
        }
    }
}