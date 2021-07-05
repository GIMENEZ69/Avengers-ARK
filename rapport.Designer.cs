
namespace Avergers
{
    partial class rapport
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
            this.CmbSHMort = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.CmbNbCivilSauve = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CmbSVOui = new System.Windows.Forms.ComboBox();
            this.CmbSVPresent = new System.Windows.Forms.ComboBox();
            this.CoutsDegats = new System.Windows.Forms.TextBox();
            this.CmbSVArrete = new System.Windows.Forms.ComboBox();
            this.Infos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ValidRapport = new System.Windows.Forms.Button();
            this.civilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetHeroDataSet3test = new Avergers.ProjetHeroDataSet3test();
            this.civilTableAdapter = new Avergers.ProjetHeroDataSet3testTableAdapters.CivilTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.projetHeroDataSet3DataGridViewMissioninRapportForm = new Avergers.ProjetHeroDataSet3DataGridViewMissioninRapportForm();
            this.missionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.missionTableAdapter = new Avergers.ProjetHeroDataSet3DataGridViewMissioninRapportFormTableAdapters.MissionTableAdapter();
            this.idincidentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcivilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.natureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomheroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datedebutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datefinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itineraireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.graviteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projetHeroDataSet3MissionGRDV = new Avergers.ProjetHeroDataSet3MissionGRDV();
            this.missionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.missionTableAdapter1 = new Avergers.ProjetHeroDataSet3MissionGRDVTableAdapters.MissionTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet3test)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet3DataGridViewMissioninRapportForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.missionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet3MissionGRDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.missionBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.CmbSHMort);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.CmbNbCivilSauve);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.CmbSVOui);
            this.groupBox2.Controls.Add(this.CmbSVPresent);
            this.groupBox2.Controls.Add(this.CoutsDegats);
            this.groupBox2.Controls.Add(this.CmbSVArrete);
            this.groupBox2.Controls.Add(this.Infos);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(12, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(997, 296);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rapport de Mission :";
            // 
            // CmbSHMort
            // 
            this.CmbSHMort.FormattingEnabled = true;
            this.CmbSHMort.Items.AddRange(new object[] {
            "Oui ",
            "Non"});
            this.CmbSHMort.Location = new System.Drawing.Point(698, 135);
            this.CmbSHMort.Name = "CmbSHMort";
            this.CmbSHMort.Size = new System.Drawing.Size(117, 21);
            this.CmbSHMort.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(594, 138);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Super Héros mort ?";
            // 
            // CmbNbCivilSauve
            // 
            this.CmbNbCivilSauve.FormattingEnabled = true;
            this.CmbNbCivilSauve.Items.AddRange(new object[] {
            "oui",
            "non"});
            this.CmbNbCivilSauve.Location = new System.Drawing.Point(698, 102);
            this.CmbNbCivilSauve.Name = "CmbNbCivilSauve";
            this.CmbNbCivilSauve.Size = new System.Drawing.Size(117, 21);
            this.CmbNbCivilSauve.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(574, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Nombre de civil sauvé :";
            // 
            // CmbSVOui
            // 
            this.CmbSVOui.FormattingEnabled = true;
            this.CmbSVOui.Location = new System.Drawing.Point(450, 107);
            this.CmbSVOui.Name = "CmbSVOui";
            this.CmbSVOui.Size = new System.Drawing.Size(117, 21);
            this.CmbSVOui.TabIndex = 24;
            // 
            // CmbSVPresent
            // 
            this.CmbSVPresent.FormattingEnabled = true;
            this.CmbSVPresent.Items.AddRange(new object[] {
            "Oui",
            "Non"});
            this.CmbSVPresent.Location = new System.Drawing.Point(450, 69);
            this.CmbSVPresent.Name = "CmbSVPresent";
            this.CmbSVPresent.Size = new System.Drawing.Size(116, 21);
            this.CmbSVPresent.TabIndex = 22;
            // 
            // CoutsDegats
            // 
            this.CoutsDegats.Location = new System.Drawing.Point(190, 107);
            this.CoutsDegats.Name = "CoutsDegats";
            this.CoutsDegats.Size = new System.Drawing.Size(112, 20);
            this.CoutsDegats.TabIndex = 21;
            // 
            // CmbSVArrete
            // 
            this.CmbSVArrete.FormattingEnabled = true;
            this.CmbSVArrete.Items.AddRange(new object[] {
            "Oui",
            "Non"});
            this.CmbSVArrete.Location = new System.Drawing.Point(698, 68);
            this.CmbSVArrete.Name = "CmbSVArrete";
            this.CmbSVArrete.Size = new System.Drawing.Size(115, 21);
            this.CmbSVArrete.TabIndex = 19;
            // 
            // Infos
            // 
            this.Infos.Location = new System.Drawing.Point(235, 189);
            this.Infos.Multiline = true;
            this.Infos.Name = "Infos";
            this.Infos.Size = new System.Drawing.Size(457, 83);
            this.Infos.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Infos complémentaires :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(590, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Super Vilain arrêté ?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(321, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Super Vilains présent(s) :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(368, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Si oui, lequel ?";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(94, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Coût des dégâts :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(94, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Nom des dégâts :";
            // 
            // ValidRapport
            // 
            this.ValidRapport.Location = new System.Drawing.Point(437, 439);
            this.ValidRapport.Name = "ValidRapport";
            this.ValidRapport.Size = new System.Drawing.Size(115, 62);
            this.ValidRapport.TabIndex = 29;
            this.ValidRapport.Text = "Valider le rapport";
            this.ValidRapport.UseVisualStyleBackColor = true;
            this.ValidRapport.Click += new System.EventHandler(this.ValidRapport_Click);
            // 
            // civilBindingSource
            // 
            this.civilBindingSource.DataMember = "Civil";
            this.civilBindingSource.DataSource = this.projetHeroDataSet3test;
            // 
            // projetHeroDataSet3test
            // 
            this.projetHeroDataSet3test.DataSetName = "ProjetHeroDataSet3test";
            this.projetHeroDataSet3test.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // civilTableAdapter
            // 
            this.civilTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idincidentDataGridViewTextBoxColumn,
            this.idcivilDataGridViewTextBoxColumn,
            this.natureDataGridViewTextBoxColumn,
            this.titreDataGridViewTextBoxColumn,
            this.nomheroDataGridViewTextBoxColumn,
            this.datedebutDataGridViewTextBoxColumn,
            this.datefinDataGridViewTextBoxColumn,
            this.itineraireDataGridViewTextBoxColumn,
            this.graviteDataGridViewTextBoxColumn,
            this.idmissionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.missionBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1044, 131);
            this.dataGridView1.TabIndex = 30;
            // 
            // projetHeroDataSet3DataGridViewMissioninRapportForm
            // 
            this.projetHeroDataSet3DataGridViewMissioninRapportForm.DataSetName = "ProjetHeroDataSet3DataGridViewMissioninRapportForm";
            this.projetHeroDataSet3DataGridViewMissioninRapportForm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // missionBindingSource
            // 
            this.missionBindingSource.DataMember = "Mission";
            this.missionBindingSource.DataSource = this.projetHeroDataSet3DataGridViewMissioninRapportForm;
            // 
            // missionTableAdapter
            // 
            this.missionTableAdapter.ClearBeforeFill = true;
            // 
            // idincidentDataGridViewTextBoxColumn
            // 
            this.idincidentDataGridViewTextBoxColumn.DataPropertyName = "Id_incident";
            this.idincidentDataGridViewTextBoxColumn.HeaderText = "Id_incident";
            this.idincidentDataGridViewTextBoxColumn.Name = "idincidentDataGridViewTextBoxColumn";
            // 
            // idcivilDataGridViewTextBoxColumn
            // 
            this.idcivilDataGridViewTextBoxColumn.DataPropertyName = "Id_civil";
            this.idcivilDataGridViewTextBoxColumn.HeaderText = "Id_civil";
            this.idcivilDataGridViewTextBoxColumn.Name = "idcivilDataGridViewTextBoxColumn";
            // 
            // natureDataGridViewTextBoxColumn
            // 
            this.natureDataGridViewTextBoxColumn.DataPropertyName = "Nature";
            this.natureDataGridViewTextBoxColumn.HeaderText = "Nature";
            this.natureDataGridViewTextBoxColumn.Name = "natureDataGridViewTextBoxColumn";
            // 
            // titreDataGridViewTextBoxColumn
            // 
            this.titreDataGridViewTextBoxColumn.DataPropertyName = "Titre";
            this.titreDataGridViewTextBoxColumn.HeaderText = "Titre";
            this.titreDataGridViewTextBoxColumn.Name = "titreDataGridViewTextBoxColumn";
            // 
            // nomheroDataGridViewTextBoxColumn
            // 
            this.nomheroDataGridViewTextBoxColumn.DataPropertyName = "Nom_hero";
            this.nomheroDataGridViewTextBoxColumn.HeaderText = "Nom_hero";
            this.nomheroDataGridViewTextBoxColumn.Name = "nomheroDataGridViewTextBoxColumn";
            // 
            // datedebutDataGridViewTextBoxColumn
            // 
            this.datedebutDataGridViewTextBoxColumn.DataPropertyName = "Date_debut";
            this.datedebutDataGridViewTextBoxColumn.HeaderText = "Date_debut";
            this.datedebutDataGridViewTextBoxColumn.Name = "datedebutDataGridViewTextBoxColumn";
            // 
            // datefinDataGridViewTextBoxColumn
            // 
            this.datefinDataGridViewTextBoxColumn.DataPropertyName = "Date_fin";
            this.datefinDataGridViewTextBoxColumn.HeaderText = "Date_fin";
            this.datefinDataGridViewTextBoxColumn.Name = "datefinDataGridViewTextBoxColumn";
            // 
            // itineraireDataGridViewTextBoxColumn
            // 
            this.itineraireDataGridViewTextBoxColumn.DataPropertyName = "Itineraire";
            this.itineraireDataGridViewTextBoxColumn.HeaderText = "Itineraire";
            this.itineraireDataGridViewTextBoxColumn.Name = "itineraireDataGridViewTextBoxColumn";
            // 
            // graviteDataGridViewTextBoxColumn
            // 
            this.graviteDataGridViewTextBoxColumn.DataPropertyName = "Gravite";
            this.graviteDataGridViewTextBoxColumn.HeaderText = "Gravite";
            this.graviteDataGridViewTextBoxColumn.Name = "graviteDataGridViewTextBoxColumn";
            // 
            // idmissionDataGridViewTextBoxColumn
            // 
            this.idmissionDataGridViewTextBoxColumn.DataPropertyName = "Id_mission";
            this.idmissionDataGridViewTextBoxColumn.HeaderText = "Id_mission";
            this.idmissionDataGridViewTextBoxColumn.Name = "idmissionDataGridViewTextBoxColumn";
            // 
            // projetHeroDataSet3MissionGRDV
            // 
            this.projetHeroDataSet3MissionGRDV.DataSetName = "ProjetHeroDataSet3MissionGRDV";
            this.projetHeroDataSet3MissionGRDV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // missionBindingSource1
            // 
            this.missionBindingSource1.DataMember = "Mission";
            this.missionBindingSource1.DataSource = this.projetHeroDataSet3MissionGRDV;
            // 
            // missionTableAdapter1
            // 
            this.missionTableAdapter1.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Matériel",
            "Immatériel",
            "Humain",
            "Autres"});
            this.comboBox1.Location = new System.Drawing.Point(190, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(116, 21);
            this.comboBox1.TabIndex = 29;
            // 
            // rapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 527);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ValidRapport);
            this.Controls.Add(this.groupBox2);
            this.Name = "rapport";
            this.Text = "rapport";
            this.Load += new System.EventHandler(this.rapport_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet3test)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet3DataGridViewMissioninRapportForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.missionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet3MissionGRDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.missionBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CmbSHMort;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox CmbNbCivilSauve;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox CmbSVOui;
        private System.Windows.Forms.ComboBox CmbSVPresent;
        private System.Windows.Forms.TextBox CoutsDegats;
        private System.Windows.Forms.ComboBox CmbSVArrete;
        private System.Windows.Forms.TextBox Infos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button ValidRapport;
        private ProjetHeroDataSet3test projetHeroDataSet3test;
        private System.Windows.Forms.BindingSource civilBindingSource;
        private ProjetHeroDataSet3testTableAdapters.CivilTableAdapter civilTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjetHeroDataSet3DataGridViewMissioninRapportForm projetHeroDataSet3DataGridViewMissioninRapportForm;
        private System.Windows.Forms.BindingSource missionBindingSource;
        private ProjetHeroDataSet3DataGridViewMissioninRapportFormTableAdapters.MissionTableAdapter missionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idincidentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcivilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn natureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomheroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datedebutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datefinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itineraireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn graviteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmissionDataGridViewTextBoxColumn;
        private ProjetHeroDataSet3MissionGRDV projetHeroDataSet3MissionGRDV;
        private System.Windows.Forms.BindingSource missionBindingSource1;
        private ProjetHeroDataSet3MissionGRDVTableAdapters.MissionTableAdapter missionTableAdapter1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}