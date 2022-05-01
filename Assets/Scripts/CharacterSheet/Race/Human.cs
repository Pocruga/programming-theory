using System;
using UnityEngine;

namespace Pocruga.OOPT.CharacterSheet.Race
{
    public class Human : Race
    {
        public override string Title => nameof(Human);

        public override string Description => "Ambitious, creative, and endlessly curious, humans have shown more drive to explore their system and the universe beyond than any of their neighbor races for better and for worse. They have helped usher in a new era of system-wide communication and organization and are admired for their passion and tenacity, but their tendency to shoot first and think about the consequences later can make them a liability for those races otherwise inclined to work with them.";

        public override int HitPoints => 4;

        public override string AbilityAdjustments {
            get {
                if(AbilityAdjustmentCount==0)
                    return "Ability Adjustments: +2 on one selected ability.";
                return base.AbilityAdjustments;
            }
        }

        public Human() {
        }

        public override bool HasAdditionalSelection() => true;

        public void SetAbilityToAdjust(string ability) {
            if(Enum.TryParse<AbilityType>(ability, out AbilityType abilityType))
                SetAbilityToAdjust(abilityType);
            else
                throw new ArgumentException($"Unsupported ability {ability}!", nameof(ability));
        }

        public void SetAbilityToAdjust(AbilityType abilityType) {
            // Ability adjustments - +2 on one user selected ability
            AddAbilityAdjustment(new AbilityAdjustment(abilityType, 2));
        }

        public override void ApplyTo(PlayerCharacter character)
        {
            // Bonus Feature - Humans select one extra feat at 1st level.
            // Skilled - Humans gain an additional skill rank at 1st level and each level thereafter.
        }
    }
}
