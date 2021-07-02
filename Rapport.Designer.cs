
namespace Avergers
{
    partial class Rapport
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
            this.CmdAnnuler = new System.Windows.Forms.Button();
            this.CmdValider = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.projetHeroDataSetCivilMort = new Avergers.ProjetHeroDataSetCivilMort();
            this.civilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.civilTableAdapter = new Avergers.ProjetHeroDataSetCivilMortTableAdapters.CivilTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetCivilMort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.CmbSHMort);
            this.groupBox2.Controls.Add(this.label14);
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
            this.groupBox2.Location = new System.Drawing.Point(10, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(780, 340);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rapport de Mission :";
            // 
            // CmbSHMort
            // 
            this.CmbSHMort.FormattingEnabled = true;
            this.CmbSHMort.Items.AddRange(new object[] {
            "Oui ",
            "Non"});
            this.CmbSHMort.Location = new System.Drawing.Point(646, 102);
            this.CmbSHMort.Name = "CmbSHMort";
            this.CmbSHMort.Size = new System.Drawing.Size(117, 21);
            this.CmbSHMort.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(542, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Super Héros mort ?";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(576, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Civil mort:";
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
            this.CmbSVArrete.Location = new System.Drawing.Point(399, 97);
            this.CmbSVArrete.Name = "CmbSVArrete";
            this.CmbSVArrete.Size = new System.Drawing.Size(115, 21);
            this.CmbSVArrete.TabIndex = 19;
            // 
            // Infos
            // 
            this.Infos.Location = new System.Drawing.Point(159, 234);
            this.Infos.Multiline = true;
            this.Infos.Name = "Infos";
            this.Infos.Size = new System.Drawing.Size(457, 83);
            this.Infos.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Infos complémentaires :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 105);
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
            // CmdAnnuler
            // 
            this.CmdAnnuler.Location = new System.Drawing.Point(478, 442);
            this.CmdAnnuler.Name = "CmdAnnuler";
            this.CmdAnnuler.Size = new System.Drawing.Size(111, 62);
            this.CmdAnnuler.TabIndex = 9;
            this.CmdAnnuler.Text = "Annuler";
            this.CmdAnnuler.UseVisualStyleBackColor = true;
            this.CmdAnnuler.Click += new System.EventHandler(this.CmdAnnuler_Click);
            // 
            // CmdValider
            // 
            this.CmdValider.Location = new System.Drawing.Point(204, 432);
            this.CmdValider.Name = "CmdValider";
            this.CmdValider.Size = new System.Drawing.Size(115, 62);
            this.CmdValider.TabIndex = 8;
            this.CmdValider.Text = "Valider le rapport de mission";
            this.CmdValider.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.civilBindingSource;
            this.listBox1.DisplayMember = "Nom";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(634, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(129, 43);
            this.listBox1.TabIndex = 29;
            this.listBox1.ValueMember = "Prenom";
            // 
            // projetHeroDataSetCivilMort
            // 
            this.projetHeroDataSetCivilMort.DataSetName = "ProjetHeroDataSetCivilMort";
            this.projetHeroDataSetCivilMort.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // civilBindingSource
            // 
            this.civilBindingSource.DataMember = "Civil";
            this.civilBindingSource.DataSource = this.projetHeroDataSetCivilMort;
            // 
            // civilTableAdapter
            // 
            this.civilTableAdapter.ClearBeforeFill = true;
            // 
            // Rapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 555);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CmdAnnuler);
            this.Controls.Add(this.CmdValider);
            this.Name = "Rapport";
            this.Text = "Rapport";
            this.Load += new System.EventHandler(this.Rapport_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetCivilMort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CmbSHMort;
        private System.Windows.Forms.Label label14;
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
        private System.Windows.Forms.Button CmdAnnuler;
        private System.Windows.Forms.Button CmdValider;
        private System.Windows.Forms.ListBox listBox1;
        private ProjetHeroDataSetCivilMort projetHeroDataSetCivilMort;
        private System.Windows.Forms.BindingSource civilBindingSource;
        private ProjetHeroDataSetCivilMortTableAdapters.CivilTableAdapter civilTableAdapter;
    }
}