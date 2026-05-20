using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0223_es17pag116
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

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox3.Items.Clear();

            if (listBox1.SelectedItem == null)
            {
                listBox3.Items.Add("Errore");
                return;
            }

            string cantante = listBox1.Text;

            for (int i = 0; i < cantanti.Length; i++)
            {
                if (cantanti[i] == cantante)
                {
                    listBox3.Items.Add(canzoni[i]);
                }
            }

        }
    }
}
