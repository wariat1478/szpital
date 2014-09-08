using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Szpital
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            this.CenterToScreen();
            InitializeComponent();
        }

        private void body_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (DB.Instance.Count("SELECT count(*) FROM konta where nazwa_uzytkownika='" + username.Text + "' AND haslo='" + CalculateSHA1(password.Text, Encoding.Unicode) + "'") == 1)
            {
                List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();
                list = DB.Instance.Select("SELECT * FROM konta WHERE nazwa_uzytkownika='" + username.Text + "'");

                //this.manager.Session = list[0];

                //Form f4 = new Form4(this.manager);
                //f4.WindowState = FormWindowState.Normal;
                //f4.BringToFront();
                //f4.Show();

                //this.Close();
            }
            else
            {
                message.Visible = true;
            }
        }

        private string CalculateSHA1(string text, Encoding enc)
        {
            byte[] buffer = enc.GetBytes(text);
            SHA1CryptoServiceProvider cryptoTransformSHA1 = new SHA1CryptoServiceProvider();
            return BitConverter.ToString(cryptoTransformSHA1.ComputeHash(buffer)).Replace("-", "").ToLower();
        }
    }
}
