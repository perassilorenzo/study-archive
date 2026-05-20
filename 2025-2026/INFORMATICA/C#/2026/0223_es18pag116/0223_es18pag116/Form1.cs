using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0223_es18pag116
{
    public partial class Form1 : Form
    {
        string[] cantanti = { "Laura Pausini", "Laura Pausini", "Tiziano Ferro", "Tiziano Ferro", "Eros Ramazzotti", "Eros Ramazzotti", "Giorgia", "Giorgia", "Vasco Rossi", "Vasco Rossi" };
        string[] canzoni = { "La solitudine", "Strani amori", "Sere nere", "Non me lo so spiegare", "Più bella cosa", "Un'emozione per sempre", "Come saprei", "Gocce di memoria", "Albachiara", "Sally" };
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.AddRange(cantanti);
            listBox2.Items.AddRange(canzoni);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();

            if (textBox1.Text == null || textBox1.Text.Length < 4)
            {
                listBox3.Items.Add($"Nome del cantante non valido");
            }
            else
            {
                string cantante = textBox1.Text;

                bool trovato = false;
                int i = 0;
                while (i < cantanti.Length && cantanti[i].CompareTo(cantante) < 0)
                {
                    i++;
                }

                while (i < cantanti.Length && cantanti[i] == cantante)
                {
                    listBox3.Items.Add(canzoni[i]);
                    i++;
                    trovato = true;
                }

                if (!trovato)
                {
                    listBox3.Items.Add($"Non ci sono canzoni del cantante {cantante}");
                }
            }
        }
    }
}
