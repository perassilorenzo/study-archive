using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio01_Oggetti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreaVeicolo_Click(object sender, EventArgs e)
        {
            ClsVeicoli veicolo = new ClsVeicoli();
            veicolo.Marca = "FIAT";
            veicolo.Modello = "Panda";
            veicolo.Colore = "Giallo";
            veicolo.Cilindrata = 1200;
            veicolo.DataImmatricolazione = Convert.ToDateTime("18/03/2023");

            //MessageBox.Show(veicolo.visualizzaVeicolo());

            lstVeicolo.Items.Clear();
            lstVeicolo.Items.Add(veicolo.visualizzaVeicolo());
            lstVeicolo.Items.Add($"Eta veicolo: {veicolo.etaInfo()}");
            lstVeicolo.Items.Add($"Bollo veicolo: {veicolo.etaInfo()}");
        }
    }
}
