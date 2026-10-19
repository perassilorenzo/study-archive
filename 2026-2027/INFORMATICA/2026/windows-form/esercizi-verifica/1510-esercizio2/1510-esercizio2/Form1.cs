using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1510_esercizio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void apriMagazzinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMagazzino formMagazzino = new FormMagazzino();
            formMagazzino.MdiParent = this;
            formMagazzino.Show();
        }

        private void apriClientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClienti formClienti = new FormClienti();
            formClienti.MdiParent = this;
            formClienti.Show();
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void confermaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Confermi?", "Conferma", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
