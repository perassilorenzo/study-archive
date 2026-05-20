using Microsoft.VisualBasic;
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

namespace _0415_pag169
{
    struct Libri
    {
        public string codiceLibro;
        public string titolo;
        public string autore;
        public string casaEditrice;
        public string genere;
        public string costo;

        public override string ToString()
        {
            return $"{codiceLibro}|{titolo}|{autore}|{casaEditrice}|{genere}|{costo}";
        }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            using (StreamWriter sw = new StreamWriter("Libri.dat"))
            {
                Libri libro = new Libri();
                string answer = "";

                do
                {
                    libro.codiceLibro = Interaction.InputBox("Inserisci il codice del libro");
                    libro.titolo = Interaction.InputBox("Inserisci il titolo");
                    libro.autore = Interaction.InputBox("Inserisci l'autore");
                    libro.casaEditrice = Interaction.InputBox("Inserisci la casa editrice");
                    libro.genere = Interaction.InputBox("Inserisci il genere");
                    libro.costo = Interaction.InputBox("Inserisci il costo");

                    sw.WriteLine(libro.ToString());
                    answer = Interaction.InputBox("Vuoi inserire un altro libro? y/n");
                } while (answer.ToUpper() == "Y");

            }

            using (StreamReader sr = new StreamReader("Libri.dat"))
            {
                string riga = "";

                while ((riga = sr.ReadLine()) != null)
                {
                    string[] libro = new string[6];
                    libro = riga.Split('|');
                    string msg = "Dati del libro: \n";
                    foreach (string s in libro)
                    {
                        msg += s + "\n";
                    }
                    MessageBox.Show(msg);
                }
            }
        }
    }
}