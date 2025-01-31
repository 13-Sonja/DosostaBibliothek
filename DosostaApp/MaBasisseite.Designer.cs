namespace DosostaApp
{
    partial class MaBasisseite
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
            MaMenüGroupbox = new GroupBox();
            button1 = new Button();
            Ausleihen_verwalten_button = new Button();
            Beanachrichtigungen_senden_button = new Button();
            Reservierungen_verwalten_button = new Button();
            Buchverwaltung_button = new Button();
            Benutzerverwaltungbutton = new Button();
            MaMenüGroupbox.SuspendLayout();
            SuspendLayout();
            // 
            // MaMenüGroupbox
            // 
            MaMenüGroupbox.Controls.Add(button1);
            MaMenüGroupbox.Controls.Add(Ausleihen_verwalten_button);
            MaMenüGroupbox.Controls.Add(Beanachrichtigungen_senden_button);
            MaMenüGroupbox.Controls.Add(Reservierungen_verwalten_button);
            MaMenüGroupbox.Controls.Add(Buchverwaltung_button);
            MaMenüGroupbox.Controls.Add(Benutzerverwaltungbutton);
            MaMenüGroupbox.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaMenüGroupbox.Location = new Point(177, 68);
            MaMenüGroupbox.Name = "MaMenüGroupbox";
            MaMenüGroupbox.Size = new Size(560, 374);
            MaMenüGroupbox.TabIndex = 1;
            MaMenüGroupbox.TabStop = false;
            MaMenüGroupbox.Text = "Menü";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(143, 148, 171);
            button1.Font = new Font("Cascadia Mono", 14.25F);
            button1.Location = new Point(300, 301);
            button1.Name = "button1";
            button1.Size = new Size(228, 50);
            button1.TabIndex = 8;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += LogoutButton_click;
            // 
            // Ausleihen_verwalten_button
            // 
            Ausleihen_verwalten_button.BackColor = Color.FromArgb(186, 189, 202);
            Ausleihen_verwalten_button.Font = new Font("Cascadia Mono", 14.25F);
            Ausleihen_verwalten_button.Location = new Point(300, 55);
            Ausleihen_verwalten_button.Name = "Ausleihen_verwalten_button";
            Ausleihen_verwalten_button.Size = new Size(228, 50);
            Ausleihen_verwalten_button.TabIndex = 7;
            Ausleihen_verwalten_button.Text = "Eigene Daten";
            Ausleihen_verwalten_button.UseVisualStyleBackColor = false;
            Ausleihen_verwalten_button.Click += Nicht_implementiert_Click;
            // 
            // Beanachrichtigungen_senden_button
            // 
            Beanachrichtigungen_senden_button.BackColor = Color.FromArgb(195, 214, 199);
            Beanachrichtigungen_senden_button.Font = new Font("Cascadia Mono", 14.25F);
            Beanachrichtigungen_senden_button.Location = new Point(31, 194);
            Beanachrichtigungen_senden_button.Name = "Beanachrichtigungen_senden_button";
            Beanachrichtigungen_senden_button.Size = new Size(228, 80);
            Beanachrichtigungen_senden_button.TabIndex = 6;
            Beanachrichtigungen_senden_button.Text = "Benachrichtigungen senden";
            Beanachrichtigungen_senden_button.UseVisualStyleBackColor = false;
            Beanachrichtigungen_senden_button.Click += Nicht_implementiert_Click;
            // 
            // Reservierungen_verwalten_button
            // 
            Reservierungen_verwalten_button.BackColor = Color.FromArgb(186, 189, 202);
            Reservierungen_verwalten_button.Font = new Font("Cascadia Mono", 14.25F);
            Reservierungen_verwalten_button.Location = new Point(300, 126);
            Reservierungen_verwalten_button.Name = "Reservierungen_verwalten_button";
            Reservierungen_verwalten_button.Size = new Size(228, 50);
            Reservierungen_verwalten_button.TabIndex = 5;
            Reservierungen_verwalten_button.Text = "Dienstpläne";
            Reservierungen_verwalten_button.UseVisualStyleBackColor = false;
            Reservierungen_verwalten_button.Click += Nicht_implementiert_Click;
            // 
            // Buchverwaltung_button
            // 
            Buchverwaltung_button.BackColor = Color.FromArgb(154, 189, 162);
            Buchverwaltung_button.Font = new Font("Cascadia Mono", 14.25F);
            Buchverwaltung_button.Location = new Point(31, 55);
            Buchverwaltung_button.Name = "Buchverwaltung_button";
            Buchverwaltung_button.Size = new Size(228, 50);
            Buchverwaltung_button.TabIndex = 4;
            Buchverwaltung_button.Text = "Buchverwaltung";
            Buchverwaltung_button.UseVisualStyleBackColor = false;
            Buchverwaltung_button.Click += Buchverwaltung_button_Click;
            // 
            // Benutzerverwaltungbutton
            // 
            Benutzerverwaltungbutton.BackColor = Color.FromArgb(195, 214, 199);
            Benutzerverwaltungbutton.Font = new Font("Cascadia Mono", 14.25F);
            Benutzerverwaltungbutton.Location = new Point(31, 126);
            Benutzerverwaltungbutton.Name = "Benutzerverwaltungbutton";
            Benutzerverwaltungbutton.Size = new Size(228, 50);
            Benutzerverwaltungbutton.TabIndex = 3;
            Benutzerverwaltungbutton.Text = "Benutzerverwaltung";
            Benutzerverwaltungbutton.UseVisualStyleBackColor = false;
            Benutzerverwaltungbutton.Click += Benutzerverwaltungbutton_Click;
            // 
            // MaBasisseite
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 252, 249);
            BackgroundImage = Properties.Resources.bg4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 510);
            Controls.Add(MaMenüGroupbox);
            Font = new Font("Cascadia Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "MaBasisseite";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dososta Bibliothek";
            MaMenüGroupbox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox MaMenüGroupbox;
        private Button Ausleihen_verwalten_button;
        private Button Beanachrichtigungen_senden_button;
        private Button Reservierungen_verwalten_button;
        private Button Buchverwaltung_button;
        private Button Benutzerverwaltungbutton;
        private Button button1;
    }
}