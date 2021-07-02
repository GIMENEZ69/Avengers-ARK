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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Missions));
            this.CmdAnnuler = new System.Windows.Forms.Button();
            this.CmdValider = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TitreIncident = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CmbInterSH = new System.Windows.Forms.ComboBox();
            this.CmbNivGravite = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.incidentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetHeroDataSet6 = new Avergers.ProjetHeroDataSet6();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.cboColonne = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.incidentTableAdapter = new Avergers.ProjetHeroDataSet6TableAdapters.IncidentTableAdapter();
            this.DateFin = new System.Windows.Forms.DateTimePicker();
            this.DateDebut = new System.Windows.Forms.DateTimePicker();
            this.CmbUrgence = new System.Windows.Forms.ComboBox();
            this.projetHeroDataSet7 = new Avergers.ProjetHeroDataSet7();
            this.superheroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.super_heroTableAdapter = new Avergers.ProjetHeroDataSet7TableAdapters.Super_heroTableAdapter();
            this.idincidentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateajoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.natureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet6)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superheroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdAnnuler
            // 
            this.CmdAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAnnuler.Location = new System.Drawing.Point(552, 520);
            this.CmdAnnuler.Name = "CmdAnnuler";
            this.CmdAnnuler.Size = new System.Drawing.Size(111, 62);
            this.CmdAnnuler.TabIndex = 6;
            this.CmdAnnuler.Text = "Annuler";
            this.CmdAnnuler.UseVisualStyleBackColor = true;
            this.CmdAnnuler.Click += new System.EventHandler(this.CmdAnnuler_Click);
            // 
            // CmdValider
            // 
            this.CmdValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdValider.Location = new System.Drawing.Point(82, 520);
            this.CmdValider.Name = "CmdValider";
            this.CmdValider.Size = new System.Drawing.Size(115, 62);
            this.CmdValider.TabIndex = 5;
            this.CmdValider.Text = "Valider la mission";
            this.CmdValider.UseVisualStyleBackColor = true;
            this.CmdValider.Click += new System.EventHandler(this.CmdValider_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CmbUrgence);
            this.groupBox1.Controls.Add(this.DateDebut);
            this.groupBox1.Controls.Add(this.DateFin);
            this.groupBox1.Controls.Add(this.TitreIncident);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.CmbInterSH);
            this.groupBox1.Controls.Add(this.CmbNivGravite);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 166);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mission :";
            // 
            // TitreIncident
            // 
            this.TitreIncident.Location = new System.Drawing.Point(133, 33);
            this.TitreIncident.Name = "TitreIncident";
            this.TitreIncident.Size = new System.Drawing.Size(100, 20);
            this.TitreIncident.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(538, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Niveau d\'urgence :";
            // 
            // CmbInterSH
            // 
            this.CmbInterSH.DataSource = this.superheroBindingSource;
            this.CmbInterSH.DisplayMember = "Nom_hero";
            this.CmbInterSH.FormattingEnabled = true;
            this.CmbInterSH.Location = new System.Drawing.Point(654, 128);
            this.CmbInterSH.Name = "CmbInterSH";
            this.CmbInterSH.Size = new System.Drawing.Size(116, 21);
            this.CmbInterSH.TabIndex = 22;
            this.CmbInterSH.ValueMember = "Nom_hero";
            // 
            // CmbNivGravite
            // 
            this.CmbNivGravite.FormattingEnabled = true;
            this.CmbNivGravite.Items.AddRange(new object[] {
            "Faible (dangereux)",
            "Moyenne ",
            "Importante",
            "Urgente (Destruction imminente)"});
            this.CmbNivGravite.Location = new System.Drawing.Point(659, 32);
            this.CmbNivGravite.Name = "CmbNivGravite";
            this.CmbNivGravite.Size = new System.Drawing.Size(115, 21);
            this.CmbNivGravite.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(537, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Niveau de gravité :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(528, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Intervention Héros :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date de fin de mission :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-9, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date de début de la mission :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titre de la mission :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idincidentDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.dateajoutDataGridViewTextBoxColumn,
            this.natureDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.incidentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(763, 134);
            this.dataGridView1.TabIndex = 7;
            // 
            // incidentBindingSource
            // 
            this.incidentBindingSource.DataMember = "Incident";
            this.incidentBindingSource.DataSource = this.projetHeroDataSet6;
            // 
            // projetHeroDataSet6
            // 
            this.projetHeroDataSet6.DataSetName = "ProjetHeroDataSet6";
            this.projetHeroDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textSearch);
            this.groupBox2.Controls.Add(this.cboColonne);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(20, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(756, 108);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Le déclarant";
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(519, 47);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(157, 20);
            this.textSearch.TabIndex = 4;
            this.textSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textSearch_KeyDown);
            // 
            // cboColonne
            // 
            this.cboColonne.FormattingEnabled = true;
            this.cboColonne.Items.AddRange(new object[] {
            "Id_Civil",
            "Nom",
            "Prenom",
            "Adresse",
            "Date_naissance"});
            this.cboColonne.Location = new System.Drawing.Point(168, 47);
            this.cboColonne.Name = "cboColonne";
            this.cboColonne.Size = new System.Drawing.Size(137, 21);
            this.cboColonne.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(373, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Saisir votre recherche :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Rechercher par :";
            // 
            // incidentTableAdapter
            // 
            this.incidentTableAdapter.ClearBeforeFill = true;
            // 
            // DateFin
            // 
            this.DateFin.Location = new System.Drawing.Point(188, 131);
            this.DateFin.Name = "DateFin";
            this.DateFin.Size = new System.Drawing.Size(200, 20);
            this.DateFin.TabIndex = 25;
            // 
            // DateDebut
            // 
            this.DateDebut.Location = new System.Drawing.Point(170, 86);
            this.DateDebut.Name = "DateDebut";
            this.DateDebut.Size = new System.Drawing.Size(200, 20);
            this.DateDebut.TabIndex = 26;
            // 
            // CmbUrgence
            // 
            this.CmbUrgence.FormattingEnabled = true;
            this.CmbUrgence.Items.AddRange(new object[] {
            "Faible ",
            "Moyenne ",
            "Importante",
            "Urgente"});
            this.CmbUrgence.Location = new System.Drawing.Point(659, 69);
            this.CmbUrgence.Name = "CmbUrgence";
            this.CmbUrgence.Size = new System.Drawing.Size(115, 21);
            this.CmbUrgence.TabIndex = 27;
            // 
            // projetHeroDataSet7
            // 
            this.projetHeroDataSet7.DataSetName = "ProjetHeroDataSet7";
            this.projetHeroDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // superheroBindingSource
            // 
            this.superheroBindingSource.DataMember = "Super_hero";
            this.superheroBindingSource.DataSource = this.projetHeroDataSet7;
            // 
            // super_heroTableAdapter
            // 
            this.super_heroTableAdapter.ClearBeforeFill = true;
            // 
            // idincidentDataGridViewTextBoxColumn
            // 
            this.idincidentDataGridViewTextBoxColumn.DataPropertyName = "Id_incident";
            this.idincidentDataGridViewTextBoxColumn.HeaderText = "Id de l\'incident";
            this.idincidentDataGridViewTextBoxColumn.Name = "idincidentDataGridViewTextBoxColumn";
            this.idincidentDataGridViewTextBoxColumn.ReadOnly = true;
            this.idincidentDataGridViewTextBoxColumn.Width = 180;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.Width = 180;
            // 
            // dateajoutDataGridViewTextBoxColumn
            // 
            this.dateajoutDataGridViewTextBoxColumn.DataPropertyName = "Date_ajout";
            this.dateajoutDataGridViewTextBoxColumn.HeaderText = "Date de l\'ajout";
            this.dateajoutDataGridViewTextBoxColumn.Name = "dateajoutDataGridViewTextBoxColumn";
            this.dateajoutDataGridViewTextBoxColumn.Width = 180;
            // 
            // natureDataGridViewTextBoxColumn
            // 
            this.natureDataGridViewTextBoxColumn.DataPropertyName = "Nature";
            this.natureDataGridViewTextBoxColumn.HeaderText = "Nature";
            this.natureDataGridViewTextBoxColumn.Name = "natureDataGridViewTextBoxColumn";
            this.natureDataGridViewTextBoxColumn.Width = 180;
            // 
            // Missions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 594);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CmdAnnuler);
            this.Controls.Add(this.CmdValider);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Missions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Missions";
            this.Load += new System.EventHandler(this.Missions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet6)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superheroBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CmdAnnuler;
        private System.Windows.Forms.Button CmdValider;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CmbInterSH;
        private System.Windows.Forms.ComboBox CmbNivGravite;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.ComboBox cboColonne;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private ProjetHeroDataSet6 projetHeroDataSet6;
        private System.Windows.Forms.BindingSource incidentBindingSource;
        private ProjetHeroDataSet6TableAdapters.IncidentTableAdapter incidentTableAdapter;
        private System.Windows.Forms.TextBox TitreIncident;
        private System.Windows.Forms.ComboBox CmbUrgence;
        private System.Windows.Forms.DateTimePicker DateDebut;
        private System.Windows.Forms.DateTimePicker DateFin;
        private ProjetHeroDataSet7 projetHeroDataSet7;
        private System.Windows.Forms.BindingSource superheroBindingSource;
        private ProjetHeroDataSet7TableAdapters.Super_heroTableAdapter super_heroTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idincidentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateajoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn natureDataGridViewTextBoxColumn;
    }
}