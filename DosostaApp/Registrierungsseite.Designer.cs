namespace DosostaApp
{
    partial class Registrierungsseite
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
            RegBasisGroupbox = new GroupBox();
            RegGroupbox = new GroupBox();
            gebDatepicker = new DateTimePicker();
            GebLabel = new Label();
            emailTextbox = new TextBox();
            emailLabel = new Label();
            passwortTextbox = new TextBox();
            nachnameTextbox = new TextBox();
            vornameTextbox = new TextBox();
            passwortLabel = new Label();
            nachnameLabel = new Label();
            vornamenLabel = new Label();
            willkommenLabel = new Label();
            zurückButton = new Button();
            regButton = new Button();
            RegBasisGroupbox.SuspendLayout();
            RegGroupbox.SuspendLayout();
            SuspendLayout();
            // 
            // RegBasisGroupbox
            // 
            RegBasisGroupbox.BackColor = Color.FromArgb(255, 244, 233);
            RegBasisGroupbox.Controls.Add(RegGroupbox);
            RegBasisGroupbox.Controls.Add(willkommenLabel);
            RegBasisGroupbox.Location = new Point(177, 68);
            RegBasisGroupbox.Name = "RegBasisGroupbox";
            RegBasisGroupbox.Size = new Size(560, 374);
            RegBasisGroupbox.TabIndex = 2;
            RegBasisGroupbox.TabStop = false;
            // 
            // RegGroupbox
            // 
            RegGroupbox.BackColor = Color.FromArgb(250, 227, 204);
            RegGroupbox.Controls.Add(gebDatepicker);
            RegGroupbox.Controls.Add(GebLabel);
            RegGroupbox.Controls.Add(emailTextbox);
            RegGroupbox.Controls.Add(emailLabel);
            RegGroupbox.Controls.Add(passwortTextbox);
            RegGroupbox.Controls.Add(nachnameTextbox);
            RegGroupbox.Controls.Add(vornameTextbox);
            RegGroupbox.Controls.Add(passwortLabel);
            RegGroupbox.Controls.Add(nachnameLabel);
            RegGroupbox.Controls.Add(vornamenLabel);
            RegGroupbox.Location = new Point(51, 102);
            RegGroupbox.Name = "RegGroupbox";
            RegGroupbox.Size = new Size(457, 251);
            RegGroupbox.TabIndex = 2;
            RegGroupbox.TabStop = false;
            RegGroupbox.Text = "Registrierung";
            // 
            // gebDatepicker
            // 
            gebDatepicker.Font = new Font("Cascadia Mono", 14.25F);
            gebDatepicker.Format = DateTimePickerFormat.Short;
            gebDatepicker.Location = new Point(176, 205);
            gebDatepicker.Name = "gebDatepicker";
            gebDatepicker.Size = new Size(245, 30);
            gebDatepicker.TabIndex = 9;
            // 
            // GebLabel
            // 
            GebLabel.AutoSize = true;
            GebLabel.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GebLabel.Location = new Point(17, 208);
            GebLabel.Name = "GebLabel";
            GebLabel.Size = new Size(144, 25);
            GebLabel.TabIndex = 8;
            GebLabel.Text = "Geburtsdatum";
            // 
            // emailTextbox
            // 
            emailTextbox.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTextbox.Location = new Point(176, 161);
            emailTextbox.Name = "emailTextbox";
            emailTextbox.Size = new Size(245, 30);
            emailTextbox.TabIndex = 7;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(19, 166);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(67, 25);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "Email";
            // 
            // passwortTextbox
            // 
            passwortTextbox.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwortTextbox.Location = new Point(176, 113);
            passwortTextbox.Name = "passwortTextbox";
            passwortTextbox.Size = new Size(245, 30);
            passwortTextbox.TabIndex = 5;
            // 
            // nachnameTextbox
            // 
            nachnameTextbox.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nachnameTextbox.Location = new Point(174, 65);
            nachnameTextbox.Name = "nachnameTextbox";
            nachnameTextbox.Size = new Size(245, 30);
            nachnameTextbox.TabIndex = 4;
            // 
            // vornameTextbox
            // 
            vornameTextbox.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vornameTextbox.Location = new Point(174, 20);
            vornameTextbox.Name = "vornameTextbox";
            vornameTextbox.Size = new Size(245, 30);
            vornameTextbox.TabIndex = 3;
            // 
            // passwortLabel
            // 
            passwortLabel.AutoSize = true;
            passwortLabel.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwortLabel.Location = new Point(17, 118);
            passwortLabel.Name = "passwortLabel";
            passwortLabel.Size = new Size(100, 25);
            passwortLabel.TabIndex = 2;
            passwortLabel.Text = "Passwort";
            // 
            // nachnameLabel
            // 
            nachnameLabel.AutoSize = true;
            nachnameLabel.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nachnameLabel.Location = new Point(17, 70);
            nachnameLabel.Name = "nachnameLabel";
            nachnameLabel.Size = new Size(100, 25);
            nachnameLabel.TabIndex = 1;
            nachnameLabel.Text = "Nachname";
            // 
            // vornamenLabel
            // 
            vornamenLabel.AutoSize = true;
            vornamenLabel.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vornamenLabel.Location = new Point(17, 25);
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
            // zurückButton
            // 
            zurückButton.BackColor = Color.FromArgb(143, 148, 171);
            zurückButton.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            zurückButton.ForeColor = Color.Black;
            zurückButton.Location = new Point(228, 453);
            zurückButton.Name = "zurückButton";
            zurückButton.Size = new Size(148, 45);
            zurückButton.TabIndex = 4;
            zurückButton.Text = "Zurück";
            zurückButton.UseVisualStyleBackColor = false;
            zurückButton.Click += zurückButton_Click;
            // 
            // regButton
            // 
            regButton.BackColor = Color.FromArgb(154, 189, 162);
            regButton.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            regButton.ForeColor = Color.Black;
            regButton.Location = new Point(520, 453);
            regButton.Name = "regButton";
            regButton.Size = new Size(165, 45);
            regButton.TabIndex = 3;
            regButton.Text = "Registrieren";
            regButton.UseVisualStyleBackColor = false;
            regButton.Click += regButton_Click;
            // 
            // Registrierungsseite
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 252, 249);
            BackgroundImage = Properties.Resources.bg4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 510);
            Controls.Add(regButton);
            Controls.Add(zurückButton);
            Controls.Add(RegBasisGroupbox);
            Font = new Font("Cascadia Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Registrierungsseite";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dososta Bibliothek";
            RegBasisGroupbox.ResumeLayout(false);
            RegBasisGroupbox.PerformLayout();
            RegGroupbox.ResumeLayout(false);
            RegGroupbox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox RegBasisGroupbox;
        private Button zurückButton;
        private Button regButton;
        private GroupBox RegGroupbox;
        private TextBox passwortTextbox;
        private TextBox nachnameTextbox;
        private TextBox vornameTextbox;
        private Label passwortLabel;
        private Label nachnameLabel;
        private Label vornamenLabel;
        private Label willkommenLabel;
        private DateTimePicker gebDatepicker;
        private Label GebLabel;
        private TextBox emailTextbox;
        private Label emailLabel;
    }
}