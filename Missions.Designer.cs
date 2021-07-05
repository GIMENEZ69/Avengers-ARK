namespace Avergers
{
    partial class Missions
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
            this.CmdAnnuler = new System.Windows.Forms.Button();
            this.CmdValider = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNatureIncident = new System.Windows.Forms.TextBox();
            this.titreMission = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CmbInterSH = new System.Windows.Forms.ComboBox();
            this.superheoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetHeroDataSet3superherocombobox = new Avergers.ProjetHeroDataSet3superherocombobox();
            this.CmbNivGravite = new System.Windows.Forms.ComboBox();
            this.IdMission = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboColumn = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.incidentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetHeroDataSetIncidentDatagridview = new Avergers.ProjetHeroDataSetIncidentDatagridview();
            this.super_heoTableAdapter = new Avergers.ProjetHeroDataSet3superherocomboboxTableAdapters.Super_heoTableAdapter();
            this.ExtractBtn = new System.Windows.Forms.Button();
            this.incidentTableAdapter = new Avergers.ProjetHeroDataSetIncidentDatagridviewTableAdapters.IncidentTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.id_civil = new System.Windows.Forms.TextBox();
            this.dateTimeFin = new System.Windows.Forms.DateTimePicker();
            this.dateDebut = new System.Windows.Forms.TextBox();
            this.idincidentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcivildeclarantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idorganisationdeclarantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentaireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateajoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.natureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projetHeroDataSetMissionComboNomSuperhero = new Avergers.ProjetHeroDataSetMissionComboNomSuperhero();
            this.superheoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.super_heoTableAdapter1 = new Avergers.ProjetHeroDataSetMissionComboNomSuperheroTableAdapters.Super_heoTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.idIncident = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adresse = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.projetHeroDataSetMissionComboboxSuperHero2 = new Avergers.ProjetHeroDataSetMissionComboboxSuperHero2();
            this.superhero2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.super_hero2TableAdapter = new Avergers.ProjetHeroDataSetMissionComboboxSuperHero2TableAdapters.Super_hero2TableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superheoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet3superherocombobox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetIncidentDatagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetMissionComboNomSuperhero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superheoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetMissionComboboxSuperHero2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superhero2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdAnnuler
            // 
            this.CmdAnnuler.Location = new System.Drawing.Point(494, 429);
            this.CmdAnnuler.Name = "CmdAnnuler";
            this.CmdAnnuler.Size = new System.Drawing.Size(111, 62);
            this.CmdAnnuler.TabIndex = 6;
            this.CmdAnnuler.Text = "Annuler";
            this.CmdAnnuler.UseVisualStyleBackColor = true;
            this.CmdAnnuler.Click += new System.EventHandler(this.CmdAnnuler_Click);
            // 
            // CmdValider
            // 
            this.CmdValider.Location = new System.Drawing.Point(286, 424);
            this.CmdValider.Name = "CmdValider";
            this.CmdValider.Size = new System.Drawing.Size(115, 62);
            this.CmdValider.TabIndex = 5;
            this.CmdValider.Text = "Valider la mission";
            this.CmdValider.UseVisualStyleBackColor = true;
            this.CmdValider.Click += new System.EventHandler(this.CmdValider_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.adresse);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.idIncident);
            this.groupBox1.Controls.Add(this.dateDebut);
            this.groupBox1.Controls.Add(this.dateTimeFin);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.id_civil);
            this.groupBox1.Controls.Add(this.txtNatureIncident);
            this.groupBox1.Controls.Add(this.titreMission);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.CmbInterSH);
            this.groupBox1.Controls.Add(this.CmbNivGravite);
            this.groupBox1.Controls.Add(this.IdMission);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(938, 221);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mission :";
            // 
            // txtNatureIncident
            // 
            this.txtNatureIncident.Location = new System.Drawing.Point(137, 34);
            this.txtNatureIncident.Name = "txtNatureIncident";
            this.txtNatureIncident.Size = new System.Drawing.Size(112, 20);
            this.txtNatureIncident.TabIndex = 26;
            // 
            // titreMission
            // 
            this.titreMission.Location = new System.Drawing.Point(137, 104);
            this.titreMission.Name = "titreMission";
            this.titreMission.Size = new System.Drawing.Size(112, 20);
            this.titreMission.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 107);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Titre de la mission :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(605, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Id de la mission :";
            // 
            // CmbInterSH
            // 
            this.CmbInterSH.DataSource = this.superhero2BindingSource;
            this.CmbInterSH.DisplayMember = "Nom_hero";
            this.CmbInterSH.FormattingEnabled = true;
            this.CmbInterSH.Location = new System.Drawing.Point(449, 69);
            this.CmbInterSH.Name = "CmbInterSH";
            this.CmbInterSH.Size = new System.Drawing.Size(116, 21);
            this.CmbInterSH.TabIndex = 22;
            this.CmbInterSH.ValueMember = "Nom_hero";
            // 
            // superheoBindingSource
            // 
            this.superheoBindingSource.DataMember = "Super_heo";
            this.superheoBindingSource.DataSource = this.projetHeroDataSet3superherocombobox;
            // 
            // projetHeroDataSet3superherocombobox
            // 
            this.projetHeroDataSet3superherocombobox.DataSetName = "ProjetHeroDataSet3superherocombobox";
            this.projetHeroDataSet3superherocombobox.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CmbNivGravite
            // 
            this.CmbNivGravite.FormattingEnabled = true;
            this.CmbNivGravite.Items.AddRange(new object[] {
            "Faible (dangereux)",
            "Moyenne ",
            "Importante",
            "Urgente (Destruction imminente)"});
            this.CmbNivGravite.Location = new System.Drawing.Point(696, 31);
            this.CmbNivGravite.Name = "CmbNivGravite";
            this.CmbNivGravite.Size = new System.Drawing.Size(115, 21);
            this.CmbNivGravite.TabIndex = 19;
            // 
            // IdMission
            // 
            this.IdMission.Location = new System.Drawing.Point(696, 70);
            this.IdMission.Name = "IdMission";
            this.IdMission.Size = new System.Drawing.Size(115, 20);
            this.IdMission.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(593, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Niveau de gravité :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Intervention Héros :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date de fin de mission :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date de début missions :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nature de l\'incident :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(584, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 20);
            this.txtSearch.TabIndex = 33;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Rechercher par :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Rechercher par :";
            // 
            // cboColumn
            // 
            this.cboColumn.FormattingEnabled = true;
            this.cboColumn.Items.AddRange(new object[] {
            "Id_civil_declarant",
            "Id_Incident"});
            this.cboColumn.Location = new System.Drawing.Point(125, 9);
            this.cboColumn.Name = "cboColumn";
            this.cboColumn.Size = new System.Drawing.Size(163, 21);
            this.cboColumn.TabIndex = 36;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idincidentDataGridViewTextBoxColumn,
            this.idcivildeclarantDataGridViewTextBoxColumn,
            this.idorganisationdeclarantDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.commentaireDataGridViewTextBoxColumn,
            this.dateajoutDataGridViewTextBoxColumn,
            this.natureDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.incidentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(948, 103);
            this.dataGridView1.TabIndex = 35;
            // 
            // incidentBindingSource
            // 
            this.incidentBindingSource.DataMember = "Incident";
            this.incidentBindingSource.DataSource = this.projetHeroDataSetIncidentDatagridview;
            // 
            // projetHeroDataSetIncidentDatagridview
            // 
            this.projetHeroDataSetIncidentDatagridview.DataSetName = "ProjetHeroDataSetIncidentDatagridview";
            this.projetHeroDataSetIncidentDatagridview.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // super_heoTableAdapter
            // 
            this.super_heoTableAdapter.ClearBeforeFill = true;
            // 
            // ExtractBtn
            // 
            this.ExtractBtn.Location = new System.Drawing.Point(397, 151);
            this.ExtractBtn.Name = "ExtractBtn";
            this.ExtractBtn.Size = new System.Drawing.Size(104, 40);
            this.ExtractBtn.TabIndex = 38;
            this.ExtractBtn.Text = "Extraction";
            this.ExtractBtn.UseVisualStyleBackColor = true;
            this.ExtractBtn.Click += new System.EventHandler(this.ExtractBtn_Click_1);
            // 
            // incidentTableAdapter
            // 
            this.incidentTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(343, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Id civil";
            // 
            // id_civil
            // 
            this.id_civil.Location = new System.Drawing.Point(400, 104);
            this.id_civil.Name = "id_civil";
            this.id_civil.Size = new System.Drawing.Size(115, 20);
            this.id_civil.TabIndex = 27;
            // 
            // dateTimeFin
            // 
            this.dateTimeFin.Location = new System.Drawing.Point(389, 34);
            this.dateTimeFin.Name = "dateTimeFin";
            this.dateTimeFin.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFin.TabIndex = 30;
            // 
            // dateDebut
            // 
            this.dateDebut.Location = new System.Drawing.Point(137, 66);
            this.dateDebut.Name = "dateDebut";
            this.dateDebut.Size = new System.Drawing.Size(112, 20);
            this.dateDebut.TabIndex = 31;
            // 
            // idincidentDataGridViewTextBoxColumn
            // 
            this.idincidentDataGridViewTextBoxColumn.DataPropertyName = "Id_incident";
            this.idincidentDataGridViewTextBoxColumn.HeaderText = "Id_incident";
            this.idincidentDataGridViewTextBoxColumn.Name = "idincidentDataGridViewTextBoxColumn";
            // 
            // idcivildeclarantDataGridViewTextBoxColumn
            // 
            this.idcivildeclarantDataGridViewTextBoxColumn.DataPropertyName = "Id_civil_declarant";
            this.idcivildeclarantDataGridViewTextBoxColumn.HeaderText = "Id_civil_declarant";
            this.idcivildeclarantDataGridViewTextBoxColumn.Name = "idcivildeclarantDataGridViewTextBoxColumn";
            // 
            // idorganisationdeclarantDataGridViewTextBoxColumn
            // 
            this.idorganisationdeclarantDataGridViewTextBoxColumn.DataPropertyName = "Id_organisation_declarant";
            this.idorganisationdeclarantDataGridViewTextBoxColumn.HeaderText = "Id_organisation_declarant";
            this.idorganisationdeclarantDataGridViewTextBoxColumn.Name = "idorganisationdeclarantDataGridViewTextBoxColumn";
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            // 
            // commentaireDataGridViewTextBoxColumn
            // 
            this.commentaireDataGridViewTextBoxColumn.DataPropertyName = "Commentaire";
            this.commentaireDataGridViewTextBoxColumn.HeaderText = "Commentaire";
            this.commentaireDataGridViewTextBoxColumn.Name = "commentaireDataGridViewTextBoxColumn";
            // 
            // dateajoutDataGridViewTextBoxColumn
            // 
            this.dateajoutDataGridViewTextBoxColumn.DataPropertyName = "Date_ajout";
            this.dateajoutDataGridViewTextBoxColumn.HeaderText = "Date_ajout";
            this.dateajoutDataGridViewTextBoxColumn.Name = "dateajoutDataGridViewTextBoxColumn";
            // 
            // natureDataGridViewTextBoxColumn
            // 
            this.natureDataGridViewTextBoxColumn.DataPropertyName = "Nature";
            this.natureDataGridViewTextBoxColumn.HeaderText = "Nature";
            this.natureDataGridViewTextBoxColumn.Name = "natureDataGridViewTextBoxColumn";
            // 
            // projetHeroDataSetMissionComboNomSuperhero
            // 
            this.projetHeroDataSetMissionComboNomSuperhero.DataSetName = "ProjetHeroDataSetMissionComboNomSuperhero";
            this.projetHeroDataSetMissionComboNomSuperhero.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // superheoBindingSource1
            // 
            this.superheoBindingSource1.DataMember = "Super_heo";
            this.superheoBindingSource1.DataSource = this.projetHeroDataSetMissionComboNomSuperhero;
            // 
            // super_heoTableAdapter1
            // 
            this.super_heoTableAdapter1.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(609, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Id incident";
            // 
            // idIncident
            // 
            this.idIncident.Location = new System.Drawing.Point(696, 100);
            this.idIncident.Name = "idIncident";
            this.idIncident.Size = new System.Drawing.Size(115, 20);
            this.idIncident.TabIndex = 32;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // adresse
            // 
            this.adresse.Location = new System.Drawing.Point(137, 140);
            this.adresse.Multiline = true;
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(167, 56);
            this.adresse.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Adresse :";
            // 
            // projetHeroDataSetMissionComboboxSuperHero2
            // 
            this.projetHeroDataSetMissionComboboxSuperHero2.DataSetName = "ProjetHeroDataSetMissionComboboxSuperHero2";
            this.projetHeroDataSetMissionComboboxSuperHero2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // superhero2BindingSource
            // 
            this.superhero2BindingSource.DataMember = "Super_hero2";
            this.superhero2BindingSource.DataSource = this.projetHeroDataSetMissionComboboxSuperHero2;
            // 
            // super_hero2TableAdapter
            // 
            this.super_hero2TableAdapter.ClearBeforeFill = true;
            // 
            // Missions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 503);
            this.Controls.Add(this.ExtractBtn);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.CmdAnnuler);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmdValider);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboColumn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Missions";
            this.Text = "Mission";
            this.Load += new System.EventHandler(this.Missions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superheoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet3superherocombobox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetIncidentDatagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetMissionComboNomSuperhero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superheoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetMissionComboboxSuperHero2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superhero2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CmdAnnuler;
        private System.Windows.Forms.Button CmdValider;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CmbInterSH;
        private System.Windows.Forms.ComboBox CmbNivGravite;
        private System.Windows.Forms.TextBox IdMission;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titreMission;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNatureIncident;
        private ProjetHeroDataSet3superherocombobox projetHeroDataSet3superherocombobox;
        private System.Windows.Forms.BindingSource superheoBindingSource;
        private ProjetHeroDataSet3superherocomboboxTableAdapters.Super_heoTableAdapter super_heoTableAdapter;
        private System.Windows.Forms.Button ExtractBtn;
        private ProjetHeroDataSetIncidentDatagridview projetHeroDataSetIncidentDatagridview;
        private System.Windows.Forms.BindingSource incidentBindingSource;
        private ProjetHeroDataSetIncidentDatagridviewTableAdapters.IncidentTableAdapter incidentTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox id_civil;
        private System.Windows.Forms.TextBox dateDebut;
        private System.Windows.Forms.DateTimePicker dateTimeFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn idincidentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcivildeclarantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idorganisationdeclarantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentaireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateajoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn natureDataGridViewTextBoxColumn;
        private ProjetHeroDataSetMissionComboNomSuperhero projetHeroDataSetMissionComboNomSuperhero;
        private System.Windows.Forms.BindingSource superheoBindingSource1;
        private ProjetHeroDataSetMissionComboNomSuperheroTableAdapters.Super_heoTableAdapter super_heoTableAdapter1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox idIncident;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private ProjetHeroDataSetMissionComboboxSuperHero2 projetHeroDataSetMissionComboboxSuperHero2;
        private System.Windows.Forms.BindingSource superhero2BindingSource;
        private ProjetHeroDataSetMissionComboboxSuperHero2TableAdapters.Super_hero2TableAdapter super_hero2TableAdapter;
    }
}