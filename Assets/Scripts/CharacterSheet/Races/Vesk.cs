using System.Collections.Generic;

namespace Pocruga.OOPT.CharacterSheet.Races
{
    public class Vesk : Race
    {
        public override string Title => nameof(Vesk);

        public override string Description => "Heavily muscled and covered with thick scales and short, sharp horns, the reptilian vesk are exactly as predatory and warlike as they appear. Vesk originally sought to conquer and subdue their stellar neighbors, as they had all the other intelligent races in their own system, until an overwhelming threat forced them into a grudging alliance.";

        public override int HitPoints => 6;

        public override bool HasAdditionalSelection() => false;

        public override List<string> RaceAbilities 
        { 
            get
            {
                List<string> abilities = new List<string>();
                abilities.Add("<i>Fearless</i> Vesk receive a +2 racial bonus to saving throws against fear effects.");
                abilities.Add("<i>Natural Weapons</i> Vesk are always considered armed. They can deal 1d3 lethal damage with unarmed strikes and the attack doesn't count as archaic. Vesk gain a unique weapon specialization with their natural weapons at 3rd level, allowing them to add 1 - 1/2 * their character level to their damage rolls for their natural weapons(instead of just adding their character level, as usual).");
                abilities.Add("<i>Low-light Vision</i> Vesk can see in dim light as if it were normal light.");
                abilities.Add("<i>Armor Savant</i> Vesk use armor in a way that complements their uniquely sturdy physiology. When wearing armor, they gain a +1 racial bonus to AC. When they're wearing heavy armor, their armor check penalty is 1 less severe than normal.");
                return abilities; 
            } 
        }

        public Vesk() : base() 
        {
            // Ability Adjustments: +2 Str, +2 Con, -2 Int
            AddAbilityAdjustment(new AbilityAdjustment(AbilityType.Strength, 2));
            AddAbilityAdjustment(new AbilityAdjustment(AbilityType.Constitution, 2));
            AddAbilityAdjustment(new AbilityAdjustment(AbilityType.Intelligence, -2));
        }

        public override void ApplyTo(PlayerCharacter character)
        {
            // 
            // 
            // 
            // 
        }
    }
}
