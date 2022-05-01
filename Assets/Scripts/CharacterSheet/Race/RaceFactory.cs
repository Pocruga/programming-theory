using System;
using System.Collections.Generic;
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

        public static IRace GetRace(int race)
        {
            return GetRace((RaceType)race);
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

        internal static List<string> GetSubChoiceElements(IRace race)
        {
            RaceType type = (RaceType)Enum.Parse(typeof(RaceType), race.Title);
            switch (type)
            {
                case RaceType.Human:
                    return new List<string>();
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
