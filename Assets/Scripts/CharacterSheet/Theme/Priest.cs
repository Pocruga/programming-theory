using System;

namespace Pocruga.OOPT.CharacterSheet.Theme
{
    class Priest : Theme
    {
        public override string Title => nameof(Priest);

        public override string Description => $"You are a member of an organized religion or similar association. Your belief, whether it has been a part of you since childhood or it came to you later in life, is an integral part of your character. You might travel the stars proselytizing your deity, or your church might have sent you out on a specific holy (or unholy) mission. No matter what obstacles life puts in your way, you always have the conviction of your beliefs to fall back on.";
        
        public override string ThemeKnowledge => $"Choose a deity or a philosophy whose alignment is within one step (on either the good-evil axis or the law-chaos axis) of your own. Reduce the DC of Culture and Mysticism checks to recall knowledge about religious traditions, religious symbols, and famous religious leaders by 5.";

        public override string Skill => $"Mysticism";

        public override AbilityAdjustment AbilityAdjustment => new AbilityAdjustment(AbilityType.Wisdom, 1);

    }
}
