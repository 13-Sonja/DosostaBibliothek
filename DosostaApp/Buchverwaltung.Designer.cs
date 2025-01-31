namespace DosostaApp
{
    partial class Buchverwaltung
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
            panel1 = new Panel();
            Zurückgeben = new Button();
            Ausleihen = new Button();
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
            Zurückgeben_tabPage2 = new TabPage();
            button1 = new Button();
            dataGridView2 = new DataGridView();
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
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            Ausleihen_tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            Zurückgeben_tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            Buch_Hinzufügen_tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.bg4;
            panel1.Controls.Add(Zurückgeben);
            panel1.Controls.Add(Ausleihen);
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 607);
            panel1.TabIndex = 0;
            // 
            // Zurückgeben
            // 
            Zurückgeben.Location = new Point(25, 218);
            Zurückgeben.Name = "Zurückgeben";
            Zurückgeben.Size = new Size(209, 82);
            Zurückgeben.TabIndex = 1;
            Zurückgeben.Text = "Bücher Zurückgeben";
            Zurückgeben.UseVisualStyleBackColor = true;
            Zurückgeben.Click += Zurückgeben_Click;
            // 
            // Ausleihen
            // 
            Ausleihen.Location = new Point(25, 79);
            Ausleihen.Name = "Ausleihen";
            Ausleihen.Size = new Size(209, 77);
            Ausleihen.TabIndex = 0;
            Ausleihen.Text = "Bücher Ausleihen";
            Ausleihen.UseVisualStyleBackColor = true;
            Ausleihen.Click += Ausleihen_Click;
            // 
            // Bücher_button
            // 
            Bücher_button.Location = new Point(396, 337);
            Bücher_button.Name = "Bücher_button";
            Bücher_button.Size = new Size(209, 55);
            Bücher_button.TabIndex = 2;
            Bücher_button.Text = " Hinzufügen";
            Bücher_button.UseVisualStyleBackColor = true;
            Bücher_button.Click += Bücher_button_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Ausleihen_tabPage1);
            tabControl1.Controls.Add(Zurückgeben_tabPage2);
            tabControl1.Controls.Add(Buch_Hinzufügen_tabPage1);
            tabControl1.Location = new Point(303, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(670, 506);
            tabControl1.TabIndex = 1;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
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
            Ausleihen_tabPage1.Location = new Point(4, 29);
            Ausleihen_tabPage1.Name = "Ausleihen_tabPage1";
            Ausleihen_tabPage1.Padding = new Padding(3);
            Ausleihen_tabPage1.Size = new Size(662, 473);
            Ausleihen_tabPage1.TabIndex = 0;
            Ausleihen_tabPage1.Text = "Ausleihen";
            Ausleihen_tabPage1.UseVisualStyleBackColor = true;
            Ausleihen_tabPage1.Click += Ausleihen_tabPage1_Click;
            // 
            // AusleihendeMenglabel2
            // 
            AusleihendeMenglabel2.AutoSize = true;
            AusleihendeMenglabel2.Location = new Point(267, 168);
            AusleihendeMenglabel2.Name = "AusleihendeMenglabel2";
            AusleihendeMenglabel2.Size = new Size(55, 20);
            AusleihendeMenglabel2.TabIndex = 11;
            AusleihendeMenglabel2.Text = "Menge";
            // 
            // ID_label2
            // 
            ID_label2.AutoSize = true;
            ID_label2.Location = new Point(14, 229);
            ID_label2.Name = "ID_label2";
            ID_label2.Size = new Size(24, 20);
            ID_label2.TabIndex = 10;
            ID_label2.Text = "ID";
            // 
            // Id_textBox1
            // 
            Id_textBox1.Location = new Point(73, 224);
            Id_textBox1.Name = "Id_textBox1";
            Id_textBox1.Size = new Size(125, 27);
            Id_textBox1.TabIndex = 9;
            // 
            // AusleihendeMengetextBox1
            // 
            AusleihendeMengetextBox1.Location = new Point(329, 164);
            AusleihendeMengetextBox1.Name = "AusleihendeMengetextBox1";
            AusleihendeMengetextBox1.Size = new Size(125, 27);
            AusleihendeMengetextBox1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 171);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 7;
            label1.Text = "Autor";
            // 
            // Titel_labe1
            // 
            Titel_labe1.AutoSize = true;
            Titel_labe1.Location = new Point(267, 109);
            Titel_labe1.Name = "Titel_labe1";
            Titel_labe1.Size = new Size(38, 20);
            Titel_labe1.TabIndex = 6;
            Titel_labe1.Text = "Titel";
            // 
            // Titel_textBox1
            // 
            Titel_textBox1.Location = new Point(329, 103);
            Titel_textBox1.Name = "Titel_textBox1";
            Titel_textBox1.Size = new Size(125, 27);
            Titel_textBox1.TabIndex = 5;
            // 
            // Autor_textBox1
            // 
            Autor_textBox1.Location = new Point(73, 165);
            Autor_textBox1.Name = "Autor_textBox1";
            Autor_textBox1.Size = new Size(125, 27);
            Autor_textBox1.TabIndex = 4;
            // 
            // Name_label1
            // 
            Name_label1.AutoSize = true;
            Name_label1.Location = new Point(0, 103);
            Name_label1.Name = "Name_label1";
            Name_label1.Size = new Size(53, 20);
            Name_label1.TabIndex = 3;
            Name_label1.Text = "UserID";
            // 
            // NameAusleiher_textBox1
            // 
            NameAusleiher_textBox1.Location = new Point(73, 100);
            NameAusleiher_textBox1.Name = "NameAusleiher_textBox1";
            NameAusleiher_textBox1.Size = new Size(115, 27);
            NameAusleiher_textBox1.TabIndex = 2;
            // 
            // btnAusleihen
            // 
            btnAusleihen.Location = new Point(329, 229);
            btnAusleihen.Name = "btnAusleihen";
            btnAusleihen.Size = new Size(94, 29);
            btnAusleihen.TabIndex = 1;
            btnAusleihen.Text = "Ausleihen";
            btnAusleihen.UseVisualStyleBackColor = true;
            btnAusleihen.Click += btnAusleihen_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 279);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(457, 188);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Zurückgeben_tabPage2
            // 
            Zurückgeben_tabPage2.Controls.Add(button1);
            Zurückgeben_tabPage2.Controls.Add(dataGridView2);
            Zurückgeben_tabPage2.Location = new Point(4, 29);
            Zurückgeben_tabPage2.Name = "Zurückgeben_tabPage2";
            Zurückgeben_tabPage2.Padding = new Padding(3);
            Zurückgeben_tabPage2.Size = new Size(662, 473);
            Zurückgeben_tabPage2.TabIndex = 1;
            Zurückgeben_tabPage2.Text = "Zurückgeben";
            Zurückgeben_tabPage2.UseVisualStyleBackColor = true;
            Zurückgeben_tabPage2.Click += Zurückgeben_tabPage2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(142, 96);
            button1.Name = "button1";
            button1.Size = new Size(101, 29);
            button1.TabIndex = 1;
            button1.Text = "Rückgabe";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(0, 282);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(464, 188);
            dataGridView2.TabIndex = 0;
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
            Buch_Hinzufügen_tabPage1.Location = new Point(4, 29);
            Buch_Hinzufügen_tabPage1.Name = "Buch_Hinzufügen_tabPage1";
            Buch_Hinzufügen_tabPage1.Padding = new Padding(3);
            Buch_Hinzufügen_tabPage1.Size = new Size(662, 473);
            Buch_Hinzufügen_tabPage1.TabIndex = 2;
            Buch_Hinzufügen_tabPage1.Text = "Bücher Hinzufügen";
            Buch_Hinzufügen_tabPage1.UseVisualStyleBackColor = true;
            // 
            // Menge_label
            // 
            Menge_label.AutoSize = true;
            Menge_label.Location = new Point(66, 285);
            Menge_label.Name = "Menge_label";
            Menge_label.Size = new Size(55, 20);
            Menge_label.TabIndex = 11;
            Menge_label.Text = "Menge";
            // 
            // Titel_label
            // 
            Titel_label.AutoSize = true;
            Titel_label.Location = new Point(433, 198);
            Titel_label.Name = "Titel_label";
            Titel_label.Size = new Size(38, 20);
            Titel_label.TabIndex = 10;
            Titel_label.Text = "Titel";
            // 
            // Genre_label
            // 
            Genre_label.AutoSize = true;
            Genre_label.Location = new Point(433, 124);
            Genre_label.Name = "Genre_label";
            Genre_label.Size = new Size(48, 20);
            Genre_label.TabIndex = 9;
            Genre_label.Text = "Genre";
            // 
            // isbn_label
            // 
            isbn_label.AutoSize = true;
            isbn_label.Location = new Point(66, 205);
            isbn_label.Name = "isbn_label";
            isbn_label.Size = new Size(41, 20);
            isbn_label.TabIndex = 8;
            isbn_label.Text = "ISBN";
            isbn_label.Click += isbn_label_Click;
            // 
            // Autor_label
            // 
            Autor_label.AutoSize = true;
            Autor_label.Location = new Point(66, 124);
            Autor_label.Name = "Autor_label";
            Autor_label.Size = new Size(46, 20);
            Autor_label.TabIndex = 7;
            Autor_label.Text = "Autor";
            // 
            // Menge_textBox6
            // 
            Menge_textBox6.Location = new Point(141, 282);
            Menge_textBox6.Name = "Menge_textBox6";
            Menge_textBox6.Size = new Size(125, 27);
            Menge_textBox6.TabIndex = 5;
            // 
            // Titel_textBox5
            // 
            Titel_textBox5.Location = new Point(507, 191);
            Titel_textBox5.Name = "Titel_textBox5";
            Titel_textBox5.Size = new Size(125, 27);
            Titel_textBox5.TabIndex = 4;
            // 
            // Genre_textBox4
            // 
            Genre_textBox4.Location = new Point(507, 117);
            Genre_textBox4.Name = "Genre_textBox4";
            Genre_textBox4.Size = new Size(125, 27);
            Genre_textBox4.TabIndex = 3;
            // 
            // isbn_textBox3
            // 
            isbn_textBox3.Location = new Point(141, 198);
            isbn_textBox3.Name = "isbn_textBox3";
            isbn_textBox3.Size = new Size(125, 27);
            isbn_textBox3.TabIndex = 2;
            // 
            // Autor_textBox2
            // 
            Autor_textBox2.Location = new Point(141, 117);
            Autor_textBox2.Name = "Autor_textBox2";
            Autor_textBox2.Size = new Size(125, 27);
            Autor_textBox2.TabIndex = 1;
            // 
            // Buchverwaltung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 545);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "Buchverwaltung";
            Text = "Buchverwaltung";
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            Ausleihen_tabPage1.ResumeLayout(false);
            Ausleihen_tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            Zurückgeben_tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            Buch_Hinzufügen_tabPage1.ResumeLayout(false);
            Buch_Hinzufügen_tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button Zurückgeben;
        private Button Ausleihen;
        private TabControl tabControl1;
        private TabPage Ausleihen_tabPage1;
        private TabPage Zurückgeben_tabPage2;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button btnAusleihen;
        private Button button1;
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
    }
}