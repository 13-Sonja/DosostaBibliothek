namespace DosostaApp
{
    partial class Loginseite
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
            loginBasisGroupbox = new GroupBox();
            zurückButton = new Button();
            LoginButton = new Button();
            loginGroupbox = new GroupBox();
            passwortTextbox = new TextBox();
            nachnameTextbox = new TextBox();
            vornameTextbox = new TextBox();
            passwortLabel = new Label();
            nachnameLabel = new Label();
            vornamenLabel = new Label();
            willkommenLabel = new Label();
            loginBasisGroupbox.SuspendLayout();
            loginGroupbox.SuspendLayout();
            SuspendLayout();
            // 
            // loginBasisGroupbox
            // 
            loginBasisGroupbox.BackColor = Color.FromArgb(255, 244, 233);
            loginBasisGroupbox.Controls.Add(zurückButton);
            loginBasisGroupbox.Controls.Add(LoginButton);
            loginBasisGroupbox.Controls.Add(loginGroupbox);
            loginBasisGroupbox.Controls.Add(willkommenLabel);
            loginBasisGroupbox.Location = new Point(177, 68);
            loginBasisGroupbox.Name = "loginBasisGroupbox";
            loginBasisGroupbox.Size = new Size(560, 374);
            loginBasisGroupbox.TabIndex = 1;
            loginBasisGroupbox.TabStop = false;
            // 
            // zurückButton
            // 
            zurückButton.BackColor = Color.FromArgb(143, 148, 171);
            zurückButton.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            zurückButton.ForeColor = Color.Black;
            zurückButton.Location = new Point(105, 314);
            zurückButton.Name = "zurückButton";
            zurückButton.Size = new Size(148, 45);
            zurückButton.TabIndex = 4;
            zurückButton.Text = "Zurück";
            zurückButton.UseVisualStyleBackColor = false;
            zurückButton.Click += zurückButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(154, 189, 162);
            LoginButton.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginButton.ForeColor = Color.Black;
            LoginButton.Location = new Point(307, 314);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(148, 45);
            LoginButton.TabIndex = 3;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // loginGroupbox
            // 
            loginGroupbox.BackColor = Color.FromArgb(250, 227, 204);
            loginGroupbox.Controls.Add(passwortTextbox);
            loginGroupbox.Controls.Add(nachnameTextbox);
            loginGroupbox.Controls.Add(vornameTextbox);
            loginGroupbox.Controls.Add(passwortLabel);
            loginGroupbox.Controls.Add(nachnameLabel);
            loginGroupbox.Controls.Add(vornamenLabel);
            loginGroupbox.Location = new Point(105, 102);
            loginGroupbox.Name = "loginGroupbox";
            loginGroupbox.Size = new Size(354, 190);
            loginGroupbox.TabIndex = 2;
            loginGroupbox.TabStop = false;
            loginGroupbox.Text = "Login";
            // 
            // passwortTextbox
            // 
            passwortTextbox.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwortTextbox.Location = new Point(124, 133);
            passwortTextbox.Name = "passwortTextbox";
            passwortTextbox.Size = new Size(211, 30);
            passwortTextbox.TabIndex = 5;
            // 
            // nachnameTextbox
            // 
            nachnameTextbox.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nachnameTextbox.Location = new Point(122, 85);
            nachnameTextbox.Name = "nachnameTextbox";
            nachnameTextbox.Size = new Size(211, 30);
            nachnameTextbox.TabIndex = 4;
            // 
            // vornameTextbox
            // 
            vornameTextbox.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vornameTextbox.Location = new Point(122, 40);
            vornameTextbox.Name = "vornameTextbox";
            vornameTextbox.Size = new Size(211, 30);
            vornameTextbox.TabIndex = 3;
            // 
            // passwortLabel
            // 
            passwortLabel.AutoSize = true;
            passwortLabel.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwortLabel.Location = new Point(18, 138);
            passwortLabel.Name = "passwortLabel";
            passwortLabel.Size = new Size(100, 25);
            passwortLabel.TabIndex = 2;
            passwortLabel.Text = "Passwort";
            // 
            // nachnameLabel
            // 
            nachnameLabel.AutoSize = true;
            nachnameLabel.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nachnameLabel.Location = new Point(18, 90);
            nachnameLabel.Name = "nachnameLabel";
            nachnameLabel.Size = new Size(100, 25);
            nachnameLabel.TabIndex = 1;
            nachnameLabel.Text = "Nachname";
            // 
            // vornamenLabel
            // 
            vornamenLabel.AutoSize = true;
            vornamenLabel.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vornamenLabel.Location = new Point(18, 45);
            vornamenLabel.Name = "vornamenLabel";
            vornamenLabel.Size = new Size(89, 25);
            vornamenLabel.TabIndex = 0;
            vornamenLabel.Text = "Vorname";
            // 
            // willkommenLabel
            // 
            willkommenLabel.AutoSize = true;
            willkommenLabel.Font = new Font("Cascadia Code", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            willkommenLabel.Location = new Point(120, 19);
            willkommenLabel.Name = "willkommenLabel";
            willkommenLabel.Size = new Size(335, 63);
            willkommenLabel.TabIndex = 1;
            willkommenLabel.Text = "Willkommen!";
            // 
            // Loginseite
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 252, 249);
            BackgroundImage = Properties.Resources.bg4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(968, 510);
            Controls.Add(loginBasisGroupbox);
            Font = new Font("Cascadia Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Loginseite";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dososta Bibliothek";
            loginBasisGroupbox.ResumeLayout(false);
            loginBasisGroupbox.PerformLayout();
            loginGroupbox.ResumeLayout(false);
            loginGroupbox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox loginBasisGroupbox;
        private GroupBox loginGroupbox;
        private Label willkommenLabel;
        private Button LoginButton;
        private TextBox passwortTextbox;
        private TextBox nachnameTextbox;
        private TextBox vornameTextbox;
        private Label passwortLabel;
        private Label nachnameLabel;
        private Label vornamenLabel;
        private Button zurückButton;
    }
}