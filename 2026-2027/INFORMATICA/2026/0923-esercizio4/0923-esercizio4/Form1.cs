using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0923_esercizio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Struct Studente
        /// </summary>
        public struct Studente
        {
            // definisco le caratteristiche
            public int NumeroMatricola;
            public string Cognome;
            public string Nome;
            public DateTime DataNascita;
            public string Classe;
            public string Specializzazione;

            // costruttore
            public Studente(int nMatricola, string cognome, string nome, DateTime dataNascita, string classe, string specializzazione)
            {
                NumeroMatricola = nMatricola;
                Cognome = cognome;
                Nome = nome;
                DataNascita = dataNascita;
                Classe = classe;
                Specializzazione = specializzazione;
            }

            // pulizia dati studente
            public void Clear()
            {
                NumeroMatricola = 0;
                Cognome = string.Empty;
                Nome = string.Empty;
                DataNascita = DateTime.MinValue;
                Classe = string.Empty;
                Specializzazione= string.Empty;
            }

            // calcolo eta studente
            public int CalcoloEta()
            {
                int eta;

                eta = DateTime.Now.Year - DataNascita.Year;

                return eta;
            }

            // dati studente 
            public string GetStudente()
            {
                return $"N° Matricola: {NumeroMatricola}\n" +
                    $"Cognome: {Cognome}\n" +
                    $"Nome: {Nome}\n" +
                    $"Data di nascita: {DataNascita.ToString(@"dd\/MM\/yyyy")}\n" +
                    $"Classe: {Classe}\n" +
                    $"Specializzazione: {Specializzazione}";
            }

            // dati studente scrittura su file
            public override string ToString()
            {
                return NumeroMatricola.ToString() + ";" +
                    Cognome + ";" +
                    Nome + ";" +
                    DataNascita.Day.ToString() + "/" +
                    DataNascita.Month.ToString() + "/" +
                    DataNascita.Year.ToString() + ";" +
                    Classe + ";" +
                    Specializzazione + ";";
            }

        }

        public Studente[] classe4A = new Studente[30];
        public string[] int_Studente = { "N. Matricola", "Cognome", "Nome", "Data di Nascita", "Classe", "Specializzazione"};

        private void Form1_Load(object sender, EventArgs e)
        {
            grbStudente.Enabled = false;
            dtpDataNascita.Value = DateTime.Now;

            // carico combo specializzazioni
            cmbSpecializzazione.Items.Add("INF");
            cmbSpecializzazione.Items.Add("MEC");
            cmbSpecializzazione.Items.Add("LSSA");
            cmbSpecializzazione.Items.Add("TUR");
            cmbSpecializzazione.Items.Add("ECO");

            cmbClasse.SelectedIndex = -1;
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void inserisciStudenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grbStudente.Enabled = true;
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            int i;

            // controllo dati input
            if (!chkDatiStudente())
            {
                if ((i = posizioneStudente()) == -1)
                {
                    MessageBox.Show("La Classe è completa");
                    return;
                }
                
                classe4A[i].NumeroMatricola = Convert.ToInt32(nudMatricola.Value);
                classe4A[i].Cognome = txtCognome.Text;
                classe4A[i].Nome = txtNome.Text;
                classe4A[i].DataNascita = dtpDataNascita.Value;
                classe4A[i].Classe = cmbClasse.Text;
                classe4A[i].Specializzazione = cmbSpecializzazione.Text;

                MessageBox.Show("Studente inserito con successo");
            }
        }

        

        // ==================================

        private bool chkDatiStudente()
        {
            if (chkNMatricola())
            {
                // numero matricola
                nudMatricola.Focus();
                MessageBox.Show("N° Matricola già presente");
                return true;
            }
            else if (txtCognome.Text == string.Empty)
            {
                // cognome
                txtCognome.Focus();
                MessageBox.Show("Cognome non inserito");
                return true;
            }
            else if (txtNome.Text == string.Empty)
            {
                // nome
                txtNome.Focus();
                MessageBox.Show("Nome non inserito");
                return true;
            }
            else if (cmbClasse.Text == string.Empty)
            {
                cmbClasse.Focus();
                MessageBox.Show("Classe non selezionata");
                return true;
            }
            else if (cmbSpecializzazione.Text == string.Empty)
            {
                cmbSpecializzazione.Focus();
                MessageBox.Show("Specializzazione non selezionata");
                return true;
            }

            return false;
        }

        private bool chkNMatricola()
        {

            for(int i = 0; i < classe4A.Length; i++)
            {
                if (classe4A[i].NumeroMatricola == Convert.ToInt32(nudMatricola.Value))
                    return true;
            }

            return false;
        }
        
        private int posizioneStudente()
        {
            for (int i = 0; i < classe4A.Length; i++)
                if (classe4A[i].NumeroMatricola == 0)
                    return i;

            return -1;
        }
    }
}