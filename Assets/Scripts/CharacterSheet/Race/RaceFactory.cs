using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

namespace Pocruga.OOPT.CharacterSheet.Race
{
    public class RaceFactory 
    {
        public static IRace GetRace(string race)
        {
            if(Enum.TryParse<RaceType>(race, out RaceType raceType))
                return GetRace(raceType);
            throw new ArgumentException($"Unsupported race: {race}", nameof(race));
        }

        public static IRace GetRace(string race, string additionalInfo)
        {
            if(Enum.TryParse<RaceType>(race, out RaceType raceType))
                return GetRace(raceType, additionalInfo);
            throw new ArgumentException($"Unsupported race: {race}", nameof(race));
        }

        private static IRace GetRace(RaceType race) => race switch
        {
            RaceType.Android => new Android(),
            RaceType.Human => new Human(),
            RaceType.Lashunta => new Lashunta(),
            RaceType.Shirren => new Shirren(),
            RaceType.Vesk => new Vesk(),
            RaceType.Ysoki => new Ysoki(),
            _ => throw new ArgumentException($"Unsupported race: {race}", nameof(race))
        };

        private static IRace GetRace(RaceType race, string additional) 
        {
            if(string.IsNullOrEmpty(additional))
                return GetRace(race);
            
            switch(race) {
                case RaceType.Human:
                    Human human = new Human();
                    human.SetAbilityToAdjust(additional);
                    return human;
                case RaceType.Lashunta:
                    return Lashunta.GetSubRace(additional);
            }
            throw new ArgumentException($"Unsupported race: {race}", nameof(race));
        }

        internal static List<string> GetSubChoiceElements(IRace race)
        {
            RaceType type = (RaceType)Enum.Parse(typeof(RaceType), race.Title);
            switch (type)
            {
                case RaceType.Human:
                    return Enum.GetNames(typeof(AbilityType)).ToList();
                case RaceType.Lashunta:
                    return Lashunta.GetSubRaces();
                default:
                    return new List<string>();
            }
        }
    }

    enum RaceType
    {
        Android,
        Human,
        Lashunta,
        Shirren,
        Vesk,
        Ysoki
    }
}
