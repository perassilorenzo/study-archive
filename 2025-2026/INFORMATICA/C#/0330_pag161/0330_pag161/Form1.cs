using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0330_pag161
{
    public partial class Form1 : Form
    {
        struct Studente
        {
            public int matricola;
            public string cognome;
            public string nome;
            public string dataNascita;
            public string classe;
        }

        public Form1()
        {
            InitializeComponent();

            Studente[] studenti = new Studente[10];
            string[] cognomi = { "Rossi", "Bianchi", "Verdi", "Russo", "Ferrari", "Esposito", "Romano", "Colombo", "Ricci", "Marino" };
            string[] nomi = { "Luca", "Marco", "Giulia", "Francesca", "Alessandro", "Sara", "Matteo", "Chiara", "Davide", "Elena" };
            string[] dateNascita = { "12/03/2005", "25/07/2006", "08/11/2005", "19/01/2006", "30/09/2005", "14/02/2006", "06/06/2005", "21/12/2006", "03/04/2005", "17/08/2006" };
            string[] classi = { "3A", "3B", "3C", "4A", "4B", "4C", "5A", "5B", "5C", "2A" };

            for (int j = 0; j < 10; j++)
            {
                studenti[j].matricola = j;
                studenti[j].cognome = cognomi[j];
                studenti[j].nome = nomi[j];
                studenti[j].dataNascita = dateNascita[j];
                studenti[j].classe = classi[j];
            }

            string cognome = Interaction.InputBox("Inserisci il cognome da ricercare");
            bool trovato = false;

            for (int i = 0; i < 10; i++)
            {
                if (studenti[i].cognome == cognome)
                {
                    listBox1.Items.Add($"{studenti[i].nome} - {studenti[i].dataNascita} - {studenti[i].classe}");
                    trovato = true;
                }
            }

            if (!trovato) MessageBox.Show("Cognome non trovato");
        }
    }
}
