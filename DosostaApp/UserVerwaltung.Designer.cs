namespace DosostaApp
{
    partial class UserVerwaltung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserVerwaltung));
            panel1 = new Panel();
            Alle_User_Sehen = new Button();
            Löschen_button = new Button();
            Edit_User = new Button();
            User_verwaltung_button = new Button();
            groupBox1 = new GroupBox();
            erneuen_button = new Button();
            erstellen_button = new Button();
            statut_comboBox = new ComboBox();
            nachname_textBox = new TextBox();
            Passwort_textBox = new TextBox();
            Email_textBox1 = new TextBox();
            vorname = new TextBox();
            Passwort_label = new Label();
            Statut_label = new Label();
            Email_Label = new Label();
            Name_label = new Label();
            Vorname_label = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(Alle_User_Sehen);
            panel1.Controls.Add(Löschen_button);
            panel1.Controls.Add(Edit_User);
            panel1.Controls.Add(User_verwaltung_button);
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 559);
            panel1.TabIndex = 0;
            // 
            // Alle_User_Sehen
            // 
            Alle_User_Sehen.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Alle_User_Sehen.Location = new Point(9, 372);
            Alle_User_Sehen.Name = "Alle_User_Sehen";
            Alle_User_Sehen.Size = new Size(221, 50);
            Alle_User_Sehen.TabIndex = 0;
            Alle_User_Sehen.Text = "Alle User sehen";
            Alle_User_Sehen.UseVisualStyleBackColor = true;
            // 
            // Löschen_button
            // 
            Löschen_button.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Löschen_button.Location = new Point(9, 277);
            Löschen_button.Name = "Löschen_button";
            Löschen_button.Size = new Size(221, 51);
            Löschen_button.TabIndex = 2;
            Löschen_button.Text = "Löschen";
            Löschen_button.UseVisualStyleBackColor = true;
            // 
            // Edit_User
            // 
            Edit_User.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Edit_User.Location = new Point(9, 172);
            Edit_User.Name = "Edit_User";
            Edit_User.Size = new Size(221, 51);
            Edit_User.TabIndex = 1;
            Edit_User.Text = "Edit User";
            Edit_User.UseVisualStyleBackColor = true;
            // 
            // User_verwaltung_button
            // 
            User_verwaltung_button.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            User_verwaltung_button.Location = new Point(9, 87);
            User_verwaltung_button.Name = "User_verwaltung_button";
            User_verwaltung_button.Size = new Size(221, 47);
            User_verwaltung_button.TabIndex = 0;
            User_verwaltung_button.Text = "Userverwaltung";
            User_verwaltung_button.UseVisualStyleBackColor = true;
            User_verwaltung_button.Click += User_verwaltung_button_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(erneuen_button);
            groupBox1.Controls.Add(erstellen_button);
            groupBox1.Controls.Add(statut_comboBox);
            groupBox1.Controls.Add(nachname_textBox);
            groupBox1.Controls.Add(Passwort_textBox);
            groupBox1.Controls.Add(Email_textBox1);
            groupBox1.Controls.Add(vorname);
            groupBox1.Controls.Add(Passwort_label);
            groupBox1.Controls.Add(Statut_label);
            groupBox1.Controls.Add(Email_Label);
            groupBox1.Controls.Add(Name_label);
            groupBox1.Controls.Add(Vorname_label);
            groupBox1.Font = new Font("Cascadia Mono SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(285, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(554, 525);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informationen der neue User eingeben";
            // 
            // erneuen_button
            // 
            erneuen_button.BackColor = Color.Red;
            erneuen_button.Location = new Point(383, 449);
            erneuen_button.Name = "erneuen_button";
            erneuen_button.Size = new Size(151, 48);
            erneuen_button.TabIndex = 15;
            erneuen_button.Text = "erneuen";
            erneuen_button.UseVisualStyleBackColor = false;
            
            // 
            // erstellen_button
            // 
            erstellen_button.BackColor = Color.Aquamarine;
            erstellen_button.Location = new Point(108, 449);
            erstellen_button.Name = "erstellen_button";
            erstellen_button.Size = new Size(137, 48);
            erstellen_button.TabIndex = 14;
            erstellen_button.Text = "erstellen";
            erstellen_button.UseVisualStyleBackColor = false;
            erstellen_button.Click += erstellen_button_Click;
            // 
            // statut_comboBox
            // 
            statut_comboBox.FormattingEnabled = true;
            statut_comboBox.Items.AddRange(new object[] { "Kunde", "Mitarbeiter", "Admin" });
            statut_comboBox.Location = new Point(383, 240);
            statut_comboBox.Name = "statut_comboBox";
            statut_comboBox.Size = new Size(151, 35);
            statut_comboBox.TabIndex = 13;
            // 
            // nachname_textBox
            // 
            nachname_textBox.Location = new Point(383, 159);
            nachname_textBox.Name = "nachname_textBox";
            nachname_textBox.Size = new Size(125, 31);
            nachname_textBox.TabIndex = 12;
            // 
            // Passwort_textBox
            // 
            Passwort_textBox.Location = new Point(131, 335);
            Passwort_textBox.Name = "Passwort_textBox";
            Passwort_textBox.Size = new Size(125, 31);
            Passwort_textBox.TabIndex = 11;
            Passwort_textBox.TextChanged += Passwort_textBox_TextChanged;
            // 
            // Email_textBox1
            // 
            Email_textBox1.Location = new Point(108, 240);
            Email_textBox1.Name = "Email_textBox1";
            Email_textBox1.Size = new Size(125, 31);
            Email_textBox1.TabIndex = 10;
            Email_textBox1.TextChanged += Email_textBox1_TextChanged;
            // 
            // vorname
            // 
            vorname.Location = new Point(108, 158);
            vorname.Name = "vorname";
            vorname.Size = new Size(125, 31);
            vorname.TabIndex = 5;
            // 
            // Passwort_label
            // 
            Passwort_label.AutoSize = true;
            Passwort_label.Location = new Point(6, 338);
            Passwort_label.Name = "Passwort_label";
            Passwort_label.Size = new Size(108, 27);
            Passwort_label.TabIndex = 4;
            Passwort_label.Text = "Passwort";
            // 
            // Statut_label
            // 
            Statut_label.AutoSize = true;
            Statut_label.Location = new Point(279, 240);
            Statut_label.Name = "Statut_label";
            Statut_label.Size = new Size(84, 27);
            Statut_label.TabIndex = 3;
            Statut_label.Text = "Statut";
            // 
            // Email_Label
            // 
            Email_Label.AutoSize = true;
            Email_Label.Location = new Point(6, 239);
            Email_Label.Name = "Email_Label";
            Email_Label.Size = new Size(72, 27);
            Email_Label.TabIndex = 2;
            Email_Label.Text = "Email";
            // 
            // Name_label
            // 
            Name_label.AutoSize = true;
            Name_label.Location = new Point(269, 162);
            Name_label.Name = "Name_label";
            Name_label.Size = new Size(108, 27);
            Name_label.TabIndex = 1;
            Name_label.Text = "Nachname";
            // 
            // Vorname_label
            // 
            Vorname_label.AutoSize = true;
            Vorname_label.Location = new Point(6, 162);
            Vorname_label.Name = "Vorname_label";
            Vorname_label.Size = new Size(96, 27);
            Vorname_label.TabIndex = 0;
            Vorname_label.Text = "Vorname";
            // 
            // UserVerwaltung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 549);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "UserVerwaltung";
            Text = "UserVerwaltung";
            Load += UserVerwaltung_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button Edit_User;
        private Button User_verwaltung_button;
        private Button Löschen_button;
        private Button Alle_User_Sehen;
        private GroupBox groupBox1;
        private Label Vorname_label;
        private Label Statut_label;
        private Label Email_Label;
        private Label Name_label;
        private Label Passwort_label;
        private TextBox vorname;
        private TextBox Passwort_textBox;
        private TextBox Email_textBox1;
        private ComboBox statut_comboBox;
        private TextBox nachname_textBox;
        private Button erstellen_button;
        private Button erneuen_button;
    }
}