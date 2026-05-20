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

namespace _0429_es18pag174
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
    struct Reparto
    {
        public string nomeReparto { get; set; }
        public int NumeroPazienti { get; set; }
    }
    public partial class Form1 : Form
    {
        Paziente[] pazientiCaricati = new Paziente[100];
        Reparto[] reparti = new Reparto[100];
        public Form1()
        {
            InitializeComponent();

            using (StreamReader sr = new StreamReader("pazienti.dat"))
            {
                bool errore = false;
                string riga;
                string[] dati = new string[6];
                int i = 0, nReparti = 0;
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
                        AggiugiPazienteReparto(dati[4], ref nReparti);
                        i++;
                    }
                }
                Array.Resize(ref pazientiCaricati, i);
                Array.Resize(ref reparti, nReparti);
            }
            dgvPazientiRicoverati.DataSource = pazientiCaricati;
            dgvPazientiPerReparto.DataSource = reparti;
        }

        private void AggiugiPazienteReparto(string reparto, ref int nReparti)
        {
            int pos = 0;
            if ((pos = CercaReparto(reparto)) != -1)
            {
                reparti[pos].NumeroPazienti++;
            }
            else
            {
                reparti[nReparti].nomeReparto = reparto;
                reparti[nReparti].NumeroPazienti = 1;
                nReparti++;
            }
        }

        private int CercaReparto(string reparto)
        {
            for (int i = 0; i < reparti.Length; i++)
            {
                if (reparti[i].nomeReparto == reparto)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}