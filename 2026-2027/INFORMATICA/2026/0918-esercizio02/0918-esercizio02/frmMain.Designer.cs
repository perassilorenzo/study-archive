namespace _0918_esercizio02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.caso1VarGlobaleStaticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caso2VarPublicForm2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiudiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caso1VarGlobaleStaticToolStripMenuItem,
            this.caso2VarPublicForm2ToolStripMenuItem,
            this.chiudiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // caso1VarGlobaleStaticToolStripMenuItem
            // 
            this.caso1VarGlobaleStaticToolStripMenuItem.Name = "caso1VarGlobaleStaticToolStripMenuItem";
            this.caso1VarGlobaleStaticToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.caso1VarGlobaleStaticToolStripMenuItem.Text = "Caso 1 - var Globale Static";
            this.caso1VarGlobaleStaticToolStripMenuItem.Click += new System.EventHandler(this.caso1VarGlobaleStaticToolStripMenuItem_Click);
            // 
            // caso2VarPublicForm2ToolStripMenuItem
            // 
            this.caso2VarPublicForm2ToolStripMenuItem.Name = "caso2VarPublicForm2ToolStripMenuItem";
            this.caso2VarPublicForm2ToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.caso2VarPublicForm2ToolStripMenuItem.Text = "Caso 2 - var Public Form 3";
            this.caso2VarPublicForm2ToolStripMenuItem.Click += new System.EventHandler(this.caso2VarPublicForm2ToolStripMenuItem_Click);
            // 
            // chiudiToolStripMenuItem
            // 
            this.chiudiToolStripMenuItem.Name = "chiudiToolStripMenuItem";
            this.chiudiToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.chiudiToolStripMenuItem.Text = "Chiudi";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "esercizio 2 - passaggio parametri tra form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem caso1VarGlobaleStaticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caso2VarPublicForm2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiudiToolStripMenuItem;
    }
}

