
using System;
using System.Collections.Generic;
using System.Text;

namespace Pocruga.OOPT.CharacterSheet.Races
{
    // INHERITANCE
    public class Lashunta : Race
    {
        public override string Title => nameof(Lashunta);

        public override string Description => "Idealized by many other humanoid races and gifted with innate psychic abilities, lashuntas are at once consummate scholars and enlightened warriors, naturally divided into two specialized subraces with different abilities and societal roles.";

        public override bool HasAdditionalSelection() => true;

        public override int HitPoints => 4;

        // ability adjusments: +2 CHA; Subrace Koresha: +2 STR, -2 WIS; Subrace Damaya: +2 INT, -2 CON
        public override string AbilityAdjustments => $"{base.AbilityAdjustments}{AbilityAdjustmentsIncomplete}";

        // to override by sub race class 
        protected virtual string AbilityAdjustmentsIncomplete {
            get {
                StringBuilder builder = new StringBuilder();
                builder.Append("\n * <i>Koresha</i> Lashuntas have additional +2 STR, -2 WIS");
                builder.Append("\n * <i>Damaya</i> Lashuntas have additional +2 INT, -2 CON");
                return builder.ToString();
            }
        }

        // ENCAPSULATION
        public override List<string> RaceAbilities
        {
            get
            {
                List<string> abilities = new List<string>();
                abilities.Add("<i>Lashunta Magic</i> Lashuntas gain the following spell-like abilities:\n\t<i>At will:</i> daze, psychokinetic hand\n\t<i>1/day:</i> detect thoughts\nSee Spell-like Abilities. The caster level for these effects is equal to the lashunta's level.");
                abilities.Add("<i>Limited Telepathy</i> Lashuntas can mentally communicate with any creatures within 30 feet with whom they share a language. Conversing telepathically with multiple creatures simultaneously is just as difficult as listening to multiple people speaking.");
                abilities.Add("<i>Student</i> Lashuntas love to learn, and they receive a +2 racial bonus to any two skills of their choice.");
                return abilities;
            }
        }


        public Lashunta() {
            // each Lashunta has an ability adjusment of +2 CHA
            AddAbilityAdjustment(new AbilityAdjustment(AbilityType.Charisma, 2));
        }

        public override void ApplyTo(PlayerCharacter character)
        {
            // TODO implement it
        }

        public static List<string> GetSubRaces()
        {
            return new List<string>() { nameof(SubRace.Koresha), nameof(SubRace.Damaya) };
        }

        internal static IRace GetSubRace(string race) {
            if(Enum.TryParse<SubRace>(race, out SubRace subRace)) {
                if(SubRace.Damaya == subRace)
                    return new Damaya();

                if(SubRace.Koresha == subRace)
                    return new Koresha();
            }
            throw new ArgumentException($"Unsupported sub race of Lashunta: {race}", nameof(race));
        }

        private enum SubRace
        {
            Damaya,
            Koresha
        }
    }
}
