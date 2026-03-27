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
            pnlSertifikat.SuspendLayout();
            ((ISupportInitialize)numTrajanje).BeginInit();
            pnlPohvala.SuspendLayout();
            pnlTakmicenje.SuspendLayout();
            SuspendLayout();
            // 
            // lblTip
            // 
            lblTip.Location = new Point(12, 12);
            lblTip.Name = "lblTip";
            lblTip.Size = new Size(80, 23);
            lblTip.TabIndex = 0;
            lblTip.Text = "Tip:";
            // 
            // cbTip
            // 
            cbTip.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTip.Location = new Point(100, 12);
            cbTip.Name = "cbTip";
            cbTip.Size = new Size(200, 23);
            cbTip.TabIndex = 1;
            cbTip.SelectedIndexChanged += cbTip_SelectedIndexChanged;
            // 
            // lblId
            // 
            lblId.Location = new Point(12, 45);
            lblId.Name = "lblId";
            lblId.Size = new Size(80, 23);
            lblId.TabIndex = 2;
            lblId.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Location = new Point(100, 45);
            txtId.Name = "txtId";
            txtId.Size = new Size(200, 23);
            txtId.TabIndex = 3;
            // 
            // lblNaziv
            // 
            lblNaziv.Location = new Point(12, 78);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(80, 23);
            lblNaziv.TabIndex = 4;
            lblNaziv.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(100, 78);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(400, 23);
            txtNaziv.TabIndex = 5;
            // 
            // lblOpis
            // 
            lblOpis.Location = new Point(12, 111);
            lblOpis.Name = "lblOpis";
            lblOpis.Size = new Size(80, 23);
            lblOpis.TabIndex = 6;
            lblOpis.Text = "Opis:";
            // 
            // txtOpis
            // 
            txtOpis.Location = new Point(100, 111);
            txtOpis.Name = "txtOpis";
            txtOpis.Size = new Size(400, 23);
            txtOpis.TabIndex = 7;
            // 
            // lblInstitucija
            // 
            lblInstitucija.Location = new Point(12, 144);
            lblInstitucija.Name = "lblInstitucija";
            lblInstitucija.Size = new Size(80, 23);
            lblInstitucija.TabIndex = 8;
            lblInstitucija.Text = "Institucija:";
            // 
            // txtInstitucija
            // 
            txtInstitucija.Location = new Point(100, 144);
            txtInstitucija.Name = "txtInstitucija";
            txtInstitucija.Size = new Size(400, 23);
            txtInstitucija.TabIndex = 9;
            // 
            // lblDatum
            // 
            lblDatum.Location = new Point(12, 177);
            lblDatum.Name = "lblDatum";
            lblDatum.Size = new Size(80, 23);
            lblDatum.TabIndex = 10;
            lblDatum.Text = "Datum:";
            // 
            // dtpDatum
            // 
            dtpDatum.Location = new Point(100, 177);
            dtpDatum.Name = "dtpDatum";
            dtpDatum.Size = new Size(200, 23);
            dtpDatum.TabIndex = 11;
            // 
            // lblNivo
            // 
            lblNivo.Location = new Point(320, 177);
            lblNivo.Name = "lblNivo";
            lblNivo.Size = new Size(50, 23);
            lblNivo.TabIndex = 12;
            lblNivo.Text = "Nivo:";
            // 
            // cbNivo
            // 
            cbNivo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNivo.Location = new Point(380, 177);
            cbNivo.Name = "cbNivo";
            cbNivo.Size = new Size(120, 23);
            cbNivo.TabIndex = 13;
            // 
            // lblMentor
            // 
            lblMentor.Location = new Point(12, 210);
            lblMentor.Name = "lblMentor";
            lblMentor.Size = new Size(80, 23);
            lblMentor.TabIndex = 14;
            lblMentor.Text = "Mentor:";
            // 
            // txtMentor
            // 
            txtMentor.Location = new Point(100, 210);
            txtMentor.Name = "txtMentor";
            txtMentor.Size = new Size(400, 23);
            txtMentor.TabIndex = 15;
            // 
            // pnlSertifikat
            // 
            pnlSertifikat.Controls.Add(lblOblast);
            pnlSertifikat.Controls.Add(txtOblast);
            pnlSertifikat.Controls.Add(lblTrajanje);
            pnlSertifikat.Controls.Add(numTrajanje);
            pnlSertifikat.Controls.Add(lblBrojSertifikata);
            pnlSertifikat.Controls.Add(txtBrojSertifikata);
            pnlSertifikat.Controls.Add(lblRokVazenja);
            pnlSertifikat.Controls.Add(dtpRokVazenja);
            pnlSertifikat.Location = new Point(12, 245);
            pnlSertifikat.Name = "pnlSertifikat";
            pnlSertifikat.Size = new Size(520, 120);
            pnlSertifikat.TabIndex = 16;
            pnlSertifikat.Visible = false;
            // 
            // lblOblast
            // 
            lblOblast.Location = new Point(0, 0);
            lblOblast.Name = "lblOblast";
            lblOblast.Size = new Size(80, 23);
            lblOblast.TabIndex = 0;
            lblOblast.Text = "Oblast:";
            // 
            // txtOblast
            // 
            txtOblast.Location = new Point(90, 0);
            txtOblast.Name = "txtOblast";
            txtOblast.Size = new Size(200, 23);
            txtOblast.TabIndex = 1;
            // 
            // lblTrajanje
            // 
            lblTrajanje.Location = new Point(0, 33);
            lblTrajanje.Name = "lblTrajanje";
            lblTrajanje.Size = new Size(80, 23);
            lblTrajanje.TabIndex = 2;
            lblTrajanje.Text = "Trajanje (h):";
            // 
            // numTrajanje
            // 
            numTrajanje.Location = new Point(90, 33);
            numTrajanje.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numTrajanje.Name = "numTrajanje";
            numTrajanje.Size = new Size(100, 23);
            numTrajanje.TabIndex = 3;
            // 
            // lblBrojSertifikata
            // 
            lblBrojSertifikata.Location = new Point(0, 66);
            lblBrojSertifikata.Name = "lblBrojSertifikata";
            lblBrojSertifikata.Size = new Size(120, 23);
            lblBrojSertifikata.TabIndex = 4;
            lblBrojSertifikata.Text = "Broj sertifikata:";
            // 
            // txtBrojSertifikata
            // 
            txtBrojSertifikata.Location = new Point(130, 66);
            txtBrojSertifikata.Name = "txtBrojSertifikata";
            txtBrojSertifikata.Size = new Size(160, 23);
            txtBrojSertifikata.TabIndex = 5;
            // 
            // lblRokVazenja
            // 
            lblRokVazenja.Location = new Point(0, 99);
            lblRokVazenja.Name = "lblRokVazenja";
            lblRokVazenja.Size = new Size(120, 23);
            lblRokVazenja.TabIndex = 6;
            lblRokVazenja.Text = "Rok važenja:";
            // 
            // dtpRokVazenja
            // 
            dtpRokVazenja.Location = new Point(130, 99);
            dtpRokVazenja.Name = "dtpRokVazenja";
            dtpRokVazenja.Size = new Size(160, 23);
            dtpRokVazenja.TabIndex = 7;
            // 
            // pnlPohvala
            // 
            pnlPohvala.Controls.Add(lblRazlog);
            pnlPohvala.Controls.Add(txtRazlog);
            pnlPohvala.Controls.Add(lblDodelio);
            pnlPohvala.Controls.Add(txtDodelio);
            pnlPohvala.Controls.Add(lblSkolskaGodina);
            pnlPohvala.Controls.Add(txtSkolskaGodina);
            pnlPohvala.Location = new Point(12, 245);
            pnlPohvala.Name = "pnlPohvala";
            pnlPohvala.Size = new Size(520, 120);
            pnlPohvala.TabIndex = 17;
            pnlPohvala.Visible = false;
            // 
            // lblRazlog
            // 
            lblRazlog.Location = new Point(0, 0);
            lblRazlog.Name = "lblRazlog";
            lblRazlog.Size = new Size(80, 23);
            lblRazlog.TabIndex = 0;
            lblRazlog.Text = "Razlog:";
            // 
            // txtRazlog
            // 
            txtRazlog.Location = new Point(90, 0);
            txtRazlog.Name = "txtRazlog";
            txtRazlog.Size = new Size(400, 23);
            txtRazlog.TabIndex = 1;
            // 
            // lblDodelio
            // 
            lblDodelio.Location = new Point(0, 33);
            lblDodelio.Name = "lblDodelio";
            lblDodelio.Size = new Size(80, 23);
            lblDodelio.TabIndex = 2;
            lblDodelio.Text = "Dodelio:";
            // 
            // txtDodelio
            // 
            txtDodelio.Location = new Point(90, 33);
            txtDodelio.Name = "txtDodelio";
            txtDodelio.Size = new Size(200, 23);
            txtDodelio.TabIndex = 3;
            // 
            // lblSkolskaGodina
            // 
            lblSkolskaGodina.Location = new Point(0, 66);
            lblSkolskaGodina.Name = "lblSkolskaGodina";
            lblSkolskaGodina.Size = new Size(120, 23);
            lblSkolskaGodina.TabIndex = 4;
            lblSkolskaGodina.Text = "Školska godina:";
            // 
            // txtSkolskaGodina
            // 
            txtSkolskaGodina.Location = new Point(130, 66);
            txtSkolskaGodina.Name = "txtSkolskaGodina";
            txtSkolskaGodina.Size = new Size(160, 23);
            txtSkolskaGodina.TabIndex = 5;
            // 
            // pnlTakmicenje
            // 
            pnlTakmicenje.Controls.Add(lblRang);
            pnlTakmicenje.Controls.Add(txtRang);
            pnlTakmicenje.Controls.Add(lblNazivTakmicenja);
            pnlTakmicenje.Controls.Add(txtNazivTakmicenja);
            pnlTakmicenje.Controls.Add(chkTimska);
            pnlTakmicenje.Location = new Point(12, 245);
            pnlTakmicenje.Name = "pnlTakmicenje";
            pnlTakmicenje.Size = new Size(520, 120);
            pnlTakmicenje.TabIndex = 18;
            pnlTakmicenje.Visible = false;
            // 
            // lblRang
            // 
            lblRang.Location = new Point(0, 0);
            lblRang.Name = "lblRang";
            lblRang.Size = new Size(80, 23);
            lblRang.TabIndex = 0;
            lblRang.Text = "Rang:";
            // 
            // txtRang
            // 
            txtRang.Location = new Point(90, 0);
            txtRang.Name = "txtRang";
            txtRang.Size = new Size(80, 23);
            txtRang.TabIndex = 1;
            // 
            // lblNazivTakmicenja
            // 
            lblNazivTakmicenja.Location = new Point(0, 33);
            lblNazivTakmicenja.Name = "lblNazivTakmicenja";
            lblNazivTakmicenja.Size = new Size(120, 23);
            lblNazivTakmicenja.TabIndex = 2;
            lblNazivTakmicenja.Text = "Naziv takmičenja:";
            // 
            // txtNazivTakmicenja
            // 
            txtNazivTakmicenja.Location = new Point(130, 33);
            txtNazivTakmicenja.Name = "txtNazivTakmicenja";
            txtNazivTakmicenja.Size = new Size(300, 23);
            txtNazivTakmicenja.TabIndex = 3;
            // 
            // chkTimska
            // 
            chkTimska.Location = new Point(0, 66);
            chkTimska.Name = "chkTimska";
            chkTimska.Size = new Size(120, 23);
            chkTimska.TabIndex = 4;
            chkTimska.Text = "Timsko takmičenje";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(340, 380);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(80, 30);
            btnOk.TabIndex = 19;
            btnOk.Text = "OK";
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(440, 380);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(80, 30);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Odustani";
            btnCancel.Click += btnCancel_Click;
            // 
            // DodajDostignuceForm
            // 
            ClientSize = new Size(540, 420);
            Controls.Add(lblTip);
            Controls.Add(cbTip);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(lblNaziv);
            Controls.Add(txtNaziv);
            Controls.Add(lblOpis);
            Controls.Add(txtOpis);
            Controls.Add(lblInstitucija);
            Controls.Add(txtInstitucija);
            Controls.Add(lblDatum);
            Controls.Add(dtpDatum);
            Controls.Add(lblNivo);
            Controls.Add(cbNivo);
            Controls.Add(lblMentor);
            Controls.Add(txtMentor);
            Controls.Add(pnlSertifikat);
            Controls.Add(pnlPohvala);
            Controls.Add(pnlTakmicenje);
            Controls.Add(btnOk);
            Controls.Add(btnCancel);
            Name = "DodajDostignuceForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodaj dostignuće";
            pnlSertifikat.ResumeLayout(false);
            pnlSertifikat.PerformLayout();
            ((ISupportInitialize)numTrajanje).EndInit();
            pnlPohvala.ResumeLayout(false);
            pnlPohvala.PerformLayout();
            pnlTakmicenje.ResumeLayout(false);
            pnlTakmicenje.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}