namespace Avergers
{
    partial class Missions
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
            this.CmdAnnuler = new System.Windows.Forms.Button();
            this.CmdValider = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CmbInterSH = new System.Windows.Forms.ComboBox();
            this.DateDébutInc = new System.Windows.Forms.TextBox();
            this.CmbNatureIncident = new System.Windows.Forms.ComboBox();
            this.CmbNivGravite = new System.Windows.Forms.ComboBox();
            this.IdMission = new System.Windows.Forms.TextBox();
            this.DateFinMission = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdAnnuler
            // 
            this.CmdAnnuler.Location = new System.Drawing.Point(493, 424);
            this.CmdAnnuler.Name = "CmdAnnuler";
            this.CmdAnnuler.Size = new System.Drawing.Size(111, 62);
            this.CmdAnnuler.TabIndex = 6;
            this.CmdAnnuler.Text = "Annuler";
            this.CmdAnnuler.UseVisualStyleBackColor = true;
            // 
            // CmdValider
            // 
            this.CmdValider.Location = new System.Drawing.Point(212, 424);
            this.CmdValider.Name = "CmdValider";
            this.CmdValider.Size = new System.Drawing.Size(115, 62);
            this.CmdValider.TabIndex = 5;
            this.CmdValider.Text = "Valider la mission";
            this.CmdValider.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.CmbInterSH);
            this.groupBox1.Controls.Add(this.DateDébutInc);
            this.groupBox1.Controls.Add(this.CmbNatureIncident);
            this.groupBox1.Controls.Add(this.CmbNivGravite);
            this.groupBox1.Controls.Add(this.IdMission);
            this.groupBox1.Controls.Add(this.DateFinMission);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 127);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mission :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 20);
            this.textBox1.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Titre de la mission :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(542, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Id de la mission :";
            // 
            // CmbInterSH
            // 
            this.CmbInterSH.FormattingEnabled = true;
            this.CmbInterSH.Location = new System.Drawing.Point(399, 69);
            this.CmbInterSH.Name = "CmbInterSH";
            this.CmbInterSH.Size = new System.Drawing.Size(116, 21);
            this.CmbInterSH.TabIndex = 22;
            // 
            // DateDébutInc
            // 
            this.DateDébutInc.Location = new System.Drawing.Point(139, 69);
            this.DateDébutInc.Name = "DateDébutInc";
            this.DateDébutInc.Size = new System.Drawing.Size(112, 20);
            this.DateDébutInc.TabIndex = 21;
            // 
            // CmbNatureIncident
            // 
            this.CmbNatureIncident.FormattingEnabled = true;
            this.CmbNatureIncident.Items.AddRange(new object[] {
            "Prise d\'otage",
            "Braquage",
            "Coup de feu",
            "Autres"});
            this.CmbNatureIncident.Location = new System.Drawing.Point(141, 33);
            this.CmbNatureIncident.Name = "CmbNatureIncident";
            this.CmbNatureIncident.Size = new System.Drawing.Size(114, 21);
            this.CmbNatureIncident.TabIndex = 20;
            // 
            // CmbNivGravite
            // 
            this.CmbNivGravite.FormattingEnabled = true;
            this.CmbNivGravite.Items.AddRange(new object[] {
            "Faible (dangereux)",
            "Moyenne ",
            "Importante",
            "Urgente (Destruction imminente)"});
            this.CmbNivGravite.Location = new System.Drawing.Point(633, 33);
            this.CmbNivGravite.Name = "CmbNivGravite";
            this.CmbNivGravite.Size = new System.Drawing.Size(115, 21);
            this.CmbNivGravite.TabIndex = 19;
            // 
            // IdMission
            // 
            this.IdMission.Location = new System.Drawing.Point(633, 69);
            this.IdMission.Name = "IdMission";
            this.IdMission.Size = new System.Drawing.Size(115, 20);
            this.IdMission.TabIndex = 13;
            // 
            // DateFinMission
            // 
            this.DateFinMission.Location = new System.Drawing.Point(399, 33);
            this.DateFinMission.Name = "DateFinMission";
            this.DateFinMission.Size = new System.Drawing.Size(115, 20);
            this.DateFinMission.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(530, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Niveau de gravité :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Intervention Héros :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date de fin de mission :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date de début :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nature de l\'incident :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(584, 9);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Rechercher par :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Rechercher par :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 21);
            this.comboBox1.TabIndex = 36;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 213);
            this.dataGridView1.TabIndex = 35;
            // 
            // Missions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.CmdAnnuler);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmdValider);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Missions";
            this.Text = "Déclaration et rapport d\'une mission";
            this.Load += new System.EventHandler(this.Missions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CmdAnnuler;
        private System.Windows.Forms.Button CmdValider;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CmbInterSH;
        private System.Windows.Forms.TextBox DateDébutInc;
        private System.Windows.Forms.ComboBox CmbNatureIncident;
        private System.Windows.Forms.ComboBox CmbNivGravite;
        private System.Windows.Forms.TextBox IdMission;
        private System.Windows.Forms.TextBox DateFinMission;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}