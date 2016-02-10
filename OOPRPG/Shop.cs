using OOPRPG.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OOPRPG
{
    public partial class Shop : Form
    { 
        public Shop(Player p)
        {
            User = p;
            InitializeComponent();
            txt_Cash.Text = User.Cash.ToString();
            lbo_Inventory.DataSource = User.Inventory;
            lbo_Inventory.DisplayMember = "Name";
            lbo_Inventory.ValueMember = "Value";
        }

        public Classes.Player User { get; set; }
        List<Armor> armors = new List<Armor>();
        List<Weapon> weapons = new List<Weapon>();
        List<Consumable> consumables = new List<Consumable>();

        private void txt_Cash_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Buy_Click(object sender, EventArgs e)
        {
            string fulldetails = lbo_ShopStock.SelectedItem.ToString();
            string name = fulldetails.Substring(0, fulldetails.LastIndexOf(':'));
            int value = Convert.ToInt32(Regex.Match(fulldetails, @"\d+").Value);
            if (lbo_ShopStock.SelectedIndex == -1) {
                MessageBox.Show("Please select an item to buy.");
            }
            else {
                if (value > User.Cash)
            {
                MessageBox.Show("Not Enough Cash!");
            }
            else
            {
                if (armors.Exists(x => x.Name == name))
                {
                    User.Cash -= value;
                    User.Inventory.Add(armors.Find(x => x.Name == name));
                    
                }
                else if (weapons.Exists(x => x.Name == name))
                {
                    User.Cash -= value;
                    User.Inventory.Add(weapons.Find(x => x.Name == name));
                }
                else if (consumables.Exists(x => x.Name == name))
                {
                    User.Cash -= value;
                    User.Inventory.Add(consumables.Find(x => x.Name == name));
                }
                else
                {
                    MessageBox.Show("You shouldn't ever see this. If you do, I messed up.");
                }
                lbo_Inventory.Refresh();
                txt_Cash.Text = User.Cash.ToString();
                lbo_Inventory.DataSource = null;
                lbo_Inventory.DataSource = User.Inventory;
                lbo_Inventory.DisplayMember = "Name";
                lbo_Inventory.ValueMember = "Value";
            }

            }
        }
        private void btn_Sell_Click(object sender, EventArgs e)
        {
            if (lbo_Inventory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item to sell");
            }
            else
            {
                string s = lbo_Inventory.GetItemText(lbo_Inventory.SelectedItem);
                var o = User.Inventory.Find(x => x.Name == s);
                User.Cash += o.Value;
                User.Inventory.Remove(o);
                txt_Cash.Text = User.Cash.ToString();
                lbo_Inventory.DataSource = null;
                lbo_Inventory.DataSource = User.Inventory;
                lbo_Inventory.DisplayMember = "Name";
                lbo_Inventory.ValueMember = "Value";
            }
        }

        private void btn_ExitShop_Click(object sender, EventArgs e)
        {
            Player p = User;
            HubUI hub = new HubUI(p);
            hub.Show();
            this.Hide();
        }

        private void lbo_ShopStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtItemClicked.Text = lbo_ShopStock.SelectedItem.ToString();       
        }

        private void Shop_Load_1(object sender, EventArgs e)
        {
            // need to add the users current inventory to the inv listbox
            //lbo_Inventory.Text = User.Inventory.ToString();
            lbo_ShopStock.Items.Clear();
            XElement element = XElement.Load("..\\..\\Resources\\Armor.xml");
            XElement element2 = XElement.Load("..\\..\\Resources\\Weapon.xml");
            XElement element3 = XElement.Load("..\\..\\Resources\\Consumable.xml");

            foreach (XElement item in element.Elements("Armor"))
            {
                string n = (string)item.Element("Name");
                int d = (int)item.Element("Defense");
                int s = (int)item.Element("Slot");
                int dm = (int)item.Element("DodgeMod");
                int val = (int)item.Element("Value");
                Armor arm = new Armor(n, d, s, dm, val);
                armors.Add(arm);
                lbo_ShopStock.Items.Add(n + ": " + ((val)*5) + "$" );
            }

            foreach (XElement item in element2.Elements("Weapon"))
            {
                string n = (string)item.Element("Name");
                int ap = (int)item.Element("AttkPower");
                bool th = (bool)item.Element("TwoHanded");
                int init = (int)item.Element("Initiative");
                int cc = (int)item.Element("CritChance");
                int cdm = (int)item.Element("CritDmgMod");
                int val = (int)item.Element("Value");
                Weapon wep = new Weapon(n, ap, th, init, cc, cdm, val);
                weapons.Add(wep);
                lbo_ShopStock.Items.Add(n + ": " + ((val) * 5) + "$");
            }

            foreach (XElement item in element3.Elements("Consumable"))
            {
                string n = (string)item.Element("Name");
                int sl = (int)item.Element("StackLimit");
                bool tb = (bool)item.Element("TempBoost");
                int hb = (int)item.Element("HealthBoost");
                int tcb = (int)item.Element("TempCritBoost");
                int tab = (int)item.Element("TempAttackBoost");
                int tdb = (int)item.Element("TempDodgeBoost");
                int tdeb = (int)item.Element("TempDefenseBoost");
                int tib = (int)item.Element("TempInitBoost");
                int nub = (int)item.Element("NumOfBattles");
                int val = (int)item.Element("Value");
                Consumable con = new Consumable(n, sl, tb, hb, tcb, tab, tdb, tdeb, tib, nub, val);
                consumables.Add(con);
                lbo_ShopStock.Items.Add(n + ": " + ((val) * 5) + "$");
            }
        }

        private void lbo_Inventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

    }
}
