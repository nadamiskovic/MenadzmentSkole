using System;

namespace projekatOop
{
<<<<<<< HEAD
    public class Profesor
    {
        public Guid id { get; private set; }

        public string ime { get; set; }

        public string prezime { get; set; }

=======
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
>>>>>>> 0f4fabc60a31d0da0418fdfdd341fd6e97348ddd
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

<<<<<<< HEAD

=======
        /// <summary>
        /// Ispiši podatke o profesoru u čitljiv oblik (korisno za UI ili log)
        /// </summary>
>>>>>>> 0f4fabc60a31d0da0418fdfdd341fd6e97348ddd
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