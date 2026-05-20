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

namespace _0325_pag159
{
    struct Studente
    {
        public int matricola;
        public string cognome;
        public string nome;
        public string dataNascita;
        public string classe;
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int nStudenti;
            string n;

            do
            {
                n = Interaction.InputBox("Inserisci numero studenti: ");
            }
            while (!(int.TryParse(n, out nStudenti)) || nStudenti <= 0);

            Studente[] studenti = new Studente[nStudenti];

            for (int i = 0; i < nStudenti; i++)
            {
                if (i == 0)
                {
                    studenti[i].matricola = IntInput($"Inserisci la matrice dello studente n'{i + 1}");
                }
                else
                {
                    do
                    {
                        studenti[i].matricola = IntInput($"Inserisci la matrice dello studente n'{i + 1}");
                    } while (studenti[i].matricola < studenti[i - 1].matricola);
                }

                studenti[i].cognome = Interaction.InputBox($"Inserisci il cognome dello studente n'{i + 1}");
                studenti[i].nome = Interaction.InputBox($"Inserisci il nome dello studente n'{i + 1}");
                studenti[i].dataNascita = Interaction.InputBox($"Inserisci la data di nascita dello studente n'{i + 1}");
                studenti[i].classe = Interaction.InputBox($"Inserisci la classe dello studente n'{i + 1}");
            }

            for (int i = 0; i < nStudenti; i++)
            {
                listBox1.Items.Add($"{studenti[i].matricola} - {studenti[i].cognome} - {studenti[i].nome} - {studenti[i].dataNascita} - {studenti[i].classe}");
            }
            

        }


        private int IntInput(string v)
        {
            while (true)
            {
                int n;
                if (int.TryParse(Interaction.InputBox(v), out n)) return n;
                MessageBox.Show("Devi inserire un numero");
            }
        }
    }
}
