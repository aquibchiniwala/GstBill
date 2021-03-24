using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GSTBill
{
    public partial class SupplierMaster : Form
    {
        Connectivity cn = new Connectivity();
        public SupplierMaster()
        {
            InitializeComponent();
        }

        private void reset()
        {
            txtSupplierName.Tag = null;
            txtSupplierName.Text = "";
            txtSupplierName.Focus();
            txtMobileNo.Text = "";
            txtAddress.Text = "";
            txtState.Text = "";
            txtGSTNo.Text = "";
        }

        private void SupplierMaster_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsSupplierMasterView.SupplierMasterView' table. You can move, or remove it, as needed.
            this.supplierMasterViewTableAdapter.Fill(this.dsSupplierMasterView.SupplierMasterView);

        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            if (txtSupplierName.Text != "" && txtMobileNo.Text != "" && txtAddress.Text != "" && txtState.Text != "" && txtGSTNo.Text != "")
            {
                if (txtSupplierName.Tag != null)
                {
                    if (cn.cn.State == ConnectionState.Closed)
                        cn.cn.Open();
                    SqlCommand cmd = new SqlCommand("SupplierMasterUpdate", cn.cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("SupplierID", txtSupplierName.Tag).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("SupplierName", txtSupplierName.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("MobileNo", txtMobileNo.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("Address", txtAddress.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("State", txtState.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("GSTIN", txtGSTNo.Text).DbType = DbType.String;
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    if (cn.cn.State == ConnectionState.Open)
                        cn.cn.Close();
                    this.supplierMasterViewTableAdapter.Fill(this.dsSupplierMasterView.SupplierMasterView);
                    cn.UpdateMessage();
                    reset();
                }
                else
                {
                    if (cn.cn.State == ConnectionState.Closed)
                        cn.cn.Open();
                    SqlCommand cmd = new SqlCommand("SupplierMasterInsert", cn.cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("SupplierName", txtSupplierName.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("MobileNo", txtMobileNo.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("Address", txtAddress.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("State", txtState.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("GSTIN", txtGSTNo.Text).DbType = DbType.String;
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    if (cn.cn.State == ConnectionState.Open)
                        cn.cn.Close();
                    this.supplierMasterViewTableAdapter.Fill(this.dsSupplierMasterView.SupplierMasterView);

                    cn.InsertMessage();
                    reset();
                }
            }
            else if (txtSupplierName.Text == "")
            {
                MessageBox.Show("Enter Supplier Name", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSupplierName.Focus();
            }
            else if (txtMobileNo.Text == "")
            {
                MessageBox.Show("Enter Mobile no", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMobileNo.Focus();
            }
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("Enter Address", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
            }
            else if (txtState.Text == "")
            {
                MessageBox.Show("Enter State", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtState.Focus();
            }
            else if (txtGSTNo.Text == "")
            {
                MessageBox.Show("Enter GSTIN", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGSTNo.Focus();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            cn.Exit(this);
        }

        private void dgvView_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvView.Focus())
            {
                if (dgvView.CurrentRow != null)
                {
                    txtSupplierName.Tag = dgvView.CurrentRow.Cells[0].Value.ToString();
                    txtSupplierName.Text = dgvView.CurrentRow.Cells[1].Value.ToString();
                    txtAddress.Text = dgvView.CurrentRow.Cells[2].Value.ToString();
                    txtMobileNo.Text = dgvView.CurrentRow.Cells[3].Value.ToString();
                    txtState.Text = dgvView.CurrentRow.Cells[4].Value.ToString();
                    txtGSTNo.Text = dgvView.CurrentRow.Cells[5].Value.ToString();
                }
            }
        }

        private void SupplierMaster_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dgvView.Focused)
                {
                    if (txtSupplierName.Tag != null)
                    {
                        if (cn.cn.State == ConnectionState.Closed)
                            cn.cn.Open();
                        SqlCommand cmd = new SqlCommand("SupplierMasterDelete", cn.cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("SupplierID", txtSupplierName.Tag).DbType = DbType.String;
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        if (cn.cn.State == ConnectionState.Open)
                            cn.cn.Close();
                        this.supplierMasterViewTableAdapter.Fill(this.dsSupplierMasterView.SupplierMasterView);
                        cn.DeleteMessage();
                        reset();
                    }
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                cn.Exit(this);
            }
            else if (e.KeyCode == Keys.Home)
            {
                reset();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (dgvView.Focused)
                {
                    e.SuppressKeyPress = true;
                    txtSupplierName.Focus();
                }
                else
                {
                    SendKeys.Send("{TAB}");
                }
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                dgvView.Focus();
                if (dgvView.CurrentRow != null)
                {
                    txtSupplierName.Tag = dgvView.CurrentRow.Cells[0].Value.ToString();
                    txtSupplierName.Text = dgvView.CurrentRow.Cells[1].Value.ToString();
                    txtAddress.Text = dgvView.CurrentRow.Cells[2].Value.ToString();
                    txtMobileNo.Text = dgvView.CurrentRow.Cells[3].Value.ToString();
                    txtState.Text = dgvView.CurrentRow.Cells[4].Value.ToString();
                    txtGSTNo.Text = dgvView.CurrentRow.Cells[5].Value.ToString();
                }
            }
            else if (e.KeyCode == Keys.S && e.Control)
            {
                btnSave_Click(sender, e);
            }
        }
    }
}
