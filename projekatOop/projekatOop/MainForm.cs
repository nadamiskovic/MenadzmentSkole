using System;
using System.Windows.Forms;

namespace projekatOop
{
    /// <summary>
    /// Navigacioni meni aplikacije — partial klasa:
    /// konstruktor poziva InitializeComponent, ovde su event handleri.
    /// Kontrole su definisane u MainForm.Designer.cs da ne bude duplikata.
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnAdministracija_Click(object sender, EventArgs e)
        {
            using var forma = new ZaposleniForm();
            forma.ShowDialog(this);
        }

        private void BtnUcenici_Click(object sender, EventArgs e)
        {
            using var forma = new UceniciForm();
            forma.ShowDialog(this);
        }

        private void BtnRasporedCasova_Click(object sender, EventArgs e)
        {
            using var forma = new RasporedForm();
            forma.ShowDialog(this);
        }

        private void BtnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}