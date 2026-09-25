namespace _0923_esercizio4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inserisciStudenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestioneStudentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ricercaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestioneClasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordinaAZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaSuFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caricaDaFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grbStudente = new System.Windows.Forms.GroupBox();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.cmbSpecializzazione = new System.Windows.Forms.ComboBox();
            this.cmbClasse = new System.Windows.Forms.ComboBox();
            this.nudMatricola = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataNascita = new System.Windows.Forms.DateTimePicker();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.grbStudente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatricola)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserisciStudenteToolStripMenuItem,
            this.gestioneStudentiToolStripMenuItem,
            this.gestioneClasseToolStripMenuItem,
            this.esciToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inserisciStudenteToolStripMenuItem
            // 
            this.inserisciStudenteToolStripMenuItem.Name = "inserisciStudenteToolStripMenuItem";
            this.inserisciStudenteToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.inserisciStudenteToolStripMenuItem.Text = "Inserisci Studente";
            this.inserisciStudenteToolStripMenuItem.Click += new System.EventHandler(this.inserisciStudenteToolStripMenuItem_Click);
            // 
            // gestioneStudentiToolStripMenuItem
            // 
            this.gestioneStudentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ricercaToolStripMenuItem,
            this.eliminaToolStripMenuItem});
            this.gestioneStudentiToolStripMenuItem.Name = "gestioneStudentiToolStripMenuItem";
            this.gestioneStudentiToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.gestioneStudentiToolStripMenuItem.Text = "Gestione Studenti";
            // 
            // ricercaToolStripMenuItem
            // 
            this.ricercaToolStripMenuItem.Name = "ricercaToolStripMenuItem";
            this.ricercaToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.ricercaToolStripMenuItem.Text = "Ricerca";
            // 
            // eliminaToolStripMenuItem
            // 
            this.eliminaToolStripMenuItem.Name = "eliminaToolStripMenuItem";
            this.eliminaToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.eliminaToolStripMenuItem.Text = "Elimina";
            // 
            // gestioneClasseToolStripMenuItem
            // 
            this.gestioneClasseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizzaToolStripMenuItem,
            this.ordinaAZToolStripMenuItem,
            this.salvaSuFileToolStripMenuItem,
            this.caricaDaFileToolStripMenuItem});
            this.gestioneClasseToolStripMenuItem.Name = "gestioneClasseToolStripMenuItem";
            this.gestioneClasseToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.gestioneClasseToolStripMenuItem.Text = "Gestione Classe";
            // 
            // visualizzaToolStripMenuItem
            // 
            this.visualizzaToolStripMenuItem.Name = "visualizzaToolStripMenuItem";
            this.visualizzaToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.visualizzaToolStripMenuItem.Text = "Visualizza ";
            // 
            // ordinaAZToolStripMenuItem
            // 
            this.ordinaAZToolStripMenuItem.Name = "ordinaAZToolStripMenuItem";
            this.ordinaAZToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.ordinaAZToolStripMenuItem.Text = "Ordina (A-Z)";
            // 
            // salvaSuFileToolStripMenuItem
            // 
            this.salvaSuFileToolStripMenuItem.Name = "salvaSuFileToolStripMenuItem";
            this.salvaSuFileToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.salvaSuFileToolStripMenuItem.Text = "Salva su File";
            // 
            // caricaDaFileToolStripMenuItem
            // 
            this.caricaDaFileToolStripMenuItem.Name = "caricaDaFileToolStripMenuItem";
            this.caricaDaFileToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.caricaDaFileToolStripMenuItem.Text = "Carica da File";
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // grbStudente
            // 
            this.grbStudente.Controls.Add(this.btnAnnulla);
            this.grbStudente.Controls.Add(this.cmbSpecializzazione);
            this.grbStudente.Controls.Add(this.cmbClasse);
            this.grbStudente.Controls.Add(this.nudMatricola);
            this.grbStudente.Controls.Add(this.label6);
            this.grbStudente.Controls.Add(this.label5);
            this.grbStudente.Controls.Add(this.label4);
            this.grbStudente.Controls.Add(this.btnInserisci);
            this.grbStudente.Controls.Add(this.txtNome);
            this.grbStudente.Controls.Add(this.label3);
            this.grbStudente.Controls.Add(this.label2);
            this.grbStudente.Controls.Add(this.dtpDataNascita);
            this.grbStudente.Controls.Add(this.txtCognome);
            this.grbStudente.Controls.Add(this.label1);
            this.grbStudente.Location = new System.Drawing.Point(12, 31);
            this.grbStudente.Name = "grbStudente";
            this.grbStudente.Size = new System.Drawing.Size(762, 314);
            this.grbStudente.TabIndex = 1;
            this.grbStudente.TabStop = false;
            this.grbStudente.Text = "Inserimento Nuovo Studente";
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Location = new System.Drawing.Point(626, 192);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulla.TabIndex = 13;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            // 
            // cmbSpecializzazione
            // 
            this.cmbSpecializzazione.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpecializzazione.FormattingEnabled = true;
            this.cmbSpecializzazione.Location = new System.Drawing.Point(412, 116);
            this.cmbSpecializzazione.Name = "cmbSpecializzazione";
            this.cmbSpecializzazione.Size = new System.Drawing.Size(200, 24);
            this.cmbSpecializzazione.TabIndex = 12;
            // 
            // cmbClasse
            // 
            this.cmbClasse.FormattingEnabled = true;
            this.cmbClasse.Items.AddRange(new object[] {
            "1A",
            "2A",
            "3A",
            "4A",
            "5A",
            "1B",
            "2B",
            "3B",
            "4B",
            "5B",
            "1C",
            "2C",
            "3C",
            "4C",
            "5C"});
            this.cmbClasse.Location = new System.Drawing.Point(412, 82);
            this.cmbClasse.Name = "cmbClasse";
            this.cmbClasse.Size = new System.Drawing.Size(200, 24);
            this.cmbClasse.TabIndex = 11;
            // 
            // nudMatricola
            // 
            this.nudMatricola.Location = new System.Drawing.Point(110, 51);
            this.nudMatricola.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMatricola.Name = "nudMatricola";
            this.nudMatricola.Size = new System.Drawing.Size(120, 22);
            this.nudMatricola.TabIndex = 10;
            this.nudMatricola.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Specializzazione:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Classe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data di Nascita:";
            // 
            // btnInserisci
            // 
            this.btnInserisci.BackColor = System.Drawing.Color.Lime;
            this.btnInserisci.Location = new System.Drawing.Point(534, 192);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(75, 23);
            this.btnInserisci.TabIndex = 6;
            this.btnInserisci.Text = "Inserisci";
            this.btnInserisci.UseVisualStyleBackColor = false;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(110, 113);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(120, 22);
            this.txtNome.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cognome:";
            // 
            // dtpDataNascita
            // 
            this.dtpDataNascita.Location = new System.Drawing.Point(412, 51);
            this.dtpDataNascita.Name = "dtpDataNascita";
            this.dtpDataNascita.Size = new System.Drawing.Size(200, 22);
            this.dtpDataNascita.TabIndex = 2;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(110, 82);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(120, 22);
            this.txtCognome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° Matricola:";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbStudente);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "0923 | esercizio 4 (Gestione STUDENTI / CLASSI)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbStudente.ResumeLayout(false);
            this.grbStudente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatricola)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inserisciStudenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestioneStudentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ricercaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestioneClasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordinaAZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvaSuFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caricaDaFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox grbStudente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataNascita;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.ComboBox cmbSpecializzazione;
        private System.Windows.Forms.ComboBox cmbClasse;
        private System.Windows.Forms.NumericUpDown nudMatricola;
    }
}

