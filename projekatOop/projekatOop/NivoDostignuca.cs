using System;

namespace projekatOop
{
    // Nivo dostignuća (primeri)
    public enum NivoDostignuca
    {
        SKOLSKI,
        OPSTINSKI,
        POKRAJINSKI,
        DRZAVNI,
        MEDJUNARODNI
    }

    // Apstraktna klasa koja predstavlja generičko dostignuće
    public abstract class Dostignuce
    {
        // Zajednička svojstva za sva dostignuća
        public string Id { get; protected set; }
        public string Naziv { get; protected set; }
        public string Opis { get; protected set; }
        public string Institucija { get; protected set; }
        public DateTime Datum { get; protected set; }
        public NivoDostignuca Nivo { get; protected set; }
        public string Mentor { get; protected set; }

        protected Dostignuce(string id, string naziv, string opis, string institucija, DateTime datum, NivoDostignuca nivo, string mentor)
        {
            if (string.IsNullOrWhiteSpace(id)) throw new ArgumentException("Id ne sme biti prazan.", nameof(id));
            Id = id;
            Naziv = naziv ?? string.Empty;
            Opis = opis ?? string.Empty;
            Institucija = institucija ?? string.Empty;
            Datum = datum;
            Nivo = nivo;
            Mentor = mentor ?? string.Empty;
        }

        // Vraća osnovne informacije; podklase nadograđuju sa detaljima
        public virtual string IspisiPodatke()
        {
            return $"[{Id}] {Naziv} ({Nivo}) - {Institucija}, {Datum:d}. Mentor: {Mentor}. Opis: {Opis}\n{IspisiDetalje()}";
        }

        // Podklase obavezno implementiraju prikaz svojih detalja
        protected abstract string IspisiDetalje();
    }

    // Sertifikat — konkretna klasa
    public class Sertifikat : Dostignuce
    {
        public string Oblast { get; set; }
        public TimeSpan Trajanje { get; set; }
        public string BrojSertifikata { get; set; }
        public DateTime RokVazenja { get; set; }

        public Sertifikat(string id, string naziv, string opis, string institucija, DateTime datum, NivoDostignuca nivo, string mentor,
                          string oblast, TimeSpan trajanje, string brojSertifikata, DateTime rokVazenja)
            : base(id, naziv, opis, institucija, datum, nivo, mentor)
        {
            Oblast = oblast ?? string.Empty;
            Trajanje = trajanje;
            BrojSertifikata = brojSertifikata ?? string.Empty;
            RokVazenja = rokVazenja;
        }

        protected override string IspisiDetalje()
        {
            return $"SERTIFIKAT - Oblast: {Oblast}, Trajanje: {Trajanje.TotalHours}h, Broj: {BrojSertifikata}, Rok važenja: {RokVazenja:d}";
        }
    }

    // Pohvala — konkretna klasa
    public class Pohvala : Dostignuce
    {
        public string Razlog { get; set; }
        public string Dodelio { get; set; }
        public string SkolskaGodina { get; set; }

        public Pohvala(string id, string naziv, string opis, string institucija, DateTime datum, NivoDostignuca nivo, string mentor,
                       string razlog, string dodelio, string skolskaGodina)
            : base(id, naziv, opis, institucija, datum, nivo, mentor)
        {
            Razlog = razlog ?? string.Empty;
            Dodelio = dodelio ?? string.Empty;
            SkolskaGodina = skolskaGodina ?? string.Empty;
        }

        protected override string IspisiDetalje()
        {
            return $"POHVALA - Razlog: {Razlog}, Dodelio: {Dodelio}, Šk. godina: {SkolskaGodina}";
        }
    }

    // Takmičenje — konkretna klasa
    public class Takmicenje : Dostignuce
    {
        public int Rang { get; set; }
        public string NazivTakmicenja { get; set; }
        public bool Timska { get; set; }

        public Takmicenje(string id, string naziv, string opis, string institucija, DateTime datum, NivoDostignuca nivo, string mentor,
                          int rang, string nazivTakmicenja, bool timska)
            : base(id, naziv, opis, institucija, datum, nivo, mentor)
        {
            Rang = rang;
            NazivTakmicenja = nazivTakmicenja ?? string.Empty;
            Timska = timska;
        }

        protected override string IspisiDetalje()
        {
            var tip = Timska ? "timsko" : "individualno";
            return $"TAKMIČENJE - {NazivTakmicenja}, Rang: {Rang}, Tip: {tip}";
        }
    }
}