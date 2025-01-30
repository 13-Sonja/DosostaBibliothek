namespace DosostaApp
{
    partial class KdBasisseite
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
            LogoutButton = new Button();
            VerleihButton = new Button();
            basisGroupbox = new GroupBox();
            ProfilButton = new Button();
            AusleihButton = new Button();
            SuspendLayout();
            // 
            // LogoutButton
            // 
            LogoutButton.BackColor = Color.FromArgb(143, 148, 171);
            LogoutButton.Font = new Font("Cascadia Mono", 12F);
            LogoutButton.Location = new Point(45, 370);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(160, 58);
            LogoutButton.TabIndex = 0;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = false;
            LogoutButton.Click += LogoutButton_click;
            // 
            // VerleihButton
            // 
            VerleihButton.BackColor = Color.FromArgb(154, 189, 162);
            VerleihButton.Font = new Font("Cascadia Mono", 12F);
            VerleihButton.Location = new Point(45, 167);
            VerleihButton.Name = "VerleihButton";
            VerleihButton.Size = new Size(160, 51);
            VerleihButton.TabIndex = 1;
            VerleihButton.Text = "Meine Bücher";
            VerleihButton.UseVisualStyleBackColor = false;
            VerleihButton.Click += MeineBücherButton_click;
            // 
            // basisGroupbox
            // 
            basisGroupbox.BackColor = Color.FromArgb(250, 227, 204);
            basisGroupbox.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            basisGroupbox.Location = new Point(266, 12);
            basisGroupbox.Name = "basisGroupbox";
            basisGroupbox.Size = new Size(635, 429);
            basisGroupbox.TabIndex = 2;
            basisGroupbox.TabStop = false;
            basisGroupbox.Text = "Ihr persönlicher Hub";
            // 
            // ProfilButton
            // 
            ProfilButton.BackColor = Color.FromArgb(195, 214, 199);
            ProfilButton.Font = new Font("Cascadia Mono", 12F);
            ProfilButton.Location = new Point(45, 249);
            ProfilButton.Name = "ProfilButton";
            ProfilButton.Size = new Size(160, 49);
            ProfilButton.TabIndex = 3;
            ProfilButton.Text = "Mein Profil";
            ProfilButton.UseVisualStyleBackColor = false;
            ProfilButton.Click += ProfilButton_click;
            // 
            // AusleihButton
            // 
            AusleihButton.BackColor = Color.FromArgb(154, 189, 162);
            AusleihButton.Font = new Font("Cascadia Mono", 12F);
            AusleihButton.Location = new Point(45, 89);
            AusleihButton.Name = "AusleihButton";
            AusleihButton.Size = new Size(160, 50);
            AusleihButton.TabIndex = 4;
            AusleihButton.Text = "Buch Ausleihen";
            AusleihButton.UseVisualStyleBackColor = false;
            AusleihButton.Click += BuchAusleihenButton_click;
            // 
            // KdBasisseite
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 244, 233);
            BackgroundImage = Properties.Resources.bg4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(916, 453);
            Controls.Add(AusleihButton);
            Controls.Add(ProfilButton);
            Controls.Add(basisGroupbox);
            Controls.Add(VerleihButton);
            Controls.Add(LogoutButton);
            Font = new Font("Cascadia Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "KdBasisseite";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dososta Bibliothek";
            ResumeLayout(false);
        }

        #endregion

        private Button LogoutButton;
        private Button VerleihButton;
        private GroupBox basisGroupbox;
        private Button ProfilButton;
        private Button AusleihButton;
    }
}