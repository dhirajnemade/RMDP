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
  
     public partial class Vendor : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter sda;
        int count = 0;
        public void Validmnumber()
        {
            if (Regex.Match(txt_mob.Text, @"^[0-9]{0,10}$").Success)
            {
                if (Regex.Match(txt_mob.Text, @"^\d{10}$").Success)
                {
                    error2.Text = "";
                }
                else
                {
                    error2.Text = "Only 10 digit number";
                    count = count + 1;

                }

            }
            else
            {
                error2.Text = "Invalid Mobile Number";
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
            if (txt_Companyname.Text == "")
            {
                error3.Text = "Please Enter valid name:";
                count = count + 1;

            }
            else
            {
                error3.Text = "";
            }
            
        }

         public Vendor()
        {
            InitializeComponent();
        }

        private void Vendor_Load(object sender, EventArgs e)
        {

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
                    cmd = new SqlCommand("INSERT INTO New_Vendor(Vendor_code,Frist_Name,Last_Name,Companny_Name,Mob_no,website,B_Street,B_City,B_state,B_Zip_cade,B_fax,B_counrty,S_Street,S_CIty,S_state,S_zip_code,S_fax,S_country,Email) VALUES (@Vendor_codeP,@Frist_NameP,@Last_NameP,@Companny_NameP,@Mob_noP,@websiteP,@B_StreetP,@B_CityP,@B_stateP,@B_Zip_cadeP,@B_faxP,@B_counrtyP,@S_StreetP,@S_CItyP,@S_stateP,@S_zip_codeP,@S_faxP,@S_countryP,@EmailP)", con);
                    cmd.Parameters.AddWithValue("@Vendor_codeP", txt_vendorcode.Text.Trim());
                    cmd.Parameters.AddWithValue("@Frist_NameP", txt_FristName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Last_NameP", txt_lastName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Companny_NameP", txt_Companyname.Text.Trim());
                    cmd.Parameters.AddWithValue("@Mob_noP", txt_mob.Text.Trim());
                    cmd.Parameters.AddWithValue("@websiteP", txt_website.Text.Trim());
                    cmd.Parameters.AddWithValue("@B_StreetP", txt_street.Text.Trim());
                    cmd.Parameters.AddWithValue("@B_CityP", txt_city.Text.Trim());
                    cmd.Parameters.AddWithValue("@B_stateP", txt_state.Text.Trim());
                    cmd.Parameters.AddWithValue("@B_Zip_cadeP", txt_zipcode.Text.Trim());
                    cmd.Parameters.AddWithValue("@B_faxP", txt_fax.Text.Trim());
                    cmd.Parameters.AddWithValue("@B_counrtyP", txt_country.Text.Trim());
                    cmd.Parameters.AddWithValue("@S_StreetP", txt_Sstreet.Text.Trim());
                    cmd.Parameters.AddWithValue("@S_CItyP", txt_cityc.Text.Trim());
                    cmd.Parameters.AddWithValue("@S_stateP", txt_states.Text.Trim());
                    cmd.Parameters.AddWithValue("@S_zip_codeP", txt_zipcode1.Text.Trim());
                    cmd.Parameters.AddWithValue("@S_faxP", txt_fax2.Text.Trim());
                    cmd.Parameters.AddWithValue("@S_countryP", txt_country2.Text.Trim());
                    cmd.Parameters.AddWithValue("@EmailP", txt_Email.Text.Trim());


                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("New Data has been Save...");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Data entry");
                }
            }
            else
            {
                count = 0;
            }
        }

        private void txt_Sstreet_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
