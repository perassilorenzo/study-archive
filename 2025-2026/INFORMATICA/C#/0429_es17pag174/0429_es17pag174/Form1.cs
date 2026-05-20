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

namespace _0429_es17pag174
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConta_Click(object sender, EventArgs e)
        {
            string repartoDaCercare = txtReparto.Text;
            int conteggio = 0;

            using (StreamReader sr = new StreamReader("pazienti.dat"))
            {
                string riga;

                while ((riga = sr.ReadLine()) != null)
                {
                    string[] campi = riga.Split('|');
                    string reparto = campi[4];

                    if (reparto == repartoDaCercare)
                    {
                        conteggio++;
                    }
                    else if (conteggio > 0)
                    {
                        break;
                    }
                }
            }

            lblRisultato.Text = "Pazienti nel reparto " + repartoDaCercare + ": " + conteggio;
        }
    }
}
