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
    /// <summary>
    /// Die Loginseite, die Benutzern die Anmeldung ermöglicht, entweder als Kunde oder als Mitarbeiter.
    /// </summary>
    public partial class Loginseite : Form
    {
        /// <summary>
        /// Die verbleibende Anzahl an Login-Versuchen.
        /// </summary>
        private int versuche = 5;
        /// <summary>
        /// Eine Referenz zur Startseite, um diese nach dem Login wieder anzuzeigen.
        /// </summary>
        public Startseite RefToStart { get; set; }
        /// <summary>
        /// Initialisiert die Loginseite.
        /// </summary>
        public Loginseite()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Handler für den Klick auf den "Zurück"-Button. Zeigt die Startseite an und schließt die Loginseite.
        /// </summary>
        /// <param name="sender">Das Objekt, das das Ereignis ausgelöst hat (der Zurück-Button).</param>
        /// <param name="e">Die Event-Argumente, die zusätzliche Informationen zum Ereignis enthalten.</param>
        private void zurückButton_Click(object sender, EventArgs e)
        {
            this.RefToStart.Show();
            Close();
        }
        /// <summary>
        /// Handler für den Klick auf den "Login"-Button. Prüft die Anmeldedaten und leitet den Benutzer zur entsprechenden Seite weiter.
        /// </summary>
        /// <param name="sender">Das Objekt, das das Ereignis ausgelöst hat (der Login-Button).</param>
        /// <param name="e">Die Event-Argumente, die zusätzliche Informationen zum Ereignis enthalten.</param>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string? vorname = vornameTextbox.Text;
            string? nachname = nachnameTextbox.Text;
            string? passwort = passwortTextbox.Text;

            (bool erfolg, string status, int kundenID, string email) loginResultat = loginErfolg(vorname, nachname, passwort);
            if (loginResultat.erfolg)
            {
                Close();
                if (loginResultat.status == "Kunde")
                {
                    KdBasisseite kdSeite = new();
                    KdBasisseite.Benutzersession.UserID = loginResultat.kundenID;
                    KdBasisseite.Benutzersession.email = loginResultat.email;
                    kdSeite.Show();
                }
                else
                {
                    MaBasisseite maSeite = new();
                    maSeite.Show();
                }
            }
            else
                return;
        }
        /// <summary>
        /// Überprüft die Login-Daten und gibt das Ergebnis der Überprüfung zurück.
        /// </summary>
        /// <param name="vorname">Der Vorname des Benutzers.</param>
        /// <param name="nachname">Der Nachname des Benutzers.</param>
        /// <param name="passwort">Das Passwort des Benutzers.</param>
        /// <returns>Ein Tuple mit dem Erfolg der Login-Prüfung, dem Status des Benutzers (Kunde oder Mitarbeiter), der Kunden-ID und der E-Mail-Adresse des Benutzers.</returns>
        private (bool, string, int, string email) loginErfolg(string vorname, string nachname, string passwort)
        {
            Datenbank kunden = new Datenbank();

            if (string.IsNullOrEmpty(vorname) || string.IsNullOrEmpty(nachname) || string.IsNullOrEmpty(passwort))
            {
                string message = "Login nicht erfolgreich. Alle Felder müssen ausgefüllt sein.";
                MessageBox.Show(message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return (false, "error", -1, "");
            }
            else if (versuche <= 0)
            {
                string message = $"Zu viele Fehlversuche, Konto gesperrt. Wenden Sie sich an einen Mitarbeiter.";
                MessageBox.Show(message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return (false, "error", -1, "");
            }
            //bool test = kunden.CheckLoginSimple(vorname, nachname, passwort);
            //MessageBox.Show(test.ToString());

            (bool erfolg, string status, int kundenID, string email) loginResultat = kunden.CheckLogin(vorname, nachname, passwort);
            
            if (loginResultat.erfolg)
                return (loginResultat.erfolg, loginResultat.status, loginResultat.kundenID, loginResultat.email);
            else if (!loginResultat.erfolg)
            {
                versuche--;
                string message = $"Login nicht erfolgreich. Daten stimmen nicht überein. Weitere Versuche: {versuche}";
                MessageBox.Show(message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return (false, "error", -1, "");
            }

            return (false, "error", -1, "");
        }
    }
}
