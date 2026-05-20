namespace _65_Es16pag174
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeReparto = new System.Windows.Forms.TextBox();
            this.lstDatiCaricati = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstDatiRicerca = new System.Windows.Forms.ListBox();
            this.btnCerca = new System.Windows.Forms.Button();
            this.dgvDati = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDati)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(523, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome repato:";
            // 
            // txtNomeReparto
            // 
            this.txtNomeReparto.Location = new System.Drawing.Point(631, 34);
            this.txtNomeReparto.Name = "txtNomeReparto";
            this.txtNomeReparto.Size = new System.Drawing.Size(176, 22);
            this.txtNomeReparto.TabIndex = 1;
            // 
            // lstDatiCaricati
            // 
            this.lstDatiCaricati.FormattingEnabled = true;
            this.lstDatiCaricati.ItemHeight = 16;
            this.lstDatiCaricati.Location = new System.Drawing.Point(16, 64);
            this.lstDatiCaricati.Name = "lstDatiCaricati";
            this.lstDatiCaricati.Size = new System.Drawing.Size(391, 260);
            this.lstDatiCaricati.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dati Caricati";
            // 
            // lstDatiRicerca
            // 
            this.lstDatiRicerca.FormattingEnabled = true;
            this.lstDatiRicerca.ItemHeight = 16;
            this.lstDatiRicerca.Location = new System.Drawing.Point(526, 64);
            this.lstDatiRicerca.Name = "lstDatiRicerca";
            this.lstDatiRicerca.Size = new System.Drawing.Size(391, 260);
            this.lstDatiRicerca.TabIndex = 4;
            // 
            // btnCerca
            // 
            this.btnCerca.Location = new System.Drawing.Point(824, 33);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(75, 23);
            this.btnCerca.TabIndex = 5;
            this.btnCerca.Text = "Cerca";
            this.btnCerca.UseVisualStyleBackColor = true;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // dgvDati
            // 
            this.dgvDati.AllowUserToAddRows = false;
            this.dgvDati.AllowUserToDeleteRows = false;
            this.dgvDati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDati.Location = new System.Drawing.Point(16, 376);
            this.dgvDati.Name = "dgvDati";
            this.dgvDati.ReadOnly = true;
            this.dgvDati.RowHeadersVisible = false;
            this.dgvDati.RowHeadersWidth = 51;
            this.dgvDati.RowTemplate.Height = 24;
            this.dgvDati.Size = new System.Drawing.Size(910, 150);
            this.dgvDati.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 595);
            this.Controls.Add(this.dgvDati);
            this.Controls.Add(this.btnCerca);
            this.Controls.Add(this.lstDatiRicerca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstDatiCaricati);
            this.Controls.Add(this.txtNomeReparto);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeReparto;
        private System.Windows.Forms.ListBox lstDatiCaricati;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstDatiRicerca;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.DataGridView dgvDati;
    }
}