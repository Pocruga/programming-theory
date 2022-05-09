
namespace Pocruga.OOPT.CharacterSheet.Theme
{
    class Outlaw : Theme
    {
        public override string Title => nameof(Outlaw);

        public override string Description => $"Due to the sins of your past or your current unlawful behavior, you are a wanted individual somewhere in the Pact Worlds. You might not even be guilty and are striving to clear your good name. Or you might fully admit to being a criminal but believe the laws you break are unjust. Whatever the case, boarding a starship headed to the Vast might be just the thing you need until the heat dies down - or until you're dragged off to prison.";
        
        public override string ThemeKnowledge => $"You are well connected to shadowy secrets and back-alley deals, and you both know about key players and have handy skills of your own. Reduce the DC of Culture checks to recall knowledge about the criminal underworld by 5.";

        public override string Skill => $"Sleight of Hand";

        public override AbilityAdjustment AbilityAdjustment => new AbilityAdjustment(AbilityType.Dexterty, 1);

    }
}