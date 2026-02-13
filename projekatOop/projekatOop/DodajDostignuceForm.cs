using System;
using System.Linq;
using System.Windows.Forms;

namespace projekatOop
{
    // Modalni dijalog za kreiranje novog dostignuća i povezivanje sa učenikom
    public partial class DodajDostignuceForm : Form
    {
        private readonly Ucenik _ucenik;

        public DodajDostignuceForm(Ucenik ucenik)
        {
            _ucenik = ucenik ?? throw new ArgumentNullException(nameof(ucenik));
            InitializeComponent();
            Inicijalizuj();
        }

        private void Inicijalizuj()
        {
            cbTip.Items.AddRange(new[] { "Sertifikat", "Pohvala", "Takmičenje" });
            cbTip.SelectedIndex = 0;

            cbNivo.Items.AddRange(Enum.GetNames<NivoDostignuca>());
            cbNivo.SelectedIndex = 0;

            // podrazumevani datum
            dtpDatum.Value = DateTime.Today;
            dtpRokVazenja.Value = DateTime.Today.AddYears(1);

            PrikaziPanel();
        }

        private void cbTip_SelectedIndexChanged(object sender, EventArgs e) => PrikaziPanel();

        private void PrikaziPanel()
        {
            pnlSertifikat.Visible = cbTip.SelectedItem as string == "Sertifikat";
            pnlPohvala.Visible = cbTip.SelectedItem as string == "Pohvala";
            pnlTakmicenje.Visible = cbTip.SelectedItem as string == "Takmičenje";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // Zajednički polja
            var id = txtId.Text.Trim();
            var naziv = txtNaziv.Text.Trim();
            var opis = txtOpis.Text.Trim();
            var institucija = txtInstitucija.Text.Trim();
            var datum = dtpDatum.Value;
            var nivo = Enum.TryParse<NivoDostignuca>(cbNivo.SelectedItem?.ToString(), out var n) ? n : NivoDostignuca.SKOLSKI;
            var mentor = txtMentor.Text.Trim();

            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(naziv))
            {
                MessageBox.Show("Id i naziv su obavezni.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Dostignuce novo = null;

            var tip = cbTip.SelectedItem as string;
            if (tip == "Sertifikat")
            {
                var oblast = txtOblast.Text.Trim();
                var trajanjeSati = (double)numTrajanje.Value;
                var broj = txtBrojSertifikata.Text.Trim();
                var rok = dtpRokVazenja.Value;
                novo = new Sertifikat(id, naziv, opis, institucija, datum, nivo, mentor, oblast, TimeSpan.FromHours(trajanjeSati), broj, rok);
            }
            else if (tip == "Pohvala")
            {
                var razlog = txtRazlog.Text.Trim();
                var dodelio = txtDodelio.Text.Trim();
                var skGod = txtSkolskaGodina.Text.Trim();
                novo = new Pohvala(id, naziv, opis, institucija, datum, nivo, mentor, razlog, dodelio, skGod);
            }
            else if (tip == "Takmičenje")
            {
                if (!int.TryParse(txtRang.Text.Trim(), out var rang)) rang = 0;
                var nazivTak = txtNazivTakmicenja.Text.Trim();
                var timska = chkTimska.Checked;
                novo = new Takmicenje(id, naziv, opis, institucija, datum, nivo, mentor, rang, nazivTak, timska);
            }

            // Dodaj u repozitorijum (repozitorijum će takođe ažurirati ucenik.Dostignuca)
            DostignuceRepository.Instance.DodajZaUcenika(_ucenik, novo);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}