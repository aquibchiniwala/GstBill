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
using System.Net.NetworkInformation;
using Microsoft.Win32;

namespace GSTBill
{
    public partial class Registration : Form
    {
        Connectivity cn = new Connectivity();
        DateTime dt;
        Microsoft.Win32.RegistryKey key;

        public Registration()
        {
            InitializeComponent();
        }

        private void reset()
        {
            dtpDate.Value = DateTime.Today;
            dtpDate.Focus();
        }


        private void MACSEC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Control)
            {
                key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\MicrosofttWindows");
                key.SetValue("CurDate",System.DateTime.Today.ToShortDateString());
                key.SetValue("ExpDate", dtpDate.Text);
                if (Convert.ToDateTime(key.GetValue("CurDate").ToString()) < Convert.ToDateTime(key.GetValue("ExpDate").ToString()))
                    key.SetValue("Flag", "1");
                else
                    key.SetValue("Flag", "0");

                MessageBox.Show("Licensed Renewed upto " + dtpDate.Text + "..Thank You.", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\MicrosofttWindows");
                if (key != null)
                {
                    Registry.CurrentUser.DeleteSubKey(@"SOFTWARE\MicrosofttWindows");
                    MessageBox.Show("License removed..Thank You.", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
            else if (e.KeyCode == Keys.Home)
            {
                reset();
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            dt = DateTime.ParseExact(dtpDate.Text, "dd/MM/yyyy", null);
        }

        private void MACSEC_Load(object sender, EventArgs e)
        {
            dt = DateTime.ParseExact(dtpDate.Text, "dd/MM/yyyy", null);
            key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\MicrosofttWindows");
            if (key != null)
            {
                txtCurrExpDate.Text = key.GetValue("ExpDate").ToString();
            }
        }
    }
}
