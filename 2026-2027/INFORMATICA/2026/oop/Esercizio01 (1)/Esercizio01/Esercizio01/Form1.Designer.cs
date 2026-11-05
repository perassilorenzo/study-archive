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
            this.btnCreaJSon = new System.Windows.Forms.Button();
            this.btnCaricaXML = new System.Windows.Forms.Button();
            this.btnCreaXML = new System.Windows.Forms.Button();
            this.dgvAuto = new System.Windows.Forms.DataGridView();
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblConsumo = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblAssicurazione = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblBollo = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblEta = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrezzoAuto = new System.Windows.Forms.TextBox();
            this.txtKmAuto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuto)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCilindrata)).BeginInit();
            this.groupBox5.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(692, 275);
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
            this.groupBox4.Controls.Add(this.btnCreaJSon);
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
            // btnCreaJSon
            // 
            this.btnCreaJSon.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnCreaJSon.Location = new System.Drawing.Point(340, 206);
            this.btnCreaJSon.Name = "btnCreaJSon";
            this.btnCreaJSon.Size = new System.Drawing.Size(75, 23);
            this.btnCreaJSon.TabIndex = 3;
            this.btnCreaJSon.Text = "Crea JSON";
            this.btnCreaJSon.UseVisualStyleBackColor = false;
            this.btnCreaJSon.Click += new System.EventHandler(this.btnCreaJSon_Click);
            // 
            // btnCaricaXML
            // 
            this.btnCaricaXML.BackColor = System.Drawing.Color.Coral;
            this.btnCaricaXML.Location = new System.Drawing.Point(238, 206);
            this.btnCaricaXML.Name = "btnCaricaXML";
            this.btnCaricaXML.Size = new System.Drawing.Size(75, 23);
            this.btnCaricaXML.TabIndex = 2;
            this.btnCaricaXML.Text = "Carica XML";
            this.btnCaricaXML.UseVisualStyleBackColor = false;
            this.btnCaricaXML.Click += new System.EventHandler(this.btnCaricaXML_Click);
            // 
            // btnCreaXML
            // 
            this.btnCreaXML.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCreaXML.Location = new System.Drawing.Point(140, 206);
            this.btnCreaXML.Name = "btnCreaXML";
            this.btnCreaXML.Size = new System.Drawing.Size(75, 23);
            this.btnCreaXML.TabIndex = 1;
            this.btnCreaXML.Text = "Crea XML";
            this.btnCreaXML.UseVisualStyleBackColor = false;
            this.btnCreaXML.Click += new System.EventHandler(this.btnCreaXML_Click);
            // 
            // dgvAuto
            // 
            this.dgvAuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuto.Location = new System.Drawing.Point(45, 0);
            this.dgvAuto.Name = "dgvAuto";
            this.dgvAuto.Size = new System.Drawing.Size(530, 179);
            this.dgvAuto.TabIndex = 0;
            this.dgvAuto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAuto_CellClick);
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblConsumo);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.lblAssicurazione);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.lblBollo);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.lblEta);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.txtPrezzoAuto);
            this.groupBox5.Controls.Add(this.txtKmAuto);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(711, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 275);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dettaglio AUTO-VEICOLO";
            // 
            // lblConsumo
            // 
            this.lblConsumo.AutoSize = true;
            this.lblConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsumo.ForeColor = System.Drawing.Color.Blue;
            this.lblConsumo.Location = new System.Drawing.Point(95, 228);
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Size = new System.Drawing.Size(0, 13);
            this.lblConsumo.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 228);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Comsumo";
            // 
            // lblAssicurazione
            // 
            this.lblAssicurazione.AutoSize = true;
            this.lblAssicurazione.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssicurazione.ForeColor = System.Drawing.Color.Blue;
            this.lblAssicurazione.Location = new System.Drawing.Point(95, 200);
            this.lblAssicurazione.Name = "lblAssicurazione";
            this.lblAssicurazione.Size = new System.Drawing.Size(0, 13);
            this.lblAssicurazione.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 199);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Assicurazione";
            // 
            // lblBollo
            // 
            this.lblBollo.AutoSize = true;
            this.lblBollo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBollo.ForeColor = System.Drawing.Color.Blue;
            this.lblBollo.Location = new System.Drawing.Point(95, 168);
            this.lblBollo.Name = "lblBollo";
            this.lblBollo.Size = new System.Drawing.Size(0, 13);
            this.lblBollo.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Bollo";
            // 
            // lblEta
            // 
            this.lblEta.AutoSize = true;
            this.lblEta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEta.ForeColor = System.Drawing.Color.Blue;
            this.lblEta.Location = new System.Drawing.Point(93, 138);
            this.lblEta.Name = "lblEta";
            this.lblEta.Size = new System.Drawing.Size(0, 13);
            this.lblEta.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Età";
            // 
            // txtPrezzoAuto
            // 
            this.txtPrezzoAuto.Location = new System.Drawing.Point(96, 83);
            this.txtPrezzoAuto.Name = "txtPrezzoAuto";
            this.txtPrezzoAuto.Size = new System.Drawing.Size(85, 20);
            this.txtPrezzoAuto.TabIndex = 3;
            // 
            // txtKmAuto
            // 
            this.txtKmAuto.Location = new System.Drawing.Point(96, 36);
            this.txtKmAuto.Name = "txtKmAuto";
            this.txtKmAuto.Size = new System.Drawing.Size(85, 20);
            this.txtKmAuto.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Prezzo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Km";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 585);
            this.Controls.Add(this.groupBox5);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuto)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCilindrata)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private System.Windows.Forms.Button btnCreaJSon;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtPrezzoAuto;
        private System.Windows.Forms.TextBox txtKmAuto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblEta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblBollo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblConsumo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblAssicurazione;
        private System.Windows.Forms.Label label14;
    }
}

