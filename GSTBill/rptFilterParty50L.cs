using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSTBill
{
    public partial class rptFilterParty50L : Form
    {
        DateTime dt, dt2;
        Connectivity cn = new Connectivity();
        String date = DateTime.Today.Day + "-" + DateTime.Today.Month + "-" + DateTime.Today.Year;
        public rptFilterParty50L()
        {
            InitializeComponent();
        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            dt = DateTime.ParseExact(dtpFromDate.Text, "dd/MM/yyyy", null);
        }

        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            dt2 = DateTime.ParseExact(dtpToDate.Text, "dd/MM/yyyy", null);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            this.rptFilterParty50LTableAdapter.Fill(this.dsRptFilterParty50L.rptFilterParty50L, dt, dt2);
        }

        private void rptFilterParty50L_Load(object sender, EventArgs e)
        {
            string startFinancialYear = (Convert.ToInt32(getFinancialYear(DateTime.Today)) - 1).ToString();
            dtpFromDate.Text = "01/04/" + startFinancialYear;

            string endEinancialYear = getFinancialYear(DateTime.Today);
            dtpToDate.Text = "31/03/" + endEinancialYear;

            dtpFromDate_ValueChanged(sender, e);
            dtpToDate_ValueChanged(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            cn.Exit(this);
        }

        public string getFinancialYear(DateTime dateTime)
        {
            return (dateTime.Month >= 4 ? dateTime.Year + 1 : dateTime.Year).ToString();
        }
    }
}
