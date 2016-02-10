namespace OOPRPG
{
    partial class HubUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HubUI));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnBattle = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.lblCash = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.txtHealth = new System.Windows.Forms.TextBox();
            this.cbxBattle = new System.Windows.Forms.ComboBox();
            this.txtMaxHealth = new System.Windows.Forms.TextBox();
            this.txtExp = new System.Windows.Forms.TextBox();
            this.lblExp = new System.Windows.Forms.Label();
            this.lblNextLvl = new System.Windows.Forms.Label();
            this.txtExpNeeded = new System.Windows.Forms.TextBox();
            this.txt_LVL = new System.Windows.Forms.TextBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(377, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Save/Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(41, 133);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(75, 23);
            this.btnInventory.TabIndex = 1;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnBattle
            // 
            this.btnBattle.Location = new System.Drawing.Point(348, 203);
            this.btnBattle.Name = "btnBattle";
            this.btnBattle.Size = new System.Drawing.Size(75, 23);
            this.btnBattle.TabIndex = 2;
            this.btnBattle.Text = "Battle";
            this.btnBattle.UseVisualStyleBackColor = true;
            this.btnBattle.Click += new System.EventHandler(this.btnBattle_Click);
            // 
            // btnShop
            // 
            this.btnShop.Location = new System.Drawing.Point(41, 210);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(75, 23);
            this.btnShop.TabIndex = 3;
            this.btnShop.Text = "Shop";
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // txtCash
            // 
            this.txtCash.Location = new System.Drawing.Point(62, 6);
            this.txtCash.Name = "txtCash";
            this.txtCash.ReadOnly = true;
            this.txtCash.Size = new System.Drawing.Size(100, 20);
            this.txtCash.TabIndex = 4;
            this.txtCash.Text = "Player Cash Total";
            this.txtCash.TextChanged += new System.EventHandler(this.txtCash_TextChanged);
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Location = new System.Drawing.Point(12, 9);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(31, 13);
            this.lblCash.TabIndex = 5;
            this.lblCash.Text = "Cash";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Location = new System.Drawing.Point(12, 43);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(38, 13);
            this.lblHealth.TabIndex = 6;
            this.lblHealth.Text = "Health";
            // 
            // txtHealth
            // 
            this.txtHealth.Location = new System.Drawing.Point(62, 40);
            this.txtHealth.Name = "txtHealth";
            this.txtHealth.ReadOnly = true;
            this.txtHealth.Size = new System.Drawing.Size(54, 20);
            this.txtHealth.TabIndex = 7;
            this.txtHealth.Text = "Player Health Total";
            // 
            // cbxBattle
            // 
            this.cbxBattle.AutoCompleteCustomSource.AddRange(new string[] {
            "Level 1",
            "Level 2",
            "Level 3",
            "Level 4"});
            this.cbxBattle.FormattingEnabled = true;
            this.cbxBattle.Items.AddRange(new object[] {
            "Can I play, Daddy?",
            "Don\'t Hurt Me.",
            "Bring \'Em On!",
            "I AM DEATH INCARNATE!"});
            this.cbxBattle.Location = new System.Drawing.Point(317, 232);
            this.cbxBattle.Name = "cbxBattle";
            this.cbxBattle.Size = new System.Drawing.Size(144, 21);
            this.cbxBattle.TabIndex = 8;
            this.cbxBattle.Text = "Please Choose Level";
            this.cbxBattle.SelectedIndexChanged += new System.EventHandler(this.cbxBattle_SelectedIndexChanged);
            // 
            // txtMaxHealth
            // 
            this.txtMaxHealth.Location = new System.Drawing.Point(122, 40);
            this.txtMaxHealth.Name = "txtMaxHealth";
            this.txtMaxHealth.ReadOnly = true;
            this.txtMaxHealth.Size = new System.Drawing.Size(54, 20);
            this.txtMaxHealth.TabIndex = 9;
            this.txtMaxHealth.Text = "Max \r\nPlayer Health Total";
            this.txtMaxHealth.TextChanged += new System.EventHandler(this.txtMaxHealth_TextChanged);
            // 
            // txtExp
            // 
            this.txtExp.Location = new System.Drawing.Point(329, 74);
            this.txtExp.Name = "txtExp";
            this.txtExp.ReadOnly = true;
            this.txtExp.Size = new System.Drawing.Size(118, 20);
            this.txtExp.TabIndex = 10;
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.Location = new System.Drawing.Point(374, 58);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(25, 13);
            this.lblExp.TabIndex = 11;
            this.lblExp.Text = "Exp";
            // 
            // lblNextLvl
            // 
            this.lblNextLvl.AutoSize = true;
            this.lblNextLvl.Location = new System.Drawing.Point(356, 105);
            this.lblNextLvl.Name = "lblNextLvl";
            this.lblNextLvl.Size = new System.Drawing.Size(58, 13);
            this.lblNextLvl.TabIndex = 12;
            this.lblNextLvl.Text = "Next Level";
            // 
            // txtExpNeeded
            // 
            this.txtExpNeeded.Location = new System.Drawing.Point(329, 121);
            this.txtExpNeeded.Name = "txtExpNeeded";
            this.txtExpNeeded.ReadOnly = true;
            this.txtExpNeeded.Size = new System.Drawing.Size(118, 20);
            this.txtExpNeeded.TabIndex = 13;
            // 
            // txt_LVL
            // 
            this.txt_LVL.Location = new System.Drawing.Point(62, 74);
            this.txt_LVL.Name = "txt_LVL";
            this.txt_LVL.ReadOnly = true;
            this.txt_LVL.Size = new System.Drawing.Size(50, 20);
            this.txt_LVL.TabIndex = 14;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(12, 77);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(33, 13);
            this.lblLevel.TabIndex = 15;
            this.lblLevel.Text = "Level";
            // 
            // HubUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.txt_LVL);
            this.Controls.Add(this.txtExpNeeded);
            this.Controls.Add(this.lblNextLvl);
            this.Controls.Add(this.lblExp);
            this.Controls.Add(this.txtExp);
            this.Controls.Add(this.txtMaxHealth);
            this.Controls.Add(this.cbxBattle);
            this.Controls.Add(this.txtHealth);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.lblCash);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.btnBattle);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnExit);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Name = "HubUI";
            this.Text = "Hub";
            this.Load += new System.EventHandler(this.HubUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnBattle;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.TextBox txtHealth;
        private System.Windows.Forms.ComboBox cbxBattle;
        private System.Windows.Forms.TextBox txtMaxHealth;
        private System.Windows.Forms.TextBox txtExp;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.Label lblNextLvl;
        private System.Windows.Forms.TextBox txtExpNeeded;
        private System.Windows.Forms.TextBox txt_LVL;
        private System.Windows.Forms.Label lblLevel;
    }
}