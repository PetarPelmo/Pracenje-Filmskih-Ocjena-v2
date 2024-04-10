namespace Pracenje_filmskih_ocjena
{
    partial class Ocjena
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
            this.listBoxOcjena = new System.Windows.Forms.ListBox();
            this.exit = new System.Windows.Forms.Button();
            this.edit3 = new System.Windows.Forms.Button();
            this.Korisnici = new System.Windows.Forms.Button();
            this.Filmovi = new System.Windows.Forms.Button();
            this.twoListBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxOcjena
            // 
            this.listBoxOcjena.FormattingEnabled = true;
            this.listBoxOcjena.Location = new System.Drawing.Point(12, 97);
            this.listBoxOcjena.Name = "listBoxOcjena";
            this.listBoxOcjena.Size = new System.Drawing.Size(287, 160);
            this.listBoxOcjena.TabIndex = 11;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(393, 234);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(127, 23);
            this.exit.TabIndex = 10;
            this.exit.Text = "Izlaz";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // edit3
            // 
            this.edit3.Location = new System.Drawing.Point(393, 161);
            this.edit3.Name = "edit3";
            this.edit3.Size = new System.Drawing.Size(127, 23);
            this.edit3.TabIndex = 9;
            this.edit3.Text = "Uredi";
            this.edit3.UseVisualStyleBackColor = true;
            this.edit3.Click += new System.EventHandler(this.edit3_Click);
            // 
            // Korisnici
            // 
            this.Korisnici.Location = new System.Drawing.Point(154, 12);
            this.Korisnici.Name = "Korisnici";
            this.Korisnici.Size = new System.Drawing.Size(75, 23);
            this.Korisnici.TabIndex = 7;
            this.Korisnici.Text = "Korisnici";
            this.Korisnici.UseVisualStyleBackColor = true;
            this.Korisnici.Click += new System.EventHandler(this.Korisnici_Click);
            // 
            // Filmovi
            // 
            this.Filmovi.Location = new System.Drawing.Point(12, 12);
            this.Filmovi.Name = "Filmovi";
            this.Filmovi.Size = new System.Drawing.Size(75, 23);
            this.Filmovi.TabIndex = 6;
            this.Filmovi.Text = "Filmovi";
            this.Filmovi.UseVisualStyleBackColor = true;
            this.Filmovi.Click += new System.EventHandler(this.Filmovi_Click);
            // 
            // twoListBox
            // 
            this.twoListBox.Location = new System.Drawing.Point(393, 97);
            this.twoListBox.Name = "twoListBox";
            this.twoListBox.Size = new System.Drawing.Size(127, 23);
            this.twoListBox.TabIndex = 12;
            this.twoListBox.Text = "Filmovi i korisnici";
            this.twoListBox.UseVisualStyleBackColor = true;
            this.twoListBox.Click += new System.EventHandler(this.Filmovi_i_korisnici);
            // 
            // Ocjena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.twoListBox);
            this.Controls.Add(this.listBoxOcjena);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.edit3);
            this.Controls.Add(this.Korisnici);
            this.Controls.Add(this.Filmovi);
            this.Name = "Ocjena";
            this.Text = "Ocjena";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxOcjena;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button edit3;
        private System.Windows.Forms.Button Korisnici;
        private System.Windows.Forms.Button Filmovi;
        private System.Windows.Forms.Button twoListBox;
    }
}