
namespace Avergers
{
    partial class MenuAdminCreat
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
            this.CmdCivils = new System.Windows.Forms.Button();
            this.CmdSH = new System.Windows.Forms.Button();
            this.CmdOrg = new System.Windows.Forms.Button();
            this.CmdSV = new System.Windows.Forms.Button();
            this.CmdQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdCivils
            // 
            this.CmdCivils.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CmdCivils.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdCivils.ForeColor = System.Drawing.SystemColors.Desktop;
            this.CmdCivils.Location = new System.Drawing.Point(249, 226);
            this.CmdCivils.Name = "CmdCivils";
            this.CmdCivils.Size = new System.Drawing.Size(194, 73);
            this.CmdCivils.TabIndex = 0;
            this.CmdCivils.Text = "Les Civils";
            this.CmdCivils.UseVisualStyleBackColor = false;
            this.CmdCivils.Click += new System.EventHandler(this.CmdCivils_Click);
            // 
            // CmdSH
            // 
            this.CmdSH.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CmdSH.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdSH.ForeColor = System.Drawing.SystemColors.Desktop;
            this.CmdSH.Location = new System.Drawing.Point(546, 226);
            this.CmdSH.Name = "CmdSH";
            this.CmdSH.Size = new System.Drawing.Size(194, 73);
            this.CmdSH.TabIndex = 1;
            this.CmdSH.Text = "Les Super-Héros";
            this.CmdSH.UseVisualStyleBackColor = false;
            this.CmdSH.Click += new System.EventHandler(this.CmdSH_Click);
            // 
            // CmdOrg
            // 
            this.CmdOrg.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CmdOrg.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdOrg.ForeColor = System.Drawing.SystemColors.Desktop;
            this.CmdOrg.Location = new System.Drawing.Point(249, 351);
            this.CmdOrg.Name = "CmdOrg";
            this.CmdOrg.Size = new System.Drawing.Size(194, 73);
            this.CmdOrg.TabIndex = 2;
            this.CmdOrg.Text = "Les Organisations";
            this.CmdOrg.UseVisualStyleBackColor = false;
            this.CmdOrg.Click += new System.EventHandler(this.CmdOrg_Click);
            // 
            // CmdSV
            // 
            this.CmdSV.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CmdSV.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdSV.ForeColor = System.Drawing.SystemColors.Desktop;
            this.CmdSV.Location = new System.Drawing.Point(546, 351);
            this.CmdSV.Name = "CmdSV";
            this.CmdSV.Size = new System.Drawing.Size(194, 73);
            this.CmdSV.TabIndex = 3;
            this.CmdSV.Text = "Les Super-Vilains";
            this.CmdSV.UseVisualStyleBackColor = false;
            this.CmdSV.Click += new System.EventHandler(this.CmdSV_Click);
            // 
            // CmdQuitter
            // 
            this.CmdQuitter.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdQuitter.Location = new System.Drawing.Point(432, 517);
            this.CmdQuitter.Name = "CmdQuitter";
            this.CmdQuitter.Size = new System.Drawing.Size(102, 35);
            this.CmdQuitter.TabIndex = 14;
            this.CmdQuitter.Text = "Fermer";
            this.CmdQuitter.UseVisualStyleBackColor = true;
            this.CmdQuitter.Click += new System.EventHandler(this.CmdQuitter_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Avergers.Properties.Resources.Avengerslogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(956, 562);
            this.Controls.Add(this.CmdQuitter);
            this.Controls.Add(this.CmdSV);
            this.Controls.Add(this.CmdOrg);
            this.Controls.Add(this.CmdSH);
            this.Controls.Add(this.CmdCivils);
            this.DoubleBuffered = true;
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdCivils;
        private System.Windows.Forms.Button CmdSH;
        private System.Windows.Forms.Button CmdOrg;
        private System.Windows.Forms.Button CmdSV;
        private System.Windows.Forms.Button CmdQuitter;
    }
}