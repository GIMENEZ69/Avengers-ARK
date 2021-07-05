
namespace Avergers
{
    partial class SuperHeros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuperHeros));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbIdCivils = new System.Windows.Forms.ComboBox();
            this.civilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetHeroDataSet2 = new Avergers.ProjetHeroDataSet2();
            this.Pouvoir = new System.Windows.Forms.TextBox();
            this.Commentaire = new System.Windows.Forms.TextBox();
            this.PointFaible = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.labelPointfaible = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.civilsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.civilsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CmdRead = new System.Windows.Forms.Button();
            this.CmdSupp = new System.Windows.Forms.Button();
            this.CmdMaj = new System.Windows.Forms.Button();
            this.CmdCréer = new System.Windows.Forms.Button();
            this.superHerosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.superHerosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CmdQuitter = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idsuperheroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcivilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomheroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pouvoirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointfaibleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentaireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.superheroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetHeroDataSet1 = new Avergers.ProjetHeroDataSet1();
            this.super_heroTableAdapter = new Avergers.ProjetHeroDataSet1TableAdapters.Super_heroTableAdapter();
            this.civilTableAdapter = new Avergers.ProjetHeroDataSet2TableAdapters.CivilTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilsBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superHerosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superHerosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superheroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CmbIdCivils);
            this.groupBox1.Controls.Add(this.Pouvoir);
            this.groupBox1.Controls.Add(this.Commentaire);
            this.groupBox1.Controls.Add(this.PointFaible);
            this.groupBox1.Controls.Add(this.Nom);
            this.groupBox1.Controls.Add(this.Id);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.labelPointfaible);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 171);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Super-Héros";
            // 
            // CmbIdCivils
            // 
            this.CmbIdCivils.AllowDrop = true;
            this.CmbIdCivils.DataSource = this.civilBindingSource;
            this.CmbIdCivils.DisplayMember = "Id_civil";
            this.CmbIdCivils.FormattingEnabled = true;
            this.CmbIdCivils.Location = new System.Drawing.Point(484, 135);
            this.CmbIdCivils.Name = "CmbIdCivils";
            this.CmbIdCivils.Size = new System.Drawing.Size(135, 21);
            this.CmbIdCivils.TabIndex = 37;
            this.CmbIdCivils.ValueMember = "Id_Civils";
            this.CmbIdCivils.SelectedIndexChanged += new System.EventHandler(this.CmbIdCivils_SelectedIndexChanged);
            // 
            // civilBindingSource
            // 
            this.civilBindingSource.DataMember = "Civil";
            this.civilBindingSource.DataSource = this.projetHeroDataSet2;
            // 
            // projetHeroDataSet2
            // 
            this.projetHeroDataSet2.DataSetName = "ProjetHeroDataSet2";
            this.projetHeroDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Pouvoir
            // 
            this.Pouvoir.Location = new System.Drawing.Point(89, 112);
            this.Pouvoir.Name = "Pouvoir";
            this.Pouvoir.Size = new System.Drawing.Size(161, 20);
            this.Pouvoir.TabIndex = 36;
            // 
            // Commentaire
            // 
            this.Commentaire.Location = new System.Drawing.Point(458, 74);
            this.Commentaire.Name = "Commentaire";
            this.Commentaire.Size = new System.Drawing.Size(161, 20);
            this.Commentaire.TabIndex = 27;
            // 
            // PointFaible
            // 
            this.PointFaible.Location = new System.Drawing.Point(458, 24);
            this.PointFaible.Name = "PointFaible";
            this.PointFaible.Size = new System.Drawing.Size(161, 20);
            this.PointFaible.TabIndex = 21;
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(89, 70);
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(378, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Commentaire :";
            // 
            // labelPointfaible
            // 
            this.labelPointfaible.AutoSize = true;
            this.labelPointfaible.Location = new System.Drawing.Point(384, 27);
            this.labelPointfaible.Name = "labelPointfaible";
            this.labelPointfaible.Size = new System.Drawing.Size(68, 13);
            this.labelPointfaible.TabIndex = 10;
            this.labelPointfaible.Text = "Point Faible :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Pouvoir :";
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
            // civilsBindingSource1
            // 
            this.civilsBindingSource1.DataMember = "Civils";
            // 
            // civilsBindingSource
            // 
            this.civilsBindingSource.DataMember = "Civils";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CmdRead);
            this.groupBox2.Controls.Add(this.CmdSupp);
            this.groupBox2.Controls.Add(this.CmdMaj);
            this.groupBox2.Controls.Add(this.CmdCréer);
            this.groupBox2.Location = new System.Drawing.Point(1, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(738, 91);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opérations";
            // 
            // CmdRead
            // 
            this.CmdRead.Location = new System.Drawing.Point(214, 33);
            this.CmdRead.Name = "CmdRead";
            this.CmdRead.Size = new System.Drawing.Size(142, 40);
            this.CmdRead.TabIndex = 3;
            this.CmdRead.Text = "Lire le Super-Héros";
            this.CmdRead.UseVisualStyleBackColor = true;
            this.CmdRead.Click += new System.EventHandler(this.CmdRead_Click);
            // 
            // CmdSupp
            // 
            this.CmdSupp.Location = new System.Drawing.Point(580, 33);
            this.CmdSupp.Name = "CmdSupp";
            this.CmdSupp.Size = new System.Drawing.Size(142, 40);
            this.CmdSupp.TabIndex = 2;
            this.CmdSupp.Text = "Supprimer le Super-Héros";
            this.CmdSupp.UseVisualStyleBackColor = true;
            this.CmdSupp.Click += new System.EventHandler(this.CmdSupp_Click);
            // 
            // CmdMaj
            // 
            this.CmdMaj.Location = new System.Drawing.Point(387, 33);
            this.CmdMaj.Name = "CmdMaj";
            this.CmdMaj.Size = new System.Drawing.Size(161, 40);
            this.CmdMaj.TabIndex = 1;
            this.CmdMaj.Text = "Mettre à jour le Super-Héros";
            this.CmdMaj.UseVisualStyleBackColor = true;
            this.CmdMaj.Click += new System.EventHandler(this.CmdMaj_Click);
            // 
            // CmdCréer
            // 
            this.CmdCréer.Location = new System.Drawing.Point(18, 33);
            this.CmdCréer.Name = "CmdCréer";
            this.CmdCréer.Size = new System.Drawing.Size(161, 40);
            this.CmdCréer.TabIndex = 0;
            this.CmdCréer.Text = "Créer le Super-Héros";
            this.CmdCréer.UseVisualStyleBackColor = true;
            this.CmdCréer.Click += new System.EventHandler(this.CmdCréer_Click);
            // 
            // superHerosBindingSource1
            // 
            this.superHerosBindingSource1.DataMember = "SuperHeros";
            // 
            // superHerosBindingSource
            // 
            this.superHerosBindingSource.DataMember = "SuperHeros";
            // 
            // CmdQuitter
            // 
            this.CmdQuitter.Location = new System.Drawing.Point(294, 616);
            this.CmdQuitter.Name = "CmdQuitter";
            this.CmdQuitter.Size = new System.Drawing.Size(102, 35);
            this.CmdQuitter.TabIndex = 40;
            this.CmdQuitter.Text = "Fermer";
            this.CmdQuitter.UseVisualStyleBackColor = true;
            this.CmdQuitter.Click += new System.EventHandler(this.CmdQuitter_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsuperheroDataGridViewTextBoxColumn,
            this.idcivilDataGridViewTextBoxColumn,
            this.nomheroDataGridViewTextBoxColumn,
            this.pouvoirDataGridViewTextBoxColumn,
            this.pointfaibleDataGridViewTextBoxColumn,
            this.commentaireDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.superheroBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(735, 300);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick_1);
            // 
            // idsuperheroDataGridViewTextBoxColumn
            // 
            this.idsuperheroDataGridViewTextBoxColumn.DataPropertyName = "Id_super_hero";
            this.idsuperheroDataGridViewTextBoxColumn.HeaderText = "Id_super_hero";
            this.idsuperheroDataGridViewTextBoxColumn.Name = "idsuperheroDataGridViewTextBoxColumn";
            // 
            // idcivilDataGridViewTextBoxColumn
            // 
            this.idcivilDataGridViewTextBoxColumn.DataPropertyName = "Id_civil";
            this.idcivilDataGridViewTextBoxColumn.HeaderText = "Id_civil";
            this.idcivilDataGridViewTextBoxColumn.Name = "idcivilDataGridViewTextBoxColumn";
            // 
            // nomheroDataGridViewTextBoxColumn
            // 
            this.nomheroDataGridViewTextBoxColumn.DataPropertyName = "Nom_hero";
            this.nomheroDataGridViewTextBoxColumn.HeaderText = "Nom_hero";
            this.nomheroDataGridViewTextBoxColumn.Name = "nomheroDataGridViewTextBoxColumn";
            // 
            // pouvoirDataGridViewTextBoxColumn
            // 
            this.pouvoirDataGridViewTextBoxColumn.DataPropertyName = "Pouvoir";
            this.pouvoirDataGridViewTextBoxColumn.HeaderText = "Pouvoir";
            this.pouvoirDataGridViewTextBoxColumn.Name = "pouvoirDataGridViewTextBoxColumn";
            // 
            // pointfaibleDataGridViewTextBoxColumn
            // 
            this.pointfaibleDataGridViewTextBoxColumn.DataPropertyName = "Point_faible";
            this.pointfaibleDataGridViewTextBoxColumn.HeaderText = "Point_faible";
            this.pointfaibleDataGridViewTextBoxColumn.Name = "pointfaibleDataGridViewTextBoxColumn";
            // 
            // commentaireDataGridViewTextBoxColumn
            // 
            this.commentaireDataGridViewTextBoxColumn.DataPropertyName = "Commentaire";
            this.commentaireDataGridViewTextBoxColumn.HeaderText = "Commentaire";
            this.commentaireDataGridViewTextBoxColumn.Name = "commentaireDataGridViewTextBoxColumn";
            // 
            // superheroBindingSource
            // 
            this.superheroBindingSource.DataMember = "Super_hero";
            this.superheroBindingSource.DataSource = this.projetHeroDataSet1;
            // 
            // projetHeroDataSet1
            // 
            this.projetHeroDataSet1.DataSetName = "ProjetHeroDataSet1";
            this.projetHeroDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // super_heroTableAdapter
            // 
            this.super_heroTableAdapter.ClearBeforeFill = true;
            // 
            // civilTableAdapter
            // 
            this.civilTableAdapter.ClearBeforeFill = true;
            // 
            // SuperHeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 653);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CmdQuitter);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SuperHeros";
            this.Text = "Création d\'un super héros";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilsBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.superHerosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superHerosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superheroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CmbIdCivils;
        private System.Windows.Forms.TextBox Pouvoir;
        private System.Windows.Forms.TextBox Commentaire;
        private System.Windows.Forms.TextBox PointFaible;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelPointfaible;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CmdRead;
        private System.Windows.Forms.Button CmdSupp;
        private System.Windows.Forms.Button CmdMaj;
        private System.Windows.Forms.Button CmdCréer;
        private System.Windows.Forms.BindingSource superHerosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSuperHerosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomSuperHerosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pouvoirSuperHerosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointFaibleSuperHerosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreSuperHerosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentaireSuperHerosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCivilsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource civilsBindingSource;
        private System.Windows.Forms.BindingSource civilsBindingSource1;
        private System.Windows.Forms.BindingSource superHerosBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button CmdQuitter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjetHeroDataSet1 projetHeroDataSet1;
        private System.Windows.Forms.BindingSource superheroBindingSource;
        private ProjetHeroDataSet1TableAdapters.Super_heroTableAdapter super_heroTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsuperheroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcivilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomheroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pouvoirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointfaibleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentaireDataGridViewTextBoxColumn;
        private ProjetHeroDataSet2 projetHeroDataSet2;
        private System.Windows.Forms.BindingSource civilBindingSource;
        private ProjetHeroDataSet2TableAdapters.CivilTableAdapter civilTableAdapter;
    }
}