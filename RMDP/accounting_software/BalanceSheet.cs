using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ExcelLibrary.SpreadSheet;
using ExcelLibrary.CompoundDocumentFormat;

using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop;


namespace accounting_software
{
    public partial class BalanceSheet : Form
    {
        public BalanceSheet()
        {
            InitializeComponent();
        }

        private void but_cancel_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            h1.Show();
            this.Close();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*string myexcel = @"C:\Users\Dheeraj\Documents\Balancesheet.xlsx";
            var excelapp = new Excel.Application();
            excelapp.Visible = true;

            Excel.Workbooks books = excelapp.Workbooks;

            Excel.Workbooks sheet = books.Open(myexcel);
            */
            try
             {
                 timer1.Enabled = true;
                
             }
             catch (Exception ea)
             {
             }                
             }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = Convert.ToInt32(progressBar1.Value + 5);
            if (Convert.ToInt32(progressBar1.Value) > 95)
            {
                timer1.Enabled = false;
                string mysheet = @"C:\Users\Dheeraj\Documents\Balancesheet1.xlsx.xls";
                var excelApp = new Excel.Application();
                excelApp.Visible = true;
                Excel.Workbooks book = excelApp.Workbooks;
                Excel._Workbook sheet1 = book.Open(mysheet);

            }

        }
                    
        }
    }

