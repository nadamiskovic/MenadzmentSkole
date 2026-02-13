namespace projekatOop
{
    // Model roditelja
    public class Roditelj
    {
        public string Ime { get; set; } = string.Empty;
        public string Prezime { get; set; } = string.Empty;
        public string Telefon { get; set; } = string.Empty;

        public string IspisiPodatke() => $"{Ime} {Prezime} - tel: {Telefon}";
    }
}