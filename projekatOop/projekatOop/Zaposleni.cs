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
