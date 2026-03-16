namespace projekatOop
{
    public class Zaposleni : Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Id { get; set; } = string.Empty;
        public ZaposleniPozicija Pozicija { get; set; } = ZaposleniPozicija.Drugo;

        public Zaposleni(string ime, string prezime, string id, ZaposleniPozicija pozicija)
        {
            Ime = ime;
            Prezime = prezime;
            Id = id;
            Pozicija = pozicija;
        }

        public string IspisiPodatke()
        {
            return $"{Ime} {Prezime} (ID: {Id}) - Pozicija: {Pozicija}";
        }

        // --- Lista svih zaposlenih (staticka) ---
        private static readonly List<Zaposleni> listaZaposlenih = new();

        // Dodavanje zaposlenog
        public static void DodajZaposlenog(Zaposleni zaposleni)
        {
            if (listaZaposlenih.Any(z => z.Id.Equals(zaposleni.Id, StringComparison.OrdinalIgnoreCase)))
            {
                throw new Exception("Zaposleni sa datim ID-jem već postoji.");
            }

            listaZaposlenih.Add(zaposleni);
        }

        // Brisanje zaposlenog po ID
        public static void IzbrisiZaposlenog(string id)
        {
            var zaposleni = listaZaposlenih.FirstOrDefault(z => z.Id.Equals(id, StringComparison.OrdinalIgnoreCase));
            if (zaposleni != null)
            {
                listaZaposlenih.Remove(zaposleni);
            }
            else
            {
                throw new Exception("Zaposleni sa datim ID-jem nije pronađen.");
            }
        }

        // Dohvatanje svih zaposlenih
        public static List<Zaposleni> VratiSveZaposlene()
        {
            return listaZaposlenih;
        }
    }

    // Editovanje pozicija zaposlenih
    public enum ZaposleniPozicija
    {
        Profesor,
        Domar,
        Spremacica,
        Pedagog,
        Psiholog,
        Direktor,
        ZamenikDirektor,
        Sekretarica,
        Bibliotekar,
        Drugo
    }
}
