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
            this.btn_Exit.Location = new System.Drawing.Point(12, 289);
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
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(464, 556);
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
    }
}