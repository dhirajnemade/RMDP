namespace accounting_software
{
    partial class newsaler
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
            this.lab_companyname = new System.Windows.Forms.Label();
            this.lab_email = new System.Windows.Forms.Label();
            this.txt_Companyname = new System.Windows.Forms.TextBox();
            this.lab_no = new System.Windows.Forms.Label();
            this.lab_PrimaryCon = new System.Windows.Forms.Label();
            this.Com_Primary = new System.Windows.Forms.ComboBox();
            this.txt_FristName = new System.Windows.Forms.TextBox();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_mob = new System.Windows.Forms.TextBox();
            this.lab_website = new System.Windows.Forms.Label();
            this.txt_website = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_street = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_state = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_zipcode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_country = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_fax = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_fax2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_country2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_zipcode1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_states = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_cityc = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_Sstreet = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.but_Save = new System.Windows.Forms.Button();
            this.but_cancel = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.error2 = new System.Windows.Forms.Label();
            this.error3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.error9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_companyname
            // 
            this.lab_companyname.AutoSize = true;
            this.lab_companyname.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_companyname.Location = new System.Drawing.Point(18, 117);
            this.lab_companyname.Name = "lab_companyname";
            this.lab_companyname.Size = new System.Drawing.Size(89, 15);
            this.lab_companyname.TabIndex = 2;
            this.lab_companyname.Text = "Company Name ";
            // 
            // lab_email
            // 
            this.lab_email.AutoSize = true;
            this.lab_email.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_email.Location = new System.Drawing.Point(25, 155);
            this.lab_email.Name = "lab_email";
            this.lab_email.Size = new System.Drawing.Size(82, 15);
            this.lab_email.TabIndex = 5;
            this.lab_email.Text = "Contact E-Mail";
            // 
            // txt_Companyname
            // 
            this.txt_Companyname.Location = new System.Drawing.Point(131, 112);
            this.txt_Companyname.Name = "txt_Companyname";
            this.txt_Companyname.Size = new System.Drawing.Size(269, 20);
            this.txt_Companyname.TabIndex = 4;
            this.txt_Companyname.TextChanged += new System.EventHandler(this.txt_Companyname_TextChanged);
            // 
            // lab_no
            // 
            this.lab_no.AutoSize = true;
            this.lab_no.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_no.Location = new System.Drawing.Point(29, 188);
            this.lab_no.Name = "lab_no";
            this.lab_no.Size = new System.Drawing.Size(78, 15);
            this.lab_no.TabIndex = 11;
            this.lab_no.Text = "Contact Phone";
            // 
            // lab_PrimaryCon
            // 
            this.lab_PrimaryCon.AutoSize = true;
            this.lab_PrimaryCon.Location = new System.Drawing.Point(25, 57);
            this.lab_PrimaryCon.Name = "lab_PrimaryCon";
            this.lab_PrimaryCon.Size = new System.Drawing.Size(80, 13);
            this.lab_PrimaryCon.TabIndex = 13;
            this.lab_PrimaryCon.Text = "Contact Person";
            // 
            // Com_Primary
            // 
            this.Com_Primary.FormattingEnabled = true;
            this.Com_Primary.Items.AddRange(new object[] {
            "Mr.",
            "Mrs.",
            "Ms.",
            "Miss"});
            this.Com_Primary.Location = new System.Drawing.Point(131, 50);
            this.Com_Primary.Name = "Com_Primary";
            this.Com_Primary.Size = new System.Drawing.Size(57, 21);
            this.Com_Primary.TabIndex = 1;
            // 
            // txt_FristName
            // 
            this.txt_FristName.Location = new System.Drawing.Point(194, 51);
            this.txt_FristName.Name = "txt_FristName";
            this.txt_FristName.Size = new System.Drawing.Size(100, 20);
            this.txt_FristName.TabIndex = 2;
            this.txt_FristName.Text = "First Name";
            this.txt_FristName.TextChanged += new System.EventHandler(this.txt_FristName_TextChanged);
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(300, 50);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(100, 20);
            this.txt_lastName.TabIndex = 3;
            this.txt_lastName.Text = "Last Name";
            this.txt_lastName.TextChanged += new System.EventHandler(this.txt_lastName_TextChanged);
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(131, 150);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(269, 20);
            this.txt_Email.TabIndex = 5;
            this.txt_Email.TextChanged += new System.EventHandler(this.txt_Email_TextChanged);
            // 
            // txt_mob
            // 
            this.txt_mob.Location = new System.Drawing.Point(134, 185);
            this.txt_mob.Name = "txt_mob";
            this.txt_mob.Size = new System.Drawing.Size(266, 20);
            this.txt_mob.TabIndex = 7;
            this.txt_mob.Text = "Mob no";
            this.txt_mob.TextChanged += new System.EventHandler(this.txt_mob_TextChanged);
            // 
            // lab_website
            // 
            this.lab_website.AutoSize = true;
            this.lab_website.Location = new System.Drawing.Point(61, 226);
            this.lab_website.Name = "lab_website";
            this.lab_website.Size = new System.Drawing.Size(46, 13);
            this.lab_website.TabIndex = 20;
            this.lab_website.Text = "Website";
            // 
            // txt_website
            // 
            this.txt_website.Location = new System.Drawing.Point(131, 219);
            this.txt_website.Name = "txt_website";
            this.txt_website.Size = new System.Drawing.Size(269, 20);
            this.txt_website.TabIndex = 8;
            this.txt_website.TextChanged += new System.EventHandler(this.txt_website_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(438, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Address ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "BILLING ADDRESS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(649, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "SHIPPING ADDRESS";
            // 
            // txt_street
            // 
            this.txt_street.Location = new System.Drawing.Point(131, 301);
            this.txt_street.Multiline = true;
            this.txt_street.Name = "txt_street";
            this.txt_street.Size = new System.Drawing.Size(269, 47);
            this.txt_street.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Street";
            // 
            // txt_city
            // 
            this.txt_city.Location = new System.Drawing.Point(131, 365);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(269, 20);
            this.txt_city.TabIndex = 10;
            this.txt_city.TextChanged += new System.EventHandler(this.txt_city_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "City";
            // 
            // txt_state
            // 
            this.txt_state.Location = new System.Drawing.Point(131, 404);
            this.txt_state.Name = "txt_state";
            this.txt_state.Size = new System.Drawing.Size(269, 20);
            this.txt_state.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(76, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "State";
            // 
            // txt_zipcode
            // 
            this.txt_zipcode.Location = new System.Drawing.Point(131, 440);
            this.txt_zipcode.Name = "txt_zipcode";
            this.txt_zipcode.Size = new System.Drawing.Size(269, 20);
            this.txt_zipcode.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(54, 445);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 31;
            this.label7.Text = "Zip Code";
            // 
            // txt_country
            // 
            this.txt_country.Location = new System.Drawing.Point(131, 515);
            this.txt_country.Name = "txt_country";
            this.txt_country.Size = new System.Drawing.Size(269, 20);
            this.txt_country.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(59, 520);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 33;
            this.label8.Text = "Country";
            // 
            // txt_fax
            // 
            this.txt_fax.Location = new System.Drawing.Point(131, 478);
            this.txt_fax.Name = "txt_fax";
            this.txt_fax.Size = new System.Drawing.Size(269, 20);
            this.txt_fax.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(83, 483);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 15);
            this.label9.TabIndex = 35;
            this.label9.Text = "Fax";
            // 
            // txt_fax2
            // 
            this.txt_fax2.Location = new System.Drawing.Point(585, 478);
            this.txt_fax2.Name = "txt_fax2";
            this.txt_fax2.Size = new System.Drawing.Size(269, 20);
            this.txt_fax2.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(537, 483);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 15);
            this.label10.TabIndex = 47;
            this.label10.Text = "Fax";
            // 
            // txt_country2
            // 
            this.txt_country2.Location = new System.Drawing.Point(585, 515);
            this.txt_country2.Name = "txt_country2";
            this.txt_country2.Size = new System.Drawing.Size(269, 20);
            this.txt_country2.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(513, 520);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 15);
            this.label11.TabIndex = 45;
            this.label11.Text = "Country";
            // 
            // txt_zipcode1
            // 
            this.txt_zipcode1.Location = new System.Drawing.Point(585, 440);
            this.txt_zipcode1.Name = "txt_zipcode1";
            this.txt_zipcode1.Size = new System.Drawing.Size(269, 20);
            this.txt_zipcode1.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(508, 445);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 15);
            this.label12.TabIndex = 43;
            this.label12.Text = "Zip Code";
            // 
            // txt_states
            // 
            this.txt_states.Location = new System.Drawing.Point(585, 404);
            this.txt_states.Name = "txt_states";
            this.txt_states.Size = new System.Drawing.Size(269, 20);
            this.txt_states.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(530, 409);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 15);
            this.label13.TabIndex = 41;
            this.label13.Text = "State";
            // 
            // txt_cityc
            // 
            this.txt_cityc.Location = new System.Drawing.Point(585, 365);
            this.txt_cityc.Name = "txt_cityc";
            this.txt_cityc.Size = new System.Drawing.Size(269, 20);
            this.txt_cityc.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(532, 370);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 15);
            this.label14.TabIndex = 39;
            this.label14.Text = "City";
            // 
            // txt_Sstreet
            // 
            this.txt_Sstreet.Location = new System.Drawing.Point(585, 301);
            this.txt_Sstreet.Multiline = true;
            this.txt_Sstreet.Name = "txt_Sstreet";
            this.txt_Sstreet.Size = new System.Drawing.Size(269, 47);
            this.txt_Sstreet.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(526, 323);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 15);
            this.label15.TabIndex = 37;
            this.label15.Text = "Street";
            // 
            // but_Save
            // 
            this.but_Save.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.but_Save.Location = new System.Drawing.Point(685, 564);
            this.but_Save.Name = "but_Save";
            this.but_Save.Size = new System.Drawing.Size(101, 34);
            this.but_Save.TabIndex = 21;
            this.but_Save.Text = "Save";
            this.but_Save.UseVisualStyleBackColor = false;
            this.but_Save.Click += new System.EventHandler(this.but_Save_Click);
            // 
            // but_cancel
            // 
            this.but_cancel.BackColor = System.Drawing.SystemColors.Window;
            this.but_cancel.Location = new System.Drawing.Point(809, 564);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(101, 34);
            this.but_cancel.TabIndex = 22;
            this.but_cancel.Text = "Cancel";
            this.but_cancel.UseVisualStyleBackColor = false;
            this.but_cancel.Click += new System.EventHandler(this.but_cancel_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(414, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 18);
            this.label16.TabIndex = 51;
            this.label16.Text = "New Customer";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(406, 157);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 13);
            this.error.TabIndex = 52;
            // 
            // error2
            // 
            this.error2.AutoSize = true;
            this.error2.ForeColor = System.Drawing.Color.Red;
            this.error2.Location = new System.Drawing.Point(406, 188);
            this.error2.Name = "error2";
            this.error2.Size = new System.Drawing.Size(0, 13);
            this.error2.TabIndex = 53;
            // 
            // error3
            // 
            this.error3.AutoSize = true;
            this.error3.ForeColor = System.Drawing.Color.Red;
            this.error3.Location = new System.Drawing.Point(407, 117);
            this.error3.Name = "error3";
            this.error3.Size = new System.Drawing.Size(0, 13);
            this.error3.TabIndex = 54;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(113, 113);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(15, 20);
            this.label17.TabIndex = 102;
            this.label17.Text = "*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(113, 148);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(15, 20);
            this.label18.TabIndex = 103;
            this.label18.Text = "*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(113, 183);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(15, 20);
            this.label19.TabIndex = 104;
            this.label19.Text = "*";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(25, 85);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 13);
            this.label20.TabIndex = 105;
            this.label20.Text = "Customer Code";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 20);
            this.textBox1.TabIndex = 106;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(113, 80);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(15, 20);
            this.label21.TabIndex = 107;
            this.label21.Text = "*";
            // 
            // error9
            // 
            this.error9.AutoSize = true;
            this.error9.ForeColor = System.Drawing.Color.Red;
            this.error9.Location = new System.Drawing.Point(407, 85);
            this.error9.Name = "error9";
            this.error9.Size = new System.Drawing.Size(0, 13);
            this.error9.TabIndex = 108;
            // 
            // newsaler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(927, 610);
            this.Controls.Add(this.error9);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.error3);
            this.Controls.Add(this.error2);
            this.Controls.Add(this.error);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_Save);
            this.Controls.Add(this.txt_fax2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_country2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_zipcode1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_states);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_cityc);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_Sstreet);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_fax);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_country);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_zipcode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_state);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_city);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_street);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_website);
            this.Controls.Add(this.lab_website);
            this.Controls.Add(this.txt_mob);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_lastName);
            this.Controls.Add(this.txt_FristName);
            this.Controls.Add(this.Com_Primary);
            this.Controls.Add(this.lab_PrimaryCon);
            this.Controls.Add(this.lab_no);
            this.Controls.Add(this.txt_Companyname);
            this.Controls.Add(this.lab_email);
            this.Controls.Add(this.lab_companyname);
            this.MaximizeBox = false;
            this.Name = "newsaler";
            this.Text = "New Customer";
            this.Load += new System.EventHandler(this.newsaler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_companyname;
        private System.Windows.Forms.Label lab_email;
        private System.Windows.Forms.TextBox txt_Companyname;
        private System.Windows.Forms.Label lab_no;
        private System.Windows.Forms.Label lab_PrimaryCon;
        private System.Windows.Forms.ComboBox Com_Primary;
        private System.Windows.Forms.TextBox txt_FristName;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_mob;
        private System.Windows.Forms.Label lab_website;
        private System.Windows.Forms.TextBox txt_website;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_street;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_state;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_zipcode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_country;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_fax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_fax2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_country2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_zipcode1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_states;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_cityc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_Sstreet;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button but_Save;
        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Label error2;
        private System.Windows.Forms.Label error3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label error9;
    }
}