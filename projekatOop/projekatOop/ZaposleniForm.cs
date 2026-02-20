using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace projekatOop
{
    // Forma za upravljanje zaposlenima — sva poslovna logika zaposlenih se nalazi ovde
    public partial class ZaposleniForm : Form
    {
        private readonly List<Zaposleni> listaZaposlenih = new();
        private readonly BindingSource izvor = new();

        public ZaposleniForm()
        {
            InitializeComponent();
            Inicijalizuj();
        }

        private void Inicijalizuj()
        {
            izvor.DataSource = listaZaposlenih;
            dgvZaposleni.AutoGenerateColumns = true;
            dgvZaposleni.DataSource = izvor;

            // Popuni filter i input pozicija iz enum-a (generic overload)
            cbFilterPozicija.Items.Add("(Svi)");
            cbFilterPozicija.Items.AddRange(Enum.GetNames<ZaposleniPozicija>());
            cbFilterPozicija.SelectedIndex = 0;

            cmbPozicija.Items.AddRange(Enum.GetNames<ZaposleniPozicija>());
            cmbPozicija.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPozicija.SelectedItem = ZaposleniPozicija.Profesor.ToString();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var ime = txtIme.Text.Trim();
            var prezime = txtPrezime.Text.Trim();
            var id = txtID.Text.Trim();
            var pozTekst = cmbPozicija.SelectedItem as string ?? string.Empty;

            if (string.IsNullOrWhiteSpace(ime) || string.IsNullOrWhiteSpace(prezime) || string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Popunite ime, prezime i ID.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Provera jedinstvenosti ID-a
            if (listaZaposlenih.Any(z => string.Equals(z.Id, id, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Zaposleni sa datim ID-jem već postoji. Unesite jedinstveni ID.", "Greška - duplikat ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var pozicija = Enum.TryParse<ZaposleniPozicija>(pozTekst, out var p)
    ? p
    : ZaposleniPozicija.Drugo;

            var zaposleni = new Zaposleni(ime, prezime, id, pozicija);

            listaZaposlenih.Add(zaposleni);

            // Ako je zaposleni profesor, dodaj odgovarajući Profesor u zajednički repozitorijum
            if (zaposleni.Pozicija == ZaposleniPozicija.Profesor)
            {
                // Provera da li već postoji profesor sa istim imenom/prezimenom
                var exists = AppServices.ProfesorRepo.vratiSveProfesore().Any(x =>
                    string.Equals(x.Ime, zaposleni.Ime, StringComparison.OrdinalIgnoreCase) &&
                    string.Equals(x.Prezime, zaposleni.Prezime, StringComparison.OrdinalIgnoreCase));

                if (!exists)
                {
                    // Predmet nije poznat preko Zaposleni modela — ostavljamo prazno
                    var noviProf = new Profesor(zaposleni.Ime, zaposleni.Prezime, string.Empty);
                    AppServices.ProfesorRepo.dodajProfesor(noviProf);
                }
            }

            OsveziPrikaz();
            OcistiUnos();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvZaposleni.CurrentRow?.DataBoundItem is Zaposleni zaposleni)
            {
                listaZaposlenih.Remove(zaposleni);

                // Ako je bio profesor, ukloni odgovarajući unos iz profesor repozitorijuma
                if (zaposleni.Pozicija == ZaposleniPozicija.Profesor)
                {
                    AppServices.ProfesorRepo.ukloniProfesorPoImenuPrezime(zaposleni.Ime, zaposleni.Prezime);
                }

                OsveziPrikaz();
            }
            else
            {
                MessageBox.Show("Izaberite zaposlenog za brisanje.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbFilterPozicija_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrimeniFilter();
        }

        private void PrimeniFilter()
        {
            var izbor = cbFilterPozicija.SelectedItem as string;
            if (izbor == "(Svi)")
            {
                izvor.DataSource = listaZaposlenih;
            }
            else if (Enum.TryParse<ZaposleniPozicija>(izbor, out var poz))
            {
                izvor.DataSource = listaZaposlenih.Where(z => z.Pozicija == poz).ToList();
            }
            else
            {
                izvor.DataSource = listaZaposlenih;
            }
            izvor.ResetBindings(false);
        }

        private void OsveziPrikaz() => PrimeniFilter();

        private void OcistiUnos()
        {
            txtIme.Text = "";
            txtPrezime.Text = "";
            txtID.Text = "";
            cmbPozicija.SelectedItem = ZaposleniPozicija.Profesor.ToString();
        }
    }
}