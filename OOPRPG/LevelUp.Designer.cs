﻿namespace OOPRPG
{
    partial class LevelUp
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
            this.btn_StrPlus = new System.Windows.Forms.Button();
            this.btn_ConPlus = new System.Windows.Forms.Button();
            this.btn_DexPlus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_StrPlus
            // 
            this.btn_StrPlus.Location = new System.Drawing.Point(15, 60);
            this.btn_StrPlus.Name = "btn_StrPlus";
            this.btn_StrPlus.Size = new System.Drawing.Size(75, 23);
            this.btn_StrPlus.TabIndex = 0;
            this.btn_StrPlus.Text = "Strength +1";
            this.btn_StrPlus.UseVisualStyleBackColor = true;
            this.btn_StrPlus.Click += new System.EventHandler(this.btn_StrPlus_Click);
            // 
            // btn_ConPlus
            // 
            this.btn_ConPlus.Location = new System.Drawing.Point(96, 60);
            this.btn_ConPlus.Name = "btn_ConPlus";
            this.btn_ConPlus.Size = new System.Drawing.Size(86, 23);
            this.btn_ConPlus.TabIndex = 1;
            this.btn_ConPlus.Text = "Constitution +1";
            this.btn_ConPlus.UseVisualStyleBackColor = true;
            this.btn_ConPlus.Click += new System.EventHandler(this.btn_ConPlus_Click);
            // 
            // btn_DexPlus
            // 
            this.btn_DexPlus.Location = new System.Drawing.Point(59, 91);
            this.btn_DexPlus.Name = "btn_DexPlus";
            this.btn_DexPlus.Size = new System.Drawing.Size(75, 23);
            this.btn_DexPlus.TabIndex = 2;
            this.btn_DexPlus.Text = "Dexterity +1";
            this.btn_DexPlus.UseVisualStyleBackColor = true;
            this.btn_DexPlus.Click += new System.EventHandler(this.btn_DexPlus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "YOU JUST LEVELED UP!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Please choose a stat to upgrade!";
            // 
            // LevelUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::OOPRPG.Properties.Resources.lvlup;
            this.ClientSize = new System.Drawing.Size(327, 126);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_DexPlus);
            this.Controls.Add(this.btn_ConPlus);
            this.Controls.Add(this.btn_StrPlus);
            this.Name = "LevelUp";
            this.Text = "LevelUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_StrPlus;
        private System.Windows.Forms.Button btn_ConPlus;
        private System.Windows.Forms.Button btn_DexPlus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}