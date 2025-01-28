using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DosostaApp
{


    public partial class UserVerwaltung : Form

    {
        private void AnzeigenGroupBox(GroupBox groupBox)
        {
            var allGroupboxes = new[] { groupBox1 };

            foreach (var box in allGroupboxes)
            {
                box.Visible = box == groupBox;
            }
        }
        public UserVerwaltung()
        {
            InitializeComponent();
        }

        private void User_verwaltung_button_Click(object sender, EventArgs e)
        {
            AnzeigenGroupBox(groupBox1);
        }

        private void Passwort_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void erneuen_button_Click()
        {
            vorname.Text = "";
            nachname_textBox.Text = "";
            Email_textBox1.Text = "";
            statut_comboBox.Text = "";
            Passwort_textBox.Text = "";
        }

        private void UserVerwaltung_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void erstellen_button_Click(object sender, EventArgs e)
        {
           string vornameUser =vorname.Text;
           string nachnameUser = nachname_textBox.Text;
           string EmailUser = Email_textBox1.Text;
           string statutUser = statut_comboBox.Text;
           string PasswortUser = Passwort_textBox.Text;

            using (var connection = Database.VerwaltungConnection())
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO users(nachname, vorname, email, statut, passwort) VALUES(@vorname, @nachname, @email, @statut, @password)";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@vorname", vornameUser);
                        cmd.Parameters.AddWithValue("@nachname", nachnameUser);
                        cmd.Parameters.AddWithValue("@email", EmailUser);
                        cmd.Parameters.AddWithValue("@statut", statutUser);
                        cmd.Parameters.AddWithValue("@passwort", PasswortUser);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User erfolgreich hinzugefügt");
                        erneuen_button_Click();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error :" + ex.Message);
                }
            }

        }
    }
    public class Database
    {
        private static string connectionString = "Data source=bd.db;Version=3";
        public static SQLiteConnection VerwaltungConnection()
        {
            return new SQLiteConnection(connectionString);
        }
    }
}
