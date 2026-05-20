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

namespace _0504_es21pag174
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            string squadraDaCercare = txtSquadra.Text;

            lstGiocatori.Items.Clear();

            using (StreamReader sr = new StreamReader("calciatori.dat"))
            {
                string riga;

                while ((riga = sr.ReadLine()) != null)
                {
                    string[] campi = riga.Split('|');

                    string cognome = campi[1];
                    string nome = campi[2];
                    string squadra = campi[3];
                    string ruolo = campi[4];
                    string goal = campi[5];

                    if (squadra == squadraDaCercare)
                    {
                        lstGiocatori.Items.Add(
                            cognome + " " + nome + " - " + ruolo + " - Gol: " + goal
                        );
                    }
                }
            }

            lblRisultato.Text = "Giocatori trovati: " + lstGiocatori.Items.Count;
        }
    }
}