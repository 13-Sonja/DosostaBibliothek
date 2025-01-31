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
            Ausleihen_tabPage1 = new TabPage();
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
            buchverwaltungGroupbox = new GroupBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            statusComboBox = new ComboBox();
            Ändern_button = new Button();
            label3 = new Label();
            vornameTextbox = new TextBox();
            Clear_button = new Button();
            nachnameTextbox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            emailTextbox = new TextBox();
            idSuchenTextbox = new TextBox();
            suchenlbl = new Label();
            tabControl1.SuspendLayout();
            Ausleihen_tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            Buch_Hinzufügen_tabPage1.SuspendLayout();
            buchverwaltungGroupbox.SuspendLayout();
            groupBox1.SuspendLayout();
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
            bücherAnzeigenButton.Location = new Point(12, 20);
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
            reservierungenButton.Location = new Point(12, 301);
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
            buchHinzufügenButton.Location = new Point(12, 135);
            buchHinzufügenButton.Margin = new Padding(3, 2, 3, 2);
            buchHinzufügenButton.Name = "buchHinzufügenButton";
            buchHinzufügenButton.Size = new Size(183, 39);
            buchHinzufügenButton.TabIndex = 2;
            buchHinzufügenButton.Text = "Buch hinzufügen";
            buchHinzufügenButton.UseVisualStyleBackColor = false;
            // 
            // rückgabeButton
            // 
            rückgabeButton.BackColor = Color.FromArgb(195, 214, 199);
            rückgabeButton.Font = new Font("Cascadia Mono", 12F);
            rückgabeButton.Location = new Point(12, 229);
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
            buchBearbeitenButton.Location = new Point(12, 80);
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
            Bücher_button.Location = new Point(346, 253);
            Bücher_button.Margin = new Padding(3, 2, 3, 2);
            Bücher_button.Name = "Bücher_button";
            Bücher_button.Size = new Size(183, 41);
            Bücher_button.TabIndex = 2;
            Bücher_button.Text = " Hinzufügen";
            Bücher_button.UseVisualStyleBackColor = true;
            Bücher_button.Click += Bücher_button_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Ausleihen_tabPage1);
            tabControl1.Controls.Add(Buch_Hinzufügen_tabPage1);
            tabControl1.Location = new Point(316, 454);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(586, 380);
            tabControl1.TabIndex = 1;
            // 
            // Ausleihen_tabPage1
            // 
            Ausleihen_tabPage1.Controls.Add(AusleihendeMenglabel2);
            Ausleihen_tabPage1.Controls.Add(ID_label2);
            Ausleihen_tabPage1.Controls.Add(Id_textBox1);
            Ausleihen_tabPage1.Controls.Add(AusleihendeMengetextBox1);
            Ausleihen_tabPage1.Controls.Add(label1);
            Ausleihen_tabPage1.Controls.Add(Titel_labe1);
            Ausleihen_tabPage1.Controls.Add(Titel_textBox1);
            Ausleihen_tabPage1.Controls.Add(Autor_textBox1);
            Ausleihen_tabPage1.Controls.Add(Name_label1);
            Ausleihen_tabPage1.Controls.Add(NameAusleiher_textBox1);
            Ausleihen_tabPage1.Controls.Add(btnAusleihen);
            Ausleihen_tabPage1.Controls.Add(dataGridView1);
            Ausleihen_tabPage1.Location = new Point(4, 24);
            Ausleihen_tabPage1.Margin = new Padding(3, 2, 3, 2);
            Ausleihen_tabPage1.Name = "Ausleihen_tabPage1";
            Ausleihen_tabPage1.Padding = new Padding(3, 2, 3, 2);
            Ausleihen_tabPage1.Size = new Size(578, 352);
            Ausleihen_tabPage1.TabIndex = 0;
            Ausleihen_tabPage1.Text = "Ausleihen";
            Ausleihen_tabPage1.UseVisualStyleBackColor = true;
            // 
            // AusleihendeMenglabel2
            // 
            AusleihendeMenglabel2.AutoSize = true;
            AusleihendeMenglabel2.Location = new Point(234, 126);
            AusleihendeMenglabel2.Name = "AusleihendeMenglabel2";
            AusleihendeMenglabel2.Size = new Size(44, 15);
            AusleihendeMenglabel2.TabIndex = 11;
            AusleihendeMenglabel2.Text = "Menge";
            // 
            // ID_label2
            // 
            ID_label2.AutoSize = true;
            ID_label2.Location = new Point(12, 172);
            ID_label2.Name = "ID_label2";
            ID_label2.Size = new Size(18, 15);
            ID_label2.TabIndex = 10;
            ID_label2.Text = "ID";
            // 
            // Id_textBox1
            // 
            Id_textBox1.Location = new Point(64, 168);
            Id_textBox1.Margin = new Padding(3, 2, 3, 2);
            Id_textBox1.Name = "Id_textBox1";
            Id_textBox1.Size = new Size(110, 23);
            Id_textBox1.TabIndex = 9;
            // 
            // AusleihendeMengetextBox1
            // 
            AusleihendeMengetextBox1.Location = new Point(288, 123);
            AusleihendeMengetextBox1.Margin = new Padding(3, 2, 3, 2);
            AusleihendeMengetextBox1.Name = "AusleihendeMengetextBox1";
            AusleihendeMengetextBox1.Size = new Size(110, 23);
            AusleihendeMengetextBox1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 128);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 7;
            label1.Text = "Autor";
            // 
            // Titel_labe1
            // 
            Titel_labe1.AutoSize = true;
            Titel_labe1.Location = new Point(234, 82);
            Titel_labe1.Name = "Titel_labe1";
            Titel_labe1.Size = new Size(29, 15);
            Titel_labe1.TabIndex = 6;
            Titel_labe1.Text = "Titel";
            // 
            // Titel_textBox1
            // 
            Titel_textBox1.Location = new Point(288, 77);
            Titel_textBox1.Margin = new Padding(3, 2, 3, 2);
            Titel_textBox1.Name = "Titel_textBox1";
            Titel_textBox1.Size = new Size(110, 23);
            Titel_textBox1.TabIndex = 5;
            // 
            // Autor_textBox1
            // 
            Autor_textBox1.Location = new Point(64, 124);
            Autor_textBox1.Margin = new Padding(3, 2, 3, 2);
            Autor_textBox1.Name = "Autor_textBox1";
            Autor_textBox1.Size = new Size(110, 23);
            Autor_textBox1.TabIndex = 4;
            // 
            // Name_label1
            // 
            Name_label1.AutoSize = true;
            Name_label1.Location = new Point(0, 77);
            Name_label1.Name = "Name_label1";
            Name_label1.Size = new Size(41, 15);
            Name_label1.TabIndex = 3;
            Name_label1.Text = "UserID";
            // 
            // NameAusleiher_textBox1
            // 
            NameAusleiher_textBox1.Location = new Point(64, 75);
            NameAusleiher_textBox1.Margin = new Padding(3, 2, 3, 2);
            NameAusleiher_textBox1.Name = "NameAusleiher_textBox1";
            NameAusleiher_textBox1.Size = new Size(101, 23);
            NameAusleiher_textBox1.TabIndex = 2;
            // 
            // btnAusleihen
            // 
            btnAusleihen.Location = new Point(288, 172);
            btnAusleihen.Margin = new Padding(3, 2, 3, 2);
            btnAusleihen.Name = "btnAusleihen";
            btnAusleihen.Size = new Size(82, 22);
            btnAusleihen.TabIndex = 1;
            btnAusleihen.Text = "Ausleihen";
            btnAusleihen.UseVisualStyleBackColor = true;
            btnAusleihen.Click += btnAusleihen_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 209);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(400, 141);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Buch_Hinzufügen_tabPage1
            // 
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
            Buch_Hinzufügen_tabPage1.Location = new Point(4, 24);
            Buch_Hinzufügen_tabPage1.Margin = new Padding(3, 2, 3, 2);
            Buch_Hinzufügen_tabPage1.Name = "Buch_Hinzufügen_tabPage1";
            Buch_Hinzufügen_tabPage1.Padding = new Padding(3, 2, 3, 2);
            Buch_Hinzufügen_tabPage1.Size = new Size(578, 352);
            Buch_Hinzufügen_tabPage1.TabIndex = 2;
            Buch_Hinzufügen_tabPage1.Text = "Bücher Hinzufügen";
            Buch_Hinzufügen_tabPage1.UseVisualStyleBackColor = true;
            // 
            // Menge_label
            // 
            Menge_label.AutoSize = true;
            Menge_label.Location = new Point(58, 214);
            Menge_label.Name = "Menge_label";
            Menge_label.Size = new Size(44, 15);
            Menge_label.TabIndex = 11;
            Menge_label.Text = "Menge";
            // 
            // Titel_label
            // 
            Titel_label.AutoSize = true;
            Titel_label.Location = new Point(379, 148);
            Titel_label.Name = "Titel_label";
            Titel_label.Size = new Size(29, 15);
            Titel_label.TabIndex = 10;
            Titel_label.Text = "Titel";
            // 
            // Genre_label
            // 
            Genre_label.AutoSize = true;
            Genre_label.Location = new Point(379, 93);
            Genre_label.Name = "Genre_label";
            Genre_label.Size = new Size(38, 15);
            Genre_label.TabIndex = 9;
            Genre_label.Text = "Genre";
            // 
            // isbn_label
            // 
            isbn_label.AutoSize = true;
            isbn_label.Location = new Point(58, 154);
            isbn_label.Name = "isbn_label";
            isbn_label.Size = new Size(32, 15);
            isbn_label.TabIndex = 8;
            isbn_label.Text = "ISBN";
            // 
            // Autor_label
            // 
            Autor_label.AutoSize = true;
            Autor_label.Location = new Point(58, 93);
            Autor_label.Name = "Autor_label";
            Autor_label.Size = new Size(37, 15);
            Autor_label.TabIndex = 7;
            Autor_label.Text = "Autor";
            // 
            // Menge_textBox6
            // 
            Menge_textBox6.Location = new Point(123, 212);
            Menge_textBox6.Margin = new Padding(3, 2, 3, 2);
            Menge_textBox6.Name = "Menge_textBox6";
            Menge_textBox6.Size = new Size(110, 23);
            Menge_textBox6.TabIndex = 5;
            // 
            // Titel_textBox5
            // 
            Titel_textBox5.Location = new Point(444, 143);
            Titel_textBox5.Margin = new Padding(3, 2, 3, 2);
            Titel_textBox5.Name = "Titel_textBox5";
            Titel_textBox5.Size = new Size(110, 23);
            Titel_textBox5.TabIndex = 4;
            // 
            // Genre_textBox4
            // 
            Genre_textBox4.Location = new Point(444, 88);
            Genre_textBox4.Margin = new Padding(3, 2, 3, 2);
            Genre_textBox4.Name = "Genre_textBox4";
            Genre_textBox4.Size = new Size(110, 23);
            Genre_textBox4.TabIndex = 3;
            // 
            // isbn_textBox3
            // 
            isbn_textBox3.Location = new Point(123, 148);
            isbn_textBox3.Margin = new Padding(3, 2, 3, 2);
            isbn_textBox3.Name = "isbn_textBox3";
            isbn_textBox3.Size = new Size(110, 23);
            isbn_textBox3.TabIndex = 2;
            // 
            // Autor_textBox2
            // 
            Autor_textBox2.Location = new Point(123, 88);
            Autor_textBox2.Margin = new Padding(3, 2, 3, 2);
            Autor_textBox2.Name = "Autor_textBox2";
            Autor_textBox2.Size = new Size(110, 23);
            Autor_textBox2.TabIndex = 1;
            // 
            // buchverwaltungGroupbox
            // 
            buchverwaltungGroupbox.BackColor = Color.FromArgb(250, 227, 204);
            buchverwaltungGroupbox.Controls.Add(groupBox1);
            buchverwaltungGroupbox.Controls.Add(idSuchenTextbox);
            buchverwaltungGroupbox.Controls.Add(suchenlbl);
            buchverwaltungGroupbox.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buchverwaltungGroupbox.Location = new Point(275, 29);
            buchverwaltungGroupbox.Name = "buchverwaltungGroupbox";
            buchverwaltungGroupbox.Size = new Size(590, 388);
            buchverwaltungGroupbox.TabIndex = 4;
            buchverwaltungGroupbox.TabStop = false;
            buchverwaltungGroupbox.Text = "Buchverwaltung";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 252, 249);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(statusComboBox);
            groupBox1.Controls.Add(Ändern_button);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(vornameTextbox);
            groupBox1.Controls.Add(Clear_button);
            groupBox1.Controls.Add(nachnameTextbox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(emailTextbox);
            groupBox1.Location = new Point(41, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(498, 278);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 62);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 5;
            label2.Text = "Nachname";
            // 
            // statusComboBox
            // 
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Items.AddRange(new object[] { "Kunde", "Mitarbeiter", "Admin" });
            statusComboBox.Location = new Point(151, 145);
            statusComboBox.Margin = new Padding(3, 2, 3, 2);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(252, 29);
            statusComboBox.TabIndex = 4;
            // 
            // Ändern_button
            // 
            Ändern_button.BackColor = Color.FromArgb(195, 214, 199);
            Ändern_button.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Ändern_button.Location = new Point(260, 210);
            Ändern_button.Margin = new Padding(3, 2, 3, 2);
            Ändern_button.Name = "Ändern_button";
            Ändern_button.Size = new Size(143, 47);
            Ändern_button.TabIndex = 12;
            Ändern_button.Text = "Ändern";
            Ändern_button.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 105);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 6;
            label3.Text = "Email";
            // 
            // vornameTextbox
            // 
            vornameTextbox.Location = new Point(151, 17);
            vornameTextbox.Margin = new Padding(3, 2, 3, 2);
            vornameTextbox.Name = "vornameTextbox";
            vornameTextbox.Size = new Size(252, 26);
            vornameTextbox.TabIndex = 3;
            // 
            // Clear_button
            // 
            Clear_button.BackColor = Color.FromArgb(143, 148, 171);
            Clear_button.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Clear_button.Location = new Point(52, 210);
            Clear_button.Margin = new Padding(3, 2, 3, 2);
            Clear_button.Name = "Clear_button";
            Clear_button.Size = new Size(129, 48);
            Clear_button.TabIndex = 11;
            Clear_button.Text = "Clear";
            Clear_button.UseVisualStyleBackColor = false;
            // 
            // nachnameTextbox
            // 
            nachnameTextbox.Location = new Point(151, 57);
            nachnameTextbox.Margin = new Padding(3, 2, 3, 2);
            nachnameTextbox.Name = "nachnameTextbox";
            nachnameTextbox.Size = new Size(252, 26);
            nachnameTextbox.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 153);
            label5.Name = "label5";
            label5.Size = new Size(64, 21);
            label5.TabIndex = 9;
            label5.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 22);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 8;
            label4.Text = "Vorname";
            // 
            // emailTextbox
            // 
            emailTextbox.Location = new Point(151, 100);
            emailTextbox.Margin = new Padding(3, 2, 3, 2);
            emailTextbox.Name = "emailTextbox";
            emailTextbox.Size = new Size(252, 26);
            emailTextbox.TabIndex = 1;
            // 
            // idSuchenTextbox
            // 
            idSuchenTextbox.Location = new Point(174, 48);
            idSuchenTextbox.Name = "idSuchenTextbox";
            idSuchenTextbox.Size = new Size(365, 26);
            idSuchenTextbox.TabIndex = 14;
            // 
            // suchenlbl
            // 
            suchenlbl.AutoSize = true;
            suchenlbl.Location = new Point(41, 53);
            suchenlbl.Name = "suchenlbl";
            suchenlbl.Size = new Size(127, 21);
            suchenlbl.TabIndex = 13;
            suchenlbl.Text = "BuchID suchen";
            // 
            // MaBuchverwaltungsseite
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 510);
            Controls.Add(buchverwaltungGroupbox);
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
            Ausleihen_tabPage1.ResumeLayout(false);
            Ausleihen_tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            Buch_Hinzufügen_tabPage1.ResumeLayout(false);
            Buch_Hinzufügen_tabPage1.PerformLayout();
            buchverwaltungGroupbox.ResumeLayout(false);
            buchverwaltungGroupbox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button rückgabeButton;
        private Button buchBearbeitenButton;
        private TabControl tabControl1;
        private TabPage Ausleihen_tabPage1;
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
        private GroupBox buchverwaltungGroupbox;
        private GroupBox groupBox1;
        private Label label2;
        private ComboBox statusComboBox;
        private Button Ändern_button;
        private Label label3;
        private TextBox vornameTextbox;
        private Button Clear_button;
        private TextBox nachnameTextbox;
        private Label label5;
        private Label label4;
        private TextBox emailTextbox;
        private TextBox idSuchenTextbox;
        private Label suchenlbl;
    }
}