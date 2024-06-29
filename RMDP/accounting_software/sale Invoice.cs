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
    
    public partial class NewInvoice : Form
    {

        float rate, qty, netamount, tax, taxa, subamount, shipppingcharges, adjustment,GrandTotal;
        String tname;
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter sda;
        SqlDataReader srd;
        int count = 0;

        public void validationTest()
        {
            if (combox_customername.Text !="")
            {
                error.Text = "";
            }
            else
            {
                error.Text = "Please Select the customer name";
                count = count+1;
             }
            if (cmb_tax.Text!="")
            {
                error6.Text = "";

            }
            else
            {
                error6.Text = "Please Select the specific tax";
                count = count + 1;
            }

            if (Regex.Match(txt_invoice.Text, @"^[0-9]*$").Success)
            {
                error1.Text = "";
            }
            else
            {
                error1.Text = "Please enter valid Bill no";
                count = count + 1;

            }
            if (Regex.Match(txt_qty.Text, @"^[0-9]*$").Success)
            {
                error2.Text = "";
            }
            else
            {
                error2.Text = "Please enter quantity in number";
                count = count + 1;

            }
            if (Regex.Match(txt_rate.Text, @"^[0-9]*$").Success)
            {
                error3.Text = "";
            }
            else
            {
                error3.Text = "Please enter amount in number";
                count = count + 1;
            }
            if (Regex.Match(txt_adjusment.Text, @"^[0-9]*$").Success)
            {
                error5.Text = "";
            }
            else
            {
                error5.Text = "Please enter adjusment amount in number";
                count = count + 1;
            }
            if (Regex.Match(txt_shpping.Text, @"^[0-9]*$").Success)
            {
                error4.Text = "";
            }
            else
            {
                error4.Text = "Please enter shipping charges amount in number";
                count = count + 1;
            }

        }
        public NewInvoice()
        {
            InitializeComponent();
             
        }
               
         private void but_cancel_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Close();

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            newsaler ns = new newsaler();
            ns.Show();
           
           
        }
       
        private void but_Save_Click(object sender, EventArgs e)
        {
            validationTest();
            if (count == 0)
            {
                try
                {
                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LoginData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                    con.Open();
                    //
                    cmd = new SqlCommand("INSERT INTO salesInvoice(CustomerName,Invoiceno,OrderNo,InvoiceDate,Terms,DueDate,ItemDetails,Quantity,Rate,Discount,Tax,SubTotal,ShippingCharges,GrandTotal) VALUES (@CustomerNameP,@InvoicenoP,@OrderNoP,@InvoiceDateP,@TermsP,@DueDateP,@ItemDetailsP,@QuantityP,@RateP,@DiscountP,@TaxP,@SubTotalP,@ShippingChargesP,@GrandTotalP)", con);
                    cmd.Parameters.AddWithValue("@CustomerNameP", combox_customername.Text.Trim());
                    cmd.Parameters.AddWithValue("@InvoicenoP", txt_invoice.Text.Trim());
                    cmd.Parameters.AddWithValue("@OrderNoP", txt_orderno.Text.Trim());
                    cmd.Parameters.AddWithValue("@InvoiceDateP", dateTimePicker1.Text.Trim());
                    cmd.Parameters.AddWithValue("@termsP", comboBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@DueDateP", dateTimePicker1.Text.Trim());
                    cmd.Parameters.AddWithValue("@ItemDetailsP", txt_iteamdetails.Text.Trim());
                    cmd.Parameters.AddWithValue("@QuantityP", txt_qty.Text.Trim());
                    cmd.Parameters.AddWithValue("@RateP", txt_rate.Text.Trim());
                    cmd.Parameters.AddWithValue("@DiscountP", txt_netamount.Text.Trim());
                    cmd.Parameters.AddWithValue("@TaxP", taxa);
                    cmd.Parameters.AddWithValue("@SubtotalP", subamount);
                    cmd.Parameters.AddWithValue("@ShippingChargesP", shipppingcharges);
                    cmd.Parameters.AddWithValue("@GrandTotalP", GrandTotal);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("New Data has been Save..");
                    Home h1 = new Home();
                    h1.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Data");
                }
            }
            else
            {
                count = 0;

            }
              }
        private void cmb_tax_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (cmb_tax.Text == "13.5%")
                {
                    tax = 13.5f;
                    tname = "Vat tax";

                }
                if (cmb_tax.Text == "2%")
                {
                    tax = 2.0f;
                    tname = "CST tax";
                }
                if (cmb_tax.Text == "15%")
                {
                    tax = 15.0f;
                    tname = "Service Tax";
                }
                taxa = (netamount * tax) / 100;
                lb_tax.Text = "" + taxa;
                subamount = taxa + netamount;
                lb_total.Text = "" + subamount;
                GrandTotal = subamount + shipppingcharges + adjustment;
                lb_grandTotal.Text = "" + GrandTotal;         
            }
            catch (Exception ea) { }
        }


        private void lb_tax_Click(object sender, EventArgs e)
        {
            try
            {
                taxa = (netamount * tax) / 100;
                lb_tax.Text = "" + taxa;
            }
            catch (Exception ea) {}
        }

        private void txt_netamount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                rate = float.Parse(txt_rate.Text);
                qty = float.Parse(txt_qty.Text);

                netamount = qty * rate;
                txt_netamount.Text = "" + netamount;
            }
            catch (Exception ea) {}
        }

        private void lb_total_Click(object sender, EventArgs e)
        {
            try
            {
                subamount = taxa + netamount;
                lb_total.Text = "" + subamount;
                GrandTotal = subamount + shipppingcharges + adjustment;
                lb_grandTotal.Text = "" + GrandTotal;

            }
            catch (Exception ea) {  }
        }

        private void lb_shipping_Click(object sender, EventArgs e)
        {
            try
            {
                shipppingcharges = float.Parse(txt_shpping.Text);
                lb_shipping.Text = "" + shipppingcharges;
            }
            catch (Exception ea) { }
        }
        
        private void lb_adjusment_Click(object sender, EventArgs e)

        {
            try
            {
                adjustment = float.Parse(txt_adjusment.Text);
                lb_adjusment.Text = "" + adjustment;
            }
            catch (Exception ea) {}
        }

        private void lb_grandTotal_Click(object sender, EventArgs e)
        {
            try
            {
                GrandTotal = subamount + shipppingcharges + adjustment;
                lb_grandTotal.Text = "" + GrandTotal;
            }
            catch (Exception ea) {}
        }
        void Fillcombo()
        {
            try
            {
                combox_customername.Items.Clear();
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LoginData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
                con.Open();
                cmd = new SqlCommand("select Company_Name from Customer_Entery", con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    combox_customername.Items.Add(dr["Company_Name"].ToString());
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ea)
            {
                MessageBox.Show("" + ea);
            }

        }
        private void NewInvoice_Load(object sender, EventArgs e)
        {
            Fillcombo();

        }

        private void combox_customername_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_shpping_TextChanged(object sender, EventArgs e)
        {
            try
            {
                shipppingcharges = float.Parse(txt_shpping.Text);
                lb_shipping.Text = "" + shipppingcharges;
                GrandTotal = subamount + shipppingcharges + adjustment;
                lb_grandTotal.Text = "" + GrandTotal;
            }
            catch (Exception ea) { }
        }

        private void txt_adjusment_TextChanged(object sender, EventArgs e)
        {
            try
            {
                adjustment = float.Parse(txt_adjusment.Text);
                lb_adjusment.Text = "" + adjustment;
                GrandTotal = subamount + shipppingcharges + adjustment;
                lb_grandTotal.Text = "" + GrandTotal;
            }
            catch (Exception ea) { }
        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_rate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
