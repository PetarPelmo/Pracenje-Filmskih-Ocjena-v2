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
        bool up = true;
        bool searched = false;
        Podatkovni_kontekst kontekst;
        List<korisnik> KorisnikPrikaz = new List<korisnik>();
        public Korisnici()
        {
            InitializeComponent();
            this.kontekst = new Podatkovni_kontekst();

        }



        private void DodajButton_Click(object sender, EventArgs e)
        {
            new KorisniciAdder().Show();

        }

        private void UrediButton_Click(object sender, EventArgs e)
        {
            new Edit().Show();
        }

        private void RefreshSobe()
        {
            ListBoxKor.Items.Clear();


            List<korisnik> korisnikci = this.kontekst.UcitajKorisnike();

            if (KorisnikPrikaz.Count > 0 || searched)
            {
                foreach (korisnik s in KorisnikPrikaz)
                {

                    ListBoxKor.Items.Add(s);
                }
            }
            else
            {
                foreach (korisnik s in korisnikci)
                {
                    ListBoxKor.Items.Add(s);
                }
            }
        }
        private void Sortiranje()
        {
            KorisnikPrikaz.Clear();
            UpDown.Visible = true;
            List<korisnik> SortKorisnik = this.kontekst.UcitajKorisnike();

            if (SortKorisnik.SelectedItem.ToString() == "Ime")
            {

                SortKorisnik.Sort((s1, s2) => s2.Username.CompareTo(s1.Username));

                if (up == true)
                {
                    foreach (korisnik s in SortKorisnik)
                    {

                        KorisnikPrikaz.Add(s);

                    }
                }

                else
                {
                    SortKorisnik.Reverse();

                    foreach (korisnik s in SortKorisnik)
                    {

                        KorisnikPrikaz.Add(s);

                    }
                }
            }

            if (SortKorisnik.SelectedItem.ToString() == "Ime")
            {
                SortKorisnik.Sort((s1, s2) => s2.Ime.CompareTo(s1.Ime));

                if (up == true)
                {
                    foreach (korisnik s in SortKorisnik)
                    {

                        KorisnikPrikaz.Add(s);

                    }
                }

                else
                {
                    SortKorisnik.Reverse();

                    foreach (korisnik s in SortKorisnik)
                    {

                        KorisnikPrikaz.Add(s);

                    }
                }
            }
            RefreshSobe();
        }
        private void Soba_Load(object sender, EventArgs e)
        {

            RefreshSobe();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshSobe();

        }

        private void SearchKorisnik_TextChanged(object sender, EventArgs e)
        {
            searched = true;

            KorisnikPrikaz.Clear();
            List<korisnik> sobaKomplet = this.kontekst.UcitajKorisnike();

            foreach (korisnik s in sobaKomplet)
                if (s.Ime.Contains(SearchKorisnik.Text.ToLower())) KorisnikPrikaz.Add(s);


            RefreshSobe();
        }



        private void UpDown_Click(object sender, EventArgs e)
        {
            up = !up;
            Sortiranje();

        }

        private void SortSoba_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sortiranje();
        }

        private void ListBoxSoba_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeleteKorisnik.Visible = true;
        }

        private void DeleteKorisnik_Click(object sender, EventArgs e)
        {
            if (ListBoxKor.SelectedIndex == -1) return;
            else
            {
                korisnik s = ListBoxKor.SelectedItem as korisnik;

                kontekst.ObrisiKorisnike(s);
            }
            KorisnikPrikaz.Clear();
            searched = false;
            RefreshSobe();
        }
    }
}