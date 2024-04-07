using Pracenje_filmskih_ocjena.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pracenje_filmskih_ocjena
{
    public partial class Korisnici : Form
    {
        List<Model.korisnik> korisniciPrikaz = new List<Model.korisnik>();
        Podatkovni_kontekst podatkovnikontekst;
        bool searched = false;
        public Korisnici()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            new Korisnici_adder().Show();
        }

        private void addKor()
        {

            Podatkovni_kontekst podatkovniKontekst = new Podatkovni_kontekst();

            listBox2.Items.Clear();
            List<Model.korisnik> korisnici = podatkovniKontekst.UcitajKorisnike();


            if (korisniciPrikaz.Count > 0 || searched)
            {
                foreach (Model.korisnik kor in korisniciPrikaz)
                {
                    listBox2.Items.Add(kor);
                }
            }

            else
            {
                foreach (Model.korisnik kor in korisnici)
                {
                    listBox2.Items.Add(kor);
                }

            }

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            // addKor();

        }

        private void Korisnici_load(object sender, EventArgs e)
        {

            addKor();

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            searched = true;
            korisniciPrikaz.Clear();

            podatkovnikontekst = new Podatkovni_kontekst();

            List<Model.korisnik> KorisniciKomplet = podatkovnikontekst.UcitajKorisnike();

            foreach (Model.korisnik kor in KorisniciKomplet)
                if (kor.Prezime.Contains(searchBox.Text.ToLower())) korisniciPrikaz.Add(kor);

            addKor();

        }

        private void filter_SelectedIndexChanged(object sender, EventArgs e)
        {

            korisniciPrikaz.Clear();
            podatkovnikontekst = new Podatkovni_kontekst();
            List<Model.korisnik> KorisniciFilter = this.podatkovnikontekst.UcitajKorisnike();

            if (filterBox.SelectedItem.ToString() == "Godine")
            {
                KorisniciFilter.Sort((z1, z2) => z2.Godine.CompareTo(z1.Godine));

                foreach (Model.korisnik kor in KorisniciFilter)
                {
                    korisniciPrikaz.Add(kor);
                }
            }

            if (filterBox.SelectedItem.ToString() == "Ime")
            {

                KorisniciFilter.Sort((z1, z2) => z2.Ime.CompareTo(z1.Ime));
                KorisniciFilter.Reverse();
                foreach (Model.korisnik kor in KorisniciFilter)
                {
                    korisniciPrikaz.Add(kor);
                }
            }
            addKor();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Podatkovni_kontekst podatkovni = new Podatkovni_kontekst();

            if (listBox2.SelectedIndex == -1) return;
            else
            {

                Model.Korisnici kor = listBox2.SelectedItem as Model.Korisnici;

                podatkovni.ObrisiKorisnike(kor);

            }
            korisniciPrikaz = podatkovni.UcitajKorisnike();
            addKor();
        }


    }
}