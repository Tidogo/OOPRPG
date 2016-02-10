using OOPRPG.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OOPRPG
{
    public partial class Inventory : Form
    {
        XElement element = XElement.Load("..\\..\\Resources\\Armor.xml");
        XElement element2 = XElement.Load("..\\..\\Resources\\Weapon.xml");
        XElement element3 = XElement.Load("..\\..\\Resources\\Consumable.xml");

        public Inventory(Player p)
        {

            User = p;
            InitializeComponent();
            txt_Cash.Text = User.Cash.ToString();
            foreach (var i in User.Inventory)
            {
                if (!i.Equipable)
                {
                    lbx_Backpack.Items.Add(i.Name);
                }
                else
                {
                    foreach (XElement item in element.Elements("Armor"))
                    {
                        string n = (string)item.Element("Name");
                        int d = (int)item.Element("Defense");
                        int s = (int)item.Element("Slot");
                        int dm = (int)item.Element("DodgeMod");
                        int val = (int)item.Element("Value");

                        if (i.Name == (string)item.Element("Name"))
                        {
                            if (s == 1)
                            {
                                cbx_Head.Items.Add(i.Name);
                            }
                            else if (s == 2)
                            {
                                cbx_Chest.Items.Add(i.Name);
                            }
                            else if (s == 3)
                            {
                                cbx_Legs.Items.Add(i.Name);
                            }
                            else if (s == 4)
                            {
                                cbx_LeftHand.Items.Add(i.Name);
                            }
                        }
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

                        if (i.Name == (string)item.Element("Name"))
                        {
                            cbx_RightHand.Items.Add(i.Name);
                        }
                    }
                }
            }
        }

        public Classes.Player User { get; set; }

        private void txt_Cash_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Player p = User;
            HubUI hub = new HubUI(p);
            hub.Show();
            this.Hide();
        }

        private void cbx_RightHand_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (XElement item in element2.Elements("Weapon"))
            {
                string n = (string)item.Element("Name");
                int ap = (int)item.Element("AttkPower");
                bool th = (bool)item.Element("TwoHanded");
                int init = (int)item.Element("Initiative");
                int cc = (int)item.Element("CritChance");
                int cdm = (int)item.Element("CritDmgMod");
                int val = (int)item.Element("Value");

                if (cbx_RightHand.Text == (string)item.Element("Name"))
                {
                    if (th == true)
                    {
                        cbx_LeftHand.Text = cbx_RightHand.Text;
                    }
                }
            }
        }
    }
}
