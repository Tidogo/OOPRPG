using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPRPG.Classes
{
    public class Consumable : Item
    {
        #region Attributes
        public int HealthBoost { get; set; }
        public int TempCritBoost { get; set; }
        public int TempDodgeBoost { get; set; }
        public int TempAttackBoost { get; set; }
        public int TempDefenseBoost { get; set; }
        public int TempInitBoost { get; set; }
        public int NumOfBattles { get; set; }
        #endregion
        public Consumable(string n, int sl, bool tb, int hb, int tcb, int tab, int tdb, int tdeb, int tib, int nub, int val)
        {
            Name = n;
            StackLimit = sl;
            TempBoost = tb;
            HealthBoost = hb;
            TempCritBoost = tcb;
            TempAttackBoost = tab;
            TempDodgeBoost = tdb;
            TempDefenseBoost = tdeb;
            TempInitBoost = tib;
            NumOfBattles = nub;
            Value = val;
        }
    }
}
