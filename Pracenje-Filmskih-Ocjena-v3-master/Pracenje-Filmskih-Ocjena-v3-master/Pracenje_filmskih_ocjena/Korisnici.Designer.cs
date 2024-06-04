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
            this.DeleteKorisnik = new System.Windows.Forms.Button();
            this.UpDown = new System.Windows.Forms.Button();
            this.SortKorisnik = new System.Windows.Forms.ComboBox();
            this.Search = new System.Windows.Forms.Label();
            this.SearchKorisnik = new System.Windows.Forms.TextBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.UrediButton = new System.Windows.Forms.Button();
            this.DodajButton = new System.Windows.Forms.Button();
            this.ListBoxKor = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // DeleteKorisnik
            // 
            this.DeleteKorisnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteKorisnik.Location = new System.Drawing.Point(308, 238);
            this.DeleteKorisnik.Name = "DeleteKorisnik";
            this.DeleteKorisnik.Size = new System.Drawing.Size(68, 46);
            this.DeleteKorisnik.TabIndex = 26;
            this.DeleteKorisnik.Text = "Izbriši";
            this.DeleteKorisnik.UseVisualStyleBackColor = true;
            this.DeleteKorisnik.Visible = false;
            // 
            // UpDown
            // 
            this.UpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDown.Location = new System.Drawing.Point(320, 176);
            this.UpDown.Name = "UpDown";
            this.UpDown.Size = new System.Drawing.Size(45, 46);
            this.UpDown.TabIndex = 25;
            this.UpDown.Text = "↑↓";
            this.UpDown.UseVisualStyleBackColor = true;
            this.UpDown.Visible = false;
            // 
            // SortKorisnik
            // 
            this.SortKorisnik.FormattingEnabled = true;
            this.SortKorisnik.Items.AddRange(new object[] {
            "Cijena noci",
            "Velicina sobe"});
            this.SortKorisnik.Location = new System.Drawing.Point(285, 131);
            this.SortKorisnik.Margin = new System.Windows.Forms.Padding(2);
            this.SortKorisnik.Name = "SortKorisnik";
            this.SortKorisnik.Size = new System.Drawing.Size(126, 21);
            this.SortKorisnik.TabIndex = 24;
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Location = new System.Drawing.Point(283, 38);
            this.Search.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(41, 13);
            this.Search.TabIndex = 23;
            this.Search.Text = "Search";
            // 
            // SearchKorisnik
            // 
            this.SearchKorisnik.Location = new System.Drawing.Point(285, 54);
            this.SearchKorisnik.Margin = new System.Windows.Forms.Padding(2);
            this.SearchKorisnik.Name = "SearchKorisnik";
            this.SearchKorisnik.Size = new System.Drawing.Size(126, 20);
            this.SearchKorisnik.TabIndex = 22;
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(634, 27);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(56, 47);
            this.refreshButton.TabIndex = 21;
            this.refreshButton.Text = "⟳";
            this.refreshButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.refreshButton.UseVisualStyleBackColor = true;
            // 
            // UrediButton
            // 
            this.UrediButton.Location = new System.Drawing.Point(475, 242);
            this.UrediButton.Name = "UrediButton";
            this.UrediButton.Size = new System.Drawing.Size(114, 38);
            this.UrediButton.TabIndex = 20;
            this.UrediButton.Text = "Uredi";
            this.UrediButton.UseVisualStyleBackColor = true;
            // 
            // DodajButton
            // 
            this.DodajButton.Location = new System.Drawing.Point(475, 160);
            this.DodajButton.Name = "DodajButton";
            this.DodajButton.Size = new System.Drawing.Size(114, 43);
            this.DodajButton.TabIndex = 19;
            this.DodajButton.Text = "Dodaj";
            this.DodajButton.UseVisualStyleBackColor = true;
            // 
            // ListBoxKor
            // 
            this.ListBoxKor.FormattingEnabled = true;
            this.ListBoxKor.Location = new System.Drawing.Point(12, 63);
            this.ListBoxKor.Name = "ListBoxKor";
            this.ListBoxKor.Size = new System.Drawing.Size(219, 303);
            this.ListBoxKor.TabIndex = 18;
            // 
            // Korisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteKorisnik);
            this.Controls.Add(this.UpDown);
            this.Controls.Add(this.SortKorisnik);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SearchKorisnik);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.UrediButton);
            this.Controls.Add(this.DodajButton);
            this.Controls.Add(this.ListBoxKor);
            this.Name = "Korisnici";
            this.Text = "Korisnik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteKorisnik;
        private System.Windows.Forms.Button UpDown;
        private System.Windows.Forms.ComboBox SortKorisnik;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.TextBox SearchKorisnik;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button UrediButton;
        private System.Windows.Forms.Button DodajButton;
        private System.Windows.Forms.ListBox ListBoxKor;
    }
}