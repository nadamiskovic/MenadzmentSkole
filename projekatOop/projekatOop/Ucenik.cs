using System;
using System.Collections.Generic;

namespace projekatOop
{
    // Model učenika — domenska logika učenika može stajati ovde
    public class Ucenik
    {
        public string Ime { get; set; } = string.Empty;
        public string Prezime { get; set; } = string.Empty;
        public string Jmbg { get; set; } = string.Empty;
        public string Odeljenje { get; set; } = string.Empty;

        public double Prosek { get; set; }
        public DateTime DatumUpisa { get; set; }
        public VladanjeEnum Vladanje { get; set; }
        public MaturaEnum Matura { get; set; }

        public Roditelj? Roditelj { get; set; }

        // Kolekcija dostignuća povezana sa ovim učenikom (navigaciono polje)
        public List<Dostignuce> Dostignuca { get; } = new();

        // Primer metode domenske logike (može se proširiti)
        public void DodajUcenika()
        {
            // Validacije ili dodatna pravila mogu biti ovde
        }

        public void UkloniUcenika()
        {
            // Logika pri uklanjanju (ako treba)
        }

        public string IspisiPodatke()
        {
            return $"{Ime} {Prezime}, JMBG: {Jmbg}, Odeljenje: {Odeljenje}, Prosek: {Prosek}, Vladanje: {Vladanje}, Matura: {Matura}, Roditelj: {Roditelj?.IspisiPodatke()}";
        }
    }
}