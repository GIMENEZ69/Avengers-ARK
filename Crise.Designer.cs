
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
            this.labelsupervilain = new System.Windows.Forms.Label();
            this.textBoxNom_vilain = new System.Windows.Forms.TextBox();
            this.labelcivil_mort = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labeldommage_collateraux = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labeldemasque = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelcrise = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.buttonvalider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelsupervilain
            // 
            this.labelsupervilain.AutoSize = true;
            this.labelsupervilain.Location = new System.Drawing.Point(32, 106);
            this.labelsupervilain.Name = "labelsupervilain";
            this.labelsupervilain.Size = new System.Drawing.Size(104, 13);
            this.labelsupervilain.TabIndex = 0;
            this.labelsupervilain.Text = "Super vilain identifie:";
            // 
            // textBoxNom_vilain
            // 
            this.textBoxNom_vilain.Location = new System.Drawing.Point(192, 99);
            this.textBoxNom_vilain.Name = "textBoxNom_vilain";
            this.textBoxNom_vilain.Size = new System.Drawing.Size(130, 20);
            this.textBoxNom_vilain.TabIndex = 1;
            // 
            // labelcivil_mort
            // 
            this.labelcivil_mort.AutoSize = true;
            this.labelcivil_mort.Location = new System.Drawing.Point(32, 168);
            this.labelcivil_mort.Name = "labelcivil_mort";
            this.labelcivil_mort.Size = new System.Drawing.Size(91, 13);
            this.labelcivil_mort.TabIndex = 2;
            this.labelcivil_mort.Text = "Nom du civil mort:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(192, 161);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 3;
            // 
            // labeldommage_collateraux
            // 
            this.labeldommage_collateraux.AutoSize = true;
            this.labeldommage_collateraux.Location = new System.Drawing.Point(414, 115);
            this.labeldommage_collateraux.Name = "labeldommage_collateraux";
            this.labeldommage_collateraux.Size = new System.Drawing.Size(146, 13);
            this.labeldommage_collateraux.TabIndex = 4;
            this.labeldommage_collateraux.Text = "Cout des dommages lateraux:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(631, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 20);
            this.textBox2.TabIndex = 5;
            // 
            // labeldemasque
            // 
            this.labeldemasque.AutoSize = true;
            this.labeldemasque.Location = new System.Drawing.Point(414, 168);
            this.labeldemasque.Name = "labeldemasque";
            this.labeldemasque.Size = new System.Drawing.Size(193, 13);
            this.labeldemasque.TabIndex = 6;
            this.labeldemasque.Text = "l\'identite du super hero a t\'il ete revele?:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Oui",
            "Non"});
            this.comboBox1.Location = new System.Drawing.Point(631, 160);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(131, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // labelcrise
            // 
            this.labelcrise.AutoSize = true;
            this.labelcrise.Location = new System.Drawing.Point(32, 230);
            this.labelcrise.Name = "labelcrise";
            this.labelcrise.Size = new System.Drawing.Size(135, 13);
            this.labelcrise.TabIndex = 8;
            this.labelcrise.Text = "Declenchement de proces:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Oui",
            "Non"});
            this.comboBox2.Location = new System.Drawing.Point(192, 222);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(123, 21);
            this.comboBox2.TabIndex = 9;
            // 
            // buttonvalider
            // 
            this.buttonvalider.Location = new System.Drawing.Point(333, 302);
            this.buttonvalider.Name = "buttonvalider";
            this.buttonvalider.Size = new System.Drawing.Size(141, 65);
            this.buttonvalider.TabIndex = 10;
            this.buttonvalider.Text = "Valider";
            this.buttonvalider.UseVisualStyleBackColor = true;
            // 
            // Crise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonvalider);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.labelcrise);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labeldemasque);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labeldommage_collateraux);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelcivil_mort);
            this.Controls.Add(this.textBoxNom_vilain);
            this.Controls.Add(this.labelsupervilain);
            this.Name = "Crise";
            this.Text = "Crise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelsupervilain;
        private System.Windows.Forms.TextBox textBoxNom_vilain;
        private System.Windows.Forms.Label labelcivil_mort;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labeldommage_collateraux;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labeldemasque;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelcrise;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button buttonvalider;
    }
}