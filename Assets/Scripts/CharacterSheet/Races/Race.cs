using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pocruga.OOPT.CharacterSheet.Races
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
                builder.Append("\n<b>Ability Adjustments:</b> ");
                foreach(AbilityAdjustment adjustment in adjustments) {
                    builder.Append(adjustment.ToString());
                    if(!adjustment.Equals(adjustments.Last()))
                        builder.Append(", ");
                }
                return builder.ToString();
            } 
        }

        public string DisplayText {
            get 
            {
                StringBuilder builder = new StringBuilder("<b>Race's Abilities</b>");
                foreach(string str in RaceAbilities)
                    builder.Append($"\n * {str}");
                return $"{Description}\n\n{AbilityAdjustments}\n\n<b>HP:</b> {HitPoints}\n\n{builder.ToString()}";
            }
        }

        public abstract int HitPoints { get; }

        public int AbilityAdjustmentCount => adjustments.Count; 

        public abstract List<string> RaceAbilities { get; }

        public abstract bool HasAdditionalSelection();

        public abstract void ApplyTo(PlayerCharacter character);

        protected void AddAbilityAdjustment(AbilityAdjustment adjustment) {
            adjustments.Add(adjustment);
        }
    }
}
