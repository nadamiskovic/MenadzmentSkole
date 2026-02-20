namespace projekatOop
{
    public class Roditelj : Osoba
    {
        public string JMBG { get; set; } = string.Empty;
        public string Telefon { get; set; } = string.Empty;

        public Roditelj() : base("", "")
        {
        }

        public Roditelj(string ime, string prezime, string telefon)
            : base(ime, prezime)
        {
            Telefon = telefon;
        }

        public void Dodaj() { }
        public void Izbrisi() { }
        public void Izmeni() { }

        public override string ToString()
        {
            return $"{Ime} {Prezime} ({Telefon})";
        }
    }
}