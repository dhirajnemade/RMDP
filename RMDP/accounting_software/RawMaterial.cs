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
    public partial class RawMaterial : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter sda;
        int count = 0;

        public void validationTest()
        {
            if (txt_material.Text != "")
            {
                error.Text = "";
            }
            else
            {
                error.Text = " please type name of matarial";
                count = count + 1;
            }
            if (txt_nameofgood.Text != "")
            {
                error1.Text = "";
            }
            else
            {
                error1.Text = "type the name of goods  ";
                count = count + 1;
            }
            if (Regex.Match(txt_qty.Text, @"^[0-9]*$").Success)
            {
                error2.Text = "";
            }
            else
            {
                error2.Text = "Please enter qty in number";
                count = count + 1;
            }
            if (Regex.Match(txt_ValueOfStock.Text, @"^[0-9]*$").Success)
            {
                error3.Text = "";
            }
            else
            {
                error3.Text = "Please enter value of stock no in number";
                count = count + 1;
            }

            if (combo_units.Text != "")
            {
                error4.Text = "";
            }
            else
            {
                error4.Text = "Please selecte the unit of stock";
                count = count + 1;
            }
            if (Regex.Match(txt_transaction.Text, @"^[0-9]*$").Success)
            {
                error9.Text = "";
            }
            else
            {
                error9.Text = "Enter valid entry number ";
                count = count + 1;
            }
        }
        public RawMaterial()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void but_cancel_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            h1.Show();
            this.Close();

        }

        private void RawMaterial_Load(object sender, EventArgs e)
        {

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
                    
                    cmd = new SqlCommand("INSERT INTO Rawmaterial(Material,NameOfGood,Quantity,Units,ValueOfStock,DateOfLastUpdate,EntryNumber) VALUES (@MaterialP,@NameOfGoodP,@QuantityP,@UnitsP,@ValueOfStockP,@DateOfLastUpdateP,@EntryNumberP)", con);
                    cmd.Parameters.AddWithValue("@MaterialP", txt_material.Text.Trim());
                    cmd.Parameters.AddWithValue("@NameOfGoodP", txt_nameofgood.Text.Trim());
                    cmd.Parameters.AddWithValue("@QuantityP", txt_qty.Text.Trim());
                    cmd.Parameters.AddWithValue("@UnitsP", combo_units.Text.Trim());
                    cmd.Parameters.AddWithValue("@ValueOfStockP", txt_ValueOfStock.Text.Trim());
                    cmd.Parameters.AddWithValue("@DateOfLastUpdateP", dateTimePicker1.Text.Trim());
                    cmd.Parameters.AddWithValue("@EntryNumberP", txt_transaction.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New Data has been save");
                    con.Close();
                }
                catch (Exception ea)
                {
                    MessageBox.Show("Invalid Data Entry");

                }
                finally
                {
                    txt_material.ResetText();
                    txt_nameofgood.ResetText();
                    txt_qty.ResetText();
                    txt_ValueOfStock.ResetText();
                    dateTimePicker1.ResetText();
                    combo_units.ResetText();
                    txt_transaction.Text.Trim();
                    
                }
            }
            else
            {
                count = 0;

            }
        }
    }
}
