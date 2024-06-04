using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracenje_filmskih_ocjena
{
    internal class filmovi: IComparable
    {
        private string naziv;
        private string redatelj;
        private string zarn;
        private int boxOffice;
        private int serijski_broj;


        public filmovi() { }

        public filmovi(string naziv, string redatelj, string zarn, int boxOffice, int serijski_broj)
        {
            this.naziv = naziv;
            this.redatelj = redatelj;
            this.zarn = zarn;
            this.boxOffice = boxOffice;
            this.serijski_broj = serijski_broj;
        }

        public string Naziv { get { return naziv; } set { naziv = value; } }
        public string Redatelj { get { return naziv; } set { naziv = value; } }
        public string Zarn { get { return zarn; } set { zarn = value; } }

        public int BoxOffice { get { return boxOffice; } }
        public int Serijski_Broj { get { return serijski_broj; } set { serijski_broj = value; } }


        public int CompareTo(object obj)
        {
            int rez = this.naziv.CompareTo(((filmovi)obj).serijski_broj);
            return rez;
        }
        public override string ToString() => naziv + ", " + zarn + ",  " + redatelj + " -> " + serijski_broj.ToString();
    }
}
