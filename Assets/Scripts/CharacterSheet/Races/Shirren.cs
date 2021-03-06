using System.Collections.Generic;

namespace Pocruga.OOPT.CharacterSheet.Races
{
    // INHERITANCE
    public class Shirren : Race
    {
        public override string Title => nameof(Shirren);

        public override string Description => "Once part of a ravenous hive of locust-like predators, the insectile shirrens only recently broke with their hive mind to become a race of telepaths physically addicted to their own individualism, yet dedicated to the idea of community and harmony with other races.";

        public override int HitPoints => 6;

        public override bool HasAdditionalSelection() => false;

        public override List<string> RaceAbilities 
        {
            get
            {
                List<string> abilities = new List<string>();
                abilities.Add("<i>Blindsense</i> Shirrens' sensitive antennae grant them blindsense(vibration) - the ability to sense vibrations in the air - out to 30 feet. A shirren ignores the Stealth bonuses from any form of visual camouflage, invisibility, and the like when attempting a Perception check opposed by a creature's Stealth check.Even on a successful Perception check, any foe that can't be seen still has total concealment(50 % miss chance) against a shirren, and the shirren still has the normal miss chance when attacking foes that have concealment. A shirren is still flat - footed against attacks from creatures it can't see.");
                abilities.Add("<i>Communalism</i> Shirrens are used to working with others as part of a team.Once per day, as long as an ally is within 10 feet, a shirren can roll a single attack roll or skill check twice and take the higher result.");
                abilities.Add("<i>Cultural Fascination</i> Shirrens are eager to learn about new cultures and societies. Shirrens receive a +2 racial bonus to Culture and Diplomacy checks.");
                abilities.Add("<i>Limited Telepathy</i> Shirrens can communicate telepathically with any creatures within 30 feet with whom they share a language. Conversing telepathically with multiple creatures simultaneously is just as difficult as listening to multiple people speak.");
                return abilities;
            }
        }

        public Shirren() : base() 
        {
            // Ability Adjustments: +2 Con, +2 Wis, -2 Cha
            AddAbilityAdjustment(new AbilityAdjustment(AbilityType.Constitution, 2));
            AddAbilityAdjustment(new AbilityAdjustment(AbilityType.Wisdom, 2));
            AddAbilityAdjustment(new AbilityAdjustment(AbilityType.Charisma, -2));
        }
        
        public override void ApplyTo(PlayerCharacter character)
        {
            // Ability Adjustments: +2 Con, +2 Wis, -2 Cha

            // 
            // 
            // 
            // 
        }
    }
}
