using System.Collections.Generic;
using System.Linq;

namespace projekatOop
{
    // Singleton repozitorijum za dostignuća povezana sa učenicima
    public class DostignuceRepository
    {
        private static readonly DostignuceRepository instance = new();
        // Ključ je JMBG učenika; lista dostignuća za tog učenika
        private readonly Dictionary<string, List<Dostignuce>> mapa = new();

        private DostignuceRepository() { }

        public static DostignuceRepository Instance => instance;

        // Dodaje dostignuće za učenika (koristi JMBG kao ključ)
        public void DodajZaUcenika(Ucenik ucenik, Dostignuce dostignuce)
        {
            if (ucenik == null || dostignuce == null) return;
            var key = ucenik.Jmbg ?? string.Empty;
            if (!mapa.TryGetValue(key, out var lista))
            {
                lista = new List<Dostignuce>();
                mapa[key] = lista;
            }

            // Ne dozvoljavamo dva dostignuća sa istim Id za istog učenika
            if (!lista.Any(d => d.Id == dostignuce.Id))
            {
                lista.Add(dostignuce);
                // Takođe osvežimo lokalnu kolekciju u objektu ucenik (ako postoji)
                ucenik.Dostignuca.Add(dostignuce);
            }
        }

        public void UkloniZaUcenika(Ucenik ucenik, Dostignuce dostignuce)
        {
            if (ucenik == null || dostignuce == null) return;
            var key = ucenik.Jmbg ?? string.Empty;
            if (mapa.TryGetValue(key, out var lista))
            {
                lista.Remove(dostignuce);
            }
            ucenik.Dostignuca.Remove(dostignuce);
        }

        // Vraća kopiju liste dostignuća za prikaz
        public List<Dostignuce> DobaviZaUcenika(Ucenik ucenik)
        {
            if (ucenik == null) return new List<Dostignuce>();
            var key = ucenik.Jmbg ?? string.Empty;
            if (mapa.TryGetValue(key, out var lista))
            {
                return lista.ToList();
            }
            return new List<Dostignuce>();
        }
    }
}