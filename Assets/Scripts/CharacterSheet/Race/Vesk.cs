
namespace Pocruga.OOPT.CharacterSheet.Race
{
    public class Vesk : IRace
    {
        public string Title => nameof(Vesk);

        public string Description => "Heavily muscled and covered with thick scales and short, sharp horns, the reptilian vesk are exactly as predatory and warlike as they appear. Vesk originally sought to conquer and subdue their stellar neighbors, as they had all the other intelligent races in their own system, until an overwhelming threat forced them into a grudging alliance.";

        public int HitPoints => 6;

        public bool HasAdditionalSelection() => false;

        public void ApplyTo(PlayerCharacter character)
        {
            // Ability Adjustments: +2 Str, +2 Con, -2 Int

            // Fearless - Vesk receive a + 2 racial bonus to saving throws against fear effects.
            // Natural Weapons - Vesk are always considered armed.They can deal 1d3 lethal damage with unarmed strikes and the attack doesn�t count as archaic.Vesk gain a unique weapon specialization with their natural weapons at 3rd level, allowing them to add 1�1 / 2 � their character level to their damage rolls for their natural weapons(instead of just adding their character level, as usual).
            // Low-light Vision - Vesk can see in dim light as if it were normal light.For more details, see page 264.
            // Armor Savant - Vesk use armor in a way that complements their uniquely sturdy physiology. When wearing armor, they gain a + 1 racial bonus to AC. When they�re wearing heavy armor, their armor check penalty is 1 less severe than normal.
        }
    }
}
