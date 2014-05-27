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
                this.manager.DB.Insert("chat", new string[] { "userSender", "userReceiver", "content" }, new string[] { "root", "root", txtChat.Text});
                txtChat.Text = String.Empty;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            history.Text = "test";
        }
    }
}

      