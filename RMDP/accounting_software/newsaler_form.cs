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
    public partial class newsaler : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        int count = 0;
        public void Validmnumber()
        {
            if (Regex.Match(txt_mob.Text, @"^[0-9]{0,10}$").Success)
            {
                if (Regex.Match(txt_mob.Text,@"^\d{10}$").Success)
                {
                    error2.Text ="";
                }
                else
                {
                    error2.Text="Only 10 digit number";
                    count = count + 1;
                }

            }
            else
            {
                error2.Text="Invalid Mobile Number";
                count = count + 1;
            }
        }
        public void ValidEmail()
        {
            string pattern = null;
            pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            if (Regex.IsMatch(txt_Email.Text, pattern))
            {
                error.Text = "";
            }
            else
            {
                error.Text = "Invalid Email ID";
             count = count + 1;
            }
            if (txt_Companyname.Text=="")
            {
                error3.Text = "Please Enter valid name:";
                count = count + 1;

            }
            else
            {
                error3.Text = "";
            }

            if (Regex.Match(textBox1.Text, @"^[0-9]*$").Success)
            {
                error3.Text = "";
            }
            else
            {
                error3.Text = "Enter valid customer code";
                count = count + 1;
            }
           }
        public newsaler()
        {
            InitializeComponent();
        }
        
        private void but_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_Save_Click(object sender, EventArgs e)
        {
            ValidEmail();
            Validmnumber();

            if (count == 0)
            {
                try
                {
                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LoginData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO Customer_Entery(FristName,LastName,Company_Name,mob,website,B_Street,B_city,B_State,B_ZipCode,B_Fax,B_country,S_Stree,S_City,S_State,S_ZipCode,S_Fax,S_country,Email,CustomerCode) VALUES (@FristNameP,@LastNameP,@Company_NameP,@mobP,@websiteP,@B_StreetP,@B_cityP,@B_StateP,@B_ZipCodeP,@B_FaxP,@B_countryP,@S_streeP,@S_CityP,@S_StateP,@S_ZipCodeP,@S_FaxP,@S_countryP,@EmailP,@CustomerCodeP)", con);
                    cmd.Parameters.AddWithValue("@FristNameP", txt_FristName.Text.Trim());
                    cmd.Parameters.AddWithValue("@LastNameP", txt_lastName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Company_NameP", txt_Companyname.Text.Trim());
                    cmd.Parameters.AddWithValue("@mobP", txt_mob.Text.Trim());
                    cmd.Parameters.AddWithValue("@websiteP", txt_website.Text.Trim());
                    cmd.Parameters.AddWithValue("@B_StreetP", txt_street.Text.Trim());
                    cmd.Parameters.AddWithValue("@B_cityP", txt_city.Text.Trim());
                    cmd.Parameters.AddWithValue("@B_StateP", txt_state.Text.Trim());
                    cmd.Parameters.AddWithValue("@B_ZipCodeP", txt_zipcode.Text.Trim());
                    cmd.Parameters.AddWithValue("@B_FaxP", txt_fax.Text.Trim());
                    cmd.Parameters.AddWithValue("@B_countryP", txt_country.Text.Trim());
                    cmd.Parameters.AddWithValue("@S_streeP", txt_Sstreet.Text.Trim());
                    cmd.Parameters.AddWithValue("@S_CityP", txt_cityc.Text.Trim());
                    cmd.Parameters.AddWithValue("@S_StateP", txt_states.Text.Trim());
                    cmd.Parameters.AddWithValue("@S_ZipCodeP", txt_zipcode1.Text.Trim());
                    cmd.Parameters.AddWithValue("@S_FaxP", txt_fax2.Text.Trim());
                    cmd.Parameters.AddWithValue("@S_countryP", txt_country2.Text.Trim());
                    cmd.Parameters.AddWithValue("@EmailP", txt_Email.Text.Trim());
                    cmd.Parameters.AddWithValue("@CustomerCodeP", textBox1.Text.Trim());
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("New Data has been Save...");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Entry");
                }
            }
            else
            {
                count = 0;
            }
        }

        private void txt_FristName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_lastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Companyname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_phone_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_mob_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_website_TextChanged(object sender, EventArgs e)
        {

        }

        private void newsaler_Load(object sender, EventArgs e)
        {

        }

        private void txt_city_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
