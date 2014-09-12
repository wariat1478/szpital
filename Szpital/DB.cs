﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace Szpital
{
    public class DB
    {
        private static DB instance;

        private DB()
        {
            Initialize();
        }

        public static DB Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DB();
                }
                return instance;
            }
        }

        private MySqlConnection conn;

        private string host = "localhost";
        private string database = "szpital";
        private string username = "root";
        private string password = "";

        public Dictionary<string, string> user = new Dictionary<string,string>();

        private void Initialize()
        {
            string connString = "server=" + this.host + ";"
                              + "database=" + this.database + ";"
                              + "uid=" + this.username + ";"
                              + "password=" + this.password + ";"
                              + "Convert Zero Datetime=True;";

            conn = new MySqlConnection(connString);
            conn.Open();
        }

        public bool checkUser(string username, string password)
        {
            string query = string.Format("SELECT count(*) FROM konta WHERE nazwa_uzytkownika='{0}' AND haslo='{1}'", username, password);

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                if (dataReader.GetInt32(0) == 1)
                {
                    dataReader.Close();
                    return true;
                }
            }

            dataReader.Close();
            return false;
        }

        public void setUser(string username)
        {
            string query = string.Format("SELECT * FROM konta WHERE nazwa_uzytkownika='{0}'", username);

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    user.Add(dataReader.GetName(i).ToLower(), dataReader.GetString(i));
                }
            }

            dataReader.Close();
        }

        public bool addEvent(string accountId, string type)
        {
            string query = string.Format("INSERT INTO historia (konto_id, kiedy, typ) VALUES ({0}, NOW(), {1})", accountId, type);

            MySqlCommand cmd = new MySqlCommand(query, conn);
            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }

            return false;
        }

        public List<Dictionary<string, string>> getPatients(string doctorId)
        {
            List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();

            string query = string.Format("SELECT p.* FROM lekarze_pacjenci lp LEFT JOIN pacjenci p ON (lp.pacjent_id=p.id) WHERE lp.lekarz_id={0}", doctorId);

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

            return list;
        }

        public Dictionary<string, string> getPatient(string patientId)
        {
            Dictionary<string, string> row = new Dictionary<string, string>();

            string query = string.Format("SELECT p.*, k.sala, k.rozpoznanie, k.data_przyjecia, k.data_wypisu FROM pacjenci p LEFT JOIN karty k ON (p.id=k.pacjent_id) WHERE p.id={0} order by data_przyjecia desc", patientId);

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                string name, value;
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    name  = dataReader.GetName(i).ToLower();
                    value = "";
                    if (!dataReader.IsDBNull(i))
                    {
                        if (name == "data_przyjecia" || name == "data_wypisu")
                        {
                            value = (dataReader.GetDateTime(i) != DateTime.MinValue) ? dataReader.GetDateTime(i).ToString() : "";
                        }
                        else
                        {
                            value = dataReader.GetString(i);
                        }
                    }
                    row.Add(name, value);
                }
            }

            dataReader.Close();

            return row;
        }

        public Dictionary<string, string> getCard(string patientId)
        {
            Dictionary<string, string> row = new Dictionary<string, string>();

            string query = string.Format("SELECT * FROM karty WHERE pacjent_id={0}", patientId);

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                string name, value;
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    name  = dataReader.GetName(i).ToLower();
                    value = "";
                    if (!dataReader.IsDBNull(i))
                    {
                        if (name == "data_przyjecia" || name == "data_wypisu")
                        {
                            value = (dataReader.GetDateTime(i) != DateTime.MinValue) ? dataReader.GetDateTime(i).ToString() : "";
                        }
                        else
                        {
                            value = dataReader.GetString(i);
                        }
                    }
                    row.Add(name, value);
                }
            }

            dataReader.Close();

            return row;
        }

        public bool saveCard(string room, string recognition, string date_in, string date_out, string cardId)
        {
            string query = string.Format("UPDATE karty SET sala='{0}', rozpoznanie='{1}', data_przyjecia='{2}', data_wypisu='{3}' WHERE id={4}", room, recognition, date_in, date_out, cardId);

            MySqlCommand cmd = new MySqlCommand(query, conn);
            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }

            return false;
        }

        public List<Dictionary<string, string>> getTreatment(string cardId)
        {
            List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();

            string query = string.Format("SELECT * FROM leczenie WHERE karta_id={0}", cardId);

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

            return list;
        }


        /*public List<Dictionary<string, string>> Select(string query)
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

        public int Count(string table, string[] conditions)
        {
            int count = 0;
            if (this.OpenConnection() == true)
            {
                string where = conditions.Length > 0 ? "WHERE " + string.Join(" AND ", conditions): "";
                string query = string.Format("SELECT count(*) FROM {0} {1}", table, where);
                MySqlCommand cmd = new MySqlCommand(query, conn);
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

        public bool Insert(string table, string[] fields, string[] values)
        {
            string query;

            if (fields.Length != values.Length)
                return false;

            for (int i = 0; i < fields.Length; i++)
            {
                fields[i] = "`" + fields[i] + "`";
            }
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = "'" + values[i] + "'";
            }

            query = "INSERT INTO " + table + " (" + String.Join(", ", fields) + ") VALUES (" + String.Join(", ", values) + ")";

            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                this.CloseConnection();

                return true;
            }

            return false;
        }

        public bool Update(string table, string[] fields, string[] conditions)
        {
            if (this.OpenConnection() == true)
            {
                string where = conditions.Length > 0 ? "WHERE " + string.Join(" AND ", conditions) : "";
                string query = string.Format("UPATE {0} SET {1} {2}", table, String.Join(", ", fields), where);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                this.CloseConnection();

                return true;
            }

            return false;
        }

        public bool Delete(string table, string[] conditions)
        {
            if (this.OpenConnection() == true)
            {
                string where = conditions.Length > 0 ? "WHERE " + string.Join(" AND ", conditions) : "";
                string query = string.Format("DELETE FROM {0} {1}", table, where);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                this.CloseConnection();

                return true;
            }

            return false;
        }*/
    }
}
