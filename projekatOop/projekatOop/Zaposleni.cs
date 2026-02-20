namespace projekatOop
{
    // Model za zaposlenog
    public class Zaposleni : Osoba
    {
        public string Id { get; set; } = string.Empty;

        public ZaposleniPozicija Pozicija { get; set; } = ZaposleniPozicija.Drugo;

        public Zaposleni(string ime, string prezime, string id, ZaposleniPozicija pozicija)
            : base(ime, prezime)
        {
            Id = id;
            Pozicija = pozicija;
        }

        // Metoda za ispis podataka (nije više u interfejsu)
        public string IspisiPodatke()
        {
            return $"{Ime} {Prezime} (ID: {Id}) - Pozicija: {Pozicija}";
        }
    }

    // Enum za poziciju zaposlenog
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