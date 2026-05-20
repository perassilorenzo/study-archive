using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0420_es30pag116
{
    public partial class Form1 : Form
    {
        string[] elencoAnimali = { "Cane", "Gatto", "Lupo", "Tigre", "Pitone", "Vipera", "Aquila", "Falco" };
        string[] elencoSpecie = { "Mammifero", "Mammifero", "Mammifero", "Mammifero", "Rettile", "Rettile", "Uccello", "Uccello" };

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string nomeAnimaleInserito = Interaction.InputBox("Inserisci l'animale da cercare:");

            if (string.IsNullOrWhiteSpace(nomeAnimaleInserito))
                return;

            int indiceAnimaleTrovato = -1;
            string specieAnimale = "";

            for (int i = 0; i < elencoAnimali.Length; i++)
            {
                if (elencoAnimali[i].ToLower() == nomeAnimaleInserito.ToLower())
                {
                    indiceAnimaleTrovato = i;
                    specieAnimale = elencoSpecie[i];
                    break;
                }
            }

            if (indiceAnimaleTrovato == -1)
            {
                MessageBox.Show("Animale non trovato.");
                return;
            }

            int numeroAnimaliStessaSpecie = 0;
            for (int i = 0; i < elencoSpecie.Length; i++)
            {
                if (elencoSpecie[i] == specieAnimale && i != indiceAnimaleTrovato)
                {
                    numeroAnimaliStessaSpecie++;
                }
            }

            string[] animaliStessaSpecie = new string[numeroAnimaliStessaSpecie];
            int indiceInserimento = 0;

            for (int i = 0; i < elencoSpecie.Length; i++)
            {
                if (elencoSpecie[i] == specieAnimale && i != indiceAnimaleTrovato)
                {
                    animaliStessaSpecie[indiceInserimento] = elencoAnimali[i];
                    indiceInserimento++;
                }
            }

            for (int i = 0; i < animaliStessaSpecie.Length - 1; i++)
            {
                for (int j = 0; j < animaliStessaSpecie.Length - 1 - i; j++)
                {
                    if (string.Compare(animaliStessaSpecie[j], animaliStessaSpecie[j + 1]) > 0)
                    {
                        string temp = animaliStessaSpecie[j];
                        animaliStessaSpecie[j] = animaliStessaSpecie[j + 1];
                        animaliStessaSpecie[j + 1] = temp;
                    }
                }
            }

            string messaggioOutput = $"Altri animali della specie {specieAnimale}:\n\n";

            if (animaliStessaSpecie.Length > 0)
            {
                for (int i = 0; i < animaliStessaSpecie.Length; i++)
                {
                    messaggioOutput += animaliStessaSpecie[i] + "\n";
                }
            }
            else
            {
                messaggioOutput = $"Nessun altro animale trovato per la specie {specieAnimale}.";
            }

            MessageBox.Show(messaggioOutput, "Risultato");
        }
    }
}