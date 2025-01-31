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
    /// <summary>
    /// Die Registrierungsseite, die es einem neuen Benutzer ermöglicht, ein Konto zu erstellen.
    /// </summary>
    public partial class Registrierungsseite : Form
    {
        /// <summary>
        /// Eine Referenz zur Startseite, um diese nach der Registrierung wieder anzuzeigen.
        /// </summary>
        public Startseite RefToStart { get; set; }
        /// <summary>
        /// Initialisiert die Registrierungsseite.
        /// </summary>
        public Registrierungsseite()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Handler für den Klick auf den "Registrieren"-Button. Überprüft die Eingabedaten und registriert den Benutzer, wenn alle Daten korrekt sind.
        /// </summary>
        /// <param name="sender">Das Objekt, das das Ereignis ausgelöst hat (der Registrieren-Button).</param>
        /// <param name="e">Die Event-Argumente, die zusätzliche Informationen zum Ereignis enthalten.</param>
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
        /// <summary>
        /// Überprüft die Eingabedaten der Registrierung und gibt zurück, ob die Registrierung erfolgreich ist.
        /// </summary>
        /// <param name="vorname">Der Vorname des Benutzers.</param>
        /// <param name="nachname">Der Nachname des Benutzers.</param>
        /// <param name="passwort">Das Passwort des Benutzers.</param>
        /// <param name="email">Die E-Mail-Adresse des Benutzers.</param>
        /// <param name="geburtsdatum">Das Geburtsdatum des Benutzers.</param>
        /// <returns>Gibt zurück, ob die Registrierung erfolgreich ist (true) oder nicht (false).</returns>
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
        /// <summary>
        /// Handler für den Klick auf den "Zurück"-Button. Zeigt die Startseite an und schließt die Registrierungsseite.
        /// </summary>
        /// <param name="sender">Das Objekt, das das Ereignis ausgelöst hat (der Zurück-Button).</param>
        /// <param name="e">Die Event-Argumente, die zusätzliche Informationen zum Ereignis enthalten.</param>
        private void zurückButton_Click(object sender, EventArgs e)
        {
            this.RefToStart.Show();
            Close();
        }
    }
}
