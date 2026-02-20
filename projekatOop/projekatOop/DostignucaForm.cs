using System;
using System.Linq;
using System.Windows.Forms;

namespace projekatOop
{
    // Forma za pregled i upravljanje dostignućima povezanih sa učenicima
    public partial class DostignucaForm : Form
    {
        public DostignucaForm()
        {
            InitializeComponent();
            Inicijalizuj();
        }

        // Novi konstruktor koji preselektuje navedenog učenika (ako postoji u combo listi)
        public DostignucaForm(Ucenik preselect)
        {
            InitializeComponent();
            Inicijalizuj();

            if (preselect != null)
            {
                // Pokušaj da pronađemo postojeći item sa istim JMBG i selektujemo ga
                for (int i = 0; i < cbUcenik.Items.Count; i++)
                {
                    if ((cbUcenik.Items[i] as ComboItem)?.Ucenik?.Jmbg == preselect.Jmbg)
                    {
                        cbUcenik.SelectedIndex = i;
                        return;
                    }
                }

                // Ako učenik nije u listi (npr. nije još dodat), dodajemo ga i selektujemo
                cbUcenik.Items.Add(new ComboItem(preselect));
                cbUcenik.SelectedIndex = cbUcenik.Items.Count - 1;
            }
        }

        private void Inicijalizuj()
        {
            // Napuni listu učenika iz repozitorijuma
            cbUcenik.Items.Clear();
            foreach (var u in UcenikRepository.Instance.DobaviSveUcenike())
            {
                cbUcenik.Items.Add(new ComboItem(u));
            }

            if (cbUcenik.Items.Count > 0) cbUcenik.SelectedIndex = 0;
        }

        private void cbUcenik_SelectedIndexChanged(object sender, EventArgs e)
        {
            OsveziPrikaz();
        }

        private Ucenik IzabraniUcenik => (cbUcenik.SelectedItem as ComboItem)?.Ucenik;

        private void OsveziPrikaz()
        {
            var u = IzabraniUcenik;
            dgvDostignuca.DataSource = null;
            if (u != null)
            {
                dgvDostignuca.DataSource = DostignuceRepository.Instance.DobaviZaUcenika(u);
            }
        }

        private void btnDodajDostignuce_Click(object sender, EventArgs e)
        {
            var u = IzabraniUcenik;
            if (u == null)
            {
                MessageBox.Show("Izaberite učenika.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using var forma = new DodajDostignuceForm(u);
            if (forma.ShowDialog(this) == DialogResult.OK)
            {
                OsveziPrikaz();
            }
        }

        private void btnObrisiDostignuce_Click(object sender, EventArgs e)
        {
            if (dgvDostignuca.CurrentRow?.DataBoundItem is Dostignuce d && IzabraniUcenik != null)
            {
                DostignuceRepository.Instance.UkloniZaUcenika(IzabraniUcenik, d);
                OsveziPrikaz();
            }
            else
            {
                MessageBox.Show("Izaberite dostignuće za brisanje.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // pomoćna klasa za combo koja prikazuje ime + JMBG
        private class ComboItem
        {
            public Ucenik Ucenik { get; }

            public ComboItem(Ucenik u) => Ucenik = u;

            public override string ToString() => $"{Ucenik.Ime} {Ucenik.Prezime} ({Ucenik.Jmbg})";
        }
    }
}