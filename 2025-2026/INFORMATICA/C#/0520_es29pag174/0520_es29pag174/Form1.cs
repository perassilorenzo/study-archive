namespace _0520_es29pag174
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

        private void button1_Click(object sender, EventArgs e)
        {
            List<Professori> listCopy = new List<Professori>(list);
            string scuola = listCopy[0].Scuola;

            for (int i = 0; i < listCopy.Count; i++)
                for (int j = 0; j < listCopy.Count - 1 - i; j++)
                {
                    if (listCopy[j].Scuola.CompareTo(listCopy[j + 1].Scuola) > 0)
                    {
                        Professori buffer = listCopy[j];
                        listCopy[j] = listCopy[j + 1];
                        listCopy[j + 1] = buffer;
                    }
                }

            int[] count = new int[listCopy.Count];
            List<string> nomiScuole = new List<string>();
            nomiScuole.Add(scuola);
            int index = 0;

            for (int i = 0; i < listCopy.Count; i++)
            {
                if (scuola == listCopy[i].Scuola) count[index]++;
                else
                {
                    scuola = listCopy[i].Scuola;
                    index++;
                    nomiScuole.Add(scuola);
                    count[index]++;
                }
            }

            int max = 0;
            int pos = 0;

            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] > max)
                {
                    max = count[i];
                    pos = i;
                }
            }

            MessageBox.Show($"La scuola con più professori è '{nomiScuole[pos]}' con {max} docenti");
        }
    }
}