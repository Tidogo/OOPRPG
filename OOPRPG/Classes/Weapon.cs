using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPRPG.Classes
{
    public class Weapon : Item
    {
        #region Attributes
        public int AttkPower { get; set; }
        public bool TwoHanded { get; set; }
        public int Initiative { get; set; }
        public int CritChance { get; set; }
        public int CritDmgMod { get; set; }
        #endregion
        public Weapon(string n, int ap, bool th, int init, int cc, int cdm, int val)
        {
            Equipable = true;
            Name = n;
            AttkPower = ap;
            TwoHanded = th;
            Initiative = init;
            CritChance = cc;
            CritDmgMod = cdm;
            Value = val;
        }
    }
}
