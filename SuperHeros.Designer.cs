
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CmdRead = new System.Windows.Forms.Button();
            this.CmdSupp = new System.Windows.Forms.Button();
            this.CmdMaj = new System.Windows.Forms.Button();
            this.CmdCréer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbIdCivils = new System.Windows.Forms.ComboBox();
            this.civilsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.civilsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
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
            this.superHerosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.superHerosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CmdQuitter = new System.Windows.Forms.Button();
            this.civilsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.superHerosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.superHerosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.superHerosBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.idSuperHerosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomSuperHerosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pouvoirSuperHerosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointFaibleSuperHerosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreSuperHerosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentaireSuperHerosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCivilsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.civilsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superHerosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superHerosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superHerosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superHerosBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superHerosBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CmdRead);
            this.groupBox2.Controls.Add(this.CmdSupp);
            this.groupBox2.Controls.Add(this.CmdMaj);
            this.groupBox2.Controls.Add(this.CmdCréer);
            this.groupBox2.Location = new System.Drawing.Point(25, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(547, 208);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opérations";
            // 
            // CmdRead
            // 
            this.CmdRead.Location = new System.Drawing.Point(368, 33);
            this.CmdRead.Name = "CmdRead";
            this.CmdRead.Size = new System.Drawing.Size(142, 40);
            this.CmdRead.TabIndex = 3;
            this.CmdRead.Text = "Lire le Super-Héros";
            this.CmdRead.UseVisualStyleBackColor = true;
            this.CmdRead.Click += new System.EventHandler(this.CmdRead_Click);
            // 
            // CmdSupp
            // 
            this.CmdSupp.Location = new System.Drawing.Point(368, 162);
            this.CmdSupp.Name = "CmdSupp";
            this.CmdSupp.Size = new System.Drawing.Size(142, 40);
            this.CmdSupp.TabIndex = 2;
            this.CmdSupp.Text = "Supprimer le Super-Héros";
            this.CmdSupp.UseVisualStyleBackColor = true;
            this.CmdSupp.Click += new System.EventHandler(this.CmdSupp_Click);
            // 
            // CmdMaj
            // 
            this.CmdMaj.Location = new System.Drawing.Point(18, 162);
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
            this.groupBox1.Location = new System.Drawing.Point(25, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 212);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Super-Héros";
            // 
            // CmbIdCivils
            // 
            this.CmbIdCivils.AllowDrop = true;
            this.CmbIdCivils.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.civilsBindingSource, "Id_Civils", true));
            this.CmbIdCivils.DataSource = this.civilsBindingSource2;
            this.CmbIdCivils.DisplayMember = "Id_Civils";
            this.CmbIdCivils.FormattingEnabled = true;
            this.CmbIdCivils.Location = new System.Drawing.Point(374, 151);
            this.CmbIdCivils.Name = "CmbIdCivils";
            this.CmbIdCivils.Size = new System.Drawing.Size(135, 21);
            this.CmbIdCivils.TabIndex = 37;
            this.CmbIdCivils.ValueMember = "Id_Civils";
            this.CmbIdCivils.SelectedIndexChanged += new System.EventHandler(this.CmbIdCivils_SelectedIndexChanged);
            // 
            // civilsBindingSource
            // 
            this.civilsBindingSource.DataMember = "Civils";
            this.civilsBindingSource.CurrentChanged += new System.EventHandler(this.civilsBindingSource_CurrentChanged);
            // 
            // avengersDBDataSet4
            // 
            // 
            // civilsBindingSource2
            // 
            this.civilsBindingSource2.DataMember = "Civils";
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
            this.Commentaire.Location = new System.Drawing.Point(358, 70);
            this.Commentaire.Name = "Commentaire";
            this.Commentaire.Size = new System.Drawing.Size(161, 20);
            this.Commentaire.TabIndex = 27;
            // 
            // PointFaible
            // 
            this.PointFaible.Location = new System.Drawing.Point(89, 151);
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
            this.label13.Location = new System.Drawing.Point(278, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Commentaire :";
            // 
            // labelPointfaible
            // 
            this.labelPointfaible.AutoSize = true;
            this.labelPointfaible.Location = new System.Drawing.Point(15, 154);
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
            // superHerosBindingSource1
            // 
            this.superHerosBindingSource1.DataMember = "SuperHeros";
            // 
            // avengersDBDataSet5
            // 
            // 
            // superHerosBindingSource
            // 
            this.superHerosBindingSource.DataMember = "SuperHeros";
            // 
            // avengersDBDataSet1
            // 
            // 
            // superHerosTableAdapter
            // 
            // 
            // CmdQuitter
            // 
            this.CmdQuitter.Location = new System.Drawing.Point(239, 622);
            this.CmdQuitter.Name = "CmdQuitter";
            this.CmdQuitter.Size = new System.Drawing.Size(102, 35);
            this.CmdQuitter.TabIndex = 9;
            this.CmdQuitter.Text = "Fermer";
            this.CmdQuitter.UseVisualStyleBackColor = true;
            this.CmdQuitter.Click += new System.EventHandler(this.CmdQuitter_Click);
            // 
            // civilsTableAdapter
            // 
            // civilsBindingSource1
            // 
            this.civilsBindingSource1.DataMember = "Civils";
            // 
            // superHerosBindingSource2
            // 
            this.superHerosBindingSource2.DataMember = "SuperHeros";
            // 
            // superHerosTableAdapter2
            // 
            // 
            // superHerosBindingSource3
            // 
            this.superHerosBindingSource3.DataMember = "SuperHeros";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSuperHerosDataGridViewTextBoxColumn,
            this.nomSuperHerosDataGridViewTextBoxColumn,
            this.pouvoirSuperHerosDataGridViewTextBoxColumn,
            this.pointFaibleSuperHerosDataGridViewTextBoxColumn,
            this.scoreSuperHerosDataGridViewTextBoxColumn,
            this.commentaireSuperHerosDataGridViewTextBoxColumn,
            this.idCivilsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.superHerosBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(6, 458);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(711, 164);
            this.dataGridView1.TabIndex = 10;
            // 
            // avengersDBDataSet8
            // 
            // 
            // superHerosBindingSource4
            // 
            this.superHerosBindingSource4.DataMember = "SuperHeros";
            // 
            // superHerosTableAdapter3
            // 
            // 
            // idSuperHerosDataGridViewTextBoxColumn
            // 
            this.idSuperHerosDataGridViewTextBoxColumn.DataPropertyName = "Id_SuperHeros";
            this.idSuperHerosDataGridViewTextBoxColumn.HeaderText = "Id_SuperHeros";
            this.idSuperHerosDataGridViewTextBoxColumn.Name = "idSuperHerosDataGridViewTextBoxColumn";
            // 
            // nomSuperHerosDataGridViewTextBoxColumn
            // 
            this.nomSuperHerosDataGridViewTextBoxColumn.DataPropertyName = "Nom_SuperHeros";
            this.nomSuperHerosDataGridViewTextBoxColumn.HeaderText = "Nom_SuperHeros";
            this.nomSuperHerosDataGridViewTextBoxColumn.Name = "nomSuperHerosDataGridViewTextBoxColumn";
            // 
            // pouvoirSuperHerosDataGridViewTextBoxColumn
            // 
            this.pouvoirSuperHerosDataGridViewTextBoxColumn.DataPropertyName = "Pouvoir_SuperHeros";
            this.pouvoirSuperHerosDataGridViewTextBoxColumn.HeaderText = "Pouvoir_SuperHeros";
            this.pouvoirSuperHerosDataGridViewTextBoxColumn.Name = "pouvoirSuperHerosDataGridViewTextBoxColumn";
            // 
            // pointFaibleSuperHerosDataGridViewTextBoxColumn
            // 
            this.pointFaibleSuperHerosDataGridViewTextBoxColumn.DataPropertyName = "PointFaible_SuperHeros";
            this.pointFaibleSuperHerosDataGridViewTextBoxColumn.HeaderText = "PointFaible_SuperHeros";
            this.pointFaibleSuperHerosDataGridViewTextBoxColumn.Name = "pointFaibleSuperHerosDataGridViewTextBoxColumn";
            // 
            // scoreSuperHerosDataGridViewTextBoxColumn
            // 
            this.scoreSuperHerosDataGridViewTextBoxColumn.DataPropertyName = "Score_SuperHeros";
            this.scoreSuperHerosDataGridViewTextBoxColumn.HeaderText = "Score_SuperHeros";
            this.scoreSuperHerosDataGridViewTextBoxColumn.Name = "scoreSuperHerosDataGridViewTextBoxColumn";
            // 
            // commentaireSuperHerosDataGridViewTextBoxColumn
            // 
            this.commentaireSuperHerosDataGridViewTextBoxColumn.DataPropertyName = "Commentaire_SuperHeros";
            this.commentaireSuperHerosDataGridViewTextBoxColumn.HeaderText = "Commentaire_SuperHeros";
            this.commentaireSuperHerosDataGridViewTextBoxColumn.Name = "commentaireSuperHerosDataGridViewTextBoxColumn";
            // 
            // idCivilsDataGridViewTextBoxColumn
            // 
            this.idCivilsDataGridViewTextBoxColumn.DataPropertyName = "Id_Civils";
            this.idCivilsDataGridViewTextBoxColumn.HeaderText = "Id_Civils";
            this.idCivilsDataGridViewTextBoxColumn.Name = "idCivilsDataGridViewTextBoxColumn";
            // 
            // SuperHeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 673);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CmdQuitter);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SuperHeros";
            this.Text = "Création d\'un super héros";
            this.Load += new System.EventHandler(this.SuperHeros_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.civilsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superHerosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superHerosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superHerosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superHerosBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superHerosBindingSource4)).EndInit();
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
        private System.Windows.Forms.TextBox PointFaible;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelPointfaible;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource superHerosBindingSource;
        private System.Windows.Forms.Button CmdQuitter;
        private System.Windows.Forms.ComboBox CmbIdCivils;
        private System.Windows.Forms.BindingSource civilsBindingSource;
        private System.Windows.Forms.BindingSource superHerosBindingSource1;
        private System.Windows.Forms.BindingSource civilsBindingSource1;
        private System.Windows.Forms.BindingSource civilsBindingSource2;
        private System.Windows.Forms.BindingSource superHerosBindingSource2;
        private System.Windows.Forms.BindingSource superHerosBindingSource3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource superHerosBindingSource4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSuperHerosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomSuperHerosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pouvoirSuperHerosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointFaibleSuperHerosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreSuperHerosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentaireSuperHerosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCivilsDataGridViewTextBoxColumn;
    }
}