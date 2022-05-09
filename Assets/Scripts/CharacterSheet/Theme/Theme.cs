using System.Text;

namespace Pocruga.OOPT.CharacterSheet.Theme
{
    abstract class Theme : ITheme
    {
        public abstract string Title { get; }

        public abstract string Description { get; }
        
        public abstract string ThemeKnowledge { get; }

        public abstract string Skill  { get; }

        public abstract AbilityAdjustment AbilityAdjustment { get; }

        public virtual string GetDisplayText() 
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(Description).Append("\n\n");
            builder.Append($"<b>{Title}-Knowledge:</b>\n");
            builder.Append(ThemeKnowledge).Append("\n\n");
            builder.Append($"<b>Class Skill:</b> ").Append(Skill);
            return builder.ToString();
        }
    }
}