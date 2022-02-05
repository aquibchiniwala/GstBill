namespace GSTBill
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageFirmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storeMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managePurchasePartyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.filterParty50LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem2,
            this.printBillToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1805, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem2
            // 
            this.adminToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageFirmToolStripMenuItem,
            this.storeMasterToolStripMenuItem,
            this.managePurchasePartyToolStripMenuItem});
            this.adminToolStripMenuItem2.Name = "adminToolStripMenuItem2";
            this.adminToolStripMenuItem2.Size = new System.Drawing.Size(92, 29);
            this.adminToolStripMenuItem2.Text = "Masters";
            // 
            // manageFirmToolStripMenuItem
            // 
            this.manageFirmToolStripMenuItem.Name = "manageFirmToolStripMenuItem";
            this.manageFirmToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
            this.manageFirmToolStripMenuItem.Text = "Manage Firm";
            this.manageFirmToolStripMenuItem.Click += new System.EventHandler(this.manageFirmToolStripMenuItem_Click);
            // 
            // storeMasterToolStripMenuItem
            // 
            this.storeMasterToolStripMenuItem.Name = "storeMasterToolStripMenuItem";
            this.storeMasterToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
            this.storeMasterToolStripMenuItem.Text = "Manage Party";
            this.storeMasterToolStripMenuItem.Click += new System.EventHandler(this.storeMasterToolStripMenuItem_Click);
            // 
            // managePurchasePartyToolStripMenuItem
            // 
            this.managePurchasePartyToolStripMenuItem.Name = "managePurchasePartyToolStripMenuItem";
            this.managePurchasePartyToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
            this.managePurchasePartyToolStripMenuItem.Text = "Manage Supplier";
            this.managePurchasePartyToolStripMenuItem.Visible = false;
            this.managePurchasePartyToolStripMenuItem.Click += new System.EventHandler(this.managePurchasePartyToolStripMenuItem_Click);
            // 
            // printBillToolStripMenuItem
            // 
            this.printBillToolStripMenuItem.Name = "printBillToolStripMenuItem";
            this.printBillToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.printBillToolStripMenuItem.Size = new System.Drawing.Size(133, 29);
            this.printBillToolStripMenuItem.Text = "Print Bill (F1)";
            this.printBillToolStripMenuItem.Click += new System.EventHandler(this.printBillToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesToolStripMenuItem,
            this.filterParty50LToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.salesToolStripMenuItem.Text = "Sales";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(56, 29);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1805, 869);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // filterParty50LToolStripMenuItem
            // 
            this.filterParty50LToolStripMenuItem.Name = "filterParty50LToolStripMenuItem";
            this.filterParty50LToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.filterParty50LToolStripMenuItem.Text = "Filter Party 50L";
            this.filterParty50LToolStripMenuItem.Click += new System.EventHandler(this.filterParty50LToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1805, 902);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GST Bill Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem storeMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageFirmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printBillToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managePurchasePartyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterParty50LToolStripMenuItem;
    }
}