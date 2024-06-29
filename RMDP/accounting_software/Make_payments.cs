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
using System.Text.RegularExpressions;

namespace accounting_software
{
    public partial class Make_payments : Form
    {
      
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter sda;
        int count = 0;
        public Make_payments()
        {
            InitializeComponent();
            }

        private void but_cancel_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Close();

        }
        public void validationTest()
        {
            if (combo_vendor.Text!= "")
            {
                error.Text = "";
            }
            else
            {
                error.Text = "Please Select the Vendor name";
                count = count + 1;
            }
            if (combo_paymentstype.Text != "")
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
            if (Regex.Match(txt_ChequeNo.Text, @"^[0-9]*$").Success)
            {
                error3.Text = "";
            }
            else
            {
                error3.Text = "Please enter cheque no in number";
                count = count + 1;
            }
           }
        void Fillcombo()
        {
            try
            {
                combo_vendor.Items.Clear();
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LoginData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
                con.Open();
                cmd = new SqlCommand("select Companny_Name from New_Vendor", con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    combo_vendor.Items.Add(dr["Companny_Name"].ToString());
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ea)
            {
                MessageBox.Show("" + ea);
            }

        }

        private void Make_payments_Load(object sender, EventArgs e)
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
                    cmd = new SqlCommand("INSERT INTO Makepayment(VendorName,PaymentType,Chequeno,DateOfPayment,Amount,PaymentOfInvoice,Reference,TransactionID) VALUES (@VendorNameP,@PaymentTypeP,@ChequenoP,@DateOfPaymentP,@AmountP,@PaymentOfInvoiceP,@ReferenceP,@TransactionIDP)", con);
                    cmd.Parameters.AddWithValue("@VendorNameP", combo_vendor.Text.Trim());
                    cmd.Parameters.AddWithValue("@PaymentTypeP", combo_paymentstype.Text.Trim());
                    cmd.Parameters.AddWithValue("@ChequenoP", txt_ChequeNo.Text.Trim());
                    cmd.Parameters.AddWithValue("@DateOfPaymentP", dateTimePicker1.Text.Trim());
                    cmd.Parameters.AddWithValue("@AmountP", txt_amount.Text.Trim());
                    cmd.Parameters.AddWithValue("@PaymentOfInvoiceP", txt_paymentInvoice.Text.Trim());
                    cmd.Parameters.AddWithValue("@ReferenceP", txt_reference.Text.Trim());
                    cmd.Parameters.AddWithValue("@TransactionIDP",txt_transaction.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New Data has been save");
                    con.Close();
                }
                catch (Exception ea)
                {
                    MessageBox.Show("Invalid Data");

                }
                finally
                {
                    combo_vendor.ResetText();
                    combo_paymentstype.ResetText();
                    txt_ChequeNo.ResetText();
                    dateTimePicker1.ResetText();
                    txt_amount.ResetText();
                    txt_paymentInvoice.ResetText();
                    txt_reference.ResetText();
                    txt_transaction.ResetText();

                }
            }
            else
            {
                count = 0;

            }
          }

        private void combo_vendor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        }
    }
