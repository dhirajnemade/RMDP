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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtcurrentpass.ResetText();
            txtnewpass.ResetText();
            txtrenewpass.ResetText();
            txtuesername.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            h1.Show();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LoginData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From USERLOGIN where USERNAME='" +txtuesername.Text+ "' and PASSWORD='"+txtcurrentpass.Text+"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            errorProvider.Clear();
            if (dt.Rows[0][0].ToString() == "1")
            {
                if (txtnewpass.Text == txtrenewpass.Text)
                {
                    SqlDataAdapter sda1 = new SqlDataAdapter("update USERLOGIN set PASSWORD='"+txtrenewpass.Text+"'where USERNAME='"+txtuesername.Text+"'and PASSWORD='"+txtcurrentpass.Text+"'",con);
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);
                    MessageBox.Show("Password Changes...!!!","message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    UserLogin l1 = new UserLogin();
                    l1.Show();
                    this.Close();
                }
                else
                {
                    errorProvider.SetError(txtnewpass,"Unmatch password");
                    errorProvider.SetError(txtrenewpass,"unmatch Password");

                }

            }
                else
                {
                    errorProvider.SetError(txtuesername, "Incorrect user name");
                    errorProvider.SetError(txtcurrentpass,"Incorrect password");

                }
            }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        }
    }

