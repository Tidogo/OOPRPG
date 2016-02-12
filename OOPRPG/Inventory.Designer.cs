namespace OOPRPG
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.lbx_Backpack = new System.Windows.Forms.ListBox();
            this.lbl_Backpack = new System.Windows.Forms.Label();
            this.lbl_Equiped = new System.Windows.Forms.Label();
            this.cbx_Head = new System.Windows.Forms.ComboBox();
            this.cbx_Chest = new System.Windows.Forms.ComboBox();
            this.cbx_RightHand = new System.Windows.Forms.ComboBox();
            this.cbx_LeftHand = new System.Windows.Forms.ComboBox();
            this.cbx_Legs = new System.Windows.Forms.ComboBox();
            this.lbl_Cash = new System.Windows.Forms.Label();
            this.txt_Cash = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_hp = new System.Windows.Forms.TextBox();
            this.txt_str = new System.Windows.Forms.TextBox();
            this.txt_dex = new System.Windows.Forms.TextBox();
            this.txt_con = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_attpow = new System.Windows.Forms.TextBox();
            this.txt_def = new System.Windows.Forms.TextBox();
            this.txt_crit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbx_Backpack
            // 
            this.lbx_Backpack.FormattingEnabled = true;
            this.lbx_Backpack.Location = new System.Drawing.Point(327, 21);
            this.lbx_Backpack.Name = "lbx_Backpack";
            this.lbx_Backpack.Size = new System.Drawing.Size(125, 290);
            this.lbx_Backpack.TabIndex = 0;
            // 
            // lbl_Backpack
            // 
            this.lbl_Backpack.AutoSize = true;
            this.lbl_Backpack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Backpack.Location = new System.Drawing.Point(324, 3);
            this.lbl_Backpack.Name = "lbl_Backpack";
            this.lbl_Backpack.Size = new System.Drawing.Size(60, 15);
            this.lbl_Backpack.TabIndex = 1;
            this.lbl_Backpack.Text = "Backpack";
            // 
            // lbl_Equiped
            // 
            this.lbl_Equiped.AutoSize = true;
            this.lbl_Equiped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Equiped.Location = new System.Drawing.Point(12, 9);
            this.lbl_Equiped.Name = "lbl_Equiped";
            this.lbl_Equiped.Size = new System.Drawing.Size(67, 16);
            this.lbl_Equiped.TabIndex = 3;
            this.lbl_Equiped.Text = "Equipped";
            // 
            // cbx_Head
            // 
            this.cbx_Head.FormattingEnabled = true;
            this.cbx_Head.Location = new System.Drawing.Point(97, 63);
            this.cbx_Head.Name = "cbx_Head";
            this.cbx_Head.Size = new System.Drawing.Size(121, 21);
            this.cbx_Head.TabIndex = 9;
            this.cbx_Head.Text = "Choose Head Gear";
            // 
            // cbx_Chest
            // 
            this.cbx_Chest.FormattingEnabled = true;
            this.cbx_Chest.Location = new System.Drawing.Point(97, 119);
            this.cbx_Chest.Name = "cbx_Chest";
            this.cbx_Chest.Size = new System.Drawing.Size(121, 21);
            this.cbx_Chest.TabIndex = 10;
            this.cbx_Chest.Text = "Choose Chest Gear";
            // 
            // cbx_RightHand
            // 
            this.cbx_RightHand.FormattingEnabled = true;
            this.cbx_RightHand.Location = new System.Drawing.Point(15, 156);
            this.cbx_RightHand.Name = "cbx_RightHand";
            this.cbx_RightHand.Size = new System.Drawing.Size(121, 21);
            this.cbx_RightHand.TabIndex = 11;
            this.cbx_RightHand.Text = "Choose RHand Gear";
            this.cbx_RightHand.SelectedIndexChanged += new System.EventHandler(this.cbx_RightHand_SelectedIndexChanged);
            // 
            // cbx_LeftHand
            // 
            this.cbx_LeftHand.FormattingEnabled = true;
            this.cbx_LeftHand.Location = new System.Drawing.Point(185, 156);
            this.cbx_LeftHand.Name = "cbx_LeftHand";
            this.cbx_LeftHand.Size = new System.Drawing.Size(121, 21);
            this.cbx_LeftHand.TabIndex = 12;
            this.cbx_LeftHand.Text = "Choose LHand Gear";
            // 
            // cbx_Legs
            // 
            this.cbx_Legs.FormattingEnabled = true;
            this.cbx_Legs.Location = new System.Drawing.Point(81, 223);
            this.cbx_Legs.Name = "cbx_Legs";
            this.cbx_Legs.Size = new System.Drawing.Size(121, 21);
            this.cbx_Legs.TabIndex = 13;
            this.cbx_Legs.Text = "Choose Leg Gear";
            // 
            // lbl_Cash
            // 
            this.lbl_Cash.AutoSize = true;
            this.lbl_Cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cash.Location = new System.Drawing.Point(182, 296);
            this.lbl_Cash.Name = "lbl_Cash";
            this.lbl_Cash.Size = new System.Drawing.Size(39, 16);
            this.lbl_Cash.TabIndex = 14;
            this.lbl_Cash.Text = "Cash";
            // 
            // txt_Cash
            // 
            this.txt_Cash.Location = new System.Drawing.Point(221, 291);
            this.txt_Cash.Name = "txt_Cash";
            this.txt_Cash.ReadOnly = true;
            this.txt_Cash.Size = new System.Drawing.Size(100, 20);
            this.txt_Cash.TabIndex = 15;
            this.txt_Cash.TextChanged += new System.EventHandler(this.txt_Cash_TextChanged);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(385, 465);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 16;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 283);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Stats";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Health";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Strength";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Dexterity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Constitution";
            // 
            // txt_hp
            // 
            this.txt_hp.Location = new System.Drawing.Point(94, 358);
            this.txt_hp.Name = "txt_hp";
            this.txt_hp.Size = new System.Drawing.Size(42, 20);
            this.txt_hp.TabIndex = 23;
            // 
            // txt_str
            // 
            this.txt_str.Location = new System.Drawing.Point(94, 385);
            this.txt_str.Name = "txt_str";
            this.txt_str.Size = new System.Drawing.Size(42, 20);
            this.txt_str.TabIndex = 24;
            // 
            // txt_dex
            // 
            this.txt_dex.Location = new System.Drawing.Point(94, 412);
            this.txt_dex.Name = "txt_dex";
            this.txt_dex.Size = new System.Drawing.Size(42, 20);
            this.txt_dex.TabIndex = 25;
            // 
            // txt_con
            // 
            this.txt_con.Location = new System.Drawing.Point(94, 438);
            this.txt_con.Name = "txt_con";
            this.txt_con.Size = new System.Drawing.Size(42, 20);
            this.txt_con.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(217, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = "Substats";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Attack Power";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(285, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Defense";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(294, 412);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Critical";
            // 
            // txt_attpow
            // 
            this.txt_attpow.Location = new System.Drawing.Point(339, 362);
            this.txt_attpow.Name = "txt_attpow";
            this.txt_attpow.Size = new System.Drawing.Size(45, 20);
            this.txt_attpow.TabIndex = 31;
            // 
            // txt_def
            // 
            this.txt_def.Location = new System.Drawing.Point(339, 385);
            this.txt_def.Name = "txt_def";
            this.txt_def.Size = new System.Drawing.Size(45, 20);
            this.txt_def.TabIndex = 32;
            // 
            // txt_crit
            // 
            this.txt_crit.Location = new System.Drawing.Point(339, 412);
            this.txt_crit.Name = "txt_crit";
            this.txt_crit.Size = new System.Drawing.Size(45, 20);
            this.txt_crit.TabIndex = 33;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(472, 500);
            this.Controls.Add(this.txt_crit);
            this.Controls.Add(this.txt_def);
            this.Controls.Add(this.txt_attpow);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_con);
            this.Controls.Add(this.txt_dex);
            this.Controls.Add(this.txt_str);
            this.Controls.Add(this.txt_hp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.txt_Cash);
            this.Controls.Add(this.lbl_Cash);
            this.Controls.Add(this.cbx_Legs);
            this.Controls.Add(this.cbx_LeftHand);
            this.Controls.Add(this.cbx_RightHand);
            this.Controls.Add(this.cbx_Chest);
            this.Controls.Add(this.cbx_Head);
            this.Controls.Add(this.lbl_Equiped);
            this.Controls.Add(this.lbl_Backpack);
            this.Controls.Add(this.lbx_Backpack);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inventory";
            this.Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_Backpack;
        private System.Windows.Forms.Label lbl_Backpack;
        private System.Windows.Forms.Label lbl_Equiped;
        private System.Windows.Forms.ComboBox cbx_Head;
        private System.Windows.Forms.ComboBox cbx_Chest;
        private System.Windows.Forms.ComboBox cbx_RightHand;
        private System.Windows.Forms.ComboBox cbx_LeftHand;
        private System.Windows.Forms.ComboBox cbx_Legs;
        private System.Windows.Forms.Label lbl_Cash;
        private System.Windows.Forms.TextBox txt_Cash;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_hp;
        private System.Windows.Forms.TextBox txt_str;
        private System.Windows.Forms.TextBox txt_dex;
        private System.Windows.Forms.TextBox txt_con;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_attpow;
        private System.Windows.Forms.TextBox txt_def;
        private System.Windows.Forms.TextBox txt_crit;
    }
}