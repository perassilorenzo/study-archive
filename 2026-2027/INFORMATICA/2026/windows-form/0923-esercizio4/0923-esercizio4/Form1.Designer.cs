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
            this.grbStudente = new System.Windows.Forms.GroupBox();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.cmbSpecializzazione = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbClasse = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDataNascita = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudMatricola = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.grbClasse = new System.Windows.Forms.GroupBox();
            this.dgvClasse = new System.Windows.Forms.DataGridView();
            this.grbRicerca = new System.Windows.Forms.GroupBox();
            this.brnRicerca = new System.Windows.Forms.Button();
            this.txtRicCognome = new System.Windows.Forms.TextBox();
            this.txtRicNome = new System.Windows.Forms.TextBox();
            this.nudRicMatricola = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grpDatiStudente = new System.Windows.Forms.GroupBox();
            this.btnElimina = new System.Windows.Forms.Button();
            this.lblSpec = new System.Windows.Forms.Label();
            this.lblClasse = new System.Windows.Forms.Label();
            this.lblDataNascita = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCognome = new System.Windows.Forms.Label();
            this.lblMatricola = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grbStudente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatricola)).BeginInit();
            this.grbClasse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasse)).BeginInit();
            this.grbRicerca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRicMatricola)).BeginInit();
            this.grpDatiStudente.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1646, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inserisciStudenteToolStripMenuItem
            // 
            this.inserisciStudenteToolStripMenuItem.Name = "inserisciStudenteToolStripMenuItem";
            this.inserisciStudenteToolStripMenuItem.Size = new System.Drawing.Size(138, 34);
            this.inserisciStudenteToolStripMenuItem.Text = "Inserisci Studente";
            this.inserisciStudenteToolStripMenuItem.Click += new System.EventHandler(this.inserisciStudenteToolStripMenuItem_Click);
            // 
            // gestioneStudentiToolStripMenuItem
            // 
            this.gestioneStudentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ricercaToolStripMenuItem,
            this.eliminaToolStripMenuItem});
            this.gestioneStudentiToolStripMenuItem.Name = "gestioneStudentiToolStripMenuItem";
            this.gestioneStudentiToolStripMenuItem.Size = new System.Drawing.Size(140, 34);
            this.gestioneStudentiToolStripMenuItem.Text = "Gestione Studenti";
            // 
            // ricercaToolStripMenuItem
            // 
            this.ricercaToolStripMenuItem.Name = "ricercaToolStripMenuItem";
            this.ricercaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ricercaToolStripMenuItem.Text = "Ricerca";
            this.ricercaToolStripMenuItem.Click += new System.EventHandler(this.ricercaToolStripMenuItem_Click);
            // 
            // eliminaToolStripMenuItem
            // 
            this.eliminaToolStripMenuItem.Name = "eliminaToolStripMenuItem";
            this.eliminaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.eliminaToolStripMenuItem.Text = "Elimina";
            this.eliminaToolStripMenuItem.Click += new System.EventHandler(this.eliminaToolStripMenuItem_Click);
            // 
            // gestioneClasseToolStripMenuItem
            // 
            this.gestioneClasseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizzaToolStripMenuItem,
            this.ordinaAZToolStripMenuItem,
            this.salvaSuFileToolStripMenuItem,
            this.caricaDaFileToolStripMenuItem});
            this.gestioneClasseToolStripMenuItem.Name = "gestioneClasseToolStripMenuItem";
            this.gestioneClasseToolStripMenuItem.Size = new System.Drawing.Size(126, 34);
            this.gestioneClasseToolStripMenuItem.Text = "Gestione Classe";
            // 
            // visualizzaToolStripMenuItem
            // 
            this.visualizzaToolStripMenuItem.Name = "visualizzaToolStripMenuItem";
            this.visualizzaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.visualizzaToolStripMenuItem.Text = "Visualizza";
            this.visualizzaToolStripMenuItem.Click += new System.EventHandler(this.visualizzaToolStripMenuItem_Click);
            // 
            // ordinaAZToolStripMenuItem
            // 
            this.ordinaAZToolStripMenuItem.Name = "ordinaAZToolStripMenuItem";
            this.ordinaAZToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ordinaAZToolStripMenuItem.Text = "Ordina (A .. Z)";
            this.ordinaAZToolStripMenuItem.Click += new System.EventHandler(this.ordinaAZToolStripMenuItem_Click);
            // 
            // salvaSuFileToolStripMenuItem
            // 
            this.salvaSuFileToolStripMenuItem.Name = "salvaSuFileToolStripMenuItem";
            this.salvaSuFileToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salvaSuFileToolStripMenuItem.Text = "Salva su File";
            this.salvaSuFileToolStripMenuItem.Click += new System.EventHandler(this.salvaSuFileToolStripMenuItem_Click);
            // 
            // caricaDaFileToolStripMenuItem
            // 
            this.caricaDaFileToolStripMenuItem.Name = "caricaDaFileToolStripMenuItem";
            this.caricaDaFileToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.caricaDaFileToolStripMenuItem.Text = "Carica da File";
            this.caricaDaFileToolStripMenuItem.Click += new System.EventHandler(this.caricaDaFileToolStripMenuItem_Click);
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(48, 34);
            this.esciToolStripMenuItem.Text = "Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(30, 34);
            this.toolStripMenuItem1.Text = "?";
            // 
            // grbStudente
            // 
            this.grbStudente.Controls.Add(this.btnAnnulla);
            this.grbStudente.Controls.Add(this.btnInserisci);
            this.grbStudente.Controls.Add(this.cmbSpecializzazione);
            this.grbStudente.Controls.Add(this.label6);
            this.grbStudente.Controls.Add(this.cmbClasse);
            this.grbStudente.Controls.Add(this.label5);
            this.grbStudente.Controls.Add(this.dtpDataNascita);
            this.grbStudente.Controls.Add(this.label4);
            this.grbStudente.Controls.Add(this.txtNome);
            this.grbStudente.Controls.Add(this.label3);
            this.grbStudente.Controls.Add(this.txtCognome);
            this.grbStudente.Controls.Add(this.label2);
            this.grbStudente.Controls.Add(this.nudMatricola);
            this.grbStudente.Controls.Add(this.label1);
            this.grbStudente.Location = new System.Drawing.Point(16, 33);
            this.grbStudente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbStudente.Name = "grbStudente";
            this.grbStudente.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbStudente.Size = new System.Drawing.Size(781, 231);
            this.grbStudente.TabIndex = 1;
            this.grbStudente.TabStop = false;
            this.grbStudente.Text = "Inserimento Nuovo Studente";
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.BackColor = System.Drawing.Color.LightCoral;
            this.btnAnnulla.Location = new System.Drawing.Point(455, 183);
            this.btnAnnulla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(100, 28);
            this.btnAnnulla.TabIndex = 13;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = false;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // btnInserisci
            // 
            this.btnInserisci.BackColor = System.Drawing.Color.LightGreen;
            this.btnInserisci.Location = new System.Drawing.Point(252, 183);
            this.btnInserisci.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(100, 28);
            this.btnInserisci.TabIndex = 12;
            this.btnInserisci.Text = "Inserisci";
            this.btnInserisci.UseVisualStyleBackColor = false;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // cmbSpecializzazione
            // 
            this.cmbSpecializzazione.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpecializzazione.FormattingEnabled = true;
            this.cmbSpecializzazione.Location = new System.Drawing.Point(515, 138);
            this.cmbSpecializzazione.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSpecializzazione.Name = "cmbSpecializzazione";
            this.cmbSpecializzazione.Size = new System.Drawing.Size(107, 24);
            this.cmbSpecializzazione.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 142);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Specializzazione";
            // 
            // cmbClasse
            // 
            this.cmbClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClasse.FormattingEnabled = true;
            this.cmbClasse.Items.AddRange(new object[] {
            "1A",
            "1B",
            "1C",
            "1D",
            "1E",
            "2A",
            "2B",
            "2C",
            "2D",
            "2E",
            "3A",
            "3B",
            "3C",
            "3D",
            "3E",
            "4A",
            "4B",
            "4C",
            "4D",
            "4E",
            "5A",
            "5B",
            "5C",
            "5D",
            "5E"});
            this.cmbClasse.Location = new System.Drawing.Point(515, 91);
            this.cmbClasse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbClasse.Name = "cmbClasse";
            this.cmbClasse.Size = new System.Drawing.Size(107, 24);
            this.cmbClasse.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 95);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Classe";
            // 
            // dtpDataNascita
            // 
            this.dtpDataNascita.Location = new System.Drawing.Point(515, 42);
            this.dtpDataNascita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDataNascita.Name = "dtpDataNascita";
            this.dtpDataNascita.Size = new System.Drawing.Size(265, 22);
            this.dtpDataNascita.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data di Nascita";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(131, 138);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(220, 22);
            this.txtNome.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(131, 91);
            this.txtCognome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(220, 22);
            this.txtCognome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cognome";
            // 
            // nudMatricola
            // 
            this.nudMatricola.Location = new System.Drawing.Point(131, 41);
            this.nudMatricola.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudMatricola.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMatricola.Name = "nudMatricola";
            this.nudMatricola.Size = new System.Drawing.Size(119, 22);
            this.nudMatricola.TabIndex = 1;
            this.nudMatricola.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "N. Matricola";
            // 
            // grbClasse
            // 
            this.grbClasse.Controls.Add(this.dgvClasse);
            this.grbClasse.Location = new System.Drawing.Point(16, 272);
            this.grbClasse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbClasse.Name = "grbClasse";
            this.grbClasse.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbClasse.Size = new System.Drawing.Size(781, 158);
            this.grbClasse.TabIndex = 2;
            this.grbClasse.TabStop = false;
            this.grbClasse.Text = "Visualizzazione Classe";
            // 
            // dgvClasse
            // 
            this.dgvClasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasse.Location = new System.Drawing.Point(8, 23);
            this.dgvClasse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvClasse.Name = "dgvClasse";
            this.dgvClasse.RowHeadersWidth = 51;
            this.dgvClasse.Size = new System.Drawing.Size(751, 126);
            this.dgvClasse.TabIndex = 0;
            // 
            // grbRicerca
            // 
            this.grbRicerca.Controls.Add(this.brnRicerca);
            this.grbRicerca.Controls.Add(this.txtRicCognome);
            this.grbRicerca.Controls.Add(this.txtRicNome);
            this.grbRicerca.Controls.Add(this.nudRicMatricola);
            this.grbRicerca.Controls.Add(this.label9);
            this.grbRicerca.Controls.Add(this.label8);
            this.grbRicerca.Controls.Add(this.label7);
            this.grbRicerca.Location = new System.Drawing.Point(16, 448);
            this.grbRicerca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbRicerca.Name = "grbRicerca";
            this.grbRicerca.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbRicerca.Size = new System.Drawing.Size(409, 331);
            this.grbRicerca.TabIndex = 3;
            this.grbRicerca.TabStop = false;
            this.grbRicerca.Text = "Ricerca Studente";
            // 
            // brnRicerca
            // 
            this.brnRicerca.BackColor = System.Drawing.Color.Gold;
            this.brnRicerca.Location = new System.Drawing.Point(149, 254);
            this.brnRicerca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.brnRicerca.Name = "brnRicerca";
            this.brnRicerca.Size = new System.Drawing.Size(100, 28);
            this.brnRicerca.TabIndex = 6;
            this.brnRicerca.Text = "Ricerca";
            this.brnRicerca.UseVisualStyleBackColor = false;
            this.brnRicerca.Click += new System.EventHandler(this.brnRicerca_Click);
            // 
            // txtRicCognome
            // 
            this.txtRicCognome.Location = new System.Drawing.Point(219, 106);
            this.txtRicCognome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRicCognome.Name = "txtRicCognome";
            this.txtRicCognome.Size = new System.Drawing.Size(160, 22);
            this.txtRicCognome.TabIndex = 5;
            // 
            // txtRicNome
            // 
            this.txtRicNome.Location = new System.Drawing.Point(219, 172);
            this.txtRicNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRicNome.Name = "txtRicNome";
            this.txtRicNome.Size = new System.Drawing.Size(160, 22);
            this.txtRicNome.TabIndex = 4;
            // 
            // nudRicMatricola
            // 
            this.nudRicMatricola.Location = new System.Drawing.Point(220, 48);
            this.nudRicMatricola.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudRicMatricola.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRicMatricola.Name = "nudRicMatricola";
            this.nudRicMatricola.Size = new System.Drawing.Size(160, 22);
            this.nudRicMatricola.TabIndex = 3;
            this.nudRicMatricola.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 176);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Ricerca Nome";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 110);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Ricerca Cognome";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ricerca Numero Matricola";
            // 
            // grpDatiStudente
            // 
            this.grpDatiStudente.Controls.Add(this.btnElimina);
            this.grpDatiStudente.Controls.Add(this.lblSpec);
            this.grpDatiStudente.Controls.Add(this.lblClasse);
            this.grpDatiStudente.Controls.Add(this.lblDataNascita);
            this.grpDatiStudente.Controls.Add(this.lblNome);
            this.grpDatiStudente.Controls.Add(this.lblCognome);
            this.grpDatiStudente.Controls.Add(this.lblMatricola);
            this.grpDatiStudente.Location = new System.Drawing.Point(447, 448);
            this.grpDatiStudente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDatiStudente.Name = "grpDatiStudente";
            this.grpDatiStudente.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDatiStudente.Size = new System.Drawing.Size(427, 331);
            this.grpDatiStudente.TabIndex = 4;
            this.grpDatiStudente.TabStop = false;
            this.grpDatiStudente.Text = "Dati Studente";
            // 
            // btnElimina
            // 
            this.btnElimina.BackColor = System.Drawing.Color.IndianRed;
            this.btnElimina.Location = new System.Drawing.Point(125, 252);
            this.btnElimina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(100, 28);
            this.btnElimina.TabIndex = 6;
            this.btnElimina.Text = "Elimina";
            this.btnElimina.UseVisualStyleBackColor = false;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // lblSpec
            // 
            this.lblSpec.AutoSize = true;
            this.lblSpec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpec.Location = new System.Drawing.Point(220, 158);
            this.lblSpec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpec.Name = "lblSpec";
            this.lblSpec.Size = new System.Drawing.Size(61, 17);
            this.lblSpec.TabIndex = 5;
            this.lblSpec.Text = "label15";
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasse.Location = new System.Drawing.Point(220, 106);
            this.lblClasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(61, 17);
            this.lblClasse.TabIndex = 4;
            this.lblClasse.Text = "label14";
            // 
            // lblDataNascita
            // 
            this.lblDataNascita.AutoSize = true;
            this.lblDataNascita.Location = new System.Drawing.Point(220, 50);
            this.lblDataNascita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataNascita.Name = "lblDataNascita";
            this.lblDataNascita.Size = new System.Drawing.Size(51, 16);
            this.lblDataNascita.TabIndex = 3;
            this.lblDataNascita.Text = "label13";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(20, 158);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 16);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "label12";
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCognome.Location = new System.Drawing.Point(20, 106);
            this.lblCognome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(61, 17);
            this.lblCognome.TabIndex = 1;
            this.lblCognome.Text = "label11";
            // 
            // lblMatricola
            // 
            this.lblMatricola.AutoSize = true;
            this.lblMatricola.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricola.ForeColor = System.Drawing.Color.Blue;
            this.lblMatricola.Location = new System.Drawing.Point(20, 50);
            this.lblMatricola.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatricola.Name = "lblMatricola";
            this.lblMatricola.Size = new System.Drawing.Size(61, 17);
            this.lblMatricola.TabIndex = 0;
            this.lblMatricola.Text = "label10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 772);
            this.Controls.Add(this.grpDatiStudente);
            this.Controls.Add(this.grbRicerca);
            this.Controls.Add(this.grbClasse);
            this.Controls.Add(this.grbStudente);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Esercizio 4 - Gestione STUDENTI / CLASSI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbStudente.ResumeLayout(false);
            this.grbStudente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatricola)).EndInit();
            this.grbClasse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasse)).EndInit();
            this.grbRicerca.ResumeLayout(false);
            this.grbRicerca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRicMatricola)).EndInit();
            this.grpDatiStudente.ResumeLayout(false);
            this.grpDatiStudente.PerformLayout();
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
        private System.Windows.Forms.GroupBox grbStudente;
        private System.Windows.Forms.NumericUpDown nudMatricola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.ComboBox cmbSpecializzazione;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDataNascita;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbClasse;
        private System.Windows.Forms.DataGridView dgvClasse;
        private System.Windows.Forms.GroupBox grbRicerca;
        private System.Windows.Forms.GroupBox grpDatiStudente;
        private System.Windows.Forms.Button brnRicerca;
        private System.Windows.Forms.TextBox txtRicCognome;
        private System.Windows.Forms.TextBox txtRicNome;
        private System.Windows.Forms.NumericUpDown nudRicMatricola;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Label lblSpec;
        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.Label lblDataNascita;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.Label lblMatricola;
        public System.Windows.Forms.ComboBox cmbClasse;
    }
}

