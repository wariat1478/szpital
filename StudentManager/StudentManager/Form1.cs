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
using MySql.Data.MySqlClient;

namespace StudentManager
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private DB DB;

        public Form1()
        {
            this.CenterToScreen();
            InitializeComponent();

            this.DB = new DB();
        }

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
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

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }

    public class DB
    {
        private MySqlConnection conn;

        private string host      = "localhost";
        private string database  = "student_manager";
        private string username  = "root";
        private string password  = "";

        public DB()
        {
            Initialize();
        }

        private void Initialize()
        {
            string connString = "server=" + this.host + ";"
                              + "database=" + this.database + ";"
                              + "uid=" + this.username + ";"
                              + "password=" + this.password + ";";

            conn = new MySqlConnection(connString);
        }

        private bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException e)
            {
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (MySqlException e)
            {
                return false;
            }
        }

        public void Insert()
        {
            string query = "INSERT INTO users (username) VALUES ('lukaszgolder@hotmail.com')";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                this.CloseConnection();
            }
        }

        public void Update()
        {
        }

        public void Delete()
        {
        }

        public List<string>[] Select()
        {
            List<string>[] list = new List <string>[0];

            return list;
        }

        public int Count()
        {
            return 0;
        }

        public void Backup()
        {
        }

        public void Restore()
        {
        }
    }
}
