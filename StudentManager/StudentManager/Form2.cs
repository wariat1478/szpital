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

namespace StudentManager
{
    public partial class Form2 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private Manager manager;
        
        public Form2(Manager manager)
        {
            InitializeComponent();

            this.manager = manager;

            name.Text = this.manager.Session["first_name"] + " " + this.manager.Session["last_name"];
            if (this.manager.Session["avatar"].Length == 0)
            {
                avatar.Image = StudentManager.Properties.Resources.avatar;
            }

            updateStatus();

            List<Dictionary<string, string>> friends = new List<Dictionary<string, string>>();
            friends = this.manager.DB.Select("select * from friends f left join users u on f.friend=u.user_id where f.user=" + this.manager.Session["user_id"]);

            Label firendName = new Label();
            for (int i = 0; i < friends.Count; i++)
            {
                firendName = new Label();
                firendName.Name = "friend" + friends[i]["friend_id"];
                firendName.Text = friends[i]["first_name"] + " " + friends[i]["last_name"];
                firendName.Parent = flowLayoutPanel1;
            }
        }

        private void Form2_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void setActive_Click(object sender, EventArgs e)
        {
            this.manager.DB.Update("update users set status=1 where user_id=" + Convert.ToInt32(this.manager.Session["user_id"]));
            this.manager.Session["status"] = "1";
            updateStatus();
        }

        private void setAway_Click(object sender, EventArgs e)
        {
            this.manager.DB.Update("update users set status=2 where user_id=" + Convert.ToInt32(this.manager.Session["user_id"]));
            this.manager.Session["status"] = "2";
            updateStatus();
        }

        private void setBusy_Click(object sender, EventArgs e)
        {
            this.manager.DB.Update("update users set status=3 where user_id=" + Convert.ToInt32(this.manager.Session["user_id"]));
            this.manager.Session["status"] = "3";
            updateStatus();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.manager.Session = new Dictionary<string, string>();
            this.Close();

            Form f1 = new Form1(this.manager);
            f1.Show();
        }

        private void updateStatus()
        {
            switch (this.manager.Session["status"])
            {
                case "1":
                    statusImage.Image = StudentManager.Properties.Resources.active;
                    status.Text = "Dostępny";
                    break;

                case "2":
                    statusImage.Image = StudentManager.Properties.Resources.away;
                    status.Text = "Nieobecny";
                    break;

                case "3":
                    statusImage.Image = StudentManager.Properties.Resources.busy;
                    status.Text = "Zajęty";
                    break;
            }

            changeStatus.Location = new Point(status.Width + 96, 85);
            select.Visible = false;
        }

        private void changeStatus_Click(object sender, EventArgs e)
        {
            select.Visible = true;
        }
    }
}
