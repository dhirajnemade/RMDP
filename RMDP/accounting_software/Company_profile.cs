using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace accounting_software
{
    public partial class Company_profile : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter sda;

        public Company_profile()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void but_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Home h1 = new Home();
            h1.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            but_cancel.Hide();
            but_back.Show();
            but_Save.Show();

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        void FillTextBox()
        {
            try
            {
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LoginData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
                con.Open();
                cmd = new SqlCommand("select * from CompanyProfile", con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {

                    txt_companyname.Text = dr["CompanyName"].ToString();
                    txt_CompanyOwerName.Text = dr["CompanyOwnerName"].ToString();
                    txt_pan.Text = dr["PANcardno"].ToString();
                    txt_officeA.Text = dr["OfficeAddress"].ToString();
                    txt_workA.Text = dr["WorkAddress"].ToString();
                    txt_mob.Text = dr["Mobno"].ToString();
                    txt_phoneno.Text = dr["phoneno"].ToString();
                    txt_dateTo.Text = dr["FinancialyearTill"].ToString();
                    txt_finyear.Text = dr["FinancialyearFrom"].ToString();

                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ea)
            {
                MessageBox.Show("" + ea);
            }
        }


        private void Company_profile_Load(object sender, EventArgs e)
        {
            but_cancel.Show();
            but_back.Hide();
            but_Save.Hide();

            FillTextBox();
        }

        private void but_back_Click(object sender, EventArgs e)
        {
            but_cancel.Show();
            but_Save.Hide();
            but_back.Hide();

        }

        private void but_Save_Click(object sender, EventArgs e)
        {
            try
            {
                string name = "" + txt_companyname.Text;

                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LoginData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
                con.Open();
                cmd = new SqlCommand("update CompanyProfile set CompanyOwnerName='" + txt_CompanyOwerName.Text + "',PANcardno='" + txt_pan.Text + "',OfficeAddress='" + txt_officeA.Text + "',WorkAddress='" + txt_workA.Text + "',phoneno='" + txt_phoneno.Text + "',Mobno='" + txt_mob.Text + "',FinancialyearFrom='" + txt_finyear.Text + "',FinancialyearTill='" + txt_dateTo.Text +"'where CompanyName='" +name+ "';", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Profile is Updates");
            }
                //,CompanyOwnerName='" + txt_CompanyOwerName.Text + "',PANcardno='" + txt_pan.Text + "',OfficeAddress='" + txt_officeA.Text + "',WorkAddress='" + txt_workA.Text + "',phoneno='" + txt_phoneno.Text + "',Mobno='" + txt_mob.Text + "',FinancialyearFrom='" + txt_finyear.Text + "',FinancialyearTill='" + txt_dateTo.Text +*/ 

            catch (Exception ea) { MessageBox.Show("" + ea); }

        }
    }
}
