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
            statusGroupbox = new GroupBox();
            logoutButton = new Button();
            textLabel1 = new Label();
            groupBox2 = new GroupBox();
            statusGroupbox.SuspendLayout();
            SuspendLayout();
            // 
            // statusGroupbox
            // 
            statusGroupbox.BackColor = Color.FromArgb(250, 227, 204);
            statusGroupbox.Controls.Add(logoutButton);
            statusGroupbox.Controls.Add(textLabel1);
            statusGroupbox.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusGroupbox.Location = new Point(12, 12);
            statusGroupbox.Name = "statusGroupbox";
            statusGroupbox.Size = new Size(890, 54);
            statusGroupbox.TabIndex = 0;
            statusGroupbox.TabStop = false;
            statusGroupbox.Text = "Loginstatus";
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.FromArgb(195, 214, 199);
            logoutButton.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoutButton.Location = new Point(749, 11);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(135, 37);
            logoutButton.TabIndex = 1;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = false;
            // 
            // textLabel1
            // 
            textLabel1.AutoSize = true;
            textLabel1.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textLabel1.Location = new Point(361, 22);
            textLabel1.Name = "textLabel1";
            textLabel1.Size = new Size(226, 21);
            textLabel1.TabIndex = 0;
            textLabel1.Text = "Eingeloggt als: {status}";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 244, 233);
            groupBox2.Location = new Point(119, 85);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(648, 413);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // MaBasisseite
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 252, 249);
            BackgroundImage = Properties.Resources.bg4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 510);
            Controls.Add(groupBox2);
            Controls.Add(statusGroupbox);
            Font = new Font("Cascadia Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "MaBasisseite";
            Text = "Dososta Bibliothek";
            statusGroupbox.ResumeLayout(false);
            statusGroupbox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox statusGroupbox;
        private Label textLabel1;
        private Button logoutButton;
        private GroupBox groupBox2;
    }
}