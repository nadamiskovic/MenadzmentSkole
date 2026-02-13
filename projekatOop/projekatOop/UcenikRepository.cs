using System.Collections.Generic;
using System.Linq;

namespace projekatOop
{
    // Singleton repozitorijum za u?enike
    public class UcenikRepository
    {
        private static readonly UcenikRepository instance = new UcenikRepository();
        private readonly List<Ucenik> ucenici = new();

        private UcenikRepository() { }

        public static UcenikRepository Instance => instance;

        public void DodajUcenika(Ucenik ucenik)
        {
            if (ucenik != null) ucenici.Add(ucenik);
        }

        public void UkloniUcenika(Ucenik ucenik)
        {
            if (ucenik != null) ucenici.Remove(ucenik);
        }

        public List<Ucenik> DobaviSveUcenike() => ucenici.ToList();
    }
}