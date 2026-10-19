using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1510_esercizio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct Libro
        {
            public string codiceIdentificativo;
            public string titolo;
            public string autore;
            public DateTime annoPubblicazione;
            
            public Libro(string codice, string titolo, string autore, DateTime anno)
            {
                this.codiceIdentificativo = codice;
                this.titolo = titolo;
                this.autore = autore;
                this.annoPubblicazione = anno;
            } 
            public void clear()
            {
                codiceIdentificativo = string.Empty;
                titolo = string.Empty;
                autore = string.Empty;
                annoPubblicazione = DateTime.Now;
            }
            
            public override string ToString()
            {
                return $"{codiceIdentificativo};{titolo};{autore};{annoPubblicazione}";
            }
        }
            
        private Libro[] libri = new Libro[10];
        private int numeroLibri = 0;

        private void inserisciUnNuovoLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (numeroLibri >= libri.Length)
            {
                MessageBox.Show("Array al completo");
                return;
            }

            libri[numeroLibri] = new Libro(txtCodice.Text, txtTitolo.Text, txtAutore.Text, dptAnno.Value);
            numeroLibri++;
        }

        public void getLibro()
        {

        }


    }
}
