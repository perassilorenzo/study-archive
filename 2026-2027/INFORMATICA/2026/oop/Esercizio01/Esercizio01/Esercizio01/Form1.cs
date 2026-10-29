using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreaVeicolo_Click(object sender, EventArgs e)
        {
            clsVeicoli veicolo = new clsVeicoli();
            clsVeicoli veicolo1 = new clsVeicoli();

            lstVeicolo.Items.Clear();

            // Imposto Primo Veicolo
            veicolo.Marca = "FIAT";
            veicolo.Modello = "Panda";
            veicolo.Colore = "GIALLO";
            veicolo.Cilindrata = 1200;
            veicolo.DataImmatricolazione = Convert.ToDateTime("18/03/2020");
            aggiungiVeicolo(veicolo);

            lstVeicolo.Items.Add("");

            veicolo1.Marca = "FERRARI";
            veicolo1.Modello = "360 Modena";
            veicolo1.Colore = "ROSSO";
            veicolo1.Cilindrata = 4500;
            veicolo1.DataImmatricolazione = Convert.ToDateTime("11/08/2024");
            aggiungiVeicolo(veicolo1);

        }

        private void aggiungiVeicolo(clsVeicoli veicolo)
        {

            int km = 0;
            double prezzo = 0.0;
            bool errore = false;

            lstVeicolo.Items.Add(veicolo.visualizzaVeicolo());
            lstVeicolo.Items.Add($"Età Veicolo: {veicolo.etaVeicolo()} anni");
            lstVeicolo.Items.Add($"Bollo Veicolo: {veicolo.calcolaBollo()} €");
            lstVeicolo.Items.Add($"Consumo Medio: {veicolo.CalcolaConsumoMedio()} Km con un litro");
            lstVeicolo.Items.Add($"Assicurazione: {veicolo.Assicurazione().ToString("f2")} €");

            if (txtKM.Text != string.Empty &&
                txtPrezzo.Text != string.Empty)
            {
                errore = false;
                try
                {
                    km = Convert.ToInt32(txtKM.Text);
                    prezzo = Convert.ToDouble(txtPrezzo.Text);
                }
                catch (Exception)
                {
                    txtPrezzo.Focus();
                    errore = true;
                }
                if (!errore)
                    lstVeicolo.Items.Add($"Costo Viaggio: {veicolo.CalcolaCostoViaggio(km, prezzo).ToString("f2")} €");
            }

        }

    }
}
