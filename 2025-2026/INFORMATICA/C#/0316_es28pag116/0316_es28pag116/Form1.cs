namespace _0316_es28pag116
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
            string nomeSpecie = textBox1.Text;

            if (nomeSpecie == "")
            {
                MessageBox.Show("Inserisci un valore valido", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int count = 0;

            for (int i = 0; i < specie.Length; i++)
            {
                if (specie[i] == nomeSpecie) count++;
            }

            MessageBox.Show($"Il numero di animali con la specie {nomeSpecie} è {count}");
        }
    }
}
