using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace accounting_software
{
    public partial class UserLogin : Form
    {
        Home h1;
        public UserLogin()
        {
            InitializeComponent();
        }

        private void but_reset_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LoginData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From UserLogin where Username='" + txt_username.Text + "' and Password='" + txt_password.Text + "'", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {

                this.Hide();
                h1 = new Home();
                h1.Show();
            }
            else
            {
                txt_password.ResetText();
                MessageBox.Show("Please check your username and password");

            }

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
