namespace OOPRPG
{
    partial class CharCreation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharCreation));
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStr = new System.Windows.Forms.Label();
            this.lblDex = new System.Windows.Forms.Label();
            this.lblCon = new System.Windows.Forms.Label();
            this.btnAddStr = new System.Windows.Forms.Button();
            this.btnAddDex = new System.Windows.Forms.Button();
            this.btnAddCon = new System.Windows.Forms.Button();
            this.toolTipStr = new System.Windows.Forms.ToolTip(this.components);
            this.btnSubStr = new System.Windows.Forms.Button();
            this.toolTipDEX = new System.Windows.Forms.ToolTip(this.components);
            this.btnSubDex = new System.Windows.Forms.Button();
            this.toolTipCON = new System.Windows.Forms.ToolTip(this.components);
            this.btnSubCon = new System.Windows.Forms.Button();
            this.txtStatStr = new System.Windows.Forms.TextBox();
            this.txtStatDex = new System.Windows.Forms.TextBox();
            this.txtStatCon = new System.Windows.Forms.TextBox();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(102, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(146, 20);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.DimGray;
            this.lblName.Location = new System.Drawing.Point(41, 72);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblStr
            // 
            this.lblStr.AutoSize = true;
            this.lblStr.BackColor = System.Drawing.Color.DimGray;
            this.lblStr.Location = new System.Drawing.Point(41, 229);
            this.lblStr.Name = "lblStr";
            this.lblStr.Size = new System.Drawing.Size(47, 13);
            this.lblStr.TabIndex = 2;
            this.lblStr.Text = "Strength";
            // 
            // lblDex
            // 
            this.lblDex.AutoSize = true;
            this.lblDex.BackColor = System.Drawing.Color.DimGray;
            this.lblDex.Location = new System.Drawing.Point(41, 273);
            this.lblDex.Name = "lblDex";
            this.lblDex.Size = new System.Drawing.Size(48, 13);
            this.lblDex.TabIndex = 3;
            this.lblDex.Text = "Dexterity";
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.BackColor = System.Drawing.Color.DimGray;
            this.lblCon.Location = new System.Drawing.Point(41, 318);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(62, 13);
            this.lblCon.TabIndex = 4;
            this.lblCon.Text = "Constitution";
            // 
            // btnAddStr
            // 
            this.btnAddStr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStr.Location = new System.Drawing.Point(199, 224);
            this.btnAddStr.Name = "btnAddStr";
            this.btnAddStr.Size = new System.Drawing.Size(75, 23);
            this.btnAddStr.TabIndex = 5;
            this.btnAddStr.Text = "+ 1 Str";
            this.toolTipStr.SetToolTip(this.btnAddStr, "Bonus Damage, Melee to hit and crit");
            this.btnAddStr.UseVisualStyleBackColor = true;
            this.btnAddStr.Click += new System.EventHandler(this.btnAddStr_Click);
            // 
            // btnAddDex
            // 
            this.btnAddDex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDex.Location = new System.Drawing.Point(199, 268);
            this.btnAddDex.Name = "btnAddDex";
            this.btnAddDex.Size = new System.Drawing.Size(75, 23);
            this.btnAddDex.TabIndex = 6;
            this.btnAddDex.Text = "+ 1 Dex";
            this.toolTipDEX.SetToolTip(this.btnAddDex, "Bonus to dodge, ranged to hit and crit");
            this.btnAddDex.UseVisualStyleBackColor = true;
            this.btnAddDex.Click += new System.EventHandler(this.btnAddDex_Click);
            // 
            // btnAddCon
            // 
            this.btnAddCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCon.Location = new System.Drawing.Point(199, 313);
            this.btnAddCon.Name = "btnAddCon";
            this.btnAddCon.Size = new System.Drawing.Size(75, 23);
            this.btnAddCon.TabIndex = 7;
            this.btnAddCon.Text = "+ 1 Con";
            this.toolTipCON.SetToolTip(this.btnAddCon, "Bonus to Healt and Resists");
            this.btnAddCon.UseVisualStyleBackColor = true;
            this.btnAddCon.Click += new System.EventHandler(this.btnAddCon_Click);
            // 
            // btnSubStr
            // 
            this.btnSubStr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubStr.Location = new System.Drawing.Point(289, 224);
            this.btnSubStr.Name = "btnSubStr";
            this.btnSubStr.Size = new System.Drawing.Size(75, 23);
            this.btnSubStr.TabIndex = 11;
            this.btnSubStr.Text = "- 1 Str";
            this.toolTipStr.SetToolTip(this.btnSubStr, "Bonus Damage, Melee to hit and crit");
            this.btnSubStr.UseVisualStyleBackColor = true;
            this.btnSubStr.Click += new System.EventHandler(this.btnSubStr_Click);
            // 
            // btnSubDex
            // 
            this.btnSubDex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubDex.Location = new System.Drawing.Point(289, 268);
            this.btnSubDex.Name = "btnSubDex";
            this.btnSubDex.Size = new System.Drawing.Size(75, 23);
            this.btnSubDex.TabIndex = 12;
            this.btnSubDex.Text = "- 1 Dex";
            this.toolTipDEX.SetToolTip(this.btnSubDex, "Bonus to dodge, ranged to hit and crit");
            this.btnSubDex.UseVisualStyleBackColor = true;
            this.btnSubDex.Click += new System.EventHandler(this.btnSubDex_Click);
            // 
            // btnSubCon
            // 
            this.btnSubCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubCon.Location = new System.Drawing.Point(289, 313);
            this.btnSubCon.Name = "btnSubCon";
            this.btnSubCon.Size = new System.Drawing.Size(75, 23);
            this.btnSubCon.TabIndex = 13;
            this.btnSubCon.Text = "- 1 Con";
            this.toolTipCON.SetToolTip(this.btnSubCon, "Bonus to Healt and Resists");
            this.btnSubCon.UseVisualStyleBackColor = true;
            this.btnSubCon.Click += new System.EventHandler(this.btnSubCon_Click);
            // 
            // txtStatStr
            // 
            this.txtStatStr.Location = new System.Drawing.Point(108, 226);
            this.txtStatStr.Name = "txtStatStr";
            this.txtStatStr.ReadOnly = true;
            this.txtStatStr.Size = new System.Drawing.Size(63, 20);
            this.txtStatStr.TabIndex = 8;
            this.txtStatStr.Text = "1";
            this.txtStatStr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStatStr.TextChanged += new System.EventHandler(this.txtStatStr_TextChanged);
            // 
            // txtStatDex
            // 
            this.txtStatDex.Location = new System.Drawing.Point(108, 270);
            this.txtStatDex.Name = "txtStatDex";
            this.txtStatDex.ReadOnly = true;
            this.txtStatDex.Size = new System.Drawing.Size(63, 20);
            this.txtStatDex.TabIndex = 9;
            this.txtStatDex.Text = "\r\n1";
            this.txtStatDex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStatDex.TextChanged += new System.EventHandler(this.txtStatDex_TextChanged);
            // 
            // txtStatCon
            // 
            this.txtStatCon.Location = new System.Drawing.Point(108, 315);
            this.txtStatCon.Name = "txtStatCon";
            this.txtStatCon.ReadOnly = true;
            this.txtStatCon.Size = new System.Drawing.Size(63, 20);
            this.txtStatCon.TabIndex = 10;
            this.txtStatCon.Text = "1";
            this.txtStatCon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStatCon.TextChanged += new System.EventHandler(this.txtStatCon_TextChanged);
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.BackColor = System.Drawing.Color.DimGray;
            this.lblInstruction.Location = new System.Drawing.Point(41, 113);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(241, 26);
            this.lblInstruction.TabIndex = 14;
            this.lblInstruction.Text = "Distribute 3  points into your stats where you wish.\r\n Auto assign makes stats a " +
    "total of 2 each";
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(39, 377);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(137, 377);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuto.Location = new System.Drawing.Point(237, 377);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(75, 23);
            this.btnAuto.TabIndex = 17;
            this.btnAuto.Text = "Auto Assign";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Location = new System.Drawing.Point(336, 377);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 18;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // CharCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(464, 441);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.btnSubCon);
            this.Controls.Add(this.btnSubDex);
            this.Controls.Add(this.btnSubStr);
            this.Controls.Add(this.txtStatCon);
            this.Controls.Add(this.txtStatDex);
            this.Controls.Add(this.txtStatStr);
            this.Controls.Add(this.btnAddCon);
            this.Controls.Add(this.btnAddDex);
            this.Controls.Add(this.btnAddStr);
            this.Controls.Add(this.lblCon);
            this.Controls.Add(this.lblDex);
            this.Controls.Add(this.lblStr);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(480, 480);
            this.MinimumSize = new System.Drawing.Size(480, 480);
            this.Name = "CharCreation";
            this.Text = "Charactor Creation";
            this.Load += new System.EventHandler(this.CharCreation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStr;
        private System.Windows.Forms.Label lblDex;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.Button btnAddStr;
        private System.Windows.Forms.ToolTip toolTipStr;
        private System.Windows.Forms.Button btnAddDex;
        private System.Windows.Forms.ToolTip toolTipDEX;
        private System.Windows.Forms.Button btnAddCon;
        private System.Windows.Forms.ToolTip toolTipCON;
        private System.Windows.Forms.TextBox txtStatStr;
        private System.Windows.Forms.TextBox txtStatDex;
        private System.Windows.Forms.TextBox txtStatCon;
        private System.Windows.Forms.Button btnSubCon;
        private System.Windows.Forms.Button btnSubDex;
        private System.Windows.Forms.Button btnSubStr;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnCreate;
    }
}

