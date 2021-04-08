using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data.SqlClient;
using System.Globalization;

namespace GSTBill
{
    public partial class SalesDetail : Form
    {
        Connectivity cn = new Connectivity();
        string FirmName, Address, MobileNo, GSTIN, BankName, AccountNo, IFSC, HSN, Printer, BillSeries;
        double gt, sgst, cgst, igst, tcs, nt;
        int flag = 0, INo;
        DateTime dt;
        public SalesDetail()
        {
            InitializeComponent();
            txtTCSPer.Text = "0";
        }

        public void reset()
        {
            ddlFirm.SelectedIndex = 0;
            dtpInvoiceDate.Value = DateTime.Today;
            dtpChallanDate.Value = DateTime.Today;
            txtBroker.Text = "";
            ddlBilledTo.SelectedIndex = 0;
            txtBillAdd.Text = "";
            txtBillMobNo.Text = "";
            txtBillGST.Text = "";
            txtBillState.Text = "";
            txtDelTo.Text = "";
            txtDelAdd.Text = "";
            txtDelMobNo.Text = "";
            txtDelGST.Text = "";
            txtDelState.Text = "";
            txtState.Text = "";
            ddlMode.Text = "";
            txtVehicle.Text = "";
            dtpSupplyDate.Value = DateTime.Today;
            dgv.Rows.Clear();
            txtSGST.Text = "0";
            txtCGST.Text = "0";
            txtIGST.Text = "0";
            txtTCS.Text = "0";
            txtTCSPer.Text = "0";
            ddlSGST.SelectedIndex = 1;
            ddlCGST.SelectedIndex = 1;
            ddlIGST.SelectedIndex = 0;
            txtGrossTotal.Text = "0";
            txtDiscPer.Text = "0";
            txtDiscAmt.Text = "0";
            txtNetTotal.Text = "0";
            dtpDueDate.Value = DateTime.Today;
            txtBank.Text = "";
            txtChequeNo.Text = "";
            txtChequeDate.Text = "";
            txtAmount.Text = "";
            setNextInvoiceNo();
        }

        public string ConvertNumbertoWords(long number)
        {
            if (number == 0) return "ZERO";
            if (number < 0) return "minus " + ConvertNumbertoWords(Math.Abs(number));
            string words = "";
            if ((number / 100000) > 0)
            {
                words += ConvertNumbertoWords(number / 100000) + " LAKH ";
                number %= 100000;
            }
            if ((number / 1000) > 0)
            {
                words += ConvertNumbertoWords(number / 1000) + " THOUSAND ";
                number %= 1000;
            }
            if ((number / 100) > 0)
            {
                words += ConvertNumbertoWords(number / 100) + " HUNDRED ";
                number %= 100;
            }
            //if ((number / 10) > 0)  
            //{  
            // words += ConvertNumbertoWords(number / 10) + " RUPEES ";  
            // number %= 10;  
            //}  
            if (number > 0)
            {
                if (words != "") words += "AND ";
                var unitsMap = new[]
            {
                "ZERO", "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE", "TEN", "ELEVEN", "TWELVE", "THIRTEEN", "FOURTEEN", "FIFTEEN", "SIXTEEN", "SEVENTEEN", "EIGHTEEN", "NINETEEN"
            };
                var tensMap = new[]
            {
                "ZERO", "TEN", "TWENTY", "THIRTY", "FORTY", "FIFTY", "SIXTY", "SEVENTY", "EIGHTY", "NINETY"
            };
                if (number < 20) words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0) words += " " + unitsMap[number % 10];
                }
            }
            return words;
        }
        private void PrintPage(object o, PrintPageEventArgs e)
        {

            //---------------

            if (cn.cn.State == ConnectionState.Closed)
                cn.cn.Open();
            SqlCommand cmd = new SqlCommand("ViewFirmByID", cn.cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirmID", ddlFirm.SelectedValue).DbType = DbType.Int64;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            FirmName = ds.Tables[0].Rows[0][1].ToString();
            Address = ds.Tables[0].Rows[0][2].ToString();
            MobileNo = ds.Tables[0].Rows[0][3].ToString();
            GSTIN = ds.Tables[0].Rows[0][4].ToString();
            BankName = ds.Tables[0].Rows[0][5].ToString();
            AccountNo = ds.Tables[0].Rows[0][6].ToString();
            IFSC = ds.Tables[0].Rows[0][7].ToString();


            cmd.Dispose();

            //---------------
            // System.Drawing.Image img = (Image)printBarcode();
            //  Point loc = new Point(10, 30);

            Font font6 = new Font("Arial", 10, FontStyle.Bold);
            Font font0 = new Font("Arial", 12, FontStyle.Regular);
            Font font1 = new Font("Arial", 8, FontStyle.Regular);
            Font font2 = new Font("Arial", 18, FontStyle.Bold);
            Font font3 = new Font("Arial", 12, FontStyle.Bold);
            Font font4 = new Font("Arial", 10, FontStyle.Regular);
            Font font5 = new Font("Arial", 7, FontStyle.Bold);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;

            SizeF txt = e.Graphics.MeasureString(Text, this.Font);
            SizeF sz = e.Graphics.VisibleClipBounds.Size;
            //Image img = Image.FromFile(@"" + Application.StartupPath + "\\RD.jpg");

            if (flag == 0)
            {
                e.Graphics.DrawString("TAX INVOICE (O)", font0, Brushes.Black, 320, 10);
            }
            else
                e.Graphics.DrawString("TAX INVOICE (D)", font0, Brushes.Black, 320, 10);
            //e.Graphics.DrawImage(img, 10, 10, 280, 100);
            //e.Graphics.DrawString("----------------------------------------------------------------------------", font1, Brushes.Black, 10, 95);
            e.Graphics.DrawString(FirmName.ToUpper(), font2, Brushes.Black, 260, 35);
            e.Graphics.DrawString(Address, font0, Brushes.Black, 145, 65);
            e.Graphics.DrawString("(M) " + MobileNo, font0, Brushes.Black, 280, 85);
            e.Graphics.DrawString("GSTIN : " + GSTIN, font0, Brushes.Black, 285, 105);
            e.Graphics.DrawString("__________________________________________________________________________________________________________________________", font1, Brushes.Black, 10, 120);
            e.Graphics.DrawString("Billed To        : ", font0, Brushes.Black, 30, 150);
            if (ddlBilledTo.SelectedValue != null)
                e.Graphics.DrawString("M/S, " + ddlBilledTo.Text.ToUpper(), font3, Brushes.Black, 30, 170);
            else
                e.Graphics.DrawString("M/S, ", font3, Brushes.Black, 30, 170);

            if (txtBillAdd.Text != "")
                e.Graphics.DrawString(txtBillAdd.Text.ToUpper(), font0, Brushes.Black, 30, 190);

            if (txtBillMobNo.Text != "")
                e.Graphics.DrawString("MOBILE NO  : " + txtBillMobNo.Text, font0, Brushes.Black, 30, 210);
            else
                e.Graphics.DrawString("MOBILE NO  : ", font0, Brushes.Black, 30, 210);
            if (txtBillState.Text != "")
                e.Graphics.DrawString("STATE          : " + txtBillState.Text.ToUpper(), font0, Brushes.Black, 30, 230);
            else
                e.Graphics.DrawString("STATE          :", font0, Brushes.Black, 30, 230);

            if (txtBillGST.Text != "")
                e.Graphics.DrawString("PARTY GST : " + txtBillGST.Text.ToUpper(), font0, Brushes.Black, 30, 250);
            else
                e.Graphics.DrawString("PARTY GST : ", font0, Brushes.Black, 30, 250);

            e.Graphics.DrawString("__________________________________________________________________________________________________________________________", font1, Brushes.Black, 10, 270);

            e.Graphics.DrawString("Delivery To    : ", font0, Brushes.Black, 30, 290);
            if (txtDelTo.Text != "")
                e.Graphics.DrawString("M/S, " + txtDelTo.Text.ToUpper(), font3, Brushes.Black, 30, 310);
            else
                e.Graphics.DrawString("M/S, ", font3, Brushes.Black, 30, 310);

            if (txtDelAdd.Text != "")
                e.Graphics.DrawString(txtDelAdd.Text.ToUpper(), font0, Brushes.Black, 30, 330);

            if (txtDelMobNo.Text != "")
                e.Graphics.DrawString("MOBILE NO  : " + txtDelMobNo.Text, font0, Brushes.Black, 30, 350);
            else
                e.Graphics.DrawString("MOBILE NO  : ", font0, Brushes.Black, 30, 350);
            if (txtDelState.Text != "")
                e.Graphics.DrawString("STATE          : " + txtDelState.Text.ToUpper(), font0, Brushes.Black, 30, 370);
            else
                e.Graphics.DrawString("STATE          : ", font0, Brushes.Black, 30, 370);

            if (txtDelGST.Text != "")
                e.Graphics.DrawString("PARTY GST : " + txtDelGST.Text.ToUpper(), font0, Brushes.Black, 30, 390);
            else
                e.Graphics.DrawString("PARTY GST : ", font0, Brushes.Black, 30, 390);

            e.Graphics.DrawString("__________________________________________________________________________________________________________________________", font1, Brushes.Black, 10, 410);

            e.Graphics.DrawString("|", font1, Brushes.Black, 530, 130);
            e.Graphics.DrawString("|", font1, Brushes.Black, 530, 140);
            e.Graphics.DrawString("|", font1, Brushes.Black, 530, 150);
            e.Graphics.DrawString("|", font1, Brushes.Black, 530, 160);
            e.Graphics.DrawString("|", font1, Brushes.Black, 530, 170);
            e.Graphics.DrawString("|", font1, Brushes.Black, 530, 180);
            e.Graphics.DrawString("|", font1, Brushes.Black, 530, 190);
            e.Graphics.DrawString("|", font1, Brushes.Black, 530, 200);
            e.Graphics.DrawString("|", font1, Brushes.Black, 530, 210);
            e.Graphics.DrawString("|", font1, Brushes.Black, 530, 220);
            e.Graphics.DrawString("|", font1, Brushes.Black, 530, 230);
            e.Graphics.DrawString("|", font1, Brushes.Black, 530, 240);
            e.Graphics.DrawString("|", font1, Brushes.Black, 530, 250);
            e.Graphics.DrawString("|", font1, Brushes.Black, 530, 260);
            e.Graphics.DrawString("|", font1, Brushes.Black, 530, 270);
            //-----
            e.Graphics.DrawString("|", font1, Brushes.Black, 530, 280);
            e.Graphics.DrawString("|", font1, Brushes.Black, 530, 290);
            e.Graphics.DrawString("|", font1, Brushes.Black, 530, 300);
            e.Graphics.DrawString("|", font1, Brushes.Black, 530, 310);
            e.Graphics.DrawString("|", font1, Brushes.Black, 530, 320);
            e.Graphics.DrawString("|", font1, Brushes.Black, 530, 330);
            e.Graphics.DrawString("|", font1, Brushes.Black, 530, 340);
            e.Graphics.DrawString("|", font1, Brushes.Black, 530, 350);
            e.Graphics.DrawString("|", font1, Brushes.Black, 530, 360);
            e.Graphics.DrawString("|", font1, Brushes.Black, 530, 370);
            e.Graphics.DrawString("|", font1, Brushes.Black, 530, 380);
            e.Graphics.DrawString("|", font1, Brushes.Black, 530, 390);
            e.Graphics.DrawString("|", font1, Brushes.Black, 530, 400);
            e.Graphics.DrawString("|", font1, Brushes.Black, 530, 410);


            if (txtInvoiceNo.Text != "")
                e.Graphics.DrawString("    INVOICE NO       : " + txtInvoiceNo.Text.ToUpper(), font3, Brushes.Black, 520, 150);
            else
                e.Graphics.DrawString("    INVOICE NO       : ", font3, Brushes.Black, 520, 150);

            e.Graphics.DrawString("    INVOICE DATE   : " + dtpInvoiceDate.Value.ToShortDateString(), font0, Brushes.Black, 520, 170);

            e.Graphics.DrawString("    INVOICE TIME    : " + dtpInvoiceDate.Value.ToShortTimeString(), font0, Brushes.Black, 520, 190);

            if (txtChallanNo.Text != "")
                e.Graphics.DrawString("    CHALLAN NO     : " + txtChallanNo.Text.ToUpper(), font0, Brushes.Black, 520, 210);
            else
                e.Graphics.DrawString("    CHALLAN NO     : ", font0, Brushes.Black, 520, 210);

            e.Graphics.DrawString("    CHALLAN DATE : " + dtpChallanDate.Text, font0, Brushes.Black, 520, 230);


            if (txtState.Text != "")
                e.Graphics.DrawString("    STATE                : " + txtState.Text.ToUpper(), font0, Brushes.Black, 520, 310);
            else
                e.Graphics.DrawString("    STATE                : ", font0, Brushes.Black, 520, 310);

            if (ddlMode.Text != "")
                e.Graphics.DrawString("    MODE                 : " + ddlMode.Text.ToUpper(), font0, Brushes.Black, 520, 330);
            else
                e.Graphics.DrawString("    MODE                 : ", font0, Brushes.Black, 520, 330);

            if (txtVehicle.Text != "")
                e.Graphics.DrawString("    VEHICLE NO      : " + txtVehicle.Text.ToUpper(), font0, Brushes.Black, 520, 350);
            else
                e.Graphics.DrawString("    VEHICLE NO      : ", font0, Brushes.Black, 520, 350);

            e.Graphics.DrawString("    SUPPLY DATE   : " + dtpSupplyDate.Text, font0, Brushes.Black, 520, 370);

            if (txtSupplyPlace.Text != "")
                e.Graphics.DrawString("    SUPPLY PLACE : " + txtSupplyPlace.Text.ToUpper(), font0, Brushes.Black, 520, 390);
            else
                e.Graphics.DrawString("    SUPPLY PLACE : ", font0, Brushes.Black, 520, 390);

            if (txtBroker.Text != "")
                e.Graphics.DrawString("BROKER      : " + txtBroker.Text.ToUpper(), font0, Brushes.Black, 30, 430);
            else
                e.Graphics.DrawString("BROKER      : ", font0, Brushes.Black, 30, 430);

            e.Graphics.DrawString("    DUE DATE          : " + dtpDueDate.Text, font0, Brushes.Black, 520, 430);

            e.Graphics.DrawString("__________________________________________________________________________________________________________________________", font1, Brushes.Black, 10, 450);

            for (int i = 130; i < 1070; i = i + 10)
            {

                e.Graphics.DrawString("|                                                                                                                                                                  |", font0, Brushes.Black, 10, i);
            }
            for (int i = 0; i < 350; i = i + 10)
            {

                e.Graphics.DrawString("|            |                                                               |                   |               |                 |             |                    ", font0, Brushes.Black, 10, i + 460);
            }
            for (int i = 350; i < 601; i = i + 10)
            {

                e.Graphics.DrawString("|                                                                            |                                                                                             ", font0, Brushes.Black, 10, i + 460);
            }
            for (int i = 350; i < 515; i = i + 10)
            {

                e.Graphics.DrawString("                                                                                                                                             |                   ", font0, Brushes.Black, 10, i + 460);
            }

            if (rbtnMeter.Checked == true)
            {
                e.Graphics.DrawString("   SNO     PARTICULARS                                    HSNCODE   TAAKA   METRES    RATE   AMOUNT   ", font3, Brushes.Black, 10, 470);
            }
            else
            {
                e.Graphics.DrawString("   SNO     PARTICULARS                                    HSNCODE   PIECES      KGS       RATE    AMOUNT   ", font3, Brushes.Black, 10, 470);
            }

            e.Graphics.DrawString("__________________________________________________________________________________________________________________________", font1, Brushes.Black, 10, 490);
            e.Graphics.DrawString("__________________________________________________________________________________________________________________________", font1, Brushes.Black, 10, 810);


            for (int i = 0; i < dgv.Rows.Count - 1; i++)
            {
                e.Graphics.DrawString(Convert.ToString(dgv.Rows[i].Cells[0].Value).ToUpper(), font6, Brushes.Black, 25, (510 + i * 25));
                e.Graphics.DrawString(Convert.ToString(dgv.Rows[i].Cells[1].Value).ToUpper(), font6, Brushes.Black, 80, (510 + i * 25));
                e.Graphics.DrawString(Convert.ToString(dgv.Rows[i].Cells[2].Value).ToUpper(), font6, Brushes.Black, 395, (510 + i * 25));
                e.Graphics.DrawString(Convert.ToString(dgv.Rows[i].Cells[3].Value).ToUpper(), font6, Brushes.Black, 490, (510 + i * 25));
                e.Graphics.DrawString(Convert.ToString(dgv.Rows[i].Cells[4].Value).ToUpper(), font6, Brushes.Black, 552, (510 + i * 25));
                e.Graphics.DrawString(Convert.ToString(dgv.Rows[i].Cells[5].Value).ToUpper(), font6, Brushes.Black, 633, (510 + i * 25));
                e.Graphics.DrawString(Convert.ToString(dgv.Rows[i].Cells[6].Value).ToUpper(), font6, Brushes.Black, 695, (510 + i * 25));
            }
            e.Graphics.DrawString("NO DYEING GUARANTEE", font3, Brushes.Black, 80, 790);

            if (txtBank.Text != "")
                e.Graphics.DrawString("Bank      : " + txtBank.Text.ToUpper(), font4, Brushes.Black, 20, 830);
            else
                e.Graphics.DrawString("Bank      : ", font4, Brushes.Black, 20, 830);

            if (txtChequeDate.Text != "")
                e.Graphics.DrawString("Date      : " + txtChequeDate.Text.ToUpper(), font4, Brushes.Black, 220, 830);
            else
                e.Graphics.DrawString("Date      : ", font4, Brushes.Black, 220, 830);

            if (txtChequeNo.Text != "")
                e.Graphics.DrawString("Chq No. : " + txtChequeNo.Text.ToUpper(), font4, Brushes.Black, 20, 850);
            else
                e.Graphics.DrawString("Chq No. : ", font4, Brushes.Black, 20, 850);

            if (txtAmount.Text != "")
                e.Graphics.DrawString("Amount : " + txtAmount.Text, font4, Brushes.Black, 220, 850);
            else
                e.Graphics.DrawString("Amount : ", font4, Brushes.Black, 220, 850);

            e.Graphics.DrawString("__________________________________________________________________________________________________________________________", font1, Brushes.Black, 10, 865);


            e.Graphics.DrawString(BankName.ToUpper(), font4, Brushes.Black, 20, 890);
            e.Graphics.DrawString("A/C No   : " + AccountNo.ToUpper(), font4, Brushes.Black, 20, 910);
            e.Graphics.DrawString("IFSC      : " + AccountNo.ToUpper(), font4, Brushes.Black, 20, 930);


            e.Graphics.DrawString("GROSS AMOUNT", font0, Brushes.Black, 390, 830);
            e.Graphics.DrawString(txtGrossTotal.Text, font0, Brushes.Black, 690, 830);

            e.Graphics.DrawString("LESS DISC", font0, Brushes.Black, 390, 850);
            e.Graphics.DrawString(txtDiscPer.Text + "%", font0, Brushes.Black, 630, 850);
            e.Graphics.DrawString((Math.Round(Convert.ToDouble(txtDiscAmt.Text), 2)).ToString(), font0, Brushes.Black, 690, 850);

            e.Graphics.DrawString("ADD SGST", font0, Brushes.Black, 390, 880);
            e.Graphics.DrawString(ddlSGST.Text + "%", font0, Brushes.Black, 630, 880);
            e.Graphics.DrawString((Math.Round(Convert.ToDouble(txtSGST.Text), 2)).ToString(), font0, Brushes.Black, 690, 880);

            e.Graphics.DrawString("ADD CGST", font0, Brushes.Black, 390, 900);
            e.Graphics.DrawString(ddlCGST.Text + "%", font0, Brushes.Black, 630, 900);
            e.Graphics.DrawString((Math.Round(Convert.ToDouble(txtCGST.Text), 2)).ToString(), font0, Brushes.Black, 690, 900);

            e.Graphics.DrawString("ADD IGST", font0, Brushes.Black, 390, 920);
            e.Graphics.DrawString(ddlIGST.Text + "%", font0, Brushes.Black, 630, 920);
            e.Graphics.DrawString((Math.Round(Convert.ToDouble(txtIGST.Text), 2)).ToString(), font0, Brushes.Black, 690, 920);

            double netTotalBeforeTCS = nt - tcs;

            e.Graphics.DrawString("ADD TCS on (" + netTotalBeforeTCS.ToString() + ")", font0, Brushes.Black, 390, 940);
            e.Graphics.DrawString(txtTCSPer.Text + "%", font0, Brushes.Black, 630, 940);
            e.Graphics.DrawString((Math.Round(Convert.ToDouble(txtTCS.Text), 2)).ToString(), font0, Brushes.Black, 690, 940);

            e.Graphics.DrawString("__________________________________________________________________________________________________________________________", font1, Brushes.Black, 10, 950);

            string amountInWords = ConvertNumbertoWords(Convert.ToInt32(Math.Round(Convert.ToDouble(txtNetTotal.Text), 0))) + " ONLY.";
            if (amountInWords.Length < 60)
            {
                e.Graphics.DrawString(amountInWords, font5, Brushes.Black, 20, 970);
            }
            else
            {
                string line1 = amountInWords.Substring(0, 50) + "-";
                string line2 = "-" + amountInWords.Substring(51);
                e.Graphics.DrawString(line1, font5, Brushes.Black, 20, 965);
                e.Graphics.DrawString(line2, font5, Brushes.Black, 20, 975);
            }


            e.Graphics.DrawString("NET AMOUNT", font3, Brushes.Black, 390, 970);
            e.Graphics.DrawString(txtNetTotal.Text, font3, Brushes.Black, 690, 970);

            e.Graphics.DrawString("__________________________________________________________________________________________________________________________", font1, Brushes.Black, 10, 980);

            e.Graphics.DrawString("Terms & Conditions.", font4, Brushes.Black, 20, 1000);
            e.Graphics.DrawString("Goods Once Sold Will Not Be Taken Back.", font4, Brushes.Black, 20, 1015);
            e.Graphics.DrawString("No Guarantee Of Any Goods.", font4, Brushes.Black, 20, 1030);
            e.Graphics.DrawString("Int.24% P.A Will Be Charged After Due Date.", font4, Brushes.Black, 20, 1045);
            e.Graphics.DrawString("Subject To Surat Jurisdiction.", font4, Brushes.Black, 20, 1060);

            e.Graphics.DrawString("E. & O. E.", font0, Brushes.Black, 695, 1000);
            e.Graphics.DrawString("for, "+ddlFirm.Text, font3, Brushes.Black, 470, 1000);
            e.Graphics.DrawString("Authorised Signatory.", font3, Brushes.Black, 570, 1060);




            e.Graphics.DrawString("__________________________________________________________________________________________________________________________", font1, Brushes.Black, 10, 1070);




        }
        private void NetTotal()
        {
            gt = 0; sgst = 0; cgst = 0; igst = 0; tcs = 0;
            if (txtDiscPer.Text != "")
                txtDiscAmt.Text = (Convert.ToDouble(txtDiscPer.Text) * Convert.ToDouble(txtGrossTotal.Text) / 100).ToString();
            else
            {
                txtDiscAmt.Text = "0";
                txtDiscPer.Text = "0";
            }
            gt = Convert.ToDouble(txtGrossTotal.Text) - Convert.ToDouble(txtDiscAmt.Text);
            txtSGST.Text = Math.Round(((Convert.ToDouble(ddlSGST.SelectedItem) * gt) / 100), 2).ToString();
            txtCGST.Text = Math.Round(((Convert.ToDouble(ddlCGST.SelectedItem) * gt) / 100), 2).ToString();
            txtIGST.Text = Math.Round(((Convert.ToDouble(ddlIGST.SelectedItem) * gt) / 100), 2).ToString();
            sgst = Convert.ToDouble(txtSGST.Text);
            cgst = Convert.ToDouble(txtCGST.Text);
            igst = Convert.ToDouble(txtIGST.Text);
            if (txtTCSPer.Text != "")
            {
                txtTCS.Text = Math.Round(((Convert.ToDouble(txtTCSPer.Text) * (gt + sgst + cgst + igst)) / 100), 2).ToString();
                tcs = Convert.ToDouble(txtTCS.Text);
            }
            else
            {
                txtTCS.Text = "0";
                txtTCSPer.Text = "0";
            }
            txtNetTotal.Text = Math.Round(gt + sgst + cgst + igst + tcs, 0, MidpointRounding.AwayFromZero).ToString();
            nt = gt + sgst + cgst + igst + tcs;
        }


        private void dgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dgv.Rows[e.RowIndex].Cells["SNO"].Value = (e.RowIndex + 1).ToString();
        }

        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double gt = 0;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                dgv.Rows[i].Cells[6].Value = Math.Round((Convert.ToDouble(dgv.Rows[i].Cells[4].Value) * Convert.ToDouble(dgv.Rows[i].Cells[5].Value)), 2);
                gt = gt + Convert.ToDouble(dgv.Rows[i].Cells[6].Value);

            }
            txtGrossTotal.Text = Math.Round(gt, 2).ToString();
            NetTotal();

        }

        private void dgv_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dgv.CurrentCell.ColumnIndex == 3 || dgv.CurrentCell.ColumnIndex == 4 || dgv.CurrentCell.ColumnIndex == 5) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }

        }
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtBillTo_TextChanged(object sender, EventArgs e)
        {
            //txtDelTo.Text = txtBillTo.Text;
        }

        private void txtBillAdd_TextChanged(object sender, EventArgs e)
        {
            txtDelAdd.Text = txtBillAdd.Text;

        }

        private void txtBillMobNo_TextChanged(object sender, EventArgs e)
        {
            txtDelMobNo.Text = txtBillMobNo.Text;
        }

        private void txtBillState_TextChanged(object sender, EventArgs e)
        {
            txtDelState.Text = txtBillState.Text;

        }

        private void txtBillGST_TextChanged(object sender, EventArgs e)
        {
            txtDelGST.Text = txtBillGST.Text;

        }

        private void ddlSGST_SelectedIndexChanged(object sender, EventArgs e)
        {
            NetTotal();
        }

        private void ddlCGST_SelectedIndexChanged(object sender, EventArgs e)
        {
            NetTotal();
        }

        private void ddlIGST_SelectedIndexChanged(object sender, EventArgs e)
        {
            NetTotal();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsListAllFirm.ListAllFirm' table. You can move, or remove it, as needed.
            this.listAllFirmTableAdapter.Fill(this.dsListAllFirm.ListAllFirm);
            // TODO: This line of code loads data into the 'dsListAllParty.ListAllParty' table. You can move, or remove it, as needed.
            this.listAllPartyTableAdapter.Fill(this.dsListAllParty.ListAllParty);
            // TODO: This line of code loads data into the 'dsListAllFirm.ListAllFirm' table. You can move, or remove it, as needed.
            this.listAllFirmTableAdapter.Fill(this.dsListAllFirm.ListAllFirm);
            // TODO: This line of code loads data into the 'dsListAllFirm.ListAllFirm' table. You can move, or remove it, as needed.
            this.listAllFirmTableAdapter.Fill(this.dsListAllFirm.ListAllFirm);
            ddlSGST.SelectedIndex = 1;
            ddlCGST.SelectedIndex = 1;
            ddlIGST.SelectedIndex = 0;
            ddlFirm.SelectedIndex = 0;
            // ddlMobileNo.SelectedIndex = 0;
            //ddlAddress.SelectedIndex = 0;
            //ddlGSTIN.SelectedIndex = 0;
            dt = DateTime.ParseExact(dtpInvoiceDate.Text, "dd/MM/yyyy h:mm tt", CultureInfo.InvariantCulture);
            ddlFirm.Focus();

            SqlCommand cmd2 = new SqlCommand("getSettings", cn.cn);
            cmd2.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            if (ds2.Tables[0].Rows.Count > 0)
            {
                HSN = ds2.Tables[0].Rows[0]["HSNCode"].ToString();
                Printer = ds2.Tables[0].Rows[0]["PrinterName"].ToString();
                Printer = ds2.Tables[0].Rows[0]["PrinterName"].ToString();
                BillSeries = ds2.Tables[0].Rows[0]["BillSeries"].ToString();
            }

            setNextInvoiceNo();
        }

        public void setNextInvoiceNo()
        {
            SqlCommand cmd = new SqlCommand("select top 1  InvoiceNo from SalesMaster where FirmID='" + ddlFirm.SelectedValue + "' order by InvoiceNo desc ", cn.cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                int nextInvoiceNo = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString().Split('-')[1]) + 1;
                if (nextInvoiceNo < 10)
                    txtInvoiceNo.Text = BillSeries + "00" + nextInvoiceNo.ToString();
                else if (nextInvoiceNo < 100)
                    txtInvoiceNo.Text = BillSeries + "0" + nextInvoiceNo.ToString();
                else
                    txtInvoiceNo.Text = BillSeries + nextInvoiceNo.ToString();
            }
            else
                txtInvoiceNo.Text = BillSeries + "001";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if ((e.KeyCode == Keys.A && e.Control) || e.KeyCode == Keys.P && e.Control)
            {
                btnPrint_Click(sender, e);
            }
            else if (e.KeyCode == Keys.S && e.Control)
            {
                btnSave_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                cn.Exit(this);
            }
            else if (e.KeyCode == Keys.Home)
            {
                reset();
            }
            else if (e.KeyCode == Keys.Enter && ddlBilledTo.Focused == false)
            {
                SendKeys.Send("{TAB}");
            }
            else if (e.KeyCode == Keys.U && e.Shift && e.Control)
            {
                btnUpdateAll_Click(sender, e);
            }
        }

        private void txtTCSPer_TextChanged(object sender, EventArgs e)
        {
            NetTotal();
        }

        private void txtTCSPer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void rbtnMeter_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMeter.Checked == true)
            {
                dgv.Columns["SKU"].HeaderText = "TAAKA";
                dgv.Columns["UNIT"].HeaderText = "METERS";
            }
            else
            {
                dgv.Columns["SKU"].HeaderText = "PIECES";
                dgv.Columns["UNIT"].HeaderText = "KGS";
            }
        }

        private void rbtnKG_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMeter.Checked == true)
            {
                dgv.Columns["SKU"].HeaderText = "TAAKA";
                dgv.Columns["UNIT"].HeaderText = "METERS";
            }
            else
            {
                dgv.Columns["SKU"].HeaderText = "PIECES";
                dgv.Columns["UNIT"].HeaderText = "KGS";
            }
        }

        private void txtDiscPer_TextChanged(object sender, EventArgs e)
        {
            NetTotal();
        }

        private void txtDiscPer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtInvoiceNo_TextChanged(object sender, EventArgs e)
        {
            txtChallanNo.Text = txtInvoiceNo.Text;
        }

        private void ddlBilledTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlBilledTo.SelectedValue != null)
            {
                if (cn.cn.State == ConnectionState.Closed)
                    cn.cn.Open();
                SqlCommand cmd = new SqlCommand("ViewPartyByID", cn.cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PartyID", ddlBilledTo.SelectedValue).DbType = DbType.Int64;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtDelTo.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtBillAdd.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtBillMobNo.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtBillState.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtBillGST.Text = ds.Tables[0].Rows[0][5].ToString();
                }
                cmd.Dispose();
            }
        }

        private void dgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgv.Rows[dgv.Rows.Count - 1].Cells[2].Value = HSN;
        }

        public void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count - 1 > 0)
            {
                DialogResult result = MessageBox.Show("Do you want to print the bill? ", "Liberty Softwares", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {

                    if (cn.cn.State == ConnectionState.Closed)
                        cn.cn.Open();

                    SqlCommand cmd2 = new SqlCommand("select SalesDetailID from SalesDetail where InvoiceNo='" + txtInvoiceNo.Text + "' and FirmID='" + ddlFirm.SelectedValue + "'", cn.cn);
                    SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                    DataSet ds2 = new DataSet();
                    da2.Fill(ds2);

                    SqlCommand cmd3 = new SqlCommand("select SalesID from SalesMaster where InvoiceNo='" + txtInvoiceNo.Text + "' and FirmID='" + ddlFirm.SelectedValue + "'", cn.cn);
                    SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                    DataSet ds3 = new DataSet();
                    da3.Fill(ds3);

                    if (ds2.Tables[0].Rows.Count == 0)
                    {
                        for (int i = 0; i < dgv.Rows.Count - 1; i++)
                        {

                            SqlCommand cmd = new SqlCommand("SalesDetailInsert", cn.cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("FirmID", ddlFirm.SelectedValue).DbType = DbType.Int64;
                            cmd.Parameters.AddWithValue("InvoiceNo", txtInvoiceNo.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("Item", dgv.Rows[i].Cells[1].Value.ToString()).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("HSNCode", dgv.Rows[i].Cells[2].Value.ToString()).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("Taka", dgv.Rows[i].Cells[3].Value.ToString()).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("Metres", dgv.Rows[i].Cells[4].Value.ToString()).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("Rate", dgv.Rows[i].Cells[5].Value.ToString()).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("Amount", dgv.Rows[i].Cells[6].Value.ToString()).DbType = DbType.Decimal;
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            //view--

                        }
                    }
                    else
                    {
                        for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
                        {
                            SqlCommand cmd = new SqlCommand("SalesDetailDelete", cn.cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("SalesDetailID", ds2
                                .Tables[0].Rows[i][0].ToString()).DbType = DbType.Int64;
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                        }

                        for (int i = 0; i < dgv.Rows.Count - 1; i++)
                        {

                            SqlCommand cmd = new SqlCommand("SalesDetailInsert", cn.cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("FirmID", ddlFirm.SelectedValue).DbType = DbType.Int64;
                            cmd.Parameters.AddWithValue("InvoiceNo", txtInvoiceNo.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("Item", dgv.Rows[i].Cells[1].Value.ToString()).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("HSNCode", dgv.Rows[i].Cells[2].Value.ToString()).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("Taka", dgv.Rows[i].Cells[3].Value.ToString()).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("Metres", dgv.Rows[i].Cells[4].Value.ToString()).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("Rate", dgv.Rows[i].Cells[5].Value.ToString()).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("Amount", dgv.Rows[i].Cells[6].Value.ToString()).DbType = DbType.Decimal;
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            //view--

                        }

                    }


                    if (ddlFirm.Text != "" && txtInvoiceNo.Text != "" && txtChallanNo.Text != "" && ddlBilledTo.Text != "" && txtDelTo.Text != "" && txtDelAdd.Text != "" && txtDelMobNo.Text != "" && txtDelState.Text != "" && txtDelGST.Text != "")
                    {
                        if (ds3.Tables[0].Rows.Count == 1)
                        {
                            SqlCommand cmd = new SqlCommand("SalesMasterUpdate", cn.cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("SalesID", ds3.Tables[0].Rows[0][0].ToString()).DbType = DbType.Int64;
                            cmd.Parameters.AddWithValue("FirmID", ddlFirm.SelectedValue).DbType = DbType.Int64;
                            cmd.Parameters.AddWithValue("PartyID", ddlBilledTo.SelectedValue).DbType = DbType.Int64;
                            cmd.Parameters.AddWithValue("InvoiceNo", txtInvoiceNo.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("InvoiceDate", dt).DbType = DbType.Date;
                            cmd.Parameters.AddWithValue("ChallanNo", txtChallanNo.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("ChallanDate", txtChequeDate.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("Broker", txtBroker.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("DelTo", txtDelTo.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("DelAddress", txtDelAdd.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("DelMobileNo", txtDelMobNo.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("DelState", txtDelState.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("DelGST", txtDelGST.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("State", txtState.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("Mode", ddlMode.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("VehicleNo", txtVehicle.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("SupplyDate", dtpSupplyDate.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("SupplyPlace", txtSupplyPlace.Text).DbType = DbType.String;
                            if (rbtnMeter.Checked == true)
                            {
                                cmd.Parameters.AddWithValue("Unit", rbtnMeter.Text).DbType = DbType.String;
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("Unit", rbtnKG.Text).DbType = DbType.String;
                            }
                            cmd.Parameters.AddWithValue("GrossAmount", txtGrossTotal.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("SGST", txtSGST.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("SGSTPer", ddlSGST.SelectedItem).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("CGST", txtCGST.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("CGSTPer", ddlCGST.SelectedItem).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("IGST", txtIGST.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("IGSTPer", ddlIGST.SelectedItem).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("TCS", txtTCS.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("TCSPer", txtTCSPer.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("Disc", txtDiscAmt.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("DiscPer", txtDiscPer.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("NetAmount", txtNetTotal.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("DueDate", dtpDueDate.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("Bank", txtBank.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("ChequeNo", txtChequeNo.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("ChequeDate", txtChequeDate.Text).DbType = DbType.String;
                            if (txtAmount.Text != "")
                                cmd.Parameters.AddWithValue("ChequeAmount", txtAmount.Text).DbType = DbType.Decimal;
                            else
                                cmd.Parameters.AddWithValue("ChequeAmount", 0).DbType = DbType.Decimal;

                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            //view--
                            cn.UpdateMessage();
                        }
                        else
                        {
                            SqlCommand cmd = new SqlCommand("SalesMasterInsert", cn.cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("FirmID", ddlFirm.SelectedValue).DbType = DbType.Int64;
                            cmd.Parameters.AddWithValue("PartyID", ddlBilledTo.SelectedValue).DbType = DbType.Int64;
                            cmd.Parameters.AddWithValue("InvoiceNo", txtInvoiceNo.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("InvoiceDate", dt).DbType = DbType.Date;
                            cmd.Parameters.AddWithValue("ChallanNo", txtChallanNo.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("ChallanDate", txtChequeDate.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("Broker", txtBroker.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("DelTo", txtDelTo.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("DelAddress", txtDelAdd.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("DelMobileNo", txtDelMobNo.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("DelState", txtDelState.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("DelGST", txtDelGST.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("State", txtState.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("Mode", ddlMode.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("VehicleNo", txtVehicle.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("SupplyDate", dtpSupplyDate.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("SupplyPlace", txtSupplyPlace.Text).DbType = DbType.String;
                            if (rbtnMeter.Checked == true)
                            {
                                cmd.Parameters.AddWithValue("Unit", rbtnMeter.Text).DbType = DbType.String;
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("Unit", rbtnKG.Text).DbType = DbType.String;
                            }
                            cmd.Parameters.AddWithValue("GrossAmount", txtGrossTotal.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("SGST", txtSGST.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("SGSTPer", ddlSGST.SelectedItem).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("CGST", txtCGST.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("CGSTPer", ddlCGST.SelectedItem).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("IGST", txtIGST.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("IGSTPer", ddlIGST.SelectedItem).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("TCS", txtTCS.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("TCSPer", txtTCSPer.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("Disc", txtDiscAmt.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("DiscPer", txtDiscPer.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("NetAmount", txtNetTotal.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("DueDate", dtpDueDate.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("Bank", txtBank.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("ChequeNo", txtChequeNo.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("ChequeDate", txtChequeDate.Text).DbType = DbType.String;
                            if (txtAmount.Text != "")
                                cmd.Parameters.AddWithValue("ChequeAmount", txtAmount.Text).DbType = DbType.Decimal;
                            else
                                cmd.Parameters.AddWithValue("ChequeAmount", 0).DbType = DbType.Decimal;


                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            //view--
                            cn.InsertMessage();

                        }


                        while (flag <= 1)
                        {
                            PrintDocument pd = new PrintDocument();
                            PaperSize ps = new PaperSize();
                            ps.RawKind = (int)PaperKind.A4;
                            pd.DefaultPageSettings.PaperSize = ps;
                            System.Windows.Forms.PrintDialog dlg = new PrintDialog();
                            if (dlg.PrinterSettings.PrinterName == Printer)
                                pd.PrinterSettings.PrinterName = Printer;
                            //pd.PrinterSettings.PrintToFile = true;
                            //pd.PrinterSettings.PrintFileName = "d:\\ddd11.xps";
                            pd.PrintPage += new PrintPageEventHandler(PrintPage);
                            pd.Print();
                            flag++;
                        }


                        if (cn.cn.State == ConnectionState.Open)
                            cn.cn.Close();
                        flag = 0;
                        PrintDocument pd1 = new PrintDocument();
                        //pd.DefaultPageSettings.PaperSize = new PaperSize("custom", 300, 1500);
                        pd1.PrinterSettings.PrinterName = "Microsoft XPS Document Writer";
                        pd1.PrinterSettings.PrintToFile = true;
                        pd1.PrinterSettings.PrintFileName = Application.StartupPath + "\\Firms\\" + ddlFirm.Text + "\\" + txtInvoiceNo.Text + ".xps";
                        pd1.PrintPage += new PrintPageEventHandler(PrintPage);
                        pd1.Print();
                        reset();

                    }
                    else if (ddlFirm.SelectedValue == "")
                    {
                        MessageBox.Show("Select Firm Name", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ddlFirm.Focus();
                    }
                    else if (txtInvoiceNo.Text == "")
                    {
                        MessageBox.Show("Enter Invoice no", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtInvoiceNo.Focus();
                    }
                    else if (txtChallanNo.Text == "")
                    {
                        MessageBox.Show("Enter Challan No", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtChallanNo.Focus();
                    }
                    else if (ddlBilledTo.SelectedValue == "")
                    {
                        MessageBox.Show("Select Billed To", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ddlBilledTo.Focus();
                    }
                    else if (txtDelTo.Text == "")
                    {
                        MessageBox.Show("Enter Delivery To", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDelTo.Focus();
                    }
                    else if (txtDelAdd.Text == "")
                    {
                        MessageBox.Show("Enter Delivery Address", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDelAdd.Focus();
                    }
                    else if (txtDelMobNo.Text == "")
                    {
                        MessageBox.Show("Enter Delivery Mobile No", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDelMobNo.Focus();
                    }
                    else if (txtDelState.Text == "")
                    {
                        MessageBox.Show("Enter Delivery State", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDelState.Focus();
                    }
                    else if (txtDelGST.Text == "")
                    {
                        MessageBox.Show("Enter Delivery GST", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDelGST.Focus();
                    }



                }
            }
            else
            {
                MessageBox.Show("No Items in the bill!", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count - 1 > 0)
            {
                DialogResult result = MessageBox.Show("Do you want to just save the bill? ", "Liberty Softwares", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {

                    if (cn.cn.State == ConnectionState.Closed)
                        cn.cn.Open();

                    SqlCommand cmd2 = new SqlCommand("select SalesDetailID from SalesDetail where InvoiceNo='" + txtInvoiceNo.Text + "' and FirmID='" + ddlFirm.SelectedValue + "'", cn.cn);
                    SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                    DataSet ds2 = new DataSet();
                    da2.Fill(ds2);

                    SqlCommand cmd3 = new SqlCommand("select SalesID from SalesMaster where InvoiceNo='" + txtInvoiceNo.Text + "' and FirmID='" + ddlFirm.SelectedValue + "'", cn.cn);
                    SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                    DataSet ds3 = new DataSet();
                    da3.Fill(ds3);

                    if (ds2.Tables[0].Rows.Count == 0)
                    {
                        for (int i = 0; i < dgv.Rows.Count - 1; i++)
                        {

                            SqlCommand cmd = new SqlCommand("SalesDetailInsert", cn.cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("FirmID", ddlFirm.SelectedValue).DbType = DbType.Int64;
                            cmd.Parameters.AddWithValue("InvoiceNo", txtInvoiceNo.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("Item", dgv.Rows[i].Cells[1].Value.ToString()).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("HSNCode", dgv.Rows[i].Cells[2].Value.ToString()).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("Taka", dgv.Rows[i].Cells[3].Value.ToString()).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("Metres", dgv.Rows[i].Cells[4].Value.ToString()).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("Rate", dgv.Rows[i].Cells[5].Value.ToString()).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("Amount", dgv.Rows[i].Cells[6].Value.ToString()).DbType = DbType.Decimal;
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            //view--

                        }
                    }
                    else
                    {
                        for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
                        {
                            SqlCommand cmd = new SqlCommand("SalesDetailDelete", cn.cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("SalesDetailID", ds2.Tables[0].Rows[i][0].ToString()).DbType = DbType.Int64;
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                        }

                        for (int i = 0; i < dgv.Rows.Count - 1; i++)
                        {

                            SqlCommand cmd = new SqlCommand("SalesDetailInsert", cn.cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("FirmID", ddlFirm.SelectedValue).DbType = DbType.Int64;
                            cmd.Parameters.AddWithValue("InvoiceNo", txtInvoiceNo.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("Item", dgv.Rows[i].Cells[1].Value.ToString()).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("HSNCode", dgv.Rows[i].Cells[2].Value.ToString()).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("Taka", dgv.Rows[i].Cells[3].Value.ToString()).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("Metres", dgv.Rows[i].Cells[4].Value.ToString()).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("Rate", dgv.Rows[i].Cells[5].Value.ToString()).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("Amount", dgv.Rows[i].Cells[6].Value.ToString()).DbType = DbType.Decimal;
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            //view--

                        }

                    }


                    if (ddlFirm.Text != "" && txtInvoiceNo.Text != "" && txtChallanNo.Text != "" && ddlBilledTo.Text != "" && txtDelTo.Text != "" && txtDelAdd.Text != "" && txtDelMobNo.Text != "" && txtDelState.Text != "" && txtDelGST.Text != "")
                    {
                        if (ds3.Tables[0].Rows.Count == 1)
                        {
                            SqlCommand cmd = new SqlCommand("SalesMasterUpdate", cn.cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("SalesID", ds3.Tables[0].Rows[0][0].ToString()).DbType = DbType.Int64;
                            cmd.Parameters.AddWithValue("FirmID", ddlFirm.SelectedValue).DbType = DbType.Int64;
                            cmd.Parameters.AddWithValue("PartyID", ddlBilledTo.SelectedValue).DbType = DbType.Int64;
                            cmd.Parameters.AddWithValue("InvoiceNo", txtInvoiceNo.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("InvoiceDate", dt).DbType = DbType.Date;
                            cmd.Parameters.AddWithValue("ChallanNo", txtChallanNo.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("ChallanDate", txtChequeDate.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("Broker", txtBroker.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("DelTo", txtDelTo.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("DelAddress", txtDelAdd.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("DelMobileNo", txtDelMobNo.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("DelState", txtDelState.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("DelGST", txtDelGST.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("State", txtState.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("Mode", ddlMode.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("VehicleNo", txtVehicle.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("SupplyDate", dtpSupplyDate.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("SupplyPlace", txtSupplyPlace.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("GrossAmount", txtGrossTotal.Text).DbType = DbType.Decimal;
                            if (rbtnMeter.Checked == true)
                            {
                                cmd.Parameters.AddWithValue("Unit", rbtnMeter.Text).DbType = DbType.String;
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("Unit", rbtnKG.Text).DbType = DbType.String;
                            }
                            cmd.Parameters.AddWithValue("SGST", txtSGST.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("SGSTPer", ddlSGST.SelectedItem).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("CGST", txtCGST.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("CGSTPer", ddlCGST.SelectedItem).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("IGST", txtIGST.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("IGSTPer", ddlIGST.SelectedItem).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("TCS", txtTCS.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("TCSPer", txtTCSPer.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("Disc", txtDiscAmt.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("DiscPer", txtDiscPer.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("NetAmount", txtNetTotal.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("DueDate", dtpDueDate.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("Bank", txtBank.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("ChequeNo", txtChequeNo.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("ChequeDate", txtChequeDate.Text).DbType = DbType.String;
                            if (txtAmount.Text != "")
                                cmd.Parameters.AddWithValue("ChequeAmount", txtAmount.Text).DbType = DbType.Decimal;
                            else
                                cmd.Parameters.AddWithValue("ChequeAmount", 0).DbType = DbType.Decimal;

                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            //view--
                            cn.UpdateMessage();
                        }
                        else
                        {
                            SqlCommand cmd = new SqlCommand("SalesMasterInsert", cn.cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("FirmID", ddlFirm.SelectedValue).DbType = DbType.Int64;
                            cmd.Parameters.AddWithValue("PartyID", ddlBilledTo.SelectedValue).DbType = DbType.Int64;
                            cmd.Parameters.AddWithValue("InvoiceNo", txtInvoiceNo.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("InvoiceDate", dt).DbType = DbType.Date;
                            cmd.Parameters.AddWithValue("ChallanNo", txtChallanNo.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("ChallanDate", txtChequeDate.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("Broker", txtBroker.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("DelTo", txtDelTo.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("DelAddress", txtDelAdd.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("DelMobileNo", txtDelMobNo.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("DelState", txtDelState.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("DelGST", txtDelGST.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("State", txtState.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("Mode", ddlMode.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("VehicleNo", txtVehicle.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("SupplyDate", dtpSupplyDate.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("SupplyPlace", txtSupplyPlace.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("GrossAmount", txtGrossTotal.Text).DbType = DbType.Decimal;
                            if (rbtnMeter.Checked == true)
                            {
                                cmd.Parameters.AddWithValue("Unit", rbtnMeter.Text).DbType = DbType.String;
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("Unit", rbtnKG.Text).DbType = DbType.String;
                            }
                            cmd.Parameters.AddWithValue("SGST", txtSGST.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("SGSTPer", ddlSGST.SelectedItem).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("CGST", txtCGST.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("CGSTPer", ddlCGST.SelectedItem).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("IGST", txtIGST.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("IGSTPer", ddlIGST.SelectedItem).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("TCS", txtTCS.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("TCSPer", txtTCSPer.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("Disc", txtDiscAmt.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("DiscPer", txtDiscPer.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("NetAmount", txtNetTotal.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("DueDate", dtpDueDate.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("Bank", txtBank.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("ChequeNo", txtChequeNo.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("ChequeDate", txtChequeDate.Text).DbType = DbType.String;
                            if (txtAmount.Text != "")
                                cmd.Parameters.AddWithValue("ChequeAmount", txtAmount.Text).DbType = DbType.Decimal;
                            else
                                cmd.Parameters.AddWithValue("ChequeAmount", 0).DbType = DbType.Decimal;


                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            //view--
                            cn.InsertMessage();

                        }

                        if (cn.cn.State == ConnectionState.Open)
                            cn.cn.Close();
                        flag = 0;
                        PrintDocument pd1 = new PrintDocument();
                        //pd.DefaultPageSettings.PaperSize = new PaperSize("custom", 300, 1500);
                        pd1.PrinterSettings.PrinterName = "Microsoft XPS Document Writer";
                        pd1.PrinterSettings.PrintToFile = true;
                        pd1.PrinterSettings.PrintFileName = Application.StartupPath + "\\Firms\\" + ddlFirm.Text + "\\" + txtInvoiceNo.Text + ".xps";
                        pd1.PrintPage += new PrintPageEventHandler(PrintPage);
                        pd1.Print();
                        reset();

                    }
                    else if (ddlFirm.SelectedValue == "")
                    {
                        MessageBox.Show("Select Firm Name", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ddlFirm.Focus();
                    }
                    else if (txtInvoiceNo.Text == "")
                    {
                        MessageBox.Show("Enter Invoice no", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtInvoiceNo.Focus();
                    }
                    else if (txtChallanNo.Text == "")
                    {
                        MessageBox.Show("Enter Challan No", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtChallanNo.Focus();
                    }
                    else if (ddlBilledTo.SelectedValue == "")
                    {
                        MessageBox.Show("Select Billed To", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ddlBilledTo.Focus();
                    }
                    else if (txtDelTo.Text == "")
                    {
                        MessageBox.Show("Enter Delivery To", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDelTo.Focus();
                    }
                    else if (txtDelAdd.Text == "")
                    {
                        MessageBox.Show("Enter Delivery Address", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDelAdd.Focus();
                    }
                    else if (txtDelMobNo.Text == "")
                    {
                        MessageBox.Show("Enter Delivery Mobile No", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDelMobNo.Focus();
                    }
                    else if (txtDelState.Text == "")
                    {
                        MessageBox.Show("Enter Delivery State", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDelState.Focus();
                    }
                    else if (txtDelGST.Text == "")
                    {
                        MessageBox.Show("Enter Delivery GST", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDelGST.Focus();
                    }



                }
            }
            else
            {
                MessageBox.Show("No Items in the bill!", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtInvoiceNo_Leave(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
            SqlCommand cmd = new SqlCommand("SalesMasterView", cn.cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("InvoiceNo", txtInvoiceNo.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("FirmID", ddlFirm.SelectedValue).DbType = DbType.Int64;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count == 1)
            {
                ddlBilledTo.SelectedValue = Convert.ToInt32(ds.Tables[0].Rows[0][2].ToString());
                ddlBilledTo_SelectedIndexChanged(sender, e);
                dtpInvoiceDate.Text = ds.Tables[0].Rows[0][4].ToString();
                txtChallanNo.Text = ds.Tables[0].Rows[0][5].ToString();
                txtChequeDate.Text = ds.Tables[0].Rows[0][6].ToString();
                txtBroker.Text = ds.Tables[0].Rows[0][7].ToString();
                txtDelTo.Text = ds.Tables[0].Rows[0][8].ToString();
                txtDelAdd.Text = ds.Tables[0].Rows[0][9].ToString();
                txtDelMobNo.Text = ds.Tables[0].Rows[0][10].ToString();
                txtDelState.Text = ds.Tables[0].Rows[0][11].ToString();
                txtDelGST.Text = ds.Tables[0].Rows[0][12].ToString();
                txtState.Text = ds.Tables[0].Rows[0][13].ToString();
                ddlMode.Text = ds.Tables[0].Rows[0][14].ToString();
                txtVehicle.Text = ds.Tables[0].Rows[0][15].ToString();
                dtpSupplyDate.Text = ds.Tables[0].Rows[0][16].ToString();
                txtSupplyPlace.Text = ds.Tables[0].Rows[0][17].ToString();
                if (ds.Tables[0].Rows[0][18].ToString() == "Meters")
                {
                    rbtnMeter.Checked = true;
                }
                else
                {
                    rbtnKG.Checked = true;
                }
                txtSGST.Text = ds.Tables[0].Rows[0][20].ToString();
                ddlSGST.Text = ds.Tables[0].Rows[0][21].ToString();
                txtCGST.Text = ds.Tables[0].Rows[0][22].ToString();
                ddlCGST.Text = ds.Tables[0].Rows[0][23].ToString();
                txtIGST.Text = ds.Tables[0].Rows[0][24].ToString();
                ddlIGST.Text = ds.Tables[0].Rows[0][25].ToString();
                txtTCS.Text = ds.Tables[0].Rows[0][26].ToString();
                txtTCSPer.Text = ds.Tables[0].Rows[0][27].ToString();
                txtDiscAmt.Text = ds.Tables[0].Rows[0][28].ToString();
                txtDiscPer.Text = ds.Tables[0].Rows[0][29].ToString();
                txtNetTotal.Text = ds.Tables[0].Rows[0][30].ToString();
                dtpDueDate.Text = ds.Tables[0].Rows[0][31].ToString();
                txtBank.Text = ds.Tables[0].Rows[0][32].ToString();
                txtChequeNo.Text = ds.Tables[0].Rows[0][33].ToString();
                txtChequeDate.Text = ds.Tables[0].Rows[0][34].ToString();
                txtAmount.Text = ds.Tables[0].Rows[0][35].ToString();

                SqlCommand cmd2 = new SqlCommand("SalesDetailView", cn.cn);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("InvoiceNo", txtInvoiceNo.Text).DbType = DbType.String;
                cmd2.Parameters.AddWithValue("FirmID", ddlFirm.SelectedValue).DbType = DbType.Int64;
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2);

                if (ds2.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
                    {
                        dgv.Rows.Insert(i, ds2.Tables[0].Rows[i][3].ToString(), ds2.Tables[0].Rows[i][3].ToString(), ds2.Tables[0].Rows[i][4].ToString(), ds2.Tables[0].Rows[i][5].ToString(), ds2.Tables[0].Rows[i][6].ToString(), ds2.Tables[0].Rows[i][7].ToString(), ds2.Tables[0].Rows[i][8].ToString());
                    }
                }

            }
        }

        private void ddlFirm_SelectedIndexChanged(object sender, EventArgs e)
        {
            setNextInvoiceNo();
        }

        private void dtpInvoiceDate_ValueChanged(object sender, EventArgs e)
        {
            dt = DateTime.ParseExact(dtpInvoiceDate.Text, "dd/MM/yyyy h:mm tt", CultureInfo.InvariantCulture);
        }

        private void btnUpdateAll_Click(object sender, EventArgs e)
        {
            SqlCommand cmda = new SqlCommand("select InvoiceNo from SalesMaster where FirmID='" + ddlFirm.SelectedValue + "' ", cn.cn);
            SqlDataAdapter daa = new SqlDataAdapter(cmda);
            DataSet dsa = new DataSet();
            daa.Fill(dsa);
            if (dsa.Tables[0].Rows.Count > 0)
                for (int j = 0; j < dsa.Tables[0].Rows.Count; j++)
                {
                    txtInvoiceNo.Text = dsa.Tables[0].Rows[j][0].ToString();
                    txtInvoiceNo_Leave(sender, e);
                    if (cn.cn.State == ConnectionState.Closed)
                        cn.cn.Open();

                    SqlCommand cmd2 = new SqlCommand("select SalesDetailID from SalesDetail where InvoiceNo='" + txtInvoiceNo.Text + "' and FirmID='" + ddlFirm.SelectedValue + "'", cn.cn);
                    SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                    DataSet ds2 = new DataSet();
                    da2.Fill(ds2);

                    SqlCommand cmd3 = new SqlCommand("select SalesID from SalesMaster where InvoiceNo='" + txtInvoiceNo.Text + "' and FirmID='" + ddlFirm.SelectedValue + "'", cn.cn);
                    SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                    DataSet ds3 = new DataSet();
                    da3.Fill(ds3);

                    if (ds2.Tables[0].Rows.Count == 0)
                    {
                        for (int i = 0; i < dgv.Rows.Count - 1; i++)
                        {

                            SqlCommand cmd = new SqlCommand("SalesDetailInsert", cn.cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("FirmID", ddlFirm.SelectedValue).DbType = DbType.Int64;
                            cmd.Parameters.AddWithValue("InvoiceNo", txtInvoiceNo.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("Item", dgv.Rows[i].Cells[1].Value.ToString()).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("HSNCode", dgv.Rows[i].Cells[2].Value.ToString()).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("Taka", dgv.Rows[i].Cells[3].Value.ToString()).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("Metres", dgv.Rows[i].Cells[4].Value.ToString()).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("Rate", dgv.Rows[i].Cells[5].Value.ToString()).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("Amount", dgv.Rows[i].Cells[6].Value.ToString()).DbType = DbType.Decimal;
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            //view--

                        }
                    }
                    else
                    {
                        for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
                        {
                            SqlCommand cmd = new SqlCommand("SalesDetailDelete", cn.cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("SalesDetailID", ds2.Tables[0].Rows[i][0].ToString()).DbType = DbType.Int64;
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                        }

                        for (int i = 0; i < dgv.Rows.Count - 1; i++)
                        {

                            SqlCommand cmd = new SqlCommand("SalesDetailInsert", cn.cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("FirmID", ddlFirm.SelectedValue).DbType = DbType.Int64;
                            cmd.Parameters.AddWithValue("InvoiceNo", txtInvoiceNo.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("Item", dgv.Rows[i].Cells[1].Value.ToString()).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("HSNCode", dgv.Rows[i].Cells[2].Value.ToString()).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("Taka", dgv.Rows[i].Cells[3].Value.ToString()).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("Metres", dgv.Rows[i].Cells[4].Value.ToString()).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("Rate", dgv.Rows[i].Cells[5].Value.ToString()).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("Amount", dgv.Rows[i].Cells[6].Value.ToString()).DbType = DbType.Decimal;
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            //view--

                        }

                    }


                    if (ddlFirm.Text != "" && txtInvoiceNo.Text != "" && txtChallanNo.Text != "" && ddlBilledTo.Text != "" && txtDelTo.Text != "" && txtDelAdd.Text != "" && txtDelMobNo.Text != "" && txtDelState.Text != "" && txtDelGST.Text != "")
                    {
                        if (ds3.Tables[0].Rows.Count == 1)
                        {
                            SqlCommand cmd = new SqlCommand("SalesMasterUpdate", cn.cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("SalesID", ds3.Tables[0].Rows[0][0].ToString()).DbType = DbType.Int64;
                            cmd.Parameters.AddWithValue("FirmID", ddlFirm.SelectedValue).DbType = DbType.Int64;
                            cmd.Parameters.AddWithValue("PartyID", ddlBilledTo.SelectedValue).DbType = DbType.Int64;
                            cmd.Parameters.AddWithValue("InvoiceNo", txtInvoiceNo.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("InvoiceDate", dt).DbType = DbType.Date;
                            cmd.Parameters.AddWithValue("ChallanNo", txtChallanNo.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("ChallanDate", txtChequeDate.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("Broker", txtBroker.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("DelTo", txtDelTo.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("DelAddress", txtDelAdd.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("DelMobileNo", txtDelMobNo.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("DelState", txtDelState.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("DelGST", txtDelGST.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("State", txtState.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("Mode", ddlMode.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("VehicleNo", txtVehicle.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("SupplyDate", dtpSupplyDate.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("SupplyPlace", txtSupplyPlace.Text).DbType = DbType.String;
                            if (rbtnMeter.Checked == true)
                            {
                                cmd.Parameters.AddWithValue("Unit", rbtnMeter.Text).DbType = DbType.String;
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("Unit", rbtnKG.Text).DbType = DbType.String;
                            }
                            cmd.Parameters.AddWithValue("GrossAmount", txtGrossTotal.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("SGST", txtSGST.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("SGSTPer", ddlSGST.SelectedItem).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("CGST", txtCGST.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("CGSTPer", ddlCGST.SelectedItem).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("IGST", txtIGST.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("IGSTPer", ddlIGST.SelectedItem).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("TCS", txtTCS.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("TCSPer", txtTCSPer.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("Disc", txtDiscAmt.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("DiscPer", txtDiscPer.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("NetAmount", txtNetTotal.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("DueDate", dtpDueDate.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("Bank", txtBank.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("ChequeNo", txtChequeNo.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("ChequeDate", txtChequeDate.Text).DbType = DbType.String;
                            if (txtAmount.Text != "")
                                cmd.Parameters.AddWithValue("ChequeAmount", txtAmount.Text).DbType = DbType.Decimal;
                            else
                                cmd.Parameters.AddWithValue("ChequeAmount", 0).DbType = DbType.Decimal;

                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            //view--
                            //cn.UpdateMessage();
                        }
                        else
                        {
                            SqlCommand cmd = new SqlCommand("SalesMasterInsert", cn.cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("FirmID", ddlFirm.SelectedValue).DbType = DbType.Int64;
                            cmd.Parameters.AddWithValue("PartyID", ddlBilledTo.SelectedValue).DbType = DbType.Int64;
                            cmd.Parameters.AddWithValue("InvoiceNo", txtInvoiceNo.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("InvoiceDate", dt).DbType = DbType.Date;
                            cmd.Parameters.AddWithValue("ChallanNo", txtChallanNo.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("ChallanDate", txtChequeDate.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("Broker", txtBroker.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("DelTo", txtDelTo.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("DelAddress", txtDelAdd.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("DelMobileNo", txtDelMobNo.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("DelState", txtDelState.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("DelGST", txtDelGST.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("State", txtState.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("Mode", ddlMode.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("VehicleNo", txtVehicle.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("SupplyDate", dtpSupplyDate.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("SupplyPlace", txtSupplyPlace.Text).DbType = DbType.String;
                            if (rbtnMeter.Checked == true)
                            {
                                cmd.Parameters.AddWithValue("Unit", rbtnMeter.Text).DbType = DbType.String;
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("Unit", rbtnKG.Text).DbType = DbType.String;
                            }
                            cmd.Parameters.AddWithValue("GrossAmount", txtGrossTotal.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("SGST", txtSGST.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("SGSTPer", ddlSGST.SelectedItem).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("CGST", txtCGST.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("CGSTPer", ddlCGST.SelectedItem).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("IGST", txtIGST.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("IGSTPer", ddlIGST.SelectedItem).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("TCS", txtTCS.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("TCSPer", txtTCSPer.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("Disc", txtDiscAmt.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("DiscPer", txtDiscPer.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("NetAmount", txtNetTotal.Text).DbType = DbType.Decimal;
                            cmd.Parameters.AddWithValue("DueDate", dtpDueDate.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("Bank", txtBank.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("ChequeNo", txtChequeNo.Text).DbType = DbType.String;
                            cmd.Parameters.AddWithValue("ChequeDate", txtChequeDate.Text).DbType = DbType.String;
                            if (txtAmount.Text != "")
                                cmd.Parameters.AddWithValue("ChequeAmount", txtAmount.Text).DbType = DbType.Decimal;
                            else
                                cmd.Parameters.AddWithValue("ChequeAmount", 0).DbType = DbType.Decimal;


                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            //view--
                            //cn.InsertMessage();

                        }

                        if (cn.cn.State == ConnectionState.Open)
                            cn.cn.Close();
                        flag = 0;
                        PrintDocument pd1 = new PrintDocument();
                        //pd.DefaultPageSettings.PaperSize = new PaperSize("custom", 300, 1500);
                        pd1.PrinterSettings.PrinterName = "Microsoft XPS Document Writer";
                        pd1.PrinterSettings.PrintToFile = true;
                        pd1.PrinterSettings.PrintFileName = Application.StartupPath + "\\Firms\\" + ddlFirm.Text + "\\" + txtInvoiceNo.Text + ".xps";
                        pd1.PrintPage += new PrintPageEventHandler(PrintPage);
                        pd1.Print();
                        reset();

                    }
                    else if (ddlFirm.SelectedValue == "")
                    {
                        MessageBox.Show("Select Firm Name", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ddlFirm.Focus();
                    }
                    else if (txtInvoiceNo.Text == "")
                    {
                        MessageBox.Show("Enter Invoice no", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtInvoiceNo.Focus();
                    }
                    else if (txtChallanNo.Text == "")
                    {
                        MessageBox.Show("Enter Challan No", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtChallanNo.Focus();
                    }
                    else if (ddlBilledTo.SelectedValue == "")
                    {
                        MessageBox.Show("Select Billed To", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ddlBilledTo.Focus();
                    }
                    else if (txtDelTo.Text == "")
                    {
                        MessageBox.Show("Enter Delivery To", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDelTo.Focus();
                    }
                    else if (txtDelAdd.Text == "")
                    {
                        MessageBox.Show("Enter Delivery Address", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDelAdd.Focus();
                    }
                    else if (txtDelMobNo.Text == "")
                    {
                        MessageBox.Show("Enter Delivery Mobile No", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDelMobNo.Focus();
                    }
                    else if (txtDelState.Text == "")
                    {
                        MessageBox.Show("Enter Delivery State", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDelState.Focus();
                    }
                    else if (txtDelGST.Text == "")
                    {
                        MessageBox.Show("Enter Delivery GST", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDelGST.Focus();
                    }
                }
            MessageBox.Show("Done");
        }
    }
}
