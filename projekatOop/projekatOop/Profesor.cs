using System;

namespace projekatOop
{
    public class Profesor : Osoba
    {
        public string Ime { get; set; } = string.Empty;
        public string Prezime { get; set; } = string.Empty;

        public Guid Id { get; private set; } 
        public string Predmet { get; set; } = string.Empty;

        public Profesor(string ime, string prezime, string predmet)
        {
            Id = Guid.NewGuid();
            Ime = ime;
            Prezime = prezime;
            Predmet = predmet;
        }

        public Profesor()
        {
            Id = Guid.NewGuid();
            Ime = string.Empty;
            Prezime = string.Empty;
            Predmet = string.Empty;
        }

        public string IspisiPodatke()
        {
            return $"{Ime} {Prezime} ({Predmet})";
        }

        public override string ToString()
        {
            return IspisiPodatke();
        }
    }
}
