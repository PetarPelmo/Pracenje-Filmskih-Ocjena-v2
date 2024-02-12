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
        private List<Filmovi> _filmovi;
        public List<Filmovi> filmovi { get { return this._filmovi; } }


        private string datFilmovi = "datFilmovi.dat";


        private List<Filmovi> UcitajZaposlenike()
        {
            List<Filmovi> zaposlenici = new List<Filmovi>();

            if (File.Exists(datFilmovi))
            {
                using (StreamReader sr = new StreamReader(datFilmovi))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();

                        string[] polja = line.Split('|');

                        Filmovi z = new Filmovi();
                        z.Naziv = polja[0];
                        z.Redatelj = polja[1];
                        z.BoxOffice = int.Parse(polja[2]);

                        zaposlenici.Add(z);

                    }
                }
            }

            return zaposlenici;

        }
    }

        public void SpremiFilm()
        {

            using (StreamWriter sw = new StreamWriter(datFilmovi))
            {
                foreach (Filmovi z in this.filmovi)
                {
                    sw.WriteLine($"{z.Naziv}, {z.Redatelj}, {z.BoxOffice}");
                }

            }

        }
    }