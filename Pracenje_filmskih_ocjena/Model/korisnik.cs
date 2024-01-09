﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracenje_filmskih_ocjena
{
    public class korisnik : IComparable
    {
        private int id;
        private string ime;
        private string prezime;
        private string email;
        private string username;
        private string password;
        private DateTime godRodj;

        public int Id { get { return id; } set { id = value; } }
        public string Ime { get { return ime; } set { ime = value; } }
        public string Prezime { get { return prezime; } set { prezime = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Username { get { return username; } set { username = value; } }
        public DateTime GodRodj { get { return godRodj; } set { godRodj = value; } }
        public string Password { get { return password; } set { password = value; } }

        public int CompareTo(object obj)
        {
            int rez = this.id.CompareTo(((korisnik)obj).id);
           /* if (rez == 0) rez = this.username.CompareTo(((Korisnik)obj).username);
            if (rez == 0) rez = this.email.CompareTo(((Korisnik)obj).email);
           nije potrebno kompareati vise od ID-a*/
            return rez;
        }
        public override string ToString()

           => Username + ", " + Email + " -> " + Id.ToString();
    }
}
