
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.civilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetHeroDataSet2FkIdCivil = new Avergers.ProjetHeroDataSet2FkIdCivil();
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
            this.civilsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.avengersDBDataSetCmbIdCivils = new Avergers.AvengersDBDataSetCmbIdCivils();
            this.civilsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.avengersDBDataSet = new Avergers.AvengersDBDataSetGridViewCivils();
            this.civilsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CmdRead = new System.Windows.Forms.Button();
            this.CmdSupp = new System.Windows.Forms.Button();
            this.CmdMaj = new System.Windows.Forms.Button();
            this.CmdCréer = new System.Windows.Forms.Button();
            this.superHerosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.superHerosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.civilsTableAdapter = new Avergers.AvengersDBDataSetGridViewCivilsTableAdapters.CivilsTableAdapter();
            this.dataGridViewSuperHeros = new System.Windows.Forms.DataGridView();
            this.idsuperheroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcivilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomheroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pouvoirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointfaibleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentaireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.superheroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetHeroDataSet1 = new Avergers.ProjetHeroDataSet1();
            this.superHerosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.avengersDBDataSetGridViewCivils2 = new Avergers.AvengersDBDataSetGridViewCivils2();
            this.superHerosTableAdapter = new Avergers.AvengersDBDataSetGridViewCivils2TableAdapters.SuperHerosTableAdapter();
            this.civilsTableAdapter1 = new Avergers.AvengersDBDataSetCmbIdCivilsTableAdapters.CivilsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.super_heroTableAdapter = new Avergers.ProjetHeroDataSet1TableAdapters.Super_heroTableAdapter();
            this.civilTableAdapter = new Avergers.ProjetHeroDataSet2FkIdCivilTableAdapters.CivilTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet2FkIdCivil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avengersDBDataSetCmbIdCivils)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avengersDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilsBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superHerosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superHerosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuperHeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superheroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superHerosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avengersDBDataSetGridViewCivils2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox1);
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
            this.groupBox1.Location = new System.Drawing.Point(30, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 220);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Super-Héros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(378, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Id Civil :";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.civilBindingSource;
            this.comboBox1.DisplayMember = "Id_civil";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(438, 162);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 21);
            this.comboBox1.TabIndex = 37;
            this.comboBox1.ValueMember = "Id_Civils";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // civilBindingSource
            // 
            this.civilBindingSource.DataMember = "Civil";
            this.civilBindingSource.DataSource = this.projetHeroDataSet2FkIdCivil;
            // 
            // projetHeroDataSet2FkIdCivil
            // 
            this.projetHeroDataSet2FkIdCivil.DataSetName = "ProjetHeroDataSet2FkIdCivil";
            this.projetHeroDataSet2FkIdCivil.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Pouvoir
            // 
            this.Pouvoir.Location = new System.Drawing.Point(89, 161);
            this.Pouvoir.Name = "Pouvoir";
            this.Pouvoir.Size = new System.Drawing.Size(161, 20);
            this.Pouvoir.TabIndex = 36;
            // 
            // Commentaire
            // 
            this.Commentaire.Location = new System.Drawing.Point(438, 103);
            this.Commentaire.Name = "Commentaire";
            this.Commentaire.Size = new System.Drawing.Size(161, 20);
            this.Commentaire.TabIndex = 27;
            // 
            // PointFaible
            // 
            this.PointFaible.Location = new System.Drawing.Point(438, 39);
            this.PointFaible.Name = "PointFaible";
            this.PointFaible.Size = new System.Drawing.Size(161, 20);
            this.PointFaible.TabIndex = 21;
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(89, 101);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(161, 20);
            this.Nom.TabIndex = 17;
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(89, 39);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(161, 20);
            this.Id.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(345, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Commentaire :";
            // 
            // labelPointfaible
            // 
            this.labelPointfaible.AutoSize = true;
            this.labelPointfaible.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPointfaible.Location = new System.Drawing.Point(350, 43);
            this.labelPointfaible.Name = "labelPointfaible";
            this.labelPointfaible.Size = new System.Drawing.Size(82, 13);
            this.labelPointfaible.TabIndex = 10;
            this.labelPointfaible.Text = "Point Faible :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Pouvoir :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id :";
            // 
            // civilsBindingSource2
            // 
            this.civilsBindingSource2.DataMember = "Civils";
            this.civilsBindingSource2.DataSource = this.avengersDBDataSetCmbIdCivils;
            // 
            // avengersDBDataSetCmbIdCivils
            // 
            this.avengersDBDataSetCmbIdCivils.DataSetName = "AvengersDBDataSetCmbIdCivils";
            this.avengersDBDataSetCmbIdCivils.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // civilsBindingSource1
            // 
            this.civilsBindingSource1.DataMember = "Civils";
            this.civilsBindingSource1.DataSource = this.avengersDBDataSet;
            // 
            // avengersDBDataSet
            // 
            this.avengersDBDataSet.DataSetName = "AvengersDBDataSet";
            this.avengersDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.groupBox2.Location = new System.Drawing.Point(30, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(627, 186);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opérations";
            // 
            // CmdRead
            // 
            this.CmdRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdRead.Location = new System.Drawing.Point(381, 25);
            this.CmdRead.Name = "CmdRead";
            this.CmdRead.Size = new System.Drawing.Size(151, 40);
            this.CmdRead.TabIndex = 3;
            this.CmdRead.Text = "Lire le Super-Héros";
            this.CmdRead.UseVisualStyleBackColor = true;
            this.CmdRead.Click += new System.EventHandler(this.CmdRead_Click);
            // 
            // CmdSupp
            // 
            this.CmdSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdSupp.Location = new System.Drawing.Point(381, 122);
            this.CmdSupp.Name = "CmdSupp";
            this.CmdSupp.Size = new System.Drawing.Size(151, 40);
            this.CmdSupp.TabIndex = 2;
            this.CmdSupp.Text = "Supprimer Super-Héros";
            this.CmdSupp.UseVisualStyleBackColor = true;
            this.CmdSupp.Click += new System.EventHandler(this.CmdSupp_Click);
            // 
            // CmdMaj
            // 
            this.CmdMaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdMaj.Location = new System.Drawing.Point(80, 122);
            this.CmdMaj.Name = "CmdMaj";
            this.CmdMaj.Size = new System.Drawing.Size(161, 40);
            this.CmdMaj.TabIndex = 1;
            this.CmdMaj.Text = "Modifier le Super-Héros";
            this.CmdMaj.UseVisualStyleBackColor = true;
            this.CmdMaj.Click += new System.EventHandler(this.CmdMaj_Click);
            // 
            // CmdCréer
            // 
            this.CmdCréer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdCréer.Location = new System.Drawing.Point(80, 25);
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
            // civilsTableAdapter
            // 
            this.civilsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewSuperHeros
            // 
            this.dataGridViewSuperHeros.AllowUserToOrderColumns = true;
            this.dataGridViewSuperHeros.AutoGenerateColumns = false;
            this.dataGridViewSuperHeros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSuperHeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSuperHeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsuperheroDataGridViewTextBoxColumn,
            this.idcivilDataGridViewTextBoxColumn,
            this.nomheroDataGridViewTextBoxColumn,
            this.pouvoirDataGridViewTextBoxColumn,
            this.pointfaibleDataGridViewTextBoxColumn,
            this.commentaireDataGridViewTextBoxColumn});
            this.dataGridViewSuperHeros.DataSource = this.superheroBindingSource;
            this.dataGridViewSuperHeros.Location = new System.Drawing.Point(16, 444);
            this.dataGridViewSuperHeros.Name = "dataGridViewSuperHeros";
            this.dataGridViewSuperHeros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSuperHeros.Size = new System.Drawing.Size(641, 161);
            this.dataGridViewSuperHeros.TabIndex = 39;
            this.dataGridViewSuperHeros.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // idsuperheroDataGridViewTextBoxColumn
            // 
            this.idsuperheroDataGridViewTextBoxColumn.DataPropertyName = "Id_super_hero";
            this.idsuperheroDataGridViewTextBoxColumn.HeaderText = "Id SuperHéros";
            this.idsuperheroDataGridViewTextBoxColumn.Name = "idsuperheroDataGridViewTextBoxColumn";
            // 
            // idcivilDataGridViewTextBoxColumn
            // 
            this.idcivilDataGridViewTextBoxColumn.DataPropertyName = "Id_civil";
            this.idcivilDataGridViewTextBoxColumn.HeaderText = "Id du civil";
            this.idcivilDataGridViewTextBoxColumn.Name = "idcivilDataGridViewTextBoxColumn";
            // 
            // nomheroDataGridViewTextBoxColumn
            // 
            this.nomheroDataGridViewTextBoxColumn.DataPropertyName = "Nom_hero";
            this.nomheroDataGridViewTextBoxColumn.HeaderText = "Nom du Héros";
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
            this.pointfaibleDataGridViewTextBoxColumn.HeaderText = "Point faible";
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
            // superHerosBindingSource2
            // 
            this.superHerosBindingSource2.DataMember = "SuperHeros";
            this.superHerosBindingSource2.DataSource = this.avengersDBDataSetGridViewCivils2;
            // 
            // avengersDBDataSetGridViewCivils2
            // 
            this.avengersDBDataSetGridViewCivils2.DataSetName = "AvengersDBDataSetGridViewCivils2";
            this.avengersDBDataSetGridViewCivils2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // superHerosTableAdapter
            // 
            this.superHerosTableAdapter.ClearBeforeFill = true;
            // 
            // civilsTableAdapter1
            // 
            this.civilsTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(285, 633);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Quitter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.BackgroundImage = global::Avergers.Properties.Resources.Avengerslogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(692, 701);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewSuperHeros);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "SuperHeros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Heros";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet2FkIdCivil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avengersDBDataSetCmbIdCivils)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avengersDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilsBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.superHerosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superHerosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuperHeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superheroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superHerosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avengersDBDataSetGridViewCivils2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.BindingSource civilsBindingSource;
        private AvengersDBDataSetGridViewCivils avengersDBDataSet;
        private System.Windows.Forms.BindingSource civilsBindingSource1;
        private AvengersDBDataSetGridViewCivilsTableAdapters.CivilsTableAdapter civilsTableAdapter;
        
        private System.Windows.Forms.BindingSource superHerosBindingSource1;
        private System.Windows.Forms.DataGridView dataGridViewSuperHeros;
        private AvengersDBDataSetGridViewCivils2 avengersDBDataSetGridViewCivils2;
        private System.Windows.Forms.BindingSource superHerosBindingSource2;
        private AvengersDBDataSetGridViewCivils2TableAdapters.SuperHerosTableAdapter superHerosTableAdapter;
        private AvengersDBDataSetCmbIdCivils avengersDBDataSetCmbIdCivils;
        private System.Windows.Forms.BindingSource civilsBindingSource2;
        private AvengersDBDataSetCmbIdCivilsTableAdapters.CivilsTableAdapter civilsTableAdapter1;
        private System.Windows.Forms.Button button1;
        private ProjetHeroDataSet1 projetHeroDataSet1;
        private System.Windows.Forms.BindingSource superheroBindingSource;
        private ProjetHeroDataSet1TableAdapters.Super_heroTableAdapter super_heroTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private ProjetHeroDataSet2FkIdCivil projetHeroDataSet2FkIdCivil;
        private System.Windows.Forms.BindingSource civilBindingSource;
        private ProjetHeroDataSet2FkIdCivilTableAdapters.CivilTableAdapter civilTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsuperheroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcivilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomheroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pouvoirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointfaibleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentaireDataGridViewTextBoxColumn;

        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}