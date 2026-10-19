namespace _0916_ripasso
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
            this.picVallauri = new System.Windows.Forms.PictureBox();
            this.btnDuplica = new System.Windows.Forms.Button();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.btnAggiungi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picVallauri)).BeginInit();
            this.SuspendLayout();
            // 
            // picVallauri
            // 
            this.picVallauri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picVallauri.Image = ((System.Drawing.Image)(resources.GetObject("picVallauri.Image")));
            this.picVallauri.Location = new System.Drawing.Point(37, 26);
            this.picVallauri.Name = "picVallauri";
            this.picVallauri.Size = new System.Drawing.Size(202, 194);
            this.picVallauri.TabIndex = 0;
            this.picVallauri.TabStop = false;
            // 
            // btnDuplica
            // 
            this.btnDuplica.Location = new System.Drawing.Point(363, 26);
            this.btnDuplica.Name = "btnDuplica";
            this.btnDuplica.Size = new System.Drawing.Size(75, 23);
            this.btnDuplica.TabIndex = 1;
            this.btnDuplica.Text = "Duplica";
            this.btnDuplica.UseVisualStyleBackColor = true;
            this.btnDuplica.Click += new System.EventHandler(this.btnDuplica_Click);
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Location = new System.Drawing.Point(530, 26);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizza.TabIndex = 2;
            this.btnVisualizza.Text = "Visualizza";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(686, 26);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(75, 23);
            this.btnAggiungi.TabIndex = 3;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 531);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.btnDuplica);
            this.Controls.Add(this.picVallauri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "0916 - esercizio 1";
            ((System.ComponentModel.ISupportInitialize)(this.picVallauri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picVallauri;
        private System.Windows.Forms.Button btnDuplica;
        private System.Windows.Forms.Button btnVisualizza;
        private System.Windows.Forms.Button btnAggiungi;
    }
}

