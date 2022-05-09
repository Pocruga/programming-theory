
namespace Pocruga.OOPT.CharacterSheet.Theme
{
    class Spacefarer : Theme
    {
        public override string Title => nameof(Spacefarer);

        public override string Description => $"Your longing to journey among the stars can't be sated. You yearn for the adventure of stepping onto a distant world and exploring its secrets. You tend to greet every new opportunity with bravery and fortitude, confident that your multitude of skills will pull you through. Perhaps you simply find joy in the act of traveling with your companions, or perhaps you are just out to line your pockets with all sorts of alien loot!";
        
        public override string ThemeKnowledge => $"You are obsessed with distant worlds, and you always mentally catalog everything you learn about new and strange places so you can recall it when you need it most. Additionally, you use your knowledge of biology and topology to inure yourself to alien hazards. Reduce the DC of Physical Science checks to recall knowledge about strange new worlds or features of space by 5.";

        public override string Skill => $"Physical Science";

        public override AbilityAdjustment AbilityAdjustment => new AbilityAdjustment(AbilityType.Constitution, 1);

    }
}