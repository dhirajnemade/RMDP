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
    public partial class View_Payments : Form
    {

        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable data;

        public View_Payments()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LoginData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
                con.Open();
                sda = new SqlDataAdapter("SELECT * FROM Makepayment", con);
                data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ea)
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LoginData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
                con.Open();
                sda = new SqlDataAdapter("SELECT * FROM PaymentRecieved", con);
                data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ea)
            {

            }
        }

        private void Bt_Back_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            h1.Show();
            this.Close();
   

        }

        private void View_Payments_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
            scb = new SqlCommandBuilder();
            scb.DataAdapter = sda;
            sda.Update(data);

        }

     }
}
