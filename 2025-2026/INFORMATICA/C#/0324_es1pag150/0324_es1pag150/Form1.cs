using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0324_es1pag150
{
    public partial class Form1 : Form
    {
        string[] cognomi = { "Rossi", "Bianchi", "Ferrari", "Esposito", "Russo", "Conti", "Galli", "Costa", "De Luca", "Greco", "Mariani", "Moretti", "Rizzo", "Lombardi", "Barbieri", "Giordano", "Colombo", "Fontana", "Martini", "Serra" };
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            listBox1.Items.AddRange(cognomi);
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (textBox1.Text == "")
            {
                MessageBox.Show("Devi inserire un valore", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }

            int value = Convert.ToInt32(textBox1.Text);

            if (value < 3 || value > 5)
            {
                MessageBox.Show("Devi inserire un numero tra 3 e 5", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] turni = new string[cognomi.Length];

            for (int i = 0; i < turni.Length; i++)
                turni[i] = cognomi[i];
            
            for (int i = 0; i < turni.Length; i++)
            {
                int j = rnd.Next(i, cognomi.Length);

                string temp = turni[i];
                turni[i] = turni[j];
                turni[j] = temp;
            }

            int turn = 1;

            for (int i = 0; i < turni.Length; i++)
            {
                listBox2.Items.Add(turn);

                for (int j = 0; j < turni.Length; j++)
                    listBox2.Items.Add(turni[j]);

                turn++;
            }
        }
    }
}
