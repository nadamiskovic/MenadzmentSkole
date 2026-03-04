namespace projekatOop
{
    public class Roditelj : Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public string JMBG { get; set; } = string.Empty;
        public string Telefon { get; set; } = string.Empty;

        public Roditelj()
        {
            Ime = string.Empty;
            Prezime = string.Empty;
        }

        public Roditelj(string ime, string prezime, string telefon)
        {
            Ime = ime;
            Prezime = prezime;
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
