namespace Pocruga.OOPT.CharacterSheet 
{
    public class SavingThrows {

        private int fortitude, reflex, will;

        public int Fortitude => fortitude;

        public int Reflex => reflex;

        public int Will => will;

        public SavingThrows(int fortitude, int reflex, int will) 
        {
            this.fortitude = fortitude;
            this.reflex = reflex;
            this.will = will;
        }
    }
}