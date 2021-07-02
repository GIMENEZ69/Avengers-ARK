using System;

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
            this.CmbTypeIncident = new System.Windows.Forms.ComboBox();
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
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idcivilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datenaissanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.civilBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.projetHeroDataSet17 = new Avergers.ProjetHeroDataSet17();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.search = new System.Windows.Forms.Label();
            this.ColonneId = new System.Windows.Forms.Label();
            this.civilBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.projetHeroDataSetok = new Avergers.ProjetHeroDataSetok();
            this.civilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetHeroDataSetlabraize = new Avergers.ProjetHeroDataSetlabraize();
            this.civilBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.projetHeroDataSet16 = new Avergers.ProjetHeroDataSet16();
            this.civilBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projetHeroDataSetnum = new Avergers.ProjetHeroDataSetnum();
            this.civilTableAdapter = new Avergers.ProjetHeroDataSetlabraizeTableAdapters.CivilTableAdapter();
            this.civilTableAdapter1 = new Avergers.ProjetHeroDataSetnumTableAdapters.CivilTableAdapter();
            this.civilTableAdapter2 = new Avergers.ProjetHeroDataSet16TableAdapters.CivilTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.civilTableAdapter3 = new Avergers.ProjetHeroDataSetokTableAdapters.CivilTableAdapter();
            this.civilTableAdapter4 = new Avergers.ProjetHeroDataSet17TableAdapters.CivilTableAdapter();
            this.GroupBoxInci.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetlabraize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetnum)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxInci
            // 
            this.GroupBoxInci.Controls.Add(this.CmbTypeIncident);
            this.GroupBoxInci.Controls.Add(this.CmbSV);
            this.GroupBoxInci.Controls.Add(this.DateTimeIncident);
            this.GroupBoxInci.Controls.Add(this.AdresseIncident);
            this.GroupBoxInci.Controls.Add(this.label7);
            this.GroupBoxInci.Controls.Add(this.label8);
            this.GroupBoxInci.Controls.Add(this.label9);
            this.GroupBoxInci.Controls.Add(this.label11);
            this.GroupBoxInci.Location = new System.Drawing.Point(47, 337);
            this.GroupBoxInci.Name = "GroupBoxInci";
            this.GroupBoxInci.Size = new System.Drawing.Size(685, 194);
            this.GroupBoxInci.TabIndex = 14;
            this.GroupBoxInci.TabStop = false;
            this.GroupBoxInci.Text = "L\'incident";
            // 
            // CmbTypeIncident
            // 
            this.CmbTypeIncident.FormattingEnabled = true;
            this.CmbTypeIncident.Items.AddRange(new object[] {
            "Prise d\'otage",
            "Braquage",
            "Coup de feu",
            "Autres"});
            this.CmbTypeIncident.Location = new System.Drawing.Point(128, 21);
            this.CmbTypeIncident.Name = "CmbTypeIncident";
            this.CmbTypeIncident.Size = new System.Drawing.Size(139, 21);
            this.CmbTypeIncident.TabIndex = 12;
            // 
            // CmbSV
            // 
            this.CmbSV.FormattingEnabled = true;
            this.CmbSV.Items.AddRange(new object[] {
            "Oui",
            "Non"});
            this.CmbSV.Location = new System.Drawing.Point(217, 123);
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
            this.AdresseIncident.TextChanged += new System.EventHandler(this.AdresseIncident_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 131);
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Nature de l\'incident :";
            // 
            // CmdValider
            // 
            this.CmdValider.Location = new System.Drawing.Point(106, 570);
            this.CmdValider.Name = "CmdValider";
            this.CmdValider.Size = new System.Drawing.Size(125, 43);
            this.CmdValider.TabIndex = 13;
            this.CmdValider.Text = "Valider";
            this.CmdValider.UseVisualStyleBackColor = true;
            this.CmdValider.Click += new System.EventHandler(this.CmdValider_Click);
            // 
            // CmdQuitter
            // 
            this.CmdQuitter.Location = new System.Drawing.Point(481, 570);
            this.CmdQuitter.Name = "CmdQuitter";
            this.CmdQuitter.Size = new System.Drawing.Size(125, 43);
            this.CmdQuitter.TabIndex = 12;
            this.CmdQuitter.Text = "Quitter";
            this.CmdQuitter.UseVisualStyleBackColor = true;
            this.CmdQuitter.Click += new System.EventHandler(this.CmdQuitter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsearch);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.ColonneId);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 261);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Le déclarant";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(519, 20);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(119, 20);
            this.txtsearch.TabIndex = 11;
            this.txtsearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsearch_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcivilDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.datenaissanceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.civilBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(55, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(584, 169);
            this.dataGridView1.TabIndex = 10;
            // 
            // idcivilDataGridViewTextBoxColumn
            // 
            this.idcivilDataGridViewTextBoxColumn.DataPropertyName = "Id_civil";
            this.idcivilDataGridViewTextBoxColumn.HeaderText = "Id civil";
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
            this.datenaissanceDataGridViewTextBoxColumn.HeaderText = "Date naissance";
            this.datenaissanceDataGridViewTextBoxColumn.Name = "datenaissanceDataGridViewTextBoxColumn";
            this.datenaissanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // civilBindingSource4
            // 
            this.civilBindingSource4.DataMember = "Civil";
            this.civilBindingSource4.DataSource = this.projetHeroDataSet17;
            // 
            // projetHeroDataSet17
            // 
            this.projetHeroDataSet17.DataSetName = "ProjetHeroDataSet17";
            this.projetHeroDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nom",
            "Prenom",
            "Adresse"});
            this.comboBox1.Location = new System.Drawing.Point(189, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(79, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.Location = new System.Drawing.Point(365, 26);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(128, 13);
            this.search.TabIndex = 2;
            this.search.Text = "Definition de la recherche";
            // 
            // ColonneId
            // 
            this.ColonneId.AutoSize = true;
            this.ColonneId.Location = new System.Drawing.Point(52, 29);
            this.ColonneId.Name = "ColonneId";
            this.ColonneId.Size = new System.Drawing.Size(120, 13);
            this.ColonneId.TabIndex = 0;
            this.ColonneId.Text = "Selection de recherche:";
            // 
            // civilBindingSource3
            // 
            this.civilBindingSource3.DataMember = "Civil";
            this.civilBindingSource3.DataSource = this.projetHeroDataSetok;
            // 
            // projetHeroDataSetok
            // 
            this.projetHeroDataSetok.DataSetName = "ProjetHeroDataSetok";
            this.projetHeroDataSetok.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // civilBindingSource
            // 
            this.civilBindingSource.DataMember = "Civil";
            this.civilBindingSource.DataSource = this.projetHeroDataSetlabraize;
            // 
            // projetHeroDataSetlabraize
            // 
            this.projetHeroDataSetlabraize.DataSetName = "ProjetHeroDataSetlabraize";
            this.projetHeroDataSetlabraize.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // civilBindingSource2
            // 
            this.civilBindingSource2.DataMember = "Civil";
            this.civilBindingSource2.DataSource = this.projetHeroDataSet16;
            // 
            // projetHeroDataSet16
            // 
            this.projetHeroDataSet16.DataSetName = "ProjetHeroDataSet16";
            this.projetHeroDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // civilBindingSource1
            // 
            this.civilBindingSource1.DataMember = "Civil";
            this.civilBindingSource1.DataSource = this.projetHeroDataSetnum;
            // 
            // projetHeroDataSetnum
            // 
            this.projetHeroDataSetnum.DataSetName = "ProjetHeroDataSetnum";
            this.projetHeroDataSetnum.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // civilTableAdapter
            // 
            this.civilTableAdapter.ClearBeforeFill = true;
            // 
            // civilTableAdapter1
            // 
            this.civilTableAdapter1.ClearBeforeFill = true;
            // 
            // civilTableAdapter2
            // 
            this.civilTableAdapter2.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(762, 25);
            this.fillByToolStrip.TabIndex = 15;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // civilTableAdapter3
            // 
            this.civilTableAdapter3.ClearBeforeFill = true;
            // 
            // civilTableAdapter4
            // 
            this.civilTableAdapter4.ClearBeforeFill = true;
            // 
            // Incident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 672);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.GroupBoxInci);
            this.Controls.Add(this.CmdValider);
            this.Controls.Add(this.CmdQuitter);
            this.Controls.Add(this.groupBox1);
            this.Name = "Incident";
            this.Text = "Incident";
            this.Load += new System.EventHandler(this.Incident_Load_1);
            this.GroupBoxInci.ResumeLayout(false);
            this.GroupBoxInci.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetlabraize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetnum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxInci;
        private System.Windows.Forms.ComboBox CmbTypeIncident;
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
        private System.Windows.Forms.Label search;
        private System.Windows.Forms.Label ColonneId;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjetHeroDataSetlabraize projetHeroDataSetlabraize;
        private System.Windows.Forms.BindingSource civilBindingSource;
        private ProjetHeroDataSetlabraizeTableAdapters.CivilTableAdapter civilTableAdapter;
        private ProjetHeroDataSetnum projetHeroDataSetnum;
        private System.Windows.Forms.BindingSource civilBindingSource1;
        private ProjetHeroDataSetnumTableAdapters.CivilTableAdapter civilTableAdapter1;
        private ProjetHeroDataSet16 projetHeroDataSet16;
        private System.Windows.Forms.BindingSource civilBindingSource2;
        private ProjetHeroDataSet16TableAdapters.CivilTableAdapter civilTableAdapter2;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcivilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datenaissanceDataGridViewTextBoxColumn;
        private ProjetHeroDataSetok projetHeroDataSetok;
        private System.Windows.Forms.BindingSource civilBindingSource3;
        private ProjetHeroDataSetokTableAdapters.CivilTableAdapter civilTableAdapter3;
        private ProjetHeroDataSet17 projetHeroDataSet17;
        private System.Windows.Forms.BindingSource civilBindingSource4;
        private ProjetHeroDataSet17TableAdapters.CivilTableAdapter civilTableAdapter4;

        public EventHandler txtsearch_TextChanged { get; private set; }
    }
}