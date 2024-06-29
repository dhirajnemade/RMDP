namespace accounting_software
{
    partial class RawMaterial
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
            this.txt_material = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nameofgood = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.combo_units = new System.Windows.Forms.ComboBox();
            this.txt_ValueOfStock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.but_cancel = new System.Windows.Forms.Button();
            this.but_Save = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.error1 = new System.Windows.Forms.Label();
            this.error2 = new System.Windows.Forms.Label();
            this.error4 = new System.Windows.Forms.Label();
            this.error3 = new System.Windows.Forms.Label();
            this.error9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_transaction = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Material ";
            // 
            // txt_material
            // 
            this.txt_material.Location = new System.Drawing.Point(326, 120);
            this.txt_material.Name = "txt_material";
            this.txt_material.Size = new System.Drawing.Size(251, 20);
            this.txt_material.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name of good ";
            // 
            // txt_nameofgood
            // 
            this.txt_nameofgood.Location = new System.Drawing.Point(326, 152);
            this.txt_nameofgood.Name = "txt_nameofgood";
            this.txt_nameofgood.Size = new System.Drawing.Size(251, 20);
            this.txt_nameofgood.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date of last update ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(326, 299);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(251, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(326, 223);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(133, 20);
            this.txt_qty.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(465, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "units ";
            // 
            // combo_units
            // 
            this.combo_units.FormattingEnabled = true;
            this.combo_units.Items.AddRange(new object[] {
            "g",
            "Kg",
            "Nos ",
            "sets "});
            this.combo_units.Location = new System.Drawing.Point(513, 226);
            this.combo_units.Name = "combo_units";
            this.combo_units.Size = new System.Drawing.Size(64, 21);
            this.combo_units.TabIndex = 4;
            // 
            // txt_ValueOfStock
            // 
            this.txt_ValueOfStock.Location = new System.Drawing.Point(326, 266);
            this.txt_ValueOfStock.Name = "txt_ValueOfStock";
            this.txt_ValueOfStock.Size = new System.Drawing.Size(251, 20);
            this.txt_ValueOfStock.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Value of Stock ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(395, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Stock Update ";
            // 
            // but_cancel
            // 
            this.but_cancel.BackColor = System.Drawing.SystemColors.Window;
            this.but_cancel.Location = new System.Drawing.Point(839, 436);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(101, 34);
            this.but_cancel.TabIndex = 8;
            this.but_cancel.Text = "Cancel";
            this.but_cancel.UseVisualStyleBackColor = false;
            this.but_cancel.Click += new System.EventHandler(this.but_cancel_Click);
            // 
            // but_Save
            // 
            this.but_Save.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.but_Save.Location = new System.Drawing.Point(715, 436);
            this.but_Save.Name = "but_Save";
            this.but_Save.Size = new System.Drawing.Size(101, 34);
            this.but_Save.TabIndex = 7;
            this.but_Save.Text = "Save";
            this.but_Save.UseVisualStyleBackColor = false;
            this.but_Save.Click += new System.EventHandler(this.but_Save_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(287, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 24);
            this.label8.TabIndex = 103;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(287, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 24);
            this.label9.TabIndex = 104;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(287, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 24);
            this.label10.TabIndex = 105;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(490, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 24);
            this.label11.TabIndex = 106;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(287, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 24);
            this.label12.TabIndex = 107;
            this.label12.Text = "*";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(583, 123);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 13);
            this.error.TabIndex = 108;
            // 
            // error1
            // 
            this.error1.AutoSize = true;
            this.error1.ForeColor = System.Drawing.Color.Red;
            this.error1.Location = new System.Drawing.Point(583, 155);
            this.error1.Name = "error1";
            this.error1.Size = new System.Drawing.Size(0, 13);
            this.error1.TabIndex = 109;
            // 
            // error2
            // 
            this.error2.AutoSize = true;
            this.error2.ForeColor = System.Drawing.Color.Red;
            this.error2.Location = new System.Drawing.Point(333, 246);
            this.error2.Name = "error2";
            this.error2.Size = new System.Drawing.Size(0, 13);
            this.error2.TabIndex = 110;
            // 
            // error4
            // 
            this.error4.AutoSize = true;
            this.error4.ForeColor = System.Drawing.Color.Red;
            this.error4.Location = new System.Drawing.Point(583, 231);
            this.error4.Name = "error4";
            this.error4.Size = new System.Drawing.Size(0, 13);
            this.error4.TabIndex = 111;
            // 
            // error3
            // 
            this.error3.AutoSize = true;
            this.error3.ForeColor = System.Drawing.Color.Red;
            this.error3.Location = new System.Drawing.Point(583, 269);
            this.error3.Name = "error3";
            this.error3.Size = new System.Drawing.Size(0, 13);
            this.error3.TabIndex = 112;
            // 
            // error9
            // 
            this.error9.AutoSize = true;
            this.error9.ForeColor = System.Drawing.Color.Red;
            this.error9.Location = new System.Drawing.Point(583, 190);
            this.error9.Name = "error9";
            this.error9.Size = new System.Drawing.Size(0, 13);
            this.error9.TabIndex = 116;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(287, 183);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 24);
            this.label14.TabIndex = 115;
            this.label14.Text = "*";
            // 
            // txt_transaction
            // 
            this.txt_transaction.Location = new System.Drawing.Point(326, 187);
            this.txt_transaction.Name = "txt_transaction";
            this.txt_transaction.Size = new System.Drawing.Size(251, 20);
            this.txt_transaction.TabIndex = 113;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(196, 190);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 114;
            this.label15.Text = "Entry ID";
            // 
            // RawMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 482);
            this.Controls.Add(this.error9);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_transaction);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.error3);
            this.Controls.Add(this.error4);
            this.Controls.Add(this.error2);
            this.Controls.Add(this.error1);
            this.Controls.Add(this.error);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_Save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_ValueOfStock);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.combo_units);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nameofgood);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_material);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "RawMaterial";
            this.Text = "RawMaterial";
            this.Load += new System.EventHandler(this.RawMaterial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_material;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nameofgood;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combo_units;
        private System.Windows.Forms.TextBox txt_ValueOfStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.Button but_Save;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Label error1;
        private System.Windows.Forms.Label error2;
        private System.Windows.Forms.Label error4;
        private System.Windows.Forms.Label error3;
        private System.Windows.Forms.Label error9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_transaction;
        private System.Windows.Forms.Label label15;
    }
}