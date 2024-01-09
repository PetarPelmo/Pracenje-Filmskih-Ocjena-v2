namespace Pracenje_filmskih_ocjena
{
    partial class Korisnici
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
            this.edit2 = new System.Windows.Forms.Button();
            this.delete2 = new System.Windows.Forms.Button();
            this.add3 = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // edit2
            // 
            this.edit2.Location = new System.Drawing.Point(295, 123);
            this.edit2.Name = "edit2";
            this.edit2.Size = new System.Drawing.Size(89, 23);
            this.edit2.TabIndex = 17;
            this.edit2.Text = "Uredi";
            this.edit2.UseVisualStyleBackColor = true;
            this.edit2.Click += new System.EventHandler(this.edit2_Click);
            // 
            // delete2
            // 
            this.delete2.Location = new System.Drawing.Point(295, 199);
            this.delete2.Name = "delete2";
            this.delete2.Size = new System.Drawing.Size(89, 23);
            this.delete2.TabIndex = 16;
            this.delete2.Text = "Obriši";
            this.delete2.UseVisualStyleBackColor = true;
            // 
            // add3
            // 
            this.add3.Location = new System.Drawing.Point(295, 56);
            this.add3.Name = "add3";
            this.add3.Size = new System.Drawing.Size(89, 23);
            this.add3.TabIndex = 15;
            this.add3.Text = "Dodaj";
            this.add3.UseVisualStyleBackColor = true;
            this.add3.Click += new System.EventHandler(this.add3_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(197, 277);
            this.listBox.TabIndex = 14;
            // 
            // Korisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.edit2);
            this.Controls.Add(this.delete2);
            this.Controls.Add(this.add3);
            this.Controls.Add(this.listBox);
            this.Name = "Korisnik";
            this.Text = "Korisnik";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button edit2;
        private System.Windows.Forms.Button delete2;
        private System.Windows.Forms.Button add3;
        private System.Windows.Forms.ListBox listBox;
    }
}