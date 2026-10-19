using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1510_esercizio3
{
    public partial class frmProfilo : Form
    {
        public frmProfilo()
        {
            InitializeComponent();
        }

        public static string nome;

        private void cambiaLabelInMarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblNome.Text = "Mario";
        }

        public void cambiaNome(string nuovoNome)
        {
            lblNome.Text = nuovoNome;
            nome = nuovoNome;
        }
    }
}
