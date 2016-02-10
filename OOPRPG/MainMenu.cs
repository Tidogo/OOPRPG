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

    public partial class frm_MainMenu : Form
    {

        public frm_MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_newchar_Click(object sender, EventArgs e)
        {
            CharCreation charC = new CharCreation();
            charC.Show();
            this.Hide();
        }

        private void btn_loadgame_Click(object sender, EventArgs e)
        {
            try
            {
                XElement plyr = XElement.Load("Player.xml");
                string name = (string)plyr.Element("Name");
                int str = (int)plyr.Element("Strength");
                int con = (int)plyr.Element("Constitution");
                int dex = (int)plyr.Element("Dexterity");
                int lvl = (int)plyr.Element("Level");
                int cash = (int)plyr.Element("Cash");
                int xp = (int)plyr.Element("Experience");
                Player p = new Player(name, str, con, dex, lvl, cash, xp);
                HubUI hubUi = new HubUI(p);
                hubUi.User = p;
                hubUi.Show();
                Hide();
            }
            catch
            {
                throw new NullReferenceException("No character to load!");
            }
        }
    }
}
