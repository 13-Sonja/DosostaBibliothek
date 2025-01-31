using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Reflection.Metadata.BlobBuilder;

namespace DosostaApp
{
    public partial class MaAdminseite : Form
    {
        private SQLiteConnection sqlite_conn;


        public MaAdminseite()
        {
            InitializeComponent();
            // InitializeBibliothek();
           // InitializeUserManagement();
           InitializeDatabase();
        }
        private void InitializeDatabase()
        {
            sqlite_conn = new SQLiteConnection("Data Source=Bibliothek.db;Version=3;");
            sqlite_conn.Open();
        }
        private void  ZeigenVerfübareBücher()
        {
            string query = "SELECT Id, Title, Autor,Genre FROM Bücher WHERE IsAusgeleihen = 0;";
            SQLiteCommand cmd = new SQLiteCommand(query, sqlite_conn);
            SQLiteDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                // Beispiel: Daten in eine ListBox einfügen
              //  listBoxAvailableBooks.Items.Add($"{reader["Id"]}: {reader["Title"]} : {reader["Genre"]} von {reader["Autor"]}");
            }
        

        }
        private void btnShowAvailableBooks_Click(object sender, EventArgs e)
        {
           // listBoxAvailableBooks.Items.Clear();
            ZeigenVerfübareBücher();
        }





        private void Benutzerverwaltungbutton_Click(object sender, EventArgs e)
        {

        }


        

        private void Ausleihen_verwalten_button_Click(object sender, EventArgs e)
        {

        }

        private void Mitarbeiterverwaltung_button_Click(object sender, EventArgs e)
        {

        }

        private void Reservierungen_verwalten_button_Click(object sender, EventArgs e)
        {

        }

        private void Beanachrichtigungen_senden_button_Click(object sender, EventArgs e)
        {

        }

        private void Buchverwaltung_button_Click(object sender, EventArgs e)
        {

        }
    }
     

    }
