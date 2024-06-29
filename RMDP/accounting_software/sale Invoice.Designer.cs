namespace accounting_software
{
    partial class NewInvoice
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
            this.lb_grandTotal = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txt_adjusment = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.lb_adjusment = new System.Windows.Forms.Label();
            this.lb_shipping = new System.Windows.Forms.Label();
            this.txt_shpping = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cmb_tax = new System.Windows.Forms.ComboBox();
            this.txt_netamount = new System.Windows.Forms.TextBox();
            this.txt_rate = new System.Windows.Forms.TextBox();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.txt_iteamdetails = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_orderno = new System.Windows.Forms.TextBox();
            this.lab_orderno = new System.Windows.Forms.Label();
            this.txt_invoice = new System.Windows.Forms.TextBox();
            this.lab_invoice = new System.Windows.Forms.Label();
            this.combox_customername = new System.Windows.Forms.ComboBox();
            this.la_cusname = new System.Windows.Forms.Label();
            this.but_cancel = new System.Windows.Forms.Button();
            this.but_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_tax = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.error = new System.Windows.Forms.Label();
            this.error1 = new System.Windows.Forms.Label();
            this.error2 = new System.Windows.Forms.Label();
            this.error3 = new System.Windows.Forms.Label();
            this.error4 = new System.Windows.Forms.Label();
            this.error5 = new System.Windows.Forms.Label();
            this.error6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_grandTotal
            // 
            this.lb_grandTotal.AutoSize = true;
            this.lb_grandTotal.Location = new System.Drawing.Point(768, 491);
            this.lb_grandTotal.Name = "lb_grandTotal";
            this.lb_grandTotal.Size = new System.Drawing.Size(28, 13);
            this.lb_grandTotal.TabIndex = 78;
            this.lb_grandTotal.Text = "0.00";
            this.lb_grandTotal.Click += new System.EventHandler(this.lb_grandTotal_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(468, 491);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(66, 13);
            this.label22.TabIndex = 77;
            this.label22.Text = "Grand Total ";
            // 
            // txt_adjusment
            // 
            this.txt_adjusment.Location = new System.Drawing.Point(576, 437);
            this.txt_adjusment.Name = "txt_adjusment";
            this.txt_adjusment.Size = new System.Drawing.Size(135, 20);
            this.txt_adjusment.TabIndex = 76;
            this.txt_adjusment.TextChanged += new System.EventHandler(this.txt_adjusment_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(468, 444);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 13);
            this.label21.TabIndex = 75;
            this.label21.Text = "Adjustment";
            // 
            // lb_adjusment
            // 
            this.lb_adjusment.AutoSize = true;
            this.lb_adjusment.Location = new System.Drawing.Point(768, 444);
            this.lb_adjusment.Name = "lb_adjusment";
            this.lb_adjusment.Size = new System.Drawing.Size(28, 13);
            this.lb_adjusment.TabIndex = 74;
            this.lb_adjusment.Text = "0.00";
            this.lb_adjusment.Click += new System.EventHandler(this.lb_adjusment_Click);
            // 
            // lb_shipping
            // 
            this.lb_shipping.AutoSize = true;
            this.lb_shipping.Location = new System.Drawing.Point(768, 412);
            this.lb_shipping.Name = "lb_shipping";
            this.lb_shipping.Size = new System.Drawing.Size(28, 13);
            this.lb_shipping.TabIndex = 73;
            this.lb_shipping.Text = "0.00";
            this.lb_shipping.Click += new System.EventHandler(this.lb_shipping_Click);
            // 
            // txt_shpping
            // 
            this.txt_shpping.Location = new System.Drawing.Point(576, 405);
            this.txt_shpping.Name = "txt_shpping";
            this.txt_shpping.Size = new System.Drawing.Size(135, 20);
            this.txt_shpping.TabIndex = 72;
            this.txt_shpping.TextChanged += new System.EventHandler(this.txt_shpping_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(468, 412);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 13);
            this.label18.TabIndex = 71;
            this.label18.Text = "Shipping charges ";
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Location = new System.Drawing.Point(768, 373);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(28, 13);
            this.lb_total.TabIndex = 70;
            this.lb_total.Text = "0.00";
            this.lb_total.Click += new System.EventHandler(this.lb_total_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(468, 373);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 69;
            this.label16.Text = "Sub Total ";
            // 
            // cmb_tax
            // 
            this.cmb_tax.FormattingEnabled = true;
            this.cmb_tax.Items.AddRange(new object[] {
            "2%",
            "13.5%",
            "15%"});
            this.cmb_tax.Location = new System.Drawing.Point(559, 298);
            this.cmb_tax.Name = "cmb_tax";
            this.cmb_tax.Size = new System.Drawing.Size(105, 21);
            this.cmb_tax.TabIndex = 66;
            this.cmb_tax.SelectedIndexChanged += new System.EventHandler(this.cmb_tax_SelectedIndexChanged);
            // 
            // txt_netamount
            // 
            this.txt_netamount.Location = new System.Drawing.Point(452, 298);
            this.txt_netamount.Name = "txt_netamount";
            this.txt_netamount.Size = new System.Drawing.Size(101, 20);
            this.txt_netamount.TabIndex = 65;
            this.txt_netamount.TextChanged += new System.EventHandler(this.txt_netamount_TextChanged);
            // 
            // txt_rate
            // 
            this.txt_rate.Location = new System.Drawing.Point(350, 298);
            this.txt_rate.Name = "txt_rate";
            this.txt_rate.Size = new System.Drawing.Size(96, 20);
            this.txt_rate.TabIndex = 64;
            this.txt_rate.TextChanged += new System.EventHandler(this.txt_rate_TextChanged);
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(281, 298);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(63, 20);
            this.txt_qty.TabIndex = 63;
            this.txt_qty.TextChanged += new System.EventHandler(this.txt_qty_TextChanged);
            // 
            // txt_iteamdetails
            // 
            this.txt_iteamdetails.Location = new System.Drawing.Point(32, 298);
            this.txt_iteamdetails.Multiline = true;
            this.txt_iteamdetails.Name = "txt_iteamdetails";
            this.txt_iteamdetails.Size = new System.Drawing.Size(243, 42);
            this.txt_iteamdetails.TabIndex = 62;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(583, 282);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 60;
            this.label13.Text = "Tax ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(455, 282);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 59;
            this.label12.Text = "Net Amount ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(382, 282);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 58;
            this.label11.Text = "Rate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(298, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "Item Details";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(583, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "Due Date";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "30Days",
            "60Days",
            "90Days",
            "6Manths "});
            this.comboBox2.Location = new System.Drawing.Point(412, 225);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(102, 21);
            this.comboBox2.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(331, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Terms";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Invoice Date";
            // 
            // txt_orderno
            // 
            this.txt_orderno.Location = new System.Drawing.Point(129, 190);
            this.txt_orderno.Name = "txt_orderno";
            this.txt_orderno.Size = new System.Drawing.Size(128, 20);
            this.txt_orderno.TabIndex = 49;
            // 
            // lab_orderno
            // 
            this.lab_orderno.AutoSize = true;
            this.lab_orderno.Location = new System.Drawing.Point(47, 197);
            this.lab_orderno.Name = "lab_orderno";
            this.lab_orderno.Size = new System.Drawing.Size(50, 13);
            this.lab_orderno.TabIndex = 48;
            this.lab_orderno.Text = "Order No";
            // 
            // txt_invoice
            // 
            this.txt_invoice.Location = new System.Drawing.Point(129, 154);
            this.txt_invoice.Name = "txt_invoice";
            this.txt_invoice.Size = new System.Drawing.Size(128, 20);
            this.txt_invoice.TabIndex = 47;
            // 
            // lab_invoice
            // 
            this.lab_invoice.AutoSize = true;
            this.lab_invoice.Location = new System.Drawing.Point(38, 161);
            this.lab_invoice.Name = "lab_invoice";
            this.lab_invoice.Size = new System.Drawing.Size(59, 13);
            this.lab_invoice.TabIndex = 46;
            this.lab_invoice.Text = "Invoice No";
            // 
            // combox_customername
            // 
            this.combox_customername.FormattingEnabled = true;
            this.combox_customername.Location = new System.Drawing.Point(130, 51);
            this.combox_customername.Name = "combox_customername";
            this.combox_customername.Size = new System.Drawing.Size(280, 21);
            this.combox_customername.TabIndex = 43;
            this.combox_customername.SelectedIndexChanged += new System.EventHandler(this.combox_customername_SelectedIndexChanged);
            // 
            // la_cusname
            // 
            this.la_cusname.AutoSize = true;
            this.la_cusname.Location = new System.Drawing.Point(15, 59);
            this.la_cusname.Name = "la_cusname";
            this.la_cusname.Size = new System.Drawing.Size(82, 13);
            this.la_cusname.TabIndex = 42;
            this.la_cusname.Text = "Customer Name";
            // 
            // but_cancel
            // 
            this.but_cancel.BackColor = System.Drawing.SystemColors.Window;
            this.but_cancel.Location = new System.Drawing.Point(848, 525);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(101, 34);
            this.but_cancel.TabIndex = 99;
            this.but_cancel.Text = "Cancel";
            this.but_cancel.UseVisualStyleBackColor = false;
            this.but_cancel.Click += new System.EventHandler(this.but_cancel_Click);
            // 
            // but_Save
            // 
            this.but_Save.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.but_Save.Location = new System.Drawing.Point(724, 525);
            this.but_Save.Name = "but_Save";
            this.but_Save.Size = new System.Drawing.Size(101, 34);
            this.but_Save.TabIndex = 98;
            this.but_Save.Text = "Save";
            this.but_Save.UseVisualStyleBackColor = false;
            this.but_Save.Click += new System.EventHandler(this.but_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(433, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 100;
            this.label1.Text = "New Sales Invoice";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.DisabledLinkColor = System.Drawing.Color.Maroon;
            this.linkLabel2.LinkColor = System.Drawing.Color.Red;
            this.linkLabel2.Location = new System.Drawing.Point(768, 54);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(79, 13);
            this.linkLabel2.TabIndex = 101;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "New Customer ";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(747, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 102;
            this.label3.Text = "Tax amount";
            // 
            // lb_tax
            // 
            this.lb_tax.AutoSize = true;
            this.lb_tax.Location = new System.Drawing.Point(768, 306);
            this.lb_tax.Name = "lb_tax";
            this.lb_tax.Size = new System.Drawing.Size(28, 13);
            this.lb_tax.TabIndex = 103;
            this.lb_tax.Text = "0.00";
            this.lb_tax.Click += new System.EventHandler(this.lb_tax_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(129, 226);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 20);
            this.dateTimePicker1.TabIndex = 104;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(659, 227);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(128, 20);
            this.dateTimePicker2.TabIndex = 105;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(411, 54);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 13);
            this.error.TabIndex = 106;
            // 
            // error1
            // 
            this.error1.AutoSize = true;
            this.error1.ForeColor = System.Drawing.Color.Red;
            this.error1.Location = new System.Drawing.Point(264, 154);
            this.error1.Name = "error1";
            this.error1.Size = new System.Drawing.Size(0, 13);
            this.error1.TabIndex = 107;
            // 
            // error2
            // 
            this.error2.AutoSize = true;
            this.error2.ForeColor = System.Drawing.Color.Red;
            this.error2.Location = new System.Drawing.Point(298, 337);
            this.error2.Name = "error2";
            this.error2.Size = new System.Drawing.Size(0, 13);
            this.error2.TabIndex = 108;
            // 
            // error3
            // 
            this.error3.AutoSize = true;
            this.error3.ForeColor = System.Drawing.Color.Red;
            this.error3.Location = new System.Drawing.Point(375, 358);
            this.error3.Name = "error3";
            this.error3.Size = new System.Drawing.Size(0, 13);
            this.error3.TabIndex = 109;
            // 
            // error4
            // 
            this.error4.AutoSize = true;
            this.error4.ForeColor = System.Drawing.Color.Red;
            this.error4.Location = new System.Drawing.Point(240, 412);
            this.error4.Name = "error4";
            this.error4.Size = new System.Drawing.Size(0, 13);
            this.error4.TabIndex = 110;
            // 
            // error5
            // 
            this.error5.AutoSize = true;
            this.error5.ForeColor = System.Drawing.Color.Red;
            this.error5.Location = new System.Drawing.Point(240, 444);
            this.error5.Name = "error5";
            this.error5.Size = new System.Drawing.Size(0, 13);
            this.error5.TabIndex = 111;
            // 
            // error6
            // 
            this.error6.AutoSize = true;
            this.error6.ForeColor = System.Drawing.Color.Red;
            this.error6.Location = new System.Drawing.Point(583, 337);
            this.error6.Name = "error6";
            this.error6.Size = new System.Drawing.Size(0, 13);
            this.error6.TabIndex = 112;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(107, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 24);
            this.label2.TabIndex = 113;
            this.label2.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(107, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 24);
            this.label4.TabIndex = 114;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(107, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 24);
            this.label5.TabIndex = 115;
            this.label5.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(281, 274);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 24);
            this.label14.TabIndex = 116;
            this.label14.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(359, 271);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 24);
            this.label15.TabIndex = 117;
            this.label15.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(555, 404);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 24);
            this.label17.TabIndex = 118;
            this.label17.Text = "*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(555, 433);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 24);
            this.label19.TabIndex = 119;
            this.label19.Text = "*";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(566, 274);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 24);
            this.label20.TabIndex = 120;
            this.label20.Text = "*";
            // 
            // NewInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(970, 571);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.error6);
            this.Controls.Add(this.error5);
            this.Controls.Add(this.error4);
            this.Controls.Add(this.error3);
            this.Controls.Add(this.error2);
            this.Controls.Add(this.error1);
            this.Controls.Add(this.error);
            this.Controls.Add(this.combox_customername);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lb_tax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_Save);
            this.Controls.Add(this.lb_grandTotal);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txt_adjusment);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lb_adjusment);
            this.Controls.Add(this.lb_shipping);
            this.Controls.Add(this.txt_shpping);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cmb_tax);
            this.Controls.Add(this.txt_netamount);
            this.Controls.Add(this.txt_rate);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.txt_iteamdetails);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_orderno);
            this.Controls.Add(this.lab_orderno);
            this.Controls.Add(this.txt_invoice);
            this.Controls.Add(this.lab_invoice);
            this.Controls.Add(this.la_cusname);
            this.MaximizeBox = false;
            this.Name = "NewInvoice";
            this.Text = "New Invoice ";
            this.Load += new System.EventHandler(this.NewInvoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_grandTotal;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txt_adjusment;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lb_adjusment;
        private System.Windows.Forms.Label lb_shipping;
        private System.Windows.Forms.TextBox txt_shpping;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmb_tax;
        private System.Windows.Forms.TextBox txt_netamount;
        private System.Windows.Forms.TextBox txt_rate;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.TextBox txt_iteamdetails;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_orderno;
        private System.Windows.Forms.Label lab_orderno;
        private System.Windows.Forms.TextBox txt_invoice;
        private System.Windows.Forms.Label lab_invoice;
        private System.Windows.Forms.ComboBox combox_customername;
        private System.Windows.Forms.Label la_cusname;
        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.Button but_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_tax;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Label error1;
        private System.Windows.Forms.Label error2;
        private System.Windows.Forms.Label error3;
        private System.Windows.Forms.Label error4;
        private System.Windows.Forms.Label error5;
        private System.Windows.Forms.Label error6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
    }
}