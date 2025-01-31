using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DosostaApp
{
    /// <summary>
    /// Die Startseite der Anwendung, die dem Benutzer verschiedene Anmeldemöglichkeiten bietet.
    /// </summary>
    public partial class Startseite : Form
    {
        /// <summary>
        /// Initialisiert die Komponenten der Startseite.
        /// </summary>
        public Startseite()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Handler für den Klick auf den Kunden-Login-Button. Öffnet die Login-Seite für den Kunden.
        /// </summary>
        /// <param name="sender">Das Objekt, das das Ereignis ausgelöst hat (der Kunden-Login-Button).</param>
        /// <param name="e">Die Event-Argumente, die zusätzliche Informationen zum Ereignis enthalten.</param>
        private void kdLoginButton_Click(object sender, EventArgs e)
        {
            Loginseite kdLogin = new();
            kdLogin.RefToStart = this;
            kdLogin.Show();
            Hide();
        }
        /// <summary>
        /// Handler für den Klick auf den Registrieren-Button. Öffnet die Registrierungsseite.
        /// </summary>
        /// <param name="sender">Das Objekt, das das Ereignis ausgelöst hat (der Registrieren-Button).</param>
        /// <param name="e">Die Event-Argumente, die zusätzliche Informationen zum Ereignis enthalten.</param>
        private void registrierenButton_Click(object sender, EventArgs e)
        {
            Registrierungsseite regSeite = new();
            regSeite.RefToStart = this;
            regSeite.Show();
            Hide();
        }
        /// <summary>
        /// Handler für den Klick auf den Mitarbeiter-Login-Button. Öffnet die Login-Seite für den Mitarbeiter.
        /// </summary>
        /// <param name="sender">Das Objekt, das das Ereignis ausgelöst hat (der Mitarbeiter-Login-Button).</param>
        /// <param name="e">Die Event-Argumente, die zusätzliche Informationen zum Ereignis enthalten.</param>
        private void maLoginButton_Click(object sender, EventArgs e)
        {
            Loginseite maLogin = new();
            maLogin.RefToStart = this;
            maLogin.Show();
            Hide();
        }
    }
}
