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

        private void header_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (DB.Instance.checkUser(username.Text, CalculateSHA1(password.Text, Encoding.Unicode)))
            {
                DB.Instance.setUser(username.Text);
                DB.Instance.addEvent(DB.Instance.user["id"], "1");

                /*List<Dictionary<string, string>> list = DB.Instance.getPatients(DB.Instance.user["lekarz_id"]);

                string imie, nazwisko;
                for (int i = 0; i < list.Count; i++)
                {
                    imie = list[i]["imie"];
                    nazwisko = list[i]["nazwisko"];
                }*/

                Form f2 = new Form2();
                f2.WindowState = FormWindowState.Normal;
                f2.BringToFront();
                f2.Show();

                this.Close();
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
