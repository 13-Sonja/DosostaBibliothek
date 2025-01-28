using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;

namespace DosostaApp.DosostaDB
{
    internal class Datenbank
    {
        private SQLiteConnection connection;
        private SQLiteCommand command;
        private SQLiteDataReader reader;
        public Datenbank()
        {
            string curPath = System.Environment.CurrentDirectory;
            string dbPath = "..\\..\\..\\DosostaDB\\Datenbank.db";
            string connectionString = $"Data Source={"C:\\Users\\ruth-\\Coding\\TQ5\\DosostaBibliothek\\DosostaApp\\DosostaDB\\Datenbank.db"};Version=3;";
            //"C:\\Users\\ruth-\\Coding\\TQ5\\DosostaBibliothek\\DosostaApp\\DosostaDB\\Datenbank.db"
            connection = new SQLiteConnection(connectionString);
            command = connection.CreateCommand();
        }

        public bool CheckLogin(string passwort)
        {
            bool loginSuccessful = false;

            try
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM User WHERE passwort = @passwort;";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    //command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@passwort", passwort);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        loginSuccessful = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Login: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            return loginSuccessful;
        }
    }
}
