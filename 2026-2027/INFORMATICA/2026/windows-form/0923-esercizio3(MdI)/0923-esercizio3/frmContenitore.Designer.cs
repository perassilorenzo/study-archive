namespace _0923_esercizio3
{
    partial class frmContenitore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContenitore));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.apriFORM2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apriFORM3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apriFORM4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apriFORM2ToolStripMenuItem,
            this.apriFORM3ToolStripMenuItem,
            this.apriFORM4ToolStripMenuItem,
            this.esciToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // apriFORM2ToolStripMenuItem
            // 
            this.apriFORM2ToolStripMenuItem.Name = "apriFORM2ToolStripMenuItem";
            this.apriFORM2ToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.apriFORM2ToolStripMenuItem.Text = "Apri FORM 2";
            this.apriFORM2ToolStripMenuItem.Click += new System.EventHandler(this.apriFORM2ToolStripMenuItem_Click);
            // 
            // apriFORM3ToolStripMenuItem
            // 
            this.apriFORM3ToolStripMenuItem.Name = "apriFORM3ToolStripMenuItem";
            this.apriFORM3ToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.apriFORM3ToolStripMenuItem.Text = "Apri FORM 3";
            this.apriFORM3ToolStripMenuItem.Click += new System.EventHandler(this.apriFORM3ToolStripMenuItem_Click);
            // 
            // apriFORM4ToolStripMenuItem
            // 
            this.apriFORM4ToolStripMenuItem.Name = "apriFORM4ToolStripMenuItem";
            this.apriFORM4ToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.apriFORM4ToolStripMenuItem.Text = "Apri FORM 4";
            this.apriFORM4ToolStripMenuItem.Click += new System.EventHandler(this.apriFORM4ToolStripMenuItem_Click);
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.esciToolStripMenuItem.Text = "Esci";
            // 
            // frmContenitore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmContenitore";
            this.Text = "0923 | esercizio 3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem apriFORM2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apriFORM3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apriFORM4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
    }
}

