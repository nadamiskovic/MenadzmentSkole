using System;

namespace projekatOop
{
    /// <summary>
    /// Dani u nedelji (na srpskom) za raspored
    /// </summary>
    public enum Dan
    {
        Ponedeljak,
        Utorak,
        Sreda,
        Cetvrtak,
        Petak,
        Subota,
        Nedelja
    }

    /// <summary>
    /// Predstavlja jedan zapis (čas) u rasporedu
    /// </summary>
    public class RasporedCasa
    {
        /// <summary>
        /// Jedinstveni identifikator časa
        /// </summary>
        public Guid id { get; private set; }

        /// <summary>
        /// Naziv časa (npr. "Matematika - I/1")
        /// </summary>
        public string nazivCasa { get; set; }

        /// <summary>
        /// Dan održavanja časa
        /// </summary>
        public Dan dan { get; set; }

        /// <summary>
        /// Vreme početka časa
        /// </summary>
        public TimeSpan vremeOd { get; set; }

        /// <summary>
        /// Vreme završetka časa
        /// </summary>
        public TimeSpan vremeDo { get; set; }

        /// <summary>
        /// Učionica u kojoj se čas održava
        /// </summary>
        public string ucionica { get; set; }

        /// <summary>
        /// Referenca na objekat profesora (ne string)
        /// </summary>
        public Profesor profesor { get; set; }

        public RasporedCasa()
        {
            id = Guid.NewGuid();
        }

        public RasporedCasa(string naziv, Dan dan, TimeSpan vremeOd, TimeSpan vremeDo, string ucionica, Profesor profesor) : this()
        {
            this.nazivCasa = naziv;
            this.dan = dan;
            this.vremeOd = vremeOd;
            this.vremeDo = vremeDo;
            this.ucionica = ucionica;
            this.profesor = profesor ?? throw new ArgumentNullException(nameof(profesor));
        }

        /// <summary>
        /// Izmeni podatke o času.
        /// Menjanje profesora predstavlja zamenski profesor.
        /// </summary>
        public void izmeniCas(string noviNaziv, Dan noviDan, TimeSpan novoVremeOd, TimeSpan novoVremeDo, string novaUcionica, Profesor noviProfesor)
        {
            if (noviProfesor == null) throw new ArgumentNullException(nameof(noviProfesor));
            nazivCasa = noviNaziv;
            dan = noviDan;
            vremeOd = novoVremeOd;
            vremeDo = novoVremeDo;
            ucionica = novaUcionica;
            profesor = noviProfesor;
        }

        /// <summary>
        /// Pomoćna metoda za zapisivanje u čitljiv oblik
        /// </summary>
        public string ispisiPodatke()
        {
            return $"{nazivCasa} - {dan} {vremeOd:hh\\:mm}-{vremeDo:hh\\:mm} ucionica: {ucionica} profesor: {profesor?.ispisiPodatke()}";
        }
    }
}