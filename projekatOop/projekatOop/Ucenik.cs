using System;
using System.Linq;
using System.Collections.Generic;

namespace projekatOop
{

    public class Ucenik : Nezaposleni
    {

        public string Ime { get; set; } = string.Empty;
        public string Prezime { get; set; } = string.Empty;
        public string JMBG { get; set; } = string.Empty;

        public string Odeljenje { get; set; } = string.Empty;

        public double Prosek { get; set; }
        public DateTime DatumUpisa { get; set; }
        public VladanjeEnum Vladanje { get; set; }
        public MaturaEnum Matura { get; set; }

        public List<Roditelj> Staratelj { get; set; } = new List<Roditelj>();


        public List<Dostignuce> Dostignuca { get; } = new();


        public void Dodaj()
        { }


        public void Izbrisi()
        { }

        public void Izmeni()
        { }

        public string IspisiPodatke()
        {

            string imenaRoditelja = string.Join(", ", Staratelj.Select(r => r.Ime));

            return $"{Ime} {Prezime}, JMBG: {JMBG}, Odeljenje: {Odeljenje}, Prosek: {Prosek}, Roditelji: {imenaRoditelja}";
        }
    }
}