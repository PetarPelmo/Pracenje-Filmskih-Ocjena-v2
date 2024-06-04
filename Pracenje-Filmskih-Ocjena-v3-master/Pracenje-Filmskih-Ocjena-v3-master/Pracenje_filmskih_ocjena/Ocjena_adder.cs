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
    public partial class Ocjena_adder : Form
    {
        Podatkovni_kontekst kontekst;
        Ocjena ocjena_;
        public Ocjena_adder()
        {
            InitializeComponent();
            this.kontekst = new Podatkovni_kontekst();
        }

        private void OcjenaAdder_Click(object sender, EventArgs e)
        {
            this.ocjena_ = new Ocjena();
            ocjena_.username = Text.Parse(OcjenaTXT);
        }


        private void Dodaj_Ocjenu(object sender, EventArgs e)
        {
            List<Filmovi_i_korisnici> film = this.kontekst.UcitajFilmIKor();
            foreach (Filmovi_i_korisnici g in film)
                listbox1.Items.Add(g);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
