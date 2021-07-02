
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Litige));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbTypeLitige = new System.Windows.Forms.ComboBox();
            this.CmbNomVictime = new System.Windows.Forms.ComboBox();
            this.CoutLitige = new System.Windows.Forms.TextBox();
            this.CausesLitiges = new System.Windows.Forms.TextBox();
            this.CmdProceder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type de litige :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Coût du litige :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom de la victime :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 13);
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
            this.CmbTypeLitige.Location = new System.Drawing.Point(164, 20);
            this.CmbTypeLitige.Name = "CmbTypeLitige";
            this.CmbTypeLitige.Size = new System.Drawing.Size(149, 21);
            this.CmbTypeLitige.TabIndex = 4;
            // 
            // CmbNomVictime
            // 
            this.CmbNomVictime.FormattingEnabled = true;
            this.CmbNomVictime.Location = new System.Drawing.Point(164, 95);
            this.CmbNomVictime.Name = "CmbNomVictime";
            this.CmbNomVictime.Size = new System.Drawing.Size(149, 21);
            this.CmbNomVictime.TabIndex = 5;
            // 
            // CoutLitige
            // 
            this.CoutLitige.Location = new System.Drawing.Point(164, 59);
            this.CoutLitige.Name = "CoutLitige";
            this.CoutLitige.Size = new System.Drawing.Size(149, 20);
            this.CoutLitige.TabIndex = 6;
            // 
            // CausesLitiges
            // 
            this.CausesLitiges.Location = new System.Drawing.Point(15, 174);
            this.CausesLitiges.Multiline = true;
            this.CausesLitiges.Name = "CausesLitiges";
            this.CausesLitiges.Size = new System.Drawing.Size(429, 133);
            this.CausesLitiges.TabIndex = 7;
            // 
            // CmdProceder
            // 
            this.CmdProceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdProceder.Location = new System.Drawing.Point(167, 329);
            this.CmdProceder.Name = "CmdProceder";
            this.CmdProceder.Size = new System.Drawing.Size(142, 45);
            this.CmdProceder.TabIndex = 8;
            this.CmdProceder.Text = "Procéder";
            this.CmdProceder.UseVisualStyleBackColor = true;
            // 
            // Litige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 394);
            this.Controls.Add(this.CmdProceder);
            this.Controls.Add(this.CausesLitiges);
            this.Controls.Add(this.CoutLitige);
            this.Controls.Add(this.CmbNomVictime);
            this.Controls.Add(this.CmbTypeLitige);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Litige";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Litige";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbTypeLitige;
        private System.Windows.Forms.ComboBox CmbNomVictime;
        private System.Windows.Forms.TextBox CoutLitige;
        private System.Windows.Forms.TextBox CausesLitiges;
        private System.Windows.Forms.Button CmdProceder;
    }
}