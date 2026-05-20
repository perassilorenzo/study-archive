namespace _0211_visualProjectEs17pag116
{
    partial class FormCanzoni
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
            this.SuspendLayout();
            // 
            // FormCanzoni
            // 
            this.ClientSize = new System.Drawing.Size(1117, 538);
            this.Name = "FormCanzoni";
            this.Load += new System.EventHandler(this.FormCanzoni_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCantanti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstCanzoni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstCanzoniCercate;
        private System.Windows.Forms.TextBox txtNomeCantante;
        private System.Windows.Forms.Button btnCercaCanzoni;
    }
}

