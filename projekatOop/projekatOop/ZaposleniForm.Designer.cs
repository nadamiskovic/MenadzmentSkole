using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace projekatOop
{
    partial class ZaposleniForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblIme;
        private TextBox txtIme;
        private Label lblPrezime;
        private TextBox txtPrezime;
        private Label lblID;
        private TextBox txtID;
        private Label lblPozicija;
        private ComboBox cmbPozicija;
        private Button btnDodaj;
        private Button btnObrisi;
        private DataGridView dgvZaposleni;
        private ComboBox cbFilterPozicija;
        private Label lblFilter;

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
            lblID = new Label();
            txtID = new TextBox();
            lblPozicija = new Label();
            cmbPozicija = new ComboBox();
            btnDodaj = new Button();
            btnObrisi = new Button();
            dgvZaposleni = new DataGridView();
            cbFilterPozicija = new ComboBox();
            lblFilter = new Label();
            ((ISupportInitialize)dgvZaposleni).BeginInit();
            SuspendLayout();
            // 
            // lblIme
            // 
            lblIme.Location = new Point(12, 12);
            lblIme.Name = "lblIme";
            lblIme.Size = new Size(80, 23);
            lblIme.TabIndex = 12;
            lblIme.Text = "Ime:";
            // 
            // txtIme
            // 
            txtIme.BackColor = Color.Linen;
            txtIme.Location = new Point(100, 12);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(200, 23);
            txtIme.TabIndex = 11;
            // 
            // lblPrezime
            // 
            lblPrezime.Location = new Point(12, 45);
            lblPrezime.Name = "lblPrezime";
            lblPrezime.Size = new Size(80, 23);
            lblPrezime.TabIndex = 10;
            lblPrezime.Text = "Prezime:";
            // 
            // txtPrezime
            // 
            txtPrezime.BackColor = Color.Linen;
            txtPrezime.Location = new Point(100, 45);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(200, 23);
            txtPrezime.TabIndex = 9;
            // 
            // lblID
            // 
            lblID.Location = new Point(12, 78);
            lblID.Name = "lblID";
            lblID.Size = new Size(80, 23);
            lblID.TabIndex = 8;
            lblID.Text = "ID:";
            // 
            // txtID
            // 
            txtID.BackColor = Color.Linen;
            txtID.Location = new Point(100, 78);
            txtID.Name = "txtID";
            txtID.Size = new Size(200, 23);
            txtID.TabIndex = 7;
            // 
            // lblPozicija
            // 
            lblPozicija.Location = new Point(12, 111);
            lblPozicija.Name = "lblPozicija";
            lblPozicija.Size = new Size(80, 23);
            lblPozicija.TabIndex = 6;
            lblPozicija.Text = "Pozicija:";
            // 
            // cmbPozicija
            // 
            cmbPozicija.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPozicija.Location = new Point(100, 111);
            cmbPozicija.Name = "cmbPozicija";
            cmbPozicija.Size = new Size(200, 23);
            cmbPozicija.TabIndex = 5;
            // 
            // btnDodaj
            // 
            btnDodaj.BackColor = Color.Linen;
            btnDodaj.Location = new Point(320, 12);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(150, 40);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "Dodaj zaposlenog";
            btnDodaj.UseVisualStyleBackColor = false;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.BackColor = Color.Linen;
            btnObrisi.ForeColor = Color.Black;
            btnObrisi.Location = new Point(320, 62);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(150, 40);
            btnObrisi.TabIndex = 3;
            btnObrisi.Text = "Obriši selektovanog";
            btnObrisi.UseVisualStyleBackColor = false;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // dgvZaposleni
            // 
            dgvZaposleni.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvZaposleni.BackgroundColor = Color.Linen;
            dgvZaposleni.Location = new Point(12, 190);
            dgvZaposleni.Name = "dgvZaposleni";
            dgvZaposleni.ReadOnly = true;
            dgvZaposleni.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvZaposleni.Size = new Size(760, 340);
            dgvZaposleni.TabIndex = 0;
            // 
            // cbFilterPozicija
            // 
            cbFilterPozicija.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterPozicija.Location = new Point(120, 150);
            cbFilterPozicija.Name = "cbFilterPozicija";
            cbFilterPozicija.Size = new Size(180, 23);
            cbFilterPozicija.TabIndex = 1;
            cbFilterPozicija.SelectedIndexChanged += cbFilterPozicija_SelectedIndexChanged;
            // 
            // lblFilter
            // 
            lblFilter.Location = new Point(12, 150);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(100, 23);
            lblFilter.TabIndex = 2;
            lblFilter.Text = "Filter pozicija:";
            // 
            // ZaposleniForm
            // 
            BackColor = Color.Ivory;
            ClientSize = new Size(784, 561);
            Controls.Add(dgvZaposleni);
            Controls.Add(cbFilterPozicija);
            Controls.Add(lblFilter);
            Controls.Add(btnObrisi);
            Controls.Add(btnDodaj);
            Controls.Add(cmbPozicija);
            Controls.Add(lblPozicija);
            Controls.Add(txtID);
            Controls.Add(lblID);
            Controls.Add(txtPrezime);
            Controls.Add(lblPrezime);
            Controls.Add(txtIme);
            Controls.Add(lblIme);
            Name = "ZaposleniForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Administracija zaposlenih";
            ((ISupportInitialize)dgvZaposleni).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}