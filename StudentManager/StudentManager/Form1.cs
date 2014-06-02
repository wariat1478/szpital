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

namespace StudentManager
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private Manager manager;

        public Form1(Manager manager)
        {
            this.CenterToScreen();
            InitializeComponent();

            this.manager = manager;
        }

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
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

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.closeActive));
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.close));
        }

        private void minimizeButton_MouseEnter(object sender, EventArgs e)
        {
            this.minimizeButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.minimizeActive));
        }

        private void minimizeButton_MouseLeave(object sender, EventArgs e)
        {
            this.minimizeButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.minimize));
        }

        private void login_Click(object sender, EventArgs e)
        {
            _login();
        }

        private void _login()
        {
            if (this.manager.DB.Count("select count(*) FROM users where username='" + username.Text + "' AND password='" + CalculateSHA1(password.Text, Encoding.Unicode) + "'") == 1)
            {
                this.manager.DB.Update("update users set status=1 where username='" + username.Text + "'");

                List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();
                list = this.manager.DB.Select("select * from users where username='" + username.Text + "'");

                this.manager.Session = list[0];

                Form f4 = new Form4(this.manager);
                f4.WindowState = FormWindowState.Normal;
                f4.BringToFront();
                f4.Show();

                this.Close();
            }
        }

        public static string CalculateSHA1(string text, Encoding enc)
        {
            byte[] buffer = enc.GetBytes(text);
            SHA1CryptoServiceProvider cryptoTransformSHA1 = new SHA1CryptoServiceProvider();
            return BitConverter.ToString(cryptoTransformSHA1.ComputeHash(buffer)).Replace("-", "");
        }

        private void username_Enter(object sender, EventArgs e)
        {
            if (username.Text == "Nazwa użytkownika")
            {
                username.Text = "";
                username.ForeColor = Color.White;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Hasło")
            {
                password.Text = "";
                password.PasswordChar = (char) 7;
                password.ForeColor = Color.White;
            }
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "Nazwa użytkownika";
                username.ForeColor = Color.FromArgb(140, 140, 140);
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "Hasło";
                password.PasswordChar = (char) 0;
                password.ForeColor = Color.FromArgb(140, 140, 140);
            }
        }

        private void username_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _login();
            }
        }
    }
}
