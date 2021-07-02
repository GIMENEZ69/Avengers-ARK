
namespace Avergers
{
    partial class Rapport_de_missions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rapport_de_missions));
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
            this.projetHeroDataSetNomSVRapportMission = new Avergers.ProjetHeroDataSetNomSVRapportMission();
            this.supervilainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.super_vilainTableAdapter = new Avergers.ProjetHeroDataSetNomSVRapportMissionTableAdapters.Super_vilainTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetNomSVRapportMission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supervilainBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(842, 305);
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
            this.CmbSHMort.Location = new System.Drawing.Point(703, 126);
            this.CmbSHMort.Name = "CmbSHMort";
            this.CmbSHMort.Size = new System.Drawing.Size(117, 21);
            this.CmbSHMort.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(550, 129);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 15);
            this.label14.TabIndex = 27;
            this.label14.Text = "Super Héros mort ?";
            // 
            // CmbNbCivilSauve
            // 
            this.CmbNbCivilSauve.FormattingEnabled = true;
            this.CmbNbCivilSauve.Location = new System.Drawing.Point(703, 31);
            this.CmbNbCivilSauve.Name = "CmbNbCivilSauve";
            this.CmbNbCivilSauve.Size = new System.Drawing.Size(117, 21);
            this.CmbNbCivilSauve.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(550, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Noms des civils sauvés :";
            // 
            // CmbSVOui
            // 
            this.CmbSVOui.DataSource = this.supervilainBindingSource;
            this.CmbSVOui.DisplayMember = "Nom_vilain";
            this.CmbSVOui.FormattingEnabled = true;
            this.CmbSVOui.Location = new System.Drawing.Point(397, 75);
            this.CmbSVOui.Name = "CmbSVOui";
            this.CmbSVOui.Size = new System.Drawing.Size(117, 21);
            this.CmbSVOui.TabIndex = 24;
            this.CmbSVOui.ValueMember = "Nom_vilain";
            // 
            // NomDegats
            // 
            this.NomDegats.Location = new System.Drawing.Point(121, 31);
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
            this.CmbSVPresent.Location = new System.Drawing.Point(397, 31);
            this.CmbSVPresent.Name = "CmbSVPresent";
            this.CmbSVPresent.Size = new System.Drawing.Size(116, 21);
            this.CmbSVPresent.TabIndex = 22;
            // 
            // CoutsDegats
            // 
            this.CoutsDegats.Location = new System.Drawing.Point(122, 98);
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
            this.CmbSVArrete.Location = new System.Drawing.Point(399, 123);
            this.CmbSVArrete.Name = "CmbSVArrete";
            this.CmbSVArrete.Size = new System.Drawing.Size(115, 21);
            this.CmbSVArrete.TabIndex = 19;
            // 
            // Infos
            // 
            this.Infos.Location = new System.Drawing.Point(185, 192);
            this.Infos.Multiline = true;
            this.Infos.Name = "Infos";
            this.Infos.Size = new System.Drawing.Size(459, 93);
            this.Infos.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Décrivez la mission : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(270, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Super Vilain arrêté ?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(244, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Super Vilains présent(s) :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(301, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Si oui, lequel ?";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Coût des dégâts :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Nom des dégâts :";
            // 
            // projetHeroDataSetNomSVRapportMission
            // 
            this.projetHeroDataSetNomSVRapportMission.DataSetName = "ProjetHeroDataSetNomSVRapportMission";
            this.projetHeroDataSetNomSVRapportMission.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supervilainBindingSource
            // 
            this.supervilainBindingSource.DataMember = "Super_vilain";
            this.supervilainBindingSource.DataSource = this.projetHeroDataSetNomSVRapportMission;
            // 
            // super_vilainTableAdapter
            // 
            this.super_vilainTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(197, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 60);
            this.button1.TabIndex = 9;
            this.button1.Text = "Valider le rapport";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(515, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 60);
            this.button2.TabIndex = 10;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(520, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nombre de civil(s) mort(s) :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(703, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 30;
            // 
            // Rapport_de_missions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rapport_de_missions";
            this.Text = "Rapport_de_missions";
            this.Load += new System.EventHandler(this.Rapport_de_missions_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetNomSVRapportMission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supervilainBindingSource)).EndInit();
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
        private ProjetHeroDataSetNomSVRapportMission projetHeroDataSetNomSVRapportMission;
        private System.Windows.Forms.BindingSource supervilainBindingSource;
        private ProjetHeroDataSetNomSVRapportMissionTableAdapters.Super_vilainTableAdapter super_vilainTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}