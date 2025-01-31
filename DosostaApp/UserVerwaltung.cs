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
        private void groupBox1_Enter_1(GroupBox groupBox)
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

        private void User_verwaltung_button_Click_1(object sender, EventArgs e)
        {
            groupBox1_Enter_1(groupBox1);
        }

        private void Passwort_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clear_button_Click()
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



       


      

        private void Ändern_button_Click(object sender, EventArgs e)
        {
            string vornameUser = vorname.Text;
            string nachnameUser = nachname_textBox.Text;
            string EmailUser = Email_textBox1.Text;
            string statutUser = statut_comboBox.Text;
            string PasswortUser = Passwort_textBox.Text;

            using (var connection = Database.VerwaltungConnection())
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO User(nachname, vorname, email, status, passwort) VALUES(@vorname, @nachname, @email, @status, @passwort)";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@vorname", vornameUser);
                        cmd.Parameters.AddWithValue("@nachname", nachnameUser);
                        cmd.Parameters.AddWithValue("@email", EmailUser);
                        cmd.Parameters.AddWithValue("@status", statutUser);
                        cmd.Parameters.AddWithValue("@passwort", PasswortUser);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User erfolgreich hinzugefügt");
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error :" + ex.Message);
                }
            }


        }


        private void Alle_User_Sehen_Click(object sender, EventArgs e)
        {

        }

        //private void groupBox1_Enter_1(object sender, EventArgs e)
        //{

        //}

        //private void User_verwaltung_button_Click_1(object sender, EventArgs e)
        //{

        //}
    }
    public class Database
    {
        private static string connectionString = "Data Source = C:\\Users\\MYTQ\\Documents\\GitHub\\DosostaBibliothek\\DosostaApp\\DosostaDB\\Datenbank.db;Version=3";
        public static SQLiteConnection VerwaltungConnection()
        {
            return new SQLiteConnection(connectionString);
        }
    }
}
