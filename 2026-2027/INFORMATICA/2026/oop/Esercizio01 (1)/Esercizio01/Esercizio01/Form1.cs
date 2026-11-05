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
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Esercizio01
{
    public partial class Form1 : Form
    {
        // Lista AUTO-VEICOLI
        List<clsAuto> listaAuto = new List<clsAuto>();
        bool listaCarica = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpImmatricolazione.Value = DateTime.Now;
            cmbNPorte.SelectedIndex = 1;
            btnCreaXML.Enabled = false;
            btnCreaJSon.Enabled = false;
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

        private void btnAggiungiAuto_Click(object sender, EventArgs e)
        {
            clsAuto auto = new clsAuto();

            if (chkDatiInputAuto())
            {
                auto.Marca = txtMarca.Text;
                auto.Modello = txtModello.Text;
                auto.Colore = txtColore.Text;
                auto.Cilindrata = Convert.ToUInt16(nudCilindrata.Value);
                auto.NumPorte = Convert.ToUInt16(cmbNPorte.Text);
                auto.DataImmatricolazione = dtpImmatricolazione.Value;
                auto.Elettrica = chkElettrica.Checked;

                // Aggiungo la Nuovo Auto alla Lista
                listaAuto.Add(auto);
                listaCarica = true;

                // Gestisco la DGV Auto
                dgvAuto.DataSource = null;
                dgvAuto.DataSource = listaAuto;
                btnCreaXML.Enabled = true;
                btnCreaJSon.Enabled = true;

                // Pulizia Dati Input Auto
                clearDatiInputAuto();

            }
        }

        private void btnCreaXML_Click(object sender, EventArgs e)
        {
            XmlSerializer xmlSer = new XmlSerializer(listaAuto.GetType());
            using (StreamWriter sw = new StreamWriter("AutoVeicoli.xml"))
            {
                xmlSer.Serialize(sw, listaAuto);
            }
            MessageBox.Show("XML è stato creato con successo !!!");
        }

        private void btnCaricaXML_Click(object sender, EventArgs e)
        {
            if (listaCarica)
            {
                if (MessageBox.Show("La Lista AUTO è già carica, vuoi sovrascriverla ?",
                                    "Conferma ricarica Lista AUTO",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Ricarico la Lista AUTO
                    ricaricaListaAutoByXML();
                }
            }
            else
            {
                // Ricarico la Lista AUTO
                ricaricaListaAutoByXML();
            }

        }

        private void btnCreaJSon_Click(object sender, EventArgs e)
        {
            string JSonAuto = JsonConvert.SerializeObject(listaAuto, Formatting.Indented);
            File.WriteAllText("AutoVeicoli.json", JSonAuto);
            MessageBox.Show("Lista AUTO JSon creata con successo !!!");
        }

        private void dgvAuto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                clsAuto auto = new clsAuto();
                DataGridViewRow riga = dgvAuto.Rows[e.RowIndex];
                int km = 0;
                double prezzo = 0.0;
                bool errore = false;

                auto.Marca = riga.Cells["Marca"].Value.ToString();
                auto.Modello = riga.Cells["Modello"].Value.ToString();
                auto.Colore = riga.Cells["Colore"].Value.ToString();
                auto.Cilindrata = Convert.ToUInt16(riga.Cells["Cilindrata"].Value.ToString());
                auto.NumPorte = Convert.ToUInt16(riga.Cells["Cilindrata"].Value.ToString());
                auto.DataImmatricolazione = Convert.ToDateTime(riga.Cells["DataImmatricolazione"].Value.ToString());
                auto.Elettrica = Convert.ToBoolean(riga.Cells["Elettrica"].Value.ToString());

                lblEta.Text = $"{auto.DataImmatricolazione.Year} ({auto.etaVeicolo().ToString()})";
                lblBollo.Text = $"{auto.calcolaBollo().ToString("f2")} €";
                lblAssicurazione.Text = $"{auto.Assicurazione().ToString("f2")} €";

                lblConsumo.Text = string.Empty;
                if (txtKmAuto.Text != string.Empty &&
                    txtPrezzoAuto.Text != string.Empty)
                {

                    errore = false;
                    try
                    {
                        km = Convert.ToInt32(txtKmAuto.Text);
                        prezzo = Convert.ToDouble(txtPrezzoAuto.Text);
                    }
                    catch (Exception)
                    {
                        txtKmAuto.Focus();
                        errore = true;
                    }

                    if (!errore)
                        lblConsumo.Text = $"{auto.CalcolaCostoViaggio(km, prezzo).ToString("f2")} €";

                }
            }
        }

        // =============================================================================

        private bool chkDatiInputAuto()
        {

            bool datiOK = true; 

            if (txtMarca.Text == string.Empty)
            {
                MessageBox.Show("Non hai inserito la Marca");
                txtMarca.Focus();
                datiOK = false;
            }
            else if (txtModello.Text == string.Empty)
            {
                MessageBox.Show("Non hai inserito il Modello");
                txtModello.Focus();
                datiOK = false;
            }
            else if (txtColore.Text == string.Empty)
            {
                MessageBox.Show("Non hai inserito il Colore");
                txtColore.Focus();
                datiOK = false;
            }

            return datiOK;
        }


        private void clearDatiInputAuto()
        {
            txtMarca.Text = string.Empty;
            txtModello.Text = string.Empty;
            txtColore.Text = string.Empty;
            nudCilindrata.Value = nudCilindrata.Minimum;
            cmbNPorte.SelectedIndex = 1;
            dtpImmatricolazione.Value = DateTime.Now;
            chkElettrica.Checked = false;
        }

        private void ricaricaListaAutoByXML()
        {
            XmlSerializer xmlSer = new XmlSerializer(listaAuto.GetType());
            bool errore = false;

            dgvAuto.DataSource = null;

            try
            {
                using (StreamReader sr = new StreamReader("AutoVeicoli.xml"))
                {
                    listaAuto = (List<clsAuto>)xmlSer.Deserialize(sr);
                }

            }
            catch (Exception ex)
            {
                errore = true;
                MessageBox.Show($"ATTENZIONE : {ex.Message}");
            }

            if (!errore)
            {
                dgvAuto.DataSource = listaAuto;
                listaCarica = true;
                btnCreaXML.Enabled = true;
                btnCreaJSon.Enabled = true;
            }
        }




    }
}
