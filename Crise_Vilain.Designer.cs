
namespace Avergers
{
    partial class Crise_Vilain
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
            this.label3 = new System.Windows.Forms.Label();
            this.CmbIdCivil = new System.Windows.Forms.ComboBox();
            this.Pouvoir = new System.Windows.Forms.TextBox();
            this.Commentaire = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmdCréer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.missionsupervilainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetHeroDataSetCriseSuperVilain = new Avergers.ProjetHeroDataSetCriseSuperVilain();
            this.mission_supervilainTableAdapter = new Avergers.ProjetHeroDataSetCriseSuperVilainTableAdapters.Mission_supervilainTableAdapter();
            this.idmissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flagidentifieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.missionsupervilainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetCriseSuperVilain)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.CmbIdCivil);
            this.groupBox2.Controls.Add(this.Pouvoir);
            this.groupBox2.Controls.Add(this.Commentaire);
            this.groupBox2.Controls.Add(this.Nom);
            this.groupBox2.Controls.Add(this.Id);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(839, 125);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Super-Vilains";
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
            this.CmbIdCivil.DisplayMember = "Id_civil";
            this.CmbIdCivil.FormattingEnabled = true;
            this.CmbIdCivil.Location = new System.Drawing.Point(716, 45);
            this.CmbIdCivil.Name = "CmbIdCivil";
            this.CmbIdCivil.Size = new System.Drawing.Size(117, 21);
            this.CmbIdCivil.TabIndex = 37;
            this.CmbIdCivil.ValueMember = "Id_civil";
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
            // CmdCréer
            // 
            this.CmdCréer.Location = new System.Drawing.Point(374, 326);
            this.CmdCréer.Name = "CmdCréer";
            this.CmdCréer.Size = new System.Drawing.Size(131, 40);
            this.CmdCréer.TabIndex = 16;
            this.CmdCréer.Text = "Créer le Super-Vilain";
            this.CmdCréer.UseVisualStyleBackColor = true;
            this.CmdCréer.Click += new System.EventHandler(this.CmdCréer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmissionDataGridViewTextBoxColumn,
            this.flagidentifieDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.missionsupervilainBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(205, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(437, 138);
            this.dataGridView1.TabIndex = 17;
            // 
            // missionsupervilainBindingSource
            // 
            this.missionsupervilainBindingSource.DataMember = "Mission_supervilain";
            this.missionsupervilainBindingSource.DataSource = this.projetHeroDataSetCriseSuperVilain;
            // 
            // projetHeroDataSetCriseSuperVilain
            // 
            this.projetHeroDataSetCriseSuperVilain.DataSetName = "ProjetHeroDataSetCriseSuperVilain";
            this.projetHeroDataSetCriseSuperVilain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mission_supervilainTableAdapter
            // 
            this.mission_supervilainTableAdapter.ClearBeforeFill = true;
            // 
            // idmissionDataGridViewTextBoxColumn
            // 
            this.idmissionDataGridViewTextBoxColumn.DataPropertyName = "Id_mission";
            this.idmissionDataGridViewTextBoxColumn.HeaderText = "Id_mission";
            this.idmissionDataGridViewTextBoxColumn.Name = "idmissionDataGridViewTextBoxColumn";
            // 
            // flagidentifieDataGridViewTextBoxColumn
            // 
            this.flagidentifieDataGridViewTextBoxColumn.DataPropertyName = "Flag_identifie";
            this.flagidentifieDataGridViewTextBoxColumn.HeaderText = "Super Vilain inconnu";
            this.flagidentifieDataGridViewTextBoxColumn.Name = "flagidentifieDataGridViewTextBoxColumn";
            // 
            // Crise_Vilain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 382);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CmdCréer);
            this.Controls.Add(this.groupBox2);
            this.Name = "Crise_Vilain";
            this.Text = "Crise_Vilain";
            this.Load += new System.EventHandler(this.Crise_Vilain_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.missionsupervilainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetCriseSuperVilain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbIdCivil;
        private System.Windows.Forms.TextBox Pouvoir;
        private System.Windows.Forms.TextBox Commentaire;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CmdCréer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjetHeroDataSetCriseSuperVilain projetHeroDataSetCriseSuperVilain;
        private System.Windows.Forms.BindingSource missionsupervilainBindingSource;
        private ProjetHeroDataSetCriseSuperVilainTableAdapters.Mission_supervilainTableAdapter mission_supervilainTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flagidentifieDataGridViewTextBoxColumn;
    }
}