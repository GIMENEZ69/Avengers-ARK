﻿
namespace Avergers
{
    partial class Civils
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CmdRead = new System.Windows.Forms.Button();
            this.CmdSupp = new System.Windows.Forms.Button();
            this.CmdMaj = new System.Windows.Forms.Button();
            this.CmdCréer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Datemodif2 = new System.Windows.Forms.DateTimePicker();
            this.Dateajout2 = new System.Windows.Forms.DateTimePicker();
            this.Ddn2 = new System.Windows.Forms.DateTimePicker();
            this.Adresse = new System.Windows.Forms.TextBox();
            this.Prenom = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idcivilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datenaissanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datedecesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateajoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datemodificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.civilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetHeroDataSet = new Avergers.ProjetHeroDataSet();
            this.civilsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.avengersDBDataSetGridViewCivils = new Avergers.AvengersDBDataSetGridViewCivils();
            this.civilsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CmdQuitter = new System.Windows.Forms.Button();
            this.civilsTableAdapter = new Avergers.AvengersDBDataSetGridViewCivilsTableAdapters.CivilsTableAdapter();
            this.civilTableAdapter = new Avergers.ProjetHeroDataSetTableAdapters.CivilTableAdapter();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avengersDBDataSetGridViewCivils)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CmdRead);
            this.groupBox2.Controls.Add(this.CmdSupp);
            this.groupBox2.Controls.Add(this.CmdMaj);
            this.groupBox2.Controls.Add(this.CmdCréer);
            this.groupBox2.Location = new System.Drawing.Point(38, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(950, 79);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opérations";
            // 
            // CmdRead
            // 
            this.CmdRead.Location = new System.Drawing.Point(299, 23);
            this.CmdRead.Name = "CmdRead";
            this.CmdRead.Size = new System.Drawing.Size(109, 40);
            this.CmdRead.TabIndex = 3;
            this.CmdRead.Text = "Lire le civil";
            this.CmdRead.UseVisualStyleBackColor = true;
            this.CmdRead.Click += new System.EventHandler(this.CmdRead_Click);
            // 
            // CmdSupp
            // 
            this.CmdSupp.Location = new System.Drawing.Point(759, 24);
            this.CmdSupp.Name = "CmdSupp";
            this.CmdSupp.Size = new System.Drawing.Size(109, 40);
            this.CmdSupp.TabIndex = 2;
            this.CmdSupp.Text = "Supprimer le Civil";
            this.CmdSupp.UseVisualStyleBackColor = true;
            this.CmdSupp.Click += new System.EventHandler(this.CmdSupp_Click);
            // 
            // CmdMaj
            // 
            this.CmdMaj.Location = new System.Drawing.Point(533, 21);
            this.CmdMaj.Name = "CmdMaj";
            this.CmdMaj.Size = new System.Drawing.Size(109, 40);
            this.CmdMaj.TabIndex = 1;
            this.CmdMaj.Text = "Modifier le Civil";
            this.CmdMaj.UseVisualStyleBackColor = true;
            this.CmdMaj.Click += new System.EventHandler(this.CmdMaj_Click);
            // 
            // CmdCréer
            // 
            this.CmdCréer.Location = new System.Drawing.Point(83, 20);
            this.CmdCréer.Name = "CmdCréer";
            this.CmdCréer.Size = new System.Drawing.Size(109, 40);
            this.CmdCréer.TabIndex = 0;
            this.CmdCréer.Text = "Créer le Civil";
            this.CmdCréer.UseVisualStyleBackColor = true;
            this.CmdCréer.Click += new System.EventHandler(this.CmdCréer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Datemodif2);
            this.groupBox1.Controls.Add(this.Dateajout2);
            this.groupBox1.Controls.Add(this.Ddn2);
            this.groupBox1.Controls.Add(this.Adresse);
            this.groupBox1.Controls.Add(this.Prenom);
            this.groupBox1.Controls.Add(this.Nom);
            this.groupBox1.Controls.Add(this.Id);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(954, 255);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Civils";
            // 
            // Datemodif2
            // 
            this.Datemodif2.Location = new System.Drawing.Point(572, 200);
            this.Datemodif2.Name = "Datemodif2";
            this.Datemodif2.Size = new System.Drawing.Size(200, 20);
            this.Datemodif2.TabIndex = 42;
            // 
            // Dateajout2
            // 
            this.Dateajout2.Location = new System.Drawing.Point(572, 146);
            this.Dateajout2.Name = "Dateajout2";
            this.Dateajout2.Size = new System.Drawing.Size(200, 20);
            this.Dateajout2.TabIndex = 41;
            // 
            // Ddn2
            // 
            this.Ddn2.Location = new System.Drawing.Point(572, 24);
            this.Ddn2.Name = "Ddn2";
            this.Ddn2.Size = new System.Drawing.Size(200, 20);
            this.Ddn2.TabIndex = 39;
            // 
            // Adresse
            // 
            this.Adresse.Location = new System.Drawing.Point(89, 200);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(161, 20);
            this.Adresse.TabIndex = 22;
            // 
            // Prenom
            // 
            this.Prenom.Location = new System.Drawing.Point(89, 146);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(161, 20);
            this.Prenom.TabIndex = 18;
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(89, 79);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(161, 20);
            this.Nom.TabIndex = 17;
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(89, 24);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(161, 20);
            this.Id.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(415, 206);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(151, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Date de dernière modification :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(496, 149);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Date d\'ajout :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(462, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Date de Naissance :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adresse :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prénom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcivilDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.datenaissanceDataGridViewTextBoxColumn,
            this.datedecesDataGridViewTextBoxColumn,
            this.dateajoutDataGridViewTextBoxColumn,
            this.datemodificationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.civilBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(38, 413);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(950, 153);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
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
            // datedecesDataGridViewTextBoxColumn
            // 
            this.datedecesDataGridViewTextBoxColumn.DataPropertyName = "Date_deces";
            this.datedecesDataGridViewTextBoxColumn.HeaderText = "Date_deces";
            this.datedecesDataGridViewTextBoxColumn.Name = "datedecesDataGridViewTextBoxColumn";
            // 
            // dateajoutDataGridViewTextBoxColumn
            // 
            this.dateajoutDataGridViewTextBoxColumn.DataPropertyName = "Date_ajout";
            this.dateajoutDataGridViewTextBoxColumn.HeaderText = "Date_ajout";
            this.dateajoutDataGridViewTextBoxColumn.Name = "dateajoutDataGridViewTextBoxColumn";
            // 
            // datemodificationDataGridViewTextBoxColumn
            // 
            this.datemodificationDataGridViewTextBoxColumn.DataPropertyName = "Date_modification";
            this.datemodificationDataGridViewTextBoxColumn.HeaderText = "Date_modification";
            this.datemodificationDataGridViewTextBoxColumn.Name = "datemodificationDataGridViewTextBoxColumn";
            // 
            // civilBindingSource
            // 
            this.civilBindingSource.DataMember = "Civil";
            this.civilBindingSource.DataSource = this.projetHeroDataSet;
            // 
            // projetHeroDataSet
            // 
            this.projetHeroDataSet.DataSetName = "ProjetHeroDataSet";
            this.projetHeroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // civilsBindingSource1
            // 
            this.civilsBindingSource1.DataMember = "Civils";
            this.civilsBindingSource1.DataSource = this.avengersDBDataSetGridViewCivils;
            // 
            // avengersDBDataSetGridViewCivils
            // 
            this.avengersDBDataSetGridViewCivils.DataSetName = "AvengersDBDataSetGridViewCivils";
            this.avengersDBDataSetGridViewCivils.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // civilsBindingSource
            // 
            this.civilsBindingSource.DataMember = "Civils";
            // 
            // CmdQuitter
            // 
            this.CmdQuitter.Location = new System.Drawing.Point(434, 603);
            this.CmdQuitter.Name = "CmdQuitter";
            this.CmdQuitter.Size = new System.Drawing.Size(102, 35);
            this.CmdQuitter.TabIndex = 7;
            this.CmdQuitter.Text = "Fermer";
            this.CmdQuitter.UseVisualStyleBackColor = true;
            this.CmdQuitter.Click += new System.EventHandler(this.CmdQuitter_Click);
            // 
            // civilsTableAdapter
            // 
            this.civilsTableAdapter.ClearBeforeFill = true;
            // 
            // civilTableAdapter
            // 
            this.civilTableAdapter.ClearBeforeFill = true;
            // 
            // Civils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 650);
            this.Controls.Add(this.CmdQuitter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Civils";
            this.Text = "Création d\'un Civil";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avengersDBDataSetGridViewCivils)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CmdRead;
        private System.Windows.Forms.Button CmdSupp;
        private System.Windows.Forms.Button CmdMaj;
        private System.Windows.Forms.Button CmdCréer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Adresse;
        private System.Windows.Forms.TextBox Prenom;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource civilsBindingSource;
        //private System.Windows.Forms.DataGridViewTextBoxColumn idCivilsDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn nomCivilsDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn prenomCivilsDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn civiliteCivilsDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn adresseCivilsDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn codePostaleCivilsDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn villeCivilsDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn emailCivilsDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn numTelCivilsDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dateDeNaissanceCivilsDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn nationaliteCivilsDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dateDeDecesCivilsDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn appartenanceOrganisationCivilsDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn commentaireCivilsDataGridViewTextBoxColumn;
       // private System.Windows.Forms.DataGridViewTextBoxColumn dateAjoutCivilsDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dateDeDerniereModificationCivilsDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn nombreIncidentsDeclaresCivilsDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn nombreMissionsCivilVictimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button CmdQuitter;
        private AvengersDBDataSetGridViewCivils avengersDBDataSetGridViewCivils;
        private System.Windows.Forms.BindingSource civilsBindingSource1;
        private AvengersDBDataSetGridViewCivilsTableAdapters.CivilsTableAdapter civilsTableAdapter;
        private ProjetHeroDataSet projetHeroDataSet;
        private System.Windows.Forms.BindingSource civilBindingSource;
        private ProjetHeroDataSetTableAdapters.CivilTableAdapter civilTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcivilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datenaissanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datedecesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateajoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datemodificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker Datemodif2;
        private System.Windows.Forms.DateTimePicker Dateajout2;
        private System.Windows.Forms.DateTimePicker Ddn2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
    }
}

