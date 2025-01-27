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
            zurückButton = new Button();
            SuspendLayout();
            // 
            // zurückButton
            // 
            zurückButton.BackColor = Color.FromArgb(195, 214, 199);
            zurückButton.Location = new Point(300, 235);
            zurückButton.Name = "zurückButton";
            zurückButton.Size = new Size(247, 78);
            zurückButton.TabIndex = 0;
            zurückButton.Text = "Zurück";
            zurückButton.UseVisualStyleBackColor = false;
            //zurückButton.Click += Utils.zurückButton_Click();
            // 
            // Registrierungsseite
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 252, 249);
            ClientSize = new Size(914, 510);
            Controls.Add(zurückButton);
            Font = new Font("Cascadia Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Registrierungsseite";
            Text = "Dososta Bibliothek";
            ResumeLayout(false);
        }

        #endregion

        private Button zurückButton;
    }
}