using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracenje_filmskih_ocjena.Model
{
    internal class FilmIKor : IComparable
    {
        private int IFilmIKor;
        private string Ocjena_;
        private korisnik Username_;
        private string Opis_;

        public int IFilmIKor { get { return IFilmIKor; } set { IFilmIKor = value; } }
        public string Ocjena_ { get { return Ocjena_; } set { Ocjena_ = value; } }
        public string Username_ { get { return Username_; } set { Username_ = value; } }
        public string Opis_ { get { return Opis_; } set { Opis_ = value; } }

        public int CompareTo(object obj)
        {
            int rez = this.IFilmIKor.CompareTo(((FilmIKor)obj).IFilmIKor);

            return rez;

        }

        public override string ToString() => this.Ocjena_ + ' ' + this.korisnik.Username_ + ',' + this.Opis_;

    }
}
