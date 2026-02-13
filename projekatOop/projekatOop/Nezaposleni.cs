using System;
using System.Collections.Generic;
using System.Text;

namespace projekatOop
{
    public interface Nezaposleni

    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string JMBG { get; set; }

        void Dodaj();
        void Izbrisi();
        void Izmeni();


    }
}
