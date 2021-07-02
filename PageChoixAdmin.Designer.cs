
namespace Avergers
{
    partial class PageChoixAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageChoixAdmin));
            this.CmdQuitter = new System.Windows.Forms.Button();
            this.CmdGestion = new System.Windows.Forms.Button();
            this.CmdCreation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdQuitter
            // 
            this.CmdQuitter.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdQuitter.Location = new System.Drawing.Point(270, 313);
            this.CmdQuitter.Name = "CmdQuitter";
            this.CmdQuitter.Size = new System.Drawing.Size(119, 45);
            this.CmdQuitter.TabIndex = 5;
            this.CmdQuitter.Text = "Quitter";
            this.CmdQuitter.UseVisualStyleBackColor = true;
            this.CmdQuitter.Click += new System.EventHandler(this.CmdQuitter_Click);
            // 
            // CmdGestion
            // 
            this.CmdGestion.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdGestion.Location = new System.Drawing.Point(381, 147);
            this.CmdGestion.Name = "CmdGestion";
            this.CmdGestion.Size = new System.Drawing.Size(165, 77);
            this.CmdGestion.TabIndex = 4;
            this.CmdGestion.Text = "Créer les missions ";
            this.CmdGestion.UseVisualStyleBackColor = true;
            this.CmdGestion.Click += new System.EventHandler(this.CmdGestion_Click);
            // 
            // CmdCreation
            // 
            this.CmdCreation.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdCreation.Location = new System.Drawing.Point(113, 147);
            this.CmdCreation.Name = "CmdCreation";
            this.CmdCreation.Size = new System.Drawing.Size(165, 77);
            this.CmdCreation.TabIndex = 3;
            this.CmdCreation.Text = "Créer dans la base de données";
            this.CmdCreation.UseVisualStyleBackColor = true;
            this.CmdCreation.Click += new System.EventHandler(this.CmdCreation_Click);
            // 
            // PageChoixAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Avergers.Properties.Resources.Avengerslogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(658, 370);
            this.Controls.Add(this.CmdQuitter);
            this.Controls.Add(this.CmdGestion);
            this.Controls.Add(this.CmdCreation);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PageChoixAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PageChoixAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdQuitter;
        private System.Windows.Forms.Button CmdGestion;
        private System.Windows.Forms.Button CmdCreation;
    }
}