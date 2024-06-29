using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Text.RegularExpressions;


namespace accounting_software
{
    public partial class Ex : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter sda;
        int count = 0;


        public void validationTest()
        {
            if (comboBox1.Text != "")
            {
                error.Text = "";
            }
            else
            {
                error.Text = "Please Select the Vendor name";
                count = count + 1;
            }
            if (Regex.Match(textBox1.Text, @"^[0-9]*$").Success)
            {
                error2.Text = "";
            }
            else
            {
                error2.Text = "Please enter amount in number";
                count = count + 1;
            }
            if (Regex.Match(textBox2.Text, @"^[0-9]*$").Success)
            {
                error3.Text = "";
            }
            else
            {
                error3.Text = "Please enter cheque no in number";
                count = count + 1;
            }
            if (Regex.Match(txt_transaction.Text, @"^[0-9]*$").Success)
            {
                error9.Text = "";
            }
            else
            {
                error9.Text = "valid transaction ID";
                count = count + 1;
            }
           
        }

        public Ex()
        {
            InitializeComponent();
        }

        private void but_Save_Click(object sender, EventArgs e)
        {
            validationTest();
            if (count == 0)
            {
                try
                {

                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LoginData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO Expenses(Date,Datatype,Amount,Tax,Reference,Note,TransactionID) VALUES (@DateP,@DatatypeP,@AmountP,@TaxP,@ReferenceP,@NoteP,@TransactionIDP)", con);
                    
                    cmd.Parameters.AddWithValue("@DateP", dateTimePicker1.Text.Trim());
                    cmd.Parameters.AddWithValue("@DatatypeP", comboBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@AmountP", textBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@TaxP", textBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@ReferenceP", textBox3.Text.Trim());
                    cmd.Parameters.AddWithValue("@NoteP", textBox4.Text.Trim());
                    cmd.Parameters.AddWithValue("@TransactionIDP", txt_transaction.Text.Trim());

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("New Data has been Save..");
                    Home h1 = new Home();
                    h1.Show();
                    this.Close();
                }
                catch (Exception ea)
                {
                    MessageBox.Show("Invalid Data");

                }
            }
            else
            {
                count = 0;

            }
        }

        private void but_cancel_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            this.Close();
            h1.Show();

        }

        private void Ex_Load(object sender, EventArgs e)
        {

        }
    }
}
