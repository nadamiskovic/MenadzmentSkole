using System;
using System.Linq;
using System.Windows.Forms;

namespace projekatOop
{
    /// <summary>
    /// Forma za dodavanje ili izmenu jednog časa.
    /// Profesor se bira iz postojeće liste profesora (repo).
    /// </summary>
    public class AddEditCasForm : Form
    {
        private readonly ProfesorRepository profesorRepo;
        private readonly RasporedCasa original;

        private TextBox tbNaziv;
        private ComboBox cbDan;
        private DateTimePicker dtpOd;
        private DateTimePicker dtpDo;
        private TextBox tbUcionica;
        private ComboBox cbProfesor;
        private Button btnOk;
        private Button btnCancel;

        public RasporedCasa Raspored { get; private set; }

        public AddEditCasForm(ProfesorRepository profesorRepo, RasporedCasa zaIzmenu = null)
        {
            this.profesorRepo = profesorRepo ?? throw new ArgumentNullException(nameof(profesorRepo));
            original = zaIzmenu;
            Text = zaIzmenu == null ? "Dodaj čas" : "Izmeni čas";
            Width = 420;
            Height = 300;
            InitializeComponents();
            UcitajPodatke();
        }

        private void InitializeComponents()
        {
            Label l1 = new Label { Left = 10, Top = 15, Text = "Naziv:" };
            tbNaziv = new TextBox { Left = 110, Top = 10, Width = 280 };

            Label l2 = new Label { Left = 10, Top = 50, Text = "Dan:" };
            cbDan = new ComboBox { Left = 110, Top = 45, Width = 160, DropDownStyle = ComboBoxStyle.DropDownList };
            cbDan.DataSource = Enum.GetValues(typeof(Dan));

            Label l3 = new Label { Left = 10, Top = 85, Text = "Vreme od:" };
            dtpOd = new DateTimePicker { Left = 110, Top = 80, Width = 120, Format = DateTimePickerFormat.Time, ShowUpDown = true };

            Label l4 = new Label { Left = 240, Top = 85, Text = "Vreme do:" };
            dtpDo = new DateTimePicker { Left = 300, Top = 80, Width = 120, Format = DateTimePickerFormat.Time, ShowUpDown = true };

            Label l5 = new Label { Left = 10, Top = 120, Text = "Ucionica:" };
            tbUcionica = new TextBox { Left = 110, Top = 115, Width = 280 };

            Label l6 = new Label { Left = 10, Top = 155, Text = "Profesor:" };
            cbProfesor = new ComboBox { Left = 110, Top = 150, Width = 280, DropDownStyle = ComboBoxStyle.DropDownList };

            btnOk = new Button { Left = 110, Top = 200, Width = 120, Text = "Sačuvaj" };
            btnCancel = new Button { Left = 250, Top = 200, Width = 120, Text = "Otkaži" };

            Controls.AddRange(new Control[] { l1, tbNaziv, l2, cbDan, l3, dtpOd, l4, dtpDo, l5, tbUcionica, l6, cbProfesor, btnOk, btnCancel });

            btnOk.Click += BtnOk_Click;
            btnCancel.Click += (s, e) => DialogResult = DialogResult.Cancel;
        }

        private void UcitajPodatke()
        {
            // Napuni listu profesora iz repozitorijuma
            var profesori = profesorRepo.vratiSveProfesore();
            cbProfesor.DataSource = profesori;
            cbProfesor.DisplayMember = "ime"; // ToString() je takođe dostupan

            if (original != null)
            {
                tbNaziv.Text = original.nazivCasa;
                cbDan.SelectedItem = original.dan;
                dtpOd.Value = DateTime.Today + original.vremeOd;
                dtpDo.Value = DateTime.Today + original.vremeDo;
                tbUcionica.Text = original.ucionica;

                if (original.profesor != null)
                {
                    var match = profesori.FirstOrDefault(p => p.id == original.profesor.id);
                    if (match != null) cbProfesor.SelectedItem = match;
                }
            }
            else
            {
                dtpOd.Value = DateTime.Today.AddHours(8);
                dtpDo.Value = DateTime.Today.AddHours(8).AddMinutes(45);
                if (profesori.Any()) cbProfesor.SelectedIndex = 0;
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNaziv.Text))
            {
                MessageBox.Show("Unesite naziv časa.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbProfesor.SelectedItem == null)
            {
                MessageBox.Show("Izaberite profesora iz liste (ili dodajte novog).", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var profesor = cbProfesor.SelectedItem as Profesor;
            var naziv = tbNaziv.Text.Trim();
            var dan = (Dan)cbDan.SelectedItem;
            var od = dtpOd.Value.TimeOfDay;
            var dov = dtpDo.Value.TimeOfDay;
            var ucionica = tbUcionica.Text.Trim();

            if (original == null)
            {
                Raspored = new RasporedCasa(naziv, dan, od, dov, ucionica, profesor);
            }
            else
            {
                // Napravimo novu instancu (ili možete koristiti original) — ovde čuvamo u Raspored, repo će pozvati izmeniCas
                Raspored = new RasporedCasa(naziv, dan, od, dov, ucionica, profesor) { /* novi ID */ };
                // Ako želite da zadržite original id, možete:
                Raspored = original;
                Raspored.izmeniCas(naziv, dan, od, dov, ucionica, profesor);
            }

            DialogResult = DialogResult.OK;
        }
    }
}