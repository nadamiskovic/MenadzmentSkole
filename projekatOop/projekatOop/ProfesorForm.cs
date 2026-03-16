using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace projekatOop
{
    public class ProfesorForm : Form
    {
        private TextBox tbIme;
        private TextBox tbPrezime;
        private CheckedListBox clbPredmet;
        private Button btnOk;
        private Button btnCancel;

        public Profesor Profesor { get; private set; }

        public ProfesorForm()
        {
            Text = "Dodaj profesora";
            Width = 360;
            Height = 340;
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            Label l1 = new Label { Left = 10, Top = 15, Text = "Ime:" };
            tbIme = new TextBox { Left = 110, Top = 10, Width = 220 };

            Label l2 = new Label { Left = 10, Top = 50, Text = "Prezime:" };
            tbPrezime = new TextBox { Left = 110, Top = 45, Width = 220 };

            Label l3 = new Label { Left = 10, Top = 85, Text = "Predmeti:" };
            clbPredmet = new CheckedListBox { Left = 110, Top = 80, Width = 220, Height = 160 };
            clbPredmet.Items.AddRange(new object[]
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
            });

            btnOk = new Button { Left = 110, Top = 250, Width = 100, Text = "Dodaj" };
            btnCancel = new Button { Left = 230, Top = 250, Width = 100, Text = "Otkaži" };

            Controls.AddRange(new Control[] { l1, tbIme, l2, tbPrezime, l3, clbPredmet, btnOk, btnCancel });

            btnOk.Click += BtnOk_Click;
            btnCancel.Click += (s, e) => DialogResult = DialogResult.Cancel;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbIme.Text) || string.IsNullOrWhiteSpace(tbPrezime.Text))
            {
                MessageBox.Show("Unesite ime i prezime profesora.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var odabraniPredmeti = clbPredmet.CheckedItems
                .Cast<string>()
                .ToList();

            Profesor = new Profesor(tbIme.Text.Trim(), tbPrezime.Text.Trim(), odabraniPredmeti);
            DialogResult = DialogResult.OK;
        }
    }
}
