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
    public partial class PurchaseDetail : Form
    {
        public PurchaseDetail()
        {
            InitializeComponent();
        }

        public void reset()
        {
            ddlSupplier.SelectedIndex = 0;
            txtInvoiceNo.Text = "";
            dtpInvoiceDate.Value = DateTime.Today;
            txtChallanNo.Text = "";
            dtpChallanDate.Value = DateTime.Today;
            dgv.Rows.Clear();
            ddlSGST.SelectedIndex = 3;
            ddlCGST.SelectedIndex = 3;
            ddlIGST.SelectedIndex = 0;
            txtSGST.Text = "0";
            txtCGST.Text = "0";
            txtIGST.Text = "0";
            txtGrossTotal.Text = "0";
            txtDiscPer.Text = "0";
            txtDiscAmt.Text = "0";
            txtNetTotal.Text = "0";
        }

        private void PurchaseDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsListAllSupplier.ListAllSupplier' table. You can move, or remove it, as needed.
            this.listAllSupplierTableAdapter.Fill(this.dsListAllSupplier.ListAllSupplier);
            ddlSGST.SelectedIndex = 3;
            ddlCGST.SelectedIndex = 3;


        }

        private void txtInvoiceNo_TextChanged(object sender, EventArgs e)
        {
            txtChallanNo.Text = txtInvoiceNo.Text;
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
    }
}
