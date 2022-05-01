using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pocruga.OOPT.CharacterSheet.Race
{
    public abstract class Race : IRace
    {
        private List<AbilityAdjustment> adjustments = new List<AbilityAdjustment>();

        public abstract string Title { get; }

        public abstract string Description { get; }

        public virtual string AbilityAdjustments { 
            get 
            {
                StringBuilder builder = new StringBuilder();
                builder.Append("Ability Adjustments: ");
                foreach(AbilityAdjustment adjustment in adjustments) {
                    builder.Append(adjustment.ToString());
                    if(!adjustment.Equals(adjustments.Last()))
                        builder.Append(", ");
                }
                return builder.ToString();
            } 
        }

        public string DisplayText => $"{Description}\n{AbilityAdjustments}";

        public abstract int HitPoints { get; }

        public int AbilityAdjustmentCount => adjustments.Count; 

        public abstract bool HasAdditionalSelection();

        public abstract void ApplyTo(PlayerCharacter character);

        protected void AddAbilityAdjustment(AbilityAdjustment adjustment) {
            adjustments.Add(adjustment);
        }
    }
}
