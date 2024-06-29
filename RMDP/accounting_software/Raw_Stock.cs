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
    public partial class Raw_Stock : Form
    {
        SqlConnection con;
        SqlDataAdapter sda;
        SqlCommand cmd;
        DataTable data;
        SqlCommandBuilder scb;

        public Raw_Stock()
        {
            InitializeComponent();
        }

        private void but__Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
                h1.Show();
                this.Close();
        }

        private void Raw_Stock_Load(object sender, EventArgs e)
        {
            try
            {
                ViewALL f1 = new ViewALL();
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LoginData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
                con.Open();
                sda = new SqlDataAdapter("SELECT * FROM Rawmaterial", con);
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
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
            scb = new SqlCommandBuilder();
            scb.DataAdapter = sda;
            sda.Update(data);

        }
    }
}
