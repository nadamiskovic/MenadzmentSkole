using System;
using System.Collections.Generic;
using System.Linq;

namespace projekatOop
{
    /// <summary>
    /// Repozitorijum koji čuva sve unete profesore.
    /// Omogućava ponovno korišćenje istih objekata profesora.
    /// </summary>
    public class ProfesorRepository
    {
        private readonly List<Profesor> profesori = new();

        /// <summary>
        /// Dodaj profesora u repozitorijum
        /// </summary>
        public void dodajProfesor(Profesor profesor)
        {
            if (profesor == null) throw new ArgumentNullException(nameof(profesor));
            if (profesori.Any(p => p.id == profesor.id)) return;
            profesori.Add(profesor);
        }

        /// <summary>
        /// Vrati listu svih profesora (kopija liste)
        /// </summary>
        public List<Profesor> vratiSveProfesore()
        {
            return new List<Profesor>(profesori);
        }

        /// <summary>
        /// Pronađi profesora po ID-u
        /// </summary>
        public Profesor nadjiPoId(Guid id)
        {
            return profesori.FirstOrDefault(p => p.id == id);
        }

        /// <summary>
        /// Ukloni profesora po imenu i prezimenu (vraća true ako je nešto uklonjeno)
        /// Korisno kada zaposlenog obrišemo iz Administracija (ZaposleniForm).
        /// </summary>
        public bool ukloniProfesorPoImenuPrezime(string ime, string prezime)
        {
            if (string.IsNullOrWhiteSpace(ime) || string.IsNullOrWhiteSpace(prezime)) return false;
            var toRemove = profesori.Where(p =>
                string.Equals(p.ime, ime, StringComparison.OrdinalIgnoreCase) &&
                string.Equals(p.prezime, prezime, StringComparison.OrdinalIgnoreCase)).ToList();

            if (!toRemove.Any()) return false;
            foreach (var p in toRemove) profesori.Remove(p);
            return true;
        }
    }
}