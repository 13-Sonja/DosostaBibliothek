namespace DosostaApp
{
    partial class MaBuchverwaltungsseite
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            zurückButton = new Button();
            bücherAnzeigenButton = new Button();
            reservierungenButton = new Button();
            buchHinzufügenButton = new Button();
            rückgabeButton = new Button();
            buchBearbeitenButton = new Button();
            Bücher_button = new Button();
            tabControl1 = new TabControl();
            Verleihen_tabPage1 = new TabPage();
            AusleihendeMenglabel2 = new Label();
            ID_label2 = new Label();
            Id_textBox1 = new TextBox();
            AusleihendeMengetextBox1 = new TextBox();
            label1 = new Label();
            Titel_labe1 = new Label();
            Titel_textBox1 = new TextBox();
            Autor_textBox1 = new TextBox();
            Name_label1 = new Label();
            NameAusleiher_textBox1 = new TextBox();
            btnAusleihen = new Button();
            dataGridView1 = new DataGridView();
            Buch_Hinzufügen_tabPage1 = new TabPage();
            Menge_label = new Label();
            Titel_label = new Label();
            Genre_label = new Label();
            isbn_label = new Label();
            Autor_label = new Label();
            Menge_textBox6 = new TextBox();
            Titel_textBox5 = new TextBox();
            Genre_textBox4 = new TextBox();
            isbn_textBox3 = new TextBox();
            Autor_textBox2 = new TextBox();
            button1 = new Button();
            tabControl1.SuspendLayout();
            Verleihen_tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            Buch_Hinzufügen_tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // zurückButton
            // 
            zurückButton.BackColor = Color.FromArgb(143, 148, 171);
            zurückButton.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            zurückButton.Location = new Point(12, 444);
            zurückButton.Margin = new Padding(3, 2, 3, 2);
            zurückButton.Name = "zurückButton";
            zurückButton.Size = new Size(183, 55);
            zurückButton.TabIndex = 3;
            zurückButton.Text = "Zurück";
            zurückButton.UseVisualStyleBackColor = false;
            zurückButton.Click += zurückButton_Click;
            // 
            // bücherAnzeigenButton
            // 
            bücherAnzeigenButton.BackColor = Color.FromArgb(154, 189, 162);
            bücherAnzeigenButton.Font = new Font("Cascadia Mono", 12F);
            bücherAnzeigenButton.Location = new Point(12, 105);
            bücherAnzeigenButton.Margin = new Padding(3, 2, 3, 2);
            bücherAnzeigenButton.Name = "bücherAnzeigenButton";
            bücherAnzeigenButton.Size = new Size(183, 37);
            bücherAnzeigenButton.TabIndex = 2;
            bücherAnzeigenButton.Text = "Bücher anzeigen";
            bücherAnzeigenButton.UseVisualStyleBackColor = false;
            // 
            // reservierungenButton
            // 
            reservierungenButton.BackColor = Color.FromArgb(195, 214, 199);
            reservierungenButton.Font = new Font("Cascadia Mono", 12F);
            reservierungenButton.Location = new Point(12, 331);
            reservierungenButton.Margin = new Padding(3, 2, 3, 2);
            reservierungenButton.Name = "reservierungenButton";
            reservierungenButton.Size = new Size(183, 62);
            reservierungenButton.TabIndex = 2;
            reservierungenButton.Text = "Reservierungen verwalten";
            reservierungenButton.UseVisualStyleBackColor = false;
            reservierungenButton.Click += KeinAnschluss_Click;
            // 
            // buchHinzufügenButton
            // 
            buchHinzufügenButton.BackColor = Color.FromArgb(154, 189, 162);
            buchHinzufügenButton.Font = new Font("Cascadia Mono", 12F);
            buchHinzufügenButton.Location = new Point(12, 206);
            buchHinzufügenButton.Margin = new Padding(3, 2, 3, 2);
            buchHinzufügenButton.Name = "buchHinzufügenButton";
            buchHinzufügenButton.Size = new Size(183, 39);
            buchHinzufügenButton.TabIndex = 2;
            buchHinzufügenButton.Text = "Buch hinzufügen";
            buchHinzufügenButton.UseVisualStyleBackColor = false;
            buchHinzufügenButton.Click += buchHinzufügenButton_Click;
            // 
            // rückgabeButton
            // 
            rückgabeButton.BackColor = Color.FromArgb(195, 214, 199);
            rückgabeButton.Font = new Font("Cascadia Mono", 12F);
            rückgabeButton.Location = new Point(12, 259);
            rückgabeButton.Margin = new Padding(3, 2, 3, 2);
            rückgabeButton.Name = "rückgabeButton";
            rückgabeButton.Size = new Size(183, 58);
            rückgabeButton.TabIndex = 1;
            rückgabeButton.Text = "Bücher zurück geben";
            rückgabeButton.UseVisualStyleBackColor = false;
            rückgabeButton.Click += KeinAnschluss_Click;
            // 
            // buchBearbeitenButton
            // 
            buchBearbeitenButton.BackColor = Color.FromArgb(154, 189, 162);
            buchBearbeitenButton.Font = new Font("Cascadia Mono", 12F);
            buchBearbeitenButton.Location = new Point(12, 157);
            buchBearbeitenButton.Margin = new Padding(3, 2, 3, 2);
            buchBearbeitenButton.Name = "buchBearbeitenButton";
            buchBearbeitenButton.Size = new Size(183, 35);
            buchBearbeitenButton.TabIndex = 0;
            buchBearbeitenButton.Text = "Buch bearbeiten";
            buchBearbeitenButton.UseVisualStyleBackColor = false;
            buchBearbeitenButton.Click += Ausleihen_Click;
            // 
            // Bücher_button
            // 
            Bücher_button.BackColor = Color.FromArgb(143, 148, 171);
            Bücher_button.Location = new Point(346, 204);
            Bücher_button.Margin = new Padding(3, 2, 3, 2);
            Bücher_button.Name = "Bücher_button";
            Bücher_button.Size = new Size(183, 41);
            Bücher_button.TabIndex = 2;
            Bücher_button.Text = " Hinzufügen";
            Bücher_button.UseVisualStyleBackColor = false;
            Bücher_button.Click += Bücher_button_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Verleihen_tabPage1);
            tabControl1.Controls.Add(Buch_Hinzufügen_tabPage1);
            tabControl1.Font = new Font("Cascadia Mono", 12F);
            tabControl1.Location = new Point(277, 52);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(586, 380);
            tabControl1.TabIndex = 1;
            // 
            // Verleihen_tabPage1
            // 
            Verleihen_tabPage1.BackColor = Color.FromArgb(255, 252, 249);
            Verleihen_tabPage1.Controls.Add(AusleihendeMenglabel2);
            Verleihen_tabPage1.Controls.Add(ID_label2);
            Verleihen_tabPage1.Controls.Add(Id_textBox1);
            Verleihen_tabPage1.Controls.Add(AusleihendeMengetextBox1);
            Verleihen_tabPage1.Controls.Add(label1);
            Verleihen_tabPage1.Controls.Add(Titel_labe1);
            Verleihen_tabPage1.Controls.Add(Titel_textBox1);
            Verleihen_tabPage1.Controls.Add(Autor_textBox1);
            Verleihen_tabPage1.Controls.Add(Name_label1);
            Verleihen_tabPage1.Controls.Add(NameAusleiher_textBox1);
            Verleihen_tabPage1.Controls.Add(btnAusleihen);
            Verleihen_tabPage1.Controls.Add(dataGridView1);
            Verleihen_tabPage1.Location = new Point(4, 30);
            Verleihen_tabPage1.Margin = new Padding(3, 2, 3, 2);
            Verleihen_tabPage1.Name = "Verleihen_tabPage1";
            Verleihen_tabPage1.Padding = new Padding(3, 2, 3, 2);
            Verleihen_tabPage1.Size = new Size(578, 346);
            Verleihen_tabPage1.TabIndex = 0;
            Verleihen_tabPage1.Text = "Verleihen";
            // 
            // AusleihendeMenglabel2
            // 
            AusleihendeMenglabel2.AutoSize = true;
            AusleihendeMenglabel2.Location = new Point(282, 79);
            AusleihendeMenglabel2.Name = "AusleihendeMenglabel2";
            AusleihendeMenglabel2.Size = new Size(55, 21);
            AusleihendeMenglabel2.TabIndex = 11;
            AusleihendeMenglabel2.Text = "Menge";
            // 
            // ID_label2
            // 
            ID_label2.AutoSize = true;
            ID_label2.Location = new Point(27, 123);
            ID_label2.Name = "ID_label2";
            ID_label2.Size = new Size(64, 21);
            ID_label2.TabIndex = 10;
            ID_label2.Text = "BuchID";
            // 
            // Id_textBox1
            // 
            Id_textBox1.Location = new Point(100, 120);
            Id_textBox1.Margin = new Padding(3, 2, 3, 2);
            Id_textBox1.Name = "Id_textBox1";
            Id_textBox1.Size = new Size(148, 26);
            Id_textBox1.TabIndex = 9;
            // 
            // AusleihendeMengetextBox1
            // 
            AusleihendeMengetextBox1.Location = new Point(357, 76);
            AusleihendeMengetextBox1.Margin = new Padding(3, 2, 3, 2);
            AusleihendeMengetextBox1.Name = "AusleihendeMengetextBox1";
            AusleihendeMengetextBox1.Size = new Size(147, 26);
            AusleihendeMengetextBox1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 81);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 7;
            label1.Text = "Autor";
            // 
            // Titel_labe1
            // 
            Titel_labe1.AutoSize = true;
            Titel_labe1.Location = new Point(282, 30);
            Titel_labe1.Name = "Titel_labe1";
            Titel_labe1.Size = new Size(55, 21);
            Titel_labe1.TabIndex = 6;
            Titel_labe1.Text = "Titel";
            // 
            // Titel_textBox1
            // 
            Titel_textBox1.Location = new Point(357, 30);
            Titel_textBox1.Margin = new Padding(3, 2, 3, 2);
            Titel_textBox1.Name = "Titel_textBox1";
            Titel_textBox1.Size = new Size(147, 26);
            Titel_textBox1.TabIndex = 5;
            // 
            // Autor_textBox1
            // 
            Autor_textBox1.Location = new Point(100, 76);
            Autor_textBox1.Margin = new Padding(3, 2, 3, 2);
            Autor_textBox1.Name = "Autor_textBox1";
            Autor_textBox1.Size = new Size(148, 26);
            Autor_textBox1.TabIndex = 4;
            // 
            // Name_label1
            // 
            Name_label1.AutoSize = true;
            Name_label1.Location = new Point(27, 30);
            Name_label1.Name = "Name_label1";
            Name_label1.Size = new Size(64, 21);
            Name_label1.TabIndex = 3;
            Name_label1.Text = "UserID";
            // 
            // NameAusleiher_textBox1
            // 
            NameAusleiher_textBox1.Location = new Point(100, 27);
            NameAusleiher_textBox1.Margin = new Padding(3, 2, 3, 2);
            NameAusleiher_textBox1.Name = "NameAusleiher_textBox1";
            NameAusleiher_textBox1.Size = new Size(148, 26);
            NameAusleiher_textBox1.TabIndex = 2;
            // 
            // btnAusleihen
            // 
            btnAusleihen.BackColor = Color.FromArgb(143, 148, 171);
            btnAusleihen.Location = new Point(357, 123);
            btnAusleihen.Margin = new Padding(3, 2, 3, 2);
            btnAusleihen.Name = "btnAusleihen";
            btnAusleihen.Size = new Size(147, 35);
            btnAusleihen.TabIndex = 1;
            btnAusleihen.Text = "Verleihen";
            btnAusleihen.UseVisualStyleBackColor = false;
            btnAusleihen.Click += btnAusleihen_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 179);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(477, 141);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Buch_Hinzufügen_tabPage1
            // 
            Buch_Hinzufügen_tabPage1.BackColor = Color.FromArgb(255, 252, 249);
            Buch_Hinzufügen_tabPage1.Controls.Add(Bücher_button);
            Buch_Hinzufügen_tabPage1.Controls.Add(Menge_label);
            Buch_Hinzufügen_tabPage1.Controls.Add(Titel_label);
            Buch_Hinzufügen_tabPage1.Controls.Add(Genre_label);
            Buch_Hinzufügen_tabPage1.Controls.Add(isbn_label);
            Buch_Hinzufügen_tabPage1.Controls.Add(Autor_label);
            Buch_Hinzufügen_tabPage1.Controls.Add(Menge_textBox6);
            Buch_Hinzufügen_tabPage1.Controls.Add(Titel_textBox5);
            Buch_Hinzufügen_tabPage1.Controls.Add(Genre_textBox4);
            Buch_Hinzufügen_tabPage1.Controls.Add(isbn_textBox3);
            Buch_Hinzufügen_tabPage1.Controls.Add(Autor_textBox2);
            Buch_Hinzufügen_tabPage1.Location = new Point(4, 30);
            Buch_Hinzufügen_tabPage1.Margin = new Padding(3, 2, 3, 2);
            Buch_Hinzufügen_tabPage1.Name = "Buch_Hinzufügen_tabPage1";
            Buch_Hinzufügen_tabPage1.Padding = new Padding(3, 2, 3, 2);
            Buch_Hinzufügen_tabPage1.Size = new Size(578, 346);
            Buch_Hinzufügen_tabPage1.TabIndex = 2;
            Buch_Hinzufügen_tabPage1.Text = "Buch hinzufügen";
            // 
            // Menge_label
            // 
            Menge_label.AutoSize = true;
            Menge_label.Location = new Point(45, 221);
            Menge_label.Name = "Menge_label";
            Menge_label.Size = new Size(55, 21);
            Menge_label.TabIndex = 11;
            Menge_label.Text = "Menge";
            // 
            // Titel_label
            // 
            Titel_label.AutoSize = true;
            Titel_label.Location = new Point(45, 41);
            Titel_label.Name = "Titel_label";
            Titel_label.Size = new Size(55, 21);
            Titel_label.TabIndex = 10;
            Titel_label.Text = "Titel";
            // 
            // Genre_label
            // 
            Genre_label.AutoSize = true;
            Genre_label.Location = new Point(315, 93);
            Genre_label.Name = "Genre_label";
            Genre_label.Size = new Size(55, 21);
            Genre_label.TabIndex = 9;
            Genre_label.Text = "Genre";
            // 
            // isbn_label
            // 
            isbn_label.AutoSize = true;
            isbn_label.Location = new Point(45, 161);
            isbn_label.Name = "isbn_label";
            isbn_label.Size = new Size(46, 21);
            isbn_label.TabIndex = 8;
            isbn_label.Text = "ISBN";
            // 
            // Autor_label
            // 
            Autor_label.AutoSize = true;
            Autor_label.Location = new Point(45, 93);
            Autor_label.Name = "Autor_label";
            Autor_label.Size = new Size(55, 21);
            Autor_label.TabIndex = 7;
            Autor_label.Text = "Autor";
            // 
            // Menge_textBox6
            // 
            Menge_textBox6.Location = new Point(110, 219);
            Menge_textBox6.Margin = new Padding(3, 2, 3, 2);
            Menge_textBox6.Name = "Menge_textBox6";
            Menge_textBox6.Size = new Size(178, 26);
            Menge_textBox6.TabIndex = 5;
            // 
            // Titel_textBox5
            // 
            Titel_textBox5.Location = new Point(110, 36);
            Titel_textBox5.Margin = new Padding(3, 2, 3, 2);
            Titel_textBox5.Name = "Titel_textBox5";
            Titel_textBox5.Size = new Size(419, 26);
            Titel_textBox5.TabIndex = 4;
            // 
            // Genre_textBox4
            // 
            Genre_textBox4.Location = new Point(380, 88);
            Genre_textBox4.Margin = new Padding(3, 2, 3, 2);
            Genre_textBox4.Name = "Genre_textBox4";
            Genre_textBox4.Size = new Size(149, 26);
            Genre_textBox4.TabIndex = 3;
            // 
            // isbn_textBox3
            // 
            isbn_textBox3.Location = new Point(110, 155);
            isbn_textBox3.Margin = new Padding(3, 2, 3, 2);
            isbn_textBox3.Name = "isbn_textBox3";
            isbn_textBox3.Size = new Size(178, 26);
            isbn_textBox3.TabIndex = 2;
            // 
            // Autor_textBox2
            // 
            Autor_textBox2.Location = new Point(110, 88);
            Autor_textBox2.Margin = new Padding(3, 2, 3, 2);
            Autor_textBox2.Name = "Autor_textBox2";
            Autor_textBox2.Size = new Size(178, 26);
            Autor_textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(154, 189, 162);
            button1.Font = new Font("Cascadia Mono", 12F);
            button1.Location = new Point(12, 52);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(183, 37);
            button1.TabIndex = 4;
            button1.Text = "Bücher verleihen";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // MaBuchverwaltungsseite
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 510);
            Controls.Add(button1);
            Controls.Add(zurückButton);
            Controls.Add(tabControl1);
            Controls.Add(bücherAnzeigenButton);
            Controls.Add(buchBearbeitenButton);
            Controls.Add(reservierungenButton);
            Controls.Add(rückgabeButton);
            Controls.Add(buchHinzufügenButton);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MaBuchverwaltungsseite";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dososta Bibliothek";
            tabControl1.ResumeLayout(false);
            Verleihen_tabPage1.ResumeLayout(false);
            Verleihen_tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            Buch_Hinzufügen_tabPage1.ResumeLayout(false);
            Buch_Hinzufügen_tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button rückgabeButton;
        private Button buchBearbeitenButton;
        private TabControl tabControl1;
        private TabPage Verleihen_tabPage1;
        private DataGridView dataGridView1;
        private Button btnAusleihen;
        private Label Name_label1;
        private TextBox NameAusleiher_textBox1;
        private Label label1;
        private Label Titel_labe1;
        private TextBox Titel_textBox1;
        private TextBox Autor_textBox1;
        private Label ID_label2;
        private TextBox Id_textBox1;
        private TextBox AusleihendeMengetextBox1;
        private Label AusleihendeMenglabel2;
        private Button Bücher_button;
        private TabPage Buch_Hinzufügen_tabPage1;
        private TextBox Genre_textBox4;
        private TextBox isbn_textBox3;
        private TextBox Autor_textBox2;
        private Label Menge_label;
        private Label Titel_label;
        private Label Genre_label;
        private Label isbn_label;
        private Label Autor_label;
        private TextBox Menge_textBox6;
        private TextBox Titel_textBox5;
        private Button reservierungenButton;
        private Button buchHinzufügenButton;
        private Button bücherAnzeigenButton;
        private Button zurückButton;
        private Button button1;
    }
}