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
            friend.Text = "Rozmowa z: Lukasz";
            this.manager = manager;
            userSender = this.manager.Session["first_name"];
            id = takeLast();
        }

        public int takeLast()
        {
            int number=0;
            List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();
            
            list = this.manager.DB.Select("SELECT end FROM `chatlast` WHERE userSender='"+userSender+"' and userReceiver='Lukasz' order by end desc limit 1");
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
                this.manager.DB.Insert("chat", new string[] { "userSender", "userReceiver", "content" }, new string[] { userSender, "Lukasz", txtChat.Text });
                txtChat.Text = String.Empty;
            }
        }


        public static void AppendText(RichTextBox box, string text, Color color, HorizontalAlignment alignment)
            {
                box.SelectionStart = box.TextLength;
                box.SelectionLength = 0;

                box.SelectionColor = color;
                box.SelectionAlignment = alignment;
                box.AppendText(text);
                box.SelectionColor = box.ForeColor;
            }
        




        
        private void timer1_Tick(object sender, EventArgs e)
        {
            string tempt="";
            string data = "";
            int number = 0;
           
            List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();

            list = this.manager.DB.Select("SELECT id FROM `chat` WHERE id>" + Convert.ToString(id) + " and userSender='" + userSender + "' and userReceiver='Lukasz' limit 1");
            number = list.Count;
            if (number > 0)
            {
                foreach (var entry in list[number - 1].Values)
                    id = Convert.ToInt32(entry);

                list = this.manager.DB.Select("SELECT content FROM `chat` WHERE userSender='" + userSender + "' and userReceiver='Lukasz' and id=" + Convert.ToString(id));
                number = list.Count;
                foreach (var entry in list[number - 1].Values)
                    tempt = entry;

                list = this.manager.DB.Select("SELECT data FROM `chat` WHERE userSender='" + userSender + "' and userReceiver='Lukasz' and id=" + Convert.ToString(id));
                number = list.Count;
                foreach (var entry in list[number - 1].Values)
                    data = entry;

                AppendText(history, data, Color.Gray, HorizontalAlignment.Right);
                history.AppendText(Environment.NewLine);
                AppendText(history, userSender + ": ", Color.FromArgb(0x79c7fc), HorizontalAlignment.Left);
                AppendText(history, tempt, Color.FromArgb(0x494c4f), HorizontalAlignment.Left);
                history.AppendText(Environment.NewLine);
            }

            list = this.manager.DB.Select("SELECT id FROM `chat` WHERE id>" + Convert.ToString(id) + " and userSender='Lukasz' and userReceiver='"+userSender+"' limit 1");
            number = list.Count;
            if (number > 0)
            {
                foreach (var entry in list[number - 1].Values)
                    id = Convert.ToInt32(entry);

                list = this.manager.DB.Select("SELECT content FROM `chat` WHERE userSender='Lukasz' and userReceiver='" + userSender + "' and id=" + Convert.ToString(id));
                number = list.Count;
                foreach (var entry in list[number - 1].Values)
                    tempt = entry;

                list = this.manager.DB.Select("SELECT data FROM `chat` WHERE userSender='Lukasz' and userReceiver='" + userSender + "' and id=" + Convert.ToString(id));
                number = list.Count;
                foreach (var entry in list[number - 1].Values)
                    data = entry;

                AppendText(history, data, Color.Gray, HorizontalAlignment.Right);
                history.AppendText(Environment.NewLine);
                AppendText(history, "Lukasz: ", Color.FromArgb(0x0097fc), HorizontalAlignment.Left);
                AppendText(history, tempt, Color.FromArgb(0x00000), HorizontalAlignment.Left);
                history.AppendText(Environment.NewLine);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.manager.DB.Insert("chatlast", new string[] { "end", "userSender", "userReceiver" }, new string[] { Convert.ToString(id), userSender, "Lukasz" });
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

      