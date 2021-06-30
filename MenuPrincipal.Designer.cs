
namespace Avergers
{
    partial class MenuPrincipal
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
            this.CmdQuitter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CmdUtilisateur = new System.Windows.Forms.Button();
            this.CmdAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdQuitter
            // 
            this.CmdQuitter.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdQuitter.Location = new System.Drawing.Point(295, 312);
            this.CmdQuitter.Name = "CmdQuitter";
            this.CmdQuitter.Size = new System.Drawing.Size(119, 45);
            this.CmdQuitter.TabIndex = 7;
            this.CmdQuitter.Text = "Quitter";
            this.CmdQuitter.UseVisualStyleBackColor = true;
            this.CmdQuitter.Click += new System.EventHandler(this.CmdQuitter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Veuillez choisir votre mode de connexion :";
            // 
            // CmdUtilisateur
            // 
            this.CmdUtilisateur.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdUtilisateur.Location = new System.Drawing.Point(391, 169);
            this.CmdUtilisateur.Name = "CmdUtilisateur";
            this.CmdUtilisateur.Size = new System.Drawing.Size(154, 55);
            this.CmdUtilisateur.TabIndex = 5;
            this.CmdUtilisateur.Text = "Utilisateur";
            this.CmdUtilisateur.UseVisualStyleBackColor = true;
            this.CmdUtilisateur.Click += new System.EventHandler(this.CmdUtilisateur_Click);
            // 
            // CmdAdmin
            // 
            this.CmdAdmin.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAdmin.Location = new System.Drawing.Point(154, 169);
            this.CmdAdmin.Name = "CmdAdmin";
            this.CmdAdmin.Size = new System.Drawing.Size(154, 55);
            this.CmdAdmin.TabIndex = 4;
            this.CmdAdmin.Text = "Administrateur";
            this.CmdAdmin.UseVisualStyleBackColor = true;
            this.CmdAdmin.Click += new System.EventHandler(this.CmdAdmin_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Avergers.Properties.Resources.Avengerslogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(606, 369);
            this.Controls.Add(this.CmdQuitter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmdUtilisateur);
            this.Controls.Add(this.CmdAdmin);
            this.DoubleBuffered = true;
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdQuitter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CmdUtilisateur;
        private System.Windows.Forms.Button CmdAdmin;
    }
}