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
    public partial class MaBasisseite : Form
    {
        public MaBasisseite()
        {
            InitializeComponent();
        }
        /*
        private void StartscreenLogin_click(object sender, EventArgs e)
        {
            string enteredUsername = vorname.Text; // TODO: username.txt Feld anlegen und verlinken
            string enterednachname = nachname.Text; // TODO: password.txt Feld anlegen und verlinken
            string enteredpassword = password.txt;

            string query = "SELECT COUNT(*) FROM Admins WHERE Username = @Username AND Password = @Password";

            using (SqlConnection connection = new SqlConnection("YourConnectionStringHere"))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Username", enteredUsername);
                command.Parameters.AddWithValue("@Password", enteredPassword); 

                try
                {
                    connection.Open();
                    int result = (int)command.ExecuteScalar();

                    if (result > 0)
                    {
                        MessageBox.Show("Erfolgreich eingeloggt!", "Admin Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        MaAdminseite adminForm = new MaAdminseite();
                        adminForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Ungültige Anmeldedaten. Bitte versuchen Sie es erneut.", "Login fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim Login: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        */
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

        private void Benutzerverwaltungbutton_Click(object sender, EventArgs e)
        {

        }
    }
}



//// Registrierung erfolgt als Kunde
//// "Mitarbeiter" Zuweisung erfolgt über den System Admin
//// datenbnk tabelle mitarbeiter vorname, nachname, password, status (vermerkt ist "Mitrarbeiter" und "Admin")
