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

            Panel friendPanel = new Panel();
            Label friendName = new Label();
            PictureBox friendStatusImage = new PictureBox();
            Label friendStatus = new Label();

            for (int i = 0; i < friends.Count; i++)
            {
                friendPanel = new Panel();
                friendPanel.Name = "friendPanel" + friends[i]["friend_id"];
                friendPanel.Parent = friendsContainer;
                friendPanel.Width = friendsContainer.Width;
                friendPanel.Height = 42;

                friendName = new Label();
                friendName.Name = "friendName" + friends[i]["friend_id"];
                friendName.Text = friends[i]["first_name"] + " " + friends[i]["last_name"];
                friendName.Parent = friendPanel;
                friendName.Location = new Point(50, 10);
                friendName.Font = new Font("Arial", 9.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
                friendName.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(220)))));
                friendName.Height = 18;

                friendStatusImage = new PictureBox();
                friendStatusImage.Parent = friendPanel;
                friendStatusImage.Location = new Point(55, 30);
                friendStatusImage.Name = "friendStatusImage" + friends[i]["friend_id"];
                friendStatusImage.Size = new Size(10, 10);

                friendStatus = new Label();
                friendStatus.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
                friendStatus.ForeColor = Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
                friendStatus.Location = new Point(70, 28);
                friendStatus.Name = "friendStatus" + friends[i]["friend_id"];
                friendStatus.Parent = friendPanel;

                switch (friends[i]["status"])
                {
                    case "0":
                        friendStatusImage.Image = StudentManager.Properties.Resources.inactive;
                        friendStatus.Text = "Niedostępny";
                        break;

                    case "1":
                        friendStatusImage.Image = StudentManager.Properties.Resources.active;
                        friendStatus.Text = "Dostępny";
                        break;

                    case "2":
                        friendStatusImage.Image = StudentManager.Properties.Resources.away;
                        friendStatus.Text = "Nieobecny";
                        break;

                    case "3":
                        friendStatusImage.Image = StudentManager.Properties.Resources.busy;
                        friendStatus.Text = "Zajęty";
                        break;
                }
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
