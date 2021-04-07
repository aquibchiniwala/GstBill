using System;
using System.Windows.Forms;

namespace GSTBill
{
    public partial class rptSales : Form
    {
        DateTime dt, dt2;
        Connectivity cn = new Connectivity();
        String date = DateTime.Today.Day + "-" + DateTime.Today.Month + "-" + DateTime.Today.Year;
        decimal sales = 0, Disc=0, GT = 0,CGST = 0, SGST = 0, IGST = 0, TCS=0;
        public rptSales()
        {
            InitializeComponent();
        }

        /* public string MonthCon(string m)
         {
             string month="";
             switch (m)
             {
                 case "01":
                     month= "JAN";
                     break;
                 case "02":
                     month = "FEB";
                     break;
                 case "03":
                     month = "MARCH";
                     break;
                 case "04":
                     month = "APRIL";
                     break;
                 case "05":
                     month = "MAY";
                     break;
                 case "06":
                     month = "JUNE";
                     break;
                 case "07":
                     month = "JULY";
                     break;
                 case "08":
                     month = "AUG";
                     break;
                 case "09":
                     month = "SEP";
                     break;
                 case "10":
                     month = "OCT";
                     break;
                 case "11":
                     month = "NOV";
                     break;
                 case "12":
                     month = "DEC";
                     break;

             };
             return month;

         }*/

        private void rptSales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsListAllPartySelect.ListAllPartySelect' table. You can move, or remove it, as needed.
            this.listAllPartySelectTableAdapter.Fill(this.dsListAllPartySelect.ListAllPartySelect);
            // TODO: This line of code loads data into the 'dsListAllFirmSelect.ListAllFirmSelect' table. You can move, or remove it, as needed.
            this.listAllFirmSelectTableAdapter.Fill(this.dsListAllFirmSelect.ListAllFirmSelect);
            dtpFromDate_ValueChanged(sender, e);
            dtpToDate_ValueChanged(sender, e);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            sales = 0; Disc=0; GT = 0; CGST = 0; SGST = 0; IGST = 0; TCS=0;

            if (txtInvoiceNo.Text == "")
                this.rptSalesTableAdapter.Fill(dsRptSales.rptSales, "", Convert.ToInt32(ddlFirm.SelectedValue), Convert.ToInt32(ddlParty.SelectedValue), dt, dt2);
            else
                this.rptSalesTableAdapter.Fill(dsRptSales.rptSales, txtInvoiceNo.Text, Convert.ToInt32(ddlFirm.SelectedValue), Convert.ToInt32(ddlParty.SelectedValue), dt, dt2);

            if (dgv.Rows.Count > 0)
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    GT = GT + Convert.ToDecimal(dgv.Rows[i].Cells[6].Value.ToString());
                    Disc = Disc + Convert.ToDecimal(dgv.Rows[i].Cells[7].Value.ToString());
                    SGST = SGST + Convert.ToDecimal(dgv.Rows[i].Cells[9].Value.ToString());
                    CGST = CGST + Convert.ToDecimal(dgv.Rows[i].Cells[11].Value.ToString());
                    IGST = IGST + Convert.ToDecimal(dgv.Rows[i].Cells[13].Value.ToString());
                    TCS = TCS + Convert.ToDecimal(dgv.Rows[i].Cells[15].Value.ToString());
                    sales = sales + Convert.ToDecimal(dgv.Rows[i].Cells[17].Value.ToString());


                }
                txtGrossTotal.Text = GT.ToString();
                txtTotalSales.Text = sales.ToString();
                txtTotalGST.Text = (CGST+SGST+IGST).ToString();
            }
            else
            {
                txtGrossTotal.Text = "0";
                txtTotalGST.Text = "0";
                txtTotalSales.Text = "0";
            }


        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            dt = DateTime.ParseExact(dtpFromDate.Text, "dd/MM/yyyy", null);
        }

        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            dt2 = DateTime.ParseExact(dtpToDate.Text, "dd/MM/yyyy", null);
        }

        private void rptSales_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                cn.Exit(this);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            btnReport_Click(sender, e);
            if (dgv.Rows.Count > 0 && Convert.ToInt32(ddlFirm.SelectedValue) != 0)
            {
                double sum = 0;
                //string month = MonthCon(dtpFromDate.Text.Substring(3, 2));

                // creating Excel Application  
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application 
                Microsoft.Office.Interop.Excel._Workbook workbook;
                // app.DisplayAlerts = false;
                if (!System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Firms\\" + ddlFirm.Text + "\\Reports\\" + date + ".xlsx"))
                {
                    workbook = app.Workbooks.Add(Type.Missing);
                }
                else
                {
                    workbook = app.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Firms\\" + ddlFirm.Text + "\\Reports\\" + date + ".xlsx");

                }
                // creating new Excelsheet in workbook  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.Sheets[1];
                workbook.Sheets[1].Activate();
                worksheet.Name = "Sales " + ddlFirm.Text;

                // storing header part in Excel  
                worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, 18]].Merge();
                worksheet.Range[worksheet.Cells[2, 1], worksheet.Cells[2, 18]].Merge();
                worksheet.Cells[1, 1] = ddlFirm.Text;
                // worksheet.Cells[2, 1] = "SALES FOR MONTH - " + month;
                worksheet.Cells[4, 1] = "SrNo";
                for (int i = 2; i < 19; i++)
                {
                    worksheet.Cells[4, i] = dgv.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 1; j < 18; j++)
                    {
                        worksheet.Cells[i + 5, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                    }
                    worksheet.Cells[5 + i, 1] = i + 1;
                }


                worksheet.Cells[2, 1] = "From Date : " + dtpFromDate.Text + "                To Date : " + dtpToDate.Text;
                worksheet.Cells[dgv.Rows.Count + 6, 1] = "TOTAL";
                worksheet.Cells[dgv.Rows.Count + 6, 7] = GT.ToString();
                worksheet.Cells[dgv.Rows.Count + 6, 8] = Disc.ToString();
                worksheet.Cells[dgv.Rows.Count + 6, 10] = SGST.ToString();
                worksheet.Cells[dgv.Rows.Count + 6, 12] = CGST.ToString();
                worksheet.Cells[dgv.Rows.Count + 6, 14] = IGST.ToString();
                worksheet.Cells[dgv.Rows.Count + 6, 16] = TCS.ToString();
                worksheet.Cells[dgv.Rows.Count + 6, 18] = sales.ToString();

                worksheet.Range[worksheet.Cells[dgv.Rows.Count + 6, 6], worksheet.Cells[dgv.Rows.Count + 6, 18]].Font.Bold = true;
                worksheet.Cells[dgv.Rows.Count + 6, 1].Font.Bold = true;
                worksheet.Range[worksheet.Cells[dgv.Rows.Count + 6, 1], worksheet.Cells[dgv.Rows.Count + 6, 5]].Merge();

                // formating excel sheet

                worksheet.get_Range("A1", "R4").Font.Bold = true;
                worksheet.get_Range("A1", "B2").Font.Underline = true;

                foreach (Microsoft.Office.Interop.Excel.Worksheet workSheet in workbook.Worksheets)
                {
                    Microsoft.Office.Interop.Excel.Range usedrange = worksheet.UsedRange;
                    usedrange.Columns.AutoFit();
                }

                worksheet.get_Range("A1", "K100").Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;



                // changing the name of active sheet  
                /*Microsoft.Office.Interop.Excel._Worksheet worksheet2 = null;
                worksheet2 = (Microsoft.Office.Interop.Excel._Worksheet)workbook.Sheets[2];
                workbook.Sheets[2].Activate(); 
                worksheet2.Name = "Purchase "+ddlFirm.Text;
               
                worksheet2.Cells[1,1]="dsd";*/
                // save the application  
                try
                {
                    workbook.SaveAs(System.Windows.Forms.Application.StartupPath + "\\Firms\\" + ddlFirm.Text + "\\Reports\\" + date + ".xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    // Exit from the application  
                    workbook.Close();
                    app.Quit();
                    MessageBox.Show("File Exported To Excel Successfully.", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Error opening file..Try again later..", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (Convert.ToInt32(ddlFirm.SelectedValue) == 0)
            {
                MessageBox.Show("Select Firm.", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("No Data Found!", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dgvView_DoubleClick(object sender, EventArgs e)
        {
            string INO = dgv.CurrentRow.Cells[1].Value.ToString();
            string Firm = dgv.CurrentRow.Cells[0].Value.ToString();
            if (System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "//Firms//" + Firm + "//" + INO + ".xps"))
                System.Diagnostics.Process.Start(System.Windows.Forms.Application.StartupPath + "//Firms//" + Firm + "//" + INO + ".xps");

        }

        private void dgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //for (int i = 0; i < dgv.Rows.Count; i++)
            //{
            //    dgv.Rows[i].Cells[5].Value = (Convert.ToDouble(dgv.Rows[i].Cells[8].Value) - (Convert.ToDouble(dgv.Rows[i].Cells[7].Value) + Convert.ToDouble(dgv.Rows[i].Cells[6].Value)));
            //}

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            cn.Exit(this);
        }
    }
}
