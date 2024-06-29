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
    public partial class Purchase_order : Form
    {
        float rate,taxa, qty, netamount, subtotal, shipping, adj, grandtotal;
        float tax;


        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter sda;
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
            if (combo_tax.Text != "")
            {
                error6.Text = "";

            }
            else
            {
                error6.Text = "Please Select the specific tax";
                count = count + 1;
            }
            if (Regex.Match(txt_purchase.Text, @"^[0-9]*$").Success)
            {
                error1.Text = "";
            }
            else
            {
                error1.Text = "Please enter valid Order no";
                count = count + 1;

            }

            if (Regex.Match(txt_Quantity.Text, @"^[0-9]*$").Success)
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
            if (Regex.Match(txt_shipping.Text, @"^[0-9]*$").Success)
            {
                error4.Text = "";
            }
            else
            {
                error4.Text = "Please enter shipping charges amount in number";
                count = count + 1;
            }

        }

        public Purchase_order()
        {
            InitializeComponent();
        }

        private void but_cancel_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Vendor v = new Vendor();
            v.Show();


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

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
        private void Purchase_order_Load(object sender, EventArgs e)
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
                    cmd = new SqlCommand("INSERT INTO PurchaseOrder(VendorName,PurchaseOrder,PurchaseOrderDate,DueDate,ItemDetails,Quantity,Rate,Discount,Tax,SubTotal,ShippingCharges,GrandTotal) VALUES (@VendorNameP,@PurchaseOrderP,@PurchaseOrderDateP,@DueDateP,@ItemDetailsP,@QuantityP,@RateP,@DiscountP,@TaxP,@SubTotalP,@ShippingChargesP,@GrandTotalP)", con);
                    cmd.Parameters.AddWithValue("@VendorNameP", combox_customername.Text.Trim());
                    cmd.Parameters.AddWithValue("@PurchaseOrderP", txt_purchase.Text.Trim());
                    cmd.Parameters.AddWithValue("@PurchaseOrderDateP", dateTimePicker1.Text.Trim());
                    cmd.Parameters.AddWithValue("@DueDateP", dateTimePicker2.Text.Trim());
                    cmd.Parameters.AddWithValue("@ItemDetailsP", txt_itemDetails.Text.Trim());
                    cmd.Parameters.AddWithValue("@QuantityP", qty);
                    cmd.Parameters.AddWithValue("@RateP", rate);
                    cmd.Parameters.AddWithValue("@DiscountP", netamount);
                    cmd.Parameters.AddWithValue("@TaxP",taxa);
                    cmd.Parameters.AddWithValue("@SubTotalP", subtotal);
                    cmd.Parameters.AddWithValue("@ShippingChargesP", shipping);
                    cmd.Parameters.AddWithValue("@GrandTotalP", grandtotal);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data Has been save...");
                    Home h1 = new Home();
                    h1.Show();
                    this.Close();

                }
                catch (Exception ea)
                {
                    MessageBox.Show("Invalid Data Or Order number is repeated");
                }
            }
            else
            {
                count = 0;

            }
        }

        private void txt_Quantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                qty = float.Parse(txt_Quantity.Text);
            }
            catch (Exception ea) { }
        }

        private void txt_rate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                rate = float.Parse(txt_rate.Text);
            }
            catch (Exception ea) {}
        }

        private void txt_amount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                netamount = rate * qty;
                txt_amount.Text = "" + netamount;
            }
            catch (Exception ea) {}
        }

        private void combo_tax_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (combo_tax.Text.Equals("2%"))
                {
                    tax=2;
                }
                if (combo_tax.Text.Equals("5%"))
                {
                    tax = 5;
                }
                if (combo_tax.Text.Equals("13.5%"))
                {
                    tax = 13.5f;
                }
                taxa = (netamount * tax) / 100;
                lb_taxamount.Text = "" + taxa;
                subtotal = netamount + taxa;
                lb_subtotal.Text = "" + subtotal;
                grandtotal = subtotal + adj + shipping;
                lb_grandtotal.Text = "" + grandtotal;
            }
            catch (Exception ea) {}
        }

        private void lb_taxamount_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ea) { }
        }

        private void lb_subtotal_Click(object sender, EventArgs e)
        {
            try
            {
                subtotal = netamount+taxa;
                lb_subtotal.Text = "" + subtotal;
                grandtotal = subtotal + adj + shipping;
                lb_grandtotal.Text = "" + grandtotal;
            }
            catch (Exception ea) {}
        }

        private void lb_shipping_Click(object sender, EventArgs e)
        {
            try
            {
                lb_shipping.Text = "" + shipping;
                grandtotal = subtotal + adj + shipping;
                lb_grandtotal.Text = "" + grandtotal;
            }
            catch (Exception ea) {}

        }

        private void lb_adjusment_Click(object sender, EventArgs e)
        {
            try
            {
                lb_adjusment.Text = "" + adj;
                grandtotal = subtotal + adj + shipping;
                lb_grandtotal.Text = "" + grandtotal;
            }
            catch (Exception ea) {}

        }

        private void txt_shipping_TextChanged(object sender, EventArgs e)
        {
            try
            {
                shipping = float.Parse(txt_shipping.Text);
                lb_shipping.Text = "" + shipping;
                grandtotal = subtotal + adj + shipping;
                lb_grandtotal.Text = "" + grandtotal;
            }
            catch (Exception ea) {}

        }


        private void txt_adjusment_TextChanged(object sender, EventArgs e)
        {
            try
            {
                adj = float.Parse(txt_adjusment.Text);
                lb_adjusment.Text = "" + adj;
                grandtotal = subtotal + adj + shipping;
                lb_grandtotal.Text = "" + grandtotal;

            }
            catch (Exception ea) {}
        }


        private void label23_Click(object sender, EventArgs e)
        {
            try
            {
                grandtotal = subtotal + adj + shipping;
                lb_grandtotal.Text = "" + grandtotal;
            }
            catch (Exception ea)
            { }

        }
    }
}
