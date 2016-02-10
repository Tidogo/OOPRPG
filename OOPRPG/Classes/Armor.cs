using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPRPG.Classes
{
    public class Armor : Item
    {
        #region Attributes
        public int Defense { get; set; }
        public int Slot { get; set; }
        public int DodgeMod { get; set; }
        #endregion
        public Armor(string n, int d, int s, int dm, int val)
        {
            Name = n;
            Defense = d;
            Slot = s;
            DodgeMod = dm;
            Value = val;
            Equipable = true;
        }

        public Armor()
        {
        }
    }
}
