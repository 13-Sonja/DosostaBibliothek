namespace DosostaApp
{
    partial class MaUserverwaltungsseite
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
            Ändern_button = new Button();
            Clear_button = new Button();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            statusComboBox = new ComboBox();
            vornameTextbox = new TextBox();
            emailTextbox = new TextBox();
            nachnameTextbox = new TextBox();
            User_verwaltung_button = new Button();
            Alle_User_Sehen = new Button();
            zurückButton = new Button();
            nutzerverwaltungGroupbox = new GroupBox();
            groupBox1 = new GroupBox();
            idSuchenTextbox = new TextBox();
            suchenlbl = new Label();
            nutzerverwaltungGroupbox.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            Ändern_button.Click += Ändern_button_Click;
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
            Clear_button.Click += Clear_button_Click;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 105);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 6;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 62);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 5;
            label1.Text = "Nachname";
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
            // vornameTextbox
            // 
            vornameTextbox.Location = new Point(151, 17);
            vornameTextbox.Margin = new Padding(3, 2, 3, 2);
            vornameTextbox.Name = "vornameTextbox";
            vornameTextbox.Size = new Size(252, 26);
            vornameTextbox.TabIndex = 3;
            // 
            // emailTextbox
            // 
            emailTextbox.Location = new Point(151, 100);
            emailTextbox.Margin = new Padding(3, 2, 3, 2);
            emailTextbox.Name = "emailTextbox";
            emailTextbox.Size = new Size(252, 26);
            emailTextbox.TabIndex = 1;
            // 
            // nachnameTextbox
            // 
            nachnameTextbox.Location = new Point(151, 57);
            nachnameTextbox.Margin = new Padding(3, 2, 3, 2);
            nachnameTextbox.Name = "nachnameTextbox";
            nachnameTextbox.Size = new Size(252, 26);
            nachnameTextbox.TabIndex = 0;
            // 
            // User_verwaltung_button
            // 
            User_verwaltung_button.BackColor = Color.FromArgb(195, 214, 199);
            User_verwaltung_button.Font = new Font("Cascadia Mono", 14.25F);
            User_verwaltung_button.Location = new Point(48, 217);
            User_verwaltung_button.Margin = new Padding(3, 2, 3, 2);
            User_verwaltung_button.Name = "User_verwaltung_button";
            User_verwaltung_button.Size = new Size(193, 70);
            User_verwaltung_button.TabIndex = 0;
            User_verwaltung_button.Text = "Nutzerdaten ändern";
            User_verwaltung_button.UseVisualStyleBackColor = false;
            // 
            // Alle_User_Sehen
            // 
            Alle_User_Sehen.BackColor = Color.FromArgb(195, 214, 199);
            Alle_User_Sehen.Font = new Font("Cascadia Mono", 14.25F);
            Alle_User_Sehen.Location = new Point(48, 48);
            Alle_User_Sehen.Margin = new Padding(3, 2, 3, 2);
            Alle_User_Sehen.Name = "Alle_User_Sehen";
            Alle_User_Sehen.Size = new Size(193, 72);
            Alle_User_Sehen.TabIndex = 0;
            Alle_User_Sehen.Text = "Alle Nutzer anzeigen";
            Alle_User_Sehen.UseVisualStyleBackColor = false;
            Alle_User_Sehen.Click += NutzerListe_Click;
            // 
            // zurückButton
            // 
            zurückButton.BackColor = Color.FromArgb(143, 148, 171);
            zurückButton.Font = new Font("Cascadia Mono", 14.25F);
            zurückButton.Location = new Point(48, 381);
            zurückButton.Margin = new Padding(3, 2, 3, 2);
            zurückButton.Name = "zurückButton";
            zurückButton.Size = new Size(193, 55);
            zurückButton.TabIndex = 2;
            zurückButton.Text = "Zurück";
            zurückButton.UseVisualStyleBackColor = false;
            zurückButton.Click += zurückButton_Click;
            // 
            // nutzerverwaltungGroupbox
            // 
            nutzerverwaltungGroupbox.BackColor = Color.FromArgb(250, 227, 204);
            nutzerverwaltungGroupbox.Controls.Add(groupBox1);
            nutzerverwaltungGroupbox.Controls.Add(idSuchenTextbox);
            nutzerverwaltungGroupbox.Controls.Add(suchenlbl);
            nutzerverwaltungGroupbox.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nutzerverwaltungGroupbox.Location = new Point(286, 48);
            nutzerverwaltungGroupbox.Name = "nutzerverwaltungGroupbox";
            nutzerverwaltungGroupbox.Size = new Size(590, 388);
            nutzerverwaltungGroupbox.TabIndex = 3;
            nutzerverwaltungGroupbox.TabStop = false;
            nutzerverwaltungGroupbox.Text = "Nutzerdaten ändern";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 252, 249);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(statusComboBox);
            groupBox1.Controls.Add(Ändern_button);
            groupBox1.Controls.Add(label2);
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
            // idSuchenTextbox
            // 
            idSuchenTextbox.Location = new Point(192, 48);
            idSuchenTextbox.Name = "idSuchenTextbox";
            idSuchenTextbox.Size = new Size(347, 26);
            idSuchenTextbox.TabIndex = 14;
            // 
            // suchenlbl
            // 
            suchenlbl.AutoSize = true;
            suchenlbl.Location = new Point(41, 53);
            suchenlbl.Name = "suchenlbl";
            suchenlbl.Size = new Size(145, 21);
            suchenlbl.TabIndex = 13;
            suchenlbl.Text = "NutzerID suchen";
            // 
            // MaUserverwaltungsseite
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 510);
            Controls.Add(User_verwaltung_button);
            Controls.Add(Alle_User_Sehen);
            Controls.Add(nutzerverwaltungGroupbox);
            Controls.Add(zurückButton);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MaUserverwaltungsseite";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dososta Bibliothek";
            nutzerverwaltungGroupbox.ResumeLayout(false);
            nutzerverwaltungGroupbox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button Ändern_button;
        private Button Clear_button;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private ComboBox statusComboBox;
        private TextBox vornameTextbox;
        private TextBox emailTextbox;
        private TextBox nachnameTextbox;
        private Button User_verwaltung_button;
        private Button Alle_User_Sehen;
        private Button zurückButton;
        private GroupBox nutzerverwaltungGroupbox;
        private GroupBox groupBox1;
        private TextBox idSuchenTextbox;
        private Label suchenlbl;
    }
}