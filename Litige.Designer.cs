
namespace Avergers
{
    partial class Litige
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Litige));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbTypeLitige = new System.Windows.Forms.ComboBox();
            this.Description = new System.Windows.Forms.TextBox();
            this.CmdProceder = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idcriseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idlitigeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dommagescollaterauxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.criseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetHeroDataSetlitige = new Avergers.ProjetHeroDataSetlitige();
            this.criseTableAdapter = new Avergers.ProjetHeroDataSetlitigeTableAdapters.CriseTableAdapter();
            this.CmbSelecRech = new System.Windows.Forms.ComboBox();
            this.Recherche = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CmdSelect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IdCrise = new System.Windows.Forms.TextBox();
            this.IdLitige = new System.Windows.Forms.TextBox();
            this.CoutDommage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.criseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetlitige)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type de litige :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Veuillez décrire les causes et les demandes du litige :";
            // 
            // CmbTypeLitige
            // 
            this.CmbTypeLitige.FormattingEnabled = true;
            this.CmbTypeLitige.Items.AddRange(new object[] {
            "Mortalité",
            "Matériel",
            "Propriété privée",
            "Propriété publique",
            "Autres"});
            this.CmbTypeLitige.Location = new System.Drawing.Point(110, 240);
            this.CmbTypeLitige.Name = "CmbTypeLitige";
            this.CmbTypeLitige.Size = new System.Drawing.Size(149, 21);
            this.CmbTypeLitige.TabIndex = 4;
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(26, 300);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(429, 133);
            this.Description.TabIndex = 7;
            // 
            // CmdProceder
            // 
            this.CmdProceder.Location = new System.Drawing.Point(323, 460);
            this.CmdProceder.Name = "CmdProceder";
            this.CmdProceder.Size = new System.Drawing.Size(142, 45);
            this.CmdProceder.TabIndex = 8;
            this.CmdProceder.Text = "Procéder";
            this.CmdProceder.UseVisualStyleBackColor = true;
            this.CmdProceder.Click += new System.EventHandler(this.CmdProceder_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcriseDataGridViewTextBoxColumn,
            this.idmissionDataGridViewTextBoxColumn,
            this.idlitigeDataGridViewTextBoxColumn,
            this.dommagescollaterauxDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.criseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(739, 128);
            this.dataGridView1.TabIndex = 9;
            // 
            // idcriseDataGridViewTextBoxColumn
            // 
            this.idcriseDataGridViewTextBoxColumn.DataPropertyName = "Id_crise";
            this.idcriseDataGridViewTextBoxColumn.HeaderText = "Id_crise";
            this.idcriseDataGridViewTextBoxColumn.Name = "idcriseDataGridViewTextBoxColumn";
            // 
            // idmissionDataGridViewTextBoxColumn
            // 
            this.idmissionDataGridViewTextBoxColumn.DataPropertyName = "Id_mission";
            this.idmissionDataGridViewTextBoxColumn.HeaderText = "Id_mission";
            this.idmissionDataGridViewTextBoxColumn.Name = "idmissionDataGridViewTextBoxColumn";
            // 
            // idlitigeDataGridViewTextBoxColumn
            // 
            this.idlitigeDataGridViewTextBoxColumn.DataPropertyName = "Id_litige";
            this.idlitigeDataGridViewTextBoxColumn.HeaderText = "Id_litige";
            this.idlitigeDataGridViewTextBoxColumn.Name = "idlitigeDataGridViewTextBoxColumn";
            // 
            // dommagescollaterauxDataGridViewTextBoxColumn
            // 
            this.dommagescollaterauxDataGridViewTextBoxColumn.DataPropertyName = "Dommages_collateraux";
            this.dommagescollaterauxDataGridViewTextBoxColumn.HeaderText = "Dommages_collateraux";
            this.dommagescollaterauxDataGridViewTextBoxColumn.Name = "dommagescollaterauxDataGridViewTextBoxColumn";
            // 
            // criseBindingSource
            // 
            this.criseBindingSource.DataMember = "Crise";
            this.criseBindingSource.DataSource = this.projetHeroDataSetlitige;
            // 
            // projetHeroDataSetlitige
            // 
            this.projetHeroDataSetlitige.DataSetName = "ProjetHeroDataSetlitige";
            this.projetHeroDataSetlitige.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // criseTableAdapter
            // 
            this.criseTableAdapter.ClearBeforeFill = true;
            // 
            // CmbSelecRech
            // 
            this.CmbSelecRech.FormattingEnabled = true;
            this.CmbSelecRech.Items.AddRange(new object[] {
            "Id_crise",
            "Id_mission",
            "Id_litige"});
            this.CmbSelecRech.Location = new System.Drawing.Point(194, 24);
            this.CmbSelecRech.Name = "CmbSelecRech";
            this.CmbSelecRech.Size = new System.Drawing.Size(99, 21);
            this.CmbSelecRech.TabIndex = 27;
            // 
            // Recherche
            // 
            this.Recherche.Location = new System.Drawing.Point(531, 24);
            this.Recherche.Name = "Recherche";
            this.Recherche.Size = new System.Drawing.Size(126, 20);
            this.Recherche.TabIndex = 26;
            this.Recherche.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Recherche_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(409, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Saisir votre recherche :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(95, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Rechercher par :";
            // 
            // CmdSelect
            // 
            this.CmdSelect.Location = new System.Drawing.Point(299, 195);
            this.CmdSelect.Name = "CmdSelect";
            this.CmdSelect.Size = new System.Drawing.Size(181, 34);
            this.CmdSelect.TabIndex = 28;
            this.CmdSelect.Text = "Sélectionner cette crise";
            this.CmdSelect.UseVisualStyleBackColor = true;
            this.CmdSelect.Click += new System.EventHandler(this.CmdSelect_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Id crise :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(555, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Id litige :";
            // 
            // IdCrise
            // 
            this.IdCrise.Location = new System.Drawing.Point(367, 241);
            this.IdCrise.Name = "IdCrise";
            this.IdCrise.Size = new System.Drawing.Size(113, 20);
            this.IdCrise.TabIndex = 31;
            // 
            // IdLitige
            // 
            this.IdLitige.Location = new System.Drawing.Point(607, 243);
            this.IdLitige.Name = "IdLitige";
            this.IdLitige.Size = new System.Drawing.Size(113, 20);
            this.IdLitige.TabIndex = 32;
            // 
            // CoutDommage
            // 
            this.CoutDommage.Location = new System.Drawing.Point(607, 285);
            this.CoutDommage.Name = "CoutDommage";
            this.CoutDommage.Size = new System.Drawing.Size(113, 20);
            this.CoutDommage.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(492, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Coût des dommages :";
            // 
            // Litige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 517);
            this.Controls.Add(this.CoutDommage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IdLitige);
            this.Controls.Add(this.IdCrise);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmdSelect);
            this.Controls.Add(this.CmbSelecRech);
            this.Controls.Add(this.Recherche);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CmdProceder);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.CmbTypeLitige);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Litige";
            this.Text = "Litige";
            this.Load += new System.EventHandler(this.Litige_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.criseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetlitige)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbTypeLitige;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Button CmdProceder;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjetHeroDataSetlitige projetHeroDataSetlitige;
        private System.Windows.Forms.BindingSource criseBindingSource;
        private ProjetHeroDataSetlitigeTableAdapters.CriseTableAdapter criseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcriseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlitigeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dommagescollaterauxDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox CmbSelecRech;
        private System.Windows.Forms.TextBox Recherche;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button CmdSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IdCrise;
        private System.Windows.Forms.TextBox IdLitige;
        private System.Windows.Forms.TextBox CoutDommage;
        private System.Windows.Forms.Label label5;
    }
}