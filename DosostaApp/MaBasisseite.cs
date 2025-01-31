using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DosostaApp
{
    public partial class MaBasisseite : Form
    {
        public string status { get; set; }
        public MaBasisseite()
        {
            InitializeComponent();
        }
        
        private void LogoutButton_click(object sender, EventArgs e)
        {
            var confirmLogout = MessageBox.Show("Möchten Sie sich wirklich abmelden?", "Abmelden", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmLogout == DialogResult.Yes)
            {
                Close();
                Startseite startForm = new();
                startForm.Show();
            }
        }

        private void Benutzerverwaltungbutton_Click(object sender, EventArgs e)
        {
            if (status == "Mitarbeiter")
                MessageBox.Show("Keine Berechtigung!", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
            MaUserverwaltungsseite userseite = new();
            userseite.Show();
            }
        }

        private void Nicht_implementiert_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kein Anschluss unter dieser Nummer.", "Nope", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Buchverwaltung_button_Click(object sender, EventArgs e)
        {
            MaBuchverwaltungsseite bvseite = new();
            bvseite.Show();

        }
    }
}