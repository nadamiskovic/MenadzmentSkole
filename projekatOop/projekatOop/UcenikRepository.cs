using System.Collections.Generic;
using System.Linq;

namespace projekatOop
{
    public class UcenikRepository
    {
        private static readonly UcenikRepository instance = new UcenikRepository();//instanca pravi objekat od klase
        private readonly List<Ucenik> ucenici = new();//kreira jednu listu sa ucenicima

        private UcenikRepository() { }//zakljucan ne mozemo da pravimo nove objekte

        public static UcenikRepository Instance => instance;//posto je konstruktor zakljucan ovo nam daje da pristupamo jednoj jeidnoj instanci UcenikRepository u celom programu

        public void DodajUcenika(Ucenik ucenik)
        {
            if (ucenik != null) ucenici.Add(ucenik);
        }

        public void UkloniUcenika(Ucenik ucenik)
        {
            if (ucenik != null) ucenici.Remove(ucenik);
        }
        //=> - lambda, operator koji oznacava metodu koja samo vraca vrednost
        public List<Ucenik> DobaviSveUcenike() => ucenici.ToList();//metoda koja vraca celu listu ucenik
    }
}
