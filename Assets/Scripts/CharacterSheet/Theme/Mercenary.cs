
namespace Pocruga.OOPT.CharacterSheet.Theme
{
    class Mercenary : Theme
    {
        public override string Title => nameof(Mercenary);

        public override string Description => $"Whether you take jobs that match your ethical beliefs or you fight for anyone who can afford your services, you are a hired gun. You might take pride in your past accomplishments, proudly displaying trophies of your kills, or you might be laden with guilt over being the sole survivor of a mission gone terribly wrong. You most likely work with other mercenaries and are familiar with the methodologies of military actions all across the galaxy.";
        
        public override string ThemeKnowledge => $"You are knowledgeable about the military, from rival mercenary groups to standard military procedures to planetary armed forces, and you can draw upon this fount of information to aid your adventurous pursuits. Reduce the DC of Culture checks and Profession (mercenary) checks to recall knowledge about hierarchies, practices, personnel, and so on in the military by 5.";

        public override string Skill => $"Athletics";

        public override AbilityAdjustment AbilityAdjustment => new AbilityAdjustment(AbilityType.Strength, 1);

    }
}