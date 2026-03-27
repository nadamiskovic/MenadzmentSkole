using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projekatOop
{
    public partial class s : Form
    {
        public s()
        {

        }

        private void InitializeComponent()
        {
            lblTip = new Label();
            lblid = new Label();
            lblnaziv = new Label();
            CMBTip = new ComboBox();
            txtid = new TextBox();
            txtnaziv = new TextBox();
            txtopis = new TextBox();
            txtinstitucija = new TextBox();
            txtmentor = new TextBox();
            lblopis = new Label();
            lblinstitucija = new Label();
            lbldatum = new Label();
            dtpdatom = new DateTimePicker();
            lblnivo = new Label();
            cmbnivo = new ComboBox();
            lblmentor = new Label();
            lbloblast = new Label();
            txtoblast = new TextBox();
            lbltrajanje = new Label();
            lblbrojsertifikata = new Label();
            lblrok = new Label();
            txtbrojsertifikata = new TextBox();
            dtprok = new DateTimePicker();
            NUMTrajanje = new NumericUpDown();
            BTNOk = new Button();
            BTNOdustani = new Button();
            ((ISupportInitialize)NUMTrajanje).BeginInit();
            SuspendLayout();
            // 
            // lblTip
            // 
            lblTip.AutoSize = true;
            lblTip.Location = new Point(23, 18);
            lblTip.Name = "lblTip";
            lblTip.Size = new Size(23, 15);
            lblTip.TabIndex = 0;
            lblTip.Text = "Tip";
            lblTip.Click += lblIme_Click;
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Location = new Point(23, 53);
            lblid.Name = "lblid";
            lblid.Size = new Size(17, 15);
            lblid.TabIndex = 1;
            lblid.Text = "id";
            lblid.Click += label2_Click;
            // 
            // lblnaziv
            // 
            lblnaziv.AutoSize = true;
            lblnaziv.Location = new Point(23, 95);
            lblnaziv.Name = "lblnaziv";
            lblnaziv.Size = new Size(34, 15);
            lblnaziv.TabIndex = 2;
            lblnaziv.Text = "naziv";
            // 
            // CMBTip
            // 
            CMBTip.FormattingEnabled = true;
            CMBTip.Location = new Point(76, 18);
            CMBTip.Name = "CMBTip";
            CMBTip.Size = new Size(121, 23);
            CMBTip.TabIndex = 3;
            // 
            // txtid
            // 
            txtid.Location = new Point(76, 53);
            txtid.Name = "txtid";
            txtid.Size = new Size(121, 23);
            txtid.TabIndex = 4;
            // 
            // txtnaziv
            // 
            txtnaziv.Location = new Point(76, 92);
            txtnaziv.Name = "txtnaziv";
            txtnaziv.Size = new Size(398, 23);
            txtnaziv.TabIndex = 5;
            // 
            // txtopis
            // 
            txtopis.Location = new Point(76, 128);
            txtopis.Name = "txtopis";
            txtopis.Size = new Size(398, 23);
            txtopis.TabIndex = 6;
            // 
            // txtinstitucija
            // 
            txtinstitucija.Location = new Point(87, 164);
            txtinstitucija.Name = "txtinstitucija";
            txtinstitucija.Size = new Size(387, 23);
            txtinstitucija.TabIndex = 7;
            // 
            // txtmentor
            // 
            txtmentor.Location = new Point(87, 225);
            txtmentor.Name = "txtmentor";
            txtmentor.Size = new Size(200, 23);
            txtmentor.TabIndex = 8;
            // 
            // lblopis
            // 
            lblopis.AutoSize = true;
            lblopis.Location = new Point(23, 128);
            lblopis.Name = "lblopis";
            lblopis.Size = new Size(29, 15);
            lblopis.TabIndex = 9;
            lblopis.Text = "opis";
            // 
            // lblinstitucija
            // 
            lblinstitucija.AutoSize = true;
            lblinstitucija.Location = new Point(23, 172);
            lblinstitucija.Name = "lblinstitucija";
            lblinstitucija.Size = new Size(58, 15);
            lblinstitucija.TabIndex = 10;
            lblinstitucija.Text = "institucija";
            // 
            // lbldatum
            // 
            lbldatum.AutoSize = true;
            lbldatum.Location = new Point(23, 202);
            lbldatum.Name = "lbldatum";
            lbldatum.Size = new Size(42, 15);
            lbldatum.TabIndex = 11;
            lbldatum.Text = "datum";
            // 
            // dtpdatom
            // 
            dtpdatom.Location = new Point(87, 196);
            dtpdatom.Name = "dtpdatom";
            dtpdatom.Size = new Size(200, 23);
            dtpdatom.TabIndex = 12;
            // 
            // lblnivo
            // 
            lblnivo.AutoSize = true;
            lblnivo.Location = new Point(318, 205);
            lblnivo.Name = "lblnivo";
            lblnivo.Size = new Size(30, 15);
            lblnivo.TabIndex = 13;
            lblnivo.Text = "nivo";
            // 
            // cmbnivo
            // 
            cmbnivo.FormattingEnabled = true;
            cmbnivo.Location = new Point(354, 199);
            cmbnivo.Name = "cmbnivo";
            cmbnivo.Size = new Size(121, 23);
            cmbnivo.TabIndex = 14;
            // 
            // lblmentor
            // 
            lblmentor.AutoSize = true;
            lblmentor.Location = new Point(23, 228);
            lblmentor.Name = "lblmentor";
            lblmentor.Size = new Size(46, 15);
            lblmentor.TabIndex = 15;
            lblmentor.Text = "mentor";
            // 
            // lbloblast
            // 
            lbloblast.AutoSize = true;
            lbloblast.Location = new Point(23, 261);
            lbloblast.Name = "lbloblast";
            lbloblast.Size = new Size(39, 15);
            lbloblast.TabIndex = 16;
            lbloblast.Text = "oblast";
            // 
            // txtoblast
            // 
            txtoblast.Location = new Point(87, 261);
            txtoblast.Name = "txtoblast";
            txtoblast.Size = new Size(200, 23);
            txtoblast.TabIndex = 17;
            // 
            // lbltrajanje
            // 
            lbltrajanje.AutoSize = true;
            lbltrajanje.Location = new Point(23, 298);
            lbltrajanje.Name = "lbltrajanje";
            lbltrajanje.Size = new Size(46, 15);
            lbltrajanje.TabIndex = 18;
            lbltrajanje.Text = "trajanje";
            // 
            // lblbrojsertifikata
            // 
            lblbrojsertifikata.AutoSize = true;
            lblbrojsertifikata.Location = new Point(23, 325);
            lblbrojsertifikata.Name = "lblbrojsertifikata";
            lblbrojsertifikata.Size = new Size(82, 15);
            lblbrojsertifikata.TabIndex = 19;
            lblbrojsertifikata.Text = "broj sertifikata";
            // 
            // lblrok
            // 
            lblrok.AutoSize = true;
            lblrok.Location = new Point(24, 366);
            lblrok.Name = "lblrok";
            lblrok.Size = new Size(24, 15);
            lblrok.TabIndex = 20;
            lblrok.Text = "rok";
            // 
            // txtbrojsertifikata
            // 
            txtbrojsertifikata.Location = new Point(111, 322);
            txtbrojsertifikata.Name = "txtbrojsertifikata";
            txtbrojsertifikata.Size = new Size(176, 23);
            txtbrojsertifikata.TabIndex = 21;
            // 
            // dtprok
            // 
            dtprok.Location = new Point(76, 360);
            dtprok.Name = "dtprok";
            dtprok.Size = new Size(200, 23);
            dtprok.TabIndex = 22;
            // 
            // NUMTrajanje
            // 
            NUMTrajanje.Location = new Point(111, 293);
            NUMTrajanje.Name = "NUMTrajanje";
            NUMTrajanje.Size = new Size(120, 23);
            NUMTrajanje.TabIndex = 23;
            // 
            // BTNOk
            // 
            BTNOk.Location = new Point(420, 399);
            BTNOk.Name = "BTNOk";
            BTNOk.Size = new Size(75, 23);
            BTNOk.TabIndex = 24;
            BTNOk.Text = "Ok";
            BTNOk.UseVisualStyleBackColor = true;
            // 
            // BTNOdustani
            // 
            BTNOdustani.Location = new Point(516, 399);
            BTNOdustani.Name = "BTNOdustani";
            BTNOdustani.Size = new Size(75, 23);
            BTNOdustani.TabIndex = 25;
            BTNOdustani.Text = "Odustani";
            BTNOdustani.UseVisualStyleBackColor = true;
            // 
            // s
            // 
            ClientSize = new Size(600, 434);
            Controls.Add(BTNOdustani);
            Controls.Add(BTNOk);
            Controls.Add(NUMTrajanje);
            Controls.Add(dtprok);
            Controls.Add(txtbrojsertifikata);
            Controls.Add(lblrok);
            Controls.Add(lblbrojsertifikata);
            Controls.Add(lbltrajanje);
            Controls.Add(txtoblast);
            Controls.Add(lbloblast);
            Controls.Add(lblmentor);
            Controls.Add(cmbnivo);
            Controls.Add(lblnivo);
            Controls.Add(dtpdatom);
            Controls.Add(lbldatum);
            Controls.Add(lblinstitucija);
            Controls.Add(lblopis);
            Controls.Add(txtmentor);
            Controls.Add(txtinstitucija);
            Controls.Add(txtopis);
            Controls.Add(txtnaziv);
            Controls.Add(txtid);
            Controls.Add(CMBTip);
            Controls.Add(lblnaziv);
            Controls.Add(lblid);
            Controls.Add(lblTip);
            Name = "s";
            ((ISupportInitialize)NUMTrajanje).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private Label lblTip;
        private Label lblnaziv;
        private ComboBox CMBTip;
        private TextBox txtid;
        private TextBox txtnaziv;
        private TextBox txtopis;
        private TextBox txtinstitucija;
        private TextBox txtmentor;
        private Label lblopis;
        private Label lblinstitucija;
        private Label lbldatum;
        private DateTimePicker dtpdatom;
        private Label lblnivo;
        private ComboBox cmbnivo;
        private Label lblmentor;
        private Label lbloblast;
        private TextBox txtoblast;
        private Label lbltrajanje;
        private Label lblbrojsertifikata;
        private Label lblrok;
        private TextBox txtbrojsertifikata;
        private DateTimePicker dtprok;
        private NumericUpDown NUMTrajanje;
        private Button BTNOk;
        private Button BTNOdustani;
        private Label lblid;

        private void lblIme_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
