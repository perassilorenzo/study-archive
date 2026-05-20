using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0317_es29pag116
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
            string nomeAnimale = textBox1.Text;

            if (nomeAnimale == "")
            {
                MessageBox.Show("Inserisci un valore valido", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nomeSpecie = "";

            for (int i = 0; i < animali.Length; i++)
            {
                if (animali[i] == nomeAnimale)
                {
                    nomeSpecie = specie[i];
                    break;
                }
            }

            for (int i = 0;i < animali.Length; i++)
            {
                if (specie[i] == nomeSpecie)
                {
                    MessageBox.Show(animali[i]);
                }
            }
        }
    }
}
