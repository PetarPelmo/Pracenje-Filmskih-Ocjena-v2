using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracenje_filmskih_ocjena.Model
{
    internal class Podatkovni_kontekst
    {
        private List<Korisnici> _korisnici;
        public List<Korisnici> Korisnici{ get { return this._korisnici; } }

        public Podatkovni_kontekst()
        {

            this._korisnici= UcitajKorisnike();

        }

        private string datKorisnici = "datFilmovi.dat";


        public List<Korisnici> UcitajKorisnike()
        {
            List<Korisnici> korisnici = new List<Korisnici>();

            if (File.Exists(datKorisnici))
            {
                using (StreamReader sr = new StreamReader(datKorisnici))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();

                        string[] polja = line.Split('|');

                        Korisnici z = new Korisnici(polja[0], polja[1], int.Parse(polja[2]), polja[3]);

                        korisnici.Add(z);

                    }
                }
            }

            return korisnici;

        }
    }

    public void SpremiKorisnike(Korisnici kor)
    {
        this.korisnici.Add(kor);
        using (StreamWriter sw = new StreamWriter(datKorisnici))
        {
            foreach (Korisnici z in this.korisnici)
            {
                sw.WriteLine($"{z.Ime}|{z.Prezime}|{z.Email}|{z.Username}|{z.Password}");
            }
            sw.Close();
        }

    }

    public void ObrisiKorisnike(Korisnici kor)
        {
        using (StreamWriter sw = new StreamWriter(datKorisnici))
        {
            foreach (Korisnici z in this.Korisnici)
            {
                if (z.Ime.Equals(kor.Ime) && z.Prezime.Equals(kor.Prezime) && z.Email.Equals(kor.Email) && z.Password.Equals(kor.Password))
                {   continue;   }
                else
                {   sw.WriteLine($"{z.Ime}|{z.Prezime}|{z.Email}|{z.Username}|{z.Password}");   }
            }
            sw.Close();
        }
    }
}