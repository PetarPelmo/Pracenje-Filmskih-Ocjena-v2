namespace Pracenje_filmskih_ocjena.PodatkovniKontext
{
    partial class UpisKorisnika
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
            this.textIme = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.textDatRod = new System.Windows.Forms.TextBox();
            this.textPrezime = new System.Windows.Forms.TextBox();
            this.buttonIzadi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textIme
            // 
            this.textIme.Location = new System.Drawing.Point(152, 48);
            this.textIme.Name = "textIme";
            this.textIme.Size = new System.Drawing.Size(100, 22);
            this.textIme.TabIndex = 0;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(152, 150);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(100, 22);
            this.textEmail.TabIndex = 1;
            // 
            // textUserName
            // 
            this.textUserName.Location = new System.Drawing.Point(152, 205);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(100, 22);
            this.textUserName.TabIndex = 2;
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(152, 262);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(100, 22);
            this.textPass.TabIndex = 3;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(381, 48);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 23);
            this.buttonDodaj.TabIndex = 4;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // textDatRod
            // 
            this.textDatRod.Location = new System.Drawing.Point(152, 321);
            this.textDatRod.Name = "textDatRod";
            this.textDatRod.Size = new System.Drawing.Size(100, 22);
            this.textDatRod.TabIndex = 5;
            // 
            // textPrezime
            // 
            this.textPrezime.Location = new System.Drawing.Point(152, 96);
            this.textPrezime.Name = "textPrezime";
            this.textPrezime.Size = new System.Drawing.Size(100, 22);
            this.textPrezime.TabIndex = 6;
            // 
            // buttonIzadi
            // 
            this.buttonIzadi.Location = new System.Drawing.Point(381, 320);
            this.buttonIzadi.Name = "buttonIzadi";
            this.buttonIzadi.Size = new System.Drawing.Size(75, 23);
            this.buttonIzadi.TabIndex = 7;
            this.buttonIzadi.Text = "Izađi";
            this.buttonIzadi.UseVisualStyleBackColor = true;
            this.buttonIzadi.Click += new System.EventHandler(this.buttonIzadi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "UserName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Datum Rođenja";
            // 
            // UpisKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonIzadi);
            this.Controls.Add(this.textPrezime);
            this.Controls.Add(this.textDatRod);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textIme);
            this.Name = "UpisKorisnika";
            this.Text = "UpisKorisnika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textIme;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.TextBox textDatRod;
        private System.Windows.Forms.TextBox textPrezime;
        private System.Windows.Forms.Button buttonIzadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}