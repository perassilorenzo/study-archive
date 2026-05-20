using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0330_es1pag150
{
    public partial class Form1 : Form
    {
        string[] cognomi = { "Rossi", "Bianchi", "Verdi", "Russo", "Ferrari", "Esposito", "Romano", "Colombo", "Ricci", "Marino", "Greco", "Bruno", "Gallo", "Conti", "De Luca", "Mancini", "Costa", "Giordano", "Rizzo", "Lombardi" };
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int x;
            string input;

            do
            {
                input = Interaction.InputBox("Inserisci numero persone per gruppo (3-5):");
            }
            while (!int.TryParse(input, out x) || x < 3 || x > 5);

            for (int i = cognomi.Length - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);

                string temp = cognomi[i];
                cognomi[i] = cognomi[j];
                cognomi[j] = temp;
            }

            int gruppo = 1;
            listBox1.Items.Clear();

            for (int i = 0; i < cognomi.Length; i += x)
            {
                listBox1.Items.Add($"Gruppo {gruppo}");

                for (int j = i; j < i + x && j < cognomi.Length; j++)
                {
                    listBox1.Items.Add(cognomi[j]);
                }

                gruppo++;
            }
        }
    }
}
