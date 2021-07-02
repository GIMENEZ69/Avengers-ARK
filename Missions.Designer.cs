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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.incidentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projetHeroDataSetIdIncidentMission = new Avergers.ProjetHeroDataSetIdIncidentMission();
            this.CmbUrgence = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TitreIncident = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CmbInterSH = new System.Windows.Forms.ComboBox();
            this.incidentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetHeroDataSet3 = new Avergers.ProjetHeroDataSet3();
            this.CmbNivGravite = new System.Windows.Forms.ComboBox();
            this.IdMission = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmdValiderMission = new System.Windows.Forms.Button();
            this.incidentTableAdapter = new Avergers.ProjetHeroDataSet3TableAdapters.IncidentTableAdapter();
            this.incidentTableAdapter1 = new Avergers.ProjetHeroDataSetIdIncidentMissionTableAdapters.IncidentTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idincidentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateajoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.natureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incidentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.projetHeroDataSetDGVIncidentMission = new Avergers.ProjetHeroDataSetDGVIncidentMission();
            this.incidentTableAdapter2 = new Avergers.ProjetHeroDataSetDGVIncidentMissionTableAdapters.IncidentTableAdapter();
            this.CmbSelecRech = new System.Windows.Forms.ComboBox();
            this.Recherche = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.projetHeroDataSetherosmission = new Avergers.ProjetHeroDataSetherosmission();
            this.superheroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.super_heroTableAdapter = new Avergers.ProjetHeroDataSetherosmissionTableAdapters.Super_heroTableAdapter();
            this.DateDebut = new System.Windows.Forms.DateTimePicker();
            this.DateFin = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incidentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetIdIncidentMission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetDGVIncidentMission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetherosmission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superheroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DateFin);
            this.groupBox1.Controls.Add(this.DateDebut);
            this.groupBox1.Controls.Add(this.CmbUrgence);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.TitreIncident);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.CmbInterSH);
            this.groupBox1.Controls.Add(this.CmbNivGravite);
            this.groupBox1.Controls.Add(this.IdMission);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(8, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 147);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mission :";
            // 
            // incidentBindingSource1
            // 
            this.incidentBindingSource1.DataMember = "Incident";
            this.incidentBindingSource1.DataSource = this.projetHeroDataSetIdIncidentMission;
            // 
            // projetHeroDataSetIdIncidentMission
            // 
            this.projetHeroDataSetIdIncidentMission.DataSetName = "ProjetHeroDataSetIdIncidentMission";
            this.projetHeroDataSetIdIncidentMission.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CmbUrgence
            // 
            this.CmbUrgence.FormattingEnabled = true;
            this.CmbUrgence.Items.AddRange(new object[] {
            "Faible",
            "Moyenne ",
            "Importante",
            "Urgente "});
            this.CmbUrgence.Location = new System.Drawing.Point(420, 28);
            this.CmbUrgence.Name = "CmbUrgence";
            this.CmbUrgence.Size = new System.Drawing.Size(115, 21);
            this.CmbUrgence.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(317, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "Niveau d\'urgence :";
            // 
            // TitreIncident
            // 
            this.TitreIncident.Location = new System.Drawing.Point(166, 33);
            this.TitreIncident.Name = "TitreIncident";
            this.TitreIncident.Size = new System.Drawing.Size(116, 20);
            this.TitreIncident.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(67, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Titre de l\'incident :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(559, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Id de la mission :";
            // 
            // CmbInterSH
            // 
            this.CmbInterSH.DataSource = this.superheroBindingSource;
            this.CmbInterSH.DisplayMember = "Nom_hero";
            this.CmbInterSH.FormattingEnabled = true;
            this.CmbInterSH.Location = new System.Drawing.Point(420, 101);
            this.CmbInterSH.Name = "CmbInterSH";
            this.CmbInterSH.Size = new System.Drawing.Size(115, 21);
            this.CmbInterSH.TabIndex = 22;
            this.CmbInterSH.ValueMember = "Nom_hero";
            // 
            // incidentBindingSource
            // 
            this.incidentBindingSource.DataMember = "Incident";
            this.incidentBindingSource.DataSource = this.projetHeroDataSet3;
            // 
            // projetHeroDataSet3
            // 
            this.projetHeroDataSet3.DataSetName = "ProjetHeroDataSet3";
            this.projetHeroDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CmbNivGravite
            // 
            this.CmbNivGravite.FormattingEnabled = true;
            this.CmbNivGravite.Items.AddRange(new object[] {
            "Faible",
            "Moyenne ",
            "Importante",
            "Urgente"});
            this.CmbNivGravite.Location = new System.Drawing.Point(420, 66);
            this.CmbNivGravite.Name = "CmbNivGravite";
            this.CmbNivGravite.Size = new System.Drawing.Size(115, 21);
            this.CmbNivGravite.TabIndex = 19;
            // 
            // IdMission
            // 
            this.IdMission.Location = new System.Drawing.Point(650, 60);
            this.IdMission.Name = "IdMission";
            this.IdMission.Size = new System.Drawing.Size(115, 20);
            this.IdMission.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(317, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Niveau de gravité :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Intervention Héros :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date de fin de mission :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date de début de la mission :";
            // 
            // CmdValiderMission
            // 
            this.CmdValiderMission.Location = new System.Drawing.Point(328, 385);
            this.CmdValiderMission.Name = "CmdValiderMission";
            this.CmdValiderMission.Size = new System.Drawing.Size(110, 52);
            this.CmdValiderMission.TabIndex = 8;
            this.CmdValiderMission.Text = "Valider la mission";
            this.CmdValiderMission.UseVisualStyleBackColor = true;
            this.CmdValiderMission.Click += new System.EventHandler(this.CmdValiderMission_Click);
            // 
            // incidentTableAdapter
            // 
            this.incidentTableAdapter.ClearBeforeFill = true;
            // 
            // incidentTableAdapter1
            // 
            this.incidentTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idincidentDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.dateajoutDataGridViewTextBoxColumn,
            this.natureDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.incidentBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(15, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(772, 139);
            this.dataGridView1.TabIndex = 9;
            // 
            // idincidentDataGridViewTextBoxColumn
            // 
            this.idincidentDataGridViewTextBoxColumn.DataPropertyName = "Id_incident";
            this.idincidentDataGridViewTextBoxColumn.HeaderText = "Id_incident";
            this.idincidentDataGridViewTextBoxColumn.Name = "idincidentDataGridViewTextBoxColumn";
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
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
            // incidentBindingSource2
            // 
            this.incidentBindingSource2.DataMember = "Incident";
            this.incidentBindingSource2.DataSource = this.projetHeroDataSetDGVIncidentMission;
            // 
            // projetHeroDataSetDGVIncidentMission
            // 
            this.projetHeroDataSetDGVIncidentMission.DataSetName = "ProjetHeroDataSetDGVIncidentMission";
            this.projetHeroDataSetDGVIncidentMission.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // incidentTableAdapter2
            // 
            this.incidentTableAdapter2.ClearBeforeFill = true;
            // 
            // CmbSelecRech
            // 
            this.CmbSelecRech.FormattingEnabled = true;
            this.CmbSelecRech.Items.AddRange(new object[] {
            "Id_incident",
            "Adresse",
            "Date_ajout",
            "Nature"});
            this.CmbSelecRech.Location = new System.Drawing.Point(174, 24);
            this.CmbSelecRech.Name = "CmbSelecRech";
            this.CmbSelecRech.Size = new System.Drawing.Size(99, 21);
            this.CmbSelecRech.TabIndex = 14;
            // 
            // Recherche
            // 
            this.Recherche.Location = new System.Drawing.Point(511, 24);
            this.Recherche.Name = "Recherche";
            this.Recherche.Size = new System.Drawing.Size(126, 20);
            this.Recherche.TabIndex = 13;
            this.Recherche.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Recherche_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Saisir votre recherche :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Sélection de recherche :";
            // 
            // projetHeroDataSetherosmission
            // 
            this.projetHeroDataSetherosmission.DataSetName = "ProjetHeroDataSetherosmission";
            this.projetHeroDataSetherosmission.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // superheroBindingSource
            // 
            this.superheroBindingSource.DataMember = "Super_hero";
            this.superheroBindingSource.DataSource = this.projetHeroDataSetherosmission;
            // 
            // super_heroTableAdapter
            // 
            this.super_heroTableAdapter.ClearBeforeFill = true;
            // 
            // DateDebut
            // 
            this.DateDebut.Location = new System.Drawing.Point(168, 70);
            this.DateDebut.Name = "DateDebut";
            this.DateDebut.Size = new System.Drawing.Size(113, 20);
            this.DateDebut.TabIndex = 28;
            // 
            // DateFin
            // 
            this.DateFin.Location = new System.Drawing.Point(169, 105);
            this.DateFin.Name = "DateFin";
            this.DateFin.Size = new System.Drawing.Size(113, 20);
            this.DateFin.TabIndex = 29;
            // 
            // Missions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.CmbSelecRech);
            this.Controls.Add(this.Recherche);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CmdValiderMission);
            this.Controls.Add(this.groupBox1);
            this.Name = "Missions";
            this.Text = "Déclaration d\'une mission";
            this.Load += new System.EventHandler(this.Missions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incidentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetIdIncidentMission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetDGVIncidentMission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetherosmission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superheroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CmbInterSH;
        private System.Windows.Forms.ComboBox CmbNivGravite;
        private System.Windows.Forms.TextBox IdMission;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CmdValiderMission;
        private System.Windows.Forms.ComboBox CmbUrgence;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TitreIncident;
        private System.Windows.Forms.Label label15;
        private ProjetHeroDataSet3 projetHeroDataSet3;
        private System.Windows.Forms.BindingSource incidentBindingSource;
        private ProjetHeroDataSet3TableAdapters.IncidentTableAdapter incidentTableAdapter;
        private ProjetHeroDataSetIdIncidentMission projetHeroDataSetIdIncidentMission;
        private System.Windows.Forms.BindingSource incidentBindingSource1;
        private ProjetHeroDataSetIdIncidentMissionTableAdapters.IncidentTableAdapter incidentTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjetHeroDataSetDGVIncidentMission projetHeroDataSetDGVIncidentMission;
        private System.Windows.Forms.BindingSource incidentBindingSource2;
        private ProjetHeroDataSetDGVIncidentMissionTableAdapters.IncidentTableAdapter incidentTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idincidentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateajoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn natureDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox CmbSelecRech;
        private System.Windows.Forms.TextBox Recherche;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private ProjetHeroDataSetherosmission projetHeroDataSetherosmission;
        private System.Windows.Forms.BindingSource superheroBindingSource;
        private ProjetHeroDataSetherosmissionTableAdapters.Super_heroTableAdapter super_heroTableAdapter;
        private System.Windows.Forms.DateTimePicker DateFin;
        private System.Windows.Forms.DateTimePicker DateDebut;
    }
}