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
    public partial class Battle : Form
    {
        public Battle(Player p, Monster m)
        {
            User = p;
            Mon = m;
            InitializeComponent();
            txt_PlayerHP.Text = User.Health.ToString();
            txt_EnemyHP.Text = Mon.Health.ToString();
            lbl_EnemyName.Text = Mon.Name;

            foreach (var i in User.Inventory)
            {
                if (!i.Equipable)
                {
                    lbo_Items.Items.Add(i.Name);
                }
            }
        }
        public Classes.Player User { get; set; }
        public Classes.Monster Mon { get; set; }
        private String aar;
        static Random rnd = new Random();
        private void btn_Attack_Click(object sender, EventArgs e)
        {
            double monDmg = Mon.AttPower;
            double userDmg = User.AttPower;
            if (rnd.Next(1, 100) < User.Crit*100 )
            {
                userDmg = User.AttPower * 2;
            }
            if (rnd.Next(1, 100) < Mon.Crit*100)
            {
               monDmg = Mon.AttPower * 2;
            }
                if (monDmg >= User.Health)
                {
                    User.Health = 0;
                    aar = Mon.Name + " inflicted a near-fatal blow on " + User.Name + "!";
                    lbo_BattleLog.Items.Add(aar);
                    User.Health = 1;
                    User.Experience = User.Experience - Mon.ExperienceValue;
                    MessageBox.Show(User.Name + " barely makes it away in one piece. Be more careful next time!");
                    Player p = User;
                    HubUI newHub = new HubUI(p);
                    newHub.Show();
                    this.Close();
                }
                else if (userDmg >= Mon.Health)
                {
                        aar = User.Name + " inflicted a fatal blow on " + Mon.Name + "!";
                        lbo_BattleLog.Items.Add(aar);
                        User.Experience = User.Experience + Mon.ExperienceValue;
                        User.Cash += Mon.RndCashLoot;
                        MessageBox.Show(User.Name + " vanquished the " + Mon.Name + "! You gain " 
                    + Mon.ExperienceValue + "XP and " + Mon.RndCashLoot + " bucks!");
                        if (User.Experience >= ((User.Level * (User.Level - 1)) * 50))
                        {
                            Player p = User;
                            LevelUp lvlup = new LevelUp(p);
                            lvlup.Show();
                            this.Close();
                        }
                        else
                        {
                            Player p = User;
                            HubUI hub = new HubUI(p);
                            hub.Show();
                            this.Close();
                        }
                }
                else
                {
                    Mon.Health -= Convert.ToInt32((userDmg - (Mon.Defense * 1.0)));
                    aar = User.Name + " hit " + Mon.Name + " for " + User.AttPower + " DMG!";
                    lbo_BattleLog.Items.Add(aar);
                    User.Health -= Convert.ToInt32((monDmg - (User.Defense * 1.0)));
                    aar = Mon.Name + " hit " + User.Name + " for " + Mon.AttPower + " DMG!";
                    lbo_BattleLog.Items.Add(aar);
                    txt_PlayerHP.Text = User.Health.ToString();
                    txt_EnemyHP.Text = Mon.Health.ToString();
                    monDmg = Mon.AttPower;
                    userDmg = User.AttPower;
                }
            }
            

        private void lbo_BattleLog_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bto_Defend_Click(object sender, EventArgs e)
        {
            double monDmg = Mon.AttPower;
            if (rnd.Next(1, 100) < Mon.Crit * 100)
            {
                monDmg = Mon.AttPower * 2;
            }
            User.Health -= Convert.ToInt32((monDmg - (User.Defense * 2.0)));
            aar = Mon.Name + " hit " + User.Name + " for " + (monDmg - (User.Defense * 2.0)) + " DMG!";
            lbo_BattleLog.Items.Add(aar);
            txt_PlayerHP.Text = User.Health.ToString();
            txt_EnemyHP.Text = Mon.Health.ToString();
            monDmg = Mon.AttPower;
        }

        private void btn_Flee_Click(object sender, EventArgs e)
        {
            double monDmg = Mon.AttPower;
            if ((User.GearInitiativeMod + (User.Dexterity * 3)) < ((Mon.Dexterity * 3) + Mon.Initiative))
            {
                User.Health -= Convert.ToInt32((monDmg - (User.Defense * 2.0)));
                aar = Mon.Name + " hit " + User.Name + " for " + (monDmg - (User.Defense * 2.0)) + " DMG!";
                MessageBox.Show(User.Name + " took a hit but ran away from the " + Mon.Name);
                Player p = User;
                HubUI hub = new HubUI(p);
                hub.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show(User.Name + " ran away from the " + Mon.Name + " before getting hit!");
                Player p = User;
                HubUI hub = new HubUI(p);
                hub.Show();
                this.Close();
            }
        }
    }
}
