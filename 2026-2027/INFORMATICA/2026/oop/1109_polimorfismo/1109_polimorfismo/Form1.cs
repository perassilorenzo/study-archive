using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1109_polimorfismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            List<Uccello> lista = new List<Uccello>();

            for (int i = 0; i < 3; i++)
            {
                int rnd = random.Next(3);
                if (rnd == 0)
                    lista.Add(new Oca());
                else if (rnd == 1)
                    lista.Add(new Corvo());
                else
                    lista.Add(new Uccello());
            }

            foreach (Uccello uccello in lista)
                uccello.Verso();
        }
    }
}
