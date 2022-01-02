namespace IMS
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.systemMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shopMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesRetrunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchasePaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPaymentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblTimer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.CompanyName = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCompanyName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.removeDuplicateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Verdana", 9F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemMasterToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.utilityToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(850, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // systemMasterToolStripMenuItem
            // 
            this.systemMasterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userMasterToolStripMenuItem,
            this.companyMasterToolStripMenuItem,
            this.bankMasterToolStripMenuItem,
            this.shopMasterToolStripMenuItem,
            this.itemMasterToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.systemMasterToolStripMenuItem.Name = "systemMasterToolStripMenuItem";
            this.systemMasterToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.systemMasterToolStripMenuItem.Text = "System Master";
            // 
            // userMasterToolStripMenuItem
            // 
            this.userMasterToolStripMenuItem.Name = "userMasterToolStripMenuItem";
            this.userMasterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.userMasterToolStripMenuItem.Text = "User Master";
            this.userMasterToolStripMenuItem.Click += new System.EventHandler(this.userMasterToolStripMenuItem_Click);
            // 
            // companyMasterToolStripMenuItem
            // 
            this.companyMasterToolStripMenuItem.Name = "companyMasterToolStripMenuItem";
            this.companyMasterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.companyMasterToolStripMenuItem.Text = "Company Master";
            this.companyMasterToolStripMenuItem.Click += new System.EventHandler(this.companyMasterToolStripMenuItem_Click);
            // 
            // bankMasterToolStripMenuItem
            // 
            this.bankMasterToolStripMenuItem.Name = "bankMasterToolStripMenuItem";
            this.bankMasterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bankMasterToolStripMenuItem.Text = "Bank Master";
            this.bankMasterToolStripMenuItem.Visible = false;
            this.bankMasterToolStripMenuItem.Click += new System.EventHandler(this.bankMasterToolStripMenuItem_Click);
            // 
            // shopMasterToolStripMenuItem
            // 
            this.shopMasterToolStripMenuItem.Name = "shopMasterToolStripMenuItem";
            this.shopMasterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.shopMasterToolStripMenuItem.Text = "Party Master";
            this.shopMasterToolStripMenuItem.Click += new System.EventHandler(this.shopMasterToolStripMenuItem_Click);
            // 
            // itemMasterToolStripMenuItem
            // 
            this.itemMasterToolStripMenuItem.Name = "itemMasterToolStripMenuItem";
            this.itemMasterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.itemMasterToolStripMenuItem.Text = "Item Master";
            this.itemMasterToolStripMenuItem.Click += new System.EventHandler(this.itemMasterToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseMasterToolStripMenuItem,
            this.purchaseReturnToolStripMenuItem,
            this.salesMasterToolStripMenuItem,
            this.salesRetrunToolStripMenuItem,
            this.purchasePaymentToolStripMenuItem,
            this.showPaymentDetailsToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.invoiceMasterToolStripMenuItem});
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
            // 
            // purchaseMasterToolStripMenuItem
            // 
            this.purchaseMasterToolStripMenuItem.Name = "purchaseMasterToolStripMenuItem";
            this.purchaseMasterToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.purchaseMasterToolStripMenuItem.Text = "Purchase Master";
            this.purchaseMasterToolStripMenuItem.Click += new System.EventHandler(this.purchaseMasterToolStripMenuItem_Click);
            // 
            // purchaseReturnToolStripMenuItem
            // 
            this.purchaseReturnToolStripMenuItem.Name = "purchaseReturnToolStripMenuItem";
            this.purchaseReturnToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.purchaseReturnToolStripMenuItem.Text = "Purchase Return";
            this.purchaseReturnToolStripMenuItem.Click += new System.EventHandler(this.purchaseReturnToolStripMenuItem_Click);
            // 
            // salesMasterToolStripMenuItem
            // 
            this.salesMasterToolStripMenuItem.Name = "salesMasterToolStripMenuItem";
            this.salesMasterToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.salesMasterToolStripMenuItem.Text = "Sales Master";
            this.salesMasterToolStripMenuItem.Click += new System.EventHandler(this.salesMasterToolStripMenuItem_Click);
            // 
            // salesRetrunToolStripMenuItem
            // 
            this.salesRetrunToolStripMenuItem.Name = "salesRetrunToolStripMenuItem";
            this.salesRetrunToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.salesRetrunToolStripMenuItem.Text = "Sales Retrun";
            this.salesRetrunToolStripMenuItem.Click += new System.EventHandler(this.salesRetrunToolStripMenuItem_Click);
            // 
            // purchasePaymentToolStripMenuItem
            // 
            this.purchasePaymentToolStripMenuItem.Name = "purchasePaymentToolStripMenuItem";
            this.purchasePaymentToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.purchasePaymentToolStripMenuItem.Text = "Purchase Payment";
            this.purchasePaymentToolStripMenuItem.Visible = false;
            this.purchasePaymentToolStripMenuItem.Click += new System.EventHandler(this.purchasePaymentToolStripMenuItem_Click);
            // 
            // showPaymentDetailsToolStripMenuItem
            // 
            this.showPaymentDetailsToolStripMenuItem.Name = "showPaymentDetailsToolStripMenuItem";
            this.showPaymentDetailsToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.showPaymentDetailsToolStripMenuItem.Text = "Show Payment Ledger";
            this.showPaymentDetailsToolStripMenuItem.Visible = false;
            this.showPaymentDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPaymentDetailsToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.stockToolStripMenuItem.Text = "Stock";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // invoiceMasterToolStripMenuItem
            // 
            this.invoiceMasterToolStripMenuItem.Name = "invoiceMasterToolStripMenuItem";
            this.invoiceMasterToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.invoiceMasterToolStripMenuItem.Text = "Invoice Master";
            this.invoiceMasterToolStripMenuItem.Click += new System.EventHandler(this.invoiceMasterToolStripMenuItem_Click);
            // 
            // utilityToolStripMenuItem
            // 
            this.utilityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeCompanyToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.removeDuplicateToolStripMenuItem});
            this.utilityToolStripMenuItem.Name = "utilityToolStripMenuItem";
            this.utilityToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.utilityToolStripMenuItem.Text = "Utility";
            // 
            // changeCompanyToolStripMenuItem
            // 
            this.changeCompanyToolStripMenuItem.Name = "changeCompanyToolStripMenuItem";
            this.changeCompanyToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.changeCompanyToolStripMenuItem.Text = "Change Company";
            this.changeCompanyToolStripMenuItem.Click += new System.EventHandler(this.changeCompanyToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTimer,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.CompanyName,
            this.lblCompanyName});
            this.statusStrip.Location = new System.Drawing.Point(0, 430);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(850, 23);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.lblTimer.ForeColor = System.Drawing.Color.Blue;
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(52, 18);
            this.lblTimer.Text = "Timer";
            this.lblTimer.Click += new System.EventHandler(this.lblTimer_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(85, 18);
            this.toolStripStatusLabel2.Text = "User Name:";
            this.toolStripStatusLabel2.Visible = false;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(49, 18);
            this.toolStripStatusLabel3.Text = "Name";
            this.toolStripStatusLabel3.Visible = false;
            // 
            // CompanyName
            // 
            this.CompanyName.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.CompanyName.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.CompanyName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(119, 18);
            this.CompanyName.Text = "Company Name:";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblCompanyName.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.lblCompanyName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lblCompanyName.ForeColor = System.Drawing.Color.Blue;
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(49, 18);
            this.lblCompanyName.Text = "Name";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // removeDuplicateToolStripMenuItem
            // 
            this.removeDuplicateToolStripMenuItem.Name = "removeDuplicateToolStripMenuItem";
            this.removeDuplicateToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.removeDuplicateToolStripMenuItem.Text = "Remove Duplicate";
            this.removeDuplicateToolStripMenuItem.Click += new System.EventHandler(this.removeDuplicateToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RADHE ENTERPRISE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem systemMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shopMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchasePaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPaymentDetailsToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel lblTimer;
        private System.Windows.Forms.ToolStripStatusLabel CompanyName;
        public System.Windows.Forms.ToolStripStatusLabel lblCompanyName;
        private System.Windows.Forms.ToolStripMenuItem companyMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripMenuItem changeCompanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesRetrunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseReturnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeDuplicateToolStripMenuItem;
    }
}



