using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0330_pag163
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

            Studente[] studenti1 = new Studente[10];
            string[] cognomi1 = { "Rossi", "Bianchi", "Verdi", "Russo", "Ferrari", "Esposito", "Romano", "Colombo", "Ricci", "Marino" };
            string[] nomi1 = { "Luca", "Marco", "Giulia", "Francesca", "Alessandro", "Sara", "Matteo", "Chiara", "Davide", "Elena" };
            string[] dateNascita1 = { "12/03/2005", "25/07/2006", "08/11/2005", "19/01/2006", "30/09/2005", "14/02/2006", "06/06/2005", "21/12/2006", "03/04/2005", "17/08/2006" };
            string[] classi1 = { "3A", "3B", "3C", "4A", "4B", "4C", "5A", "5B", "5C", "2A" };

            for (int j = 0; j < 10; j++)
            {
                studenti1[j].matricola = j;
                studenti1[j].cognome = cognomi1[j];
                studenti1[j].nome = nomi1[j];
                studenti1[j].dataNascita = dateNascita1[j];
                studenti1[j].classe = classi1[j];
            }

            Studente[] studenti2 = new Studente[20];
            string[] cognomi2 = { "Rossi", "Bianchi", "Verdi", "Russo", "Ferrari", "Esposito", "Romano", "Colombo", "Ricci", "Marino", "Greco", "Bruno", "Gallo", "Conti", "De Luca", "Mancini", "Costa", "Giordano", "Rizzo", "Lombardi" };
            string[] nomi2 = { "Luca", "Marco", "Giulia", "Francesca", "Alessandro", "Sara", "Matteo", "Chiara", "Davide", "Elena", "Andrea", "Martina", "Simone", "Valentina", "Stefano", "Giorgia", "Antonio", "Federica", "Riccardo", "Laura" };
            string[] dateNascita2 = { "12/03/2005", "25/07/2006", "08/11/2005", "19/01/2006", "30/09/2005", "14/02/2006", "06/06/2005", "21/12/2006", "03/04/2005", "17/08/2006", "09/10/2005", "28/05/2006", "11/01/2005", "22/07/2006", "15/03/2005", "04/11/2006", "18/02/2005", "27/09/2006", "05/06/2005", "13/12/2006" };
            string[] classi2 = { "3A", "3B", "3C", "4A", "4B", "4C", "5A", "5B", "5C", "2A", "2B", "2C", "1A", "1B", "1C", "4D", "5D", "3D", "2D", "1D" };

            for (int i = 0; i < nomi2.Length; i++)
            {
                studenti2[i].matricola = i;
                studenti2[i].cognome = cognomi2[i];
                studenti2[i].nome = nomi2[i];
                studenti2[i].dataNascita = dateNascita2[i];
                studenti2[i].classe = classi2[i];
            }

            Studente[] studenti = new Studente[studenti1.Length + studenti2.Length];

            int i = 0;
            int j = 0;

            for (int k = 0; k <(10+20 - 1); k++)
            {
                if (studenti1[i].matricola > studenti2[j].matricola)
                {
                    studenti[k] = studenti2[j];
                    j++;
                }
                else
                {
                    studenti[k] = studenti1[i];
                    i++;
                }
            }

            for (int ii = 0; i < 30; ii++)
            {
                listBox1.Items.Add($"{studenti[ii].matricola} - {studenti[ii].cognome} - {studenti[ii].nome} - {studenti[ii].dataNascita} - {studenti[ii].classe}");
            }

        }
    }
}
