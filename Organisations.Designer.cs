
namespace Avergers
{
    partial class Organisations
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CmdRead = new System.Windows.Forms.Button();
            this.CmdSupp = new System.Windows.Forms.Button();
            this.CmdMaj = new System.Windows.Forms.Button();
            this.CmdCréer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbIdCivil = new System.Windows.Forms.ComboBox();
            this.civilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DateTimeModif = new System.Windows.Forms.DateTimePicker();
            this.DateTimeAjout = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Membre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SiegeSocial = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.organisationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CmdQuitter = new System.Windows.Forms.Button();
            this.organisationsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.organisationsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idorganisationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomorgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siegesocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcivildirigeantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ajoutorgaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modificationorgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organisationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetHeroDataSet = new Avergers.ProjetHeroDataSet();
            this.organisationTableAdapter = new Avergers.ProjetHeroDataSetTableAdapters.OrganisationTableAdapter();
            this.projetHeroDataSetOrganisationGrdv = new Avergers.ProjetHeroDataSetOrganisationGrdv();
            this.organisationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.organisationTableAdapter1 = new Avergers.ProjetHeroDataSetOrganisationGrdvTableAdapters.OrganisationTableAdapter();
            this.projetHeroDataSetCmbIdCivilOrg = new Avergers.ProjetHeroDataSetCmbIdCivilOrg();
            this.civilBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.civilTableAdapter1 = new Avergers.ProjetHeroDataSetCmbIdCivilOrgTableAdapters.CivilTableAdapter();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organisationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organisationsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organisationsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organisationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetOrganisationGrdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organisationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetCmbIdCivilOrg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CmdRead);
            this.groupBox2.Controls.Add(this.CmdSupp);
            this.groupBox2.Controls.Add(this.CmdMaj);
            this.groupBox2.Controls.Add(this.CmdCréer);
            this.groupBox2.Location = new System.Drawing.Point(12, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(955, 79);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opérations";
            // 
            // CmdRead
            // 
            this.CmdRead.Location = new System.Drawing.Point(269, 29);
            this.CmdRead.Name = "CmdRead";
            this.CmdRead.Size = new System.Drawing.Size(109, 40);
            this.CmdRead.TabIndex = 3;
            this.CmdRead.Text = "Lire l\'organisation";
            this.CmdRead.UseVisualStyleBackColor = true;
            this.CmdRead.Click += new System.EventHandler(this.CmdRead_Click);
            // 
            // CmdSupp
            // 
            this.CmdSupp.Location = new System.Drawing.Point(732, 29);
            this.CmdSupp.Name = "CmdSupp";
            this.CmdSupp.Size = new System.Drawing.Size(142, 40);
            this.CmdSupp.TabIndex = 2;
            this.CmdSupp.Text = "Supprimer l\'organisation";
            this.CmdSupp.UseVisualStyleBackColor = true;
            this.CmdSupp.Click += new System.EventHandler(this.CmdSupp_Click);
            // 
            // CmdMaj
            // 
            this.CmdMaj.Location = new System.Drawing.Point(487, 29);
            this.CmdMaj.Name = "CmdMaj";
            this.CmdMaj.Size = new System.Drawing.Size(161, 40);
            this.CmdMaj.TabIndex = 1;
            this.CmdMaj.Text = "Mettre à jour l\'organisation";
            this.CmdMaj.UseVisualStyleBackColor = true;
            this.CmdMaj.Click += new System.EventHandler(this.CmdMaj_Click);
            // 
            // CmdCréer
            // 
            this.CmdCréer.Location = new System.Drawing.Point(26, 29);
            this.CmdCréer.Name = "CmdCréer";
            this.CmdCréer.Size = new System.Drawing.Size(131, 40);
            this.CmdCréer.TabIndex = 0;
            this.CmdCréer.Text = "Créer l\'organisation";
            this.CmdCréer.UseVisualStyleBackColor = true;
            this.CmdCréer.Click += new System.EventHandler(this.CmdCréer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CmbIdCivil);
            this.groupBox1.Controls.Add(this.DateTimeModif);
            this.groupBox1.Controls.Add(this.DateTimeAjout);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Membre);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.SiegeSocial);
            this.groupBox1.Controls.Add(this.Nom);
            this.groupBox1.Controls.Add(this.Id);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(955, 198);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Organisations";
            // 
            // CmbIdCivil
            // 
            this.CmbIdCivil.DataSource = this.civilBindingSource1;
            this.CmbIdCivil.DisplayMember = "Id_civil";
            this.CmbIdCivil.FormattingEnabled = true;
            this.CmbIdCivil.Location = new System.Drawing.Point(122, 162);
            this.CmbIdCivil.Name = "CmbIdCivil";
            this.CmbIdCivil.Size = new System.Drawing.Size(161, 21);
            this.CmbIdCivil.TabIndex = 51;
            this.CmbIdCivil.ValueMember = "Id_civil";
            // 
            // civilBindingSource
            // 
            this.civilBindingSource.DataMember = "Civil";
            // 
            // projetHeroDataSetCivilComboOrg
            // 
            // 
            // DateTimeModif
            // 
            this.DateTimeModif.Location = new System.Drawing.Point(532, 117);
            this.DateTimeModif.Name = "DateTimeModif";
            this.DateTimeModif.Size = new System.Drawing.Size(161, 20);
            this.DateTimeModif.TabIndex = 50;
            // 
            // DateTimeAjout
            // 
            this.DateTimeAjout.Location = new System.Drawing.Point(532, 71);
            this.DateTimeAjout.Name = "DateTimeAjout";
            this.DateTimeAjout.Size = new System.Drawing.Size(161, 20);
            this.DateTimeAjout.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Nombre de membres :";
            // 
            // Membre
            // 
            this.Membre.Location = new System.Drawing.Point(532, 27);
            this.Membre.Name = "Membre";
            this.Membre.Size = new System.Drawing.Size(161, 20);
            this.Membre.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(364, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Date de la dernière modification :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(456, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Date d\'ajout :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "ID Civil du dirigeant :";
            // 
            // SiegeSocial
            // 
            this.SiegeSocial.Location = new System.Drawing.Point(122, 120);
            this.SiegeSocial.Name = "SiegeSocial";
            this.SiegeSocial.Size = new System.Drawing.Size(161, 20);
            this.SiegeSocial.TabIndex = 36;
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(122, 74);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(161, 20);
            this.Nom.TabIndex = 17;
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(122, 24);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(161, 20);
            this.Id.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Siège social :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id :";
            // 
            // organisationsBindingSource
            // 
            this.organisationsBindingSource.DataMember = "Organisations";
            // 
            // CmdQuitter
            // 
            this.CmdQuitter.Location = new System.Drawing.Point(423, 516);
            this.CmdQuitter.Name = "CmdQuitter";
            this.CmdQuitter.Size = new System.Drawing.Size(102, 35);
            this.CmdQuitter.TabIndex = 13;
            this.CmdQuitter.Text = "Fermer";
            this.CmdQuitter.UseVisualStyleBackColor = true;
            this.CmdQuitter.Click += new System.EventHandler(this.CmdQuitter_Click);
            // 
            // organisationsBindingSource1
            // 
            this.organisationsBindingSource1.DataMember = "Organisations";
            // 
            // organisationsBindingSource2
            // 
            this.organisationsBindingSource2.DataMember = "Organisations";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idorganisationDataGridViewTextBoxColumn,
            this.nomorgDataGridViewTextBoxColumn,
            this.siegesocialDataGridViewTextBoxColumn,
            this.idcivildirigeantDataGridViewTextBoxColumn,
            this.membreDataGridViewTextBoxColumn,
            this.ajoutorgaDataGridViewTextBoxColumn,
            this.modificationorgDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.organisationBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(13, 318);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(953, 184);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick_1);
            // 
            // idorganisationDataGridViewTextBoxColumn
            // 
            this.idorganisationDataGridViewTextBoxColumn.DataPropertyName = "Id_organisation";
            this.idorganisationDataGridViewTextBoxColumn.HeaderText = "Id_organisation";
            this.idorganisationDataGridViewTextBoxColumn.Name = "idorganisationDataGridViewTextBoxColumn";
            // 
            // nomorgDataGridViewTextBoxColumn
            // 
            this.nomorgDataGridViewTextBoxColumn.DataPropertyName = "Nom_org";
            this.nomorgDataGridViewTextBoxColumn.HeaderText = "Nom_org";
            this.nomorgDataGridViewTextBoxColumn.Name = "nomorgDataGridViewTextBoxColumn";
            // 
            // siegesocialDataGridViewTextBoxColumn
            // 
            this.siegesocialDataGridViewTextBoxColumn.DataPropertyName = "Siege_social";
            this.siegesocialDataGridViewTextBoxColumn.HeaderText = "Siege_social";
            this.siegesocialDataGridViewTextBoxColumn.Name = "siegesocialDataGridViewTextBoxColumn";
            // 
            // idcivildirigeantDataGridViewTextBoxColumn
            // 
            this.idcivildirigeantDataGridViewTextBoxColumn.DataPropertyName = "Id_civil_dirigeant";
            this.idcivildirigeantDataGridViewTextBoxColumn.HeaderText = "Id_civil_dirigeant";
            this.idcivildirigeantDataGridViewTextBoxColumn.Name = "idcivildirigeantDataGridViewTextBoxColumn";
            // 
            // membreDataGridViewTextBoxColumn
            // 
            this.membreDataGridViewTextBoxColumn.DataPropertyName = "Membre";
            this.membreDataGridViewTextBoxColumn.HeaderText = "Membre";
            this.membreDataGridViewTextBoxColumn.Name = "membreDataGridViewTextBoxColumn";
            // 
            // ajoutorgaDataGridViewTextBoxColumn
            // 
            this.ajoutorgaDataGridViewTextBoxColumn.DataPropertyName = "Ajout_orga";
            this.ajoutorgaDataGridViewTextBoxColumn.HeaderText = "Ajout_orga";
            this.ajoutorgaDataGridViewTextBoxColumn.Name = "ajoutorgaDataGridViewTextBoxColumn";
            // 
            // modificationorgDataGridViewTextBoxColumn
            // 
            this.modificationorgDataGridViewTextBoxColumn.DataPropertyName = "Modification_org";
            this.modificationorgDataGridViewTextBoxColumn.HeaderText = "Modification_org";
            this.modificationorgDataGridViewTextBoxColumn.Name = "modificationorgDataGridViewTextBoxColumn";
            // 
            // organisationBindingSource
            // 
            this.organisationBindingSource.DataMember = "Organisation";
            this.organisationBindingSource.DataSource = this.projetHeroDataSet;
            // 
            // projetHeroDataSet
            // 
            this.projetHeroDataSet.DataSetName = "ProjetHeroDataSet";
            this.projetHeroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // organisationTableAdapter
            // 
            this.organisationTableAdapter.ClearBeforeFill = true;
            // 
            // civilTableAdapter
            // 
            // 
            // projetHeroDataSetOrganisationGrdv
            // 
            this.projetHeroDataSetOrganisationGrdv.DataSetName = "ProjetHeroDataSetOrganisationGrdv";
            this.projetHeroDataSetOrganisationGrdv.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // organisationBindingSource1
            // 
            this.organisationBindingSource1.DataMember = "Organisation";
            this.organisationBindingSource1.DataSource = this.projetHeroDataSetOrganisationGrdv;
            // 
            // organisationTableAdapter1
            // 
            this.organisationTableAdapter1.ClearBeforeFill = true;
            // 
            // projetHeroDataSetCmbIdCivilOrg
            // 
            this.projetHeroDataSetCmbIdCivilOrg.DataSetName = "ProjetHeroDataSetCmbIdCivilOrg";
            this.projetHeroDataSetCmbIdCivilOrg.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // civilBindingSource1
            // 
            this.civilBindingSource1.DataMember = "Civil";
            this.civilBindingSource1.DataSource = this.projetHeroDataSetCmbIdCivilOrg;
            // 
            // civilTableAdapter1
            // 
            this.civilTableAdapter1.ClearBeforeFill = true;
            // 
            // Organisations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 556);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CmdQuitter);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Organisations";
            this.Text = "Organisations";
            this.Load += new System.EventHandler(this.Organisations_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organisationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organisationsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organisationsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organisationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetOrganisationGrdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organisationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetCmbIdCivilOrg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CmdRead;
        private System.Windows.Forms.Button CmdSupp;
        private System.Windows.Forms.Button CmdMaj;
        private System.Windows.Forms.Button CmdCréer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SiegeSocial;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource organisationsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOrganisationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomOrganisationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseOrganisationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codePostaleOrganisationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeOrganisationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirigeantOrganisationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentaireOrganisationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAjoutOrganisationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDerniereModificationOrganisationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button CmdQuitter;
        private System.Windows.Forms.BindingSource organisationsBindingSource1;
        private System.Windows.Forms.BindingSource organisationsBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreIncidentsDeclaresOrganisationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMissionsOrganisationsImpliqueOrganisationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Membre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjetHeroDataSet projetHeroDataSet;
        private System.Windows.Forms.BindingSource organisationBindingSource;
        private ProjetHeroDataSetTableAdapters.OrganisationTableAdapter organisationTableAdapter;
        private System.Windows.Forms.DateTimePicker DateTimeModif;
        private System.Windows.Forms.DateTimePicker DateTimeAjout;
        private System.Windows.Forms.DataGridViewTextBoxColumn idorganisationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomorgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siegesocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcivildirigeantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn membreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ajoutorgaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modificationorgDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox CmbIdCivil;
        private System.Windows.Forms.BindingSource civilBindingSource;
        private ProjetHeroDataSetOrganisationGrdv projetHeroDataSetOrganisationGrdv;
        private System.Windows.Forms.BindingSource organisationBindingSource1;
        private ProjetHeroDataSetOrganisationGrdvTableAdapters.OrganisationTableAdapter organisationTableAdapter1;
        private ProjetHeroDataSetCmbIdCivilOrg projetHeroDataSetCmbIdCivilOrg;
        private System.Windows.Forms.BindingSource civilBindingSource1;
        private ProjetHeroDataSetCmbIdCivilOrgTableAdapters.CivilTableAdapter civilTableAdapter1;
    }
}