namespace _20260520_es27pag174
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
        List<Professori> lstCerca = new List<Professori>();

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

        private void btnCerca_Click(object sender, EventArgs e)
        {
            string scuola = txtScuola.Text;

            lstCerca.Clear();
            foreach (Professori p in list)
            {
                if (p.Scuola == scuola)
                {
                    lstCerca.Add(p);
                }
            }
            dgvCercaProf.DataSource = null;
            dgvCercaProf.DataSource = lstCerca;
        }

        private void btnCercaInsegnantiPerMateria_Click(object sender, EventArgs e)
        {
            int count = 0;
            string materiaInput = txtMateria.Text;

            foreach (Professori p in list)
            {
                if (p.Materia == materiaInput)
                {
                    count++;
                }
            }

            MessageBox.Show($"Sono stati trovati: {count} professori che insegnano la materia {materiaInput}");
        }
    }
}