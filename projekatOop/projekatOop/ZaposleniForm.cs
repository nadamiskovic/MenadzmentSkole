using System;
using System.Linq;
using System.Windows.Forms;

namespace projekatOop
{
    public partial class ZaposleniForm : Form
    {
        // Konstanta za filter koji prikazuje sve zaposlene.
        // Koristimo konstantu da ne pisemo isti tekst na vise mesta.
        private const string SviFilter = "(Svi)";

        // BindingSource povezuje listu zaposlenih sa DataGridView tabelom.
        private readonly BindingSource izvor = new();

        // Lista predmeta koja se prikazuje samo kada je izabrana pozicija Profesor.
        private readonly string[] predmeti =
        {
            "Matematika",
            "Fizika",
            "Hemija",
            "Biologija",
            "Istorija",
            "Geografija",
            "Srpski jezik",
            "Engleski jezik",
            "Informatika"
        };

        public ZaposleniForm()
        {
            InitializeComponent();
            Inicijalizuj();
        }

        // DALIBOR komsija
        // - podesavanje forme i filteri 

        private void Inicijalizuj()
        {
            // Dozvoljavamo tabeli da sama napravi kolone prema klasi Zaposleni.
            dgvZaposleni.AutoGenerateColumns = true;

            // Tabela prikazuje podatke iz BindingSource objekta.
            dgvZaposleni.DataSource = izvor;

            // U filter prvo dodajemo opciju za sve zaposlene.
            cbFilterPozicija.Items.Add(SviFilter);

            // Zatim dodajemo sve vrednosti iz enum-a ZaposleniPozicija.
            cbFilterPozicija.Items.AddRange(Enum.GetNames<ZaposleniPozicija>());

            // Podrazumevano je izabrano "(Svi)".
            cbFilterPozicija.SelectedIndex = 0;

            // ComboBox za unos pozicije dobija iste pozicije iz enum-a.
            cmbPozicija.Items.AddRange(Enum.GetNames<ZaposleniPozicija>());

            // Podrazumevana pozicija pri unosu je Profesor.
            cmbPozicija.SelectedItem = ZaposleniPozicija.Profesor.ToString();

            // CheckedListBox dobija listu predmeta.
            clbPredmet.Items.AddRange(predmeti);

            // Predmeti se prikazuju samo ako je izabran Profesor.
            PrikaziPredmeteZaProfesora();

            // Kada korisnik promeni poziciju, proveravamo da li treba prikazati predmete.
            cmbPozicija.SelectedIndexChanged += CmbPozicija_SelectedIndexChanged;

            // Na pocetku prikazujemo trenutnu listu zaposlenih.
            OsveziPrikaz();
        }

        private void CmbPozicija_SelectedIndexChanged(object? sender, EventArgs e)
        {
            // Svaka promena pozicije menja vidljivost liste predmeta.
            PrikaziPredmeteZaProfesora();

            // Ako pozicija vise nije Profesor, brisemo cekirane predmete.
            if (!IzabranaPozicijaJeProfesor())
                OcistiPredmete();
        }

        private void cbFilterPozicija_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kada se promeni filter, ponovo se puni tabela.
            PrimeniFilter();
        }

        private void PrimeniFilter()
        {
            // Uzimamo sve zaposlene iz staticke liste u klasi Zaposleni.
            var lista = Zaposleni.VratiSveZaposlene();

            // Citamo sta je korisnik izabrao u filter ComboBox-u.
            var izbor = cbFilterPozicija.SelectedItem as string;

            // Ako nije izabrano "(Svi)", prikazujemo samo zaposlene sa tom pozicijom.
            if (izbor != SviFilter && Enum.TryParse<ZaposleniPozicija>(izbor, out var pozicija))
                lista = lista.Where(z => z.Pozicija == pozicija).ToList();

            // Novu listu postavljamo kao izvor podataka za tabelu.
            izvor.DataSource = lista;

            // ResetBindings kaze tabeli da osvezi prikaz.
            izvor.ResetBindings(false);
        }

        private void OsveziPrikaz()
        {
            // Osvezavanje prikaza zapravo samo ponovo primenjuje trenutni filter.
            PrimeniFilter();
        }

        // MITA legendarac
        // Dodaj Obrisi dugmici

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            // Prvo proveravamo da li su obavezna polja popunjena.
            if (!UnosJeIspravan())
                return;

            // Od teksta sa forme pravimo objekat klase Zaposleni.
            var zaposleni = NapraviZaposlenogIzUnosa();

            try
            {
                // Dodajemo zaposlenog u listu. Ako ID vec postoji, metoda baca gresku.
                Zaposleni.DodajZaposlenog(zaposleni);
            }
            catch (Exception ex)
            {
                // Ako postoji duplikat ID-a, prikazujemo poruku i prekidamo dodavanje.
                MessageBox.Show(ex.Message, "Greska - duplikat ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ako je zaposleni Profesor, dodajemo ga i u repozitorijum profesora.
            if (zaposleni.Pozicija == ZaposleniPozicija.Profesor)
                DodajProfesoraAkoNePostoji(zaposleni);

            // Posle dodavanja osvezavamo tabelu.
            OsveziPrikaz();

            // Brisemo tekst iz polja da forma bude spremna za novi unos.
            OcistiUnos();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            // Proveravamo da li je korisnik selektovao red u tabeli.
            if (dgvZaposleni.CurrentRow?.DataBoundItem is not Zaposleni zaposleni)
            {
                MessageBox.Show("Izaberite zaposlenog za brisanje.", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Brisemo zaposlenog iz liste pomocu njegovog ID-a.
                Zaposleni.IzbrisiZaposlenog(zaposleni.Id);
            }
            catch (Exception ex)
            {
                // Ako zaposleni nije pronadjen, prikazujemo gresku.
                MessageBox.Show(ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ako je obrisani zaposleni profesor, brisemo ga i iz liste profesora.
            if (zaposleni.Pozicija == ZaposleniPozicija.Profesor)
                AppServices.ProfesorRepo.ukloniProfesorPoImenuPrezime(zaposleni.Ime, zaposleni.Prezime);

            // Na kraju osvezavamo tabelu da se obrisani red vise ne vidi.
            OsveziPrikaz();
        }

        // OGNJEN smeker najveci

        private bool UnosJeIspravan()
        {
            // Proveravamo posebno ime, prezime i ID da bi kod bio citljiv.
            bool imeJeUneto = !string.IsNullOrWhiteSpace(txtIme.Text);
            bool prezimeJeUneto = !string.IsNullOrWhiteSpace(txtPrezime.Text);
            bool idJeUnet = !string.IsNullOrWhiteSpace(txtID.Text);

            // Ako su sva tri polja popunjena, unos je ispravan.
            if (imeJeUneto && prezimeJeUneto && idJeUnet)
                return true;

            // Ako neko polje fali, prikazuje se poruka korisniku.
            MessageBox.Show("Popunite ime, prezime i ID.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        private Zaposleni NapraviZaposlenogIzUnosa()
        {
            // Pravimo novi objekat Zaposleni od vrednosti koje je korisnik uneo.
            return new Zaposleni(
                // Trim uklanja razmake sa pocetka i kraja teksta.
                txtIme.Text.Trim(),
                txtPrezime.Text.Trim(),
                txtID.Text.Trim(),
                IzabranaPozicija());
        }

        private ZaposleniPozicija IzabranaPozicija()
        {
            // Uzimamo tekst iz ComboBox-a, na primer "Profesor" ili "Direktor".
            var pozicijaTekst = cmbPozicija.SelectedItem as string;

            // TryParse pokusava da tekst pretvori u enum vrednost.
            if (Enum.TryParse<ZaposleniPozicija>(pozicijaTekst, out var pozicija))
                return pozicija;

            // Ako nesto nije dobro izabrano, vracamo bezbednu vrednost Drugo.
            return ZaposleniPozicija.Drugo;
        }

        private bool IzabranaPozicijaJeProfesor()
        {
            // Ova metoda vraca true samo kada je u ComboBox-u izabran Profesor.
            return IzabranaPozicija() == ZaposleniPozicija.Profesor;
        }

        private void PrikaziPredmeteZaProfesora()
        {
            // Predmeti treba da se vide samo za profesore.
            bool prikazi = IzabranaPozicijaJeProfesor();

            // Labela "Predmet" se prikazuje ili sakriva.
            lblPredmet.Visible = prikazi;

            // Lista predmeta se prikazuje ili sakriva.
            clbPredmet.Visible = prikazi;
        }

        private void OcistiPredmete()
        {
            // Prolazimo kroz sve predmete u listi.
            for (int i = 0; i < clbPredmet.Items.Count; i++)
                // Svaki predmet postavljamo da nije cekiran.
                clbPredmet.SetItemChecked(i, false);
        }

        private void OcistiUnos()
        {
            // Brisemo tekst iz polja za unos.
            txtIme.Text = "";
            txtPrezime.Text = "";
            txtID.Text = "";

            // Vracamo poziciju na podrazumevanu vrednost Profesor.
            cmbPozicija.SelectedItem = ZaposleniPozicija.Profesor.ToString();

            // Brisemo cekirane predmete.
            OcistiPredmete();

            // Ponovo prikazujemo predmete jer je podrazumevana pozicija Profesor.
            PrikaziPredmeteZaProfesora();
        }

        private void DodajProfesoraAkoNePostoji(Zaposleni zaposleni)
        {
            // Ako profesor sa istim imenom i prezimenom vec postoji, ne dodajemo ga ponovo.
            if (ProfesorVecPostoji(zaposleni))
                return;

            // Pravimo profesora od podataka zaposlenog i izabranih predmeta.
            var profesor = new Profesor(zaposleni.Ime, zaposleni.Prezime, OdabraniPredmetiTekst());

            // Dodajemo profesora u zajednicki repozitorijum profesora.
            AppServices.ProfesorRepo.dodajProfesor(profesor);
        }

        private bool ProfesorVecPostoji(Zaposleni zaposleni)
        {
            // Any proverava da li u listi profesora postoji bar jedan koji ispunjava uslov.
            return AppServices.ProfesorRepo.vratiSveProfesore().Any(profesor =>
                // Poredimo ime bez obzira na velika i mala slova.
                string.Equals(profesor.Ime, zaposleni.Ime, StringComparison.OrdinalIgnoreCase) &&
                // Poredimo prezime bez obzira na velika i mala slova.
                string.Equals(profesor.Prezime, zaposleni.Prezime, StringComparison.OrdinalIgnoreCase));
        }

        private string OdabraniPredmetiTekst()
        {
            // Uzimamo sve cekirane predmete iz CheckedListBox kontrole.
            var odabraniPredmeti = clbPredmet.CheckedItems.Cast<string>().ToList();

            // Ako nije cekiran nijedan predmet, upisujemo podrazumevan tekst.
            if (odabraniPredmeti.Count == 0)
                return "Nije unet predmet";

            // Ako ima vise predmeta, spajamo ih u jedan tekst odvojen zarezima.
            return string.Join(", ", odabraniPredmeti);
        }

        private void lblFilter_Click(object sender, EventArgs e) { }
    }
}
