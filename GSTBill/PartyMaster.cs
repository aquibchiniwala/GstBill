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
    public partial class PartyMaster : Form
    {
        Connectivity cn = new Connectivity();
        public PartyMaster()
        {
            InitializeComponent();
        }

        private void reset()
        {
            txtPartyName.Tag = null;
            txtPartyName.Text = "";
            txtPartyName.Focus();
            txtMobileNo.Text = "";
            txtAddress.Text = "";
            txtState.Text = "";
            txtGSTNo.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPartyName.Text != "" && txtMobileNo.Text != "" && txtAddress.Text != "" && txtState.Text != "" && txtGSTNo.Text != "")
            {
                if (txtPartyName.Tag != null)
                {
                    if (cn.cn.State == ConnectionState.Closed)
                        cn.cn.Open();
                    SqlCommand cmd = new SqlCommand("PartyMasterUpdate", cn.cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("PartyID", txtPartyName.Tag).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("PartyName", txtPartyName.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("MobileNo", txtMobileNo.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("Address", txtAddress.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("State", txtState.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("GSTIN", txtGSTNo.Text).DbType = DbType.String;
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    if (cn.cn.State == ConnectionState.Open)
                        cn.cn.Close();
                    this.partyMasterViewTableAdapter.Fill(this.dsPartyMasterView.PartyMasterView);
                    cn.UpdateMessage();
                    reset();
                }
                else
                {
                    if (cn.cn.State == ConnectionState.Closed)
                        cn.cn.Open();
                    SqlCommand cmd = new SqlCommand("PartyMasterInsert", cn.cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("PartyName", txtPartyName.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("MobileNo", txtMobileNo.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("Address", txtAddress.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("State", txtState.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("GSTIN", txtGSTNo.Text).DbType = DbType.String;
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    if (cn.cn.State == ConnectionState.Open)
                        cn.cn.Close();
                    this.partyMasterViewTableAdapter.Fill(this.dsPartyMasterView.PartyMasterView);

                    cn.InsertMessage();
                    reset();
                }
            }
            else if (txtPartyName.Text == "")
            {
                MessageBox.Show("Enter Party Name", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPartyName.Focus();
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
        

        private void PartyMaster_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsPartyMasterView.PartyMasterView' table. You can move, or remove it, as needed.
            this.partyMasterViewTableAdapter.Fill(this.dsPartyMasterView.PartyMasterView);

        }

        private void txtMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
           // cn.NoVal(sender, e);
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
                    txtPartyName.Tag = dgvView.CurrentRow.Cells[0].Value.ToString();
                    txtPartyName.Text = dgvView.CurrentRow.Cells[1].Value.ToString();
                    txtAddress.Text = dgvView.CurrentRow.Cells[2].Value.ToString();
                    txtMobileNo.Text = dgvView.CurrentRow.Cells[3].Value.ToString();
                    txtState.Text = dgvView.CurrentRow.Cells[4].Value.ToString();
                    txtGSTNo.Text = dgvView.CurrentRow.Cells[5].Value.ToString();
                }
            }
        }

        private void PartyMaster_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dgvView.Focused)
                {
                    if (txtPartyName.Tag != null)
                    {
                        if (cn.cn.State == ConnectionState.Closed)
                            cn.cn.Open();
                        SqlCommand cmd = new SqlCommand("PartyMasterDelete", cn.cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("PartyID", txtPartyName.Tag).DbType = DbType.String;
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        if (cn.cn.State == ConnectionState.Open)
                            cn.cn.Close();
                        this.partyMasterViewTableAdapter.Fill(this.dsPartyMasterView.PartyMasterView);
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
                    txtPartyName.Focus();
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
                    txtPartyName.Tag = dgvView.CurrentRow.Cells[0].Value.ToString();
                    txtPartyName.Text = dgvView.CurrentRow.Cells[1].Value.ToString();
                    txtAddress.Text = dgvView.CurrentRow.Cells[2].Value.ToString();
                    txtMobileNo.Text = dgvView.CurrentRow.Cells[3].Value.ToString();
                    txtState.Text = dgvView.CurrentRow.Cells[4].Value.ToString();
                    txtGSTNo.Text = dgvView.CurrentRow.Cells[5].Value.ToString();
                }
            }
            else if (e.KeyCode == Keys.S && e.Control) 
            {
                if (txtPartyName.Text != "" && txtMobileNo.Text != "" && txtAddress.Text != "" && txtState.Text != "" && txtGSTNo.Text != "")
                {
                    if (txtPartyName.Tag != null)
                    {
                        if (cn.cn.State == ConnectionState.Closed)
                            cn.cn.Open();
                        SqlCommand cmd = new SqlCommand("PartyMasterUpdate", cn.cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("PartyID", txtPartyName.Tag).DbType = DbType.Int64;
                        cmd.Parameters.AddWithValue("PartyName", txtPartyName.Text).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("MobileNo", txtMobileNo.Text).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("Address", txtAddress.Text).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("State", txtState.Text).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("GSTIN", txtGSTNo.Text).DbType = DbType.String;
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        if (cn.cn.State == ConnectionState.Open)
                            cn.cn.Close();
                        this.partyMasterViewTableAdapter.Fill(this.dsPartyMasterView.PartyMasterView);
                        cn.UpdateMessage();
                        reset();
                    }
                    else
                    {
                        if (cn.cn.State == ConnectionState.Closed)
                            cn.cn.Open();
                        SqlCommand cmd = new SqlCommand("PartyMasterInsert", cn.cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("PartyName", txtPartyName.Text).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("MobileNo", txtMobileNo.Text).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("Address", txtAddress.Text).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("State", txtState.Text).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("GSTIN", txtGSTNo.Text).DbType = DbType.String;
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        if (cn.cn.State == ConnectionState.Open)
                            cn.cn.Close();
                        this.partyMasterViewTableAdapter.Fill(this.dsPartyMasterView.PartyMasterView);

                        cn.InsertMessage();
                        reset();
                    }
                }
                else if (txtPartyName.Text == "")
                {
                    MessageBox.Show("Enter Party Name", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPartyName.Focus();
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
        }
    }
}
