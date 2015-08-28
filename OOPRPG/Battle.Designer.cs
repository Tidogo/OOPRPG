namespace OOPRPG
{
    partial class Battle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Battle));
            this.btn_Flee = new System.Windows.Forms.Button();
            this.btn_Attack = new System.Windows.Forms.Button();
            this.lbo_BattleLog = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bto_Defend = new System.Windows.Forms.Button();
            this.txt_PlayerHP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_UseItem = new System.Windows.Forms.Button();
            this.lbo_Items = new System.Windows.Forms.ListBox();
            this.txt_EnemyHP = new System.Windows.Forms.TextBox();
            this.lbl_EnemyName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Flee
            // 
            this.btn_Flee.Location = new System.Drawing.Point(537, 383);
            this.btn_Flee.Name = "btn_Flee";
            this.btn_Flee.Size = new System.Drawing.Size(75, 46);
            this.btn_Flee.TabIndex = 0;
            this.btn_Flee.Text = "Flee";
            this.btn_Flee.UseVisualStyleBackColor = true;
            this.btn_Flee.Click += new System.EventHandler(this.btn_Flee_Click);
            // 
            // btn_Attack
            // 
            this.btn_Attack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Attack.Location = new System.Drawing.Point(257, 12);
            this.btn_Attack.Name = "btn_Attack";
            this.btn_Attack.Size = new System.Drawing.Size(110, 47);
            this.btn_Attack.TabIndex = 1;
            this.btn_Attack.Text = "Attack";
            this.btn_Attack.UseVisualStyleBackColor = true;
            this.btn_Attack.Click += new System.EventHandler(this.btn_Attack_Click);
            // 
            // lbo_BattleLog
            // 
            this.lbo_BattleLog.BackColor = System.Drawing.Color.Black;
            this.lbo_BattleLog.ForeColor = System.Drawing.Color.Red;
            this.lbo_BattleLog.FormattingEnabled = true;
            this.lbo_BattleLog.Location = new System.Drawing.Point(11, 231);
            this.lbo_BattleLog.Name = "lbo_BattleLog";
            this.lbo_BattleLog.Size = new System.Drawing.Size(282, 199);
            this.lbo_BattleLog.TabIndex = 2;
            this.lbo_BattleLog.SelectedIndexChanged += new System.EventHandler(this.lbo_BattleLog_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Battle Log";
            // 
            // bto_Defend
            // 
            this.bto_Defend.Location = new System.Drawing.Point(257, 118);
            this.bto_Defend.Name = "bto_Defend";
            this.bto_Defend.Size = new System.Drawing.Size(110, 44);
            this.bto_Defend.TabIndex = 4;
            this.bto_Defend.Text = "Defend";
            this.bto_Defend.UseVisualStyleBackColor = true;
            this.bto_Defend.Click += new System.EventHandler(this.bto_Defend_Click);
            // 
            // txt_PlayerHP
            // 
            this.txt_PlayerHP.BackColor = System.Drawing.Color.Lime;
            this.txt_PlayerHP.Location = new System.Drawing.Point(492, 45);
            this.txt_PlayerHP.Name = "txt_PlayerHP";
            this.txt_PlayerHP.Size = new System.Drawing.Size(100, 20);
            this.txt_PlayerHP.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Your HP";
            // 
            // btn_UseItem
            // 
            this.btn_UseItem.Location = new System.Drawing.Point(257, 65);
            this.btn_UseItem.Name = "btn_UseItem";
            this.btn_UseItem.Size = new System.Drawing.Size(110, 47);
            this.btn_UseItem.TabIndex = 7;
            this.btn_UseItem.Text = "Use Item";
            this.btn_UseItem.UseVisualStyleBackColor = true;
            // 
            // lbo_Items
            // 
            this.lbo_Items.BackColor = System.Drawing.Color.Gray;
            this.lbo_Items.FormattingEnabled = true;
            this.lbo_Items.Location = new System.Drawing.Point(492, 118);
            this.lbo_Items.Name = "lbo_Items";
            this.lbo_Items.Size = new System.Drawing.Size(120, 225);
            this.lbo_Items.TabIndex = 8;
            // 
            // txt_EnemyHP
            // 
            this.txt_EnemyHP.BackColor = System.Drawing.Color.Red;
            this.txt_EnemyHP.Location = new System.Drawing.Point(16, 45);
            this.txt_EnemyHP.Name = "txt_EnemyHP";
            this.txt_EnemyHP.Size = new System.Drawing.Size(100, 20);
            this.txt_EnemyHP.TabIndex = 9;
            // 
            // lbl_EnemyName
            // 
            this.lbl_EnemyName.AutoSize = true;
            this.lbl_EnemyName.Location = new System.Drawing.Point(13, 29);
            this.lbl_EnemyName.Name = "lbl_EnemyName";
            this.lbl_EnemyName.Size = new System.Drawing.Size(0, 13);
            this.lbl_EnemyName.TabIndex = 10;
            // 
            // Battle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OOPRPG.Properties.Resources.bg_battle;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.lbl_EnemyName);
            this.Controls.Add(this.txt_EnemyHP);
            this.Controls.Add(this.lbo_Items);
            this.Controls.Add(this.btn_UseItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_PlayerHP);
            this.Controls.Add(this.bto_Defend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbo_BattleLog);
            this.Controls.Add(this.btn_Attack);
            this.Controls.Add(this.btn_Flee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(640, 480);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Battle";
            this.Text = "Battle!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Flee;
        private System.Windows.Forms.Button btn_Attack;
        private System.Windows.Forms.ListBox lbo_BattleLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bto_Defend;
        private System.Windows.Forms.TextBox txt_PlayerHP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_UseItem;
        private System.Windows.Forms.ListBox lbo_Items;
        private System.Windows.Forms.TextBox txt_EnemyHP;
        private System.Windows.Forms.Label lbl_EnemyName;
    }
}