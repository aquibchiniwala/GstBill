﻿using System;
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
    public partial class FirmMaster : Form
    {
        Connectivity cn = new Connectivity();
        string oldname;
        public FirmMaster()
        {
            InitializeComponent();
        }

        private void reset()
        {
            txtFirmName.Tag = null;
            txtFirmName.Text = "";
            txtFirmName.Focus();
            txtMobileNo.Text = "";
            txtAddress.Text = "";
            txtGSTNo.Text = "";
            txtBankName.Text = "";
            txtAccountNo.Text = "";
            txtIFSC.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFirmName.Text != "" && txtMobileNo.Text != "" && txtAddress.Text != "" && txtGSTNo.Text != "" && txtBankName.Text != "" && txtAccountNo.Text != "" && txtIFSC.Text != "")
            {
                if (txtFirmName.Tag != null)
                {
                    if (cn.cn.State == ConnectionState.Closed)
                        cn.cn.Open();
                    SqlCommand cmd = new SqlCommand("FirmMasterUpdate", cn.cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("FirmID", txtFirmName.Tag).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("FirmName", txtFirmName.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("MobileNo", txtMobileNo.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("Address", txtAddress.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("GSTIN", txtGSTNo.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("BankName", txtBankName.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("AccountNo", txtAccountNo.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("IFSC", txtIFSC.Text).DbType = DbType.String;
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    if (cn.cn.State == ConnectionState.Open)
                        cn.cn.Close();
                    if (oldname != txtFirmName.Text)
                    {
                        if (!System.IO.Directory.Exists(Application.StartupPath + "\\Firms\\" + oldname))
                        {
                            System.IO.Directory.CreateDirectory(Application.StartupPath + "\\Firms\\" + txtFirmName.Text);
                            System.IO.Directory.CreateDirectory(Application.StartupPath + "\\Firms\\" + txtFirmName.Text + "\\Reports");
                        }
                        else
                        {
                            System.IO.Directory.Move(Application.StartupPath + "\\Firms\\" + oldname, Application.StartupPath + "\\Firms\\" + txtFirmName.Text);
                        }
                    }
                    else
                    {
                        if (!System.IO.Directory.Exists(Application.StartupPath + "\\Firms\\" + txtFirmName.Text))
                        {
                            System.IO.Directory.CreateDirectory(Application.StartupPath + "\\Firms\\" + txtFirmName.Text);
                            System.IO.Directory.CreateDirectory(Application.StartupPath + "\\Firms\\" + txtFirmName.Text + "\\Reports");
                        }
                    }
                    this.firmMasterViewTableAdapter.Fill(this.dsFirmMasterView.FirmMasterView);
                    cn.UpdateMessage();
                }
                else
                {
                    if (cn.cn.State == ConnectionState.Closed)
                        cn.cn.Open();
                    SqlCommand cmd = new SqlCommand("FirmMasterInsert", cn.cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("FirmName", txtFirmName.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("MobileNo", txtMobileNo.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("Address", txtAddress.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("GSTIN", txtGSTNo.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("BankName", txtBankName.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("AccountNo", txtAccountNo.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("IFSC", txtIFSC.Text).DbType = DbType.String;
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    if (cn.cn.State == ConnectionState.Open)
                        cn.cn.Close();
                    this.firmMasterViewTableAdapter.Fill(this.dsFirmMasterView.FirmMasterView);
                    System.IO.Directory.CreateDirectory(Application.StartupPath + "\\Firms\\" + txtFirmName.Text);
                    System.IO.Directory.CreateDirectory(Application.StartupPath + "\\Firms\\" + txtFirmName.Text + "\\Reports");
                    cn.InsertMessage();
                }
                reset();
            }
            else if (txtFirmName.Text == "")
            {
                MessageBox.Show("Enter firm Name", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirmName.Focus();
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
            else if (txtGSTNo.Text == "")
            {
                MessageBox.Show("Enter GSTIN", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGSTNo.Focus();
            }
            else if (txtBankName.Text == "")
            {
                MessageBox.Show("Enter Bank Name", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBankName.Focus();
            }
            else if (txtAccountNo.Text == "")
            {
                MessageBox.Show("Enter Bank Account Number", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAccountNo.Focus();
            }
            else if (txtIFSC.Text == "")
            {
                MessageBox.Show("Enter Bank IFSC Code", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIFSC.Focus();
            }
        }

        private void FirmMaster_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsFirmMasterView.FirmMasterView' table. You can move, or remove it, as needed.
            this.firmMasterViewTableAdapter.Fill(this.dsFirmMasterView.FirmMasterView);
            // TODO: This line of code loads data into the 'dsFirmMasterView.FirmMasterView' table. You can move, or remove it, as needed.
            this.firmMasterViewTableAdapter.Fill(this.dsFirmMasterView.FirmMasterView);

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
                    txtFirmName.Tag = dgvView.CurrentRow.Cells[0].Value.ToString();
                    txtFirmName.Text = dgvView.CurrentRow.Cells[1].Value.ToString();
                    oldname = dgvView.CurrentRow.Cells[1].Value.ToString();
                    txtAddress.Text = dgvView.CurrentRow.Cells[2].Value.ToString();
                    txtMobileNo.Text = dgvView.CurrentRow.Cells[3].Value.ToString();
                    txtGSTNo.Text = dgvView.CurrentRow.Cells[4].Value.ToString();
                    txtBankName.Text = dgvView.CurrentRow.Cells[5].Value.ToString();
                    txtAccountNo.Text = dgvView.CurrentRow.Cells[6].Value.ToString();
                    txtIFSC.Text = dgvView.CurrentRow.Cells[7].Value.ToString();
                }
            }
        }

        private void FirmMaster_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dgvView.Focused)
                {
                    if (txtFirmName.Tag != null)
                    {
                        if (cn.cn.State == ConnectionState.Closed)
                            cn.cn.Open();
                        SqlCommand cmd = new SqlCommand("FirmMasterDelete", cn.cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("FirmID", txtFirmName.Tag).DbType = DbType.String;
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        if (cn.cn.State == ConnectionState.Open)
                            cn.cn.Close();
                        this.firmMasterViewTableAdapter.Fill(this.dsFirmMasterView.FirmMasterView);
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
                    txtFirmName.Focus();
                }
                else
                {
                    SendKeys.Send("{TAB}");
                }
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                dgvView.Focus();
                //if (dgvView.CurrentRow != null)
                //{
                //    txtFirmName.Tag = dgvView.CurrentRow.Cells[0].Value.ToString();
                //    txtFirmName.Text = dgvView.CurrentRow.Cells[1].Value.ToString();
                //    oldname = dgvView.CurrentRow.Cells[1].Value.ToString();
                //    txtAddress.Text = dgvView.CurrentRow.Cells[2].Value.ToString();
                //    txtMobileNo.Text = dgvView.CurrentRow.Cells[3].Value.ToString();
                //    txtGSTNo.Text = dgvView.CurrentRow.Cells[4].Value.ToString();
                //    txtBankName.Text = dgvView.CurrentRow.Cells[5].Value.ToString();
                //    txtAccountNo.Text = dgvView.CurrentRow.Cells[6].Value.ToString();
                //    txtIFSC.Text = dgvView.CurrentRow.Cells[7].Value.ToString();
                //}
            }
            else if (e.KeyCode == Keys.S && e.Control)
            {
                if (txtFirmName.Text != "" && txtMobileNo.Text != "" && txtAddress.Text != "" && txtGSTNo.Text != "" && txtBankName.Text != "" && txtAccountNo.Text != "" && txtIFSC.Text != "")
                {
                    if (txtFirmName.Tag != null)
                    {
                        if (cn.cn.State == ConnectionState.Closed)
                            cn.cn.Open();
                        SqlCommand cmd = new SqlCommand("FirmMasterUpdate", cn.cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("FirmID", txtFirmName.Tag).DbType = DbType.Int64;
                        cmd.Parameters.AddWithValue("FirmName", txtFirmName.Text).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("MobileNo", txtMobileNo.Text).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("Address", txtAddress.Text).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("GSTIN", txtGSTNo.Text).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("BankName", txtBankName.Text).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("AccountNo", txtAccountNo.Text).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("IFSC", txtIFSC.Text).DbType = DbType.String;
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        if (cn.cn.State == ConnectionState.Open)
                            cn.cn.Close();
                        if (oldname != txtFirmName.Text)
                        {
                            if (!System.IO.Directory.Exists(Application.StartupPath + "\\Firms\\" + oldname))
                            {
                                System.IO.Directory.CreateDirectory(Application.StartupPath + "\\Firms\\" + txtFirmName.Text);
                                System.IO.Directory.CreateDirectory(Application.StartupPath + "\\Firms\\" + txtFirmName.Text + "\\Reports");
                            }
                            else
                            {
                                System.IO.Directory.Move(Application.StartupPath + "\\Firms\\" + oldname, Application.StartupPath + "\\Firms\\" + txtFirmName.Text);
                            }
                        }
                        else
                        {
                            if (!System.IO.Directory.Exists(Application.StartupPath + "\\Firms\\" + txtFirmName.Text))
                            {
                                System.IO.Directory.CreateDirectory(Application.StartupPath + "\\Firms\\" + txtFirmName.Text);
                                System.IO.Directory.CreateDirectory(Application.StartupPath + "\\Firms\\" + txtFirmName.Text + "\\Reports");
                            }
                        }
                        this.firmMasterViewTableAdapter.Fill(this.dsFirmMasterView.FirmMasterView);
                        cn.UpdateMessage();
                    }
                    else
                    {
                        if (cn.cn.State == ConnectionState.Closed)
                            cn.cn.Open();
                        SqlCommand cmd = new SqlCommand("FirmMasterInsert", cn.cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("FirmName", txtFirmName.Text).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("MobileNo", txtMobileNo.Text).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("Address", txtAddress.Text).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("GSTIN", txtGSTNo.Text).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("BankName", txtBankName.Text).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("AccountNo", txtAccountNo.Text).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("IFSC", txtIFSC.Text).DbType = DbType.String;
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        if (cn.cn.State == ConnectionState.Open)
                            cn.cn.Close();
                        this.firmMasterViewTableAdapter.Fill(this.dsFirmMasterView.FirmMasterView);
                        System.IO.Directory.CreateDirectory(Application.StartupPath + "\\Firms\\" + txtFirmName.Text);
                        System.IO.Directory.CreateDirectory(Application.StartupPath + "\\Firms\\" + txtFirmName.Text + "\\Reports");
                        cn.InsertMessage();
                    }
                    reset();
                }
                else if (txtFirmName.Text == "")
                {
                    MessageBox.Show("Enter firm Name", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFirmName.Focus();
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
                else if (txtGSTNo.Text == "")
                {
                    MessageBox.Show("Enter GSTIN", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtGSTNo.Focus();
                }
                else if (txtBankName.Text == "")
                {
                    MessageBox.Show("Enter Bank Name", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBankName.Focus();
                }
                else if (txtAccountNo.Text == "")
                {
                    MessageBox.Show("Enter Bank Account Number", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAccountNo.Focus();
                }
                else if (txtIFSC.Text == "")
                {
                    MessageBox.Show("Enter Bank IFSC Code", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtIFSC.Focus();
                }
            }
        }
    }
}
