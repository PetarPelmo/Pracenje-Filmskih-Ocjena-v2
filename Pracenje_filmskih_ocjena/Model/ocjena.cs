using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracenje_filmskih_ocjena
{
    public class ocjena : IComparable
    {
        private int id;
        private korisnik ime;
        private film naziv;
        private string desc;

        public int Id { get { return id; } set { id = value; } }
        public film Naziv { get { return naziv; } set { naziv = value; } }
        public korisnik Ime { get { return ime; } set { ime = value; } }
        public string Desc { get { return desc; } set { desc = value; } }

        public int CompareTo(object obj)
        {
            int rez = this.id.CompareTo(((ocjena)obj).id);
           /* if (rez == 0) rez = this.naziv.CompareTo(((ocjena)obj).naziv);
            if (rez == 0) rez = this.ime.CompareTo(((ocjena)obj).ime);
           nije potrebno kompareati vise od ID-a*/
            return rez;
        }
        public override string ToString()

           => ime.ToString() + "\n" + naziv.ToString() + "\n" + desc + "->" + Id.ToString();
    }
}
