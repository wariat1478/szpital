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
    public partial class Form3 : Form
    {
        private Manager manager;

        public Form3(Manager manager)
        {
            InitializeComponent();
            this.manager = manager;
        }

        private void message_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox txtChat = (TextBox)sender;

            if ((txtChat.Lines.Length > 1) && (e.KeyCode == Keys.Enter))
            {
                this.manager.DB.Insert("chat", new string[] { "userSender", "userReceiver", "content" }, new string[] { Convert.ToString(this.manager.Session), "root", txtChat.Text });
                txtChat.Text = String.Empty;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();
            list =this.manager.DB.Select("SELECT content FROM `chat` WHERE userReceiver='root'");
            history.Text = history.Text + "\n" + "root: "+list[0];
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}

      