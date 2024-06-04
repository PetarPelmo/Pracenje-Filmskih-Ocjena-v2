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
        private List<FilmIKor> FilmoviIKor_;
        private List<ocjena> _ocjena;
        public List<korisnik> Korisnici { get { return _korisnici; } }
        public List<FilmIKor> FilmoviIKor { get { return FilmoviIKor_; } }
        public List<ocjena> Ocjena { get { return _ocjena; } }


        public Podatkovni_kontekst()
        {

            _korisnici = UcitajKorisnike();
            FilmoviIKor_ = UcitajFilmIKor();
        }

        private string datKorisnici = "datFilmovi.dat";
        private string datFilmIKor = "datFilmIKor.dat";
        private string datOcjena = "datOcjene.dat";


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

        public List<FilmIKor> UcitajFilmIKor()
        {

            List<FilmIKor> FilmIKor_ = new List<FilmIKor>();

            if (File.Exists(datFilmIKor))
            {
                using (StreamReader sr = new StreamReader(datFilmIKor))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] polja = line.Split('|');
                        FilmIKor g = new FilmIKor();

                        Ocjena_ = polja[0];
                        Username_ = polja[1];
                        Opis_ = polja[2];

                        var polja2 = polja[3].Split(',');
                        g.IFilmIKor = new Filmovi_i_korisnici();
                        FilmIKor_.Add(g);
                    }
                }
            }
            return FilmIKor_;
        }

        public void SpremiFilmIKor(FilmIKor g)
        {
            FilmoviIKor_.Add(g);
            using (StreamWriter sw = new StreamWriter(datFilmIKor))
            {
                foreach (var item in FilmoviIKor_)
                {
                    sw.WriteLine($"{item.Ocjena_}|{item.Username_}|{item.Opis_}");
                }
            }
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