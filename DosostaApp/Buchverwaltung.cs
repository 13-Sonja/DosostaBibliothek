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

namespace DosostaApp
{
    public partial class Buchverwaltung : Form
    {
        public Buchverwaltung()
        {
            InitializeComponent();
        }

        private void Ausleihen_tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Zurückgeben_tabPage2_Click(object sender, EventArgs e)
        {

        }

        public class Database
        {
            public static string connectionString = "Data Source = C:\\Users\\MYTQ\\Documents\\GitHub\\DosostaBibliothek\\DosostaApp\\DosostaDB\\Datenbank.db; Version = 3";

            public static SQLiteConnection VerwaltungConnection()
            {
                return new SQLiteConnection(connectionString);
            }
        }

        private void Bücher()
        {
            using (var conn = Database.VerwaltungConnection())
            {
                conn.Open();
                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM  Buecher", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void Ausleihen_Click(object sender, EventArgs e)
        {
            Bücher();

        }

        private void BücherZurückgeben()
        {
            using (var conn = Database.VerwaltungConnection())
            {
                conn.Open();
                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM  Buecher", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;

            }
        }


        private void Zurückgeben_Click(object sender, EventArgs e)
        {

            tabControl1.SelectedTab = Zurückgeben_tabPage2;
            BücherZurückgeben();
        }


        private void btnAusleihen_Click(object sender, EventArgs e)
        {
            string titel = btnAusleihen.Text;
            // string name = NameAusleiher_textBox1.Text;
            int UserID = int.Parse(NameAusleiher_textBox1.Text);



            if (string.IsNullOrEmpty(titel))
            {
                MessageBox.Show("Geben Sie den Titel des Buches in Verbindung mit Ihrem Namen ein, um ein Buch ausleihen zu können.");
                return;
            }
            else
            {
                int BuchID = Convert.ToInt32(Id_textBox1.Text);
                int Menge = Convert.ToInt32(AusleihendeMengetextBox1.Text);
                // int UserID = int.Parse(Id_textBox1.Text);

                if (Menge > 0)
                {
                    Ausleihen_Click(BuchID, UserID);
                    //chargerLivres(dataGridViewTake);
                    Bücher();
                }
            }
        }

        private void Ausleihen_Click(int BuchID, int UserID)
        {
            using (var conn = Database.VerwaltungConnection())
            {
                conn.Open();
                SQLiteTransaction transaction = conn.BeginTransaction();

                try
                {
                    SQLiteCommand cmdEmprunt = new SQLiteCommand("INSERT INTO Verleih (BuchID,UserID,verleihdatum,rückgabedatum) VALUES (@BuchID,@UserID,@verleihdatum,@rückgabedatum", conn);

                    cmdEmprunt.Parameters.AddWithValue("@BuchID", BuchID);
                    cmdEmprunt.Parameters.AddWithValue("@UserID", UserID);
                    cmdEmprunt.Parameters.AddWithValue("@verleihdatum", DateTime.Now);
                    cmdEmprunt.Parameters.AddWithValue("@rückgabedatum", DateTime.Now.AddDays(14));
                    // cmdEmprunt.Parameters.AddWithValue("@Returned", false);

                    cmdEmprunt.ExecuteNonQuery();

                    SQLiteCommand cmdUpdate = new SQLiteCommand("UPDATE Buch set Menge = Menge -1 WHERE Buchid = @Buchid", conn);
                    cmdUpdate.Parameters.AddWithValue("@Buchid", BuchID);

                    cmdUpdate.ExecuteNonQuery();

                    transaction.Commit();

                    MessageBox.Show("Die Transaktion verlief erfolgreich. Sie haben 14 Tage Zeit, das Buch zurückzugeben.  ");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Kann die Transaktion des Ausleihvorgangs nicht abschließen ", ex.Message);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                Id_textBox1.Text = row.Cells["BuchID"].Value.ToString();
                Titel_textBox1.Text = row.Cells["titel"].Value.ToString();
                //txtGenreTake.Text = row.Cells["genre"].Value.ToString();
                Autor_textBox1.Text = row.Cells["autor"].Value.ToString();
                AusleihendeMengetextBox1.Text = row.Cells["Menge"].Value.ToString();


            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BuchID_textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bücher_button_Click(object sender, EventArgs e)
        {


            // Werte aus den Textfeldern auslesen
            //string buchID = BuchID_textBox1.Text;
            string titel = Titel_textBox5.Text;
            string autor = Autor_textBox2.Text;
            string isbn = isbn_textBox3.Text;
            string genre = Genre_textBox4.Text;
            string menge = Menge_textBox6.Text;

            // SQL-Befehl zum Einfügen des Buches
            string query = "INSERT INTO Buecher ( autor, titel,isbn, genre, menge) " +
                           "VALUES ( @autor, @titel, @isbn, @genre, @menge)";

            // Verbindung zur Datenbank herstellen
            using (var conn = Database.VerwaltungConnection())
            {
                try
                {
                    conn.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, conn))
                    {
                        // Parameter hinzufügen
                        command.Parameters.AddWithValue("@titel", titel);
                        command.Parameters.AddWithValue("@autor", autor);
                        command.Parameters.AddWithValue("@genre", genre);
                        command.Parameters.AddWithValue("@menge", menge);
                        command.Parameters.AddWithValue("@isbn", isbn);
                        // command.Parameters.AddWithValue("@BuchID", buchID);

                        // Befehl ausführen
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Buch erfolgreich hinzugefügt!");
                        }
                        else
                        {
                            MessageBox.Show("Fehler beim Hinzufügen des Buches.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler: " + ex.Message);
                }
            }

        }

        private void isbn_label_Click(object sender, EventArgs e)
        {

        }
    }
}
