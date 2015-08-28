using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPRPG.Classes
{
    public class Monster : Entity
    {
        public Monster(string n, int diff, int lvl, int str, int con, int dex, int ap, double init)
        {
            Name = n;
            Level = lvl;
            Difficulty = diff;
            Health = (10 * con) + (lvl * 5);
            Strength = str;
            Constitution = con;
            Dexterity = dex;
            AttPower = ap;
            Initiative = init;
            RndCashLoot = lvl + (10 * diff);
            ExperienceValue = lvl * 10;
            LootSeedValue = lvl * 10;
            Calculate_SubStats();
        }
        #region Attributes
        public int LootSeedValue { get; set; }
        public int ExperienceValue { get; set; }
        public int RndCashLoot { get; set; }
        public int Difficulty { get; set; }
        #endregion

        public double Initiative { get; set; }
    }
}
