using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DosostaApp.DosostaDB;


namespace DosostaApp
{
    public partial class Loginseite : Form
    {
        private int versuche = 5;
        public Loginseite()
        {
            InitializeComponent();
        }

        private void zurückButton_Click(object sender, EventArgs e)
        {
            Startseite startseite = new Startseite();
            startseite.Show();
            Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string? vorname = this.vornameTextbox.Text;
            string? nachname = this.nachnameTextbox.Text;
            string? passwort = this.passwortTextbox.Text;
            bool loginErfolgreich = loginErfolg(vorname, nachname, passwort);
            if (loginErfolgreich)
            {
                Close();
                KdBasisseite kdSeite = new KdBasisseite();
                kdSeite.Show();
            }
            else
                return;
        }

        private bool loginErfolg(string vorname, string nachname, string passwort)
        {
            Datenbank kunden = new Datenbank();

            if (string.IsNullOrEmpty(vorname) || string.IsNullOrEmpty(nachname) || string.IsNullOrEmpty(passwort))
            {
                string message = "Login nicht erfolgreich. Alle Felder müssen ausgefüllt sein.";
                MessageBox.Show(message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (versuche <= 0)
            {
                string message = $"Zu viele Fehlversuche, Konto gesperrt. Wenden Sie sich an einen Mitarbeiter.";
                MessageBox.Show(message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (kunden.CheckLogin(passwort))
                //find and verify data
                return true;
            else if (!kunden.CheckLogin(passwort))
            {
                versuche--;
                string message = $"Login nicht erfolgreich. Daten stimmen nicht überein. Weitere Versuche: {versuche}";
                MessageBox.Show(message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return false;
        }
    }
}
