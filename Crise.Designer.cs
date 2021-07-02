
namespace Avergers
{
    partial class Crise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crise));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CmdValider = new System.Windows.Forms.Button();
            this.SVArrete = new System.Windows.Forms.TextBox();
            this.NomCivilMort = new System.Windows.Forms.TextBox();
            this.CoutDommage = new System.Windows.Forms.TextBox();
            this.CmbIdentiteSH = new System.Windows.Forms.ComboBox();
            this.CmbProces = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Super Vilain Identifié :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom du Civil mort :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Déclenchement de procès :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(443, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Coût des dommages latéraux :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(355, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "L\'identité du Super Héros à t\'elle été révélé ?";
            // 
            // CmdValider
            // 
            this.CmdValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdValider.Location = new System.Drawing.Point(339, 147);
            this.CmdValider.Name = "CmdValider";
            this.CmdValider.Size = new System.Drawing.Size(117, 57);
            this.CmdValider.TabIndex = 5;
            this.CmdValider.Text = "Valider";
            this.CmdValider.UseVisualStyleBackColor = true;
            // 
            // SVArrete
            // 
            this.SVArrete.Location = new System.Drawing.Point(180, 38);
            this.SVArrete.Name = "SVArrete";
            this.SVArrete.Size = new System.Drawing.Size(131, 20);
            this.SVArrete.TabIndex = 6;
            // 
            // NomCivilMort
            // 
            this.NomCivilMort.Location = new System.Drawing.Point(180, 71);
            this.NomCivilMort.Name = "NomCivilMort";
            this.NomCivilMort.Size = new System.Drawing.Size(131, 20);
            this.NomCivilMort.TabIndex = 7;
            // 
            // CoutDommage
            // 
            this.CoutDommage.Location = new System.Drawing.Point(626, 38);
            this.CoutDommage.Name = "CoutDommage";
            this.CoutDommage.Size = new System.Drawing.Size(131, 20);
            this.CoutDommage.TabIndex = 8;
            // 
            // CmbIdentiteSH
            // 
            this.CmbIdentiteSH.FormattingEnabled = true;
            this.CmbIdentiteSH.Items.AddRange(new object[] {
            "Oui",
            "Non"});
            this.CmbIdentiteSH.Location = new System.Drawing.Point(626, 71);
            this.CmbIdentiteSH.Name = "CmbIdentiteSH";
            this.CmbIdentiteSH.Size = new System.Drawing.Size(131, 21);
            this.CmbIdentiteSH.TabIndex = 9;
            // 
            // CmbProces
            // 
            this.CmbProces.FormattingEnabled = true;
            this.CmbProces.Items.AddRange(new object[] {
            "Oui",
            "Non"});
            this.CmbProces.Location = new System.Drawing.Point(180, 104);
            this.CmbProces.Name = "CmbProces";
            this.CmbProces.Size = new System.Drawing.Size(131, 21);
            this.CmbProces.TabIndex = 10;
            // 
            // Crise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 219);
            this.Controls.Add(this.CmbProces);
            this.Controls.Add(this.CmbIdentiteSH);
            this.Controls.Add(this.CoutDommage);
            this.Controls.Add(this.NomCivilMort);
            this.Controls.Add(this.SVArrete);
            this.Controls.Add(this.CmdValider);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Crise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CmdValider;
        private System.Windows.Forms.TextBox SVArrete;
        private System.Windows.Forms.TextBox NomCivilMort;
        private System.Windows.Forms.TextBox CoutDommage;
        private System.Windows.Forms.ComboBox CmbIdentiteSH;
        private System.Windows.Forms.ComboBox CmbProces;
    }
}