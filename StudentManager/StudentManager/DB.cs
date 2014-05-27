using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace StudentManager
{
    public class DB
    {
        private MySqlConnection conn;

        private string host = "localhost";
        private string database = "student_manager";
        private string username = "root";
        private string password = "";

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

        public List<Dictionary<string, string>> Select(string query)
        {
            List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Dictionary<string, string> row = new Dictionary<string, string>();
                    for (int i = 0; i < dataReader.FieldCount; i++)
                    {
                        row.Add(dataReader.GetName(i).ToLower(), dataReader.GetString(i));
                    }
                    list.Add(row);
                }

                dataReader.Close();
                this.CloseConnection();

                return list;
            }

            return list;
        }

        public int Count(string query)
        {
            int count = 0;
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query.ToLower(), conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    count = Convert.ToInt32(dataReader["count(*)"]);
                }

                dataReader.Close();
                this.CloseConnection();
            }

            return count;
        }
    }
}
