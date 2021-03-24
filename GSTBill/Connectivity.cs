using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GSTBill
{
    class Connectivity
    {
        public SqlConnection cn = new SqlConnection(GSTBill.Properties.Settings.Default.Con.ToString());

        public void InsertMessage()
        {
            MessageBox.Show("Record saved successfully", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void DeleteMessage()
        {
            MessageBox.Show("Record deleted successfully", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void UpdateMessage()
        {
            MessageBox.Show("Record updated successfully", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Exit(Form frm)
        {
            DialogResult result = MessageBox.Show("Do you want close this window? ", "Liberty Softwares", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
                frm.Close();
        }
        public void NoVal(object sender, KeyPressEventArgs e)
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
