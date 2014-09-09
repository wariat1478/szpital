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

namespace Szpital
{
    public partial class Form2 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form2()
        {
            //this.CenterToScreen();
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

        private void break_button_Click(object sender, EventArgs e)
        {
            break_button.Visible = false;
            DateTime Now = DateTime.Now;
            string NowMySql = Now.ToString("yyyy-MM-dd HH:mm:ss");
            //DB.Instance.Insert("historia", new string[] { "konto_id", "kiedy", "typ" }, new string[] { "1", NowMySql, "2" });
            endbreak_button.Visible = true;
        }

        private void endbreak_button_Click(object sender, EventArgs e)
        {
            endbreak_button.Visible = false;
            DateTime Now = DateTime.Now;
            string NowMySql = Now.ToString("yyyy-MM-dd HH:mm:ss");
            //DB.Instance.Insert("historia", new string[] { "konto_id", "kiedy", "typ" }, new string[] { "1", NowMySql, "1" });
            break_button.Visible = true;
        }

        private void end_button_Click(object sender, EventArgs e)
        {
            DialogResult wybor = new DialogResult();
            wybor = MessageBox.Show("Czy na pewno chcesz zakończyć?", "Zakończenie programu", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (wybor == DialogResult.Yes)
            {
                DateTime Now = DateTime.Now;
                string NowMySql = Now.ToString("yyyy-MM-dd HH:mm:ss");
                //DB.Instance.Insert("historia", new string[] { "konto_id", "kiedy", "typ" }, new string[] { "1", NowMySql, "0" });
                Application.Exit();
                //wylogowanie
            }
            else
            {
                //powrot
            }
        }
    }
}
