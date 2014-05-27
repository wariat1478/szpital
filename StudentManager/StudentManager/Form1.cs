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
using System.Security.Cryptography;

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

        private void login_Click(object sender, EventArgs e)
        {
            if (this.DB.Count("select count(*) FROM users where username='" + username.Text + "' AND password='" + CalculateSHA1(password.Text, Encoding.Unicode) + "'") == 1)
            {
                MessageBox.Show("Zalogowany");
            }
        }

        public static string CalculateSHA1(string text, Encoding enc)
        {
            byte[] buffer = enc.GetBytes(text);
            SHA1CryptoServiceProvider cryptoTransformSHA1 = new SHA1CryptoServiceProvider();
            return BitConverter.ToString(cryptoTransformSHA1.ComputeHash(buffer)).Replace("-", "");
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

        public void Insert(string table, string[] fields, string[] values)
        {
            string query;

            if (fields.Length != values.Length)
                return;

            for (int i = 0; i < fields.Length; i++)
            {
                fields[i] = "`" + fields[i] + "`";
            }
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = "'" + values[i] + "'";
            }

            query = "INSERT INTO " + table + " (" + String.Join(", ", fields) + ") VALUES (" + String.Join(", ", values) + ")";

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

        public int Count(string query)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query.ToLower(), conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    return Convert.ToInt32(dataReader["count(*)"]);
                }

                dataReader.Close();
                this.CloseConnection();
            }

            return 0;
        }
    }
}
