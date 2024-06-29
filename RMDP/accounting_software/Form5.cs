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


namespace accounting_software
{
    public partial class ViewALL : Form
    {
        string nameoftable;
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable data;

     
        public ViewALL()
        {

            InitializeComponent();
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ViewALL f1 = new ViewALL();
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LoginData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
                con.Open();
                sda = new SqlDataAdapter("SELECT * FROM PurchaseBills", con);
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ViewALL f1 = new ViewALL();
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LoginData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
                con.Open();
                sda = new SqlDataAdapter("SELECT * FROM SalesInvoice", con);
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                ViewALL f1 = new ViewALL();
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LoginData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
                con.Open();
                sda = new SqlDataAdapter("SELECT * FROM SaleOrder", con);
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ViewALL f1 = new ViewALL();
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LoginData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
                con.Open();
                sda = new SqlDataAdapter("SELECT * FROM PurchaseOrder", con);
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

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                ViewALL f1 = new ViewALL();
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LoginData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
                con.Open();
                sda = new SqlDataAdapter("SELECT * FROM Expenses", con);
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

        private void Back_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            h1.Show();
            this.Close();
        }

        private void ViewALL_Load(object sender, EventArgs e)
        {
            /*if (button1.Text.Equals("Sale Invoice "))
            {
                nameoftable = "salesInvoice";
            }
            if (button4.Text.Equals("Sale Order"))
            {
                nameoftable = "SaleOrder";
            }
            if (button3.Text.Equals("Purchase Invoice "))
            {
                nameoftable = "PurchaseBills";
            }
            if (button2.Text.Equals("Purchase Order "))
            {
                nameoftable = "PurchaseOrder";

            }
            if (button5.Text.Equals("Expenses"))
            {
                nameoftable = "Expenses";
            }
            */
        }

        private void button6_Click(object sender, EventArgs e)
        {

            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
            scb = new SqlCommandBuilder();
            scb.DataAdapter = sda;
            sda.Update(data);
        }

        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
        
        }
    }
}
