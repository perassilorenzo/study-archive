using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _0923_esercizio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /**********************/
        /* Struttura Studente */
        /**********************/

        public struct studente
        {

            // Definisco le Caratteristiche
            public int nMatr;
            public string cognome;
            public string nome;
            public DateTime dataN;
            public string classe; // 3A - 4B - 5C
            public string spec; // INF - MEC - ELT

            // Costruttore
            public studente(int nM,
                             string co,
                             string no,
                             DateTime dN,
                             string cl,
                             string sp)
            {
                nMatr = nM;
                cognome = co;
                nome = no;
                dataN = dN;
                classe = cl;
                spec = sp;
            }

            // Pulizia Dati Studente
            public void clear()
            {
                nMatr = 0;
                cognome = string.Empty;
                nome = string.Empty;
                dataN = DateTime.MinValue;
                classe = string.Empty;
                spec = string.Empty;
            }

            // Calcolo Età Studente
            public int calcolaEta()
            {
                int eta;

                eta = DateTime.Now.Year - dataN.Year;

                return eta;
            }

            // Dati dello Studente
            public string getStudente()
            {
                return $"N° Matricola = {nMatr} " +
                        $" | Cognome = {cognome}" +
                        $" | Nome = {nome}" +
                        $" | Data Nascita = {dataN.ToString(@"dd\/MM\/yyyy")}" +
                        $" | Classe = {classe}" +
                        $" | Specializzazione = {spec}";
            }

            // Dati Studente per Salvare su File
            public override string ToString()
            {
                return nMatr.ToString() + ";" +
                       cognome + ";" +
                       nome + ";" +
                         dataN.Day.ToString() + "/" +
                         dataN.Month.ToString() + "/" +
                         dataN.Year.ToString() + ";" +
                       classe + ";" +
                       spec + ";";

            }

        }

        public studente[] classe4A = new studente[30];
        public string[] int_Studente = { "N.MATRICOLA", "COGNOME", "NOME", "DATA NASCITA", "CLASSE", "SPECIALIZZAZIONE" };
        public int posStudente = -1;

        private void Form1_Load(object sender, EventArgs e)
        {
            grbStudente.Enabled = false;
            grbClasse.Enabled = false;
            grbRicerca.Enabled = false;
            grpDatiStudente.Enabled = false;

            dtpDataNascita.Value = DateTime.Now;

            // Carico Combo Specializzazioni
            cmbSpecializzazione.Items.Add("INF");
            cmbSpecializzazione.Items.Add("MEC");
            cmbSpecializzazione.Items.Add("ELT");
            cmbSpecializzazione.Items.Add("LSSA");
            cmbSpecializzazione.Items.Add("ECO");
            cmbSpecializzazione.Items.Add("TUR");

            cmbClasse.SelectedIndex = -1;
        }


        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void inserisciStudenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grbStudente.Enabled = true;
            grbClasse.Enabled = false;
            grbRicerca.Enabled = false;
            grpDatiStudente.Enabled = false;
        }

        private void salvaSuFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (verificaStudenti())
            {

                this.Cursor = Cursors.WaitCursor;

                // Imposto il File di Salvataggio
                // TextWriter fClasse = new StreamWriter("Classe4A.txt");

                /*
                StreamWriter sw = new StreamWriter("Classe4A.txt");
                for (int I = 0; I < classe4A.Length; I++)
                    if (classe4A[I].nMatr != 0)
                        sw.WriteLine(classe4A[I].ToString());
                sw.Close();
                */

                using (StreamWriter sw = new StreamWriter("Classe4A.txt"))
                {
                    for (int I = 0; I < classe4A.Length; I++)
                        if (classe4A[I].nMatr != 0)
                            sw.WriteLine(classe4A[I].ToString());
                }

                this.Cursor = Cursors.Default;
                MessageBox.Show("Classe salvata con successo su File !!!");

            }
            else
                MessageBox.Show("La Classe non contiene Studenti !!!");

        }

        private void caricaDaFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool leggiDati = false;
            string s;
            string[] vDati = new string[6];
            int pos = -1;

            if (verificaStudenti())
            {
                if (MessageBox.Show("La Classe contiene già degli Studenti, sovrascriverli ?",
                                    "Caricameno Studenti da File",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    inizializzaClasse();
                    leggiDati = true;
                }
            }
            else
            {
                leggiDati = true;
            }

            if (leggiDati)
            {
                using (StreamReader sr = new StreamReader("Classe4A.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        s = sr.ReadLine();
                        vDati = s.Split(';');
                        pos++;
                        classe4A[pos].nMatr = Convert.ToInt32(vDati[0]);
                        classe4A[pos].cognome = vDati[1];
                        classe4A[pos].nome = vDati[2];
                        classe4A[pos].dataN = Convert.ToDateTime(vDati[3]);
                        classe4A[pos].classe = vDati[4];
                        classe4A[pos].spec = vDati[5];
                    }
                }
                MessageBox.Show("La classe è stata recuperata dal File con successo");
                visualizzaClasse();
            }
        }

        private void visualizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            visualizzaClasse();
        }
        private void ricercaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grbRicerca.Enabled = true;
            grpDatiStudente.Enabled = false;

            clearInserimento();
            grbStudente.Enabled = false;
            grbClasse.Enabled = false;
            btnElimina.Enabled = true;
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            studente stuAus = new studente();
            int pos;

            // Controllo Dati Input
            if (chkDatiStudente())
            {
                pos = posizioneStudente();

                if (pos != -1)
                {
                    stuAus.nMatr = Convert.ToInt32(nudMatricola.Value);
                    stuAus.cognome = txtCognome.Text;
                    stuAus.nome = txtNome.Text;
                    stuAus.dataN = dtpDataNascita.Value;
                    stuAus.classe = cmbClasse.Text;
                    stuAus.spec = cmbSpecializzazione.Text;
                    classe4A[pos] = stuAus;
                    MessageBox.Show("Studente inserito con successo !!!");
                }
                else
                    MessageBox.Show("La Classe è comleta !!!");

                clearInserimento();
                grbStudente.Enabled = false;

            }


        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            clearInserimento();
            grbStudente.Enabled = false;
        }
        private void brnRicerca_Click(object sender, EventArgs e)
        {
            string tipoRicerca = string.Empty;
            if (txtRicCognome.Text != string.Empty && txtRicNome.Text != string.Empty)
            {
                tipoRicerca = "CognomeNome";
            }
            else
            {
                tipoRicerca = "Matricola";
            }
            bool trovato = false;
            //Ricerca eventuale studente
            for (int i = 0; i < classe4A.Length; i++)
            {
                //Ricerca per matricola
                if (tipoRicerca == "Matricola")
                {
                    if (classe4A[i].nMatr == nudRicMatricola.Value)
                    {
                        trovato = true;
                        visDatiStudente(i);
                        break;
                    }
                }
                else
                {
                    if (string.Compare(classe4A[i].cognome, txtRicCognome.Text) == 0 &&
                        string.Compare(classe4A[i].nome, txtRicNome.Text) == 0)
                    {
                        trovato = true;
                        visDatiStudente(i);
                        break;
                    }
                }
            }

            if (!trovato)
            {
                MessageBox.Show($"Lo studente non è stato trovato ");
            }
        }

        private void eliminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grbRicerca.Enabled = true;

            clearInserimento();
            grbStudente.Enabled = false;
            grbRicerca.Enabled = false;

            dtpDataNascita.Value = DateTime.Now;
        }
        private void ordinaAZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ordinaOk = false;
            if (verificaStudenti())
            {
                for (int i = 0; i < classe4A.Length - 1; i++)
                {
                    if (classe4A[i].nMatr != 0)
                    {
                        for (int j = i + 1; j < classe4A.Length; j++)
                        {
                            if (string.Compare(classe4A[i].cognome, classe4A[j].cognome) > 0)
                            {
                                studente stuAus = classe4A[i];
                                classe4A[i] = classe4A[j];
                                classe4A[j] = stuAus;
                                ordinaOk = true;
                            }
                            else if (string.Compare(classe4A[i].cognome, classe4A[j].cognome) == 0)
                            {
                                if (string.Compare(classe4A[i].nome, classe4A[j].nome) > 0)
                                {
                                    studente stuAus = classe4A[i];
                                    classe4A[i] = classe4A[j];
                                    classe4A[j] = stuAus;
                                    ordinaOk = true;
                                }
                            }
                        }
                    }
                }
                if (ordinaOk)
                {
                    MessageBox.Show("La classe è stata ordinata con successo");
                    visualizzaClasse();
                }
                else
                {
                    MessageBox.Show("La classe è gia ordinata");
                }
            }
            else
            {
                MessageBox.Show("La classe non ha studenti");
            }
        }


        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Eliminare lo Studente selezionato ? ", "Cancellazione Studente",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                classe4A[posStudente].clear();
                MessageBox.Show("Studente Cancellato con successo");
                clearDatiRicerca();
                clearDatiStudenti();
                visualizzaClasse();
            }
        }
        // =====================================================

        public bool chkDatiStudente()
        {
            bool errore = false;

            if (chkNMatricola())
            {
                // Numero Matricola
                nudMatricola.Focus();
                MessageBox.Show("N° Matricola già presente nella Classe");
                errore = true;
            }
            else if (txtCognome.Text == string.Empty)
            {
                // Cognome
                txtCognome.Focus();
                MessageBox.Show("Cognome non inserito");
                errore = true;
            }
            else if (txtNome.Text == string.Empty)
            {
                // Nome
                txtNome.Focus();
                MessageBox.Show("Nome non inserito");
                errore = true;
            }
            else if (cmbClasse.Text == string.Empty)
            {
                // Classe
                cmbClasse.Focus();
                MessageBox.Show("Classe non selezionata");
                errore = true;
            }
            else if (cmbSpecializzazione.Text == string.Empty)
            {
                // Specializzazione
                cmbSpecializzazione.Focus();
                MessageBox.Show("Specializzazione non selezionata");
                errore = true;
            }

            return !errore;
        }

        public bool chkNMatricola()
        {
            bool errore = false;

            for (int I = 0; I < classe4A.Length; I++)
            {
                if (classe4A[I].nMatr == Convert.ToInt32(nudMatricola.Value))
                {
                    errore = true;
                    break;
                }
            }

            return errore;
        }

        public int posizioneStudente()
        {
            int pos = -1;

            for (int I = 0; I < classe4A.Length; I++)
                if (classe4A[I].nMatr == 0)
                {
                    pos = I;
                    break;
                }

            return pos;
        }

        public void clearInserimento()
        {
            nudMatricola.Value = 1;
            txtCognome.Text = string.Empty;
            txtNome.Text = string.Empty;
            dtpDataNascita.Value = DateTime.Now;
            cmbClasse.SelectedIndex = -1;
            cmbSpecializzazione.SelectedIndex = -1;
        }

        public bool verificaStudenti()
        {
            //int cont = 0;
            // int I =  0;

            for (int I = 0; I < classe4A.Length; I++)
                if (classe4A[I].nMatr != 0)
                    return true;
            //{
            //    cont++;
            //    break;
            //}

            /*
            while (classe4A[I].nMatr == 0 && I < classe4A.Length)
                I++;

            if (classe4A[I].nMatr != 0)
                return 1;
            */

            return false;
        }

        public void inizializzaClasse()
        {
            for (int I = 0; I < classe4A.Length; I++)
                classe4A[I].clear();
        }
        private void visualizzaClasse()
        {
            grbClasse.Enabled = true;

            clearInserimento();
            grbStudente.Enabled = false;
            grbRicerca.Enabled = false;
            grpDatiStudente.Enabled = false;

            //Impostazione della DGV: pulisce, rende fisse le colonne
            dgvClasse.Rows.Clear();
            dgvClasse.ReadOnly = true;
            dgvClasse.ColumnCount = 6;
            dgvClasse.RowHeadersVisible = false;
            dgvClasse.AllowUserToAddRows = false;
            dgvClasse.AllowUserToResizeColumns = false;
            dgvClasse.AllowUserToResizeRows = false;

            dgvClasse.ClearSelection();
            if (verificaStudenti())
            {
                //Intestazione DGV
                for (int i = 0; i < int_Studente.Length; i++)
                {
                    dgvClasse.Columns[i].HeaderText = int_Studente[i];
                }
                //Carico gli studenti
                for (int i = 0; i < classe4A.Length; i++)
                {
                    if (classe4A[i].nMatr != 0)
                    {
                        dgvClasse.Rows.Add(
                            classe4A[i].nMatr.ToString(),
                            classe4A[i].cognome,
                            classe4A[i].nome,
                            classe4A[i].dataN.ToString(@"dd\/MM\/yyyy"),
                            classe4A[i].classe,
                            classe4A[i].spec
                        );
                    }
                }
                dgvClasse.AutoResizeColumns();
            }
        }

        public void clearDatiRicerca()
        {
            nudRicMatricola.Value = 1;
            txtRicCognome.Text = string.Empty;
            txtRicNome.Text = string.Empty;
        }
        public void clearDatiStudenti()
        {
            lblMatricola.Text = string.Empty;
            lblCognome.Text = string.Empty;
            lblNome.Text = string.Empty;
            lblDataNascita.Text = string.Empty;
            lblClasse.Text = string.Empty;
            lblSpec.Text = string.Empty;
            btnElimina.Enabled = false;
        }
        public void visDatiStudente(int i)
        {
            grpDatiStudente.Enabled = true;

            lblMatricola.Text = classe4A[i].nMatr.ToString();
            lblCognome.Text = classe4A[i].cognome;
            lblNome.Text = classe4A[i].nome;
            lblDataNascita.Text = classe4A[i].dataN.ToString(@"dd\/MM\/yyyy");
            lblClasse.Text = classe4A[i].classe;
            lblSpec.Text = classe4A[i].spec;

            posStudente = i;
        }

    }
}
