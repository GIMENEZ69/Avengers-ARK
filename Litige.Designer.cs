
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
            this.labeldescription = new System.Windows.Forms.Label();
            this.textBoxdescription = new System.Windows.Forms.TextBox();
            this.labeltype = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelcout = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelcivil = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.projetHeroDataSetvictime = new Avergers.ProjetHeroDataSetvictime();
            this.civilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.civilTableAdapter = new Avergers.ProjetHeroDataSetvictimeTableAdapters.CivilTableAdapter();
            this.buttonvalider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetvictime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labeldescription
            // 
            this.labeldescription.AutoSize = true;
            this.labeldescription.Location = new System.Drawing.Point(30, 261);
            this.labeldescription.Name = "labeldescription";
            this.labeldescription.Size = new System.Drawing.Size(239, 13);
            this.labeldescription.TabIndex = 0;
            this.labeldescription.Text = "Veuillez d\'ecrire les causes et demandes du litige:";
            this.labeldescription.Click += new System.EventHandler(this.labeldescription_Click);
            // 
            // textBoxdescription
            // 
            this.textBoxdescription.Location = new System.Drawing.Point(359, 261);
            this.textBoxdescription.Multiline = true;
            this.textBoxdescription.Name = "textBoxdescription";
            this.textBoxdescription.Size = new System.Drawing.Size(355, 113);
            this.textBoxdescription.TabIndex = 1;
            // 
            // labeltype
            // 
            this.labeltype.AutoSize = true;
            this.labeltype.Location = new System.Drawing.Point(38, 41);
            this.labeltype.Name = "labeltype";
            this.labeltype.Size = new System.Drawing.Size(73, 13);
            this.labeltype.TabIndex = 2;
            this.labeltype.Text = "Type de litige:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mortalite",
            "Materiel",
            "Propriete privee",
            "Propriete public ",
            "Autres"});
            this.comboBox1.Location = new System.Drawing.Point(157, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // labelcout
            // 
            this.labelcout.AutoSize = true;
            this.labelcout.Location = new System.Drawing.Point(38, 99);
            this.labelcout.Name = "labelcout";
            this.labelcout.Size = new System.Drawing.Size(71, 13);
            this.labelcout.TabIndex = 4;
            this.labelcout.Text = "Cout du litige:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 5;
            // 
            // labelcivil
            // 
            this.labelcivil.AutoSize = true;
            this.labelcivil.Location = new System.Drawing.Point(38, 161);
            this.labelcivil.Name = "labelcivil";
            this.labelcivil.Size = new System.Drawing.Size(94, 13);
            this.labelcivil.TabIndex = 6;
            this.labelcivil.Text = "Nom de la victime:";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.civilBindingSource;
            this.comboBox2.DisplayMember = "Id_civil";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(157, 153);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(150, 21);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.ValueMember = "Id_civil";
            // 
            // projetHeroDataSetvictime
            // 
            this.projetHeroDataSetvictime.DataSetName = "ProjetHeroDataSetvictime";
            this.projetHeroDataSetvictime.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // civilBindingSource
            // 
            this.civilBindingSource.DataMember = "Civil";
            this.civilBindingSource.DataSource = this.projetHeroDataSetvictime;
            // 
            // civilTableAdapter
            // 
            this.civilTableAdapter.ClearBeforeFill = true;
            // 
            // buttonvalider
            // 
            this.buttonvalider.Location = new System.Drawing.Point(157, 385);
            this.buttonvalider.Name = "buttonvalider";
            this.buttonvalider.Size = new System.Drawing.Size(129, 42);
            this.buttonvalider.TabIndex = 8;
            this.buttonvalider.Text = "Proceder";
            this.buttonvalider.UseVisualStyleBackColor = true;
            // 
            // Litige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonvalider);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.labelcivil);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelcout);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labeltype);
            this.Controls.Add(this.textBoxdescription);
            this.Controls.Add(this.labeldescription);
            this.Name = "Litige";
            this.Text = "Litige";
            this.Load += new System.EventHandler(this.Litige_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projetHeroDataSetvictime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.civilBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeldescription;
        private System.Windows.Forms.TextBox textBoxdescription;
        private System.Windows.Forms.Label labeltype;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelcout;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelcivil;
        private System.Windows.Forms.ComboBox comboBox2;
        private ProjetHeroDataSetvictime projetHeroDataSetvictime;
        private System.Windows.Forms.BindingSource civilBindingSource;
        private ProjetHeroDataSetvictimeTableAdapters.CivilTableAdapter civilTableAdapter;
        private System.Windows.Forms.Button buttonvalider;
    }
}