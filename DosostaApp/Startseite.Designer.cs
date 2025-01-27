namespace DosostaApp
{
    partial class Startseite
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
            buttonGroupbox = new GroupBox();
            willkommenLabel = new Label();
            registrierenButton = new Button();
            maLoginButton = new Button();
            kdLoginButton = new Button();
            buttonGroupbox.SuspendLayout();
            SuspendLayout();
            // 
            // buttonGroupbox
            // 
            buttonGroupbox.BackColor = Color.FromArgb(255, 244, 233);
            buttonGroupbox.Controls.Add(willkommenLabel);
            buttonGroupbox.Controls.Add(registrierenButton);
            buttonGroupbox.Controls.Add(maLoginButton);
            buttonGroupbox.Controls.Add(kdLoginButton);
            buttonGroupbox.Location = new Point(171, 76);
            buttonGroupbox.Name = "buttonGroupbox";
            buttonGroupbox.Size = new Size(560, 374);
            buttonGroupbox.TabIndex = 0;
            buttonGroupbox.TabStop = false;
            // 
            // willkommenLabel
            // 
            willkommenLabel.AutoSize = true;
            willkommenLabel.Font = new Font("Cascadia Code", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            willkommenLabel.Location = new Point(153, 45);
            willkommenLabel.Name = "willkommenLabel";
            willkommenLabel.Size = new Size(264, 49);
            willkommenLabel.TabIndex = 1;
            willkommenLabel.Text = "Willkommen!";
            // 
            // registrierenButton
            // 
            registrierenButton.BackColor = Color.FromArgb(195, 214, 199);
            registrierenButton.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registrierenButton.Location = new Point(199, 156);
            registrierenButton.Name = "registrierenButton";
            registrierenButton.Size = new Size(142, 90);
            registrierenButton.TabIndex = 2;
            registrierenButton.Text = "Neues Kundenkonto anlegen";
            registrierenButton.UseVisualStyleBackColor = false;
            // 
            // maLoginButton
            // 
            maLoginButton.BackColor = Color.FromArgb(143, 148, 171);
            maLoginButton.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maLoginButton.Location = new Point(385, 156);
            maLoginButton.Name = "maLoginButton";
            maLoginButton.Size = new Size(130, 90);
            maLoginButton.TabIndex = 1;
            maLoginButton.Text = "Login Mitarbeiter";
            maLoginButton.UseVisualStyleBackColor = false;
            // 
            // kdLoginButton
            // 
            kdLoginButton.BackColor = Color.FromArgb(154, 189, 162);
            kdLoginButton.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kdLoginButton.ForeColor = Color.Black;
            kdLoginButton.Location = new Point(32, 156);
            kdLoginButton.Name = "kdLoginButton";
            kdLoginButton.Size = new Size(122, 90);
            kdLoginButton.TabIndex = 0;
            kdLoginButton.Text = "Login Kunde";
            kdLoginButton.UseVisualStyleBackColor = false;
            // 
            // Startseite
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 252, 249);
            BackgroundImage = Properties.Resources.bg4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 510);
            Controls.Add(buttonGroupbox);
            Font = new Font("Cascadia Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Startseite";
            Text = "Dososta Bibliothek";
            buttonGroupbox.ResumeLayout(false);
            buttonGroupbox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox buttonGroupbox;
        private Label willkommenLabel;
        private Button maLoginButton;
        private Button kdLoginButton;
        private Button registrierenButton;
    }
}