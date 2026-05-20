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

namespace _0420_es1pag173
{
    struct Libro
    {
        public string codiceLibro;
        public string titolo;
        public string autore;
        public string casaEditrice;
        public string prezzo;
    }

    public partial class Form1 : Form
    {
        Libro[] libri = new Libro[6];

        public Form1()
        {
            InitializeComponent();

            libri[0] = new Libro { codiceLibro = "B01", titolo = "Il Nome della Rosa", autore = "Eco", casaEditrice = "Bompiani", prezzo = "20.00" };
            libri[1] = new Libro { codiceLibro = "B02", titolo = "Fahrenheit 451", autore = "Bradbury", casaEditrice = "Mondadori", prezzo = "14.00" };
            libri[2] = new Libro { codiceLibro = "B03", titolo = "Dracula", autore = "Stoker", casaEditrice = "Feltrinelli", prezzo = "16.50" };
            libri[3] = new Libro { codiceLibro = "B04", titolo = "Frankenstein", autore = "Shelley", casaEditrice = "Einaudi", prezzo = "13.00" };
            libri[4] = new Libro { codiceLibro = "B05", titolo = "Il Codice Da Vinci", autore = "Brown", casaEditrice = "Mondadori", prezzo = "19.90" };
            libri[5] = new Libro { codiceLibro = "B06", titolo = "Sherlock Holmes", autore = "Doyle", casaEditrice = "Newton Compton", prezzo = "17.00" };

            string autore = Interaction.InputBox("Inserire l'autore da cercare: ");
            if (string.IsNullOrWhiteSpace(autore)) return;

            int count = 0;

            for (int i = 0; i < libri.Length; i++)
            {
                if (libri[i].autore.ToLower() == autore.ToLower())
                {
                    count++;
                }
            }

            MessageBox.Show($"{autore} ha pubblicato {count} libro/i");
        }
    }
}