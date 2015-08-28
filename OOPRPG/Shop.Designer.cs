namespace OOPRPG
{
    partial class Shop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shop));
            this.btn_ExitShop = new System.Windows.Forms.Button();
            this.lbo_ShopStock = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Buy = new System.Windows.Forms.Button();
            this.lbo_Inventory = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Sell = new System.Windows.Forms.Button();
            this.txt_Cash = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.txtItemClicked = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_ExitShop
            // 
            this.btn_ExitShop.BackColor = System.Drawing.SystemColors.Control;
            this.btn_ExitShop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ExitShop.Location = new System.Drawing.Point(377, 272);
            this.btn_ExitShop.Name = "btn_ExitShop";
            this.btn_ExitShop.Size = new System.Drawing.Size(75, 37);
            this.btn_ExitShop.TabIndex = 0;
            this.btn_ExitShop.Text = "Exit Shop";
            this.btn_ExitShop.UseVisualStyleBackColor = false;
            this.btn_ExitShop.Click += new System.EventHandler(this.btn_ExitShop_Click);
            // 
            // lbo_ShopStock
            // 
            this.lbo_ShopStock.BackColor = System.Drawing.Color.Gray;
            this.lbo_ShopStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbo_ShopStock.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbo_ShopStock.FormattingEnabled = true;
            this.lbo_ShopStock.Items.AddRange(new object[] {
            "placeholder",
            "placeholder",
            "placeholder",
            "placeholder",
            "placeholder",
            "placeholder",
            "placeholder",
            "placeholder",
            "placeholder",
            "placeholder",
            "placeholder",
            "placeholder",
            "placeholder",
            "placeholder",
            "placeholder",
            "placeholder",
            "placeholder",
            "placeholder",
            "placeholder",
            "placeholder",
            "placeholder"});
            this.lbo_ShopStock.Location = new System.Drawing.Point(12, 58);
            this.lbo_ShopStock.Name = "lbo_ShopStock";
            this.lbo_ShopStock.Size = new System.Drawing.Size(146, 247);
            this.lbo_ShopStock.TabIndex = 1;
            this.lbo_ShopStock.SelectedIndexChanged += new System.EventHandler(this.lbo_ShopStock_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Shop";
            // 
            // btn_Buy
            // 
            this.btn_Buy.Location = new System.Drawing.Point(164, 272);
            this.btn_Buy.Name = "btn_Buy";
            this.btn_Buy.Size = new System.Drawing.Size(75, 37);
            this.btn_Buy.TabIndex = 3;
            this.btn_Buy.Text = "Buy";
            this.btn_Buy.UseVisualStyleBackColor = true;
            this.btn_Buy.Click += new System.EventHandler(this.btn_Buy_Click);
            // 
            // lbo_Inventory
            // 
            this.lbo_Inventory.BackColor = System.Drawing.Color.Gray;
            this.lbo_Inventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbo_Inventory.FormattingEnabled = true;
            this.lbo_Inventory.Location = new System.Drawing.Point(320, 58);
            this.lbo_Inventory.Name = "lbo_Inventory";
            this.lbo_Inventory.Size = new System.Drawing.Size(132, 182);
            this.lbo_Inventory.TabIndex = 4;
            this.lbo_Inventory.SelectedIndexChanged += new System.EventHandler(this.lbo_Inventory_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(388, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "You";
            // 
            // btn_Sell
            // 
            this.btn_Sell.Location = new System.Drawing.Point(267, 272);
            this.btn_Sell.Name = "btn_Sell";
            this.btn_Sell.Size = new System.Drawing.Size(75, 37);
            this.btn_Sell.TabIndex = 6;
            this.btn_Sell.Text = "Sell";
            this.btn_Sell.UseVisualStyleBackColor = true;
            this.btn_Sell.Click += new System.EventHandler(this.btn_Sell_Click);
            // 
            // txt_Cash
            // 
            this.txt_Cash.Location = new System.Drawing.Point(352, 246);
            this.txt_Cash.Name = "txt_Cash";
            this.txt_Cash.Size = new System.Drawing.Size(100, 20);
            this.txt_Cash.TabIndex = 7;
            this.txt_Cash.TextChanged += new System.EventHandler(this.txt_Cash_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(311, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cash:";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(197, 48);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(27, 13);
            this.lblItem.TabIndex = 9;
            this.lblItem.Text = "Item";
            // 
            // txtItemClicked
            // 
            this.txtItemClicked.Location = new System.Drawing.Point(174, 64);
            this.txtItemClicked.Multiline = true;
            this.txtItemClicked.Name = "txtItemClicked";
            this.txtItemClicked.Size = new System.Drawing.Size(129, 160);
            this.txtItemClicked.TabIndex = 10;
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OOPRPG.Properties.Resources.bg_store;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.txtItemClicked);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Cash);
            this.Controls.Add(this.btn_Sell);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbo_Inventory);
            this.Controls.Add(this.btn_Buy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbo_ShopStock);
            this.Controls.Add(this.btn_ExitShop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(480, 360);
            this.MinimumSize = new System.Drawing.Size(480, 360);
            this.Name = "Shop";
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.Shop_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ExitShop;
        private System.Windows.Forms.ListBox lbo_ShopStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Buy;
        private System.Windows.Forms.ListBox lbo_Inventory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Sell;
        private System.Windows.Forms.TextBox txt_Cash;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.TextBox txtItemClicked;
    }
}