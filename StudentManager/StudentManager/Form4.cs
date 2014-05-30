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
    public partial class Form4 : Form
    {
        private Manager Manager;

        public Form4(Manager manager)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.BringToFront();

            this.Manager = manager;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void friends_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(this.Manager);
            f5.Show();
        }
    }
}
