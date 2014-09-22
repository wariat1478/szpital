using System;
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
            string query = "SELECT count(*) FROM konta WHERE nazwa_uzytkownika='@username' AND haslo='@password'";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

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
            string query = "SELECT * FROM konta WHERE nazwa_uzytkownika='@username'";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);

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

        public bool isEventAdded(string accountId, string type)
        {
            string query = "SELECT id FROM historia WHERE konto_id=@id AND typ=@type AND DATE_FORMAT(kiedy, '%Y%m%d') = DATE_FORMAT(NOW(), '%Y%m%d')";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", accountId);
            cmd.Parameters.AddWithValue("@type", type);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.HasRows)
            {
                dataReader.Close();
                return true;
            }

            dataReader.Close();
            return false;
        }

        public bool addEvent(string accountId, string type)
        {
            string query = "INSERT INTO historia (konto_id, kiedy, typ) VALUES (@id, NOW(), '@type')";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", accountId);
            cmd.Parameters.AddWithValue("@type", type);

            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }

            return false;
        }

        public List<Dictionary<string, string>> getPatients(string doctorId)
        {
            List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();

            string query = "SELECT p.* FROM lekarze_pacjenci lp LEFT JOIN pacjenci p ON (lp.pacjent_id=p.id) WHERE lp.lekarz_id=@id";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", doctorId);

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

            string query = "SELECT p.*, k.id as karta, k.sala, k.rozpoznanie, k.data_przyjecia, k.data_wypisu FROM pacjenci p LEFT JOIN karty k ON (p.id=k.pacjent_id) WHERE p.id=@id order by data_przyjecia desc";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", patientId);

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

            string query = "SELECT * FROM karty WHERE pacjent_id=@id";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", patientId);

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
            string query = "UPDATE karty SET sala='@room', rozpoznanie='@recognition', data_przyjecia='@dateIn', data_wypisu='@dateOut' WHERE id=@id";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@room", room);
            cmd.Parameters.AddWithValue("@recognition", recognition);
            cmd.Parameters.AddWithValue("@dateIn", date_in);
            cmd.Parameters.AddWithValue("@dateOut", date_out);
            cmd.Parameters.AddWithValue("@id", cardId);

            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }

            return false;
        }


        public bool saveTreatment(string text, string cardId)
        {
            string query = "INSERT INTO leczenie (karta_id, opis, kiedy) VALUES (@id, @desc, now())";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", cardId);
            cmd.Parameters.AddWithValue("@id", text);

            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }

            return false;
        }

        public List<Dictionary<string, string>> getTreatment(string cardId)
        {
            List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();

            string query = "SELECT * FROM leczenie WHERE karta_id=@id";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", cardId);

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

        public string getPatientId(string card)
        {
            string query = "SELECT pacjent_id FROM karty WHERE id=@id";
            string pacjent = "0";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", card);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                pacjent = dataReader.GetString(0);
                dataReader.Close();
            }

            return pacjent;
        }
    }
}
