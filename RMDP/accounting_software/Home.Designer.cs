namespace accounting_software
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllBillAndOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllPaymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pucharseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.generatBalanceSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generatLadgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recivePaymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matarialStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rowMatarialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finishedGoodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.pucharseToolStripMenuItem,
            this.accountToolStripMenuItem1,
            this.paymentsToolStripMenuItem,
            this.matarialStockToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1051, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllBillAndOrderToolStripMenuItem,
            this.viewAllPaymentsToolStripMenuItem,
            this.customerToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.accountToolStripMenuItem.Text = "Summary ";
            // 
            // viewAllBillAndOrderToolStripMenuItem
            // 
            this.viewAllBillAndOrderToolStripMenuItem.Name = "viewAllBillAndOrderToolStripMenuItem";
            this.viewAllBillAndOrderToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.viewAllBillAndOrderToolStripMenuItem.Text = "View All Bill and Order";
            this.viewAllBillAndOrderToolStripMenuItem.Click += new System.EventHandler(this.viewAllBillAndOrderToolStripMenuItem_Click);
            // 
            // viewAllPaymentsToolStripMenuItem
            // 
            this.viewAllPaymentsToolStripMenuItem.Name = "viewAllPaymentsToolStripMenuItem";
            this.viewAllPaymentsToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.viewAllPaymentsToolStripMenuItem.Text = "View All Payments";
            this.viewAllPaymentsToolStripMenuItem.Click += new System.EventHandler(this.viewAllPaymentsToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.customerToolStripMenuItem.Text = "Customer/Vendor List";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invoiceToolStripMenuItem,
            this.saleOrderToolStripMenuItem});
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // invoiceToolStripMenuItem
            // 
            this.invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            this.invoiceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.invoiceToolStripMenuItem.Text = "Sales Invoice";
            this.invoiceToolStripMenuItem.Click += new System.EventHandler(this.invoiceToolStripMenuItem_Click);
            // 
            // saleOrderToolStripMenuItem
            // 
            this.saleOrderToolStripMenuItem.Name = "saleOrderToolStripMenuItem";
            this.saleOrderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saleOrderToolStripMenuItem.Text = "Sale Order ";
            this.saleOrderToolStripMenuItem.Click += new System.EventHandler(this.saleOrderToolStripMenuItem_Click);
            // 
            // pucharseToolStripMenuItem
            // 
            this.pucharseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseInvoiceToolStripMenuItem,
            this.purchaseOrderToolStripMenuItem,
            this.eToolStripMenuItem});
            this.pucharseToolStripMenuItem.Name = "pucharseToolStripMenuItem";
            this.pucharseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.pucharseToolStripMenuItem.Text = "Purchase";
            this.pucharseToolStripMenuItem.Click += new System.EventHandler(this.pucharseToolStripMenuItem_Click);
            // 
            // purchaseInvoiceToolStripMenuItem
            // 
            this.purchaseInvoiceToolStripMenuItem.Name = "purchaseInvoiceToolStripMenuItem";
            this.purchaseInvoiceToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.purchaseInvoiceToolStripMenuItem.Text = "Purchase Invoice";
            this.purchaseInvoiceToolStripMenuItem.Click += new System.EventHandler(this.purchaseInvoiceToolStripMenuItem_Click);
            // 
            // purchaseOrderToolStripMenuItem
            // 
            this.purchaseOrderToolStripMenuItem.Name = "purchaseOrderToolStripMenuItem";
            this.purchaseOrderToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.purchaseOrderToolStripMenuItem.Text = "Purchase Order ";
            this.purchaseOrderToolStripMenuItem.Click += new System.EventHandler(this.purchaseOrderToolStripMenuItem_Click);
            // 
            // eToolStripMenuItem
            // 
            this.eToolStripMenuItem.Name = "eToolStripMenuItem";
            this.eToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.eToolStripMenuItem.Text = "Expenses";
            this.eToolStripMenuItem.Click += new System.EventHandler(this.eToolStripMenuItem_Click);
            // 
            // accountToolStripMenuItem1
            // 
            this.accountToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generatBalanceSheetToolStripMenuItem,
            this.generatLadgerToolStripMenuItem});
            this.accountToolStripMenuItem1.Name = "accountToolStripMenuItem1";
            this.accountToolStripMenuItem1.Size = new System.Drawing.Size(67, 20);
            this.accountToolStripMenuItem1.Text = "Account ";
            // 
            // generatBalanceSheetToolStripMenuItem
            // 
            this.generatBalanceSheetToolStripMenuItem.Name = "generatBalanceSheetToolStripMenuItem";
            this.generatBalanceSheetToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.generatBalanceSheetToolStripMenuItem.Text = "Generate Balance Sheet ";
            this.generatBalanceSheetToolStripMenuItem.Click += new System.EventHandler(this.generatBalanceSheetToolStripMenuItem_Click);
            // 
            // generatLadgerToolStripMenuItem
            // 
            this.generatLadgerToolStripMenuItem.Name = "generatLadgerToolStripMenuItem";
            this.generatLadgerToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.generatLadgerToolStripMenuItem.Text = "Generate Ledger ";
            this.generatLadgerToolStripMenuItem.Click += new System.EventHandler(this.generatLadgerToolStripMenuItem_Click);
            // 
            // paymentsToolStripMenuItem
            // 
            this.paymentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recivePaymentsToolStripMenuItem,
            this.paidToolStripMenuItem});
            this.paymentsToolStripMenuItem.Name = "paymentsToolStripMenuItem";
            this.paymentsToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.paymentsToolStripMenuItem.Text = "Payments ";
            // 
            // recivePaymentsToolStripMenuItem
            // 
            this.recivePaymentsToolStripMenuItem.Name = "recivePaymentsToolStripMenuItem";
            this.recivePaymentsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.recivePaymentsToolStripMenuItem.Text = "Recived Payments ";
            this.recivePaymentsToolStripMenuItem.Click += new System.EventHandler(this.recivePaymentsToolStripMenuItem_Click);
            // 
            // paidToolStripMenuItem
            // 
            this.paidToolStripMenuItem.Name = "paidToolStripMenuItem";
            this.paidToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.paidToolStripMenuItem.Text = "Paid  Payments ";
            this.paidToolStripMenuItem.Click += new System.EventHandler(this.paidToolStripMenuItem_Click);
            // 
            // matarialStockToolStripMenuItem
            // 
            this.matarialStockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rowMatarialToolStripMenuItem,
            this.finishedGoodsToolStripMenuItem});
            this.matarialStockToolStripMenuItem.Name = "matarialStockToolStripMenuItem";
            this.matarialStockToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.matarialStockToolStripMenuItem.Text = "Material Stock";
            // 
            // rowMatarialToolStripMenuItem
            // 
            this.rowMatarialToolStripMenuItem.Name = "rowMatarialToolStripMenuItem";
            this.rowMatarialToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.rowMatarialToolStripMenuItem.Text = "Update Stock Material ";
            this.rowMatarialToolStripMenuItem.Click += new System.EventHandler(this.rowMatarialToolStripMenuItem_Click);
            // 
            // finishedGoodsToolStripMenuItem
            // 
            this.finishedGoodsToolStripMenuItem.Name = "finishedGoodsToolStripMenuItem";
            this.finishedGoodsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.finishedGoodsToolStripMenuItem.Text = "View Stock";
            this.finishedGoodsToolStripMenuItem.Click += new System.EventHandler(this.finishedGoodsToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.companyInfoToolStripMenuItem,
            this.backupToolStripMenuItem,
            this.passwordSettingToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.settingsToolStripMenuItem.Text = "Settings ";
            // 
            // companyInfoToolStripMenuItem
            // 
            this.companyInfoToolStripMenuItem.Name = "companyInfoToolStripMenuItem";
            this.companyInfoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.companyInfoToolStripMenuItem.Text = "Company Info.";
            this.companyInfoToolStripMenuItem.Click += new System.EventHandler(this.companyInfoToolStripMenuItem_Click);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.backupToolStripMenuItem.Text = "Backup";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // passwordSettingToolStripMenuItem
            // 
            this.passwordSettingToolStripMenuItem.Name = "passwordSettingToolStripMenuItem";
            this.passwordSettingToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.passwordSettingToolStripMenuItem.Text = "Password Setting";
            this.passwordSettingToolStripMenuItem.Click += new System.EventHandler(this.passwordSettingToolStripMenuItem_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(973, 5);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(66, 19);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sign-Out";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(250, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 340);
            this.panel1.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 506);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pucharseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generatBalanceSheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generatLadgerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recivePaymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matarialStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rowMatarialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finishedGoodsToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolStripMenuItem eToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllBillAndOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllPaymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}