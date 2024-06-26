﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracenje_filmskih_ocjena
{
    internal class korisnik: IComparable
    {
        private int id;
        private string ime;
        private string prezime;
        private string email;
        private string username;
        private string password;
        public korisnik(string text, string text1, string text2) { }

        public korisnik(string ime, string prezime, string email, string username, string password)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.email = email;
            this.username = username;
            this.password = password;        }

        public int Id { get { return id; } set { id = value; } }
        public string Ime { get { return ime; } set { ime = value; } }
        public string Prezime { get { return prezime; } set { prezime = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }

        public int CompareTo(object obj)
        {
            int rez = this.id.CompareTo(((korisnik)obj).id);
            return rez;
        }
        public override string ToString() => Username + ", " + Email + " -> " + Id.ToString();
    }
}
