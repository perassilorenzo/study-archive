using System;
using System.Windows.Forms;

namespace _0504_es3pag173
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
        }

        private void btnOrdina_Click(object sender, EventArgs e)
        {
            OrdinaPerAutore();
            MostraLibri();
        }

        private void OrdinaPerAutore()
        {
            for (int i = 0; i < libri.Length - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < libri.Length; j++)
                {
                    if (string.Compare(libri[j].autore, libri[min].autore, true) < 0)
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    Libro temp = libri[i];
                    libri[i] = libri[min];
                    libri[min] = temp;
                }
            }
        }

        private void MostraLibri()
        {
            lstLibri.Items.Clear();

            for (int i = 0; i < libri.Length; i++)
            {
                lstLibri.Items.Add(libri[i].autore + " - " + libri[i].titolo);
            }
        }
    }
}