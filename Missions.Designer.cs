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
            this.CmbInterSH = new System.Windows.Forms.ComboBox();
            this.CmbNivGravite = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TitreIncident = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comborecherche = new System.Windows.Forms.ComboBox();
            this.textRecherche = new System.Windows.Forms.TextBox();
            this.projetHeroDataSetMission = new Avergers.ProjetHeroDataSetMission();
            this.incidentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incidentTableAdapter = new Avergers.ProjetHeroDataSetMissionTableAdapters.IncidentTableAdapter();
            this.projetHeroDataSetGridMission = new Avergers.ProjetHeroDataSetGridMission();
            this.incidentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.incidentTableAdapter1 = new Avergers.ProjetHeroDataSetGridMissionTableAdapters.IncidentTableAdapter();
            this.idincidentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcivildeclarantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateajoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.natureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonvalider = new System.Windows.Forms.Button();
            this.projetHeroDataSetHeroMission = new Avergers.ProjetHeroDataSetHeroMission();
            this.superheroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.super_heroTableAdapter = new Avergers.ProjetHeroDataSetHeroMissionTableAdapters.Super_heroTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetMission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetGridMission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetHeroMission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superheroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.TitreIncident);
            this.groupBox1.Controls.Add(this.CmbInterSH);
            this.groupBox1.Controls.Add(this.CmbNivGravite);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(793, 244);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mission :";
            // 
            // CmbInterSH
            // 
            this.CmbInterSH.DataSource = this.superheroBindingSource;
            this.CmbInterSH.FormattingEnabled = true;
            this.CmbInterSH.Location = new System.Drawing.Point(418, 182);
            this.CmbInterSH.Name = "CmbInterSH";
            this.CmbInterSH.Size = new System.Drawing.Size(116, 21);
            this.CmbInterSH.TabIndex = 22;
            // 
            // CmbNivGravite
            // 
            this.CmbNivGravite.FormattingEnabled = true;
            this.CmbNivGravite.Items.AddRange(new object[] {
            "Faible (dangereux)",
            "Moyenne ",
            "Importante",
            "Urgente (Destruction imminente)"});
            this.CmbNivGravite.Location = new System.Drawing.Point(419, 77);
            this.CmbNivGravite.Name = "CmbNivGravite";
            this.CmbNivGravite.Size = new System.Drawing.Size(115, 21);
            this.CmbNivGravite.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Niveau de gravité :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Héros intervenu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date de fin de mission :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date de début :";
            // 
            // TitreIncident
            // 
            this.TitreIncident.AutoSize = true;
            this.TitreIncident.Location = new System.Drawing.Point(27, 138);
            this.TitreIncident.Name = "TitreIncident";
            this.TitreIncident.Size = new System.Drawing.Size(91, 13);
            this.TitreIncident.TabIndex = 24;
            this.TitreIncident.Text = "Titre de l\'Incident:";
            this.TitreIncident.Click += new System.EventHandler(this.TitreIncident_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 20);
            this.textBox1.TabIndex = 25;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idincidentDataGridViewTextBoxColumn,
            this.idcivildeclarantDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.dateajoutDataGridViewTextBoxColumn,
            this.natureDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.incidentBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(83, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(655, 78);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Selection de recherche:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(465, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Recherche:";
            // 
            // comborecherche
            // 
            this.comborecherche.FormattingEnabled = true;
            this.comborecherche.Items.AddRange(new object[] {
            "ID Incident",
            "ID Civil",
            "Date Ajout",
            "Nature"});
            this.comborecherche.Location = new System.Drawing.Point(195, 32);
            this.comborecherche.Name = "comborecherche";
            this.comborecherche.Size = new System.Drawing.Size(113, 21);
            this.comborecherche.TabIndex = 8;
            // 
            // textRecherche
            // 
            this.textRecherche.Location = new System.Drawing.Point(545, 38);
            this.textRecherche.Name = "textRecherche";
            this.textRecherche.Size = new System.Drawing.Size(122, 20);
            this.textRecherche.TabIndex = 9;
            this.textRecherche.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // projetHeroDataSetMission
            // 
            this.projetHeroDataSetMission.DataSetName = "ProjetHeroDataSetMission";
            this.projetHeroDataSetMission.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // incidentBindingSource
            // 
            this.incidentBindingSource.DataMember = "Incident";
            this.incidentBindingSource.DataSource = this.projetHeroDataSetMission;
            // 
            // incidentTableAdapter
            // 
            this.incidentTableAdapter.ClearBeforeFill = true;
            // 
            // projetHeroDataSetGridMission
            // 
            this.projetHeroDataSetGridMission.DataSetName = "ProjetHeroDataSetGridMission";
            this.projetHeroDataSetGridMission.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // incidentBindingSource1
            // 
            this.incidentBindingSource1.DataMember = "Incident";
            this.incidentBindingSource1.DataSource = this.projetHeroDataSetGridMission;
            // 
            // incidentTableAdapter1
            // 
            this.incidentTableAdapter1.ClearBeforeFill = true;
            // 
            // idincidentDataGridViewTextBoxColumn
            // 
            this.idincidentDataGridViewTextBoxColumn.DataPropertyName = "Id_incident";
            this.idincidentDataGridViewTextBoxColumn.HeaderText = "Id_incident";
            this.idincidentDataGridViewTextBoxColumn.Name = "idincidentDataGridViewTextBoxColumn";
            this.idincidentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idcivildeclarantDataGridViewTextBoxColumn
            // 
            this.idcivildeclarantDataGridViewTextBoxColumn.DataPropertyName = "Id_civil_declarant";
            this.idcivildeclarantDataGridViewTextBoxColumn.HeaderText = "Id_civil_declarant";
            this.idcivildeclarantDataGridViewTextBoxColumn.Name = "idcivildeclarantDataGridViewTextBoxColumn";
            this.idcivildeclarantDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateajoutDataGridViewTextBoxColumn
            // 
            this.dateajoutDataGridViewTextBoxColumn.DataPropertyName = "Date_ajout";
            this.dateajoutDataGridViewTextBoxColumn.HeaderText = "Date_ajout";
            this.dateajoutDataGridViewTextBoxColumn.Name = "dateajoutDataGridViewTextBoxColumn";
            this.dateajoutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // natureDataGridViewTextBoxColumn
            // 
            this.natureDataGridViewTextBoxColumn.DataPropertyName = "Nature";
            this.natureDataGridViewTextBoxColumn.HeaderText = "Nature";
            this.natureDataGridViewTextBoxColumn.Name = "natureDataGridViewTextBoxColumn";
            this.natureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Niveau d\'urgence:";
            // 
            // buttonvalider
            // 
            this.buttonvalider.Location = new System.Drawing.Point(353, 493);
            this.buttonvalider.Name = "buttonvalider";
            this.buttonvalider.Size = new System.Drawing.Size(115, 25);
            this.buttonvalider.TabIndex = 10;
            this.buttonvalider.Text = "Valider";
            this.buttonvalider.UseVisualStyleBackColor = true;
            // 
            // projetHeroDataSetHeroMission
            // 
            this.projetHeroDataSetHeroMission.DataSetName = "ProjetHeroDataSetHeroMission";
            this.projetHeroDataSetHeroMission.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // superheroBindingSource
            // 
            this.superheroBindingSource.DataMember = "Super_hero";
            this.superheroBindingSource.DataSource = this.projetHeroDataSetHeroMission;
            // 
            // super_heroTableAdapter
            // 
            this.super_heroTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(422, 130);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(111, 20);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(143, 189);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(108, 20);
            this.dateTimePicker2.TabIndex = 29;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Faible (dangereux)",
            "Moyenne ",
            "Importante",
            "Urgente (Destruction imminente)"});
            this.comboBox2.Location = new System.Drawing.Point(148, 82);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(104, 21);
            this.comboBox2.TabIndex = 30;
            // 
            // Missions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 531);
            this.Controls.Add(this.buttonvalider);
            this.Controls.Add(this.textRecherche);
            this.Controls.Add(this.comborecherche);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Missions";
            this.Text = "Déclaration de mission";
            this.Load += new System.EventHandler(this.Missions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetMission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetGridMission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetHeroMission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superheroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CmbInterSH;
        private System.Windows.Forms.ComboBox CmbNivGravite;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label TitreIncident;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comborecherche;
        private System.Windows.Forms.TextBox textRecherche;
        private ProjetHeroDataSetMission projetHeroDataSetMission;
        private System.Windows.Forms.BindingSource incidentBindingSource;
        private ProjetHeroDataSetMissionTableAdapters.IncidentTableAdapter incidentTableAdapter;
        private ProjetHeroDataSetGridMission projetHeroDataSetGridMission;
        private System.Windows.Forms.BindingSource incidentBindingSource1;
        private ProjetHeroDataSetGridMissionTableAdapters.IncidentTableAdapter incidentTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idincidentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcivildeclarantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateajoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn natureDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonvalider;
        private ProjetHeroDataSetHeroMission projetHeroDataSetHeroMission;
        private System.Windows.Forms.BindingSource superheroBindingSource;
        private ProjetHeroDataSetHeroMissionTableAdapters.Super_heroTableAdapter super_heroTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}