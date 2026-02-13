using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace projekatOop
{
    partial class DostignucaForm
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox cbUcenik;
        private Label lblUcenik;
        private DataGridView dgvDostignuca;
        private Button btnDodajDostignuce;
        private Button btnObrisiDostignuce;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblUcenik = new Label();
            cbUcenik = new ComboBox();
            dgvDostignuca = new DataGridView();
            btnDodajDostignuce = new Button();
            btnObrisiDostignuce = new Button();
            ((ISupportInitialize)dgvDostignuca).BeginInit();
            SuspendLayout();
            // 
            // lblUcenik
            // 
            lblUcenik.Location = new Point(12, 12);
            lblUcenik.Name = "lblUcenik";
            lblUcenik.Size = new Size(80, 23);
            lblUcenik.TabIndex = 4;
            lblUcenik.Text = "Učenik:";
            // 
            // cbUcenik
            // 
            cbUcenik.BackColor = Color.Linen;
            cbUcenik.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUcenik.Location = new Point(100, 12);
            cbUcenik.Name = "cbUcenik";
            cbUcenik.Size = new Size(400, 23);
            cbUcenik.TabIndex = 3;
            cbUcenik.SelectedIndexChanged += cbUcenik_SelectedIndexChanged;
            // 
            // dgvDostignuca
            // 
            dgvDostignuca.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDostignuca.BackgroundColor = Color.Linen;
            dgvDostignuca.Location = new Point(12, 50);
            dgvDostignuca.Name = "dgvDostignuca";
            dgvDostignuca.ReadOnly = true;
            dgvDostignuca.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDostignuca.Size = new Size(760, 420);
            dgvDostignuca.TabIndex = 2;
            // 
            // btnDodajDostignuce
            // 
            btnDodajDostignuce.BackColor = Color.Linen;
            btnDodajDostignuce.Location = new Point(520, 10);
            btnDodajDostignuce.Name = "btnDodajDostignuce";
            btnDodajDostignuce.Size = new Size(120, 28);
            btnDodajDostignuce.TabIndex = 1;
            btnDodajDostignuce.Text = "Dodaj dostignuće";
            btnDodajDostignuce.UseVisualStyleBackColor = false;
            btnDodajDostignuce.Click += btnDodajDostignuce_Click;
            // 
            // btnObrisiDostignuce
            // 
            btnObrisiDostignuce.BackColor = Color.Linen;
            btnObrisiDostignuce.Location = new Point(650, 10);
            btnObrisiDostignuce.Name = "btnObrisiDostignuce";
            btnObrisiDostignuce.Size = new Size(120, 28);
            btnObrisiDostignuce.TabIndex = 0;
            btnObrisiDostignuce.Text = "Obriši selektovano";
            btnObrisiDostignuce.UseVisualStyleBackColor = false;
            btnObrisiDostignuce.Click += btnObrisiDostignuce_Click;
            // 
            // DostignucaForm
            // 
            BackColor = Color.Ivory;
            ClientSize = new Size(784, 481);
            Controls.Add(btnObrisiDostignuce);
            Controls.Add(btnDodajDostignuce);
            Controls.Add(dgvDostignuca);
            Controls.Add(cbUcenik);
            Controls.Add(lblUcenik);
            Name = "DostignucaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dostignuća učenika";
            ((ISupportInitialize)dgvDostignuca).EndInit();
            ResumeLayout(false);
        }
    }
}