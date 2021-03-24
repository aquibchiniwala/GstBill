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
    public partial class Menu : Form
    {
        Connectivity cn = new Connectivity();
        public Menu()
        {
            InitializeComponent();
        }

        private void printBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesDetail bill = new SalesDetail();
            bill.ShowDialog();
        }

        private void storeMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PartyMaster pm = new PartyMaster();
            pm.ShowDialog();
        }

        private void manageFirmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FirmMaster fm = new FirmMaster();
            fm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rptSales sr = new rptSales();
            sr.ShowDialog();
        }

        private void managePurchasePartyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierMaster sm = new SupplierMaster();
            sm.ShowDialog();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
