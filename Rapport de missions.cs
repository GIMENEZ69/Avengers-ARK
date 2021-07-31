/**
 * Titre : Avengers
 * Créer par : RG / AS / DC / KT
 * Date : 06/07/2021
 **/
using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Avergers
{
    public partial class Rapport_de_missions : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-TKJHI8I;Initial Catalog=ProjetHero;Integrated Security=True");
        
        public Rapport_de_missions()
        {
            InitializeComponent();
        }

        private void Rapport_de_missions_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSet11.Mission'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.missionTableAdapter.Fill(this.projetHeroDataSet11.Mission);
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSetNomSVRapportMission.Super_vilain'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.super_vilainTableAdapter.Fill(this.projetHeroDataSetNomSVRapportMission.Super_vilain);
        }

        private void Valider_Click(object sender, EventArgs e)
        {
            if (CmbSHDemasque.SelectedIndex == 0)
            {
                conn.Open();
                string query = "INSERT INTO Mission_superhero (Id_mission, nom_hero, Flag_mort)" +
                    "VALUES( '" + IdMission.Text + "', '" + HerosIntervenu.Text + "', '" + CmbSHDemasque.Text + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
                SDA.SelectCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Enregistré");

                Crise crise = new Crise();
                crise.ShowDialog();
            }
            else
            {
                MessageBox.Show("rien");
            }
        }

        private void Extract_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in dataGridView1.Rows)
            {
                int id = Convert.ToInt32(dgvr.Cells[0].Value);
                IdMission.Text = id.ToString();
                IdIncident.Text = dgvr.Cells[1].Value.ToString();
                IdCivil.Text = dgvr.Cells[2].Value.ToString();
                NatureIncident.Text = dgvr.Cells[3].Value.ToString();
                TitreIncident.Text = dgvr.Cells[4].Value.ToString();
                DateMission.Text = dgvr.Cells[5].Value.ToString();
                HerosIntervenu.Text = dgvr.Cells[9].Value.ToString();
                break;
            }
        }

        private void Recherche_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(Recherche.Text))
                    missionBindingSource.Filter = string.Empty;
                else
                    missionBindingSource.Filter = string.Format("{0}='{1}'", CmbSelecRech.Text, Recherche.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void CmdGenerIdSH_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Id_super_hero FROM Super_hero WHERE Nom_hero = '" + HerosIntervenu.Text + "'", conn);
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            IdSH.Text = result.ToString();
        }
    }
}
