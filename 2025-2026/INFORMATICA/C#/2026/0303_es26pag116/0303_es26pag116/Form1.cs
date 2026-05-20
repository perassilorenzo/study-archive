using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0303_es26pag116
{
    public partial class Form1 : Form
    {
        string[] animali = {
"Aquila",
"Cane",
"Cavallo",
"Coccodrillo",
"Delfino",
"Elefante",
"Farfalla",
"Gatto",
"Rana",
"Squalo"
};

        string[] specie = {
"Uccello",
"Mammifero",
"Mammifero",
"Rettile",
"Mammifero",
"Mammifero",
"Insetto",
"Mammifero",
"Anfibio",
"Pesce"
};

        public Form1()
        {
            InitializeComponent();
            listBox1.Items.AddRange(animali);
            listBox2.Items.AddRange(specie);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrdinaPerSpecie(animali, specie);
            listBox1.Items.Clear();
            listBox1.Items.AddRange(animali);
            listBox2.Items.Clear();
            listBox2.Items.AddRange(specie);
        }

        private void OrdinaPerSpecie(string[] animali, string[] specie)
        {
            int posMin = 0;
            string aus = "";

            for (int i = 0; i < specie.Length; i++) {
                for (int j = i + 1; j < specie.Length; j++)
                {
                    if (specie[j].CompareTo(specie[posMin]) < 0)
                    {
                        posMin = j;
                    }
                }

                aus = specie[posMin];
                specie[posMin] = specie[i];
                specie[i] = aus;

                aus = animali[posMin];
                animali[posMin] = animali[i];
                animali[i] = aus;
        }
    }
}
