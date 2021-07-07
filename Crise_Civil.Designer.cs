
namespace Avergers
{
    partial class Crise_Civil
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
            this.CoutDommage = new System.Windows.Forms.TextBox();
            this.NomCivilMort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idcivilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datenaissanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datedecesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateajoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datemodificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.civilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetHeroDataSetCivil = new Avergers.ProjetHeroDataSetCivil();
            this.projetHeroDataSetCivilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.civilTableAdapter = new Avergers.ProjetHeroDataSetCivilTableAdapters.CivilTableAdapter();
            this.CmbSelecRech = new System.Windows.Forms.ComboBox();
            this.Recherche = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CmdSelect = new System.Windows.Forms.Button();
            this.DateDeces = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbProces = new System.Windows.Forms.ComboBox();
            this.CmdValider = new System.Windows.Forms.Button();
            this.IdLitige = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.IdCrise = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.IdMission = new System.Windows.Forms.TextBox();
            this.CmdIdMission = new System.Windows.Forms.Button();
            this.IdCivil = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetCivil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetCivilBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CoutDommage
            // 
            this.CoutDommage.Location = new System.Drawing.Point(172, 307);
            this.CoutDommage.Name = "CoutDommage";
            this.CoutDommage.Size = new System.Drawing.Size(131, 20);
            this.CoutDommage.TabIndex = 16;
            // 
            // NomCivilMort
            // 
            this.NomCivilMort.Location = new System.Drawing.Point(235, 268);
            this.NomCivilMort.Name = "NomCivilMort";
            this.NomCivilMort.Size = new System.Drawing.Size(131, 20);
            this.NomCivilMort.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Coût des dommages latéraux :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nom du Civil mort :";
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
            this.dataGridView1.DataSource = this.civilBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(737, 126);
            this.dataGridView1.TabIndex = 19;
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
            // projetHeroDataSetCivilBindingSource
            // 
            this.projetHeroDataSetCivilBindingSource.DataSource = this.projetHeroDataSetCivil;
            this.projetHeroDataSetCivilBindingSource.Position = 0;
            // 
            // civilTableAdapter
            // 
            this.civilTableAdapter.ClearBeforeFill = true;
            // 
            // CmbSelecRech
            // 
            this.CmbSelecRech.FormattingEnabled = true;
            this.CmbSelecRech.Items.AddRange(new object[] {
            "Id_civil",
            "Nom",
            "Prenom",
            "Date_deces"});
            this.CmbSelecRech.Location = new System.Drawing.Point(217, 22);
            this.CmbSelecRech.Name = "CmbSelecRech";
            this.CmbSelecRech.Size = new System.Drawing.Size(99, 21);
            this.CmbSelecRech.TabIndex = 23;
            // 
            // Recherche
            // 
            this.Recherche.Location = new System.Drawing.Point(554, 22);
            this.Recherche.Name = "Recherche";
            this.Recherche.Size = new System.Drawing.Size(126, 20);
            this.Recherche.TabIndex = 22;
            this.Recherche.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Recherche_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Saisir votre recherche :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(118, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Rechercher par :";
            // 
            // CmdSelect
            // 
            this.CmdSelect.Location = new System.Drawing.Point(325, 197);
            this.CmdSelect.Name = "CmdSelect";
            this.CmdSelect.Size = new System.Drawing.Size(150, 51);
            this.CmdSelect.TabIndex = 24;
            this.CmdSelect.Text = "Sélectionner le civil";
            this.CmdSelect.UseVisualStyleBackColor = true;
            this.CmdSelect.Click += new System.EventHandler(this.CmdSelect_Click);
            // 
            // DateDeces
            // 
            this.DateDeces.Location = new System.Drawing.Point(464, 268);
            this.DateDeces.Name = "DateDeces";
            this.DateDeces.Size = new System.Drawing.Size(131, 20);
            this.DateDeces.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Date du décès :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Déclenchement d\'un procès ?";
            // 
            // CmbProces
            // 
            this.CmbProces.FormattingEnabled = true;
            this.CmbProces.Items.AddRange(new object[] {
            "Oui",
            "Non"});
            this.CmbProces.Location = new System.Drawing.Point(479, 306);
            this.CmbProces.Name = "CmbProces";
            this.CmbProces.Size = new System.Drawing.Size(87, 21);
            this.CmbProces.TabIndex = 28;
            // 
            // CmdValider
            // 
            this.CmdValider.Location = new System.Drawing.Point(325, 379);
            this.CmdValider.Name = "CmdValider";
            this.CmdValider.Size = new System.Drawing.Size(150, 51);
            this.CmdValider.TabIndex = 29;
            this.CmdValider.Text = "Valider";
            this.CmdValider.UseVisualStyleBackColor = true;
            this.CmdValider.Click += new System.EventHandler(this.CmdValider_Click);
            // 
            // IdLitige
            // 
            this.IdLitige.Location = new System.Drawing.Point(719, 307);
            this.IdLitige.Name = "IdLitige";
            this.IdLitige.Size = new System.Drawing.Size(66, 20);
            this.IdLitige.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(601, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Création d\'un Id litige :";
            // 
            // IdCrise
            // 
            this.IdCrise.Location = new System.Drawing.Point(719, 268);
            this.IdCrise.Name = "IdCrise";
            this.IdCrise.Size = new System.Drawing.Size(66, 20);
            this.IdCrise.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(601, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Création d\'un Id crise :";
            // 
            // IdMission
            // 
            this.IdMission.Location = new System.Drawing.Point(122, 346);
            this.IdMission.Name = "IdMission";
            this.IdMission.Size = new System.Drawing.Size(66, 20);
            this.IdMission.TabIndex = 35;
            // 
            // CmdIdMission
            // 
            this.CmdIdMission.Location = new System.Drawing.Point(23, 342);
            this.CmdIdMission.Name = "CmdIdMission";
            this.CmdIdMission.Size = new System.Drawing.Size(93, 27);
            this.CmdIdMission.TabIndex = 36;
            this.CmdIdMission.Text = "Id mission :";
            this.CmdIdMission.UseVisualStyleBackColor = true;
            this.CmdIdMission.Click += new System.EventHandler(this.CmdIdMission_Click);
            // 
            // IdCivil
            // 
            this.IdCivil.Location = new System.Drawing.Point(67, 268);
            this.IdCivil.Name = "IdCivil";
            this.IdCivil.Size = new System.Drawing.Size(31, 20);
            this.IdCivil.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Id Civil :";
            // 
            // Crise_Civil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IdCivil);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CmdIdMission);
            this.Controls.Add(this.IdMission);
            this.Controls.Add(this.IdCrise);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.IdLitige);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CmdValider);
            this.Controls.Add(this.CmbProces);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateDeces);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmdSelect);
            this.Controls.Add(this.CmbSelecRech);
            this.Controls.Add(this.Recherche);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CoutDommage);
            this.Controls.Add(this.NomCivilMort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "Crise_Civil";
            this.Text = "Crise_Civil";
            this.Load += new System.EventHandler(this.Crise_Civil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetCivil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetCivilBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox CoutDommage;
        private System.Windows.Forms.TextBox NomCivilMort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource projetHeroDataSetCivilBindingSource;
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
        private System.Windows.Forms.ComboBox CmbSelecRech;
        private System.Windows.Forms.TextBox Recherche;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button CmdSelect;
        private System.Windows.Forms.TextBox DateDeces;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbProces;
        private System.Windows.Forms.Button CmdValider;
        private System.Windows.Forms.TextBox IdLitige;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IdCrise;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox IdMission;
        private System.Windows.Forms.Button CmdIdMission;
        private System.Windows.Forms.TextBox IdCivil;
        private System.Windows.Forms.Label label9;
    }
}