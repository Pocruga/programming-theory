using System;
using System.Collections.Generic;
using System.Linq;

namespace Pocruga.OOPT.CharacterSheet.Theme
{

    public class ThemeFactory
    {
        public static ITheme GetTheme(string theme) 
        {
            if(Enum.TryParse<ThemeType>(theme, out ThemeType themeType))
                return GetTheme(themeType);
            throw new ArgumentException($"Unsupported theme: {theme}", nameof(theme));
        }

        public static ITheme GetTheme(int theme) 
        {
            return GetTheme((ThemeType)theme);
        }

        static ITheme GetTheme(ThemeType theme) => theme switch 
        {
            
            ThemeType.Icon => new Icon(),
            ThemeType.Priest => new Priest(),
            ThemeType.Outlaw => new Outlaw(),
            ThemeType.BountyHunter => new BountyHunter(),
            ThemeType.Spacefarer => new Spacefarer(),
            ThemeType.Mercenary => new Mercenary(),
            _ => throw new ArgumentException($"Unsupported theme: {theme}", nameof(theme))
        };
    }

    enum ThemeType {
        Icon,
        Priest,
        Outlaw,
        BountyHunter,
        Spacefarer,
        Mercenary
    }
}
