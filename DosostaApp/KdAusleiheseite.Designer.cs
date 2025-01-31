namespace DosostaApp
{
    partial class KdAusleiheseite_Form
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
            Bücher_Ausleihen_button = new Button();
            Bücher_Rückgabe_button = new Button();
            tb_search = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tb_search);
            groupBox1.Controls.Add(Bücher_Rückgabe_button);
            groupBox1.Controls.Add(Bücher_Ausleihen_button);
            groupBox1.Location = new Point(233, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(575, 343);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // Bücher_Ausleihen_button
            // 
            Bücher_Ausleihen_button.Location = new Point(120, 144);
            Bücher_Ausleihen_button.Name = "Bücher_Ausleihen_button";
            Bücher_Ausleihen_button.Size = new Size(243, 53);
            Bücher_Ausleihen_button.TabIndex = 6;
            Bücher_Ausleihen_button.Text = "Bücher Ausleihen";
            Bücher_Ausleihen_button.UseVisualStyleBackColor = true;
            Bücher_Ausleihen_button.Click += Bücher_Ausleihen_button_Click;
            // 
            // Bücher_Rückgabe_button
            // 
            Bücher_Rückgabe_button.Location = new Point(120, 238);
            Bücher_Rückgabe_button.Name = "Bücher_Rückgabe_button";
            Bücher_Rückgabe_button.Size = new Size(243, 47);
            Bücher_Rückgabe_button.TabIndex = 7;
            Bücher_Rückgabe_button.Text = "Bücher Rückgabe";
            Bücher_Rückgabe_button.UseVisualStyleBackColor = true;
            Bücher_Rückgabe_button.Click += Bücher_Rückgabe_button_Click;
            // 
            // tb_search
            // 
            tb_search.Font = new Font("Sitka Banner", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            tb_search.Location = new Point(324, 41);
            tb_search.Multiline = true;
            tb_search.Name = "tb_search";
            tb_search.PlaceholderText = "Bücher suchen...";
            tb_search.Size = new Size(216, 34);
            tb_search.TabIndex = 8;
            tb_search.TextChanged += tb_search_TextChanged;
            // 
            // KdAusleiheseite_Form
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 244, 233);
            BackgroundImage = Properties.Resources.bg4;
            ClientSize = new Size(896, 463);
            Controls.Add(groupBox1);
            Font = new Font("Cascadia Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "KdAusleiheseite_Form";
            Text = "Dososta Bibliothek AusleiheSeite";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button Bücher_Rückgabe_button;
        private Button Bücher_Ausleihen_button;
        private TextBox tb_search;
    }
}