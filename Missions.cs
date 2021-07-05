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
        }

        private void Missions_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSetFicheMissionDtgvIncident.Incident'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.incidentTableAdapter3.Fill(this.projetHeroDataSetFicheMissionDtgvIncident.Incident);
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSetherosmission.Super_hero'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.super_heroTableAdapter.Fill(this.projetHeroDataSetherosmission.Super_hero);
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSetDGVIncidentMission.Incident'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.incidentTableAdapter2.Fill(this.projetHeroDataSetDGVIncidentMission.Incident);
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSetIdIncidentMission.Incident'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.incidentTableAdapter1.Fill(this.projetHeroDataSetIdIncidentMission.Incident);
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSet3.Incident'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.incidentTableAdapter.Fill(this.projetHeroDataSet3.Incident);
            CmbSelecRech.SelectedIndex = 1;
        }

        private void Recherche_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(Recherche.Text))
                    incidentBindingSource2.Filter = string.Empty;
                else
                    incidentBindingSource2.Filter = string.Format("{0}='{1}'", CmbSelecRech.Text, Recherche.Text);
            }
        }

        SqlConnection conn = new SqlConnection(@"Data Source=AUDREY;Initial Catalog=ProjetHero;Integrated Security=True");
        private void CmdValiderMission_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "INSERT INTO Mission (Id_incident, Id_civil, Nature, Titre, Date_debut, Itineraire, Urgence, Gravite, Nom_hero_mission)" +
                "VALUES( '" + IdIncident.Text + "', '" + IdCivilDeclarant.Text + "', '" + NatureIncident.Text + "','" + TitreIncident.Text + "', '" + DateDebutMission.Text + "', '" + Adresse.Text + "','" + CmbUrgence.Text + "','" + CmbNivGravite.Text + "', '" + CmbInterSH.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("La mission a bien été créée");
        }

        private void ExtractIncident_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in dataGridView1.Rows)
            {
                int id = Convert.ToInt32(dgvr.Cells[0].Value);
                IdIncident.Text = id.ToString();
                IdCivilDeclarant.Text = dgvr.Cells[1].Value.ToString();
                NatureIncident.Text = dgvr.Cells[2].Value.ToString();
                DateDebutMission.Text = dgvr.Cells[4].Value.ToString();
                Adresse.Text = dgvr.Cells[3].Value.ToString();
                break;
            }
        }
    }
}
