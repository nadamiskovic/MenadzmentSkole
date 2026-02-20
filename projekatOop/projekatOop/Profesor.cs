using System;

namespace projekatOop
{
    public class Profesor
    {
        public Guid id { get; private set; }

        public string ime { get; set; } = string.Empty;
        public string prezime { get; set; } = string.Empty;
        public string predmet { get; set; } = string.Empty;

        public Profesor()
        {
            id = Guid.NewGuid();
        }

        public Profesor(string ime, string prezime, string predmet) : this()
        {
            this.ime = ime;
            this.prezime = prezime;
            this.predmet = predmet;
        }

        public string ispisiPodatke()
        {
            return $"{ime} {prezime} ({predmet})";
        }

        public override string ToString()
        {
            return ispisiPodatke();
        }
    }
}