using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace projekatOop
{
    partial class UceniciForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblIme;
        private TextBox txtIme;
        private Label lblPrezime;
        private TextBox txtPrezime;
        private Label lblJMBG;
        private TextBox txtJMBG;
        private Label lblOdeljenje;
        private TextBox txtOdeljenje;
        private Label lblProsek;
        private TextBox txtProsek;
        private Label lblDatum;
        private DateTimePicker dtpDatumUpisa;
        private Label lblVladanje;
        private ComboBox cbVladanje;
        private Label lblMatura;
        private ComboBox cbMatura;

        private GroupBox gbRoditelj;
        private Label lblRoditeljIme;
        private TextBox txtRoditeljIme;
        private Label lblRoditeljPrezime;
        private TextBox txtRoditeljPrezime;
        private Label lblRoditeljTelefon;
        private TextBox txtRoditeljTelefon;

        private Button btnDodajUcenika;
        private Button btnObrisi;
        private Button btnDostignuca;
        private DataGridView dgvUcenici;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblIme = new Label();
            txtIme = new TextBox();
            lblPrezime = new Label();
            txtPrezime = new TextBox();
            lblJMBG = new Label();
            txtJMBG = new TextBox();
            lblOdeljenje = new Label();
            txtOdeljenje = new TextBox();
            lblProsek = new Label();
            txtProsek = new TextBox();
            lblDatum = new Label();
            dtpDatumUpisa = new DateTimePicker();
            lblVladanje = new Label();
            cbVladanje = new ComboBox();
            lblMatura = new Label();
            cbMatura = new ComboBox();
            gbRoditelj = new GroupBox();
            lblRoditeljIme = new Label();
            txtRoditeljIme = new TextBox();
            lblRoditeljPrezime = new Label();
            txtRoditeljPrezime = new TextBox();
            lblRoditeljTelefon = new Label();
            txtRoditeljTelefon = new TextBox();
            btnDodajUcenika = new Button();
            btnObrisi = new Button();
            btnDostignuca = new Button();
            dgvUcenici = new DataGridView();
            gbRoditelj.SuspendLayout();
            ((ISupportInitialize)dgvUcenici).BeginInit();
            SuspendLayout();
            // 
            // lblIme
            // 
            lblIme.Location = new Point(12, 12);
            lblIme.Name = "lblIme";
            lblIme.Size = new Size(80, 23);
            lblIme.TabIndex = 20;
            lblIme.Text = "Ime:";
            // 
            // txtIme
            // 
            txtIme.Location = new Point(100, 12);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(200, 23);
            txtIme.TabIndex = 19;
            // 
            // lblPrezime
            // 
            lblPrezime.Location = new Point(12, 45);
            lblPrezime.Name = "lblPrezime";
            lblPrezime.Size = new Size(80, 23);
            lblPrezime.TabIndex = 18;
            lblPrezime.Text = "Prezime:";
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(100, 45);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(200, 23);
            txtPrezime.TabIndex = 17;
            // 
            // lblJMBG
            // 
            lblJMBG.Location = new Point(12, 78);
            lblJMBG.Name = "lblJMBG";
            lblJMBG.Size = new Size(80, 23);
            lblJMBG.TabIndex = 16;
            lblJMBG.Text = "JMBG:";
            // 
            // txtJMBG
            // 
            txtJMBG.Location = new Point(100, 78);
            txtJMBG.Name = "txtJMBG";
            txtJMBG.Size = new Size(200, 23);
            txtJMBG.TabIndex = 15;
            // 
            // lblOdeljenje
            // 
            lblOdeljenje.Location = new Point(12, 111);
            lblOdeljenje.Name = "lblOdeljenje";
            lblOdeljenje.Size = new Size(80, 23);
            lblOdeljenje.TabIndex = 14;
            lblOdeljenje.Text = "Odeljenje:";
            // 
            // txtOdeljenje
            // 
            txtOdeljenje.Location = new Point(100, 111);
            txtOdeljenje.Name = "txtOdeljenje";
            txtOdeljenje.Size = new Size(200, 23);
            txtOdeljenje.TabIndex = 13;
            // 
            // lblProsek
            // 
            lblProsek.Location = new Point(12, 144);
            lblProsek.Name = "lblProsek";
            lblProsek.Size = new Size(80, 23);
            lblProsek.TabIndex = 12;
            lblProsek.Text = "Prosek:";
            // 
            // txtProsek
            // 
            txtProsek.Location = new Point(100, 144);
            txtProsek.Name = "txtProsek";
            txtProsek.Size = new Size(200, 23);
            txtProsek.TabIndex = 11;
            txtProsek.Text = "0";
            // 
            // lblDatum
            // 
            lblDatum.Location = new Point(12, 177);
            lblDatum.Name = "lblDatum";
            lblDatum.Size = new Size(80, 23);
            lblDatum.TabIndex = 10;
            lblDatum.Text = "Datum upisa:";
            // 
            // dtpDatumUpisa
            // 
            dtpDatumUpisa.Location = new Point(100, 177);
            dtpDatumUpisa.Name = "dtpDatumUpisa";
            dtpDatumUpisa.Size = new Size(200, 23);
            dtpDatumUpisa.TabIndex = 9;
            // 
            // lblVladanje
            // 
            lblVladanje.Location = new Point(12, 210);
            lblVladanje.Name = "lblVladanje";
            lblVladanje.Size = new Size(80, 23);
            lblVladanje.TabIndex = 8;
            lblVladanje.Text = "Vladanje:";
            // 
            // cbVladanje
            // 
            cbVladanje.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVladanje.Location = new Point(100, 210);
            cbVladanje.Name = "cbVladanje";
            cbVladanje.Size = new Size(200, 23);
            cbVladanje.TabIndex = 7;
            // 
            // lblMatura
            // 
            lblMatura.Location = new Point(12, 243);
            lblMatura.Name = "lblMatura";
            lblMatura.Size = new Size(80, 23);
            lblMatura.TabIndex = 6;
            lblMatura.Text = "Matura:";
            // 
            // cbMatura
            // 
            cbMatura.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMatura.ForeColor = Color.Black;
            cbMatura.Location = new Point(100, 243);
            cbMatura.Name = "cbMatura";
            cbMatura.Size = new Size(200, 23);
            cbMatura.TabIndex = 5;
            // 
            // gbRoditelj
            // 
            gbRoditelj.Controls.Add(lblRoditeljIme);
            gbRoditelj.Controls.Add(txtRoditeljIme);
            gbRoditelj.Controls.Add(lblRoditeljPrezime);
            gbRoditelj.Controls.Add(txtRoditeljPrezime);
            gbRoditelj.Controls.Add(lblRoditeljTelefon);
            gbRoditelj.Controls.Add(txtRoditeljTelefon);
            gbRoditelj.Location = new Point(330, 12);
            gbRoditelj.Name = "gbRoditelj";
            gbRoditelj.Size = new Size(320, 160);
            gbRoditelj.TabIndex = 4;
            gbRoditelj.TabStop = false;
            gbRoditelj.Text = "Podaci o roditelju";
            // 
            // lblRoditeljIme
            // 
            lblRoditeljIme.Location = new Point(10, 25);
            lblRoditeljIme.Name = "lblRoditeljIme";
            lblRoditeljIme.Size = new Size(80, 23);
            lblRoditeljIme.TabIndex = 0;
            lblRoditeljIme.Text = "Ime:";
            // 
            // txtRoditeljIme
            // 
            txtRoditeljIme.Location = new Point(100, 25);
            txtRoditeljIme.Name = "txtRoditeljIme";
            txtRoditeljIme.Size = new Size(200, 23);
            txtRoditeljIme.TabIndex = 1;
            // 
            // lblRoditeljPrezime
            // 
            lblRoditeljPrezime.Location = new Point(10, 58);
            lblRoditeljPrezime.Name = "lblRoditeljPrezime";
            lblRoditeljPrezime.Size = new Size(80, 23);
            lblRoditeljPrezime.TabIndex = 2;
            lblRoditeljPrezime.Text = "Prezime:";
            // 
            // txtRoditeljPrezime
            // 
            txtRoditeljPrezime.Location = new Point(100, 58);
            txtRoditeljPrezime.Name = "txtRoditeljPrezime";
            txtRoditeljPrezime.Size = new Size(200, 23);
            txtRoditeljPrezime.TabIndex = 3;
            // 
            // lblRoditeljTelefon
            // 
            lblRoditeljTelefon.Location = new Point(10, 91);
            lblRoditeljTelefon.Name = "lblRoditeljTelefon";
            lblRoditeljTelefon.Size = new Size(80, 23);
            lblRoditeljTelefon.TabIndex = 4;
            lblRoditeljTelefon.Text = "Telefon:";
            // 
            // txtRoditeljTelefon
            // 
            txtRoditeljTelefon.Location = new Point(100, 91);
            txtRoditeljTelefon.Name = "txtRoditeljTelefon";
            txtRoditeljTelefon.Size = new Size(200, 23);
            txtRoditeljTelefon.TabIndex = 5;
            // 
            // btnDodajUcenika
            // 
            btnDodajUcenika.BackColor = Color.Linen;
            btnDodajUcenika.Location = new Point(330, 190);
            btnDodajUcenika.Name = "btnDodajUcenika";
            btnDodajUcenika.Size = new Size(150, 40);
            btnDodajUcenika.TabIndex = 3;
            btnDodajUcenika.Text = "Dodaj učenika";
            btnDodajUcenika.UseVisualStyleBackColor = false;
            btnDodajUcenika.Click += btnDodajUcenika_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.BackColor = Color.Linen;
            btnObrisi.Location = new Point(500, 190);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(150, 40);
            btnObrisi.TabIndex = 2;
            btnObrisi.Text = "Obriši selektovanog";
            btnObrisi.UseVisualStyleBackColor = false;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // btnDostignuca
            // 
            btnDostignuca.BackColor = Color.Linen;
            btnDostignuca.Location = new Point(414, 243);
            btnDostignuca.Name = "btnDostignuca";
            btnDostignuca.Size = new Size(150, 40);
            btnDostignuca.TabIndex = 1;
            btnDostignuca.Text = "Dostignuća";
            btnDostignuca.UseVisualStyleBackColor = false;
            btnDostignuca.Click += btnDostignuca_Click;
            // 
            // dgvUcenici
            // 
            dgvUcenici.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUcenici.BackgroundColor = Color.Linen;
            dgvUcenici.Location = new Point(12, 300);
            dgvUcenici.Name = "dgvUcenici";
            dgvUcenici.ReadOnly = true;
            dgvUcenici.Size = new Size(760, 340);
            dgvUcenici.TabIndex = 0;
            // 
            // UceniciForm
            // 
            BackColor = Color.Ivory;
            ClientSize = new Size(984, 661);
            Controls.Add(dgvUcenici);
            Controls.Add(btnDostignuca);
            Controls.Add(btnObrisi);
            Controls.Add(btnDodajUcenika);
            Controls.Add(gbRoditelj);
            Controls.Add(cbMatura);
            Controls.Add(lblMatura);
            Controls.Add(cbVladanje);
            Controls.Add(lblVladanje);
            Controls.Add(dtpDatumUpisa);
            Controls.Add(lblDatum);
            Controls.Add(txtProsek);
            Controls.Add(lblProsek);
            Controls.Add(txtOdeljenje);
            Controls.Add(lblOdeljenje);
            Controls.Add(txtJMBG);
            Controls.Add(lblJMBG);
            Controls.Add(txtPrezime);
            Controls.Add(lblPrezime);
            Controls.Add(txtIme);
            Controls.Add(lblIme);
            Name = "UceniciForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Učenici";
            gbRoditelj.ResumeLayout(false);
            gbRoditelj.PerformLayout();
            ((ISupportInitialize)dgvUcenici).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}