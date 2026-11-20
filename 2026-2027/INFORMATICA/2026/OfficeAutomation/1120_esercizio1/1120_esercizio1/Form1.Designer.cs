namespace _1120_esercizio1
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
            this.btnCreaDoc = new System.Windows.Forms.Button();
            this.btnLeggeDoc = new System.Windows.Forms.Button();
            this.lstDatiDoc = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCreaDoc
            // 
            this.btnCreaDoc.Location = new System.Drawing.Point(12, 12);
            this.btnCreaDoc.Name = "btnCreaDoc";
            this.btnCreaDoc.Size = new System.Drawing.Size(112, 35);
            this.btnCreaDoc.TabIndex = 0;
            this.btnCreaDoc.Text = "Crea Docx";
            this.btnCreaDoc.UseVisualStyleBackColor = true;
            this.btnCreaDoc.Click += new System.EventHandler(this.btnCreaDoc_Click);
            // 
            // btnLeggeDoc
            // 
            this.btnLeggeDoc.Location = new System.Drawing.Point(130, 12);
            this.btnLeggeDoc.Name = "btnLeggeDoc";
            this.btnLeggeDoc.Size = new System.Drawing.Size(121, 35);
            this.btnLeggeDoc.TabIndex = 1;
            this.btnLeggeDoc.Text = "Leggi Docx";
            this.btnLeggeDoc.UseVisualStyleBackColor = true;
            this.btnLeggeDoc.Click += new System.EventHandler(this.btnLeggeDoc_Click);
            // 
            // lstDatiDoc
            // 
            this.lstDatiDoc.FormattingEnabled = true;
            this.lstDatiDoc.ItemHeight = 16;
            this.lstDatiDoc.Location = new System.Drawing.Point(257, 12);
            this.lstDatiDoc.Name = "lstDatiDoc";
            this.lstDatiDoc.Size = new System.Drawing.Size(365, 292);
            this.lstDatiDoc.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstDatiDoc);
            this.Controls.Add(this.btnLeggeDoc);
            this.Controls.Add(this.btnCreaDoc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Esercizio 1 - Documento WORD";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreaDoc;
        private System.Windows.Forms.Button btnLeggeDoc;
        private System.Windows.Forms.ListBox lstDatiDoc;
    }
}

