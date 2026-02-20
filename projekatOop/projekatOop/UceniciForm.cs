using System;
using System.Windows.Forms;

namespace projekatOop
{
    public partial class UceniciForm : Form
    {
        private readonly UcenikRepository repozitorij = UcenikRepository.Instance;

        public UceniciForm()
        {
            InitializeComponent();
            Inicijalizuj();
            OsveziPrikaz();
        }

        private void Inicijalizuj()
        {
            cbVladanje.Items.AddRange(Enum.GetNames(typeof(VladanjeEnum)));
            cbVladanje.SelectedIndex = 0;

            cbMatura.Items.AddRange(Enum.GetNames(typeof(MaturaEnum)));
            cbMatura.SelectedIndex = 0;

            dgvUcenici.AutoGenerateColumns = true;
            dgvUcenici.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUcenici.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnDodajUcenika_Click(object sender, EventArgs e)
        {
            var ime = txtIme.Text.Trim();
            var prezime = txtPrezime.Text.Trim();
            var jmbg = txtJMBG.Text.Trim();

            if (!double.TryParse(txtProsek.Text.Trim(), out var prosek))
            {
                MessageBox.Show("Neispravan prosek.");
                return;
            }

            var roditelj = new Roditelj
            {
                Ime = txtRoditeljIme.Text.Trim(),
                Prezime = txtRoditeljPrezime.Text.Trim(),
                Telefon = txtRoditeljTelefon.Text.Trim()
            };

            var ucenik = new Ucenik
            {
                Ime = ime,
                Prezime = prezime,
                Jmbg = jmbg,
                Odeljenje = txtOdeljenje.Text.Trim(),
                Prosek = prosek,
                DatumUpisa = dtpDatumUpisa.Value,
                Vladanje = Enum.Parse<VladanjeEnum>(cbVladanje.SelectedItem.ToString()),
                Matura = Enum.Parse<MaturaEnum>(cbMatura.SelectedItem.ToString()),
                Roditelj = roditelj
            };

            repozitorij.DodajUcenika(ucenik);
            OsveziPrikaz();
            OcistiUnos();
        }

        private void OsveziPrikaz()
        {
            dgvUcenici.DataSource = null;
            dgvUcenici.DataSource = repozitorij.DobaviSveUcenike();
        }

        private void OcistiUnos()
        {
            txtIme.Clear();
            txtPrezime.Clear();
            txtJMBG.Clear();
            txtOdeljenje.Clear();
            txtProsek.Text = "0";
            txtRoditeljIme.Clear();
            txtRoditeljPrezime.Clear();
            txtRoditeljTelefon.Clear();
        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvUcenici.CurrentRow?.DataBoundItem is Ucenik ucenik)
            {
                UcenikRepository.Instance.UkloniUcenika(ucenik);
                OsveziPrikaz();
            }
        }

        private void btnDostignuca_Click(object sender, EventArgs e)
        {
            var izabrani = dgvUcenici.CurrentRow?.DataBoundItem as Ucenik;

            using var forma = izabrani != null
                ? new DostignucaForm(izabrani)
                : new DostignucaForm();

            forma.ShowDialog(this);
            OsveziPrikaz();
        }
    }
}