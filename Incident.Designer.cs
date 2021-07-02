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
            this.textSearch = new System.Windows.Forms.TextBox();
            this.cboColonne = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idcivilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datenaissanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.civilBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projetHeroDataSet_incident = new Avergers.ProjetHeroDataSet_incident();
            this.civilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetHeroDataSet5 = new Avergers.ProjetHeroDataSet5();
            this.civilTableAdapter = new Avergers.ProjetHeroDataSet5TableAdapters.CivilTableAdapter();
            this.projetHeroDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetHeroDataSet4 = new Avergers.ProjetHeroDataSet4();
            this.projetHeroDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetHeroDataSet = new Avergers.ProjetHeroDataSet();
            this.projetHeroDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.civilTableAdapter1 = new Avergers.ProjetHeroDataSet_incidentTableAdapters.CivilTableAdapter();
            this.projetHeroDataSet3 = new Avergers.ProjetHeroDataSet3();
            this.projetHeroDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetHeroDataSetIdIncident = new Avergers.ProjetHeroDataSetIdIncident();
            this.incidentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incidentTableAdapter = new Avergers.ProjetHeroDataSetIdIncidentTableAdapters.IncidentTableAdapter();
            this.GroupBoxInci.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet_incident)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetIdIncident)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxInci
            // 
            this.GroupBoxInci.Controls.Add(this.CmbNatureIncident);
            this.GroupBoxInci.Controls.Add(this.CmbSV);
            this.GroupBoxInci.Controls.Add(this.DateTimeIncident);
            this.GroupBoxInci.Controls.Add(this.AdresseIncident);
            this.GroupBoxInci.Controls.Add(this.label7);
            this.GroupBoxInci.Controls.Add(this.label8);
            this.GroupBoxInci.Controls.Add(this.label9);
            this.GroupBoxInci.Controls.Add(this.label11);
            this.GroupBoxInci.Location = new System.Drawing.Point(45, 333);
            this.GroupBoxInci.Name = "GroupBoxInci";
            this.GroupBoxInci.Size = new System.Drawing.Size(685, 194);
            this.GroupBoxInci.TabIndex = 14;
            this.GroupBoxInci.TabStop = false;
            this.GroupBoxInci.Text = "L\'incident";
            // 
            // CmbNatureIncident
            // 
            this.CmbNatureIncident.FormattingEnabled = true;
            this.CmbNatureIncident.Items.AddRange(new object[] {
            "Prise otage",
            "Braquage",
            "Coup de feu",
            "Autres"});
            this.CmbNatureIncident.Location = new System.Drawing.Point(136, 56);
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
            this.CmbSV.Location = new System.Drawing.Point(489, 109);
            this.CmbSV.Name = "CmbSV";
            this.CmbSV.Size = new System.Drawing.Size(179, 21);
            this.CmbSV.TabIndex = 11;
            // 
            // DateTimeIncident
            // 
            this.DateTimeIncident.Location = new System.Drawing.Point(489, 58);
            this.DateTimeIncident.Name = "DateTimeIncident";
            this.DateTimeIncident.Size = new System.Drawing.Size(179, 20);
            this.DateTimeIncident.TabIndex = 10;
            // 
            // AdresseIncident
            // 
            this.AdresseIncident.Location = new System.Drawing.Point(133, 112);
            this.AdresseIncident.Name = "AdresseIncident";
            this.AdresseIncident.Size = new System.Drawing.Size(139, 20);
            this.AdresseIncident.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(310, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Causé par un Super Vilain  ? ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(364, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Date de l\'incident  :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(68, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Adresse  :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Nature de l\'incident :";
            // 
            // CmdValider
            // 
            this.CmdValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdValider.Location = new System.Drawing.Point(181, 556);
            this.CmdValider.Name = "CmdValider";
            this.CmdValider.Size = new System.Drawing.Size(125, 43);
            this.CmdValider.TabIndex = 13;
            this.CmdValider.Text = "Valider";
            this.CmdValider.UseVisualStyleBackColor = true;
            this.CmdValider.Click += new System.EventHandler(this.CmdValider_Click);
            // 
            // CmdQuitter
            // 
            this.CmdQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdQuitter.Location = new System.Drawing.Point(484, 556);
            this.CmdQuitter.Name = "CmdQuitter";
            this.CmdQuitter.Size = new System.Drawing.Size(125, 43);
            this.CmdQuitter.TabIndex = 12;
            this.CmdQuitter.Text = "Quitter";
            this.CmdQuitter.UseVisualStyleBackColor = true;
            this.CmdQuitter.Click += new System.EventHandler(this.CmdQuitter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textSearch);
            this.groupBox1.Controls.Add(this.cboColonne);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(45, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 108);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Le déclarant";
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(460, 47);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(157, 20);
            this.textSearch.TabIndex = 4;
            this.textSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textSearch_KeyDown);
            // 
            // cboColonne
            // 
            this.cboColonne.FormattingEnabled = true;
            this.cboColonne.Items.AddRange(new object[] {
            "Id_Civil",
            "Nom",
            "Prenom",
            "Adresse",
            "Date_naissance"});
            this.cboColonne.Location = new System.Drawing.Point(166, 47);
            this.cboColonne.Name = "cboColonne";
            this.cboColonne.Size = new System.Drawing.Size(137, 21);
            this.cboColonne.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(373, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Recherche :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id du déclarant :";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcivilDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.datenaissanceDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.civilBindingSource1;
            this.dataGridView.Location = new System.Drawing.Point(45, 147);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(685, 150);
            this.dataGridView.TabIndex = 15;
            // 
            // idcivilDataGridViewTextBoxColumn
            // 
            this.idcivilDataGridViewTextBoxColumn.DataPropertyName = "Id_civil";
            this.idcivilDataGridViewTextBoxColumn.HeaderText = "Id du civil";
            this.idcivilDataGridViewTextBoxColumn.Name = "idcivilDataGridViewTextBoxColumn";
            this.idcivilDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datenaissanceDataGridViewTextBoxColumn
            // 
            this.datenaissanceDataGridViewTextBoxColumn.DataPropertyName = "Date_naissance";
            this.datenaissanceDataGridViewTextBoxColumn.HeaderText = "Date de naissance";
            this.datenaissanceDataGridViewTextBoxColumn.Name = "datenaissanceDataGridViewTextBoxColumn";
            this.datenaissanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // civilBindingSource1
            // 
            this.civilBindingSource1.DataMember = "Civil";
            this.civilBindingSource1.DataSource = this.projetHeroDataSet_incident;
            // 
            // projetHeroDataSet_incident
            // 
            this.projetHeroDataSet_incident.DataSetName = "ProjetHeroDataSet_incident";
            this.projetHeroDataSet_incident.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // civilBindingSource
            // 
            this.civilBindingSource.DataMember = "Civil";
            this.civilBindingSource.DataSource = this.projetHeroDataSet5;
            // 
            // projetHeroDataSet5
            // 
            this.projetHeroDataSet5.DataSetName = "ProjetHeroDataSet5";
            this.projetHeroDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // civilTableAdapter
            // 
            this.civilTableAdapter.ClearBeforeFill = true;
            // 
            // projetHeroDataSet5BindingSource
            // 
            this.projetHeroDataSet5BindingSource.DataSource = this.projetHeroDataSet5;
            this.projetHeroDataSet5BindingSource.Position = 0;
            // 
            // projetHeroDataSet4
            // 
            this.projetHeroDataSet4.DataSetName = "ProjetHeroDataSet4";
            this.projetHeroDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projetHeroDataSet4BindingSource
            // 
            this.projetHeroDataSet4BindingSource.DataSource = this.projetHeroDataSet4;
            this.projetHeroDataSet4BindingSource.Position = 0;
            // 
            // projetHeroDataSet
            // 
            this.projetHeroDataSet.DataSetName = "ProjetHeroDataSet";
            this.projetHeroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projetHeroDataSetBindingSource
            // 
            this.projetHeroDataSetBindingSource.DataSource = this.projetHeroDataSet;
            this.projetHeroDataSetBindingSource.Position = 0;
            // 
            // civilTableAdapter1
            // 
            this.civilTableAdapter1.ClearBeforeFill = true;
            // 
            // projetHeroDataSet3
            // 
            this.projetHeroDataSet3.DataSetName = "ProjetHeroDataSet3";
            this.projetHeroDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projetHeroDataSet3BindingSource
            // 
            this.projetHeroDataSet3BindingSource.DataSource = this.projetHeroDataSet3;
            this.projetHeroDataSet3BindingSource.Position = 0;
            // 
            // projetHeroDataSetIdIncident
            // 
            this.projetHeroDataSetIdIncident.DataSetName = "ProjetHeroDataSetIdIncident";
            this.projetHeroDataSetIdIncident.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // incidentBindingSource
            // 
            this.incidentBindingSource.DataMember = "Incident";
            this.incidentBindingSource.DataSource = this.projetHeroDataSetIdIncident;
            // 
            // incidentTableAdapter
            // 
            this.incidentTableAdapter.ClearBeforeFill = true;
            // 
            // Incident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Avergers.Properties.Resources.Avengerslogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(791, 635);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.GroupBoxInci);
            this.Controls.Add(this.CmdValider);
            this.Controls.Add(this.CmdQuitter);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Incident";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incident";
            this.Load += new System.EventHandler(this.Incident_Load);
            this.GroupBoxInci.ResumeLayout(false);
            this.GroupBoxInci.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet_incident)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetIdIncident)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.ComboBox cboColonne;
        private System.Windows.Forms.DataGridView dataGridView;
        private ProjetHeroDataSet5 projetHeroDataSet5;
        private System.Windows.Forms.BindingSource civilBindingSource;
        private ProjetHeroDataSet5TableAdapters.CivilTableAdapter civilTableAdapter;
        private System.Windows.Forms.BindingSource projetHeroDataSetBindingSource;
        private ProjetHeroDataSet projetHeroDataSet;
        private System.Windows.Forms.BindingSource projetHeroDataSet5BindingSource;
        private ProjetHeroDataSet4 projetHeroDataSet4;
        private System.Windows.Forms.BindingSource projetHeroDataSet4BindingSource;
        private ProjetHeroDataSet_incident projetHeroDataSet_incident;
        private System.Windows.Forms.BindingSource civilBindingSource1;
        private ProjetHeroDataSet_incidentTableAdapters.CivilTableAdapter civilTableAdapter1;
        private System.Windows.Forms.BindingSource projetHeroDataSet3BindingSource;
        private ProjetHeroDataSet3 projetHeroDataSet3;
        private ProjetHeroDataSetIdIncident projetHeroDataSetIdIncident;
        private System.Windows.Forms.BindingSource incidentBindingSource;
        private ProjetHeroDataSetIdIncidentTableAdapters.IncidentTableAdapter incidentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcivilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datenaissanceDataGridViewTextBoxColumn;
    }
}