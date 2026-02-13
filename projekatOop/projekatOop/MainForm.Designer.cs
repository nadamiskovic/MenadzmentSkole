using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace projekatOop
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        // Kontrole glavnog menija
        private Button btnAdministracija;
        private Button btnUcenici;
        private Button btnRasporedCasova;
        private Button btnIzlaz;

        /// <summary>
        /// Oslobodi resurse
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        /// <summary>
        /// Inicijalizacija komponenti (designer)
        /// </summary>
        private void InitializeComponent()
        {
            btnAdministracija = new Button();
            btnUcenici = new Button();
            btnRasporedCasova = new Button();
            btnIzlaz = new Button();
            SuspendLayout();
            // 
            // btnAdministracija
            // 
            btnAdministracija.BackColor = Color.Linen;
            btnAdministracija.Font = new Font("Berlin Sans FB Demi", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdministracija.ForeColor = Color.DimGray;
            btnAdministracija.Location = new Point(43, 49);
            btnAdministracija.Name = "btnAdministracija";
            btnAdministracija.Size = new Size(240, 40);
            btnAdministracija.TabIndex = 0;
            btnAdministracija.Text = "Administracija zaposlenih";
            btnAdministracija.UseVisualStyleBackColor = false;
            btnAdministracija.Click += BtnAdministracija_Click;
            // 
            // btnUcenici
            // 
            btnUcenici.BackColor = Color.Linen;
            btnUcenici.Font = new Font("Berlin Sans FB Demi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUcenici.ForeColor = Color.DimGray;
            btnUcenici.Location = new Point(43, 95);
            btnUcenici.Name = "btnUcenici";
            btnUcenici.Size = new Size(240, 40);
            btnUcenici.TabIndex = 1;
            btnUcenici.Text = "Učenici";
            btnUcenici.UseVisualStyleBackColor = false;
            btnUcenici.Click += BtnUcenici_Click;
            // 
            // btnRasporedCasova
            // 
            btnRasporedCasova.BackColor = Color.Linen;
            btnRasporedCasova.Font = new Font("Berlin Sans FB Demi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRasporedCasova.ForeColor = Color.DimGray;
            btnRasporedCasova.Location = new Point(43, 141);
            btnRasporedCasova.Name = "btnRasporedCasova";
            btnRasporedCasova.Size = new Size(240, 40);
            btnRasporedCasova.TabIndex = 2;
            btnRasporedCasova.Text = "Raspored časova";
            btnRasporedCasova.UseVisualStyleBackColor = false;
            btnRasporedCasova.Click += BtnRasporedCasova_Click;
            // 
            // btnIzlaz
            // 
            btnIzlaz.BackColor = Color.Maroon;
            btnIzlaz.Font = new Font("Berlin Sans FB Demi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIzlaz.ForeColor = SystemColors.ControlLightLight;
            btnIzlaz.Location = new Point(43, 187);
            btnIzlaz.Name = "btnIzlaz";
            btnIzlaz.Size = new Size(240, 40);
            btnIzlaz.TabIndex = 3;
            btnIzlaz.Text = "Izlaz";
            btnIzlaz.UseVisualStyleBackColor = false;
            btnIzlaz.Click += BtnIzlaz_Click;
            // 
            // MainForm
            // 
            BackColor = Color.Ivory;
            ClientSize = new Size(331, 282);
            Controls.Add(btnIzlaz);
            Controls.Add(btnRasporedCasova);
            Controls.Add(btnUcenici);
            Controls.Add(btnAdministracija);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Početna forma";
            ResumeLayout(false);
        }
    }
}