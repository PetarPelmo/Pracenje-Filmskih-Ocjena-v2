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
        private List<korisnik> _korisnici;
        public List<korisnik> Korisnici { get { return this._korisnici; } }

        public Podatkovni_kontekst()
        {

            this._korisnici = UcitajKorisnike(z, z, z);

        }

        private string datKorisnici = "datFilmovi.dat";


        public List<korisnik> UcitajKorisnike(Korisnici z, Korisnici z, Korisnici z)
        {
            List<korisnik> korisnici = new List<korisnik>();

            if (File.Exists(datKorisnici))
            {
                using (StreamReader sr = new StreamReader(datKorisnici))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();

                        string[] polja = line.Split('|');

                        Korisnici kor = new Korisnici(polja[0], polja[1], polja[2], polja[3], polja[4]);

                        korisnici.Add(kor);

                    }
                }
            }

            return korisnici;

        }


        public void SpremiKorisnike(Korisnici kor)
        {
            this.Korisnici.Add(kor);
            using (StreamWriter sw = new StreamWriter(datKorisnici))
            {
                foreach (Korisnici z in this.Korisnici)
                {
                    sw.WriteLine($"{z.Ime}|{z.Prezime}|{z.Email}|{z.Username}|{z.Password}");
                }
                sw.Close();
            }

        }

        public void ObrisiKorisnike(korisnik kor)
        {
            using (StreamWriter sw = new StreamWriter(datKorisnici))
            {
                foreach (korisnik z in this.Korisnici)
                {
                    if (z.Ime.Equals(kor.Ime) && z.Prezime.Equals(kor.Prezime) && z.Email.Equals(kor.Email) && z.Password.Equals(kor.Password))
                    { continue; }
                    else
                    { sw.WriteLine($"{z.Ime}|{z.Prezime}|{z.Email}|{z.Username}|{z.Password}"); }
                }
                sw.Close();
            }
        }
    }
}