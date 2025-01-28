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
            groupBox1 = new GroupBox();
            Bücherliste = new ListBox();
            ProfilButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // LogoutButton
            // 
            LogoutButton.Location = new Point(27, 408);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(75, 23);
            LogoutButton.TabIndex = 0;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_click;
            // 
            // VerleihButton
            // 
            VerleihButton.Location = new Point(27, 379);
            VerleihButton.Name = "VerleihButton";
            VerleihButton.Size = new Size(75, 23);
            VerleihButton.TabIndex = 1;
            VerleihButton.Text = "Bücher";
            VerleihButton.UseVisualStyleBackColor = true;
            VerleihButton.Click += MeineBücherButton_click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Bücherliste);
            groupBox1.Location = new Point(439, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(465, 363);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // Bücherliste
            // 
            Bücherliste.Dock = DockStyle.Fill;
            Bücherliste.FormattingEnabled = true;
            Bücherliste.ItemHeight = 17;
            Bücherliste.Location = new Point(3, 19);
            Bücherliste.Name = "Bücherliste";
            Bücherliste.Size = new Size(459, 341);
            Bücherliste.TabIndex = 0;
            // 
            // ProfilButton
            // 
            ProfilButton.Location = new Point(27, 350);
            ProfilButton.Name = "ProfilButton";
            ProfilButton.Size = new Size(75, 23);
            ProfilButton.TabIndex = 3;
            ProfilButton.Text = "Profil";
            ProfilButton.UseVisualStyleBackColor = true;
            ProfilButton.Click += ProfilButton_click;
            // 
            // KdBasisseite
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 244, 233);
            ClientSize = new Size(916, 453);
            Controls.Add(ProfilButton);
            Controls.Add(groupBox1);
            Controls.Add(VerleihButton);
            Controls.Add(LogoutButton);
            Font = new Font("Cascadia Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "KdBasisseite";
            Text = "Dososta Bibliothek";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button LogoutButton;
        private Button VerleihButton;
        private GroupBox groupBox1;
        private Button ProfilButton;
        private ListBox Bücherliste;
    }
}