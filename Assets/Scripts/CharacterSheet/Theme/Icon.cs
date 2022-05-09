using System;
using System.Text;

namespace Pocruga.OOPT.CharacterSheet.Theme
{
    class Icon : Theme
    {
        public override string Title => nameof(Icon);

        public override string Description => $"Thanks to interstellar transmissions and Drift travel, the galaxy is smaller than ever, and this connectivity has facilitated your ascension to celebrity status. You might be a famous performer or a celebrated scientist, but either way, you get recognized on the Pact Worlds and in associated systems. Your reason for traveling to unknown worlds might be to further spread your acclaim or to escape the limelight.";
        
        public override string ThemeKnowledge => $"Choose a Profession skill. You are hooked deeply into the culture of your iconic profession. When attempting a Profession or Culture check to recall knowledge about other icons of your profession or details about your profession's cultural aspects, reduce the DC by 5. You gain a +1 bonus to checks with your chosen Profession skill.";

        public override string Skill => $"Culture";

        public override AbilityAdjustment AbilityAdjustment => new AbilityAdjustment(AbilityType.Charisma, 1);

    }
}