using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPRPG.Classes
{
    public abstract class Item
    {
        #region Attributes
        public string Name { get; set; }
        public int StackLimit { get; set; }
        public bool TempBoost { get; set; }  //a poition or something that gives temp boost
        public bool Equipable { get; set; }  // gear a player can equip
        public int Value { get; set; } //cost to player to buy from store
        #endregion
    }
}
