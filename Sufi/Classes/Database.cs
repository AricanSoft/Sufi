using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElementiumBrowser.Classes
{
    public class Database
    {

        SQLiteConnection connection;

        public Database()
        {
            var DBlocation = Application.StartupPath + "/Browser.db";
            if (!File.Exists(DBlocation)) File.WriteAllBytes(DBlocation, Properties.Resources.Browser);
            connection = new SQLiteConnection("Data Source=" + DBlocation);
        }

        public void StartConnection()
        {
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public SQLiteCommand CreateCommand()
        {
            SQLiteCommand command = new SQLiteCommand();
            StartConnection();
            command.Connection = connection;
            return command;
        }

        public void DestoryCommand(SQLiteCommand _SQLiteCommand)
        {
            CloseConnection();
            _SQLiteCommand.Dispose();
        }

        public List<Dictionary<string, string>> GetObjects(string sql)
        {

            if (string.IsNullOrEmpty(sql)) return null;
            var cmd = CreateCommand();
            cmd.CommandText = sql;

            SQLiteDataReader reader = cmd.ExecuteReader();

            var objects = new List<Dictionary<string, string>>();
            while (reader.Read())
            {
                var fields = new Dictionary<string, string>();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    string fieldName = reader.GetName(i);
                    string field = "";
                    if (reader.GetFieldType(i).ToString().Contains("64"))
                    {
                        field = !reader.IsDBNull(i) ? reader.GetInt32(i).ToString() : "";
                    }
                    else
                    {
                        field = !reader.IsDBNull(i) ? reader.GetString(i) : "";
                    }
                    fields.Add(fieldName, field);
                }
                objects.Add(fields);
            }

            DestoryCommand(cmd);
            return objects;
        }
        public void ExecuteQuery(string sql)
        {
            if (string.IsNullOrEmpty(sql)) return;
            var cmd = CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            DestoryCommand(cmd);
        }
    }
}
