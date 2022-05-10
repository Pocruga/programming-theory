using System.Collections.Generic;

namespace Pocruga.OOPT.CharacterSheet.Races
{
    public interface IRace
    {
        string Title { get; }

        string Description { get; }

        string DisplayText { get; }

        int HitPoints { get; }
        
        List<string> RaceAbilities { get; }

        bool HasAdditionalSelection();

        void ApplyTo(PlayerCharacter character);
   }
}
