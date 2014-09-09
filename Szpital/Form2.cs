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
            DB.Instance.addEvent(DB.Instance.user["id"], "2");
            endbreak_button.Visible = true;
        }

        private void endbreak_button_Click(object sender, EventArgs e)
        {
            endbreak_button.Visible = false;
            DB.Instance.addEvent(DB.Instance.user["id"], "3");
            break_button.Visible = true;
        }

        private void end_button_Click(object sender, EventArgs e)
        {
            DialogResult wybor = new DialogResult();
            wybor = MessageBox.Show("Czy na pewno chcesz zakończyć?", "Zakończenie programu", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (wybor == DialogResult.Yes)
            {
                DB.Instance.addEvent(DB.Instance.user["id"], "4");
                Application.Exit();
            }
            else
            {
                //powrot
            }

         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showPatients();
        }

        private void showPatients()
        {
           List<Dictionary<string, string>> list = DB.Instance.getPatients(DB.Instance.user["lekarz_id"]);
           string imie, nazwisko;
           for (int i = 0; i < list.Count; i++)
           {
             imie = list[i]["imie"];
             nazwisko = list[i]["nazwisko"];
             
             Panel panel = new Panel();
             panel.Parent = patients_panel;
             panel.Dock = DockStyle.Top;
             panel.Height = 25;

             Button button1 = new Button();
             TextBox textBox1 = new TextBox();
             button1.Parent = panel;
             button1.Text = imie+" "+nazwisko;
             button1.Dock = DockStyle.Left;
             button1.Size = new System.Drawing.Size(100, 20); 
           }
          
           
        }
    }
}
