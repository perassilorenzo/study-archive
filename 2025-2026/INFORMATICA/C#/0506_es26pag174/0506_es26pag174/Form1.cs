using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace _0506_es26pag174
{
    struct Professori
    {
        public string Codice { get; set; }
        public string Cognome { get; set; }
        public string Nome { get; set; }
        public string Materia { get; set; }
        public string Scuola { get; set; }
    }
    public partial class Form1 : Form
    {
        List<Professori> list = new List<Professori>();
        List<Professori> listCerca = new List<Professori>();
        public Form1()
        {
            InitializeComponent();
            LeggiFile("professori.dat");
            dataGridView1.DataSource = list;
        }

        private void LeggiFile(string v)
        {
            using (StreamReader sr = new StreamReader("professori.dat"))
            {
                string riga;

                while ((riga = sr.ReadLine()) != null)
                {
                    string[] dati = new string[5];
                    dati = riga.Split('|');

                    Professori p = new Professori();
                    p.Codice = dati[0];
                    p.Cognome = dati[1];
                    p.Nome = dati[2];
                    p.Materia = dati[3];
                    p.Scuola = dati[4];

                    list.Add(p);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string scuola = textBox1.Text.Trim();

            foreach (Professori p in list)
            {
                if (p.Scuola == scuola)
                {
                    listCerca.Add(p);
                }
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = listCerca;

            }
        }
    }
}
