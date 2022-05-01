namespace Pocruga.OOPT.CharacterSheet.Race
{
    public class Ysoki : Race
    {
        public override string Title => nameof(Ysoki);

        public override string Description => "Small and furtive, the ysoki are often overlooked by larger races. Yet through wit and technological prowess, they have spread throughout the Solar system, giving truth to the old adage that every starship needs a few rats.";

        public override int HitPoints => 2;

        public override bool HasAdditionalSelection() => false;

        public override void ApplyTo(PlayerCharacter character)
        {
            // Ability Adjustments: +2 Dex + 2 Int �2 Str

            // Darkvision - Ysoki can see up to 60 feet in the dark. See page 263 for more information.
            // Moxie - Ysoki are scrappy and nimble even when the odds are against them. A ysoki can stand from prone as a swift action. Additionally, when off-kilter(see page 276), a ysoki does not take the normal penalties to attacks or gain the flat-footed condition.When attempting an Acrobatics check to tumble through the space of an opponent at least one size category larger than himself, a ysoki receive a +5 racial bonus to the check.
            // Scrounger - Ysoki receive a + 2 racial bonus to Engineering, Stealth, and Survival checks.
            // Cheek Pouches - Ysoki can store up to 1 cubic foot of items weighing up to 1 bulk in total in their cheek pouches, and they can transfer a single object between hand and cheek as a swift action. A ysoki can disgorge the entire contents of his pouch onto the ground in his square as a move action that does not provoke an attack of opportunity.
        }
    }
}
