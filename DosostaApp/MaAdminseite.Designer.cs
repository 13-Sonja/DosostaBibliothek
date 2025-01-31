namespace DosostaApp
{
    partial class MaAdminseite
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
            groupBox1 = new GroupBox();
            Ausleihen_verwalten_button = new Button();
            Beanachrichtigungen_senden_button = new Button();
            Reservierungen_verwalten_button = new Button();
            Buchverwaltung_button = new Button();
            Benutzerverwaltungbutton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Ausleihen_verwalten_button);
            groupBox1.Controls.Add(Beanachrichtigungen_senden_button);
            groupBox1.Controls.Add(Reservierungen_verwalten_button);
            groupBox1.Controls.Add(Buchverwaltung_button);
            groupBox1.Controls.Add(Benutzerverwaltungbutton);
            groupBox1.Location = new Point(153, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(615, 406);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // Ausleihen_verwalten_button
            // 
            Ausleihen_verwalten_button.Location = new Point(381, 205);
            Ausleihen_verwalten_button.Name = "Ausleihen_verwalten_button";
            Ausleihen_verwalten_button.Size = new Size(228, 29);
            Ausleihen_verwalten_button.TabIndex = 7;
            Ausleihen_verwalten_button.Text = "Ausleihen verwalten";
            Ausleihen_verwalten_button.UseVisualStyleBackColor = true;
            Ausleihen_verwalten_button.Click += Ausleihen_verwalten_button_Click;
            // 
            // Beanachrichtigungen_senden_button
            // 
            Beanachrichtigungen_senden_button.Location = new Point(381, 137);
            Beanachrichtigungen_senden_button.Name = "Beanachrichtigungen_senden_button";
            Beanachrichtigungen_senden_button.Size = new Size(228, 29);
            Beanachrichtigungen_senden_button.TabIndex = 6;
            Beanachrichtigungen_senden_button.Text = "Beanachrichtigungen senden";
            Beanachrichtigungen_senden_button.UseVisualStyleBackColor = true;
            Beanachrichtigungen_senden_button.Click += Beanachrichtigungen_senden_button_Click;
            // 
            // Reservierungen_verwalten_button
            // 
            Reservierungen_verwalten_button.Location = new Point(6, 286);
            Reservierungen_verwalten_button.Name = "Reservierungen_verwalten_button";
            Reservierungen_verwalten_button.Size = new Size(281, 29);
            Reservierungen_verwalten_button.TabIndex = 5;
            Reservierungen_verwalten_button.Text = "Reservierungen verwalten";
            Reservierungen_verwalten_button.UseVisualStyleBackColor = true;
            Reservierungen_verwalten_button.Click += Reservierungen_verwalten_button_Click;
            // 
            // Buchverwaltung_button
            // 
            Buchverwaltung_button.Location = new Point(6, 205);
            Buchverwaltung_button.Name = "Buchverwaltung_button";
            Buchverwaltung_button.Size = new Size(222, 29);
            Buchverwaltung_button.TabIndex = 4;
            Buchverwaltung_button.Text = "Buchverwaltung";
            Buchverwaltung_button.UseVisualStyleBackColor = true;
            Buchverwaltung_button.Click += Buchverwaltung_button_Click;
            // 
            // Benutzerverwaltungbutton
            // 
            Benutzerverwaltungbutton.Location = new Point(6, 137);
            Benutzerverwaltungbutton.Name = "Benutzerverwaltungbutton";
            Benutzerverwaltungbutton.Size = new Size(222, 29);
            Benutzerverwaltungbutton.TabIndex = 3;
            Benutzerverwaltungbutton.Text = "Benutzerverwaltung";
            Benutzerverwaltungbutton.UseVisualStyleBackColor = true;
            Benutzerverwaltungbutton.Click += Benutzerverwaltungbutton_Click;
            // 
            // MaAdminseite
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 244, 233);
            BackgroundImage = Properties.Resources.bg4;
            ClientSize = new Size(914, 510);
            Controls.Add(groupBox1);
            Font = new Font("Cascadia Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "MaAdminseite";
            Text = "Dososta Bibliothek - MaAdminseite";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button Benutzerverwaltungbutton;
        private Button Buchverwaltung_button;
        private Button Ausleihen_verwalten_button;
        private Button Beanachrichtigungen_senden_button;
        private Button Reservierungen_verwalten_button;
    }
}