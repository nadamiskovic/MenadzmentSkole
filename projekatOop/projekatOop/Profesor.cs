using System;

namespace projekatOop
{
    public class Profesor : Osoba
    {
        public Guid Id { get; private set; } 
        public string Predmet { get; set; } = string.Empty;

        public Profesor(string ime, string prezime, string predmet)
            : base(ime, prezime)
        {
            this.Id = Guid.NewGuid();
            this.Predmet = predmet;
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