using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OOPRPG.Classes
{
    public class Player : Entity
    {
        public Player(string name, int str, int con, int dex, int lvl, int cash, int xp)
        {
            Name = name;
            Level = lvl;
            Health = 100 + (10*con) + (lvl*5);
            Strength = str;
            Constitution = con;
            Dexterity = dex;
            Experience = xp;
            Cash = cash;
            List<Item> inven = new List<Item>();
            Inventory = inven;
            List<Item> equipped = new List<Item>();
            EquippedGear = equipped;
            Calculate_SubStats();
        }
        public Player(string name, int str, int con, int dex) {
            Name = name;
            Level = 1;
            Health = 100 + (10 * con)+ 5;
            Strength = str;
            Constitution = con;
            Dexterity = dex;
            Experience = 0;
            Cash = 9999; //For Testing Purposes
            List<Item> inven = new List<Item>();
            Inventory = inven;
            List<Item> equipped = new List<Item>();
            EquippedGear = equipped;
            Calculate_SubStats();
        }
        #region Attributes
        public int Cash { get; set; }
        public int Experience { get; set; }
        public List<Item> Inventory { get; set; }
        public List<Item> EquippedGear { get; set; }
        public int GearDefenseTotal { get; set; }
        public int GearDodgeTotal { get; set; }
        public int GearStrengthMod { get; set; }
        public int GearConstitutionMod { get; set; }
        public int GearDexterityMod { get; set; }
        public double GearDefenseMod { get; set; }
        public double GearDodgeMod { get; set; }
        public double GearCritMod { get; set; }
        public int GearAttPowerMod { get; set; }
        public double GearInitiativeMod { get; set; }
        public double GearCritDmgMod { get; set; }
        public int BattleCounter { get; set; }
        #endregion
        #region Actions/Methods
        public void Calculate_Equip_Bonus()
        {
            foreach (var i in EquippedGear)
            {

            }
        }
        public void Equip(Item i)
        {
            if (i.Equipable)
            {

            }
        }
        #endregion
    }
}
