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
        public Startseite RefToStart { get; set; }
        public Loginseite()
        {
            InitializeComponent();
        }

        private void zurückButton_Click(object sender, EventArgs e)
        {
            this.RefToStart.Show();
            Close();
        }

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
                    maSeite.status = loginResultat.status;
                    maSeite.Show();
                }
            }
            else
                return;
        }

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
