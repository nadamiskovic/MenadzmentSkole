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

        // nove kontrole za predmet ovo je visible samo kada je pozicija = profesor.
        private Label lblPredmet;
        private CheckedListBox clbPredmet;

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
            lblPredmet = new Label();
            clbPredmet = new CheckedListBox();
            ((ISupportInitialize)dgvZaposleni).BeginInit();
            SuspendLayout();
            // 
            // lblIme
            // 
            lblIme.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblIme.ForeColor = SystemColors.Control;
            lblIme.Location = new Point(12, 12);
            lblIme.Name = "lblIme";
            lblIme.Size = new Size(80, 23);
            lblIme.TabIndex = 12;
            lblIme.Text = "Ime:";
            // 
            // txtIme
            // 
            txtIme.BackColor = SystemColors.Control;
            txtIme.Font = new Font("Tahoma", 9F);
            txtIme.ForeColor = SystemColors.WindowText;
            txtIme.Location = new Point(100, 12);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(200, 22);
            txtIme.TabIndex = 11;
            // 
            // lblPrezime
            // 
            lblPrezime.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblPrezime.ForeColor = SystemColors.Control;
            lblPrezime.Location = new Point(12, 45);
            lblPrezime.Name = "lblPrezime";
            lblPrezime.Size = new Size(80, 23);
            lblPrezime.TabIndex = 10;
            lblPrezime.Text = "Prezime:";
            // 
            // txtPrezime
            // 
            txtPrezime.BackColor = SystemColors.Control;
            txtPrezime.Font = new Font("Tahoma", 9F);
            txtPrezime.ForeColor = SystemColors.WindowText;
            txtPrezime.Location = new Point(100, 45);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(200, 22);
            txtPrezime.TabIndex = 9;
            // 
            // lblID
            // 
            lblID.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblID.ForeColor = SystemColors.Control;
            lblID.Location = new Point(12, 78);
            lblID.Name = "lblID";
            lblID.Size = new Size(80, 23);
            lblID.TabIndex = 8;
            lblID.Text = "ID:";
            // 
            // txtID
            // 
            txtID.BackColor = SystemColors.Control;
            txtID.Font = new Font("Tahoma", 9F);
            txtID.ForeColor = SystemColors.WindowText;
            txtID.Location = new Point(100, 78);
            txtID.Name = "txtID";
            txtID.Size = new Size(200, 22);
            txtID.TabIndex = 7;
            // 
            // lblPozicija
            // 
            lblPozicija.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblPozicija.ForeColor = SystemColors.Control;
            lblPozicija.Location = new Point(12, 111);
            lblPozicija.Name = "lblPozicija";
            lblPozicija.Size = new Size(80, 23);
            lblPozicija.TabIndex = 6;
            lblPozicija.Text = "Pozicija:";
            // 
            // cmbPozicija
            // 
            cmbPozicija.BackColor = SystemColors.Control;
            cmbPozicija.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPozicija.Font = new Font("Tahoma", 9F);
            cmbPozicija.ForeColor = SystemColors.WindowText;
            cmbPozicija.Location = new Point(100, 111);
            cmbPozicija.Name = "cmbPozicija";
            cmbPozicija.Size = new Size(200, 22);
            cmbPozicija.TabIndex = 5;
            // 
            // btnDodaj
            // 
            btnDodaj.BackColor = SystemColors.Control;
            btnDodaj.Font = new Font("Tahoma", 9F, FontStyle.Italic);
            btnDodaj.Location = new Point(620, 12);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(150, 40);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "Dodaj zaposlenog";
            btnDodaj.UseVisualStyleBackColor = false;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.BackColor = SystemColors.Control;
            btnObrisi.Font = new Font("Tahoma", 9F, FontStyle.Italic);
            btnObrisi.ForeColor = Color.Black;
            btnObrisi.Location = new Point(620, 60);
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
            dgvZaposleni.BackgroundColor = SystemColors.Control;
            dgvZaposleni.ColumnHeadersHeight = 29;
            dgvZaposleni.Location = new Point(12, 190);
            dgvZaposleni.Name = "dgvZaposleni";
            dgvZaposleni.ReadOnly = true;
            dgvZaposleni.RowHeadersWidth = 51;
            dgvZaposleni.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvZaposleni.Size = new Size(760, 340);
            dgvZaposleni.TabIndex = 0;
            // 
            // cbFilterPozicija
            // 
            cbFilterPozicija.BackColor = SystemColors.Control;
            cbFilterPozicija.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterPozicija.Font = new Font("Tahoma", 9F);
            cbFilterPozicija.ForeColor = SystemColors.WindowText;
            cbFilterPozicija.Location = new Point(100, 145);
            cbFilterPozicija.Name = "cbFilterPozicija";
            cbFilterPozicija.Size = new Size(200, 22);
            cbFilterPozicija.TabIndex = 1;
            cbFilterPozicija.SelectedIndexChanged += cbFilterPozicija_SelectedIndexChanged;
            // 
            // lblFilter
            // 
            lblFilter.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblFilter.ForeColor = SystemColors.Control;
            lblFilter.Location = new Point(12, 145);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(100, 23);
            lblFilter.TabIndex = 2;
            lblFilter.Text = "Filter:";
            lblFilter.Click += lblFilter_Click;
            // 
            // lblPredmet
            // 
            lblPredmet.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblPredmet.ForeColor = SystemColors.Control;
            lblPredmet.Location = new Point(320, 12);
            lblPredmet.Name = "lblPredmet";
            lblPredmet.Size = new Size(80, 23);
            lblPredmet.TabIndex = 20;
            lblPredmet.Text = "Predmet:";
            lblPredmet.Visible = false;
            // 
            // clbPredmet
            // 
            clbPredmet.Font = new Font("Tahoma", 9F);
            clbPredmet.ForeColor = SystemColors.WindowText;
            clbPredmet.Location = new Point(410, 12);
            clbPredmet.Name = "clbPredmet";
            clbPredmet.Size = new Size(200, 160);
            clbPredmet.TabIndex = 21;
            clbPredmet.Visible = false;
            // 
            // ZaposleniForm
            // 
            BackColor = Color.Indigo;
            ClientSize = new Size(784, 561);
            Controls.Add(dgvZaposleni);
            Controls.Add(cbFilterPozicija);
            Controls.Add(lblFilter);
            Controls.Add(btnObrisi);
            Controls.Add(btnDodaj);
            Controls.Add(clbPredmet);
            Controls.Add(lblPredmet);
            Controls.Add(cmbPozicija);
            Controls.Add(lblPozicija);
            Controls.Add(txtID);
            Controls.Add(lblID);
            Controls.Add(txtPrezime);
            Controls.Add(lblPrezime);
            Controls.Add(txtIme);
            Controls.Add(lblIme);
            Font = new Font("Tahoma", 9F);
            Name = "ZaposleniForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Administracija zaposlenih";
            ((ISupportInitialize)dgvZaposleni).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
