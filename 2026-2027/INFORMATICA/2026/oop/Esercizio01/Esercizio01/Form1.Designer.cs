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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chkElettrica = new System.Windows.Forms.CheckBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModello = new System.Windows.Forms.TextBox();
            this.txtColore = new System.Windows.Forms.TextBox();
            this.nudCilindrata = new System.Windows.Forms.NumericUpDown();
            this.cmbPorte = new System.Windows.Forms.ComboBox();
            this.dtpMatricola = new System.Windows.Forms.DateTimePicker();
            this.btnAggiungiAuto = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCilindrata)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(940, 338);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestione VEICOLI";
            // 
            // txtPrezzo
            // 
            this.txtPrezzo.Location = new System.Drawing.Point(77, 123);
            this.txtPrezzo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrezzo.Name = "txtPrezzo";
            this.txtPrezzo.Size = new System.Drawing.Size(124, 22);
            this.txtPrezzo.TabIndex = 5;
            // 
            // txtKM
            // 
            this.txtKM.Location = new System.Drawing.Point(77, 91);
            this.txtKM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKM.Name = "txtKM";
            this.txtKM.Size = new System.Drawing.Size(124, 22);
            this.txtKM.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prezzo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Km.";
            // 
            // lstVeicolo
            // 
            this.lstVeicolo.FormattingEnabled = true;
            this.lstVeicolo.ItemHeight = 16;
            this.lstVeicolo.Location = new System.Drawing.Point(211, 44);
            this.lstVeicolo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstVeicolo.Name = "lstVeicolo";
            this.lstVeicolo.ScrollAlwaysVisible = true;
            this.lstVeicolo.Size = new System.Drawing.Size(687, 260);
            this.lstVeicolo.TabIndex = 1;
            // 
            // btnCreaVeicolo
            // 
            this.btnCreaVeicolo.Location = new System.Drawing.Point(21, 44);
            this.btnCreaVeicolo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreaVeicolo.Name = "btnCreaVeicolo";
            this.btnCreaVeicolo.Size = new System.Drawing.Size(181, 28);
            this.btnCreaVeicolo.TabIndex = 0;
            this.btnCreaVeicolo.Text = "Crea VEICOLO";
            this.btnCreaVeicolo.UseVisualStyleBackColor = true;
            this.btnCreaVeicolo.Click += new System.EventHandler(this.btnCreaVeicolo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(16, 375);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(940, 429);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gestione AUTO-VEICOLI";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAggiungiAuto);
            this.groupBox3.Controls.Add(this.dtpMatricola);
            this.groupBox3.Controls.Add(this.cmbPorte);
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
            this.groupBox3.Location = new System.Drawing.Point(21, 62);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(442, 344);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dati AUTO";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(469, 62);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(442, 344);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Visualizza AUTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Modello";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Colore";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Cilindrata";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Data Immatricolazione";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "N. Porte";
            // 
            // chkElettrica
            // 
            this.chkElettrica.AutoSize = true;
            this.chkElettrica.Location = new System.Drawing.Point(24, 296);
            this.chkElettrica.Name = "chkElettrica";
            this.chkElettrica.Size = new System.Drawing.Size(77, 20);
            this.chkElettrica.TabIndex = 6;
            this.chkElettrica.Text = "Elettrica";
            this.chkElettrica.UseVisualStyleBackColor = true;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(190, 43);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 22);
            this.txtMarca.TabIndex = 7;
            // 
            // txtModello
            // 
            this.txtModello.Location = new System.Drawing.Point(190, 79);
            this.txtModello.Name = "txtModello";
            this.txtModello.Size = new System.Drawing.Size(100, 22);
            this.txtModello.TabIndex = 8;
            // 
            // txtColore
            // 
            this.txtColore.Location = new System.Drawing.Point(190, 121);
            this.txtColore.Name = "txtColore";
            this.txtColore.Size = new System.Drawing.Size(100, 22);
            this.txtColore.TabIndex = 9;
            // 
            // nudCilindrata
            // 
            this.nudCilindrata.Location = new System.Drawing.Point(190, 162);
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
            this.nudCilindrata.Size = new System.Drawing.Size(100, 22);
            this.nudCilindrata.TabIndex = 10;
            this.nudCilindrata.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // cmbPorte
            // 
            this.cmbPorte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPorte.FormattingEnabled = true;
            this.cmbPorte.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.cmbPorte.Location = new System.Drawing.Point(190, 251);
            this.cmbPorte.Name = "cmbPorte";
            this.cmbPorte.Size = new System.Drawing.Size(100, 24);
            this.cmbPorte.TabIndex = 11;
            // 
            // dtpMatricola
            // 
            this.dtpMatricola.Location = new System.Drawing.Point(190, 208);
            this.dtpMatricola.Name = "dtpMatricola";
            this.dtpMatricola.Size = new System.Drawing.Size(100, 22);
            this.dtpMatricola.TabIndex = 12;
            // 
            // btnAggiungiAuto
            // 
            this.btnAggiungiAuto.Location = new System.Drawing.Point(218, 296);
            this.btnAggiungiAuto.Name = "btnAggiungiAuto";
            this.btnAggiungiAuto.Size = new System.Drawing.Size(133, 23);
            this.btnAggiungiAuto.TabIndex = 13;
            this.btnAggiungiAuto.Text = "Aggiungi auto";
            this.btnAggiungiAuto.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1581, 866);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "OOP - Esercizio 1 - Gestione Veicoli";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCilindrata)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nudCilindrata;
        private System.Windows.Forms.TextBox txtColore;
        private System.Windows.Forms.TextBox txtModello;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.CheckBox chkElettrica;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpMatricola;
        private System.Windows.Forms.ComboBox cmbPorte;
        private System.Windows.Forms.Button btnAggiungiAuto;
    }
}

