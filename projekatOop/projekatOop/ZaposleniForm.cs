using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace projekatOop
{
    public partial class ZaposleniForm : Form
    {
        private readonly BindingSource izvor = new();

        public ZaposleniForm()
        {
            InitializeComponent();
            Inicijalizuj();
        }

        private void Inicijalizuj()
        {
            izvor.DataSource = Zaposleni.VratiSveZaposlene();
            dgvZaposleni.AutoGenerateColumns = true;
            dgvZaposleni.DataSource = izvor;

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

            var pozicija = Enum.TryParse<ZaposleniPozicija>(pozTekst, out var p) ? p : ZaposleniPozicija.Drugo;
            var zaposleni = new Zaposleni(ime, prezime, id, pozicija);

            try
            {
                Zaposleni.DodajZaposlenog(zaposleni);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ako je zaposleni profesor, dodaj u ProfesorRepo
            if (zaposleni.Pozicija == ZaposleniPozicija.Profesor)
            {
                var exists = AppServices.ProfesorRepo.vratiSveProfesore().Any(x =>
                    string.Equals(x.Ime, zaposleni.Ime, StringComparison.OrdinalIgnoreCase) &&
                    string.Equals(x.Prezime, zaposleni.Prezime, StringComparison.OrdinalIgnoreCase));

                if (!exists)
                {
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
                try
                {
                    Zaposleni.IzbrisiZaposlenog(zaposleni.Id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Ako je bio profesor, ukloni iz ProfesorRepo
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
            List<Zaposleni> lista = Zaposleni.VratiSveZaposlene();

            if (izbor != "(Svi)" && Enum.TryParse<ZaposleniPozicija>(izbor, out var poz))
            {
                lista = lista.Where(z => z.Pozicija == poz).ToList();
            }

            izvor.DataSource = lista;
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
