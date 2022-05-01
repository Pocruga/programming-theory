
using System.Collections.Generic;

namespace Pocruga.OOPT.CharacterSheet.Race
{
    public class Lashunta : IRace
    {
        public virtual string Title => nameof(Lashunta);

        public virtual string Description => "Idealized by many other humanoid races and gifted with innate psychic abilities, lashuntas are at once consummate scholars and enlightened warriors, naturally divided into two specialized subraces with different abilities and societal roles.";

        public virtual bool HasAdditionalSelection() => true;

        public int HitPoints => 4;


        public virtual void ApplyTo(PlayerCharacter character)
        {
            // ability adjusments: +2 CHA
            //      Subrace Koresha: +2 STR, -2 WIS
            //      Subrace Damaya: +2 INT, -2 CON

            // Lashunta Magic - Lashuntas gain the following spell-like abilities:
            //          * At will: daze, psychokinetic hand
            //          * 1 / day: detect thoughts
            //      See Spell-like Abilities.The caster level for these effects is equal to the lashunta's level.
            // Limited Telepathy - Lashuntas can mentally communicate with any creatures within 30 feet with whom they share a language. Conversing telepathically with multiple creatures simultaneously is just as difficult as listening to multiple people speaking.
            // Student - Lashuntas love to learn, and they receive a +2 racial bonus to any two skills of their choice.
        }

        public static List<string> GetSubRaces()
        {
            return new List<string>() { nameof(SubRace.Koresha), nameof(SubRace.Damaya) };
        }

        private enum SubRace
        {
            Damaya,
            Koresha
        }
    }
}
