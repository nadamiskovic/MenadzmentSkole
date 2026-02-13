using System;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace projekatOop
{
    /// <summary>
    /// Forma za prikaz i upravljanje rasporedom časova.
    /// Sadrži listu profesora, tabelu časova i tekstualni ispis "sve zajedno".
    /// </summary>
    public class RasporedForm : Form
    {
        // Koristi se zajednički repozitorijum iz AppServices, tako da ZaposleniForm i RasporedForm
        // vide iste profesore
        private readonly ProfesorRepository profesorRepo = AppServices.ProfesorRepo;
        private readonly RasporedRepository rasporedRepo = AppServices.RasporedRepo;

        private readonly BindingList<Profesor> bsProfesori = new();
        private readonly BindingList<RasporedCasa> bsCasovi = new();

        private ListBox lbProfesori;
        private DataGridView dgvCasovi;
        private TextBox tbIspisSve;
        private Button btnDodajProfesor;
        private Button btnDodajCas;
        private Button btnIzmeniCas;
        private Button btnUkloniCas;
        private Button btnPrikaziSve;

        public RasporedForm()
        {
            Text = "Raspored časova";
            Width = 1000;
            Height = 700;
            StartPosition = FormStartPosition.CenterScreen;

            InitializeComponents();
            PodesiPodatke();
        }

        private void InitializeComponents()
        {
            lbProfesori = new ListBox { Left = 10, Top = 10, Width = 300, Height = 260 };
            dgvCasovi = new DataGridView { Left = 320, Top = 10, Width = 650, Height = 260, ReadOnly = true, AutoGenerateColumns = false, AllowUserToAddRows = false };
            tbIspisSve = new TextBox { Left = 10, Top = 280, Width = 960, Height = 320, Multiline = true, ScrollBars = ScrollBars.Both, ReadOnly = true, WordWrap = false };

            btnDodajProfesor = new Button { Left = 10, Top = 610, Width = 140, Text = "Dodaj profesora" };
            btnDodajCas = new Button { Left = 160, Top = 610, Width = 140, Text = "Dodaj čas" };
            btnIzmeniCas = new Button { Left = 320, Top = 610, Width = 140, Text = "Izmeni čas" };
            btnUkloniCas = new Button { Left = 480, Top = 610, Width = 140, Text = "Ukloni čas" };
            btnPrikaziSve = new Button { Left = 640, Top = 610, Width = 140, Text = "Prikaži sve" };

            Controls.AddRange(new Control[] { lbProfesori, dgvCasovi, tbIspisSve, btnDodajProfesor, btnDodajCas, btnIzmeniCas, btnUkloniCas, btnPrikaziSve });

            btnDodajProfesor.Click += BtnDodajProfesor_Click;
            btnDodajCas.Click += BtnDodajCas_Click;
            btnIzmeniCas.Click += BtnIzmeniCas_Click;
            btnUkloniCas.Click += BtnUkloniCas_Click;
            btnPrikaziSve.Click += (s, e) => PrikaziSve();

            dgvCasovi.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Naziv", DataPropertyName = "nazivCasa", Width = 220 });
            dgvCasovi.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Dan", DataPropertyName = "dan", Width = 90 });
            dgvCasovi.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Vreme", Width = 160, DataPropertyName = "vremeOd" });
            dgvCasovi.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Učionica", DataPropertyName = "ucionica", Width = 100 });
            dgvCasovi.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Profesor", Width = 230, Name = "ProfesorCol" });

            dgvCasovi.CellFormatting += DgvCasovi_CellFormatting;
        }

        private void DgvCasovi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvCasovi.Columns[e.ColumnIndex].Name == "ProfesorCol")
            {
                var cas = dgvCasovi.Rows[e.RowIndex].DataBoundItem as RasporedCasa;
                e.Value = cas?.profesor?.ispisiPodatke() ?? "(nema)";
            }
            if (dgvCasovi.Columns[e.ColumnIndex].DataPropertyName == "vremeOd")
            {
                var cas = dgvCasovi.Rows[e.RowIndex].DataBoundItem as RasporedCasa;
                if (cas != null) e.Value = $"{cas.vremeOd:hh\\:mm} - {cas.vremeDo:hh\\:mm}";
            }
        }

        private void PodesiPodatke()
        {
            // Ako nema profesora u zajedničkom repozitorijumu, inicijalizujemo par primera
            if (!profesorRepo.vratiSveProfesore().Any())
            {
                var p1 = new Profesor("Marko", "Marković", "Matematika");
                var p2 = new Profesor("Jelena", "Jović", "Engleski");
                profesorRepo.dodajProfesor(p1);
                profesorRepo.dodajProfesor(p2);

                var c1 = new RasporedCasa("Matematika - I/1", Dan.Ponedeljak, new TimeSpan(8, 0, 0), new TimeSpan(8, 45, 0), "101", p1);
                var c2 = new RasporedCasa("Engleski - II/2", Dan.Utorak, new TimeSpan(9, 0, 0), new TimeSpan(9, 45, 0), "202", p2);
                var c3 = new RasporedCasa("Matematika - II/2", Dan.Sreda, new TimeSpan(10, 0, 0), new TimeSpan(10, 45, 0), "101", p1);
                rasporedRepo.dodajCas(c1);
                rasporedRepo.dodajCas(c2);
                rasporedRepo.dodajCas(c3);
            }

            OsveziListe();
            PrikaziSve();
        }

        private void OsveziListe()
        {
            bsProfesori.Clear();
            foreach (var p in profesorRepo.vratiSveProfesore()) bsProfesori.Add(p);
            lbProfesori.DataSource = bsProfesori;
            lbProfesori.DisplayMember = "ime";

            bsCasovi.Clear();
            foreach (var c in rasporedRepo.vratiSveCasove()) bsCasovi.Add(c);
            dgvCasovi.DataSource = bsCasovi;
            dgvCasovi.Refresh();
        }

        private void PrikaziSve()
        {
            var sb = new StringBuilder();
            var profesori = profesorRepo.vratiSveProfesore();
            var casovi = rasporedRepo.vratiSveCasove();

            sb.AppendLine("=== Profesori i njihovi časovi ===");
            foreach (var p in profesori)
            {
                sb.AppendLine();
                sb.AppendLine($"* {p.ispisiPodatke()}");
                var pCasovi = casovi.Where(c => c.profesor != null && c.profesor.id == p.id).OrderBy(c => c.dan).ThenBy(c => c.vremeOd).ToList();
                if (!pCasovi.Any())
                {
                    sb.AppendLine("  (nema dodeljenih časova)");
                }
                else
                {
                    foreach (var c in pCasovi)
                    {
                        sb.AppendLine($"  - {c.nazivCasa} | {c.dan} {c.vremeOd:hh\\:mm}-{c.vremeDo:hh\\:mm} | učionica: {c.ucionica}");
                    }
                }
            }

            var bezProfesora = casovi.Where(c => c.profesor == null).ToList();
            if (bezProfesora.Any())
            {
                sb.AppendLine();
                sb.AppendLine("=== Časovi bez dodeljenog profesora ===");
                foreach (var c in bezProfesora)
                {
                    sb.AppendLine($"- {c.nazivCasa} | {c.dan} {c.vremeOd:hh\\:mm}-{c.vremeDo:hh\\:mm} | učionica: {c.ucionica}");
                }
            }

            sb.AppendLine();
            sb.AppendLine($"Ukupno profesora: {profesori.Count}, ukupno časova: {casovi.Count}");

            tbIspisSve.Text = sb.ToString();
        }

        private void BtnDodajProfesor_Click(object sender, EventArgs e)
        {
            using var f = new ProfesorForm();
            if (f.ShowDialog() == DialogResult.OK)
            {
                profesorRepo.dodajProfesor(f.Profesor);
                OsveziListe();
                PrikaziSve();
            }
        }

        private void BtnDodajCas_Click(object sender, EventArgs e)
        {
            using var f = new AddEditCasForm(profesorRepo);
            if (f.ShowDialog() == DialogResult.OK)
            {
                rasporedRepo.dodajCas(f.Raspored);
                OsveziListe();
                PrikaziSve();
            }
        }

        private void BtnIzmeniCas_Click(object sender, EventArgs e)
        {
            if (dgvCasovi.CurrentRow == null) return;
            var cas = dgvCasovi.CurrentRow.DataBoundItem as RasporedCasa;
            if (cas == null) return;

            using var f = new AddEditCasForm(profesorRepo, cas);
            if (f.ShowDialog() == DialogResult.OK)
            {
                rasporedRepo.izmeniCas(cas.id, f.Raspored.nazivCasa, f.Raspored.dan, f.Raspored.vremeOd, f.Raspored.vremeDo, f.Raspored.ucionica, f.Raspored.profesor);
                OsveziListe();
                PrikaziSve();
            }
        }

        private void BtnUkloniCas_Click(object sender, EventArgs e)
        {
            if (dgvCasovi.CurrentRow == null) return;
            var cas = dgvCasovi.CurrentRow.DataBoundItem as RasporedCasa;
            if (cas == null) return;

            var ok = MessageBox.Show("Da li ste sigurni da želite da obrišete izabrani čas?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ok == DialogResult.Yes)
            {
                rasporedRepo.ukloniCas(cas.id);
                OsveziListe();
                PrikaziSve();
            }
        }
    }
}