using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0223_es19pag116
{
    public partial class Form1 : Form
    {
        string[] cantanti = { "Laura Pausini", "Laura Pausini", "Tiziano Ferro", "Tiziano Ferro", "Eros Ramazzotti", "Eros Ramazzotti", "Giorgia", "Giorgia", "Vasco Rossi", "Vasco Rossi" };
        string[] canzoni = { "La solitudine", "Strani amori", "Sere nere", "Non me lo so spiegare", "Più bella cosa", "Un'emozione per sempre", "Come saprei", "Gocce di memoria", "Albachiara", "Sally" };
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.AddRange(canzoni);
            listBox2.Items.AddRange(cantanti);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox1.Text.Length > 2)
            {
                int count = 0;

                for (int i = 0; i < cantanti.Length; i++)
                {
                    if (textBox1.Text.CompareTo(cantanti[i]) == 0)
                    {
                        count++;
                    }
                }

                listBox3.Items.Add($"Sono presenti {count} canzoni di {textBox1.Text}");
            }
            else
            {
                listBox3.Items.Add("Devi inserire almeno 3 caratteri");
            }
        }
    }
}
