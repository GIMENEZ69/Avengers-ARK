
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
            this.DateTimeModif = new System.Windows.Forms.DateTimePicker();
            this.DateTimeAjout = new System.Windows.Forms.DateTimePicker();
            this.DateTimeNaissance = new System.Windows.Forms.DateTimePicker();
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
            this.CmdQuitter = new System.Windows.Forms.Button();
            this.civilsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idcivilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datenaissanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datedecesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateajoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datemodificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.civilBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projetHeroDataSet3CivilGridview = new Avergers.ProjetHeroDataSet3CivilGridview();
            this.civilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetHeroDataSetCivil = new Avergers.ProjetHeroDataSetCivil();
            this.civilsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.civilTableAdapter = new Avergers.ProjetHeroDataSetCivilTableAdapters.CivilTableAdapter();
            this.civilTableAdapter1 = new Avergers.ProjetHeroDataSet3CivilGridviewTableAdapters.CivilTableAdapter();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.civilsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet3CivilGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetCivil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CmdRead);
            this.groupBox2.Controls.Add(this.CmdSupp);
            this.groupBox2.Controls.Add(this.CmdMaj);
            this.groupBox2.Controls.Add(this.CmdCréer);
            this.groupBox2.Location = new System.Drawing.Point(134, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(786, 79);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opérations";
            // 
            // CmdRead
            // 
            this.CmdRead.Location = new System.Drawing.Point(229, 29);
            this.CmdRead.Name = "CmdRead";
            this.CmdRead.Size = new System.Drawing.Size(109, 40);
            this.CmdRead.TabIndex = 3;
            this.CmdRead.Text = "Lire le civil";
            this.CmdRead.UseVisualStyleBackColor = true;
            this.CmdRead.Click += new System.EventHandler(this.CmdRead_Click);
            // 
            // CmdSupp
            // 
            this.CmdSupp.Location = new System.Drawing.Point(646, 29);
            this.CmdSupp.Name = "CmdSupp";
            this.CmdSupp.Size = new System.Drawing.Size(109, 40);
            this.CmdSupp.TabIndex = 2;
            this.CmdSupp.Text = "Supprimer le Civil";
            this.CmdSupp.UseVisualStyleBackColor = true;
            this.CmdSupp.Click += new System.EventHandler(this.CmdSupp_Click);
            // 
            // CmdMaj
            // 
            this.CmdMaj.Location = new System.Drawing.Point(426, 29);
            this.CmdMaj.Name = "CmdMaj";
            this.CmdMaj.Size = new System.Drawing.Size(109, 40);
            this.CmdMaj.TabIndex = 1;
            this.CmdMaj.Text = "Mettre à jour le Civil";
            this.CmdMaj.UseVisualStyleBackColor = true;
            this.CmdMaj.Click += new System.EventHandler(this.CmdMaj_Click);
            // 
            // CmdCréer
            // 
            this.CmdCréer.Location = new System.Drawing.Point(34, 31);
            this.CmdCréer.Name = "CmdCréer";
            this.CmdCréer.Size = new System.Drawing.Size(109, 40);
            this.CmdCréer.TabIndex = 0;
            this.CmdCréer.Text = "Créer le Civil";
            this.CmdCréer.UseVisualStyleBackColor = true;
            this.CmdCréer.Click += new System.EventHandler(this.CmdCréer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DateTimeModif);
            this.groupBox1.Controls.Add(this.DateTimeAjout);
            this.groupBox1.Controls.Add(this.DateTimeNaissance);
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
            this.groupBox1.Size = new System.Drawing.Size(954, 137);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Civils";
            // 
            // DateTimeModif
            // 
            this.DateTimeModif.Location = new System.Drawing.Point(785, 59);
            this.DateTimeModif.Name = "DateTimeModif";
            this.DateTimeModif.Size = new System.Drawing.Size(159, 20);
            this.DateTimeModif.TabIndex = 41;
            this.DateTimeModif.Value = new System.DateTime(2021, 6, 30, 0, 0, 0, 0);
            // 
            // DateTimeAjout
            // 
            this.DateTimeAjout.Location = new System.Drawing.Point(785, 24);
            this.DateTimeAjout.Name = "DateTimeAjout";
            this.DateTimeAjout.Size = new System.Drawing.Size(159, 20);
            this.DateTimeAjout.TabIndex = 40;
            this.DateTimeAjout.Value = new System.DateTime(2021, 6, 30, 0, 0, 0, 0);
            // 
            // DateTimeNaissance
            // 
            this.DateTimeNaissance.Location = new System.Drawing.Point(434, 24);
            this.DateTimeNaissance.Name = "DateTimeNaissance";
            this.DateTimeNaissance.Size = new System.Drawing.Size(159, 20);
            this.DateTimeNaissance.TabIndex = 39;
            this.DateTimeNaissance.Value = new System.DateTime(2021, 6, 30, 0, 0, 0, 0);
            // 
            // Adresse
            // 
            this.Adresse.Location = new System.Drawing.Point(432, 59);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(161, 20);
            this.Adresse.TabIndex = 22;
            // 
            // Prenom
            // 
            this.Prenom.Location = new System.Drawing.Point(89, 88);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(161, 20);
            this.Prenom.TabIndex = 18;
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(89, 59);
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
            this.label15.Location = new System.Drawing.Point(628, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(151, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Date de dernière modification :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(709, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Date d\'ajout :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(324, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Date de Naissance :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adresse :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prénom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 62);
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
            // CmdQuitter
            // 
            this.CmdQuitter.Location = new System.Drawing.Point(441, 465);
            this.CmdQuitter.Name = "CmdQuitter";
            this.CmdQuitter.Size = new System.Drawing.Size(102, 35);
            this.CmdQuitter.TabIndex = 7;
            this.CmdQuitter.Text = "Fermer";
            this.CmdQuitter.UseVisualStyleBackColor = true;
            this.CmdQuitter.Click += new System.EventHandler(this.CmdQuitter_Click);
            // 
            // civilsBindingSource
            // 
            this.civilsBindingSource.DataMember = "Civils";
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.DataSource = this.civilBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(72, 295);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(877, 150);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick_1);
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
            // civilBindingSource1
            // 
            this.civilBindingSource1.DataMember = "Civil";
            this.civilBindingSource1.DataSource = this.projetHeroDataSet3CivilGridview;
            // 
            // projetHeroDataSet3CivilGridview
            // 
            this.projetHeroDataSet3CivilGridview.DataSetName = "ProjetHeroDataSet3CivilGridview";
            this.projetHeroDataSet3CivilGridview.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // civilBindingSource
            // 
            this.civilBindingSource.DataMember = "Civil";
            this.civilBindingSource.DataSource = this.projetHeroDataSetCivil;
            // 
            // projetHeroDataSetCivil
            // 
            this.projetHeroDataSetCivil.DataSetName = "ProjetHeroDataSetCivil";
            this.projetHeroDataSetCivil.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // civilsBindingSource1
            // 
            this.civilsBindingSource1.DataMember = "Civils";
            // 
            // civilTableAdapter
            // 
            this.civilTableAdapter.ClearBeforeFill = true;
            // 
            // civilTableAdapter1
            // 
            this.civilTableAdapter1.ClearBeforeFill = true;
            // 
            // Civils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 537);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CmdQuitter);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Civils";
            this.Text = "Création d\'un Civil";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.civilsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet3CivilGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetCivil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilsBindingSource1)).EndInit();
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
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        /*private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource civilsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCivilsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCivilsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomCivilsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn civiliteCivilsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseCivilsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codePostaleCivilsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeCivilsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailCivilsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numTelCivilsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDeNaissanceCivilsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationaliteCivilsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDeDecesCivilsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appartenanceOrganisationCivilsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentaireCivilsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAjoutCivilsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDeDerniereModificationCivilsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreIncidentsDeclaresCivilsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMissionsCivilVictimeDataGridViewTextBoxColumn;*/
        private System.Windows.Forms.Button CmdQuitter;
        private System.Windows.Forms.BindingSource civilsBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource civilsBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCivilsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCivilsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomCivilsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn civiliteCivilsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseCivilsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codePostaleCivilsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeCivilsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailCivilsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numTelCivilsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDeNaissanceCivilsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationaliteCivilsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDeDecesCivilsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appartenanceOrganisationCivilsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentaireCivilsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAjoutCivilsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDeDerniereModificationCivilsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreIncidentsDeclaresCivilsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMissionsCivilVictimeDataGridViewTextBoxColumn;
        private ProjetHeroDataSetCivil projetHeroDataSetCivil;
        private System.Windows.Forms.BindingSource civilBindingSource;
        private ProjetHeroDataSetCivilTableAdapters.CivilTableAdapter civilTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcivilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datenaissanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datedecesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateajoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datemodificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker DateTimeModif;
        private System.Windows.Forms.DateTimePicker DateTimeAjout;
        private System.Windows.Forms.DateTimePicker DateTimeNaissance;
        private ProjetHeroDataSet3CivilGridview projetHeroDataSet3CivilGridview;
        private System.Windows.Forms.BindingSource civilBindingSource1;
        private ProjetHeroDataSet3CivilGridviewTableAdapters.CivilTableAdapter civilTableAdapter1;
    }
}

