using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DosostaApp.DosostaDB
{
    internal class Datenbank
    {
        private SQLiteConnection connection;
        private SQLiteCommand command;
        private SQLiteDataReader reader;

        private SQLiteConnection ConnectDB()
            //TO DO relativen Pfad benutzen
        {            
            string curPath = System.Environment.CurrentDirectory;
            //string dbPath = "..\\..\\..\\DosostaDB\\Datenbank.db";
            string connectionString = $"Data Source={"C:\\Users\\ruth-\\Coding\\TQ5\\DosostaBibliothek\\DosostaApp\\DosostaDB\\Datenbank.db"};Version=3;";
            connection = new SQLiteConnection(connectionString);
            return connection;
        }
        /*
        public bool CheckLoginSimple(string vorname, string nachname, string passwort)
        {
            bool loginSuccessful = false;
            string query = "SELECT COUNT(*) FROM User WHERE passwort = @passwort;";
            using (SQLiteConnection connection = ConnectDB())
                try
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@passwort", passwort);

                        command.Parameters.Add("@passwort", DbType.String);
                        command.Parameters["@passwort"].Value = passwort;

                        command.Parameters.Add("@vorname", DbType.String);
                        command.Parameters["@vorname"].Value = vorname;

                        command.Parameters.Add("@nachname", DbType.String);
                        command.Parameters["@nachname"].Value = nachname;
                        var count = command.ExecuteScalar();
                        Console.WriteLine(count);
                        //using var reader = command.ExecuteReader();
                        if (count != null)
                        {
                            MessageBox.Show(count.ToString());
                            loginSuccessful = true;
                        }
                        else
                        {
                            MessageBox.Show("Benutzerdaten konnten nicht gefunden werden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            loginSuccessful = false;
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
         */
        public (bool, string, int) CheckLogin(string vorname, string nachname, string passwort)
        {
            bool loginSuccessful = false;
            int id = 0;
            string status = "";

            using (SQLiteConnection connection = ConnectDB())
                try
                    {
                        connection.Open();
                        string query = "SELECT UserID, status FROM User WHERE passwort = @passwort AND vorname = @vorname AND nachname = @nachname;";
                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@passwort", passwort);
                            command.Parameters.AddWithValue("@vorname", vorname);
                            command.Parameters.AddWithValue("@nachname", nachname);

                        SQLiteDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            id = Convert.ToInt32((reader["UserID"].ToString()));
                            status = reader["status"].ToString();
                            loginSuccessful = true;
                            //MessageBox.Show($"{id} {status}");
                        }
                            else
                            {
                                MessageBox.Show("Benutzerdaten konnten nicht gefunden werden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    return (loginSuccessful, status, id);
                }

        public void BenutzerHinzufügen(string vorname, string nachname, string passwort, string email, string geburtsdatum)
        {
            using (SQLiteConnection connection = ConnectDB())
            try
            { 
                connection.Open();
                string query = "INSERT INTO User (vorname, nachname, email, passwort, status) VALUES (@vorname, @nachname, @email, @passwort, @status);";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@vorname", vorname);
                    command.Parameters.AddWithValue("@nachname", nachname);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@passwort", passwort);
                    command.Parameters.AddWithValue("@status", "Kunde");

                    command.ExecuteNonQuery();
                }
            MessageBox.Show($"Kunde erfolgreich hinzugefügt.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Hinzufügen des Kunden: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
