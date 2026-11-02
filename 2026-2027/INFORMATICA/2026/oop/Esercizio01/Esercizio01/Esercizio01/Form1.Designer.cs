namespace Esercizio01
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPrezzo = new System.Windows.Forms.TextBox();
            this.txtKM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstVeicolo = new System.Windows.Forms.ListBox();
            this.btnCreaVeicolo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAggiungiAuto = new System.Windows.Forms.Button();
            this.dtpImmatricolazione = new System.Windows.Forms.DateTimePicker();
            this.cmbNPorte = new System.Windows.Forms.ComboBox();
            this.nudCilindrata = new System.Windows.Forms.NumericUpDown();
            this.txtColore = new System.Windows.Forms.TextBox();
            this.txtModello = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.chkElettrica = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvAuto = new System.Windows.Forms.DataGridView();
            this.btnCreaXML = new System.Windows.Forms.Button();
            this.btnCaricaXML = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCilindrata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPrezzo);
            this.groupBox1.Controls.Add(this.txtKM);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lstVeicolo);
            this.groupBox1.Controls.Add(this.btnCreaVeicolo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestione VEICOLI";
            // 
            // txtPrezzo
            // 
            this.txtPrezzo.Location = new System.Drawing.Point(58, 100);
            this.txtPrezzo.Name = "txtPrezzo";
            this.txtPrezzo.Size = new System.Drawing.Size(94, 20);
            this.txtPrezzo.TabIndex = 5;
            // 
            // txtKM
            // 
            this.txtKM.Location = new System.Drawing.Point(58, 74);
            this.txtKM.Name = "txtKM";
            this.txtKM.Size = new System.Drawing.Size(94, 20);
            this.txtKM.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prezzo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Km.";
            // 
            // lstVeicolo
            // 
            this.lstVeicolo.FormattingEnabled = true;
            this.lstVeicolo.Location = new System.Drawing.Point(158, 36);
            this.lstVeicolo.Name = "lstVeicolo";
            this.lstVeicolo.ScrollAlwaysVisible = true;
            this.lstVeicolo.Size = new System.Drawing.Size(516, 212);
            this.lstVeicolo.TabIndex = 1;
            // 
            // btnCreaVeicolo
            // 
            this.btnCreaVeicolo.Location = new System.Drawing.Point(16, 36);
            this.btnCreaVeicolo.Name = "btnCreaVeicolo";
            this.btnCreaVeicolo.Size = new System.Drawing.Size(136, 23);
            this.btnCreaVeicolo.TabIndex = 0;
            this.btnCreaVeicolo.Text = "Crea VEICOLO";
            this.btnCreaVeicolo.UseVisualStyleBackColor = true;
            this.btnCreaVeicolo.Click += new System.EventHandler(this.btnCreaVeicolo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(12, 293);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(899, 280);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gestione AUTO-VEICOLI";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCaricaXML);
            this.groupBox4.Controls.Add(this.btnCreaXML);
            this.groupBox4.Controls.Add(this.dgvAuto);
            this.groupBox4.Location = new System.Drawing.Point(318, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(562, 239);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Visualizza AUTO";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAggiungiAuto);
            this.groupBox3.Controls.Add(this.dtpImmatricolazione);
            this.groupBox3.Controls.Add(this.cmbNPorte);
            this.groupBox3.Controls.Add(this.nudCilindrata);
            this.groupBox3.Controls.Add(this.txtColore);
            this.groupBox3.Controls.Add(this.txtModello);
            this.groupBox3.Controls.Add(this.txtMarca);
            this.groupBox3.Controls.Add(this.chkElettrica);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(19, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(293, 239);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dati AUTO";
            // 
            // btnAggiungiAuto
            // 
            this.btnAggiungiAuto.BackColor = System.Drawing.Color.Orange;
            this.btnAggiungiAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggiungiAuto.Location = new System.Drawing.Point(88, 177);
            this.btnAggiungiAuto.Name = "btnAggiungiAuto";
            this.btnAggiungiAuto.Size = new System.Drawing.Size(111, 23);
            this.btnAggiungiAuto.TabIndex = 13;
            this.btnAggiungiAuto.Text = "Aggiungi AUTO";
            this.btnAggiungiAuto.UseVisualStyleBackColor = false;
            this.btnAggiungiAuto.Click += new System.EventHandler(this.btnAggiungiAuto_Click);
            // 
            // dtpImmatricolazione
            // 
            this.dtpImmatricolazione.Location = new System.Drawing.Point(88, 128);
            this.dtpImmatricolazione.Name = "dtpImmatricolazione";
            this.dtpImmatricolazione.Size = new System.Drawing.Size(200, 20);
            this.dtpImmatricolazione.TabIndex = 12;
            // 
            // cmbNPorte
            // 
            this.cmbNPorte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNPorte.FormattingEnabled = true;
            this.cmbNPorte.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.cmbNPorte.Location = new System.Drawing.Point(221, 101);
            this.cmbNPorte.Name = "cmbNPorte";
            this.cmbNPorte.Size = new System.Drawing.Size(61, 21);
            this.cmbNPorte.TabIndex = 11;
            // 
            // nudCilindrata
            // 
            this.nudCilindrata.Location = new System.Drawing.Point(88, 102);
            this.nudCilindrata.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudCilindrata.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudCilindrata.Name = "nudCilindrata";
            this.nudCilindrata.Size = new System.Drawing.Size(45, 20);
            this.nudCilindrata.TabIndex = 10;
            this.nudCilindrata.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // txtColore
            // 
            this.txtColore.Location = new System.Drawing.Point(88, 75);
            this.txtColore.Name = "txtColore";
            this.txtColore.Size = new System.Drawing.Size(194, 20);
            this.txtColore.TabIndex = 9;
            // 
            // txtModello
            // 
            this.txtModello.Location = new System.Drawing.Point(88, 49);
            this.txtModello.Name = "txtModello";
            this.txtModello.Size = new System.Drawing.Size(194, 20);
            this.txtModello.TabIndex = 8;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(88, 23);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(194, 20);
            this.txtMarca.TabIndex = 7;
            // 
            // chkElettrica
            // 
            this.chkElettrica.AutoSize = true;
            this.chkElettrica.Location = new System.Drawing.Point(88, 154);
            this.chkElettrica.Name = "chkElettrica";
            this.chkElettrica.Size = new System.Drawing.Size(64, 17);
            this.chkElettrica.TabIndex = 6;
            this.chkElettrica.Text = "Elettrica";
            this.chkElettrica.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(169, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "N. Porte";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Data Imm.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Cilindrata";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Colore";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Modello";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Marca";
            // 
            // dgvAuto
            // 
            this.dgvAuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuto.Location = new System.Drawing.Point(11, 21);
            this.dgvAuto.Name = "dgvAuto";
            this.dgvAuto.Size = new System.Drawing.Size(530, 179);
            this.dgvAuto.TabIndex = 0;
            // 
            // btnCreaXML
            // 
            this.btnCreaXML.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCreaXML.Location = new System.Drawing.Point(197, 206);
            this.btnCreaXML.Name = "btnCreaXML";
            this.btnCreaXML.Size = new System.Drawing.Size(75, 23);
            this.btnCreaXML.TabIndex = 1;
            this.btnCreaXML.Text = "Crea XML";
            this.btnCreaXML.UseVisualStyleBackColor = false;
            this.btnCreaXML.Click += new System.EventHandler(this.btnCreaXML_Click);
            // 
            // btnCaricaXML
            // 
            this.btnCaricaXML.BackColor = System.Drawing.Color.Coral;
            this.btnCaricaXML.Location = new System.Drawing.Point(312, 206);
            this.btnCaricaXML.Name = "btnCaricaXML";
            this.btnCaricaXML.Size = new System.Drawing.Size(75, 23);
            this.btnCaricaXML.TabIndex = 2;
            this.btnCaricaXML.Text = "Carica XML";
            this.btnCaricaXML.UseVisualStyleBackColor = false;
            this.btnCaricaXML.Click += new System.EventHandler(this.btnCaricaXML_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 585);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "OOP - Esercizio 1 - Gestione Veicoli";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCilindrata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreaVeicolo;
        private System.Windows.Forms.ListBox lstVeicolo;
        private System.Windows.Forms.TextBox txtPrezzo;
        private System.Windows.Forms.TextBox txtKM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkElettrica;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpImmatricolazione;
        private System.Windows.Forms.ComboBox cmbNPorte;
        private System.Windows.Forms.NumericUpDown nudCilindrata;
        private System.Windows.Forms.TextBox txtColore;
        private System.Windows.Forms.TextBox txtModello;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Button btnAggiungiAuto;
        private System.Windows.Forms.DataGridView dgvAuto;
        private System.Windows.Forms.Button btnCaricaXML;
        private System.Windows.Forms.Button btnCreaXML;
    }
}

