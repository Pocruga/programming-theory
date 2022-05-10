namespace Pocruga.OOPT.CharacterSheet.Classes
{
    abstract class CharacterClass : IClass
    {
        private SavingThrows savingThrows;

        public abstract string Titel { get; }

        public abstract string Description { get; }

        public int Level { get; private set; }

        public abstract int HitPoints { get; }

        public abstract int StaminaPoints { get; }

        public abstract int SkillranksperLevel { get; }

        public abstract AbilityType KeyAbility { get; }

        public abstract ArmorProficiency ArmorProficiency { get; }

        public abstract WeaponProficiency WeaponProficiency { get; }

        public SavingThrows SavingThrows => savingThrows;

        protected CharacterClass(SavingThrows savingThrows) 
        {
            this.savingThrows = savingThrows;
            this.Level = 1;
        }
    }
}
