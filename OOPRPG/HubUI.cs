using OOPRPG.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OOPRPG
{
    public partial class HubUI : Form
    {
        bool changed = false;
        public HubUI(Player p)
        {
            User = p;
            InitializeComponent();
            txtExp.Text = User.Experience.ToString();
            txtExpNeeded.Text = ((User.Level * (User.Level - 1)) * 50).ToString();
            txt_LVL.Text = User.Level.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            XElement player = new XElement("Player",
                new XElement("Name", User.Name),
                new XElement("Strength", User.Strength),
                new XElement("Dexterity", User.Dexterity),
                new XElement("Constitution", User.Constitution),
                new XElement("Cash", User.Cash),
                new XElement("Experience", User.Experience),
                new XElement("Level", User.Level)
            );
            player.Save("player.xml");
            string createChar = File.ReadAllText("player.xml");
            Console.WriteLine(player);
            Environment.Exit(0);
        }

        public Classes.Player User { get; set; }
        List<Monster> monArray = new List<Monster>();
        static Random rnd = new Random();

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void HubUI_Load(object sender, EventArgs e)
        {
            txtCash.Text = User.Cash.ToString();
            txtHealth.Text = User.Health.ToString();
            txtMaxHealth.Text = Convert.ToString(100 + (User.Constitution * 10)+(User.Level*5));
            XElement element = XElement.Load("..\\..\\Resources\\Monster.xml");
            foreach (XElement item in element.Elements("Monster"))
            {
                string n = (string)item.Element("Name");
                int lvl = (int)item.Element("Level");
                int str = (int)item.Element("Strength");
                int diff = (int)item.Element("Difficulty");
                int con = (int)item.Element("Constitution");
                int dex = (int)item.Element("Dexterity");
                int ap = (int)item.Element("AttkPower");
                double init = (double)item.Element("Initiative");
                Monster mon = new Monster(n, diff, lvl, str, con, dex, ap, init);
                monArray.Add(mon);
            }
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            Player p = User;
            Shop shop = new Shop(p);
            shop.Show();
            this.Hide();
        }

        private void txtMaxHealth_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            Player p = User;
            Inventory inv = new Inventory(p);
            inv.Show();
            this.Hide();
        }

        private void btnBattle_Click(object sender, EventArgs e)
        {
            if  (changed == true)
            {
                int selectDiff = cbxBattle.SelectedIndex + 1;
                List<Monster> monJumble = new List<Monster>();
                foreach (Monster m in monArray)
                {
                    if (m.Difficulty == selectDiff)
                    {
                        monJumble.Add(m);
                    }
                }
                int r = rnd.Next(monJumble.Count);
                Monster mon = monJumble[r];
                Player p = User;
                Battle bat = new Battle(p, mon);
                bat.Show();
                this.Hide();
            }
        }

        private void cbxBattle_SelectedIndexChanged(object sender, EventArgs e)
        {
            changed = true;
        }

    }
}
