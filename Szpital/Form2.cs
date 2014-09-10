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
        string id = "1";

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
            patients_panel.Controls.Clear();
            List<Dictionary<string, string>> list = DB.Instance.getPatients(DB.Instance.user["lekarz_id"]);
            for (int i = 0; i < list.Count; i++)
            {
                Button patient = new Button();
                patient.Parent = patients_panel;
                patient.Text = list[i]["imie"] + " " + list[i]["nazwisko"];
                patient.Dock = DockStyle.Top;
                patient.Size = new System.Drawing.Size(100, 50);
                patient.Tag  = list[i]["id"];

                patient.Click += (s, e) =>
                {
                    Button button = (Button)s;
                    showPatient((string) button.Tag);
                };
            }
        }

        private void showPatient(string patientId)
        {
            Dictionary<string, string> patient = DB.Instance.getPatient(patientId);
            patientName.Text = "Dane pacjenta: " + Environment.NewLine + Environment.NewLine + patient["imie"] + " " + patient["nazwisko"] + Environment.NewLine + "Nr Ubezpieczenia: " + patient["nr_ubezpieczenia"] + Environment.NewLine + "Telefon kontaktowy: " + patient["telefon_kontaktowy"] + Environment.NewLine + "Pesel: " + patient["pesel"];
            patientCard.Text = "Karta pacjenta: " + Environment.NewLine + Environment.NewLine + "Sala: " + patient["sala"] + Environment.NewLine + "Rozpoznanie: " + patient["rozpoznanie"] + Environment.NewLine + "Data przyjęcia: " + patient["data_przyjecia"] + Environment.NewLine + "Data wypisu: " + patient["data_wypisu"];

            editCard.Tag = patient["id"];
            editCard.Visible = true;
        }

        private void patientCard_DoubleClick(object sender, EventArgs e)
        {
            DialogResult wybor = new DialogResult();
            wybor = MessageBox.Show("Czy chcesz edytować dane?", "Edycja", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (wybor == DialogResult.Yes)
            {
                //Form f3 = new Form3(id);
                //f3.WindowState = FormWindowState.Normal;
                //f3.BringToFront();
                //f3.Show();
            }
            else
            {
                
            }
        }

        private void editCard_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            showCardForm((string)button.Tag);
        }

        private void showCardForm(string patientId)
        {
            editCardForm.Visible = true;
            Dictionary<string, string> card = DB.Instance.getCard(patientId);

            TextBox data_wypisu = new TextBox();
            data_wypisu.Parent = editCardForm;
            data_wypisu.Dock = DockStyle.Top;
            TextBox data_przyjecia = new TextBox();
            data_przyjecia.Parent = editCardForm;
            data_przyjecia.Dock = DockStyle.Top;
            TextBox rozpoznanie = new TextBox();
            rozpoznanie.Parent = editCardForm;
            rozpoznanie.Dock = DockStyle.Top;
            TextBox sala = new TextBox();
            sala.Parent = editCardForm;
            sala.Dock = DockStyle.Top;
            Label name = new Label();
            name.Parent = editCardForm;
            name.Dock = DockStyle.Top;
            Label pola = new Label();
            pola.Parent = editCardForm;
            pola.Dock = DockStyle.Left;

            pola.Font = new Font("Times New Roma Bold", 9);
            pola.Text = Environment.NewLine + Environment.NewLine + "Sala: " + Environment.NewLine +  "Rozpozanie: " + Environment.NewLine + "Data przyjęcia: " + Environment.NewLine +"Data wypisu: ";

            name.Text = "Edycja karty pacjenta";
            sala.Text = card["sala"];
            rozpoznanie.Text = card["rozpoznanie"];
            data_przyjecia.Text = card["data_przyjecia"];
            data_wypisu.Text = card["data_wypisu"];

            Button save = new Button();
            save.Parent = editCardForm;
            save.Dock = DockStyle.Bottom;
            save.Size = new System.Drawing.Size(100, 50);
            save.Text = "Zapisz";

            save.Click += (s, e) =>
            {
                Button button = (Button)s;
                editCardForm.Visible = false;
                editCardForm.Controls.Clear();
            };

        }
    }
}
