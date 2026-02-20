using System;
using System.Collections.Generic;
using System.Linq;

namespace projekatOop
{
    /// <summary>
    /// Repozitorijum koji čuva sve zapise rasporeda (sve instance RasporedCasa)
    /// </summary>
    public class RasporedRepository
    {
        private readonly List<RasporedCasa> casovi = new();

        /// <summary>
        /// Dodaj čas u raspored
        /// </summary>
        public void dodajCas(RasporedCasa cas)
        {
            if (cas == null) throw new ArgumentNullException(nameof(cas));
            if (casovi.Any(c => c.id == cas.id)) return;
            casovi.Add(cas);
        }

        /// <summary>
        /// Ukloni čas iz rasporeda prema ID-u
        /// </summary>
        public bool ukloniCas(Guid id)
        {
            var c = casovi.FirstOrDefault(x => x.id == id);
            if (c == null) return false;
            casovi.Remove(c);
            return true;
        }

        /// <summary>
        /// Vrati sve časove
        /// </summary>
        public List<RasporedCasa> vratiSveCasove()
        {
            return new List<RasporedCasa>(casovi);
        }

        /// <summary>
        /// Pronađi čas po ID-u
        /// </summary>
        public RasporedCasa nadjiPoId(Guid id)
        {
            return casovi.FirstOrDefault(x => x.id == id);
        }

        /// <summary>
        /// Izmeni postojeći čas (ako postoji), vraća true ako je uspešno izmenjen
        /// </summary>
        public bool izmeniCas(Guid id, string naziv, Dan dan, TimeSpan vremeOd, TimeSpan vremeDo, string ucionica, Profesor profesor)
        {
            var c = nadjiPoId(id);
            if (c == null) return false;
            c.izmeniCas(naziv, dan, vremeOd, vremeDo, ucionica, profesor);
            return true;
        }
    }
}