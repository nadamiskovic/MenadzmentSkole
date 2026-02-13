using System;
<<<<<<< HEAD
using System.Linq;
=======
>>>>>>> 0f4fabc60a31d0da0418fdfdd341fd6e97348ddd
using System.Collections.Generic;

namespace projekatOop
{
<<<<<<< HEAD

    public class Ucenik : Nezaposleni
    {

        public string Ime { get; set; } = string.Empty;
        public string Prezime { get; set; } = string.Empty;
        public string JMBG { get; set; } = string.Empty;

=======
    // Model učenika — domenska logika učenika može stajati ovde
    public class Ucenik
    {
        public string Ime { get; set; } = string.Empty;
        public string Prezime { get; set; } = string.Empty;
        public string Jmbg { get; set; } = string.Empty;
>>>>>>> 0f4fabc60a31d0da0418fdfdd341fd6e97348ddd
        public string Odeljenje { get; set; } = string.Empty;

        public double Prosek { get; set; }
        public DateTime DatumUpisa { get; set; }
        public VladanjeEnum Vladanje { get; set; }
        public MaturaEnum Matura { get; set; }

<<<<<<< HEAD
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
=======
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
>>>>>>> 0f4fabc60a31d0da0418fdfdd341fd6e97348ddd
        }
    }
}