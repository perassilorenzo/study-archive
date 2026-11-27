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
            this.btnImg = new System.Windows.Forms.Button();
            this.btnAddImg = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnModificaParagrafo = new System.Windows.Forms.Button();
            this.btnTabella = new System.Windows.Forms.Button();
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
            // btnImg
            // 
            this.btnImg.Location = new System.Drawing.Point(12, 53);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(112, 35);
            this.btnImg.TabIndex = 3;
            this.btnImg.Text = "Crea IMG";
            this.btnImg.UseVisualStyleBackColor = true;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // btnAddImg
            // 
            this.btnAddImg.Location = new System.Drawing.Point(130, 53);
            this.btnAddImg.Name = "btnAddImg";
            this.btnAddImg.Size = new System.Drawing.Size(112, 35);
            this.btnAddImg.TabIndex = 4;
            this.btnAddImg.Text = "Aggiungi IMG";
            this.btnAddImg.UseVisualStyleBackColor = true;
            this.btnAddImg.Click += new System.EventHandler(this.btnAddImg_Click);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(12, 94);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(112, 35);
            this.btnFont.TabIndex = 5;
            this.btnFont.Text = "Aggiungi font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnModificaParagrafo
            // 
            this.btnModificaParagrafo.Location = new System.Drawing.Point(130, 94);
            this.btnModificaParagrafo.Name = "btnModificaParagrafo";
            this.btnModificaParagrafo.Size = new System.Drawing.Size(112, 47);
            this.btnModificaParagrafo.TabIndex = 6;
            this.btnModificaParagrafo.Text = "Modifica paragrafo";
            this.btnModificaParagrafo.UseVisualStyleBackColor = true;
            this.btnModificaParagrafo.Click += new System.EventHandler(this.btnModificaParagrafo_Click);
            // 
            // btnTabella
            // 
            this.btnTabella.Location = new System.Drawing.Point(12, 135);
            this.btnTabella.Name = "btnTabella";
            this.btnTabella.Size = new System.Drawing.Size(112, 47);
            this.btnTabella.TabIndex = 7;
            this.btnTabella.Text = "Aggiugni tabella";
            this.btnTabella.UseVisualStyleBackColor = true;
            this.btnTabella.Click += new System.EventHandler(this.btnTabella_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTabella);
            this.Controls.Add(this.btnModificaParagrafo);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnAddImg);
            this.Controls.Add(this.btnImg);
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
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.Button btnAddImg;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnModificaParagrafo;
        private System.Windows.Forms.Button btnTabella;
    }
}

