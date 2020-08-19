namespace Voetbalclub1._0
{
    partial class Form1
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
            this.rbSpeler = new System.Windows.Forms.RadioButton();
            this.rbTrainer = new System.Windows.Forms.RadioButton();
            this.rbBestuurder = new System.Windows.Forms.RadioButton();
            this.btnMaak = new System.Windows.Forms.Button();
            this.btnWijzig = new System.Windows.Forms.Button();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbSpeler
            // 
            this.rbSpeler.AutoSize = true;
            this.rbSpeler.Location = new System.Drawing.Point(27, 35);
            this.rbSpeler.Name = "rbSpeler";
            this.rbSpeler.Size = new System.Drawing.Size(55, 17);
            this.rbSpeler.TabIndex = 2;
            this.rbSpeler.TabStop = true;
            this.rbSpeler.Text = "Speler";
            this.rbSpeler.UseVisualStyleBackColor = true;
            // 
            // rbTrainer
            // 
            this.rbTrainer.AutoSize = true;
            this.rbTrainer.Location = new System.Drawing.Point(151, 35);
            this.rbTrainer.Name = "rbTrainer";
            this.rbTrainer.Size = new System.Drawing.Size(58, 17);
            this.rbTrainer.TabIndex = 3;
            this.rbTrainer.TabStop = true;
            this.rbTrainer.Text = "Trainer";
            this.rbTrainer.UseVisualStyleBackColor = true;
            // 
            // rbBestuurder
            // 
            this.rbBestuurder.AutoSize = true;
            this.rbBestuurder.Location = new System.Drawing.Point(269, 35);
            this.rbBestuurder.Name = "rbBestuurder";
            this.rbBestuurder.Size = new System.Drawing.Size(76, 17);
            this.rbBestuurder.TabIndex = 4;
            this.rbBestuurder.TabStop = true;
            this.rbBestuurder.Text = "Bestuurder";
            this.rbBestuurder.UseVisualStyleBackColor = true;
            // 
            // btnMaak
            // 
            this.btnMaak.Location = new System.Drawing.Point(27, 106);
            this.btnMaak.Name = "btnMaak";
            this.btnMaak.Size = new System.Drawing.Size(75, 23);
            this.btnMaak.TabIndex = 5;
            this.btnMaak.Text = "Maak Aan";
            this.btnMaak.UseVisualStyleBackColor = true;
            // 
            // btnWijzig
            // 
            this.btnWijzig.Location = new System.Drawing.Point(108, 106);
            this.btnWijzig.Name = "btnWijzig";
            this.btnWijzig.Size = new System.Drawing.Size(75, 23);
            this.btnWijzig.TabIndex = 6;
            this.btnWijzig.Text = "Wijzig";
            this.btnWijzig.UseVisualStyleBackColor = true;
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(189, 106);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(75, 23);
            this.btnVerwijder.TabIndex = 7;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(270, 106);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 8;
            this.btnShow.Text = "Bekijk";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 162);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.btnWijzig);
            this.Controls.Add(this.btnMaak);
            this.Controls.Add(this.rbBestuurder);
            this.Controls.Add(this.rbTrainer);
            this.Controls.Add(this.rbSpeler);
            this.Name = "Form1";
            this.Text = "Inlogformulier";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbSpeler;
        private System.Windows.Forms.RadioButton rbTrainer;
        private System.Windows.Forms.RadioButton rbBestuurder;
        private System.Windows.Forms.Button btnMaak;
        private System.Windows.Forms.Button btnWijzig;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.Button btnShow;
    }
}

