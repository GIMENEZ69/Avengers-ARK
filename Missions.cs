using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avergers
{
    public partial class Missions : Form
    {
        public Missions()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(@"Data Source=MSI-UBI\MSSQLSERVER01;Initial Catalog=ProjetHero;Integrated Security=True");
        }

        private void CmdAnnuler_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void Missions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projetHeroDataSetHeroMission.Super_hero' table. You can move, or remove it, as needed.
            this.super_heroTableAdapter.Fill(this.projetHeroDataSetHeroMission.Super_hero);
            // TODO: This line of code loads data into the 'projetHeroDataSetGridMission.Incident' table. You can move, or remove it, as needed.
            //this.incidentTableAdapter1.Fill(this.projetHeroDataSetGridMission.Incident);
            // TODO: This line of code loads data into the 'projetHeroDataSetMission.Incident' table. You can move, or remove it, as needed.
           // this.incidentTableAdapter.Fill(this.projetHeroDataSetMission.Incident);

            comborecherche.SelectedIndex = 1;  
        }

        private void TitreIncident_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(textRecherche.Text))
                    incidentBindingSource1.Filter = string.Empty;
                else
                    incidentBindingSource1.Filter = string.Format("{0}='{1}'", comborecherche.Text, textRecherche.Text);

            }
        }
    }
}
