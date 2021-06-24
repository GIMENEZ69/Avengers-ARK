
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
            this.Adresse = new System.Windows.Forms.TextBox();
            this.Commentaire = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Ville = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Dirigeant = new System.Windows.Forms.TextBox();
            this.Dateajout = new System.Windows.Forms.TextBox();
            this.Datemodif = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.avengersDBDataSet3 = new Avergers.AvengersDBDataSet3();
            this.organisationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.organisationsTableAdapter = new Avergers.AvengersDBDataSet3TableAdapters.OrganisationsTableAdapter();
            this.idOrganisationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomOrganisationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseOrganisationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codePostaleOrganisationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeOrganisationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirigeantOrganisationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentaireOrganisationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAjoutOrganisationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDerniereModificationOrganisationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmdQuitter = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avengersDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organisationsBindingSource)).BeginInit();
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Code Postal :";
            // 
            // CP
            // 
            this.CP.Location = new System.Drawing.Point(93, 156);
            this.CP.Name = "CP";
            this.CP.Size = new System.Drawing.Size(161, 20);
            this.CP.TabIndex = 38;
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
            // Ville
            // 
            this.Ville.Location = new System.Drawing.Point(93, 196);
            this.Ville.Name = "Ville";
            this.Ville.Size = new System.Drawing.Size(161, 20);
            this.Ville.TabIndex = 40;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(456, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Date d\'ajout :";
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
            // Dirigeant
            // 
            this.Dirigeant.Location = new System.Drawing.Point(532, 28);
            this.Dirigeant.Name = "Dirigeant";
            this.Dirigeant.Size = new System.Drawing.Size(161, 20);
            this.Dirigeant.TabIndex = 44;
            // 
            // Dateajout
            // 
            this.Dateajout.Location = new System.Drawing.Point(532, 121);
            this.Dateajout.Name = "Dateajout";
            this.Dateajout.Size = new System.Drawing.Size(161, 20);
            this.Dateajout.TabIndex = 45;
            // 
            // Datemodif
            // 
            this.Datemodif.Location = new System.Drawing.Point(532, 160);
            this.Datemodif.Name = "Datemodif";
            this.Datemodif.Size = new System.Drawing.Size(161, 20);
            this.Datemodif.TabIndex = 46;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOrganisationsDataGridViewTextBoxColumn,
            this.nomOrganisationsDataGridViewTextBoxColumn,
            this.adresseOrganisationsDataGridViewTextBoxColumn,
            this.codePostaleOrganisationsDataGridViewTextBoxColumn,
            this.villeOrganisationsDataGridViewTextBoxColumn,
            this.dirigeantOrganisationsDataGridViewTextBoxColumn,
            this.commentaireOrganisationsDataGridViewTextBoxColumn,
            this.dateAjoutOrganisationsDataGridViewTextBoxColumn,
            this.dateDerniereModificationOrganisationsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.organisationsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 356);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(952, 199);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // avengersDBDataSet3
            // 
            this.avengersDBDataSet3.DataSetName = "AvengersDBDataSet3";
            this.avengersDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // organisationsBindingSource
            // 
            this.organisationsBindingSource.DataMember = "Organisations";
            this.organisationsBindingSource.DataSource = this.avengersDBDataSet3;
            // 
            // organisationsTableAdapter
            // 
            this.organisationsTableAdapter.ClearBeforeFill = true;
            // 
            // idOrganisationsDataGridViewTextBoxColumn
            // 
            this.idOrganisationsDataGridViewTextBoxColumn.DataPropertyName = "Id_Organisations";
            this.idOrganisationsDataGridViewTextBoxColumn.HeaderText = "Id_Organisations";
            this.idOrganisationsDataGridViewTextBoxColumn.Name = "idOrganisationsDataGridViewTextBoxColumn";
            // 
            // nomOrganisationsDataGridViewTextBoxColumn
            // 
            this.nomOrganisationsDataGridViewTextBoxColumn.DataPropertyName = "Nom_Organisations";
            this.nomOrganisationsDataGridViewTextBoxColumn.HeaderText = "Nom_Organisations";
            this.nomOrganisationsDataGridViewTextBoxColumn.Name = "nomOrganisationsDataGridViewTextBoxColumn";
            // 
            // adresseOrganisationsDataGridViewTextBoxColumn
            // 
            this.adresseOrganisationsDataGridViewTextBoxColumn.DataPropertyName = "Adresse_Organisations";
            this.adresseOrganisationsDataGridViewTextBoxColumn.HeaderText = "Adresse_Organisations";
            this.adresseOrganisationsDataGridViewTextBoxColumn.Name = "adresseOrganisationsDataGridViewTextBoxColumn";
            // 
            // codePostaleOrganisationsDataGridViewTextBoxColumn
            // 
            this.codePostaleOrganisationsDataGridViewTextBoxColumn.DataPropertyName = "CodePostale_Organisations";
            this.codePostaleOrganisationsDataGridViewTextBoxColumn.HeaderText = "CodePostale_Organisations";
            this.codePostaleOrganisationsDataGridViewTextBoxColumn.Name = "codePostaleOrganisationsDataGridViewTextBoxColumn";
            // 
            // villeOrganisationsDataGridViewTextBoxColumn
            // 
            this.villeOrganisationsDataGridViewTextBoxColumn.DataPropertyName = "Ville_Organisations";
            this.villeOrganisationsDataGridViewTextBoxColumn.HeaderText = "Ville_Organisations";
            this.villeOrganisationsDataGridViewTextBoxColumn.Name = "villeOrganisationsDataGridViewTextBoxColumn";
            // 
            // dirigeantOrganisationsDataGridViewTextBoxColumn
            // 
            this.dirigeantOrganisationsDataGridViewTextBoxColumn.DataPropertyName = "Dirigeant_Organisations";
            this.dirigeantOrganisationsDataGridViewTextBoxColumn.HeaderText = "Dirigeant_Organisations";
            this.dirigeantOrganisationsDataGridViewTextBoxColumn.Name = "dirigeantOrganisationsDataGridViewTextBoxColumn";
            // 
            // commentaireOrganisationsDataGridViewTextBoxColumn
            // 
            this.commentaireOrganisationsDataGridViewTextBoxColumn.DataPropertyName = "Commentaire_Organisations";
            this.commentaireOrganisationsDataGridViewTextBoxColumn.HeaderText = "Commentaire_Organisations";
            this.commentaireOrganisationsDataGridViewTextBoxColumn.Name = "commentaireOrganisationsDataGridViewTextBoxColumn";
            // 
            // dateAjoutOrganisationsDataGridViewTextBoxColumn
            // 
            this.dateAjoutOrganisationsDataGridViewTextBoxColumn.DataPropertyName = "DateAjout_Organisations";
            this.dateAjoutOrganisationsDataGridViewTextBoxColumn.HeaderText = "DateAjout_Organisations";
            this.dateAjoutOrganisationsDataGridViewTextBoxColumn.Name = "dateAjoutOrganisationsDataGridViewTextBoxColumn";
            // 
            // dateDerniereModificationOrganisationsDataGridViewTextBoxColumn
            // 
            this.dateDerniereModificationOrganisationsDataGridViewTextBoxColumn.DataPropertyName = "DateDerniereModification_Organisations";
            this.dateDerniereModificationOrganisationsDataGridViewTextBoxColumn.HeaderText = "DateDerniereModification_Organisations";
            this.dateDerniereModificationOrganisationsDataGridViewTextBoxColumn.Name = "dateDerniereModificationOrganisationsDataGridViewTextBoxColumn";
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
            // Organisations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 625);
            this.Controls.Add(this.CmdQuitter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Organisations";
            this.Text = "Organisations";
            this.Load += new System.EventHandler(this.Organisations_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avengersDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organisationsBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private AvengersDBDataSet3 avengersDBDataSet3;
        private System.Windows.Forms.BindingSource organisationsBindingSource;
        private AvengersDBDataSet3TableAdapters.OrganisationsTableAdapter organisationsTableAdapter;
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
    }
}