
namespace OOPRPG.Classes
{
    public class Entity
    {
        #region Attributes
        public string Name { get; set; }
        public int Level { get; set; }
        public int Strength { get; set; }
        public int Constitution { get; set; }
        public int Dexterity { get; set; }
        public int Health { get; set; }
        public int Defense { get; set; }
        public double Dodge { get; set; }
        public double Crit { get; set; }
        public int AttPower { get; set; }
        public double CritDmgMultiplier { get; set; }
        #endregion
        #region Methods
        public void Calculate_SubStats()
        {
            Defense = 1;
            for (int i = 0; i < Dexterity; i++)
            {
                Dodge += .05;
                Crit += .025;
            }
            CritDmgMultiplier = 2;
            AttPower = Strength * 2;
        }
        #endregion

    }
}
