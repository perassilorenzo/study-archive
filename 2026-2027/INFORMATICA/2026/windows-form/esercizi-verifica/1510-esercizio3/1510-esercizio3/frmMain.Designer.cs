namespace _1510_esercizio3
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.impostaUtenteALorenzoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apriFrmProfiloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.impostaUtenteALorenzoToolStripMenuItem,
            this.apriFrmProfiloToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // impostaUtenteALorenzoToolStripMenuItem
            // 
            this.impostaUtenteALorenzoToolStripMenuItem.Name = "impostaUtenteALorenzoToolStripMenuItem";
            this.impostaUtenteALorenzoToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.impostaUtenteALorenzoToolStripMenuItem.Text = "Imposta utente a \"Lorenzo\"";
            this.impostaUtenteALorenzoToolStripMenuItem.Click += new System.EventHandler(this.impostaUtenteALorenzoToolStripMenuItem_Click);
            // 
            // apriFrmProfiloToolStripMenuItem
            // 
            this.apriFrmProfiloToolStripMenuItem.Name = "apriFrmProfiloToolStripMenuItem";
            this.apriFrmProfiloToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.apriFrmProfiloToolStripMenuItem.Text = "Apri frmProfilo";
            this.apriFrmProfiloToolStripMenuItem.Click += new System.EventHandler(this.apriFrmProfiloToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem impostaUtenteALorenzoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apriFrmProfiloToolStripMenuItem;
    }
}

