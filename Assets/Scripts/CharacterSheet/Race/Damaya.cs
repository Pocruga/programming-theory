
namespace Pocruga.OOPT.CharacterSheet.Race
{
    public class Damaya : Lashunta
    {
        public override string Title => string.Format("{0} ({1})", base.Title, nameof(Damaya));

        public override string Description => string.Format("{0}\n{1}", base.Description, "Damaya lashunta focus their energies on the development of their mind, overloading their brain time and time again during their final stage of puberty as the catalyst of their defining stressor. Their genetics restructure memory cells within their brain during this stage, sacrificing muscle density hormones in return for vastly increased rentition capabilities.");

        public override bool HasAdditionalSelection() => false;
        
        public override void ApplyTo(PlayerCharacter character)
        {
            base.ApplyTo(character);
            // Ability adjusments: +2 INT, -2 CON
        }
    }
}
