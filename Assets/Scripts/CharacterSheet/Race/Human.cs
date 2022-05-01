using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pocruga.OOPT.CharacterSheet.Race
{
    public class Human : IRace
    {
        public string Title => nameof(Human);

        public string Description => "Ambitious, creative, and endlessly curious, humans have shown more drive to explore their system and the universe beyond than any of their neighbor races�for better and for worse. They�ve helped usher in a new era of system-wide communication and organization and are admired for their passion and tenacity, but their tendency to shoot first and think about the consequences later can make them a liability for those races otherwise inclined to work with them.";

        public int HitPoints => 4;

        public bool HasAdditionalSelection() => false;

        public void ApplyTo(PlayerCharacter character)
        {
            // Ability adjustments - +2 on one user selected ability
            // Bonus Feature - Humans select one extra feat at 1st level.
            // Skilled - Humans gain an additional skill rank at 1st level and each level thereafter.
        }
    }
}
