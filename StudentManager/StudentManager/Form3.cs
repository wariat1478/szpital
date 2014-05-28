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
        int id = 1;
        string userSender = "";
        

        public Form3(Manager manager)
        {
            InitializeComponent();
            this.manager = manager;
            foreach (var entry in this.manager.Session.Values)
                userSender = entry;

            id = takeLast();
        }

        public int takeLast()
        {
            int number=0;
            List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();
            
            list = this.manager.DB.Select("SELECT end FROM `chatlast` WHERE userSender='root' and userReceiver='root' order by end desc limit 1");
            number = list.Count;
            if (number > 0)
            {
                foreach (var entry in list[number - 1].Values)
                    id = Convert.ToInt32(entry);
            }
            else
            {
                id = 1;
            }
            return id;
        }


        private void message_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox txtChat = (TextBox)sender;
            
            if ((txtChat.Lines.Length > 1) && (e.KeyCode == Keys.Enter))
            {
                this.manager.DB.Insert("chat", new string[] { "userSender", "userReceiver", "content" }, new string[] { userSender, "root", txtChat.Text });
                txtChat.Text = String.Empty;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string tempt="";
            int number = 0;
           
            List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();

            list = this.manager.DB.Select("SELECT id FROM `chat` WHERE id>"+Convert.ToString(id)+" and userReceiver='root' limit 1");
            number = list.Count;
            if (number > 0)
            {
                foreach (var entry in list[number - 1].Values)
                    id = Convert.ToInt32(entry);

                list = this.manager.DB.Select("SELECT content FROM `chat` WHERE userReceiver='root' and id=" + Convert.ToString(id));
                number = list.Count;
                foreach (var entry in list[number - 1].Values)
                    tempt = entry;

                history.AppendText("root: " + tempt);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.manager.DB.Insert("chatlast", new string[] { "end", "userSender", "userReceiver" }, new string[] { Convert.ToString(id), "root", "root"  });
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

      