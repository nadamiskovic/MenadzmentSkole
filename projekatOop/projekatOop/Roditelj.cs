namespace projekatOop
{
<<<<<<< HEAD
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

=======
    // Model roditelja
    public class Roditelj
    {
        public string Ime { get; set; } = string.Empty;
        public string Prezime { get; set; } = string.Empty;
        public string Telefon { get; set; } = string.Empty;

>>>>>>> 0f4fabc60a31d0da0418fdfdd341fd6e97348ddd
        public string IspisiPodatke() => $"{Ime} {Prezime} - tel: {Telefon}";
    }
}