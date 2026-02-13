namespace projekatOop
{
    public class Roditelj : Nezaposleni
    {
        public string Ime { get; set; } = string.Empty;
        public string Prezime { get; set; } = string.Empty;
        public string JMBG { get; set; } = string.Empty;

        public string Telefon { get; set; } = string.Empty;

        public void Dodaj()
        { }

        public void Izbrisi()
        { }

        public void Izmeni()
        { }

        public string IspisiPodatke() => $"{Ime} {Prezime} - tel: {Telefon}";
    }
}