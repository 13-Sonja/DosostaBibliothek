using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DosostaApp.DosostaDB;

namespace DosostaApp
{


    public partial class MaUserverwaltungsseite : Form
    {
        Datenbank dosostaDB = new();
        public MaUserverwaltungsseite()
        {
            InitializeComponent();
            idSuchenTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKey);
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            vornameTextbox.Text = "";
            nachnameTextbox.Text = "";
            emailTextbox.Text = "";
            statusComboBox.Text = "";
        }
        private void CheckEnterKey(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)

            {
                TextBox senderObj = (TextBox)sender;
                string result = senderObj.Text;
                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Keine Eingabe erfolgt!", "Meldung", MessageBoxButtons.OK);
                    senderObj.Text = "";
                }
                else
                {
                    string query = "SELECT vorname, nachname, email, status FROM User WHERE UserID = @userID;";
                    using (SQLiteConnection connection = dosostaDB.ConnectDB())
                    try
                    {
                        connection.Open();
                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@userID", result);
                            SQLiteDataReader reader = command.ExecuteReader();
                            if (reader.Read())
                            {
                                vornameTextbox.Text = reader["vorname"].ToString();
                                nachnameTextbox.Text = reader["nachname"].ToString();
                                emailTextbox.Text = reader["email"].ToString();
                                statusComboBox.Text = reader["status"].ToString();

                                //MessageBox.Show($"{vorname}, {status}");
                            }
                            else
                            {
                                MessageBox.Show("Benutzerdaten konnten nicht gefunden werden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                vornameTextbox.Text = "";
                                nachnameTextbox.Text = "";
                                emailTextbox.Text = "";
                                statusComboBox.Text = "";
                                }
                            reader.Close();
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
                    }
                }
            }
        private void Ändern_button_Click(object sender, EventArgs e)
        {
            string vornameUser = vornameTextbox.Text;
            string nachnameUser = nachnameTextbox.Text;
            string EmailUser = emailTextbox.Text;
            string statusUser = statusComboBox.Text;

            using (SQLiteConnection connection = dosostaDB.ConnectDB())
                try
                {
                    connection.Open();
                    //change to edit user where!
                    string query = "UPDATE User SET vorname = @vorname, nachname = @nachname, email = @email, status = @status WHERE UserID = @userID";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@userID", idSuchenTextbox.Text);
                        cmd.Parameters.AddWithValue("@vorname", vornameUser);
                        cmd.Parameters.AddWithValue("@nachname", nachnameUser);
                        cmd.Parameters.AddWithValue("@email", EmailUser);
                        cmd.Parameters.AddWithValue("@status", statusUser);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Nutzerdaten erfolgreich geändert.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error :" + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
        }
        private void NutzerListe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kein Anschluss unter dieser Nummer.", "Nope", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void zurückButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }

}
