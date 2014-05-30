using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class Form5 : Form
    {
        private Manager Manager;

        public Form5(Manager manager)
        {
            InitializeComponent();

            this.Manager = manager;

            readFriends();
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

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.closeActive));
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.close));
        }

        private void maximizeButton_MouseEnter(object sender, EventArgs e)
        {
            this.maximizeButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.maxmizeActive));
        }

        private void maximizeButton_MouseLeave(object sender, EventArgs e)
        {
            this.maximizeButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.maxmize));
        }

        private void minimizeButton_MouseEnter(object sender, EventArgs e)
        {
            this.minimizeButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.minimizeActive));
        }

        private void minimizeButton_MouseLeave(object sender, EventArgs e)
        {
            this.minimizeButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.minimize));
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            select.Visible = select.Visible == false;
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            this.Manager.DB.Update("update users set status=1 where user_id=" + Convert.ToInt32(this.Manager.Session["user_id"]));
            this.Manager.Session["status"] = "1";
            updateStatus();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            this.Manager.DB.Update("update users set status=2 where user_id=" + Convert.ToInt32(this.Manager.Session["user_id"]));
            this.Manager.Session["status"] = "2";
            updateStatus();
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            this.Manager.DB.Update("update users set status=3 where user_id=" + Convert.ToInt32(this.Manager.Session["user_id"]));
            this.Manager.Session["status"] = "3";
            updateStatus();
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            //this.Manager.logout();
            this.Close();
        }

        private void updateStatus()
        {
            switch (this.Manager.Session["status"])
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

            select.Visible = false;
        }

        private void readFriends()
        {
            List<Dictionary<string, string>> friends = new List<Dictionary<string, string>>();
            friends = this.Manager.DB.Select("select * from friends f left join users u on f.friend=u.user_id where f.user=" + "1");//this.Manager.Session["user_id"]);

            Panel friendPanel;
            Label friendName;
            Label friendStatus;
            PictureBox friendAvatar;
            PictureBox friendStatusIm;

            for (int i = 0; i < friends.Count; i++)
            {
                friendPanel = new Panel();
                friendPanel.Name = "friendPanel" + friends[i]["friend_id"];
                friendPanel.Parent = friendsContainer;
                friendPanel.Height = 45;
                friendPanel.Dock = DockStyle.Top;

                friendAvatar = new PictureBox();
                friendAvatar.Name = "friendAvatar" + friends[i]["friend_id"];
                friendAvatar.Parent = friendPanel;
                friendAvatar.BackColor = Color.Black;
                friendAvatar.Size = new Size(35, 35);
                friendAvatar.Location = new Point(20, 5);

                friendName = new Label();
                friendName.Name = "friendName" + friends[i]["friend_id"];
                friendName.Parent = friendPanel;
                friendName.Text = friends[i]["first_name"] + " " + friends[i]["last_name"];
                friendName.Location = new Point(62, 8);
                friendName.Font = new Font("Arial", 9.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
                friendName.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(220)))));
                friendName.Height = 18;

                friendStatusIm = new PictureBox();
                friendStatusIm.Name = "friendStatusIm" + friends[i]["friend_id"];
                friendStatusIm.Parent = friendPanel;
                friendStatusIm.Location = new Point(67, 28);
                friendStatusIm.Size = new Size(10, 10);

                friendStatus = new Label();
                friendStatus.Name = "friendStatusIm" + friends[i]["friend_id"];
                friendStatus.Parent = friendPanel;
                friendStatus.Location = new Point(82, 26);
                friendStatus.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
                friendStatus.ForeColor = Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));

                switch (friends[i]["status"])
                {
                    case "0":
                        friendStatusIm.Image = StudentManager.Properties.Resources.inactive3;
                        friendStatus.Text = "Niedostępny";
                        break;

                    case "1":
                        friendStatusIm.Image = StudentManager.Properties.Resources.active3;
                        friendStatus.Text = "Dostępny";
                        break;

                    case "2":
                        friendStatusIm.Image = StudentManager.Properties.Resources.away3;
                        friendStatus.Text = "Nieobecny";
                        break;

                    case "3":
                        friendStatusIm.Image = StudentManager.Properties.Resources.busy3;
                        friendStatus.Text = "Zajęty";
                        break;
                }
            }
        }
    }
}
