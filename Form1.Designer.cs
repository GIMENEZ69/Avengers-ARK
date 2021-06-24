
namespace Avergers
{
    partial class Form1
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
            this.CmbIdCivils = new System.Windows.Forms.ComboBox();
            this.civilsBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CmdRead = new System.Windows.Forms.Button();
            this.CmdSupp = new System.Windows.Forms.Button();
            this.CmdMaj = new System.Windows.Forms.Button();
            this.CmdCréer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.superHerosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avengersDBDataSet = new Avergers.AvengersDBDataSet();
            this.civilsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.civilsTableAdapter = new Avergers.AvengersDBDataSetTableAdapters.CivilsTableAdapter();
            this.avengersDBDataSet1 = new Avergers.AvengersDBDataSet1();
            this.superHerosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.superHerosTableAdapter = new Avergers.AvengersDBDataSet1TableAdapters.SuperHerosTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.civilsBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superHerosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avengersDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avengersDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superHerosBindingSource1)).BeginInit();
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
            this.groupBox1.Size = new System.Drawing.Size(547, 220);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Super-Héros";
            // 
            // CmbIdCivils
            // 
            this.CmbIdCivils.AllowDrop = true;
            this.CmbIdCivils.DataSource = this.civilsBindingSource1;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CmdRead);
            this.groupBox2.Controls.Add(this.CmdSupp);
            this.groupBox2.Controls.Add(this.CmdMaj);
            this.groupBox2.Controls.Add(this.CmdCréer);
            this.groupBox2.Location = new System.Drawing.Point(574, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(547, 208);
            this.groupBox2.TabIndex = 38;
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
            // 
            // CmdSupp
            // 
            this.CmdSupp.Location = new System.Drawing.Point(368, 162);
            this.CmdSupp.Name = "CmdSupp";
            this.CmdSupp.Size = new System.Drawing.Size(142, 40);
            this.CmdSupp.TabIndex = 2;
            this.CmdSupp.Text = "Supprimer le Super-Héros";
            this.CmdSupp.UseVisualStyleBackColor = true;
            // 
            // CmdMaj
            // 
            this.CmdMaj.Location = new System.Drawing.Point(18, 162);
            this.CmdMaj.Name = "CmdMaj";
            this.CmdMaj.Size = new System.Drawing.Size(161, 40);
            this.CmdMaj.TabIndex = 1;
            this.CmdMaj.Text = "Mettre à jour le Super-Héros";
            this.CmdMaj.UseVisualStyleBackColor = true;
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView1.DataSource = this.superHerosBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1133, 457);
            this.dataGridView1.TabIndex = 39;
            // 
            // superHerosBindingSource
            // 
            this.superHerosBindingSource.DataMember = "SuperHeros";
            // 
            // avengersDBDataSet
            // 
            this.avengersDBDataSet.DataSetName = "AvengersDBDataSet";
            this.avengersDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // civilsBindingSource1
            // 
            this.civilsBindingSource1.DataMember = "Civils";
            this.civilsBindingSource1.DataSource = this.avengersDBDataSet;
            // 
            // civilsTableAdapter
            // 
            this.civilsTableAdapter.ClearBeforeFill = true;
            // 
            // avengersDBDataSet1
            // 
            this.avengersDBDataSet1.DataSetName = "AvengersDBDataSet1";
            this.avengersDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // superHerosBindingSource1
            // 
            this.superHerosBindingSource1.DataMember = "SuperHeros";
            this.superHerosBindingSource1.DataSource = this.avengersDBDataSet1;
            // 
            // superHerosTableAdapter
            // 
            this.superHerosTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_SuperHeros";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_SuperHeros";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nom_SuperHeros";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom_SuperHeros";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Pouvoir_SuperHeros";
            this.dataGridViewTextBoxColumn3.HeaderText = "Pouvoir_SuperHeros";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PointFaible_SuperHeros";
            this.dataGridViewTextBoxColumn4.HeaderText = "PointFaible_SuperHeros";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Score_SuperHeros";
            this.dataGridViewTextBoxColumn5.HeaderText = "Score_SuperHeros";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Commentaire_SuperHeros";
            this.dataGridViewTextBoxColumn6.HeaderText = "Commentaire_SuperHeros";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Id_Civils";
            this.dataGridViewTextBoxColumn7.HeaderText = "Id_Civils";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 701);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.civilsBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superHerosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avengersDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avengersDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superHerosBindingSource1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource superHerosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSuperHerosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomSuperHerosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pouvoirSuperHerosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointFaibleSuperHerosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreSuperHerosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentaireSuperHerosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCivilsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource civilsBindingSource;
        private AvengersDBDataSet avengersDBDataSet;
        private System.Windows.Forms.BindingSource civilsBindingSource1;
        private AvengersDBDataSetTableAdapters.CivilsTableAdapter civilsTableAdapter;
        private AvengersDBDataSet1 avengersDBDataSet1;
        private System.Windows.Forms.BindingSource superHerosBindingSource1;
        private AvengersDBDataSet1TableAdapters.SuperHerosTableAdapter superHerosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}