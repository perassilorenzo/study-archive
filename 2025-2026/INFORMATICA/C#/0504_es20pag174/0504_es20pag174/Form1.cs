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

namespace _0504_es20pag174
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            string cittaDaCercare = txtCitta.Text;

            lstPazienti.Items.Clear();

            using (StreamReader sr = new StreamReader("pazienti.dat"))
            {
                string riga;
                bool trovato = false;

                while ((riga = sr.ReadLine()) != null)
                {
                    string[] campi = riga.Split('|');

                    string cognome = campi[1];
                    string nome = campi[2];
                    string citta = campi[3];
                    string reparto = campi[4];

                    if (citta == cittaDaCercare)
                    {
                        trovato = true;
                        lstPazienti.Items.Add(cognome + " " + nome + " - " + reparto);
                    }
                    else if (trovato)
                    {
                        break;
                    }
                }
            }

            lblRisultato.Text = "Pazienti di " + cittaDaCercare + ": " + lstPazienti.Items.Count;
        }
    }
}