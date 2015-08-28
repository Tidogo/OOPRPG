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
using System.Xml.Serialization;

namespace OOPRPG
{
    public partial class CharCreation : Form
    {
        public int statCount = 0;
        public int str = 1;
        public int dex = 1;
        public int con = 1;

        public CharCreation()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CharCreation_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;

            if (name == "")
            {
                MessageBox.Show("You need a name friend.");
            }
            else
            {
                if (statCount == 3)
                {
                    Player p = new Player(name, str, con, dex);
                    XElement player = new XElement("Player",
                        new XElement("Name", name),
                        new XElement("Strength", str),
                        new XElement("Dexterity", dex),
                        new XElement("Constitution", con)
                    );
                    player.Save("player.xml");
                    string createChar = File.ReadAllText("player.xml");
                    Console.WriteLine(player);

                    HubUI hubUi = new HubUI(p);
                    hubUi.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("You need to spend three points on stats.");
                }
            }
            

        }

        private void btnAddStr_Click(object sender, EventArgs e)
        {
            if (statCount >= 0 && statCount < 3)
            {
                str = str + 1;
                statCount = statCount + 1;
                txtStatStr.Text = str.ToString();
            }
        }

        private void txtStatStr_TextChanged(object sender, EventArgs e)
        {
            txtStatStr.Text = str.ToString();
        }

        private void txtStatDex_TextChanged(object sender, EventArgs e)
        {
            txtStatDex.Text = dex.ToString();
        }

        private void txtStatCon_TextChanged(object sender, EventArgs e)
        {
            txtStatCon.Text = con.ToString();
        }

        private void btnAddDex_Click(object sender, EventArgs e)
        {
            if (statCount >= 0 && statCount < 3)
            {
                dex = dex + 1;
                statCount = statCount + 1;
                txtStatDex.Text = dex.ToString();
            }
        }

        private void btnSubStr_Click(object sender, EventArgs e)
        {
            if (str > 1)
            {
                str = str - 1;
                statCount = statCount - 1;
                txtStatStr.Text = str.ToString();       
            }
        }

        private void btnSubDex_Click(object sender, EventArgs e)
        {
            if (dex > 1)
            {
                dex = dex - 1;
                statCount = statCount - 1;
                txtStatDex.Text = dex.ToString();
            }
        }

        private void btnAddCon_Click(object sender, EventArgs e)
        {
            if (statCount == 0 || statCount < 3)
            {
                con = con + 1;
                statCount = statCount + 1;
                txtStatCon.Text = con.ToString();
            }
        }

        private void btnSubCon_Click(object sender, EventArgs e)
        {
            if (con > 1)
            {
                con = con - 1;
                statCount = statCount - 1;
                txtStatCon.Text = con.ToString();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            str = 1;
            con = 1;
            dex = 1;
            statCount = 0;
            txtStatStr.Text = str.ToString();
            txtStatCon.Text = con.ToString();
            txtStatDex.Text = dex.ToString();
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            str = 2;
            con = 2;
            dex = 2;
            statCount = 3;
            txtStatStr.Text = str.ToString();
            txtStatCon.Text = con.ToString();
            txtStatDex.Text = dex.ToString();
        }




    }
}
