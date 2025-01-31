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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            Ändern_button = new Button();
            Clear_button = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            statut_comboBox = new ComboBox();
            vorname = new TextBox();
            Passwort_textBox = new TextBox();
            Email_textBox1 = new TextBox();
            nachname_textBox = new TextBox();
            tabPage2 = new TabPage();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
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
            User_verwaltung_button.Click += User_verwaltung_button_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tabControl1);
            groupBox1.Location = new Point(289, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(733, 525);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(27, 142);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(700, 345);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(Ändern_button);
            tabPage1.Controls.Add(Clear_button);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(statut_comboBox);
            tabPage1.Controls.Add(vorname);
            tabPage1.Controls.Add(Passwort_textBox);
            tabPage1.Controls.Add(Email_textBox1);
            tabPage1.Controls.Add(nachname_textBox);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(692, 312);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Hinzufügen";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Ändern_button
            // 
            Ändern_button.Location = new Point(363, 247);
            Ändern_button.Name = "Ändern_button";
            Ändern_button.Size = new Size(94, 29);
            Ändern_button.TabIndex = 12;
            Ändern_button.Text = "Hinfügen";
            Ändern_button.UseVisualStyleBackColor = true;
            Ändern_button.Click += Ändern_button_Click;
            // 
            // Clear_button
            // 
            Clear_button.Location = new Point(501, 246);
            Clear_button.Name = "Clear_button";
            Clear_button.Size = new Size(94, 29);
            Clear_button.TabIndex = 11;
            Clear_button.Text = "Clear";
            Clear_button.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(321, 153);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 9;
            label5.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(335, 76);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 8;
            label4.Text = "Vorname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 255);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 7;
            label3.Text = "Passwort";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 172);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 6;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 77);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // statut_comboBox
            // 
            statut_comboBox.FormattingEnabled = true;
            statut_comboBox.Items.AddRange(new object[] { "Kunde", "Mitarbeiter", "Admin" });
            statut_comboBox.Location = new Point(394, 150);
            statut_comboBox.Name = "statut_comboBox";
            statut_comboBox.Size = new Size(151, 28);
            statut_comboBox.TabIndex = 4;
            // 
            // vorname
            // 
            vorname.Location = new Point(420, 70);
            vorname.Name = "vorname";
            vorname.Size = new Size(125, 27);
            vorname.TabIndex = 3;
            // 
            // Passwort_textBox
            // 
            Passwort_textBox.Location = new Point(78, 248);
            Passwort_textBox.Name = "Passwort_textBox";
            Passwort_textBox.Size = new Size(125, 27);
            Passwort_textBox.TabIndex = 2;
            // 
            // Email_textBox1
            // 
            Email_textBox1.Location = new Point(76, 165);
            Email_textBox1.Name = "Email_textBox1";
            Email_textBox1.Size = new Size(125, 27);
            Email_textBox1.TabIndex = 1;
            // 
            // nachname_textBox
            // 
            nachname_textBox.Location = new Point(76, 73);
            nachname_textBox.Name = "nachname_textBox";
            nachname_textBox.Size = new Size(125, 27);
            nachname_textBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(692, 312);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // UserVerwaltung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 549);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "UserVerwaltung";
            Text = "UserVerwaltung";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button Edit_User;
        private Button User_verwaltung_button;
        private Button Löschen_button;
        private Button Alle_User_Sehen;
        private GroupBox groupBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox vorname;
        private TextBox Passwort_textBox;
        private TextBox Email_textBox1;
        private TextBox nachname_textBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox statut_comboBox;
        private Button Clear_button;
        private Button Ändern_button;
       
    }
}