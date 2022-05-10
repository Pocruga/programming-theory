namespace Pocruga.OOPT.CharacterSheet.Classes
{
    class Envoy : CharacterClass
    {
        public override string Titel => nameof(Envoy);

        public override string Description => $"You make your way in the universe with a charming smile, quick wit, and keen sense of self-preservation, and excel at getting others to do what you want. You might be a trickster, hustler, or con artist, or you might serve as an actor, ambassador, or businessperson, paving the way for negotiation through kind words or the occasional dirty trick. You are often the group's strategist, using your quick wit and tactical acumen to push your friends to greater heights. You may also be skilled in diplomacy, serving as the face for a starship crew, talking your way into restricted systems or gaining audiences with local politicians or warlords.";

        // core-rulebook 6; hero-handbook 12
        public override int HitPoints => 6;

        // core-rulebook
        public override int StaminaPoints => 6;

        // core-rulebook
        public override int SkillranksperLevel => 8;

        // core-rulebook; hero-handbook
        public override AbilityType KeyAbility => AbilityType.Charisma;

        // core-rulebook; hero-handbook
        public override ArmorProficiency ArmorProficiency => ArmorProficiency.LightArmor;

        // core-rulebook; hero-handbook
        public override WeaponProficiency WeaponProficiency => WeaponProficiency.BasicMeleeWeapon|WeaponProficiency.Grenades|WeaponProficiency.SmallArms;

        // core-rulebook; hero-handbook
        public Envoy() : base(new SavingThrows(0,2,2))
        {
        }
    }
}
