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
            groupBox2 = new GroupBox();
            label1 = new Label();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 244, 233);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(119, 85);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(648, 413);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 173);
            label1.Name = "label1";
            label1.Size = new Size(96, 17);
            label1.TabIndex = 0;
            label1.Text = "Mitarbeiter";
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
            Font = new Font("Cascadia Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "MaBasisseite";
            Text = "Dososta Bibliothek";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private Label label1;
    }
}