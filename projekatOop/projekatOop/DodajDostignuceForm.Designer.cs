using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace projekatOop
{
    partial class DodajDostignuceForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTip;
        private ComboBox cbTip;

        // Zajednička polja
        private Label lblId;
        private TextBox txtId;
        private Label lblNaziv;
        private TextBox txtNaziv;
        private Label lblOpis;
        private TextBox txtOpis;
        private Label lblInstitucija;
        private TextBox txtInstitucija;
        private Label lblDatum;
        private DateTimePicker dtpDatum;
        private Label lblNivo;
        private ComboBox cbNivo;
        private Label lblMentor;
        private TextBox txtMentor;

        // Panel Sertifikat
        private Panel pnlSertifikat;
        private Label lblOblast;
        private TextBox txtOblast;
        private Label lblTrajanje;
        private NumericUpDown numTrajanje;
        private Label lblBrojSertifikata;
        private TextBox txtBrojSertifikata;
        private Label lblRokVazenja;
        private DateTimePicker dtpRokVazenja;

        // Panel Pohvala
        private Panel pnlPohvala;
        private Label lblRazlog;
        private TextBox txtRazlog;
        private Label lblDodelio;
        private TextBox txtDodelio;
        private Label lblSkolskaGodina;
        private TextBox txtSkolskaGodina;

        // Panel Takmicenje
        private Panel pnlTakmicenje;
        private Label lblRang;
        private TextBox txtRang;
        private Label lblNazivTakmicenja;
        private TextBox txtNazivTakmicenja;
        private CheckBox chkTimska;

        private Button btnOk;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTip = new Label();
            cbTip = new ComboBox();

            lblId = new Label();
            txtId = new TextBox();
            lblNaziv = new Label();
            txtNaziv = new TextBox();
            lblOpis = new Label();
            txtOpis = new TextBox();
            lblInstitucija = new Label();
            txtInstitucija = new TextBox();
            lblDatum = new Label();
            dtpDatum = new DateTimePicker();
            lblNivo = new Label();
            cbNivo = new ComboBox();
            lblMentor = new Label();
            txtMentor = new TextBox();

            pnlSertifikat = new Panel();
            lblOblast = new Label();
            txtOblast = new TextBox();
            lblTrajanje = new Label();
            numTrajanje = new NumericUpDown();
            lblBrojSertifikata = new Label();
            txtBrojSertifikata = new TextBox();
            lblRokVazenja = new Label();
            dtpRokVazenja = new DateTimePicker();

            pnlPohvala = new Panel();
            lblRazlog = new Label();
            txtRazlog = new TextBox();
            lblDodelio = new Label();
            txtDodelio = new TextBox();
            lblSkolskaGodina = new Label();
            txtSkolskaGodina = new TextBox();

            pnlTakmicenje = new Panel();
            lblRang = new Label();
            txtRang = new TextBox();
            lblNazivTakmicenja = new Label();
            txtNazivTakmicenja = new TextBox();
            chkTimska = new CheckBox();

            btnOk = new Button();
            btnCancel = new Button();

            SuspendLayout();
            // Tip
            lblTip.Location = new Point(12, 12);
            lblTip.Size = new Size(80, 23);
            lblTip.Text = "Tip:";
            cbTip.Location = new Point(100, 12);
            cbTip.Size = new Size(200, 23);
            cbTip.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTip.SelectedIndexChanged += cbTip_SelectedIndexChanged;

            // Zajednička polja
            lblId.Location = new Point(12, 45); lblId.Size = new Size(80, 23); lblId.Text = "Id:";
            txtId.Location = new Point(100, 45); txtId.Size = new Size(200, 23);

            lblNaziv.Location = new Point(12, 78); lblNaziv.Size = new Size(80, 23); lblNaziv.Text = "Naziv:";
            txtNaziv.Location = new Point(100, 78); txtNaziv.Size = new Size(400, 23);

            lblOpis.Location = new Point(12, 111); lblOpis.Size = new Size(80, 23); lblOpis.Text = "Opis:";
            txtOpis.Location = new Point(100, 111); txtOpis.Size = new Size(400, 23);

            lblInstitucija.Location = new Point(12, 144); lblInstitucija.Size = new Size(80, 23); lblInstitucija.Text = "Institucija:";
            txtInstitucija.Location = new Point(100, 144); txtInstitucija.Size = new Size(400, 23);

            lblDatum.Location = new Point(12, 177); lblDatum.Size = new Size(80, 23); lblDatum.Text = "Datum:";
            dtpDatum.Location = new Point(100, 177); dtpDatum.Size = new Size(200, 23);

            lblNivo.Location = new Point(320, 177); lblNivo.Size = new Size(50, 23); lblNivo.Text = "Nivo:";
            cbNivo.Location = new Point(380, 177); cbNivo.Size = new Size(120, 23);
            cbNivo.DropDownStyle = ComboBoxStyle.DropDownList;

            lblMentor.Location = new Point(12, 210); lblMentor.Size = new Size(80, 23); lblMentor.Text = "Mentor:";
            txtMentor.Location = new Point(100, 210); txtMentor.Size = new Size(400, 23);

            // Panel Sertifikat
            pnlSertifikat.Location = new Point(12, 245); pnlSertifikat.Size = new Size(520, 120);
            lblOblast.Location = new Point(0, 0); lblOblast.Size = new Size(80, 23); lblOblast.Text = "Oblast:";
            txtOblast.Location = new Point(90, 0); txtOblast.Size = new Size(200, 23);
            lblTrajanje.Location = new Point(0, 33); lblTrajanje.Size = new Size(80, 23); lblTrajanje.Text = "Trajanje (h):";
            numTrajanje.Location = new Point(90, 33); numTrajanje.Size = new Size(100, 23); numTrajanje.Minimum = 0; numTrajanje.Maximum = 10000;
            lblBrojSertifikata.Location = new Point(0, 66); lblBrojSertifikata.Size = new Size(120, 23); lblBrojSertifikata.Text = "Broj sertifikata:";
            txtBrojSertifikata.Location = new Point(130, 66); txtBrojSertifikata.Size = new Size(160, 23);
            lblRokVazenja.Location = new Point(0, 99); lblRokVazenja.Size = new Size(120, 23); lblRokVazenja.Text = "Rok važenja:";
            dtpRokVazenja.Location = new Point(130, 99); dtpRokVazenja.Size = new Size(160, 23);

            pnlSertifikat.Controls.Add(lblOblast); pnlSertifikat.Controls.Add(txtOblast);
            pnlSertifikat.Controls.Add(lblTrajanje); pnlSertifikat.Controls.Add(numTrajanje);
            pnlSertifikat.Controls.Add(lblBrojSertifikata); pnlSertifikat.Controls.Add(txtBrojSertifikata);
            pnlSertifikat.Controls.Add(lblRokVazenja); pnlSertifikat.Controls.Add(dtpRokVazenja);

            // Panel Pohvala
            pnlPohvala.Location = new Point(12, 245); pnlPohvala.Size = new Size(520, 120);
            lblRazlog.Location = new Point(0, 0); lblRazlog.Size = new Size(80, 23); lblRazlog.Text = "Razlog:";
            txtRazlog.Location = new Point(90, 0); txtRazlog.Size = new Size(400, 23);
            lblDodelio.Location = new Point(0, 33); lblDodelio.Size = new Size(80, 23); lblDodelio.Text = "Dodelio:";
            txtDodelio.Location = new Point(90, 33); txtDodelio.Size = new Size(200, 23);
            lblSkolskaGodina.Location = new Point(0, 66); lblSkolskaGodina.Size = new Size(120, 23); lblSkolskaGodina.Text = "Školska godina:";
            txtSkolskaGodina.Location = new Point(130, 66); txtSkolskaGodina.Size = new Size(160, 23);

            pnlPohvala.Controls.Add(lblRazlog); pnlPohvala.Controls.Add(txtRazlog);
            pnlPohvala.Controls.Add(lblDodelio); pnlPohvala.Controls.Add(txtDodelio);
            pnlPohvala.Controls.Add(lblSkolskaGodina); pnlPohvala.Controls.Add(txtSkolskaGodina);

            // Panel Takmicenje
            pnlTakmicenje.Location = new Point(12, 245); pnlTakmicenje.Size = new Size(520, 120);
            lblRang.Location = new Point(0, 0); lblRang.Size = new Size(80, 23); lblRang.Text = "Rang:";
            txtRang.Location = new Point(90, 0); txtRang.Size = new Size(80, 23);
            lblNazivTakmicenja.Location = new Point(0, 33); lblNazivTakmicenja.Size = new Size(120, 23); lblNazivTakmicenja.Text = "Naziv takmičenja:";
            txtNazivTakmicenja.Location = new Point(130, 33); txtNazivTakmicenja.Size = new Size(300, 23);
            chkTimska.Location = new Point(0, 66); chkTimska.Size = new Size(120, 23); chkTimska.Text = "Timsko takmičenje";

            pnlTakmicenje.Controls.Add(lblRang); pnlTakmicenje.Controls.Add(txtRang);
            pnlTakmicenje.Controls.Add(lblNazivTakmicenja); pnlTakmicenje.Controls.Add(txtNazivTakmicenja);
            pnlTakmicenje.Controls.Add(chkTimska);

            // Dugmad
            btnOk.Location = new Point(340, 380); btnOk.Size = new Size(80, 30); btnOk.Text = "OK"; btnOk.Click += btnOk_Click;
            btnCancel.Location = new Point(440, 380); btnCancel.Size = new Size(80, 30); btnCancel.Text = "Odustani"; btnCancel.Click += btnCancel_Click;

            // Dodavanje kontrola
            Controls.Add(lblTip); Controls.Add(cbTip);
            Controls.Add(lblId); Controls.Add(txtId);
            Controls.Add(lblNaziv); Controls.Add(txtNaziv);
            Controls.Add(lblOpis); Controls.Add(txtOpis);
            Controls.Add(lblInstitucija); Controls.Add(txtInstitucija);
            Controls.Add(lblDatum); Controls.Add(dtpDatum);
            Controls.Add(lblNivo); Controls.Add(cbNivo);
            Controls.Add(lblMentor); Controls.Add(txtMentor);

            Controls.Add(pnlSertifikat);
            Controls.Add(pnlPohvala);
            Controls.Add(pnlTakmicenje);

            Controls.Add(btnOk); Controls.Add(btnCancel);

            ClientSize = new Size(540, 420);
            Name = "DodajDostignuceForm";
            Text = "Dodaj dostignuće";
            StartPosition = FormStartPosition.CenterParent;

            // Inicijalno sakrij sve panele, PrikaziPanel će prikazati odgovarajući
            pnlSertifikat.Visible = false;
            pnlPohvala.Visible = false;
            pnlTakmicenje.Visible = false;

            ResumeLayout(false);
            PerformLayout();
        }
    }
}