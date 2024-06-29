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
    public partial class ledger : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter sda;

        public ledger()
        {
            InitializeComponent();
        }

        private void but_cancel_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            h1.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ViewALL f1 = new ViewALL();
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LoginData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
                con.Open();
                sda = new SqlDataAdapter("SELECT InvoiceDate,Invoiceno,GrandTotal FROM salesInvoice where CustomerName='" + combo_customer.Text + "'", con);
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;
                
                sda = new SqlDataAdapter("SELECT ChequeNo,DateOfPayment,Amount FROM PaymentRecieved where CustomerName='" + combo_customer.Text + "'", con);
                DataTable data1 = new DataTable();
                sda.Fill(data1);
                dataGridView2.DataSource=data1;
                               
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ea)
            {

            }
            /*try
            {                
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LoginData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
                con.Open();
                sda = new SqlDataAdapter("SELECT InvoiceDate,Invoiceno,GrandTotal FROM salesInvoice where CustomerName='" + combo_customer.Text + "'", con);
                DataTable data = new DataTable();                
                sda.Fill(data);
                dataGridView1.DataSource = data;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ea)
            {
                MessageBox.Show(""+ea);
            }
            */
        }

        void Fillcombo1()
        {
            try
            {
                comboBox1.Items.Clear();
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LoginData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
                con.Open();
                cmd = new SqlCommand("select Companny_Name from New_Vendor", con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    comboBox1.Items.Add(dr["Companny_Name"].ToString());
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ea)
            {
                MessageBox.Show("" + ea);
            }

        }

        void Fillcombo()
        {
            try
            {
                combo_customer.Items.Clear();
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LoginData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
                con.Open();
                cmd = new SqlCommand("select Company_Name from Customer_Entery", con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    combo_customer.Items.Add(dr["Company_Name"].ToString());
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ea)
            {
                MessageBox.Show("" + ea);
            }

        }
        private void ledger_Load(object sender, EventArgs e)
        {
            Fillcombo();
            Fillcombo1();
            comboBox1.Visible = false;
            button2.Visible = false;
            label3.Visible = false;
            combo_customer.Visible = false;
            label2.Visible = false;
            button1.Visible = false;

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void combo_customer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LoginData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
            con.Open();
            sda = new SqlDataAdapter("SELECT PurchaseOrder,Invoiceno,GrandTotal FROM PurchaseBills where VendorName='" +comboBox1.Text+ "'", con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;

            sda = new SqlDataAdapter("SELECT Chequeno,DateOfPayment,Amount FROM Makepayment where VendorName='" +comboBox1.Text+ "'", con);
            DataTable data1 = new DataTable();
            sda.Fill(data1);
            dataGridView2.DataSource = data1;

            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            combo_customer.Visible = true;
            button1.Visible = true;

            comboBox1.Visible = false;
            button2.Visible = false;
            label3.Visible = false;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = true;
            comboBox1.Visible = true;
            button2.Visible = true;

            combo_customer.Visible = false;
            label2.Visible = false;
            button1.Visible = false;

        }
    }
}
