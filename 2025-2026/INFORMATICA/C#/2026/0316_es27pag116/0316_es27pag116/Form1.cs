namespace _0316_es27pag116
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
            AnimaleMax(animali, specie);
            listBox1.Items.Clear();
            listBox1.Items.AddRange(animali);
            listBox2.Items.Clear();
            listBox2.Items.AddRange(specie);
        }

        private void AnimaleMax(string[] animali, string[] specie)
        {
            string specieMax = specie[0];
            int maxCount = 1;

            int count = 1;

            for (int i = 1; i < specie.Length; i++)
            {
                if (specie[i] == specie[i - 1])
                {
                    count++;
                }
                else
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                        specieMax = specie[i - 1];
                    }
                    count = 1;
                }
            }

            MessageBox.Show($"La specie con più animali è {specieMax} con {maxCount} animali");
        }

    }
}