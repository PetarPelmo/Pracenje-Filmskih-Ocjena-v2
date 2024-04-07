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
            this.filterBox = new System.Windows.Forms.ComboBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // filterBox
            // 
            this.filterBox.FormattingEnabled = true;
            this.filterBox.Items.AddRange(new object[] {
            "Godine",
            "Ime"});
            this.filterBox.Location = new System.Drawing.Point(357, 89);
            this.filterBox.Margin = new System.Windows.Forms.Padding(2);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(126, 21);
            this.filterBox.TabIndex = 17;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(357, 40);
            this.searchBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(126, 20);
            this.searchBox.TabIndex = 16;
            this.searchBox.Text = "Search";
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(588, 168);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(89, 58);
            this.edit.TabIndex = 15;
            this.edit.Text = "Uredi";
            this.edit.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(588, 244);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(89, 58);
            this.delete.TabIndex = 14;
            this.delete.Text = "Obriši";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(588, 89);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(89, 57);
            this.add.TabIndex = 13;
            this.add.Text = "Dodaj";
            this.add.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.listBox2.Location = new System.Drawing.Point(67, 89);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(197, 277);
            this.listBox2.TabIndex = 12;
            // 
            // Korisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filterBox);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.listBox2);
            this.Name = "Korisnici";
            this.Text = "Korisnik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox filterBox;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ListBox listBox2;
    }
}