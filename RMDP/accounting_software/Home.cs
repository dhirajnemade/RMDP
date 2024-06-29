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
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using System.Threading.Tasks;




namespace accounting_software
{
    public partial class Home : Form
    {

        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter sda;

        public Home()
        {
            InitializeComponent();

        }

        private void paidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Make_payments mp = new Make_payments();
            mp.Show();
            this.Hide();
        }

        private void pucharseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UserLogin ul = new UserLogin();
            ul.Show();

        }

        private void purchaseInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Purchase_bill pb = new Purchase_bill();
            pb.Show();
        }

        private void companyInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Company_profile cp = new Company_profile();
            cp.Show();
            this.Hide();

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void rowMatarialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RawMaterial ra = new RawMaterial();
            ra.Show();
            this.Hide();

        }

        private void generatBalanceSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BalanceSheet bs = new BalanceSheet();
            bs.Show();
            this.Hide();

        }

        private void generatLadgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ledger l1 = new ledger();
            l1.Show();
            this.Hide();

        }

        private void finishedGoodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raw_Stock raw = new Raw_Stock();
            raw.Show();
            this.Hide();

        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewAllBillAndOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewALL v1 = new ViewALL();
            v1.Show();
            this.Hide();

        }

        private void saleOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales_Order sa = new Sales_Order();
            sa.Show();
            this.Hide();
        }

        private void viewAllPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_Payments vp = new View_Payments();
            vp.Show();
            this.Hide();

        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewInvoice nv = new NewInvoice();
            nv.Show();
        }

        private void purchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase_order po = new Purchase_order();
            po.Show();
            this.Hide();
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ex ab = new Ex();
            ab.Show();
            this.Hide();
        }

        private void recivePaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payment_Received pr = new Payment_Received();
            pr.Show();
            this.Hide();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void passwordSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f1 = new Form3();
            f1.Show();
            this.Hide();

        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {//
            try
            {

                con = new SqlConnection(accounting_software.Properties.Settings.Default.Database1ConnectionString);
                OpenFileDialog fd = new OpenFileDialog();
                fd.Filter = "SQL DataBases(*.mdf)|*.mdf";
                fd.Title = "Select SQL Database";
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    string file = fd.FileName;
                    string database = con.Database.ToString();
                    MessageBox.Show("Data restoration done..!");
                    con.Open();

                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LoginData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
                    con.Open();
                    string sql = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                    SqlCommand cmd1 = new SqlCommand(sql, con);
                    cmd1.ExecuteNonQuery();

                    string sqqlstm2 = "USE MASTER RESTORE DATABASE[" + database + "]FROM DISK='" + file + "'WITH REPLACE";
                    SqlCommand cmd2 = new SqlCommand(sqqlstm2, con);
                    cmd2.ExecuteNonQuery();

                    string sqlstm3 = string.Format("ALTER DATABASE[" + database + "]SET MULTI_USER");
                    SqlCommand cmd3 = new SqlCommand(sqlstm3, con);
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("Data restoration done..!");
                }//end of if
            }
            catch (Exception ea) 
            {
            }
        } //end of function

        public void mailSend1()
        {
            try
            {
                System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
                message.From = new MailAddress("dheerajnemade@gmail.com");
                message.To.Add("jkudos@rediffmail.com");
                message.Subject = "Back_UP System Generated Mail";
                message.Body = "Back Up of your accounting software";
                message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Timeout = (60 * 5 * 1000);
                smtpClient.Credentials = new NetworkCredential("dheerajnemade",
                                                               "46133719");
                smtpClient.Send(message.From.ToString(), message.To.ToString(),
                message.Subject, message.Body);
                message.Attachments.Add(new Attachment("LoginData.mdf"));
                message.Attachments.Add(new Attachment("LoginData_log.LDF"));
                smtpClient.Send(message);
                MessageBox.Show("Mail send sucessfully ");
            }
            catch (Exception ea)
            {
                MessageBox.Show("" + ea);
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mailSend1();
           
      }
    }

}
