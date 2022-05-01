
namespace Pocruga.OOPT.CharacterSheet.Race
{
    public class Damaya : Lashunta
    {
        public override string Title => $"{base.Title} ({nameof(Damaya)})";

        public override string Description => $"{base.Description}\nDamaya lashunta focus their energies on the development of their mind, overloading their brain time and time again during their final stage of puberty as the catalyst of their defining stressor. Their genetics restructure memory cells within their brain during this stage, sacrificing muscle density hormones in return for vastly increased rentition capabilities.";

        public override bool HasAdditionalSelection() => false;
        
        protected override sealed string AbilityAdjustmentsUncomplete => string.Empty;

        public Damaya() : base() 
        {
            // Ability adjusments: +2 INT, -2 CON
            AddAbilityAdjustment(new AbilityAdjustment(AbilityType.Intelligence, 2));
            AddAbilityAdjustment(new AbilityAdjustment(AbilityType.Constitution, -2));
        }
        public override void ApplyTo(PlayerCharacter character)
        {
            base.ApplyTo(character);
        }
    }
}
