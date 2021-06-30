
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
            this.datemodif = new System.Windows.Forms.DateTimePicker();
            this.dateajout = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.civilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetHeroDataSet3 = new Avergers.ProjetHeroDataSet3();
            this.Dirigeant = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.TextBox();
            this.Siegesocial = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.organisationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CmdQuitter = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idorganisationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomorgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siegesocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcivildirigeantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ajoutorgaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modificationorgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organisationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetHeroDataSet4 = new Avergers.ProjetHeroDataSet4();
            this.organisationsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.avengersDBDataSet1 = new Avergers.AvengersDBDataSet1();
            this.organisationsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.organisationsTableAdapter2 = new Avergers.AvengersDBDataSet1TableAdapters.OrganisationsTableAdapter();
            this.civilTableAdapter = new Avergers.ProjetHeroDataSet3TableAdapters.CivilTableAdapter();
            this.organisationTableAdapter = new Avergers.ProjetHeroDataSet4TableAdapters.OrganisationTableAdapter();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organisationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organisationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organisationsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avengersDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organisationsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CmdRead);
            this.groupBox2.Controls.Add(this.CmdSupp);
            this.groupBox2.Controls.Add(this.CmdMaj);
            this.groupBox2.Controls.Add(this.CmdCréer);
            this.groupBox2.Location = new System.Drawing.Point(12, 263);
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
            this.CmdMaj.Text = "Modifier l\'organisation";
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
            this.groupBox1.Controls.Add(this.datemodif);
            this.groupBox1.Controls.Add(this.dateajout);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.Dirigeant);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Nom);
            this.groupBox1.Controls.Add(this.Siegesocial);
            this.groupBox1.Controls.Add(this.Id);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(955, 233);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Organisations";
            // 
            // datemodif
            // 
            this.datemodif.Location = new System.Drawing.Point(532, 157);
            this.datemodif.Name = "datemodif";
            this.datemodif.Size = new System.Drawing.Size(200, 20);
            this.datemodif.TabIndex = 50;
            // 
            // dateajout
            // 
            this.dateajout.Location = new System.Drawing.Point(532, 95);
            this.dateajout.Name = "dateajout";
            this.dateajout.Size = new System.Drawing.Size(200, 20);
            this.dateajout.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Numéro Id. Civils :";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.civilBindingSource;
            this.comboBox1.DisplayMember = "Id_civil";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(99, 186);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 21);
            this.comboBox1.TabIndex = 47;
            this.comboBox1.ValueMember = "Id_civil";
            // 
            // civilBindingSource
            // 
            this.civilBindingSource.DataMember = "Civil";
            this.civilBindingSource.DataSource = this.projetHeroDataSet3;
            // 
            // projetHeroDataSet3
            // 
            this.projetHeroDataSet3.DataSetName = "ProjetHeroDataSet3";
            this.projetHeroDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Dirigeant
            // 
            this.Dirigeant.Location = new System.Drawing.Point(532, 28);
            this.Dirigeant.Name = "Dirigeant";
            this.Dirigeant.Size = new System.Drawing.Size(161, 20);
            this.Dirigeant.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(364, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Date de la dernière modification :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(456, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Date d\'ajout :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Membre dirigeant :";
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(93, 62);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(161, 20);
            this.Nom.TabIndex = 27;
            // 
            // Siegesocial
            // 
            this.Siegesocial.Location = new System.Drawing.Point(93, 118);
            this.Siegesocial.Name = "Siegesocial";
            this.Siegesocial.Size = new System.Drawing.Size(161, 20);
            this.Siegesocial.TabIndex = 17;
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(93, 25);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(161, 20);
            this.Id.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(43, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Siège Siocial :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numéro Id. :";
            // 
            // organisationsBindingSource
            // 
            this.organisationsBindingSource.DataMember = "Organisations";
            // 
            // CmdQuitter
            // 
            this.CmdQuitter.Location = new System.Drawing.Point(409, 578);
            this.CmdQuitter.Name = "CmdQuitter";
            this.CmdQuitter.Size = new System.Drawing.Size(102, 35);
            this.CmdQuitter.TabIndex = 13;
            this.CmdQuitter.Text = "Fermer";
            this.CmdQuitter.UseVisualStyleBackColor = true;
            this.CmdQuitter.Click += new System.EventHandler(this.CmdQuitter_Click);
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
            this.dataGridView1.DataSource = this.organisationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 374);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(948, 182);
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
            this.organisationBindingSource.DataSource = this.projetHeroDataSet4;
            // 
            // projetHeroDataSet4
            // 
            this.projetHeroDataSet4.DataSetName = "ProjetHeroDataSet4";
            this.projetHeroDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // organisationsBindingSource2
            // 
            this.organisationsBindingSource2.DataMember = "Organisations";
            this.organisationsBindingSource2.DataSource = this.avengersDBDataSet1;
            // 
            // avengersDBDataSet1
            // 
            this.avengersDBDataSet1.DataSetName = "AvengersDBDataSet1";
            this.avengersDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // organisationsBindingSource1
            // 
            this.organisationsBindingSource1.DataMember = "Organisations";
            // 
            // organisationsTableAdapter2
            // 
            this.organisationsTableAdapter2.ClearBeforeFill = true;
            // 
            // civilTableAdapter
            // 
            this.civilTableAdapter.ClearBeforeFill = true;
            // 
            // organisationTableAdapter
            // 
            this.organisationTableAdapter.ClearBeforeFill = true;
            // 
            // Organisations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 625);
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
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organisationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organisationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organisationsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avengersDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organisationsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CmdRead;
        private System.Windows.Forms.Button CmdSupp;
        private System.Windows.Forms.Button CmdMaj;
        private System.Windows.Forms.Button CmdCréer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.TextBox Siegesocial;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Dirigeant;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource organisationsBindingSource;
        //private System.Windows.Forms.DataGridViewTextBoxColumn idOrganisationsDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn nomOrganisationsDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn adresseOrganisationsDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn codePostaleOrganisationsDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn villeOrganisationsDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dirigeantOrganisationsDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn commentaireOrganisationsDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dateAjoutOrganisationsDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dateDerniereModificationOrganisationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button CmdQuitter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource organisationsBindingSource1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private AvengersDBDataSet1 avengersDBDataSet1;
        private System.Windows.Forms.BindingSource organisationsBindingSource2;
        private AvengersDBDataSet1TableAdapters.OrganisationsTableAdapter organisationsTableAdapter2;
        private System.Windows.Forms.ComboBox comboBox1;
        private ProjetHeroDataSet3 projetHeroDataSet3;
        private System.Windows.Forms.BindingSource civilBindingSource;
        private ProjetHeroDataSet3TableAdapters.CivilTableAdapter civilTableAdapter;
        private ProjetHeroDataSet4 projetHeroDataSet4;
        private System.Windows.Forms.BindingSource organisationBindingSource;
        private ProjetHeroDataSet4TableAdapters.OrganisationTableAdapter organisationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idorganisationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomorgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siegesocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcivildirigeantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn membreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ajoutorgaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modificationorgDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datemodif;
        private System.Windows.Forms.DateTimePicker dateajout;
    }
}