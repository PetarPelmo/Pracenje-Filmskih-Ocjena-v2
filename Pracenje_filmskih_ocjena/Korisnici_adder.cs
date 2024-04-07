using Pracenje_filmskih_ocjena.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pracenje_filmskih_ocjena
{
    public partial class Korisnici_adder : Form
    {
        Podatkovni_kontekst podatkovniKontekst;
        Model.korisnik korisnici_;
        public Korisnici_adder()
        {
            InitializeComponent();
            
            this.podatkovniKontekst = new Podatkovni_kontekst();
        }

        private void zivotinja_add_Click(object sender, EventArgs e)
        {

            this.korisnici_ = new Model.korisnik(this.ime.Text, this.prezime.Text, this.email.Text, this.username.Text, this.password);
            this.podatkovniKontekst.SpremiKorisnike(this.korisnici_);

            Close();

        }
    }
}
