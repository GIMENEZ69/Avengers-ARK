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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Incident));
            this.GroupBoxInci = new System.Windows.Forms.GroupBox();
            this.IdIncident = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IdCivilRattache = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbNatureIncident = new System.Windows.Forms.ComboBox();
            this.CmbSV = new System.Windows.Forms.ComboBox();
            this.DateTimeIncident = new System.Windows.Forms.DateTimePicker();
            this.AdresseIncident = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CmdValider = new System.Windows.Forms.Button();
            this.CmdQuitter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idcivilDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datenaissanceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.civilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetHeroDataSetCivilDatagriedIncident = new Avergers.ProjetHeroDataSetCivilDatagriedIncident();
            this.CmdValidDeclarant = new System.Windows.Forms.Button();
            this.CmbSelecRech = new System.Windows.Forms.ComboBox();
            this.Recherche = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.civilTableAdapter = new Avergers.ProjetHeroDataSetCivilDatagriedIncidentTableAdapters.CivilTableAdapter();
            this.projetHeroDataSetCivil = new Avergers.ProjetHeroDataSetCivil();
            this.projetHeroDataSetCivilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GroupBoxInci.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetCivilDatagriedIncident)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetCivil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetCivilBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxInci
            // 
            this.GroupBoxInci.Controls.Add(this.IdIncident);
            this.GroupBoxInci.Controls.Add(this.label4);
            this.GroupBoxInci.Controls.Add(this.IdCivilRattache);
            this.GroupBoxInci.Controls.Add(this.label2);
            this.GroupBoxInci.Controls.Add(this.CmbNatureIncident);
            this.GroupBoxInci.Controls.Add(this.CmbSV);
            this.GroupBoxInci.Controls.Add(this.DateTimeIncident);
            this.GroupBoxInci.Controls.Add(this.AdresseIncident);
            this.GroupBoxInci.Controls.Add(this.label7);
            this.GroupBoxInci.Controls.Add(this.label8);
            this.GroupBoxInci.Controls.Add(this.label9);
            this.GroupBoxInci.Controls.Add(this.label11);
            this.GroupBoxInci.Location = new System.Drawing.Point(12, 298);
            this.GroupBoxInci.Name = "GroupBoxInci";
            this.GroupBoxInci.Size = new System.Drawing.Size(685, 207);
            this.GroupBoxInci.TabIndex = 14;
            this.GroupBoxInci.TabStop = false;
            this.GroupBoxInci.Text = "L\'incident";
            // 
            // IdIncident
            // 
            this.IdIncident.Location = new System.Drawing.Point(122, 62);
            this.IdIncident.Name = "IdIncident";
            this.IdIncident.Size = new System.Drawing.Size(138, 20);
            this.IdIncident.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "ID de l\'incident :";
            // 
            // IdCivilRattache
            // 
            this.IdCivilRattache.Location = new System.Drawing.Point(122, 30);
            this.IdCivilRattache.Name = "IdCivilRattache";
            this.IdCivilRattache.Size = new System.Drawing.Size(138, 20);
            this.IdCivilRattache.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID du Civil rattaché :";
            // 
            // CmbNatureIncident
            // 
            this.CmbNatureIncident.FormattingEnabled = true;
            this.CmbNatureIncident.Items.AddRange(new object[] {
            "Prise d otage",
            "Braquage",
            "Coup de feu",
            "Autres"});
            this.CmbNatureIncident.Location = new System.Drawing.Point(124, 97);
            this.CmbNatureIncident.Name = "CmbNatureIncident";
            this.CmbNatureIncident.Size = new System.Drawing.Size(139, 21);
            this.CmbNatureIncident.TabIndex = 12;
            // 
            // CmbSV
            // 
            this.CmbSV.FormattingEnabled = true;
            this.CmbSV.Items.AddRange(new object[] {
            "Oui",
            "Non"});
            this.CmbSV.Location = new System.Drawing.Point(470, 110);
            this.CmbSV.Name = "CmbSV";
            this.CmbSV.Size = new System.Drawing.Size(163, 21);
            this.CmbSV.TabIndex = 11;
            // 
            // DateTimeIncident
            // 
            this.DateTimeIncident.Location = new System.Drawing.Point(470, 65);
            this.DateTimeIncident.Name = "DateTimeIncident";
            this.DateTimeIncident.Size = new System.Drawing.Size(163, 20);
            this.DateTimeIncident.TabIndex = 10;
            // 
            // AdresseIncident
            // 
            this.AdresseIncident.Location = new System.Drawing.Point(124, 138);
            this.AdresseIncident.Multiline = true;
            this.AdresseIncident.Name = "AdresseIncident";
            this.AdresseIncident.Size = new System.Drawing.Size(139, 53);
            this.AdresseIncident.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(284, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Causé par un Super Vilain identifié ? ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(366, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Date de l\'incident  :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Adresse  :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Nature de l\'incident :";
            // 
            // CmdValider
            // 
            this.CmdValider.Location = new System.Drawing.Point(109, 524);
            this.CmdValider.Name = "CmdValider";
            this.CmdValider.Size = new System.Drawing.Size(125, 43);
            this.CmdValider.TabIndex = 13;
            this.CmdValider.Text = "Valider";
            this.CmdValider.UseVisualStyleBackColor = true;
            this.CmdValider.Click += new System.EventHandler(this.CmdValider_Click);
            // 
            // CmdQuitter
            // 
            this.CmdQuitter.Location = new System.Drawing.Point(482, 524);
            this.CmdQuitter.Name = "CmdQuitter";
            this.CmdQuitter.Size = new System.Drawing.Size(125, 43);
            this.CmdQuitter.TabIndex = 12;
            this.CmdQuitter.Text = "Quitter";
            this.CmdQuitter.UseVisualStyleBackColor = true;
            this.CmdQuitter.Click += new System.EventHandler(this.CmdQuitter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.CmdValidDeclarant);
            this.groupBox1.Controls.Add(this.CmbSelecRech);
            this.groupBox1.Controls.Add(this.Recherche);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 271);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Le déclarant";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcivilDataGridViewTextBoxColumn1,
            this.nomDataGridViewTextBoxColumn1,
            this.prenomDataGridViewTextBoxColumn1,
            this.adresseDataGridViewTextBoxColumn1,
            this.datenaissanceDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.civilBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 53);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(659, 163);
            this.dataGridView2.TabIndex = 16;
            // 
            // idcivilDataGridViewTextBoxColumn1
            // 
            this.idcivilDataGridViewTextBoxColumn1.DataPropertyName = "Id_civil";
            this.idcivilDataGridViewTextBoxColumn1.HeaderText = "Id_civil";
            this.idcivilDataGridViewTextBoxColumn1.Name = "idcivilDataGridViewTextBoxColumn1";
            // 
            // nomDataGridViewTextBoxColumn1
            // 
            this.nomDataGridViewTextBoxColumn1.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn1.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn1.Name = "nomDataGridViewTextBoxColumn1";
            // 
            // prenomDataGridViewTextBoxColumn1
            // 
            this.prenomDataGridViewTextBoxColumn1.DataPropertyName = "Prenom";
            this.prenomDataGridViewTextBoxColumn1.HeaderText = "Prenom";
            this.prenomDataGridViewTextBoxColumn1.Name = "prenomDataGridViewTextBoxColumn1";
            // 
            // adresseDataGridViewTextBoxColumn1
            // 
            this.adresseDataGridViewTextBoxColumn1.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn1.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn1.Name = "adresseDataGridViewTextBoxColumn1";
            // 
            // datenaissanceDataGridViewTextBoxColumn1
            // 
            this.datenaissanceDataGridViewTextBoxColumn1.DataPropertyName = "Date_naissance";
            this.datenaissanceDataGridViewTextBoxColumn1.HeaderText = "Date_naissance";
            this.datenaissanceDataGridViewTextBoxColumn1.Name = "datenaissanceDataGridViewTextBoxColumn1";
            // 
            // civilBindingSource
            // 
            this.civilBindingSource.DataMember = "Civil";
            this.civilBindingSource.DataSource = this.projetHeroDataSetCivilDatagriedIncident;
            // 
            // projetHeroDataSetCivilDatagriedIncident
            // 
            this.projetHeroDataSetCivilDatagriedIncident.DataSetName = "ProjetHeroDataSetCivilDatagriedIncident";
            this.projetHeroDataSetCivilDatagriedIncident.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CmdValidDeclarant
            // 
            this.CmdValidDeclarant.Location = new System.Drawing.Point(273, 222);
            this.CmdValidDeclarant.Name = "CmdValidDeclarant";
            this.CmdValidDeclarant.Size = new System.Drawing.Size(125, 43);
            this.CmdValidDeclarant.TabIndex = 15;
            this.CmdValidDeclarant.Text = "Valider le déclarant";
            this.CmdValidDeclarant.UseVisualStyleBackColor = true;
            this.CmdValidDeclarant.Click += new System.EventHandler(this.CmdValidDeclarant_Click);
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
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saisir votre recherche :";
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
            // civilTableAdapter
            // 
            this.civilTableAdapter.ClearBeforeFill = true;
            // 
            // projetHeroDataSetCivil
            // 
            this.projetHeroDataSetCivil.DataSetName = "ProjetHeroDataSetCivil";
            this.projetHeroDataSetCivil.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projetHeroDataSetCivilBindingSource
            // 
            this.projetHeroDataSetCivilBindingSource.DataSource = this.projetHeroDataSetCivil;
            this.projetHeroDataSetCivilBindingSource.Position = 0;
            // 
            // Incident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 579);
            this.Controls.Add(this.GroupBoxInci);
            this.Controls.Add(this.CmdValider);
            this.Controls.Add(this.CmdQuitter);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Incident";
            this.Text = "Incident";
            this.Load += new System.EventHandler(this.Incident_Load);
            this.GroupBoxInci.ResumeLayout(false);
            this.GroupBoxInci.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetCivilDatagriedIncident)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetCivil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetCivilBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxInci;
        private System.Windows.Forms.ComboBox CmbNatureIncident;
        private System.Windows.Forms.ComboBox CmbSV;
        private System.Windows.Forms.DateTimePicker DateTimeIncident;
        private System.Windows.Forms.TextBox AdresseIncident;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button CmdValider;
        private System.Windows.Forms.Button CmdQuitter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Recherche;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbSelecRech;
        private ProjetHeroDataSetCivilDatagriedIncident projetHeroDataSetCivilDatagriedIncident;
        private System.Windows.Forms.BindingSource civilBindingSource;
        private ProjetHeroDataSetCivilDatagriedIncidentTableAdapters.CivilTableAdapter civilTableAdapter;
        private System.Windows.Forms.TextBox IdIncident;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IdCivilRattache;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CmdValidDeclarant;
        private ProjetHeroDataSetCivil projetHeroDataSetCivil;
        private System.Windows.Forms.BindingSource projetHeroDataSetCivilBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcivilDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datenaissanceDataGridViewTextBoxColumn1;
    }
}