
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
            this.Datemodif = new System.Windows.Forms.TextBox();
            this.Dateajout = new System.Windows.Forms.TextBox();
            this.Dirigeant = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Ville = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Adresse = new System.Windows.Forms.TextBox();
            this.Commentaire = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.organisationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CmdQuitter = new System.Windows.Forms.Button();
            this.avengersDBDataSetOrga = new Avergers.AvengersDBDataSetOrga();
            this.organisationsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.organisationsTableAdapter = new Avergers.AvengersDBDataSetOrgaTableAdapters.OrganisationsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.avengersDBDataSetOrga1 = new Avergers.AvengersDBDataSetOrga();
            this.organisationsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreIncidentsDeclaresOrganisationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMissionsOrganisationsImpliqueOrganisationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.organisationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avengersDBDataSetOrga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organisationsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avengersDBDataSetOrga1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organisationsBindingSource2)).BeginInit();
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
            this.groupBox1.Controls.Add(this.Datemodif);
            this.groupBox1.Controls.Add(this.Dateajout);
            this.groupBox1.Controls.Add(this.Dirigeant);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Ville);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Adresse);
            this.groupBox1.Controls.Add(this.Commentaire);
            this.groupBox1.Controls.Add(this.Nom);
            this.groupBox1.Controls.Add(this.Id);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(955, 233);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Organisations";
            // 
            // Datemodif
            // 
            this.Datemodif.Location = new System.Drawing.Point(532, 160);
            this.Datemodif.Name = "Datemodif";
            this.Datemodif.Size = new System.Drawing.Size(161, 20);
            this.Datemodif.TabIndex = 46;
            // 
            // Dateajout
            // 
            this.Dateajout.Location = new System.Drawing.Point(532, 121);
            this.Dateajout.Name = "Dateajout";
            this.Dateajout.Size = new System.Drawing.Size(161, 20);
            this.Dateajout.TabIndex = 45;
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
            this.label6.Location = new System.Drawing.Point(456, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Date d\'ajout :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(471, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Dirigeant :";
            // 
            // Ville
            // 
            this.Ville.Location = new System.Drawing.Point(93, 196);
            this.Ville.Name = "Ville";
            this.Ville.Size = new System.Drawing.Size(161, 20);
            this.Ville.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Ville :";
            // 
            // CP
            // 
            this.CP.Location = new System.Drawing.Point(93, 156);
            this.CP.Name = "CP";
            this.CP.Size = new System.Drawing.Size(161, 20);
            this.CP.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Code Postal :";
            // 
            // Adresse
            // 
            this.Adresse.Location = new System.Drawing.Point(93, 117);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(161, 20);
            this.Adresse.TabIndex = 36;
            // 
            // Commentaire
            // 
            this.Commentaire.Location = new System.Drawing.Point(532, 74);
            this.Commentaire.Name = "Commentaire";
            this.Commentaire.Size = new System.Drawing.Size(161, 20);
            this.Commentaire.TabIndex = 27;
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(93, 70);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(161, 20);
            this.Nom.TabIndex = 17;
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(93, 24);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(161, 20);
            this.Id.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(452, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Commentaire :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Adresse :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 74);
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
            // avengersDBDataSetOrga
            // 
            this.avengersDBDataSetOrga.DataSetName = "AvengersDBDataSetOrga";
            this.avengersDBDataSetOrga.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // organisationsBindingSource1
            // 
            this.organisationsBindingSource1.DataMember = "Organisations";
            this.organisationsBindingSource1.DataSource = this.avengersDBDataSetOrga;
            // 
            // organisationsTableAdapter
            // 
            this.organisationsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.nombreIncidentsDeclaresOrganisationsDataGridViewTextBoxColumn,
            this.nombreMissionsOrganisationsImpliqueOrganisationsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.organisationsBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(16, 350);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(950, 160);
            this.dataGridView1.TabIndex = 14;
            // 
            // avengersDBDataSetOrga1
            // 
            this.avengersDBDataSetOrga1.DataSetName = "AvengersDBDataSetOrga";
            this.avengersDBDataSetOrga1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // organisationsBindingSource2
            // 
            this.organisationsBindingSource2.DataMember = "Organisations";
            this.organisationsBindingSource2.DataSource = this.avengersDBDataSetOrga1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Organisations";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Organisations";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nom_Organisations";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom_Organisations";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Adresse_Organisations";
            this.dataGridViewTextBoxColumn3.HeaderText = "Adresse_Organisations";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CodePostale_Organisations";
            this.dataGridViewTextBoxColumn4.HeaderText = "CodePostale_Organisations";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Ville_Organisations";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ville_Organisations";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Dirigeant_Organisations";
            this.dataGridViewTextBoxColumn6.HeaderText = "Dirigeant_Organisations";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Commentaire_Organisations";
            this.dataGridViewTextBoxColumn7.HeaderText = "Commentaire_Organisations";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DateAjout_Organisations";
            this.dataGridViewTextBoxColumn8.HeaderText = "DateAjout_Organisations";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DateDerniereModification_Organisations";
            this.dataGridViewTextBoxColumn9.HeaderText = "DateDerniereModification_Organisations";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // nombreIncidentsDeclaresOrganisationsDataGridViewTextBoxColumn
            // 
            this.nombreIncidentsDeclaresOrganisationsDataGridViewTextBoxColumn.DataPropertyName = "NombreIncidentsDeclares_Organisations";
            this.nombreIncidentsDeclaresOrganisationsDataGridViewTextBoxColumn.HeaderText = "NombreIncidentsDeclares_Organisations";
            this.nombreIncidentsDeclaresOrganisationsDataGridViewTextBoxColumn.Name = "nombreIncidentsDeclaresOrganisationsDataGridViewTextBoxColumn";
            // 
            // nombreMissionsOrganisationsImpliqueOrganisationsDataGridViewTextBoxColumn
            // 
            this.nombreMissionsOrganisationsImpliqueOrganisationsDataGridViewTextBoxColumn.DataPropertyName = "NombreMissionsOrganisationsImplique_Organisations";
            this.nombreMissionsOrganisationsImpliqueOrganisationsDataGridViewTextBoxColumn.HeaderText = "NombreMissionsOrganisationsImplique_Organisations";
            this.nombreMissionsOrganisationsImpliqueOrganisationsDataGridViewTextBoxColumn.Name = "nombreMissionsOrganisationsImpliqueOrganisationsDataGridViewTextBoxColumn";
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
            ((System.ComponentModel.ISupportInitialize)(this.organisationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avengersDBDataSetOrga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organisationsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avengersDBDataSetOrga1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organisationsBindingSource2)).EndInit();
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
        private System.Windows.Forms.TextBox Commentaire;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Datemodif;
        private System.Windows.Forms.TextBox Dateajout;
        private System.Windows.Forms.TextBox Dirigeant;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Ville;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CP;
        private System.Windows.Forms.Label label3;
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
        private AvengersDBDataSetOrga avengersDBDataSetOrga;
        private System.Windows.Forms.BindingSource organisationsBindingSource1;
        private AvengersDBDataSetOrgaTableAdapters.OrganisationsTableAdapter organisationsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AvengersDBDataSetOrga avengersDBDataSetOrga1;
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
    }
}