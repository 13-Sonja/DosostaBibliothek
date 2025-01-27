using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DosostaApp
{
    public partial class KdBasisseite : Form
    {
        public KdBasisseite()
        {
            InitializeComponent();
        }
        private void LogoutButton_click(object sender, EventArgs e)
        {
            var confirmLogout = MessageBox.Show("Möchten Sie sich wirklich abmelden?", "Abmelden", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmLogout == DialogResult.Yes)
            {
                this.Hide();
                Startseite startForm = new Startseite();
                startForm.Show();
            }
        }
        public class Benutzersession
        {
            public static int KundenID { get; set; }
            public static string Username { get; set; }

        }
        private void ProfilButton_click(object sender, EventArgs e)
        {
            Profilinformation();
        }
        private void Profilinformation()
        {
            string loggedInUsername = Benutzersession.Username;
            string query = "SELECT Vorname, Nachname, Email FROM Kunden WHERE Username = @Username";

            using (SqlConnection connection = new SqlConnection("YourConnectionStringHere"))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", loggedInUsername);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        foreach (Control control in groupBox1.Controls)
                        {
                            if (control is Label)
                            {
                                control.Dispose();
                            }
                        }
                        string vorname = reader["Vorname"].ToString();
                        string nachname = reader["Nachname"].ToString();
                        string email = reader["Email"].ToString();
                        Label lblVorname = new Label
                        {
                            Text = "Nachname: " + reader["Nachname"].ToString(),
                            Location = new Point(10, 70),
                            Size = new Size(120, 25)
                        };
                        Label lblNachname = new Label
                        {
                            Text = "Nachname: " + reader["Nachname"].ToString(),
                            Location = new Point(20, 100),
                            Size = new Size(220, 25)
                        };
                        Label lblEmail = new Label
                        {
                            Text = "E-Mail: " + reader["Email"].ToString(),
                            Location = new Point(20, 140),
                            Size = new Size(320, 25)
                        };
                        Button btnVorname = new Button
                        {
                            Text = "Ändern?",
                            Location = new Point(240, 30),
                            Size = new Size(80, 25)
                        };
                        btnVorname.Click += (sender, e) => EditProfileField("Vorname", loggedInUsername);

                        Button btnNachname = new Button
                        {
                            Text = "Ändern?",
                            Location = new Point(240, 70),
                            Size = new Size(80, 25)
                        };
                        btnNachname.Click += (sender, e) => EditProfileField("Nachname", loggedInUsername);

                        Button btnEmail = new Button
                        {
                            Text = "Ändern?",
                            Location = new Point(240, 110),
                            Size = new Size(80, 25)
                        };
                        btnEmail.Click += (sender, e) => EditProfileField("Email", loggedInUsername);
                        groupBox1.Controls.Add(lblVorname);
                        groupBox1.Controls.Add(lblNachname);
                        groupBox1.Controls.Add(lblEmail);
                        groupBox1.Controls.Add(btnVorname);
                        groupBox1.Controls.Add(btnNachname);
                        groupBox1.Controls.Add(btnEmail);
                    }
                    else
                    {
                        MessageBox.Show("Benutzerdaten konnten nicht gefunden werden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim Abrufen der Benutzerdaten: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            void EditProfileField(string field, string loggedInUsername)
            {

                string newValue = Microsoft.VisualBasic.Interaction.InputBox("Bitte geben Sie den neuen Wert für " + field + " ein:", "Profil bearbeiten", "");
                if (newValue != "")
                {
                    string query = "UPDATE Kunden SET " + field + " = @newValue WHERE Username = @Username";
                    using (SqlConnection connection = new SqlConnection("YourConnectionStringHere"))
                    {
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@newValue", newValue);
                        command.Parameters.AddWithValue("@Username", loggedInUsername);
                        try
                        {
                            connection.Open();
                            int affectedRows = command.ExecuteNonQuery();
                            if (affectedRows > 0)
                            {
                                MessageBox.Show("Das Feld " + field + " wurde erfolgreich aktualisiert.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Profilinformation();
                            }
                            else
                            {
                                MessageBox.Show("Das Feld " + field + " konnte nicht aktualisiert werden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Fehler beim Aktualisieren des Feldes " + field + ": " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        private void MeineBücherButton_click(object sender, EventArgs e)
        {
            MeineBücher_Bücher();
        }
        private void MeineBücher_Bücher()
        {
            int kundenID = Benutzersession.KundenID;
            string query = "SELECT b.Titel, b.Autor, v.Verleihdatum, v.Rückgabedatum FROM Verleih v JOIN Buecher b ON v.BuchID = b.BuchID WHERE v.KundenID =@KundenID AND v.Status = 'ausgeliehen'";

            using (SqlConnection connection = new SqlConnection("YourConnectionStringHere"))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@KundenID", kundenID);

                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    Bücherliste.Items.Clear();

                    while (reader.Read())
                    {
                        string titel = reader["Titel"].ToString();
                        string autor = reader["Autor"].ToString();
                        
                        DateTime verleihdatum = Convert.ToDateTime(reader["Verleihdatum"]);
                        DateTime rückgabedatum = Convert.ToDateTime(reader["Rückgabedatum"]);
                        TimeSpan verbleibendeTage = rückgabedatum.Date - DateTime.Today;
                        
                        int tageBisRückgabe = verbleibendeTage.Days;

                        string statusText = "";
                        if (tageBisRückgabe >7 && tageBisRückgabe <= 14)
                        {
                            statusText = " - [Bald fällig!]";
                        }
                        else if (tageBisRückgabe > 0 && tageBisRückgabe <= 7)
                        {
                            statusText = " - [Dringend!]";
                        }
                        else if (tageBisRückgabe == 0)
                        {
                            statusText = "- [Rückgabe heute!]";
                        }
                        else if (tageBisRückgabe < 0)
                        {
                            statusText = "- [Verspätet!]";
                        }
                        else
                        {
                            statusText = "Rückgabe in " + tageBisRückgabe + " Tagen";
                        }

                        string buchInfo = $"Titel: {titel}, Autor: {autor}, " +
                                   $"Verliehen am: {verleihdatum:dd.MM.yyyy}, " +
                                   $"Rückgabe: {rückgabedatum:dd.MM.yyyy} {statusText}";
                        Bücherliste.Items.Add(buchInfo);  
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim Abrufen der Daten: " + ex.Message);
                }
            }
        }
    }
}
