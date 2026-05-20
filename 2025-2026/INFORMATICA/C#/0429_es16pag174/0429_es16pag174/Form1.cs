using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _65_Es16pag174
{
    struct Paziente
    {
        public string codicePaziente { get; set; }
        public string cognome { get; set; }
        public string nome { get; set; }
        public string citta { get; set; }
        public string reparto { get; set; }
        public string nLetto { get; set; }

        public override string ToString()
        {
            return codicePaziente + " " + cognome + " " + nome + " " + citta + " " +
                reparto + " " + nLetto;
        }
    }
    public partial class Form1 : Form
    {
        Paziente[] pazientiCaricati = new Paziente[100];

        public Form1()
        {
            InitializeComponent();

            using (StreamReader sr = new StreamReader("Pazienti.dat"))
            {
                bool errore = false;
                string riga;
                string[] dati = new string[6];
                int i = 0;
                while (((riga = sr.ReadLine()) != null) && !errore)
                {
                    dati = riga.Split('|');
                    if (dati.Length != 6)
                    {
                        MessageBox.Show("ERRORE!", "File corrotto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errore = true;
                    }
                    else
                    {
                        pazientiCaricati[i].codicePaziente = dati[0];
                        pazientiCaricati[i].cognome = dati[1];
                        pazientiCaricati[i].nome = dati[2];
                        pazientiCaricati[i].citta = dati[3];
                        pazientiCaricati[i].reparto = dati[4];
                        pazientiCaricati[i].nLetto = dati[5];
                        lstDatiCaricati.Items.Add(pazientiCaricati[i]);
                        i++;
                    }
                }
                Array.Resize(ref pazientiCaricati, i);
            }
            dgvDati.DataSource = pazientiCaricati;
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            Paziente[] pazientiCercati = new Paziente[100];
            string reparto = txtNomeReparto.Text;
            int j = 0;

            lstDatiRicerca.Items.Clear();
            for (int i = 0; i < pazientiCaricati.Length; i++)
            {
                if (pazientiCaricati[i].reparto == reparto)
                {
                    pazientiCercati[j].codicePaziente = pazientiCaricati[i].codicePaziente;
                    pazientiCercati[j].cognome = pazientiCaricati[i].cognome;
                    pazientiCercati[j].nome = pazientiCaricati[i].nome;
                    pazientiCercati[j].citta = pazientiCaricati[i].citta;
                    pazientiCercati[j].reparto = pazientiCaricati[i].reparto;
                    pazientiCercati[j].nLetto = pazientiCaricati[i].nLetto;
                    lstDatiRicerca.Items.Add(pazientiCercati[j]);
                }
            }
        }
    }
}