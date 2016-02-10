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

namespace OOPRPG
{
    public partial class LevelUp : Form
    {
        public LevelUp(Player p)
        {
            User = p;
            InitializeComponent();
        }
        public Classes.Player User { get; set; }

        private void btn_StrPlus_Click(object sender, EventArgs e)
        {
            Player p = User;
            User.Strength += 1;
            
            User.Level += 1;
            User.Health = 100 + (10 * User.Constitution) + (User.Level * 5);
            p.Calculate_SubStats();
            HubUI hub = new HubUI(p);
            hub.Show();
            this.Close();
        }

        private void btn_ConPlus_Click(object sender, EventArgs e)
        {
            Player p = User;
            User.Constitution += 1;
            
            User.Level += 1;
            User.Health = 100 + (10 * User.Constitution) + (User.Level * 5);
            p.Calculate_SubStats();
            HubUI hub = new HubUI(p);
            hub.Show();
            this.Close();
        }

        private void btn_DexPlus_Click(object sender, EventArgs e)
        {
            Player p = User;
            User.Dexterity += 1;
            
            User.Level += 1;
            User.Health = 100 + (10 * User.Constitution) + (User.Level * 5);
            p.Calculate_SubStats();
            HubUI hub = new HubUI(p);
            hub.Show();
            this.Close();
        }
    }
}
