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
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using Microsoft.Win32;
using System.Net;
using System.Net.Sockets;

namespace GSTBill
{
    public partial class Login : Form
    {
        Connectivity cn=new Connectivity();
        Microsoft.Win32.RegistryKey key;
        String dtstr;
        int flag = 1;
       
        public Login()
        {
            InitializeComponent();
        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (var stream = client.OpenRead("https://www.freecodecamp.com/the-fastest-web-page-on-the-internet"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public static DateTime GetServerTime()
        {
            //default Windows time server
            const string ntpServer = "time.windows.com";

            // NTP message size - 16 bytes of the digest (RFC 2030)
            var ntpData = new byte[48];

            //Setting the Leap Indicator, Version Number and Mode values
            ntpData[0] = 0x1B; //LI = 0 (no warning), VN = 3 (IPv4 only), Mode = 3 (Client Mode)

            var addresses = Dns.GetHostEntry(ntpServer).AddressList;

            //The UDP port number assigned to NTP is 123
            var ipEndPoint = new IPEndPoint(addresses[0], 123);
            //NTP uses UDP

            using (var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp))
            {
                socket.Connect(ipEndPoint);

                //Stops code hang if NTP is blocked
                socket.ReceiveTimeout = 3000;

                socket.Send(ntpData);
                socket.Receive(ntpData);
                socket.Close();
            }

            //Offset to get to the "Transmit Timestamp" field (time at which the reply 
            //departed the server for the client, in 64-bit timestamp format."
            const byte serverReplyTime = 40;

            //Get the seconds part
            ulong intPart = BitConverter.ToUInt32(ntpData, serverReplyTime);

            //Get the seconds fraction
            ulong fractPart = BitConverter.ToUInt32(ntpData, serverReplyTime + 4);

            //Convert From big-endian to little-endian
            intPart = SwapEndianness(intPart);
            fractPart = SwapEndianness(fractPart);

            var milliseconds = (intPart * 1000) + ((fractPart * 1000) / 0x100000000L);

            //**UTC** time
            var networkDateTime = (new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)).AddMilliseconds((long)milliseconds);

            return networkDateTime.ToLocalTime();
        }

        static uint SwapEndianness(ulong x)
        {
            return (uint)(((x & 0x000000ff) << 24) +
                           ((x & 0x0000ff00) << 8) +
                           ((x & 0x00ff0000) >> 8) +
                           ((x & 0xff000000) >> 24));
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("CheckLogin", cn.cn);
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.AddWithValue("@Username", txtUsername.Text).DbType = DbType.String;
            cmd2.Parameters.AddWithValue("@Password", txtPassword.Text).DbType = DbType.String;
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            if (ds2.Tables[0].Rows.Count > 0)
            {
                this.Hide();
                if (ds2.Tables[0].Rows[0]["LoginID"].ToString() == "1")        //Superuser
                {
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    Registration mac = new Registration();
                    mac.ShowDialog();
                }
                else if (flag==0)
                {
                    MessageBox.Show("Your license has expired..For renewal, please contact Liberty Softwares [8905555755].", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                else
                {
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    this.Hide();
                    Menu menu = new Menu();
                    menu.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Invalid User Type, Username or Password", "Liberty Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }  
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            #region RegistryKeyDateUpdate
            key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\MicrosofttWindows");
            if (key != null)
            {
                key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\MicrosofttWindows");
                if (key.GetValue("Flag").ToString() != "0")
                {
                    if (CheckForInternetConnection() == true)
                    {

                        if (GetServerTime().ToString() != "")
                            dtstr = GetServerTime().ToShortDateString();


                        key.SetValue("CurDate", dtstr);
                        if (Convert.ToDateTime(key.GetValue("CurDate").ToString()) > Convert.ToDateTime(key.GetValue("ExpDate").ToString()))
                        {
                            key.SetValue("Flag", "0");
                            flag = 0;
                        }
                    }

                }
                else
                    flag = 0;
                key.Close();
            }
            #endregion
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
