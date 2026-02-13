using System;
using System.Windows.Forms;

namespace projekatOop
{
    // Forma za upravljanje učenicima — koristi UcenikRepository (singleton)
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

            if (string.IsNullOrWhiteSpace(ime) || string.IsNullOrWhiteSpace(prezime) || string.IsNullOrWhiteSpace(jmbg))
            {
                MessageBox.Show("Popunite ime, prezime i JMBG.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtProsek.Text.Trim(), out var prosek))
            {
                MessageBox.Show("Neispravan prosek.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                Vladanje = Enum.TryParse<VladanjeEnum>(cbVladanje.SelectedItem.ToString(), out var v) ? v : VladanjeEnum.DOBRO,
                Matura = Enum.TryParse<MaturaEnum>(cbMatura.SelectedItem.ToString(), out var m) ? m : MaturaEnum.NIJE_POLAGAO,
                Roditelj = roditelj
            };

            repozitorij.DodajUcenika(ucenik);
            OsveziPrikaz();
            OcistiUnos();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvUcenici.CurrentRow?.DataBoundItem is Ucenik ucenik)
            {
                repozitorij.UkloniUcenika(ucenik);
                OsveziPrikaz();
            }
            else
            {
                MessageBox.Show("Izaberite učenika za brisanje.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDostignuca_Click(object sender, EventArgs e)
        {
            // Otvori formu za dostignuća i preselektuj trenutnog izabranog učenika ako postoji
            var izabrani = dgvUcenici.CurrentRow?.DataBoundItem as Ucenik;
            using var forma = izabrani != null ? new DostignucaForm(izabrani) : new DostignucaForm();
            forma.ShowDialog(this);
            // nakon zatvaranja moguće je da su dostignuća promenjena — osveži prikaz
            OsveziPrikaz();
        }

        private void OsveziPrikaz()
        {
            dgvUcenici.DataSource = null;
            dgvUcenici.DataSource = repozitorij.DobaviSveUcenike();
        }

        private void OcistiUnos()
        {
            txtIme.Text = "";
            txtPrezime.Text = "";
            txtJMBG.Text = "";
            txtOdeljenje.Text = "";
            txtProsek.Text = "0";
            dtpDatumUpisa.Value = DateTime.Today;
            cbVladanje.SelectedIndex = 0;
            cbMatura.SelectedIndex = 0;
            txtRoditeljIme.Text = "";
            txtRoditeljPrezime.Text = "";
            txtRoditeljTelefon.Text = "";
        }
    }
}