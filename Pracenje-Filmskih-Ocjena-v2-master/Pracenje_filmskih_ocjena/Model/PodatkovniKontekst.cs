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
        public List<korisnik> Korisnici { get { return _korisnici; } }

        public Podatkovni_kontekst()
        {

            _korisnici = UcitajKorisnike();

        }

        private string datKorisnici = "datFilmovi.dat";

        

        public List<korisnik> UcitajKorisnike()
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

                        korisnik zkor = new korisnik(polja[0], polja[1], polja[2], polja[3], polja[4]);

                        korisnici.Add(zkor);

                    }
                }
            }

            return korisnici;

        }


        public void SpremiKorisnike(korisnik kor)
        {
            Korisnici.Add(kor);
            using (StreamWriter sw = new StreamWriter(datKorisnici))
            {
                foreach (korisnik z in Korisnici)
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
                foreach (korisnik z in Korisnici)
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