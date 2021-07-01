namespace Avergers
{
    partial class Incident
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GroupBoxInci = new System.Windows.Forms.GroupBox();
            this.CmbInterSH = new System.Windows.Forms.ComboBox();
            this.CmbTypeLitige = new System.Windows.Forms.ComboBox();
            this.CmbSV = new System.Windows.Forms.ComboBox();
            this.DateTimeIncident = new System.Windows.Forms.DateTimePicker();
            this.AdresseIncident = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CmdValider = new System.Windows.Forms.Button();
            this.CmdQuitter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Recherche = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CmbSelecRech = new System.Windows.Forms.ComboBox();
            this.projetHeroDataSetCivilDatagriedIncident = new Avergers.ProjetHeroDataSetCivilDatagriedIncident();
            this.civilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.civilTableAdapter = new Avergers.ProjetHeroDataSetCivilDatagriedIncidentTableAdapters.CivilTableAdapter();
            this.idcivilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datenaissanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBoxInci.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetCivilDatagriedIncident)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxInci
            // 
            this.GroupBoxInci.Controls.Add(this.CmbInterSH);
            this.GroupBoxInci.Controls.Add(this.CmbTypeLitige);
            this.GroupBoxInci.Controls.Add(this.CmbSV);
            this.GroupBoxInci.Controls.Add(this.DateTimeIncident);
            this.GroupBoxInci.Controls.Add(this.AdresseIncident);
            this.GroupBoxInci.Controls.Add(this.label7);
            this.GroupBoxInci.Controls.Add(this.label8);
            this.GroupBoxInci.Controls.Add(this.label9);
            this.GroupBoxInci.Controls.Add(this.label10);
            this.GroupBoxInci.Controls.Add(this.label11);
            this.GroupBoxInci.Location = new System.Drawing.Point(12, 250);
            this.GroupBoxInci.Name = "GroupBoxInci";
            this.GroupBoxInci.Size = new System.Drawing.Size(685, 152);
            this.GroupBoxInci.TabIndex = 14;
            this.GroupBoxInci.TabStop = false;
            this.GroupBoxInci.Text = "L\'incident";
            // 
            // CmbInterSH
            // 
            this.CmbInterSH.FormattingEnabled = true;
            this.CmbInterSH.Items.AddRange(new object[] {
            "Oui",
            "Non"});
            this.CmbInterSH.Location = new System.Drawing.Point(109, 103);
            this.CmbInterSH.Name = "CmbInterSH";
            this.CmbInterSH.Size = new System.Drawing.Size(139, 21);
            this.CmbInterSH.TabIndex = 13;
            // 
            // CmbTypeLitige
            // 
            this.CmbTypeLitige.FormattingEnabled = true;
            this.CmbTypeLitige.Items.AddRange(new object[] {
            "Prise d\'otage",
            "Braquage",
            "Coup de feu",
            "Autres"});
            this.CmbTypeLitige.Location = new System.Drawing.Point(109, 26);
            this.CmbTypeLitige.Name = "CmbTypeLitige";
            this.CmbTypeLitige.Size = new System.Drawing.Size(139, 21);
            this.CmbTypeLitige.TabIndex = 12;
            // 
            // CmbSV
            // 
            this.CmbSV.FormattingEnabled = true;
            this.CmbSV.Items.AddRange(new object[] {
            "Oui",
            "Non"});
            this.CmbSV.Location = new System.Drawing.Point(514, 103);
            this.CmbSV.Name = "CmbSV";
            this.CmbSV.Size = new System.Drawing.Size(123, 21);
            this.CmbSV.TabIndex = 11;
            // 
            // DateTimeIncident
            // 
            this.DateTimeIncident.Location = new System.Drawing.Point(514, 63);
            this.DateTimeIncident.Name = "DateTimeIncident";
            this.DateTimeIncident.Size = new System.Drawing.Size(123, 20);
            this.DateTimeIncident.TabIndex = 10;
            // 
            // AdresseIncident
            // 
            this.AdresseIncident.Location = new System.Drawing.Point(514, 27);
            this.AdresseIncident.Name = "AdresseIncident";
            this.AdresseIncident.Size = new System.Drawing.Size(123, 20);
            this.AdresseIncident.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Causé par un Super Vilain identifié ? ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(410, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Date de l\'incident  :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(454, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Adresse  :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(209, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Nécessite l\'intervention s\'un Super-Héros ?";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Type d\'incident :";
            // 
            // CmdValider
            // 
            this.CmdValider.Location = new System.Drawing.Point(123, 418);
            this.CmdValider.Name = "CmdValider";
            this.CmdValider.Size = new System.Drawing.Size(125, 43);
            this.CmdValider.TabIndex = 13;
            this.CmdValider.Text = "Valider";
            this.CmdValider.UseVisualStyleBackColor = true;
            // 
            // CmdQuitter
            // 
            this.CmdQuitter.Location = new System.Drawing.Point(501, 418);
            this.CmdQuitter.Name = "CmdQuitter";
            this.CmdQuitter.Size = new System.Drawing.Size(125, 43);
            this.CmdQuitter.TabIndex = 12;
            this.CmdQuitter.Text = "Quitter";
            this.CmdQuitter.UseVisualStyleBackColor = true;
            this.CmdQuitter.Click += new System.EventHandler(this.CmdQuitter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CmbSelecRech);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.Recherche);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 223);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Le déclarant";
            // 
            // Recherche
            // 
            this.Recherche.Location = new System.Drawing.Point(448, 26);
            this.Recherche.Name = "Recherche";
            this.Recherche.Size = new System.Drawing.Size(126, 20);
            this.Recherche.TabIndex = 8;
            this.Recherche.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Recherche_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Définition de la recherche :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sélection de recherche :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcivilDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.datenaissanceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.civilBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(663, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // CmbSelecRech
            // 
            this.CmbSelecRech.FormattingEnabled = true;
            this.CmbSelecRech.Items.AddRange(new object[] {
            "Id_civil",
            "Nom",
            "Prenom",
            "Adresse",
            "Date_naissance"});
            this.CmbSelecRech.Location = new System.Drawing.Point(181, 26);
            this.CmbSelecRech.Name = "CmbSelecRech";
            this.CmbSelecRech.Size = new System.Drawing.Size(99, 21);
            this.CmbSelecRech.TabIndex = 10;
            // 
            // projetHeroDataSetCivilDatagriedIncident
            // 
            this.projetHeroDataSetCivilDatagriedIncident.DataSetName = "ProjetHeroDataSetCivilDatagriedIncident";
            this.projetHeroDataSetCivilDatagriedIncident.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // civilBindingSource
            // 
            this.civilBindingSource.DataMember = "Civil";
            this.civilBindingSource.DataSource = this.projetHeroDataSetCivilDatagriedIncident;
            // 
            // civilTableAdapter
            // 
            this.civilTableAdapter.ClearBeforeFill = true;
            // 
            // idcivilDataGridViewTextBoxColumn
            // 
            this.idcivilDataGridViewTextBoxColumn.DataPropertyName = "Id_civil";
            this.idcivilDataGridViewTextBoxColumn.HeaderText = "Id_civil";
            this.idcivilDataGridViewTextBoxColumn.Name = "idcivilDataGridViewTextBoxColumn";
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            // 
            // datenaissanceDataGridViewTextBoxColumn
            // 
            this.datenaissanceDataGridViewTextBoxColumn.DataPropertyName = "Date_naissance";
            this.datenaissanceDataGridViewTextBoxColumn.HeaderText = "Date_naissance";
            this.datenaissanceDataGridViewTextBoxColumn.Name = "datenaissanceDataGridViewTextBoxColumn";
            // 
            // Incident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 469);
            this.Controls.Add(this.GroupBoxInci);
            this.Controls.Add(this.CmdValider);
            this.Controls.Add(this.CmdQuitter);
            this.Controls.Add(this.groupBox1);
            this.Name = "Incident";
            this.Text = "Incident";
            this.Load += new System.EventHandler(this.Incident_Load);
            this.GroupBoxInci.ResumeLayout(false);
            this.GroupBoxInci.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetCivilDatagriedIncident)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxInci;
        private System.Windows.Forms.ComboBox CmbInterSH;
        private System.Windows.Forms.ComboBox CmbTypeLitige;
        private System.Windows.Forms.ComboBox CmbSV;
        private System.Windows.Forms.DateTimePicker DateTimeIncident;
        private System.Windows.Forms.TextBox AdresseIncident;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button CmdValider;
        private System.Windows.Forms.Button CmdQuitter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Recherche;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbSelecRech;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjetHeroDataSetCivilDatagriedIncident projetHeroDataSetCivilDatagriedIncident;
        private System.Windows.Forms.BindingSource civilBindingSource;
        private ProjetHeroDataSetCivilDatagriedIncidentTableAdapters.CivilTableAdapter civilTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcivilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datenaissanceDataGridViewTextBoxColumn;
    }
}