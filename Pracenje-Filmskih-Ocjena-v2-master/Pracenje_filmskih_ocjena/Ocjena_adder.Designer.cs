namespace Pracenje_filmskih_ocjena
{
    partial class Ocjena_adder
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
            this.ocjena_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ocjena_film = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.zivotinja_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.opis_ocjene = new System.Windows.Forms.TextBox();
            this.broj_ocjene = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ocjena_username
            // 
            this.ocjena_username.Location = new System.Drawing.Point(304, 337);
            this.ocjena_username.Name = "ocjena_username";
            this.ocjena_username.Size = new System.Drawing.Size(100, 20);
            this.ocjena_username.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Username";
            // 
            // ocjena_film
            // 
            this.ocjena_film.Location = new System.Drawing.Point(304, 260);
            this.ocjena_film.Name = "ocjena_film";
            this.ocjena_film.Size = new System.Drawing.Size(100, 20);
            this.ocjena_film.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Film";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(469, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 24);
            this.label7.TabIndex = 53;
            this.label7.Text = "Dodaj Ocjenu";
            // 
            // zivotinja_add
            // 
            this.zivotinja_add.Location = new System.Drawing.Point(533, 223);
            this.zivotinja_add.Name = "zivotinja_add";
            this.zivotinja_add.Size = new System.Drawing.Size(94, 50);
            this.zivotinja_add.TabIndex = 52;
            this.zivotinja_add.Text = "Dodaj";
            this.zivotinja_add.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Opis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Ocjena";
            // 
            // opis_ocjene
            // 
            this.opis_ocjene.Location = new System.Drawing.Point(304, 190);
            this.opis_ocjene.Name = "opis_ocjene";
            this.opis_ocjene.Size = new System.Drawing.Size(100, 20);
            this.opis_ocjene.TabIndex = 49;
            // 
            // broj_ocjene
            // 
            this.broj_ocjene.Location = new System.Drawing.Point(304, 102);
            this.broj_ocjene.MaxLength = 1;
            this.broj_ocjene.Name = "broj_ocjene";
            this.broj_ocjene.Size = new System.Drawing.Size(100, 20);
            this.broj_ocjene.TabIndex = 48;
            // 
            // Ocjena_adder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ocjena_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ocjena_film);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.zivotinja_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.opis_ocjene);
            this.Controls.Add(this.broj_ocjene);
            this.Name = "Ocjena_adder";
            this.Text = "Ocjena_adder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ocjena_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ocjena_film;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button zivotinja_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox opis_ocjene;
        private System.Windows.Forms.TextBox broj_ocjene;
    }
}