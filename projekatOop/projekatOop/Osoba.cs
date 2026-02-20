using System;
using System.Collections.Generic;
using System.Text;

namespace projekatOop
{
    public abstract class Osoba : IOsoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }

        protected Osoba(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }
    }
}
