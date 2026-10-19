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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void impostaUtenteALorenzoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.utente = "Lorenzo";
        }

        private void apriFrmProfiloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfilo frmProfilo = new frmProfilo();
            frmProfilo.MdiParent = this;
            frmProfilo.Show();

            // si esegue quando il form si viene chiuso
            Label lblNomeUtente = new Label();
            lblNomeUtente.Location = new Point(20, 50);
            this.Controls.Add(lblNomeUtente);
            lblNomeUtente.Text = Program.utente;
        }
    }
}
