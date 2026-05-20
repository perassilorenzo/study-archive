using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0303_es25pag116
{
    public partial class Form1 : Form
    {
        string[] animali = { "Aquila", "Cane", "Cavallo", "Coccodrillo", "Delfino", "Elefante", "Farfalla", "Gatto", "Rana", "Squalo" };

        string[] specie = { "Uccello", "Mammifero", "Mammifero", "Rettile", "Mammifero", "Mammifero", "Insetto", "Mammifero", "Anfibio", "Pesce" };
       
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.AddRange(animali);
            listBox2.Items.AddRange(specie);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1 == null || textBox1.Text == "")
            {
                MessageBox.Show("Devi inserire un animale per cercarne la specie");
            }
            else
            {
                int index = JumpSearch(textBox1.Text, animali);

                if (index == -1)
                {
                    MessageBox.Show("Animale non presente");
                }
                else MessageBox.Show($"L'animale {animali[index]} appartiene alla specie {specie[index]}");
            }
        }

        private int JumpSearch(string text, string[] animali)
        {
            int step = (int)Math.Sqrt(animali.Length);
            int prev = 0;

            for (int i = 0; i < animali.Length; i += step)
            {
                if (text.CompareTo(animali[i]) <= 0)
                {
                    prev = Math.Max(0, i - step);

                    for (int j = prev; j <= i; j++)
                    {
                        if (animali[j] == text) return j;
                    }

                    return -1;
                }
            }

            return -1;
        }
    }
}
