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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DosostaApp
{
    public partial class Registrierungsseite : Form
    {
        public Startseite RefToStart { get; set; }
        public Registrierungsseite()
        {
            InitializeComponent();
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            string? vorname = vornameTextbox.Text;
            string? nachname = nachnameTextbox.Text;
            string? passwort = passwortTextbox.Text;
            string? email = emailTextbox.Text;
            string geburtsdatum = gebDatepicker.Value.ToShortDateString();

            bool registrierungErfolgreich = RegistrierungErfolg(vorname, nachname, passwort, email, geburtsdatum);
           
            if (registrierungErfolgreich)
            {
                // create entry in db
                Datenbank kunden = new Datenbank();
                kunden.BenutzerHinzufügen(vorname, nachname, passwort, email, geburtsdatum);
                Close();
                Loginseite logseite = new();
                logseite.Show();
            }
            else
                return;

        }

        private bool RegistrierungErfolg(string? vorname, string? nachname, string? passwort, string? email, string geburtsdatum)
        {
            if (string.IsNullOrEmpty(vorname) || string.IsNullOrEmpty(nachname) || string.IsNullOrEmpty(passwort) || string.IsNullOrEmpty(email))
            {
                string message = "Registrierung nicht erfolgreich. Alle Felder müssen ausgefüllt sein.";
                MessageBox.Show(message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (email == "max.mustermann@example.com")
            { 
                string message = "Emailadresse bereits registriert. Wollen Sie sich einloggen?";
                MessageBox.Show(message, "Fehler", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return false;
            }
            else if (!email.Contains('@') && !email.Contains('.'))
            {
                string message = "Emailadresse fehlerhaft, bitte prüfen.";
                MessageBox.Show(message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void zurückButton_Click(object sender, EventArgs e)
        {
            this.RefToStart.Show();
            Close();
        }
    }
}
