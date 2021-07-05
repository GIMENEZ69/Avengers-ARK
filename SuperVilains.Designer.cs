
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuperVilains));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CmdRead = new System.Windows.Forms.Button();
            this.CmdSupp = new System.Windows.Forms.Button();
            this.CmdMaj = new System.Windows.Forms.Button();
            this.CmdCréer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbIdCivil = new System.Windows.Forms.ComboBox();
            this.civilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetHeroDataSetFKIdCivil = new Avergers.ProjetHeroDataSetFKIdCivil();
            this.Pouvoir = new System.Windows.Forms.TextBox();
            this.Commentaire = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.superVilainsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CmdQuitter = new System.Windows.Forms.Button();
            this.superVilainsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.superVilainsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idsupervilainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcivilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomvilainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pouvoirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentaireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supervilainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetHeroDataSetVilain = new Avergers.ProjetHeroDataSetVilain();
            this.super_vilainTableAdapter = new Avergers.ProjetHeroDataSetVilainTableAdapters.Super_vilainTableAdapter();
            this.civilTableAdapter = new Avergers.ProjetHeroDataSetFKIdCivilTableAdapters.CivilTableAdapter();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetFKIdCivil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superVilainsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superVilainsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superVilainsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supervilainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetVilain)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CmdRead);
            this.groupBox2.Controls.Add(this.CmdSupp);
            this.groupBox2.Controls.Add(this.CmdMaj);
            this.groupBox2.Controls.Add(this.CmdCréer);
            this.groupBox2.Location = new System.Drawing.Point(12, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(839, 79);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opérations";
            // 
            // CmdRead
            // 
            this.CmdRead.Location = new System.Drawing.Point(237, 29);
            this.CmdRead.Name = "CmdRead";
            this.CmdRead.Size = new System.Drawing.Size(109, 40);
            this.CmdRead.TabIndex = 3;
            this.CmdRead.Text = "Lire le Super-Vilain";
            this.CmdRead.UseVisualStyleBackColor = true;
            this.CmdRead.Click += new System.EventHandler(this.CmdRead_Click);
            // 
            // CmdSupp
            // 
            this.CmdSupp.Location = new System.Drawing.Point(680, 29);
            this.CmdSupp.Name = "CmdSupp";
            this.CmdSupp.Size = new System.Drawing.Size(142, 40);
            this.CmdSupp.TabIndex = 2;
            this.CmdSupp.Text = "Supprimer le Super-Vilain";
            this.CmdSupp.UseVisualStyleBackColor = true;
            this.CmdSupp.Click += new System.EventHandler(this.CmdSupp_Click);
            // 
            // CmdMaj
            // 
            this.CmdMaj.Location = new System.Drawing.Point(434, 29);
            this.CmdMaj.Name = "CmdMaj";
            this.CmdMaj.Size = new System.Drawing.Size(161, 40);
            this.CmdMaj.TabIndex = 1;
            this.CmdMaj.Text = "Mettre à jour le Super-Vilain";
            this.CmdMaj.UseVisualStyleBackColor = true;
            this.CmdMaj.Click += new System.EventHandler(this.CmdMaj_Click);
            // 
            // CmdCréer
            // 
            this.CmdCréer.Location = new System.Drawing.Point(26, 29);
            this.CmdCréer.Name = "CmdCréer";
            this.CmdCréer.Size = new System.Drawing.Size(131, 40);
            this.CmdCréer.TabIndex = 0;
            this.CmdCréer.Text = "Créer le Super-Vilain";
            this.CmdCréer.UseVisualStyleBackColor = true;
            this.CmdCréer.Click += new System.EventHandler(this.CmdCréer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CmbIdCivil);
            this.groupBox1.Controls.Add(this.Pouvoir);
            this.groupBox1.Controls.Add(this.Commentaire);
            this.groupBox1.Controls.Add(this.Nom);
            this.groupBox1.Controls.Add(this.Id);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(839, 125);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Super-Vilains";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(669, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Id Civil:";
            // 
            // CmbIdCivil
            // 
            this.CmbIdCivil.DataSource = this.civilBindingSource;
            this.CmbIdCivil.DisplayMember = "Id_civil";
            this.CmbIdCivil.FormattingEnabled = true;
            this.CmbIdCivil.Location = new System.Drawing.Point(716, 45);
            this.CmbIdCivil.Name = "CmbIdCivil";
            this.CmbIdCivil.Size = new System.Drawing.Size(117, 21);
            this.CmbIdCivil.TabIndex = 37;
            this.CmbIdCivil.ValueMember = "Id_civil";
            // 
            // civilBindingSource
            // 
            this.civilBindingSource.DataMember = "Civil";
            this.civilBindingSource.DataSource = this.projetHeroDataSetFKIdCivil;
            // 
            // projetHeroDataSetFKIdCivil
            // 
            this.projetHeroDataSetFKIdCivil.DataSetName = "ProjetHeroDataSetFKIdCivil";
            this.projetHeroDataSetFKIdCivil.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Pouvoir
            // 
            this.Pouvoir.Location = new System.Drawing.Point(434, 24);
            this.Pouvoir.Name = "Pouvoir";
            this.Pouvoir.Size = new System.Drawing.Size(161, 20);
            this.Pouvoir.TabIndex = 36;
            // 
            // Commentaire
            // 
            this.Commentaire.Location = new System.Drawing.Point(434, 67);
            this.Commentaire.Name = "Commentaire";
            this.Commentaire.Size = new System.Drawing.Size(161, 20);
            this.Commentaire.TabIndex = 27;
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
            this.label13.Location = new System.Drawing.Point(332, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Commentaire :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(359, 27);
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
            // superVilainsBindingSource
            // 
            this.superVilainsBindingSource.DataMember = "SuperVilains";
            // 
            // CmdQuitter
            // 
            this.CmdQuitter.Location = new System.Drawing.Point(383, 483);
            this.CmdQuitter.Name = "CmdQuitter";
            this.CmdQuitter.Size = new System.Drawing.Size(102, 35);
            this.CmdQuitter.TabIndex = 11;
            this.CmdQuitter.Text = "Fermer";
            this.CmdQuitter.UseVisualStyleBackColor = true;
            this.CmdQuitter.Click += new System.EventHandler(this.CmdQuitter_Click);
            // 
            // superVilainsBindingSource1
            // 
            this.superVilainsBindingSource1.DataMember = "SuperVilains";
            // 
            // superVilainsBindingSource2
            // 
            this.superVilainsBindingSource2.DataMember = "SuperVilains";
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
            this.idsupervilainDataGridViewTextBoxColumn,
            this.idcivilDataGridViewTextBoxColumn,
            this.nomvilainDataGridViewTextBoxColumn,
            this.pouvoirDataGridViewTextBoxColumn,
            this.commentaireDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.supervilainBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(838, 199);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick_1);
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
            this.supervilainBindingSource.DataSource = this.projetHeroDataSetVilain;
            // 
            // projetHeroDataSetVilain
            // 
            this.projetHeroDataSetVilain.DataSetName = "ProjetHeroDataSetVilain";
            this.projetHeroDataSetVilain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // super_vilainTableAdapter
            // 
            this.super_vilainTableAdapter.ClearBeforeFill = true;
            // 
            // civilTableAdapter
            // 
            this.civilTableAdapter.ClearBeforeFill = true;
            // 
            // SuperVilains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 530);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CmdQuitter);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SuperVilains";
            this.Text = "Création d\'un Super-Vilain";
            this.Load += new System.EventHandler(this.SuperVilains_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetFKIdCivil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superVilainsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superVilainsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superVilainsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supervilainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetVilain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CmdRead;
        private System.Windows.Forms.Button CmdSupp;
        private System.Windows.Forms.Button CmdMaj;
        private System.Windows.Forms.Button CmdCréer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Pouvoir;
        private System.Windows.Forms.TextBox Commentaire;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource superVilainsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSuperVilainsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomSuperVilainsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn degatsSuperVilainsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentaireSuperVilainsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button CmdQuitter;
        private System.Windows.Forms.BindingSource superVilainsBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource superVilainsBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDeMefaitsSuperVilainssDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreSuperVilainsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjetHeroDataSetVilain projetHeroDataSetVilain;
        private System.Windows.Forms.BindingSource supervilainBindingSource;
        private ProjetHeroDataSetVilainTableAdapters.Super_vilainTableAdapter super_vilainTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsupervilainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcivilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomvilainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pouvoirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentaireDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbIdCivil;
        private ProjetHeroDataSetFKIdCivil projetHeroDataSetFKIdCivil;
        private System.Windows.Forms.BindingSource civilBindingSource;
        private ProjetHeroDataSetFKIdCivilTableAdapters.CivilTableAdapter civilTableAdapter;
    }
}