using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1104_gestione_libreria
{
    public partial class Form1 : Form
    {
        Libreria libreria = new Libreria();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            string titolo = txtTitolo.Text;
            string autore = txtAutore.Text;

            double prezzo;
            int numero;

            if (titolo == "" || autore == "")
            {
                MessageBox.Show("Inserisci titolo e autore");
                return;
            }

            if (!double.TryParse(txtPrezzo.Text, out prezzo))
            {
                MessageBox.Show("Inserisci un prezzo valido");
                return;
            }

            if (!int.TryParse(txtExtra.Text, out numero))
            {
                MessageBox.Show("Inserisci un numero valido");
                return;
            }

            Pubblicazione p;

            if (cmbTipo.Text == "Libro")
                p = new Libro(titolo, autore, prezzo, numero);
            else
                p = new Rivista(titolo, autore, prezzo, numero);

            libreria.AggiungiPubblicazione(p);

            lstCatalogo.Items.Add(p.Titolo + " - " + p.Autore);

            txtTitolo.Clear();
            txtAutore.Clear();
            txtPrezzo.Clear();
            txtExtra.Clear();

            MessageBox.Show("Pubblicazione aggiunta");
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            Pubblicazione p = libreria.CercaPerTitolo(txtRicerca.Text);

            if (p != null)
                MessageBox.Show(p.VisualizzaInfo(), "Pubblicazione trovata");
            else
                MessageBox.Show("Titolo non trovato");
        }

        private void btnPrezzoMedio_Click(object sender, EventArgs e)
        {
            double media = libreria.CalcolaPrezzoMedio();
            MessageBox.Show("Prezzo medio: " + media.ToString("0.00") + " euro");
        }
    }
}