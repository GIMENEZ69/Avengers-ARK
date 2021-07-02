
namespace Avergers
{
    partial class rapport
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
            this.CmbSHMort = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.CmbNbCivilSauve = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CmbSVOui = new System.Windows.Forms.ComboBox();
            this.NomDegats = new System.Windows.Forms.TextBox();
            this.CmbSVPresent = new System.Windows.Forms.ComboBox();
            this.CoutsDegats = new System.Windows.Forms.TextBox();
            this.CmbSVArrete = new System.Windows.Forms.ComboBox();
            this.Infos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ValidRapport = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.projetHeroDataSet3test = new Avergers.ProjetHeroDataSet3test();
            this.civilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.civilTableAdapter = new Avergers.ProjetHeroDataSet3testTableAdapters.CivilTableAdapter();
            this.idcivilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet3test)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CmbSHMort);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.CmbNbCivilSauve);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.CmbSVOui);
            this.groupBox2.Controls.Add(this.NomDegats);
            this.groupBox2.Controls.Add(this.CmbSVPresent);
            this.groupBox2.Controls.Add(this.CoutsDegats);
            this.groupBox2.Controls.Add(this.CmbSVArrete);
            this.groupBox2.Controls.Add(this.Infos);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(12, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(780, 231);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rapport de Mission :";
            // 
            // CmbSHMort
            // 
            this.CmbSHMort.FormattingEnabled = true;
            this.CmbSHMort.Items.AddRange(new object[] {
            "Oui ",
            "Non"});
            this.CmbSHMort.Location = new System.Drawing.Point(647, 97);
            this.CmbSHMort.Name = "CmbSHMort";
            this.CmbSHMort.Size = new System.Drawing.Size(117, 21);
            this.CmbSHMort.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(543, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Super Héros mort ?";
            // 
            // CmbNbCivilSauve
            // 
            this.CmbNbCivilSauve.FormattingEnabled = true;
            this.CmbNbCivilSauve.Location = new System.Drawing.Point(647, 64);
            this.CmbNbCivilSauve.Name = "CmbNbCivilSauve";
            this.CmbNbCivilSauve.Size = new System.Drawing.Size(117, 21);
            this.CmbNbCivilSauve.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(523, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Nombre de civil sauvé :";
            // 
            // CmbSVOui
            // 
            this.CmbSVOui.FormattingEnabled = true;
            this.CmbSVOui.Location = new System.Drawing.Point(399, 69);
            this.CmbSVOui.Name = "CmbSVOui";
            this.CmbSVOui.Size = new System.Drawing.Size(117, 21);
            this.CmbSVOui.TabIndex = 24;
            // 
            // NomDegats
            // 
            this.NomDegats.Location = new System.Drawing.Point(139, 31);
            this.NomDegats.Name = "NomDegats";
            this.NomDegats.Size = new System.Drawing.Size(112, 20);
            this.NomDegats.TabIndex = 23;
            // 
            // CmbSVPresent
            // 
            this.CmbSVPresent.FormattingEnabled = true;
            this.CmbSVPresent.Items.AddRange(new object[] {
            "Oui",
            "Non"});
            this.CmbSVPresent.Location = new System.Drawing.Point(399, 31);
            this.CmbSVPresent.Name = "CmbSVPresent";
            this.CmbSVPresent.Size = new System.Drawing.Size(116, 21);
            this.CmbSVPresent.TabIndex = 22;
            // 
            // CoutsDegats
            // 
            this.CoutsDegats.Location = new System.Drawing.Point(139, 69);
            this.CoutsDegats.Name = "CoutsDegats";
            this.CoutsDegats.Size = new System.Drawing.Size(112, 20);
            this.CoutsDegats.TabIndex = 21;
            // 
            // CmbSVArrete
            // 
            this.CmbSVArrete.FormattingEnabled = true;
            this.CmbSVArrete.Items.AddRange(new object[] {
            "Oui",
            "Non"});
            this.CmbSVArrete.Location = new System.Drawing.Point(647, 30);
            this.CmbSVArrete.Name = "CmbSVArrete";
            this.CmbSVArrete.Size = new System.Drawing.Size(115, 21);
            this.CmbSVArrete.TabIndex = 19;
            // 
            // Infos
            // 
            this.Infos.Location = new System.Drawing.Point(151, 140);
            this.Infos.Multiline = true;
            this.Infos.Name = "Infos";
            this.Infos.Size = new System.Drawing.Size(457, 83);
            this.Infos.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Infos complémentaires :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(539, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Super Vilain arrêté ?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(270, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Super Vilains présent(s) :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(317, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Si oui, lequel ?";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Coût des dégâts :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(43, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Nom des dégâts :";
            // 
            // ValidRapport
            // 
            this.ValidRapport.Location = new System.Drawing.Point(341, 461);
            this.ValidRapport.Name = "ValidRapport";
            this.ValidRapport.Size = new System.Drawing.Size(115, 62);
            this.ValidRapport.TabIndex = 29;
            this.ValidRapport.Text = "Valider le rapport";
            this.ValidRapport.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(377, 253);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(163, 21);
            this.comboBox2.TabIndex = 33;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.idcivilDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.civilBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(79, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 174);
            this.dataGridView1.TabIndex = 34;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // projetHeroDataSet3test
            // 
            this.projetHeroDataSet3test.DataSetName = "ProjetHeroDataSet3test";
            this.projetHeroDataSet3test.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // civilBindingSource
            // 
            this.civilBindingSource.DataMember = "Civil";
            this.civilBindingSource.DataSource = this.projetHeroDataSet3test;
            // 
            // civilTableAdapter
            // 
            this.civilTableAdapter.ClearBeforeFill = true;
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
            // rapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.ValidRapport);
            this.Controls.Add(this.groupBox2);
            this.Name = "rapport";
            this.Text = "rapport";
            this.Load += new System.EventHandler(this.rapport_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSet3test)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CmbSHMort;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox CmbNbCivilSauve;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox CmbSVOui;
        private System.Windows.Forms.TextBox NomDegats;
        private System.Windows.Forms.ComboBox CmbSVPresent;
        private System.Windows.Forms.TextBox CoutsDegats;
        private System.Windows.Forms.ComboBox CmbSVArrete;
        private System.Windows.Forms.TextBox Infos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button ValidRapport;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private ProjetHeroDataSet3test projetHeroDataSet3test;
        private System.Windows.Forms.BindingSource civilBindingSource;
        private ProjetHeroDataSet3testTableAdapters.CivilTableAdapter civilTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcivilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
    }
}