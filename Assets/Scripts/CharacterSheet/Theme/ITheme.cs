
namespace Pocruga.OOPT.CharacterSheet.Theme
{
    public interface ITheme 
    {
        //
        string Title { get; }

        //
        string Description { get; }

        //
        string ThemeKnowledge { get; }

        //
        string Skill { get; }

        // a +1 modifier to the themes 
        AbilityAdjustment AbilityAdjustment { get; }

        //
        string GetDisplayText();
    }
}