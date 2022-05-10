
namespace Pocruga.OOPT.CharacterSheet.Classes
{
    public interface IClass
    {
        string Titel { get; }

        string Description { get; }

        int Level { get; }

        int HitPoints { get; }

        int StaminaPoints { get; }

        int SkillranksperLevel { get; }

        AbilityType KeyAbility { get; }

        ArmorProficiency ArmorProficiency { get; }

        WeaponProficiency WeaponProficiency { get; }

        SavingThrows SavingThrows { get; }
    }
}
