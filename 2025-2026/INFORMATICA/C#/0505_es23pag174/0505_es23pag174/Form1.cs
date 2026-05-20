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

namespace _0505_es23pag174
{
    struct Calciatore
    {
        public string codiceGiocatore { get; set; }
        public string Cognome { get; set; }
        public string Nome { get; set; }
        public string Squadra { get; set; }
        public string Ruolo { get; set; }
        public int NGoal { get; set; }

        public override string ToString()
        {
            return $"{codiceGiocatore} {Cognome} {Nome} {Squadra} {Ruolo} {NGoal}";
        }

    }
    public partial class Form1 : Form
    {
        Calciatore[] calciatoriCaricati = new Calciatore[100];
        Calciatore[] calciatoriCercati = new Calciatore[100];

        public Form1()
        {
            InitializeComponent();

            int i = 0;
            bool errore = false;
            using (StreamReader sr = new StreamReader("calciatori.dat"))
            {
                string riga;
                string[] dati = new string[6];
                while ((riga = sr.ReadLine()) != null && !errore)
                {
                    dati = riga.Split('|');

                    if (dati.Length != 6)
                    {
                        MessageBox.Show("Il file è corrotto","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

                        errore = true;
                        return;
                    }

                    calciatoriCaricati[i].codiceGiocatore = dati[0];
                    calciatoriCaricati[i].Cognome = dati[1];
                    calciatoriCaricati[i].Nome = dati[2];
                    calciatoriCaricati[i].Squadra = dati[3];
                    calciatoriCaricati[i].Ruolo = dati[4];
                    calciatoriCaricati[i].NGoal = int.Parse(dati[5]);
                    lstDatiCaricati.Items.Add(calciatoriCaricati[i]);
                    i++;
                }
                Array.Resize(ref calciatoriCaricati, i);
            }
        }
        private void btnCerca_Click(object sender, EventArgs e)
        {
            string ruolo = txtCerca.Text.Trim();
            int cont = 0;

            Calciatore[] temp = new Calciatore[calciatoriCaricati.Length];

            for (int i = 0; i < calciatoriCaricati.Length; i++)
                if (calciatoriCaricati[i].Ruolo == ruolo)
                {
                    temp[cont] = calciatoriCaricati[i];
                    cont++;
                }
            

            Array.Resize(ref temp, cont);
            Array.Sort(temp, (a, b) => string.Compare(a.Ruolo, b.Ruolo));

            MessageBox.Show($"Giocatori trovati: {cont}");
            dvgCalciatori.DataSource = temp;
        }
    }
}
