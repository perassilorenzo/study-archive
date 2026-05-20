using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0223_es22pag116
{
    public partial class Form1 : Form
    {
        string[] cantanti = { "Laura Pausini", "Laura Pausini", "Tiziano Ferro", "Tiziano Ferro", "Eros Ramazzotti", "Eros Ramazzotti", "Giorgia", "Giorgia", "Vasco Rossi", "Vasco Rossi" };
        string[] canzoni = { "La solitudine", "Strani amori", "Sere nere", "Non me lo so spiegare", "Più bella cosa", "Un'emozione per sempre", "Come saprei", "Gocce di memoria", "Albachiara", "Sally" };

        int[] point = new int[10];
        static Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            listBox1.Items.AddRange(cantanti);
            listBox2.Items.AddRange(canzoni);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            listBox4.Items.Clear();

            for (int i = 0; i < point.Length; i++)
            {
                point[i] = rnd.Next(1, 11);
                listBox3.Items.Add(point[i]);
            }

            int n = point.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (point[j] < point[j + 1])
                    {
                        int tPunteggio = point[j];
                        point[j] = point[j + 1];
                        point[j + 1] = tPunteggio;

                        string tCantanti = cantanti[j];
                        cantanti[j] = cantanti[j + 1];
                        cantanti[j + 1] = tCantanti;

                        string tCanzoni = canzoni[j];
                        canzoni[j] = canzoni[j + 1];
                        canzoni[j + 1] = tCanzoni;
                    }
                }
            }

            int[] pos = new int[n];
            int parade = 1;

            for (int i = 0; i < n; i++)
            {
                if (i > 0 && point[i] < point[i - 1])
                {
                    parade++;
                }
                pos[i] = parade;
            }

            for (int i = 0; i < n; i++)
            {
                point[i] = pos[i];
            }

            for (int i = 0; i < n; i++)
            {
                listBox4.Items.Add($"{point[i]}° - {canzoni[i]} - {cantanti[i]}");
            }

        }
    }
}
