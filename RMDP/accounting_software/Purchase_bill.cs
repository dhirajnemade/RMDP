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
    public partial class Purchase_bill : Form
    {
        float netamount,taxn,tax, rate, qty, subtotal, shipping,adjustment, grandtotal;
        string taxName;
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter sda;
        SqlDataReader srd;
        int count = 0;

        public void validationTest()
        {
            if (combox_customername.Text != "")
            {
                error.Text = "";
            }
            else
            {
                error.Text = "Please Select the customer name";
                count = count + 1;
            }
            if (combo_po.Text!= "")
            {
                error2.Text = "";
            }
            else
            {
                error2.Text = "Please selecte po number ";
                count = count + 1;
            }
            if (combo_tax.Text != "")
            {
                error7.Text = "";

            }
            else
            {
                error7.Text = "Please Select the specific tax";
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
                error3.Text = "";
            }
            else
            {
                error3.Text = "Please enter quantity in number";
                count = count + 1;

            }
            if (Regex.Match(txt_rate.Text, @"^[0-9]*$").Success)
            {
                error4.Text = "";
            }
            else
            {
                error4.Text = "Please enter amount in number";
                count = count + 1;
            }
            if (Regex.Match(txt_adjustment.Text, @"^[0-9]*$").Success)
            {
                error6.Text = "";
            }
            else
            {
                error6.Text = "Please enter adjusment amount in number";
                count = count + 1;
            }
            if (Regex.Match(txt_shpping.Text, @"^[0-9]*$").Success)
            {
                error5.Text = "";
            }
            else
            {
                error5.Text = "Please enter shipping charges amount in number";
                count = count + 1;
            }

        }
        public Purchase_bill()
        {
            InitializeComponent();
           }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        void FillCombopo()
        {
            try
            {
                combo_po.Items.Clear();
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LoginData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
                con.Open();
                cmd = new SqlCommand("select PurchaseOrder from PurchaseOrder", con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {

                    combo_po.Items.Add(dr["PurchaseOrder"].ToString());
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
                combox_customername.Items.Clear();
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LoginData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
                con.Open();
                cmd = new SqlCommand("select Companny_Name from New_Vendor", con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    combox_customername.Items.Add(dr["Companny_Name"].ToString());
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ea) 
            {
                MessageBox.Show("" + ea);
            }

        }

        private void but_cancel_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
          this.Hide();


        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Vendor v = new Vendor();
            v.Show();

        }

        private void Purchase_bill_Load(object sender, EventArgs e)
        {
            Fillcombo();
            FillCombopo();
        }

        private void but_Save_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LoginData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
                con.Open();
                cmd = new SqlCommand("INSERT INTO PurchaseBills(VendorName,Invoiceno,PurchaseOrder,PurchaseDate,DueDate,ItemDetails,Quantity,Rate,Discount,Tax,SubTotal,ShippingCharges,GrandTotal) VALUES (@VendorNameP,@InvoicenoP,@PurchaseOrderP,@PurchaseDateP,@DueDateP,@ItemDetailsP,@QuantityP,@RateP,@DiscountP,@TaxP,@SubTotalP,@ShippingChargesP,@GrandTotalP)", con);
                cmd.Parameters.AddWithValue("@VendorNameP", combox_customername.Text.Trim());
                cmd.Parameters.AddWithValue("@InvoicenoP", txt_invoice.Text.Trim());
                cmd.Parameters.AddWithValue("@PurchaseOrderP", combo_po.Text.Trim());
                cmd.Parameters.AddWithValue("@PurchaseDateP", dateTimePicker1.Text.Trim());
                cmd.Parameters.AddWithValue("@DueDateP", dateTimePicker2.Text.Trim());
                cmd.Parameters.AddWithValue("@ItemDetailsP", txt_itemdetails.Text.Trim());
                cmd.Parameters.AddWithValue("@QuantityP", qty);
                cmd.Parameters.AddWithValue("@RateP", rate);
                cmd.Parameters.AddWithValue("@DiscountP", netamount);
                cmd.Parameters.AddWithValue("@TaxP", taxn);
                cmd.Parameters.AddWithValue("@SubTotalP", subtotal);
                cmd.Parameters.AddWithValue("@ShippingChargesP", shipping);
                cmd.Parameters.AddWithValue("@GrandTotalP", grandtotal);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("New Data has been save...");
                Home h1 = new Home();
                h1.Show();
                this.Close();
            }
            catch (Exception ea)
            {
                MessageBox.Show("Invalid Data");
            }
           }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                qty = float.Parse(txt_qty.Text);
            }
            catch (Exception ea) { MessageBox.Show("Invalid Data entry"); }

        }

        private void txt_rate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                rate = float.Parse(txt_rate.Text);
            }
            catch (Exception ea) { MessageBox.Show("Invalid Data entry"); }
        }

        private void txt_netamount_TextChanged(object sender, EventArgs e)
        {
            try
            {

                netamount = qty * rate;
                txt_netamount.Text = "" + netamount;
            }
            catch (Exception ea) { MessageBox.Show("Invalid Data entry"); }

        }

        private void combo_tax_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (combo_tax.Text.Equals("5%"))
                {
                    tax = 5;
                    taxName = "Vat tax";

                }
                if (combo_tax.Text.Equals("6%"))
                {
                    tax = 6;
                    taxName = "Vat tax";

                } if (combo_tax.Text.Equals("13.5%"))
                {
                    tax = 13.5f;
                    taxName = "Vat tax";

                }
                if (combo_tax.Text.Equals("2%"))
                {
                    tax = 2;
                    taxName = "Cst tax";
                }
                if (combo_tax.Text.Equals("15%"))
                {
                    tax = 15;
                    taxName = "Service tax";

                }
                taxn = (netamount * tax) / 100;
                lb_taxamount.Text = "" + taxn;
                subtotal = taxn + netamount;
                lb_subtotal.Text = "" + subtotal;
                grandtotal = subtotal + shipping + adjustment;
                lb_grandtotal.Text = "" + grandtotal;
            
            }
            catch (Exception ea) { MessageBox.Show("Invalid Data entry"); }
            }

        private void lb_taxamount_Click(object sender, EventArgs e)
        {
            try
            {
                taxn = (netamount * tax)/100;
                lb_taxamount.Text = "" + taxn;
            }
            catch (Exception ea) { MessageBox.Show("Invalid Data entry"); }
        }

        private void lb_subtotal_Click(object sender, EventArgs e)
        {
            try
            {
                subtotal = taxn + netamount;
                lb_subtotal.Text = "" + subtotal;
                grandtotal = subtotal + shipping + adjustment;
                lb_grandtotal.Text = "" + grandtotal;
            }
            catch (Exception ea) { }

        }

        private void txt_shpping_TextChanged(object sender, EventArgs e)
        {
            try
            {
            
                shipping = float.Parse(txt_shpping.Text);
                lb_shpping.Text = "" + shipping;
                grandtotal = subtotal + shipping + adjustment;
                lb_grandtotal.Text = "" + grandtotal;

            }
            catch (Exception ea) { MessageBox.Show("Invalid Data entry"); }
        }

        private void txt_adjustment_TextChanged(object sender, EventArgs e)
        {
            try
            {
                adjustment = float.Parse(txt_adjustment.Text);
                lb_adjustment.Text = "" + adjustment;
                grandtotal = subtotal + shipping + adjustment;
                lb_grandtotal.Text = "" + grandtotal;
            
            }
            catch (Exception ea) { MessageBox.Show("Invalid Data entry"); }

        }

        private void lb_shpping_Click(object sender, EventArgs e)
        {
            try
            {

                lb_shpping.Text = "" + shipping;

            }
            catch (Exception ea) { MessageBox.Show("Invalid Data entry"); }

        }

        private void lb_adjustment_Click(object sender, EventArgs e)
        {
            try
            {
                lb_adjustment.Text = "" + adjustment;
            }
            catch (Exception ea) { MessageBox.Show("Invalid Data entry"); }
        }

        private void lb_grandtotal_Click(object sender, EventArgs e)
        {
            try
            {
                grandtotal = subtotal + shipping + adjustment;
                lb_grandtotal.Text = "" + grandtotal;
            }
            catch (Exception ea) { MessageBox.Show("Invalid Data entry"); }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
         
        }

    }
}
