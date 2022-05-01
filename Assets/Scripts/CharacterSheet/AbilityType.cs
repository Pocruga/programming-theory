using System;

namespace Pocruga.OOPT.CharacterSheet 
{
    public enum AbilityType {
        Strength,
        Dexterty,
        Constitution,
        Intelligence,
        Wisdom,
        Charisma
    }

    public static class Extensions {
        public static string GetAbbrev(this AbilityType type) => type switch
        {
            AbilityType.Strength => "STR",
            AbilityType.Dexterty => "DEX",
            AbilityType.Constitution => "CON",
            AbilityType.Intelligence => "INT",
            AbilityType.Wisdom => "WIS",
            AbilityType.Charisma => "CHA",
            _ => throw new ArgumentException($"Unsupported ability: {type}", nameof(type))
        };
    }
}