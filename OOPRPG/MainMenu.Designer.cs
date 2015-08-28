namespace OOPRPG
{
    partial class frm_MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MainMenu));
            this.btn_newchar = new System.Windows.Forms.Button();
            this.btn_loadgame = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_newchar
            // 
            this.btn_newchar.BackColor = System.Drawing.Color.Black;
            this.btn_newchar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newchar.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newchar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_newchar.Location = new System.Drawing.Point(12, 197);
            this.btn_newchar.Name = "btn_newchar";
            this.btn_newchar.Size = new System.Drawing.Size(130, 50);
            this.btn_newchar.TabIndex = 0;
            this.btn_newchar.Text = "New Character";
            this.btn_newchar.UseVisualStyleBackColor = false;
            this.btn_newchar.Click += new System.EventHandler(this.btn_newchar_Click);
            // 
            // btn_loadgame
            // 
            this.btn_loadgame.BackColor = System.Drawing.Color.Black;
            this.btn_loadgame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_loadgame.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loadgame.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_loadgame.Location = new System.Drawing.Point(305, 197);
            this.btn_loadgame.Name = "btn_loadgame";
            this.btn_loadgame.Size = new System.Drawing.Size(143, 50);
            this.btn_loadgame.TabIndex = 1;
            this.btn_loadgame.Text = "Load Game";
            this.btn_loadgame.UseVisualStyleBackColor = false;
            this.btn_loadgame.Click += new System.EventHandler(this.btn_loadgame_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Black;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_Exit.Location = new System.Drawing.Point(188, 253);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 52);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Exit Game";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // frm_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::OOPRPG.Properties.Resources.bg_mainmenu;
            this.ClientSize = new System.Drawing.Size(460, 317);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_loadgame);
            this.Controls.Add(this.btn_newchar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(480, 360);
            this.MinimumSize = new System.Drawing.Size(480, 360);
            this.Name = "frm_MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_newchar;
        private System.Windows.Forms.Button btn_loadgame;
        private System.Windows.Forms.Button btn_Exit;
    }
}

