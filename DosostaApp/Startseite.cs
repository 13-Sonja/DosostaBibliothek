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
        public Startseite()
        {
            InitializeComponent();
        }

        private void kdLoginButton_Click(object sender, EventArgs e)
        {
            Loginseite kdLogin = new();
            kdLogin.RefToStart = this;
            kdLogin.Show();
            Hide();
        }

        private void registrierenButton_Click(object sender, EventArgs e)
        {
            Registrierungsseite regSeite = new();
            regSeite.RefToStart = this;
            regSeite.Show();
            Hide();
        }

        private void maLoginButton_Click(object sender, EventArgs e)
        {
            Loginseite maLogin = new();
            maLogin.RefToStart = this;
            maLogin.Show();
            Hide();
        }
    }
}
