using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracenje_filmskih_ocjena
{
    public class ocjena: IComparable
    {
        private int brojOcjene;
        private string description;
        private int idOcjene;
        private Filmovi naziv;
        private Korisnici username;


        public int BrojOcjene { get { return brojOcjene; } set { this.brojOcjene = value; } }
        public string Description { get { return description; } set { description = value; } }
        public int IdOcjene { get { return idOcjene; } set { idOcjene = value; } }
        public Filmovi Film { get { return naziv; } set { naziv = value; } }
        public Korisnici Korisnici { get { return username; } set { username = value; } }
        public int CompareTo(object obj)
        {

            int rez = this.idOcjene.CompareTo(((ocjena)obj).idOcjene);

            return rez;

        }

        public override string ToString() => this.BrojOcjene + "\n" + this.Description + "\n" + this.IdOcjene;

    }
}