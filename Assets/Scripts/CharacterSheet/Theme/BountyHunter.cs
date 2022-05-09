using System;

namespace Pocruga.OOPT.CharacterSheet.Theme
{
    class BountyHunter : Theme
    {
        public override string Title => $"Bounty Hunter";

        public override string Description => $"You track people down for money. It is a dangerous profession, as most of your targets understandably don't wish to be caught. You wouldn't have it any other way. You might have a code of ethics, never taking jobs that, say, target children or members of your own race. You might hunt down only escaped criminals. Or you might be completely amoral, taking any job that comes along - for the right price.";
        
        public override string ThemeKnowledge => $"Your mind is a cold steel trap when it comes to scraps of information about the creatures you're tracking down. Choose a specific sentient creature that you can identify by name, alias, or specific identity to be your mark. Reduce the DC of Culture or Profession (bounty hunter) checks to recall knowledge about your mark, as well as to recall knowledge about law-enforcement individuals and practices, by 5. If you choose a mark that is known only by an alias or secret identity, this ability helps you learn facts only about the identity you know about, not any other unknown identities. Once you defeat your mark, as an action that takes 1 minute, you can study dossiers and database information about another individual to be your new mark. You can instead abandon your mark for a new one without defeating it, but if you do so, you take a –2 penalty to all skill checks for 1 week.";

        public override string Skill => $"Survival";

        public override AbilityAdjustment AbilityAdjustment => new AbilityAdjustment(AbilityType.Constitution, 1);
    }
}
