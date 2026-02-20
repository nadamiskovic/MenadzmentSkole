using System;
using System.Collections.Generic;

namespace projekatOop
{
    public class Ucenik : Osoba
    {
        public string Jmbg { get; set; } = string.Empty;
        public string Odeljenje { get; set; } = string.Empty;
        public double Prosek { get; set; }
        public DateTime DatumUpisa { get; set; }

        public VladanjeEnum Vladanje { get; set; }
        public MaturaEnum Matura { get; set; }

        public Roditelj? Roditelj { get; set; }

        public List<Dostignuce> Dostignuca { get; } = new();

        public Ucenik(string ime, string prezime, string jmbg)
            : base(ime, prezime)
        {
            Jmbg = jmbg;
        }

        public Ucenik() : base(string.Empty, string.Empty)
        {
        }

        public string IspisiPodatke()
        {
            return $"{Ime} {Prezime}, JMBG: {Jmbg}, Odeljenje: {Odeljenje}, Prosek: {Prosek}";
        }

        public override string ToString()
        {
            return IspisiPodatke();
        }
    }
}