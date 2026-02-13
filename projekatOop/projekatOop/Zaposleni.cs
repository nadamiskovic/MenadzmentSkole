namespace projekatOop
{
    // Model za zaposlenog
    public class Zaposleni
    {
        public string Ime { get; set; } = string.Empty;
        public string Prezime { get; set; } = string.Empty;
        public string Id { get; set; } = string.Empty;
        public ZaposleniPozicija Pozicija { get; set; } = ZaposleniPozicija.Drugo;

        // Ispisuje podatke zaposlenog u čitljiv oblik
        public string IspisiPodatke()
        {
            return $"{Ime} {Prezime} (ID: {Id}) - Pozicija: {Pozicija}";
        }
    }

    // Enum za poziciju zaposlenog — tačne vrednosti koje se pojavljuju u drop meniju
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