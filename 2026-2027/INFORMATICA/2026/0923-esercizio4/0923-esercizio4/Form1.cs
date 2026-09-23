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
                return NumeroMatricola.ToString() + ";";

                // DA CONCLUDERE
            }

        }



    }
}
