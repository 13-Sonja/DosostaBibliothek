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
            public static int UserID { get; set; }
            public static string email { get; set; }

        }
        private void ProfilButton_click(object sender, EventArgs e)
        {
            groupBox1.Controls.Clear();
            Profilinformation();
        }
        private void Profilinformation()
        {
            string loggedInEmail = Benutzersession.email;
            string query = "SELECT Vorname, Nachname, Email FROM User WHERE email = @email";

            using (SQLiteConnection connection = new SQLiteConnection("Data Source=C:\\Users\\mytq\\Documents\\GitHub\\DosostaBibliothek\\DosostaApp\\DosostaDB\\Datenbank.db;Version=3;"))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@email", loggedInEmail);

                try
                {
                    connection.Open();
                    SQLiteDataReader reader = command.ExecuteReader();
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
                        int yOffset = 30;

                        Label lblVorname = new Label
                        {
                            Text = "Vorname: " + reader["Vorname"].ToString(),
                            Location = new Point(10, yOffset),
                            Size = new Size(120, 25)
                        };
                        groupBox1.Controls.Add(lblVorname);
                        yOffset += 40;

                        Label lblNachname = new Label
                        {
                            Text = "Nachname: " + reader["Nachname"].ToString(),
                            Location = new Point(20, 100),
                            Size = new Size(220, 25)
                        };
                        groupBox1.Controls.Add(lblVorname);
                        yOffset += 40;

                        Label lblEmail = new Label
                        {
                            Text = "E-Mail: " + reader["Email"].ToString(),
                            Location = new Point(20, 140),
                            Size = new Size(320, 25)
                        };
                        groupBox1.Controls.Add(lblVorname);
                        yOffset += 40;

                        Button btnVorname = new Button
                        {
                            Text = "Ändern?",
                            Location = new Point(240, 30),
                            Size = new Size(80, 25)
                        };
                        btnVorname.Click += (sender, e) => EditProfileField("Vorname", loggedInEmail);
                        yOffset += 40;

                        Button btnNachname = new Button
                        {
                            Text = "Ändern?",
                            Location = new Point(240, 70),
                            Size = new Size(80, 25)
                        };
                        btnNachname.Click += (sender, e) => EditProfileField("Nachname", loggedInEmail);
                        yOffset += 40;

                        Button btnPasswort = new Button
                        {
                            Text = "Ändern?",
                            Location = new Point(240, 110),
                            Size = new Size(80, 25)
                        };
                        btnPasswort.Click += (sender, e) => EditProfileField("Passwort", loggedInEmail);
                        groupBox1.Controls.Add(lblVorname);
                        groupBox1.Controls.Add(lblNachname);
                        groupBox1.Controls.Add(lblEmail);
                        groupBox1.Controls.Add(btnVorname);
                        groupBox1.Controls.Add(btnNachname);
                        groupBox1.Controls.Add(btnPasswort);
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
        }
        private void EditProfileField(string field, string loggedInEmail)
        {
            string newValue = Microsoft.VisualBasic.Interaction.InputBox("Bitte geben Sie den neuen Wert für " + field + " ein:", "Profil bearbeiten", "");

            if (field != "Vorname" && field != "Nachname" && field != "Email")
            {
                throw new ArgumentException("Ungültiges Feld");
            }

            string query = $"UPDATE User SET {field} = @newValue WHERE email = @email";

            using (SQLiteConnection connection = new SQLiteConnection("Data Source=C:\\Users\\mytq\\Documents\\GitHub\\DosostaBibliothek\\DosostaApp\\DosostaDB\\Datenbank.db;Version=3;"))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@newValue", newValue);
                command.Parameters.AddWithValue("@email", loggedInEmail);

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
        private void MeineBücherButton_click(object sender, EventArgs e)
        {
            groupBox1.Controls.Clear();
            MeineBücher_Bücher();
        }
        private void MeineBücher_Bücher()
        {
            int UserID = Benutzersession.UserID;
            string query = "SELECT b.Titel, b.Autor, v.Verleihdatum, v.Rückgabedatum FROM Verleih v JOIN Buecher b ON v.BuchID = b.BuchID WHERE v.UserID = @UserID AND v.Status = 'ausgeliehen'";

            using (SQLiteConnection connection = new SQLiteConnection("Data Source=C:\\Users\\mytq\\Documents\\GitHub\\DosostaBibliothek\\DosostaApp\\DosostaDB\\Datenbank.db;Version=3;"))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", UserID);

                try
                {
                    connection.Open();
                    SQLiteDataReader reader = command.ExecuteReader();
                    ListBox Bücherliste = new ListBox();
                    Bücherliste.Dock = DockStyle.Fill;
                    groupBox1.Controls.Add(Bücherliste);

                    while (reader.Read())
                    {
                        string titel = reader["Titel"].ToString();
                        string autor = reader["Autor"].ToString();

                        DateTime verleihdatum = Convert.ToDateTime(reader["Verleihdatum"]);
                        DateTime rückgabedatum = Convert.ToDateTime(reader["Rückgabedatum"]);
                        TimeSpan verbleibendeTage = rückgabedatum.Date - DateTime.Today;
                        int tageBisRückgabe = (int)verbleibendeTage.TotalDays;

                        string statusText = "";
                        if (tageBisRückgabe > 7 && tageBisRückgabe <= 14)
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
        private void BuchAusleihenButton_click(object sender, EventArgs e)
        {
            groupBox1.Controls.Clear();
            BücherSuchen();
        }
        private void BücherSuchen()
        {
            int yOffset = 20;

            Label lblAutor = new Label { Text = "Autor:", Location = new Point(10, yOffset), Size = new Size(50, 25) };
            groupBox1.Controls.Add(lblAutor);
            TextBox txtAutor = new TextBox { Name = "txtAutor", Location = new Point(70, yOffset), Size = new Size(200, 25) };
            groupBox1.Controls.Add(txtAutor);
            yOffset += 40;

            Label lblTitel = new Label { Text = "Titel:", Location = new Point(10, yOffset), Size = new Size(50, 25) };
            groupBox1.Controls.Add(lblTitel);
            TextBox txtTitel = new TextBox { Name = "txtTitel", Location = new Point(70, yOffset), Size = new Size(200, 25) };
            groupBox1.Controls.Add(txtTitel);
            yOffset += 40;

            Label lblGenre = new Label { Text = "Genre:", Location = new Point(10, yOffset), Size = new Size(50, 25) };
            groupBox1.Controls.Add(lblGenre);
            TextBox txtGenre = new TextBox { Name = "txtGenre", Location = new Point(70, yOffset), Size = new Size(200, 25) };
            groupBox1.Controls.Add(txtGenre);
            yOffset += 40;

            Button btnSuchen = new Button { Text = "Suchen", Location = new Point(10, yOffset), Size = new Size(80, 30) };
            btnSuchen.Click += (sender, e) => BücherSuchenButton_Click(sender, e);
            groupBox1.Controls.Add(btnSuchen);
            yOffset += 40;

            Button btnLeiheBestätigen = new Button { Text = "Ausleihe Bestätigen", Location  = new Point (btnSuchen.Location.X+160,btnSuchen.Location.Y), Size = new Size(200, 30), Enabled = false };
            groupBox1.Controls.Add(btnLeiheBestätigen);


            ListBox listBoxErgebnisse = new ListBox
            {
                Name = "listBoxErgebnisse",
                Location = new Point(10, yOffset),
                Size = new Size(350, 200)
            };
            groupBox1.Controls.Add(listBoxErgebnisse);
            yOffset += 220;

            listBoxErgebnisse.SelectedIndexChanged += (sender, e) =>
            {
                btnLeiheBestätigen.Enabled = listBoxErgebnisse.SelectedItem != null;
            };

            btnLeiheBestätigen.Click += (sender, e) => AusleiheBestätigenButton_click(sender, e, listBoxErgebnisse);
        }
        private void BücherSuchenButton_Click(object sender, EventArgs e)
        {
            string autor = ((TextBox)groupBox1.Controls["txtAutor"]).Text.Trim();
            string titel = ((TextBox)groupBox1.Controls["txtTitel"]).Text.Trim();
            string genre = ((TextBox)groupBox1.Controls["txtGenre"]).Text.Trim();

            string query = "SELECT Titel, Autor, Genre, Menge FROM Buecher WHERE 1=1";
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();

            if (!string.IsNullOrEmpty(autor))
            {
                query += " AND Autor LIKE @autor";
                parameters.Add(new SQLiteParameter("@autor", "%" + autor + "%"));
            }
            if (!string.IsNullOrEmpty(titel))
            {
                query += " AND Titel LIKE @titel";
                parameters.Add(new SQLiteParameter("@titel", "%" + titel + "%"));
            }
            if (!string.IsNullOrEmpty(genre))
            {
                query += " AND Genre LIKE @genre";
                parameters.Add(new SQLiteParameter("@genre", "%" + genre + "%"));
            }

            ListBox listBoxErgebnisse = (ListBox)groupBox1.Controls["listBoxErgebnisse"];
            listBoxErgebnisse.Items.Clear();

            using (SQLiteConnection connection = new SQLiteConnection("Data Source=C:\\Users\\mytq\\Documents\\GitHub\\DosostaBibliothek\\DosostaApp\\DosostaDB\\Datenbank.db;Version=3;"))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddRange(parameters.ToArray());

                try
                {
                    connection.Open();
                    SQLiteDataReader reader = command.ExecuteReader();

                    if (!reader.HasRows)
                    {
                        MessageBox.Show("Keine Treffer gefunden.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        while (reader.Read())
                        {
                            string result = $"{reader["Titel"]} - {reader["Autor"]} - {reader["Genre"]} - Verfügbar: {reader["Menge"]}";
                            listBoxErgebnisse.Items.Add(result);
                        }
                    }

                    reader.Close();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim Ausführen der Suche: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }

            }
        }
        private void BücherleiheButton_click(object sender, EventArgs e)
        {
            string autor = ((TextBox)groupBox1.Controls["txtAutor"]).Text.Trim();
            string titel = ((TextBox)groupBox1.Controls["txtTitel"]).Text.Trim();
            string genre = ((TextBox)groupBox1.Controls["txtGenre"]).Text.Trim();

            string query = "SELECT Titel, Autor, Genre, Menge FROM Buecher WHERE 1=1";
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();

            if (!string.IsNullOrEmpty(autor))
            {
                query += " AND Autor LIKE @autor";
                parameters.Add(new SQLiteParameter("@autor", "%" + autor + "%"));
            }
            if (!string.IsNullOrEmpty(titel))
            {
                query += " AND Titel LIKE @titel";
                parameters.Add(new SQLiteParameter("@titel", "%" + titel + "%"));
            }
            if (!string.IsNullOrEmpty(genre))
            {
                query += " AND Genre LIKE @genre";
                parameters.Add(new SQLiteParameter("@genre", "%" + genre + "%"));
            }
            ListBox listBoxErgebnisse;
            if (groupBox1.Controls.ContainsKey("listBoxErgebnisse"))
            {
                listBoxErgebnisse = (ListBox)groupBox1.Controls["listBoxErgebnisse"];
                listBoxErgebnisse.Items.Clear(); 
            }
            else
            {
                listBoxErgebnisse = new ListBox
                {
                    Name = "listBoxErgebnisse",
                    Location = new Point(10, 200),
                    Size = new Size(350, 200)
                };
                groupBox1.Controls.Add(listBoxErgebnisse);
            }
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=C:\\Users\\mytq\\Documents\\GitHub\\DosostaBibliothek\\DosostaApp\\DosostaDB\\Datenbank.db;Version=3;"))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddRange(parameters.ToArray());

                try
                {
                    connection.Open();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("Keine Treffer in der Datenbank gefunden.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            while (reader.Read())
                            {
                                string result = $"{reader["Titel"]} - {reader["Autor"]} - {reader["Genre"]} - Verfügbar: {reader["Menge"]}";
                                listBoxErgebnisse.Items.Add(result);
                            }
                        }
                    } 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim Ausführen der Suche: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (!groupBox1.Controls.ContainsKey("btnBestätigenUndAusleihen"))
            {
                Button btnBestätigenUndAusleihen = new Button
                {
                    Name = "btnBestätigenUndAusleihen",
                    Text = "Ausleihe Bestätigen",
                    Location = new Point(100, 420),
                    Size = new Size(150, 30),
                    Enabled = true
                };

                btnBestätigenUndAusleihen.Click += (s, e) => AusleiheBestätigenButton_click(s, e, listBoxErgebnisse);
                groupBox1.Controls.Add(btnBestätigenUndAusleihen);
            }
        }
        private void AusleiheBestätigenButton_click(object sender, EventArgs e, ListBox listBoxErgebnisse)
        {
            if (listBoxErgebnisse.SelectedItem == null)
            {
                MessageBox.Show("Bitte wählen Sie ein Buch aus.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedBook = listBoxErgebnisse.SelectedItem.ToString();
            string[] bookDetails = selectedBook.Split(new string[] { " - " }, StringSplitOptions.None);

            string titel = bookDetails[0];
            string autor = bookDetails[1];
            string genre = bookDetails[2];
            string menge = bookDetails[3].Replace("Verfügbar: ", "");

            if (int.Parse(menge) > 0)
            {
                using (SQLiteConnection connection = new SQLiteConnection("Data Source=C:\\Users\\mytq\\Documents\\GitHub\\DosostaBibliothek\\DosostaApp\\DosostaDB\\Datenbank.db;Version=3;"))
                {
                    connection.Open();
                    using (SQLiteTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string getBookIDQuery = "SELECT BuchID FROM Buecher WHERE Titel = @titel AND Autor = @autor";
                            int buchID = -1;

                            using (SQLiteCommand getBookIDCmd = new SQLiteCommand(getBookIDQuery, connection))
                            {
                                getBookIDCmd.Parameters.AddWithValue("@titel", titel);
                                getBookIDCmd.Parameters.AddWithValue("@autor", autor);

                                object result = getBookIDCmd.ExecuteScalar();
                                if (result != null) buchID = Convert.ToInt32(result);
                            }

                            if (buchID == -1)
                            {
                                MessageBox.Show("Fehler: Buch konnte nicht gefunden werden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            string updateQuery = "UPDATE Buecher SET Menge = Menge - 1 WHERE BuchID = @buchID";
                            using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                            {
                                command.Parameters.AddWithValue("@buchID", buchID);
                                command.ExecuteNonQuery();
                            }
                            int userID = Benutzersession.UserID;
                            DateTime verleihDatum = DateTime.Now;
                            DateTime rueckgabeDatum = verleihDatum.AddDays(28);

                            string insertQuery = "INSERT INTO Verleih (UserID, BuchID, Verleihdatum, Rückgabedatum, Status) " +
                                                 "VALUES (@userID, @buchID, @verleihDatum, @rueckgabeDatum, @status)";

                            using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@userID", userID);
                                insertCommand.Parameters.AddWithValue("@buchID", buchID);
                                insertCommand.Parameters.AddWithValue("@verleihDatum", verleihDatum);
                                insertCommand.Parameters.AddWithValue("@rueckgabeDatum", rueckgabeDatum);
                                insertCommand.Parameters.AddWithValue("@status", "verliehen");

                                insertCommand.ExecuteNonQuery();
                            }

                            transaction.Commit();

                            MessageBox.Show($"Das Buch '{titel}' wurde erfolgreich ausgeliehen.\nRückgabe bis: {rueckgabeDatum:dd.MM.yyyy}",
                                "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Fehler bei der Ausleihe: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Das Buch ist derzeit nicht verfügbar.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
