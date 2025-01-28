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
    public partial class Startseite : Form
    {
        public static string status = "";
        public Startseite()
        {
            InitializeComponent();
        }

        private void kdLoginButton_Click(object sender, EventArgs e)
        {
            status = "Kunde";
            Loginseite kdLogin = new Loginseite();
            kdLogin.Show();
            Hide();
        }

        private void registrierenButton_Click(object sender, EventArgs e)
        {
            Registrierungsseite regSeite = new Registrierungsseite();
            regSeite.Show();
            Hide();
        }

        private void maLoginButton_Click(object sender, EventArgs e)
        {
            status = "Mitarbeiter";
            Loginseite maLogin = new Loginseite();
            maLogin.Show();
            Hide();
        }
    }
}
