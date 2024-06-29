namespace accounting_software
{
    partial class Make_payments
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
            this.label1 = new System.Windows.Forms.Label();
            this.combo_vendor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_paymentstype = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_paymentInvoice = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_reference = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.but_cancel = new System.Windows.Forms.Button();
            this.but_Save = new System.Windows.Forms.Button();
            this.txt_ChequeNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.error1 = new System.Windows.Forms.Label();
            this.error3 = new System.Windows.Forms.Label();
            this.error2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_transaction = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.error9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vendor Name ";
            // 
            // combo_vendor
            // 
            this.combo_vendor.FormattingEnabled = true;
            this.combo_vendor.Location = new System.Drawing.Point(185, 125);
            this.combo_vendor.Name = "combo_vendor";
            this.combo_vendor.Size = new System.Drawing.Size(229, 21);
            this.combo_vendor.TabIndex = 1;
            this.combo_vendor.SelectedIndexChanged += new System.EventHandler(this.combo_vendor_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Payment Type ";
            // 
            // combo_paymentstype
            // 
            this.combo_paymentstype.FormattingEnabled = true;
            this.combo_paymentstype.Items.AddRange(new object[] {
            "Cash ",
            "Cheque ",
            "NEFT",
            "RTGS"});
            this.combo_paymentstype.Location = new System.Drawing.Point(185, 184);
            this.combo_paymentstype.Name = "combo_paymentstype";
            this.combo_paymentstype.Size = new System.Drawing.Size(229, 21);
            this.combo_paymentstype.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount ";
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(185, 261);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(173, 20);
            this.txt_amount.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Payment Of Invoice";
            // 
            // txt_paymentInvoice
            // 
            this.txt_paymentInvoice.FormattingEnabled = true;
            this.txt_paymentInvoice.Location = new System.Drawing.Point(185, 295);
            this.txt_paymentInvoice.Name = "txt_paymentInvoice";
            this.txt_paymentInvoice.Size = new System.Drawing.Size(173, 21);
            this.txt_paymentInvoice.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Reference#";
            // 
            // txt_reference
            // 
            this.txt_reference.Location = new System.Drawing.Point(185, 331);
            this.txt_reference.Name = "txt_reference";
            this.txt_reference.Size = new System.Drawing.Size(173, 20);
            this.txt_reference.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Date Of Payment ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(185, 223);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(229, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // but_cancel
            // 
            this.but_cancel.BackColor = System.Drawing.SystemColors.Window;
            this.but_cancel.Location = new System.Drawing.Point(796, 431);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(101, 34);
            this.but_cancel.TabIndex = 97;
            this.but_cancel.Text = "Cancel";
            this.but_cancel.UseVisualStyleBackColor = false;
            this.but_cancel.Click += new System.EventHandler(this.but_cancel_Click);
            // 
            // but_Save
            // 
            this.but_Save.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.but_Save.Location = new System.Drawing.Point(672, 431);
            this.but_Save.Name = "but_Save";
            this.but_Save.Size = new System.Drawing.Size(101, 34);
            this.but_Save.TabIndex = 96;
            this.but_Save.Text = "Save";
            this.but_Save.UseVisualStyleBackColor = false;
            this.but_Save.Click += new System.EventHandler(this.but_Save_Click);
            // 
            // txt_ChequeNo
            // 
            this.txt_ChequeNo.Location = new System.Drawing.Point(557, 222);
            this.txt_ChequeNo.Name = "txt_ChequeNo";
            this.txt_ChequeNo.Size = new System.Drawing.Size(186, 20);
            this.txt_ChequeNo.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(451, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 116;
            this.label7.Text = "Cheque No";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(431, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 18);
            this.label10.TabIndex = 118;
            this.label10.Text = "Payments Paid ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(139, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 20);
            this.label4.TabIndex = 119;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(139, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 20);
            this.label5.TabIndex = 120;
            this.label5.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(139, 259);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 20);
            this.label11.TabIndex = 121;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(518, 224);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 20);
            this.label12.TabIndex = 122;
            this.label12.Text = "*";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(420, 128);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 13);
            this.error.TabIndex = 123;
            // 
            // error1
            // 
            this.error1.AutoSize = true;
            this.error1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error1.ForeColor = System.Drawing.Color.Red;
            this.error1.Location = new System.Drawing.Point(420, 185);
            this.error1.Name = "error1";
            this.error1.Size = new System.Drawing.Size(0, 13);
            this.error1.TabIndex = 124;
            // 
            // error3
            // 
            this.error3.AutoSize = true;
            this.error3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error3.ForeColor = System.Drawing.Color.Red;
            this.error3.Location = new System.Drawing.Point(749, 220);
            this.error3.Name = "error3";
            this.error3.Size = new System.Drawing.Size(0, 13);
            this.error3.TabIndex = 125;
            // 
            // error2
            // 
            this.error2.AutoSize = true;
            this.error2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error2.ForeColor = System.Drawing.Color.Red;
            this.error2.Location = new System.Drawing.Point(364, 263);
            this.error2.Name = "error2";
            this.error2.Size = new System.Drawing.Size(0, 13);
            this.error2.TabIndex = 126;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 127;
            this.label13.Text = "Transaction ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(139, 162);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 20);
            this.label14.TabIndex = 128;
            this.label14.Text = "*";
            // 
            // txt_transaction
            // 
            this.txt_transaction.Location = new System.Drawing.Point(185, 155);
            this.txt_transaction.Name = "txt_transaction";
            this.txt_transaction.Size = new System.Drawing.Size(229, 20);
            this.txt_transaction.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(486, 231);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 13);
            this.label15.TabIndex = 130;
            // 
            // error9
            // 
            this.error9.AutoSize = true;
            this.error9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error9.ForeColor = System.Drawing.Color.Red;
            this.error9.Location = new System.Drawing.Point(420, 162);
            this.error9.Name = "error9";
            this.error9.Size = new System.Drawing.Size(0, 13);
            this.error9.TabIndex = 132;
            // 
            // Make_payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1046, 503);
            this.Controls.Add(this.error9);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_transaction);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.error2);
            this.Controls.Add(this.error3);
            this.Controls.Add(this.error1);
            this.Controls.Add(this.error);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_ChequeNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_Save);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_reference);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_paymentInvoice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combo_paymentstype);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combo_vendor);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Make_payments";
            this.Text = "Make_payments";
            this.Load += new System.EventHandler(this.Make_payments_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_vendor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_paymentstype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txt_paymentInvoice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_reference;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.Button but_Save;
        private System.Windows.Forms.TextBox txt_ChequeNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Label error1;
        private System.Windows.Forms.Label error3;
        private System.Windows.Forms.Label error2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_transaction;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label error9;
    }
}