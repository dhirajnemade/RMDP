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
    public partial class Payment_Received : Form
    {

        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter sda;
        int count = 0;
        
        public void validationTest()
        {
            if (combo_customernaem.Text != "")
            {
                error.Text = "";
            }
            else
            {
                error.Text = "Please Select the customer name";
                count = count + 1;
            }
            if (combo_Payments.Text != "")
            {
                error1.Text = "";
            }
            else
            {
                error1.Text = "Please selecte payment type ";
                count = count + 1;
            }
            if (Regex.Match(txt_amount.Text, @"^[0-9]*$").Success)
            {
                error2.Text = "";
            }
            else
            {
                error2.Text = "Please enter amount in number";
                count = count + 1;
            }
                if (Regex.Match(txt_cheque.Text, @"^[0-9]*$").Success)
                {
                    error3.Text = "";
                }
                else
                {
                    error3.Text = "Please enter cheque no in number";
                    count = count + 1;
                }

                if (Regex.Match(txt_transaction.Text, @"^[0-9]*$").Success)
                {
                    error9.Text = "";
                }
                else
                {
                    error9.Text = "invalid transaction ID";
                    count = count + 1;
                }
              
              }
        public Payment_Received()
        {
            InitializeComponent();
        }

        private void but_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Home h = new Home();
            h.Show();

        }
        void Fillcombo()
        {
            try
            {
                combo_customernaem.Items.Clear();
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LoginData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
                con.Open();
                cmd = new SqlCommand("select Company_Name from Customer_Entery", con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    combo_customernaem.Items.Add(dr["Company_Name"].ToString());
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ea)
            {
                MessageBox.Show("" + ea);
            }
        }
        private void Payment_Received_Load(object sender, EventArgs e)
        {
            Fillcombo();

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
                    cmd = new SqlCommand("INSERT INTO PaymentRecieved(CustomerName,PaymentType,ChequeNo,DateOfPayment,Amount,PaymentOfInvoice,Reference,CompanyTransactionNo) VALUES (@CustomerNameP,@PaymentTypeP,@ChequeNoP,@DateOfPaymentP,@AmountP,@PaymentOfInvoiceP,@ReferenceP,@CompanyTransactionNoP)", con);
                    cmd.Parameters.AddWithValue("@CustomerNameP", combo_customernaem.Text.Trim());
                    cmd.Parameters.AddWithValue("@PaymentTypeP", combo_Payments.Text.Trim());
                    cmd.Parameters.AddWithValue("@ChequeNoP", txt_cheque.Text.Trim());
                    cmd.Parameters.AddWithValue("@DateOfPaymentP", dateTimePicker1.Text.Trim());
                    cmd.Parameters.AddWithValue("@AmountP", txt_amount.Text.Trim());
                    cmd.Parameters.AddWithValue("@PaymentOfInvoiceP", txt_PaymentOfInvoice.Text.Trim());
                    cmd.Parameters.AddWithValue("@ReferenceP", txt_reference.Text.Trim());
                    cmd.Parameters.AddWithValue("@CompanyTransactionNoP", txt_transaction.Text.Trim());

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
                    combo_customernaem.ResetText();
                    combo_Payments.ResetText();
                    txt_cheque.ResetText();
                    dateTimePicker1.ResetText();
                    txt_amount.ResetText();
                    txt_PaymentOfInvoice.ResetText();
                    txt_reference.ResetText();
                    txt_transaction.ResetText();
                    txt_transaction.ResetText();


                }
            }
            else
            {
                count = 0;

            }
        }

        private void combo_Payments_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
