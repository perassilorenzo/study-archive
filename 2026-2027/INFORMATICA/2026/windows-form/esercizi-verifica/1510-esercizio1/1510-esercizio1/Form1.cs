using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1510_esercizio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbIva.SelectedIndex = -1;
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            if (txtNomeProdotto.Text == "")
            {
                MessageBox.Show("Inserisci il nome del prodotto", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNomeProdotto.Focus();
                return;
            }
            if (cmbIva.Text == "")
            {
                MessageBox.Show("Inserisci l'IVA", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbIva.Focus();
                return;
            }

            string ivaText = cmbIva.Text;
            ivaText = ivaText.Replace("%", "");
            double iva = Convert.ToDouble(ivaText);

            double prezzo = (double)nudPrezzoIniziale.Value;
            double prezzoFinale = prezzo + (prezzo * iva / 100);

            lblRisultato.Text = $"{txtNomeProdotto.Text}: {prezzoFinale:F2} €";

        }

    }
}
