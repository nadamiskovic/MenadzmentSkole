using System;

namespace projekatOop
{
    /// <summary>
    /// Predstavlja profesora koji može biti dodeljen više časova.
    /// </summary>
    public class Profesor
    {
        /// <summary>
        /// Jedinstveni identifikator profesora
        /// </summary>
        public Guid id { get; private set; }

        /// <summary>
        /// Ime profesora
        /// </summary>
        public string ime { get; set; }

        /// <summary>
        /// Prezime profesora
        /// </summary>
        public string prezime { get; set; }

        /// <summary>
        /// Predmet koji profesor predaje
        /// </summary>
        public string predmet { get; set; }

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

        /// <summary>
        /// Ispiši podatke o profesoru u čitljiv oblik (korisno za UI ili log)
        /// </summary>
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