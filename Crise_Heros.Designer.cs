
namespace Avergers
{
    partial class Crise_Heros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crise_Heros));
            this.CmdValider = new System.Windows.Forms.Button();
            this.IdSH = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idcivilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datenaissanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.civilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetHeroDataSetCriseHeros = new Avergers.ProjetHeroDataSetCriseHeros();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmdIdSH = new System.Windows.Forms.Button();
            this.IdMission = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NomSH = new System.Windows.Forms.TextBox();
            this.missionsupervilainBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.missionsupervilainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.civilTableAdapter = new Avergers.ProjetHeroDataSetCriseHerosTableAdapters.CivilTableAdapter();
            this.projetHeroDataSetherosmission = new Avergers.ProjetHeroDataSetherosmission();
            this.superheroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.super_heroTableAdapter = new Avergers.ProjetHeroDataSetherosmissionTableAdapters.Super_heroTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomheroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.missionsuperheroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetHeroDataSetCriseSH = new Avergers.ProjetHeroDataSetCriseSH();
            this.mission_superheroTableAdapter = new Avergers.ProjetHeroDataSetCriseSHTableAdapters.Mission_superheroTableAdapter();
            this.CmbSelecRech = new System.Windows.Forms.ComboBox();
            this.Recherche = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CmdSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetCriseHeros)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.missionsupervilainBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.missionsupervilainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetherosmission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superheroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.missionsuperheroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetCriseSH)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdValider
            // 
            this.CmdValider.Location = new System.Drawing.Point(303, 500);
            this.CmdValider.Name = "CmdValider";
            this.CmdValider.Size = new System.Drawing.Size(117, 51);
            this.CmdValider.TabIndex = 5;
            this.CmdValider.Text = "Valider";
            this.CmdValider.UseVisualStyleBackColor = true;
            this.CmdValider.Click += new System.EventHandler(this.CmdValider_Click);
            // 
            // IdSH
            // 
            this.IdSH.Location = new System.Drawing.Point(221, 36);
            this.IdSH.Name = "IdSH";
            this.IdSH.Size = new System.Drawing.Size(67, 20);
            this.IdSH.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcivilDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.datenaissanceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.civilBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 104);
            this.dataGridView1.TabIndex = 11;
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
            // civilBindingSource
            // 
            this.civilBindingSource.DataMember = "Civil";
            this.civilBindingSource.DataSource = this.projetHeroDataSetCriseHeros;
            // 
            // projetHeroDataSetCriseHeros
            // 
            this.projetHeroDataSetCriseHeros.DataSetName = "ProjetHeroDataSetCriseHeros";
            this.projetHeroDataSetCriseHeros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CmdIdSH);
            this.groupBox1.Controls.Add(this.IdMission);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.NomSH);
            this.groupBox1.Controls.Add(this.IdSH);
            this.groupBox1.Location = new System.Drawing.Point(21, 386);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 97);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Super Héros";
            // 
            // CmdIdSH
            // 
            this.CmdIdSH.Location = new System.Drawing.Point(129, 28);
            this.CmdIdSH.Name = "CmdIdSH";
            this.CmdIdSH.Size = new System.Drawing.Size(86, 34);
            this.CmdIdSH.TabIndex = 20;
            this.CmdIdSH.Text = "Id Super heros";
            this.CmdIdSH.UseVisualStyleBackColor = true;
            this.CmdIdSH.Click += new System.EventHandler(this.CmdIdSH_Click);
            // 
            // IdMission
            // 
            this.IdMission.Location = new System.Drawing.Point(6, 36);
            this.IdMission.Name = "IdMission";
            this.IdMission.Size = new System.Drawing.Size(60, 20);
            this.IdMission.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nom du Super Héros démasqué :";
            // 
            // NomSH
            // 
            this.NomSH.Location = new System.Drawing.Point(494, 36);
            this.NomSH.Name = "NomSH";
            this.NomSH.Size = new System.Drawing.Size(138, 20);
            this.NomSH.TabIndex = 10;
            // 
            // missionsupervilainBindingSource1
            // 
            this.missionsupervilainBindingSource1.DataMember = "Mission_supervilain";
            // 
            // missionsupervilainBindingSource
            // 
            this.missionsupervilainBindingSource.DataMember = "Mission_supervilain";
            // 
            // civilTableAdapter
            // 
            this.civilTableAdapter.ClearBeforeFill = true;
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
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.nomheroDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.missionsuperheroBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(195, 216);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(290, 98);
            this.dataGridView2.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id_mission";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id_mission";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // nomheroDataGridViewTextBoxColumn
            // 
            this.nomheroDataGridViewTextBoxColumn.DataPropertyName = "nom_hero";
            this.nomheroDataGridViewTextBoxColumn.HeaderText = "nom_hero";
            this.nomheroDataGridViewTextBoxColumn.Name = "nomheroDataGridViewTextBoxColumn";
            // 
            // missionsuperheroBindingSource
            // 
            this.missionsuperheroBindingSource.DataMember = "Mission_superhero";
            this.missionsuperheroBindingSource.DataSource = this.projetHeroDataSetCriseSH;
            // 
            // projetHeroDataSetCriseSH
            // 
            this.projetHeroDataSetCriseSH.DataSetName = "ProjetHeroDataSetCriseSH";
            this.projetHeroDataSetCriseSH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mission_superheroTableAdapter
            // 
            this.mission_superheroTableAdapter.ClearBeforeFill = true;
            // 
            // CmbSelecRech
            // 
            this.CmbSelecRech.FormattingEnabled = true;
            this.CmbSelecRech.Items.AddRange(new object[] {
            "Id_mission",
            "Id_super_hero",
            "nom_hero"});
            this.CmbSelecRech.Location = new System.Drawing.Point(162, 172);
            this.CmbSelecRech.Name = "CmbSelecRech";
            this.CmbSelecRech.Size = new System.Drawing.Size(99, 21);
            this.CmbSelecRech.TabIndex = 18;
            // 
            // Recherche
            // 
            this.Recherche.Location = new System.Drawing.Point(499, 172);
            this.Recherche.Name = "Recherche";
            this.Recherche.Size = new System.Drawing.Size(126, 20);
            this.Recherche.TabIndex = 17;
            this.Recherche.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Recherche_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Saisir votre recherche :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Rechercher par :";
            // 
            // CmdSelect
            // 
            this.CmdSelect.Location = new System.Drawing.Point(256, 331);
            this.CmdSelect.Name = "CmdSelect";
            this.CmdSelect.Size = new System.Drawing.Size(181, 34);
            this.CmdSelect.TabIndex = 19;
            this.CmdSelect.Text = "Sélectionner la mission";
            this.CmdSelect.UseVisualStyleBackColor = true;
            this.CmdSelect.Click += new System.EventHandler(this.CmdSelect_Click);
            // 
            // Crise_Heros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 563);
            this.Controls.Add(this.CmdSelect);
            this.Controls.Add(this.CmbSelecRech);
            this.Controls.Add(this.Recherche);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CmdValider);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Crise_Heros";
            this.Text = "Crise";
            this.Load += new System.EventHandler(this.Crise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetCriseHeros)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.missionsupervilainBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.missionsupervilainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetherosmission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superheroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.missionsuperheroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetCriseSH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CmdValider;
        private System.Windows.Forms.TextBox IdSH;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource missionsupervilainBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsupervilainDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource missionsupervilainBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private ProjetHeroDataSetCriseHeros projetHeroDataSetCriseHeros;
        private System.Windows.Forms.BindingSource civilBindingSource;
        private ProjetHeroDataSetCriseHerosTableAdapters.CivilTableAdapter civilTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcivilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datenaissanceDataGridViewTextBoxColumn;
        private ProjetHeroDataSetherosmission projetHeroDataSetherosmission;
        private System.Windows.Forms.BindingSource superheroBindingSource;
        private ProjetHeroDataSetherosmissionTableAdapters.Super_heroTableAdapter super_heroTableAdapter;
        private System.Windows.Forms.TextBox NomSH;
        private System.Windows.Forms.DataGridView dataGridView2;
        private ProjetHeroDataSetCriseSH projetHeroDataSetCriseSH;
        private System.Windows.Forms.BindingSource missionsuperheroBindingSource;
        private ProjetHeroDataSetCriseSHTableAdapters.Mission_superheroTableAdapter mission_superheroTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbSelecRech;
        private System.Windows.Forms.TextBox Recherche;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox IdMission;
        private System.Windows.Forms.Button CmdSelect;
        private System.Windows.Forms.Button CmdIdSH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomheroDataGridViewTextBoxColumn;
    }
}