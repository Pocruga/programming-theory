
namespace Pocruga.OOPT.CharacterSheet.Race
{
    public class Koresha : Lashunta
    {
        public override string Title => string.Format("{0} ({1})", base.Title, nameof(Koresha));

        public override string Description => string.Format("{0}\n{1}",base.Description, "Korasha endure brutal physical hardship. In ancient times, each village, town or city would have a specific rite of passage - usually involving surviving in Castrovel's wilderness for a time. Korasha would often spend a year or two preparing themselves for this potentially deadly ritual, plundering the libraries of knowledge offered by the damaya. The ritual often lasted several months, during which time exhaustion left no time for creative thinking - relying instead on age-old methods and counterstrategies generations old. In modern times, however, the korasha are able to simulate this ritual with magic, heavily laced with various technology like holograms and artificial gravity.");

        public override bool HasAdditionalSelection() => false;

        public override void ApplyTo(PlayerCharacter character)
        {
            base.ApplyTo(character);
            // Ability adjusments: +2 STR, -2 WIS
        }
    }
}
