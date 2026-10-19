namespace _1510_esercizio2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.apriMagazzinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apriClientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.confermaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apriMagazzinoToolStripMenuItem,
            this.apriClientiToolStripMenuItem,
            this.esciToolStripMenuItem,
            this.toolStripMenuItem1,
            this.confermaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // apriMagazzinoToolStripMenuItem
            // 
            this.apriMagazzinoToolStripMenuItem.Name = "apriMagazzinoToolStripMenuItem";
            this.apriMagazzinoToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.apriMagazzinoToolStripMenuItem.Text = "Apri Magazzino";
            this.apriMagazzinoToolStripMenuItem.Click += new System.EventHandler(this.apriMagazzinoToolStripMenuItem_Click);
            // 
            // apriClientiToolStripMenuItem
            // 
            this.apriClientiToolStripMenuItem.Name = "apriClientiToolStripMenuItem";
            this.apriClientiToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.apriClientiToolStripMenuItem.Text = "Apri Clienti";
            this.apriClientiToolStripMenuItem.Click += new System.EventHandler(this.apriClientiToolStripMenuItem_Click);
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.esciToolStripMenuItem.Text = "Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(30, 24);
            this.toolStripMenuItem1.Text = "?";
            // 
            // confermaToolStripMenuItem
            // 
            this.confermaToolStripMenuItem.Name = "confermaToolStripMenuItem";
            this.confermaToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.confermaToolStripMenuItem.Text = "Conferma";
            this.confermaToolStripMenuItem.Click += new System.EventHandler(this.confermaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem apriMagazzinoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apriClientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem confermaToolStripMenuItem;
    }
}

