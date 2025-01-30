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
    }
}