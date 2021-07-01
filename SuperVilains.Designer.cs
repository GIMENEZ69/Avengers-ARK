
namespace Avergers
{
    partial class SuperVilains
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.civilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetHeroDataSet2FkIdCivil_2 = new Avergers.ProjetHeroDataSet2FkIdCivil_2();
            this.label5 = new System.Windows.Forms.Label();
            this.Pouvoir = new System.Windows.Forms.TextBox();
            this.Commentaire = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CmdSupp = new System.Windows.Forms.Button();
            this.CmdMaj = new System.Windows.Forms.Button();
            this.CmdRead = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewSuperVilains = new System.Windows.Forms.DataGridView();
            this.idsupervilainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcivilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomvilainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pouvoirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentaireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supervilainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetHeroDataSet2 = new Avergers.ProjetHeroDataSet2();
            this.superVilainsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.avengersDBDataSet = new Avergers.AvengersDBDataSet();
            this.superVilainsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.superVilainsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.superVilainsTableAdapter = new Avergers.AvengersDBDataSetTableAdapters.SuperVilainsTableAdapter();
            this.civilTableAdapter = new Avergers.ProjetHeroDataSet2FkIdCivil_2TableAdapters.CivilTableAdapter();
            this.super_vilainTableAdapter = new Avergers.ProjetHeroDataSet2TableAdapters.Super_vilainTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet2FkIdCivil_2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuperVilains)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supervilainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superVilainsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avengersDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superVilainsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superVilainsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Pouvoir);
            this.groupBox1.Controls.Add(this.Commentaire);
            this.groupBox1.Controls.Add(this.Nom);
            this.groupBox1.Controls.Add(this.Id);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Super Vilains";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.civilBindingSource;
            this.comboBox1.DisplayMember = "Id_civil";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(532, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 24);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "Id_civil";
            // 
            // civilBindingSource
            // 
            this.civilBindingSource.DataMember = "Civil";
            this.civilBindingSource.DataSource = this.projetHeroDataSet2FkIdCivil_2;
            // 
            // projetHeroDataSet2FkIdCivil_2
            // 
            this.projetHeroDataSet2FkIdCivil_2.DataSetName = "ProjetHeroDataSet2FkIdCivil_2";
            this.projetHeroDataSet2FkIdCivil_2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pouvoir :";
            // 
            // Pouvoir
            // 
            this.Pouvoir.Location = new System.Drawing.Point(159, 149);
            this.Pouvoir.Name = "Pouvoir";
            this.Pouvoir.Size = new System.Drawing.Size(162, 22);
            this.Pouvoir.TabIndex = 8;
            // 
            // Commentaire
            // 
            this.Commentaire.Location = new System.Drawing.Point(532, 124);
            this.Commentaire.Name = "Commentaire";
            this.Commentaire.Size = new System.Drawing.Size(162, 22);
            this.Commentaire.TabIndex = 7;
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(159, 89);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(162, 22);
            this.Nom.TabIndex = 5;
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(159, 29);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(162, 22);
            this.Id.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(419, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Commentaire :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Super Vilains :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CmdSupp);
            this.groupBox2.Controls.Add(this.CmdMaj);
            this.groupBox2.Controls.Add(this.CmdRead);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(804, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opérations";
            // 
            // CmdSupp
            // 
            this.CmdSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdSupp.Location = new System.Drawing.Point(600, 31);
            this.CmdSupp.Name = "CmdSupp";
            this.CmdSupp.Size = new System.Drawing.Size(157, 36);
            this.CmdSupp.TabIndex = 3;
            this.CmdSupp.Text = "Supprimer Super Vilains";
            this.CmdSupp.UseVisualStyleBackColor = true;
            this.CmdSupp.Click += new System.EventHandler(this.CmdSupp_Click);
            // 
            // CmdMaj
            // 
            this.CmdMaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdMaj.Location = new System.Drawing.Point(393, 31);
            this.CmdMaj.Name = "CmdMaj";
            this.CmdMaj.Size = new System.Drawing.Size(156, 36);
            this.CmdMaj.TabIndex = 2;
            this.CmdMaj.Text = "Modifier Super Vilains";
            this.CmdMaj.UseVisualStyleBackColor = true;
            this.CmdMaj.Click += new System.EventHandler(this.CmdMaj_Click);
            // 
            // CmdRead
            // 
            this.CmdRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdRead.Location = new System.Drawing.Point(224, 31);
            this.CmdRead.Name = "CmdRead";
            this.CmdRead.Size = new System.Drawing.Size(118, 36);
            this.CmdRead.TabIndex = 1;
            this.CmdRead.Text = "Lire Super Vilains";
            this.CmdRead.UseVisualStyleBackColor = true;
            this.CmdRead.Click += new System.EventHandler(this.CmdRead_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(48, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Créer Super-Vilains";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CmdCreer_Clickk);
            // 
            // dataGridViewSuperVilains
            // 
            this.dataGridViewSuperVilains.AllowUserToOrderColumns = true;
            this.dataGridViewSuperVilains.AutoGenerateColumns = false;
            this.dataGridViewSuperVilains.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSuperVilains.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsupervilainDataGridViewTextBoxColumn,
            this.idcivilDataGridViewTextBoxColumn,
            this.nomvilainDataGridViewTextBoxColumn,
            this.pouvoirDataGridViewTextBoxColumn,
            this.commentaireDataGridViewTextBoxColumn});
            this.dataGridViewSuperVilains.DataSource = this.supervilainBindingSource;
            this.dataGridViewSuperVilains.Location = new System.Drawing.Point(12, 321);
            this.dataGridViewSuperVilains.Name = "dataGridViewSuperVilains";
            this.dataGridViewSuperVilains.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSuperVilains.Size = new System.Drawing.Size(804, 162);
            this.dataGridViewSuperVilains.TabIndex = 2;
            this.dataGridViewSuperVilains.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // idsupervilainDataGridViewTextBoxColumn
            // 
            this.idsupervilainDataGridViewTextBoxColumn.DataPropertyName = "Id_super_vilain";
            this.idsupervilainDataGridViewTextBoxColumn.HeaderText = "Id_super_vilain";
            this.idsupervilainDataGridViewTextBoxColumn.Name = "idsupervilainDataGridViewTextBoxColumn";
            // 
            // idcivilDataGridViewTextBoxColumn
            // 
            this.idcivilDataGridViewTextBoxColumn.DataPropertyName = "Id_civil";
            this.idcivilDataGridViewTextBoxColumn.HeaderText = "Id_civil";
            this.idcivilDataGridViewTextBoxColumn.Name = "idcivilDataGridViewTextBoxColumn";
            // 
            // nomvilainDataGridViewTextBoxColumn
            // 
            this.nomvilainDataGridViewTextBoxColumn.DataPropertyName = "Nom_vilain";
            this.nomvilainDataGridViewTextBoxColumn.HeaderText = "Nom_vilain";
            this.nomvilainDataGridViewTextBoxColumn.Name = "nomvilainDataGridViewTextBoxColumn";
            // 
            // pouvoirDataGridViewTextBoxColumn
            // 
            this.pouvoirDataGridViewTextBoxColumn.DataPropertyName = "Pouvoir";
            this.pouvoirDataGridViewTextBoxColumn.HeaderText = "Pouvoir";
            this.pouvoirDataGridViewTextBoxColumn.Name = "pouvoirDataGridViewTextBoxColumn";
            // 
            // commentaireDataGridViewTextBoxColumn
            // 
            this.commentaireDataGridViewTextBoxColumn.DataPropertyName = "Commentaire";
            this.commentaireDataGridViewTextBoxColumn.HeaderText = "Commentaire";
            this.commentaireDataGridViewTextBoxColumn.Name = "commentaireDataGridViewTextBoxColumn";
            // 
            // supervilainBindingSource
            // 
            this.supervilainBindingSource.DataMember = "Super_vilain";
            this.supervilainBindingSource.DataSource = this.projetHeroDataSet2;
            // 
            // projetHeroDataSet2
            // 
            this.projetHeroDataSet2.DataSetName = "ProjetHeroDataSet2";
            this.projetHeroDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // superVilainsBindingSource2
            // 
            this.superVilainsBindingSource2.DataMember = "SuperVilains";
            this.superVilainsBindingSource2.DataSource = this.avengersDBDataSet;
            // 
            // avengersDBDataSet
            // 
            this.avengersDBDataSet.DataSetName = "AvengersDBDataSet";
            this.avengersDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // superVilainsBindingSource1
            // 
            this.superVilainsBindingSource1.DataMember = "SuperVilains";
            // 
            // superVilainsBindingSource
            // 
            this.superVilainsBindingSource.DataMember = "SuperVilains";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(339, 514);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 47);
            this.button2.TabIndex = 3;
            this.button2.Text = "Quitter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // superVilainsTableAdapter
            // 
            this.superVilainsTableAdapter.ClearBeforeFill = true;
            // 
            // civilTableAdapter
            // 
            this.civilTableAdapter.ClearBeforeFill = true;
            // 
            // super_vilainTableAdapter
            // 
            this.super_vilainTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(463, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Id Civil :";
            // 
            // SuperVilains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Avergers.Properties.Resources.Avengerslogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(828, 582);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridViewSuperVilains);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "SuperVilains";
            this.Text = "Création Super Vilains";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet2FkIdCivil_2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuperVilains)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supervilainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superVilainsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avengersDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superVilainsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superVilainsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Commentaire;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CmdSupp;
        private System.Windows.Forms.Button CmdMaj;
        private System.Windows.Forms.Button CmdRead;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewSuperVilains;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource superVilainsBindingSource;
        //private System.Windows.Forms.DataGridViewTextBoxColumn idSuperVilainsDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn nomSuperVilainsDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn degatsSuperVilainsDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn commentaireSuperVilainsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource superVilainsBindingSource1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        //private System.Windows.Forms.DataGridViewTextBoxColumn nombreDeMefaitsSuperVilainsDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        //private System.Windows.Forms.DataGridViewTextBoxColumn scoreSuperVilainsDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private AvengersDBDataSet avengersDBDataSet;
        private System.Windows.Forms.BindingSource superVilainsBindingSource2;
        private AvengersDBDataSetTableAdapters.SuperVilainsTableAdapter superVilainsTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private ProjetHeroDataSet2FkIdCivil_2 projetHeroDataSet2FkIdCivil_2;
        private System.Windows.Forms.BindingSource civilBindingSource;
        private ProjetHeroDataSet2FkIdCivil_2TableAdapters.CivilTableAdapter civilTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Pouvoir;
        private ProjetHeroDataSet2 projetHeroDataSet2;
        private System.Windows.Forms.BindingSource supervilainBindingSource;
        private ProjetHeroDataSet2TableAdapters.Super_vilainTableAdapter super_vilainTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsupervilainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcivilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomvilainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pouvoirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentaireDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
    }
}