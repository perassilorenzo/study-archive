using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0525_es30pag174
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

        public Form1()
        {
            InitializeComponent();
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            LeggiFile(path + "\\Professori.dat");
            dgvElencoProf.DataSource = list;
        }

        private void LeggiFile(string nomeFile)
        {
            using (StreamReader sr = new StreamReader(nomeFile))
            {
                string riga;
                while ((riga = sr.ReadLine()) != null)
                {
                    string[] dati = riga.Split('|');
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

        private void btnConta_Click(object sender, EventArgs e)
        {
            string scuola = txtScuola.Text;
            string materia = txtMateria.Text;

            int count = 0;
            foreach (Professori p in list)
            {
                if (p.Scuola == scuola && p.Materia == materia)
                    count++;
            }

            lblRisultato.Text = $"Nella scuola '{scuola}' insegnano {count} professori la materia '{materia}'";
        }
    }
}