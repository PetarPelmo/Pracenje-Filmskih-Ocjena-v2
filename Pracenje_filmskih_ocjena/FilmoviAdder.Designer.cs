namespace Pracenje_filmskih_ocjena
{
    partial class FilmoviAdder
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
            this.box_office = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.zarn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.zivotinja_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.redatelj = new System.Windows.Forms.TextBox();
            this.naziv = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // box_office
            // 
            this.box_office.Location = new System.Drawing.Point(304, 300);
            this.box_office.Name = "box_office";
            this.box_office.Size = new System.Drawing.Size(100, 20);
            this.box_office.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Box Office";
            // 
            // zarn
            // 
            this.zarn.Location = new System.Drawing.Point(304, 223);
            this.zarn.Name = "zarn";
            this.zarn.Size = new System.Drawing.Size(100, 20);
            this.zarn.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "zarn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(469, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 24);
            this.label7.TabIndex = 43;
            this.label7.Text = "Dodaj Film";
            // 
            // zivotinja_add
            // 
            this.zivotinja_add.Location = new System.Drawing.Point(533, 186);
            this.zivotinja_add.Name = "zivotinja_add";
            this.zivotinja_add.Size = new System.Drawing.Size(94, 50);
            this.zivotinja_add.TabIndex = 42;
            this.zivotinja_add.Text = "Dodaj";
            this.zivotinja_add.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Redatelj";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Naziv";
            // 
            // redatelj
            // 
            this.redatelj.Location = new System.Drawing.Point(304, 153);
            this.redatelj.Name = "redatelj";
            this.redatelj.Size = new System.Drawing.Size(100, 20);
            this.redatelj.TabIndex = 39;
            // 
            // naziv
            // 
            this.naziv.Location = new System.Drawing.Point(304, 65);
            this.naziv.Name = "naziv";
            this.naziv.Size = new System.Drawing.Size(100, 20);
            this.naziv.TabIndex = 38;
            // 
            // FilmoviAdder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.box_office);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.zarn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.zivotinja_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.redatelj);
            this.Controls.Add(this.naziv);
            this.Name = "FilmoviAdder";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox box_office;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox zarn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button zivotinja_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox redatelj;
        private System.Windows.Forms.TextBox naziv;
    }
}