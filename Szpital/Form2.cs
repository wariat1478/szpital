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

            /*TextBox textBox1 = new TextBox();
            textBox1.Location = new Point(69, 120);
            textBox1.Text = "I am a TextBox5";
            textBox1.Size = new Size(200, 30);

            CheckBox checkBox1 = new CheckBox();
            checkBox1.Location = new Point(69, 120);
            checkBox1.Text = "Check Me";
            checkBox1.Size = new Size(200, 30);

            patients_panel.Controls.Add(textBox1);
            patients_panel.Controls.Add(checkBox1);

            Controls.Add(patients_panel);*/
        }

        private void showPatients()
        {
            for (int i = 0; i < 5; i++)
            {
                Panel panel = new Panel();
                panel.Parent = patients_panel;
                panel.Dock = DockStyle.Top;

                TextBox textBox1 = new TextBox();
                textBox1.Parent = panel;
                textBox1.Text = "Dupa";
                textBox1.Dock = DockStyle.Top;
            }
        }
    }
}
