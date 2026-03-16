using System;
using System.Collections.Generic;

namespace projekatOop
{
    public class Ucenik : Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public string Jmbg { get; set; } = string.Empty;//prazan tekst
        public string Odeljenje { get; set; } = string.Empty;
        public double Prosek { get; set; }
        public DateTime DatumUpisa { get; set; }

        public VladanjeEnum Vladanje { get; set; }
        public MaturaEnum Matura { get; set; }

        public Roditelj? Roditelj { get; set; }//?-nullable, dete moze imati unete podatke o roditelju ali ne mora

        public List<Dostignuce> Dostignuca { get; } = new();//kreira listu dostignuca od svojstav dostignuca iz klase
        //ima samo get-ne moze se postavljati nova lista
        public Ucenik(string ime, string prezime, string jmbg)
        {
            Ime = ime;
            Prezime = prezime;
            Jmbg = jmbg;
        }

        public Ucenik()
        {
            Ime = string.Empty;
            Prezime = string.Empty;
        }

        public string IspisiPodatke()
        {
            return $"{Ime} {Prezime}, JMBG: {Jmbg}, Odeljenje: {Odeljenje}, Prosek: {Prosek}";
        }
        //override sam poziva moju metodu ako ja zaboravim
        public override string ToString()//override se koristi za prethodno definisane metode(da im da novu funkciju)
        {
            return IspisiPodatke();
        }
    }
}
