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
    public partial class RapportMissions : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=AUDREY;Initial Catalog=ProjetHero;Integrated Security=True");
        public RapportMissions()
        {
            InitializeComponent();
        }

        private void RapportMissions_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSetRapportMission.Mission'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.missionTableAdapter.Fill(this.projetHeroDataSetRapportMission.Mission);
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSetCivilmortRapport.Civil'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.civilTableAdapter1.Fill(this.projetHeroDataSetCivilmortRapport.Civil);
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSetCivil.Civil'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.civilTableAdapter.Fill(this.projetHeroDataSetCivil.Civil);
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSetNomSVRapportMission.Super_vilain'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.super_vilainTableAdapter.Fill(this.projetHeroDataSetNomSVRapportMission.Super_vilain);
            CmbSelecRech.SelectedIndex = 0;
        }

        private void CmdValiderRapport_Click(object sender, EventArgs e)
        {
            if(CmbSHDemasque.SelectedIndex == 0)
            {
                conn.Open();
                string query = "INSERT INTO Mission_superhero (Id_mission, nom_hero, Flag_mort)" +
                    "VALUES( '" + IdMission.Text + "', '" + HerosIntervenu.Text + "', '" + CmbSHDemasque.Text + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
                SDA.SelectCommand.ExecuteNonQuery();
                conn.Close();
                //MessageBox.Show("Enregistré");

                Crise_Heros criseheros = new Crise_Heros();
                criseheros.ShowDialog();
            } else
            {
                //MessageBox.Show("rien");
            }

            if(CBBCivilMort.SelectedIndex == 0)
            {
                conn.Open();
                string query = "UPDATE Civil SET Date_deces = '" + Convert.ToDateTime(DateFin.Text) + "' WHERE Id_civil = '" + IdCivil.Text + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
                SDA.SelectCommand.ExecuteNonQuery();
                conn.Close();
                //MessageBox.Show("La date de décès a bien été enregistré");

                Crise_Civil crisecivil = new Crise_Civil();
                crisecivil.ShowDialog();
            }
            else
            {
                //MessageBox.Show("rien");
            }

            if (CmbSVPresent.SelectedIndex == 1)
            {
                conn.Open();
                string query = "INSERT INTO Mission_supervilain (Id_mission, Flag_identifie)" +
                    "VALUES( '" + IdMission.Text + "', '" + CmbSVPresent.Text + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
                SDA.SelectCommand.ExecuteNonQuery();
                conn.Close();
                //MessageBox.Show("Super Vilain enregistré");

                Crise_Vilain crisevilain = new Crise_Vilain();
                crisevilain.ShowDialog();
            }
            else
            {
                //MessageBox.Show("rien");
            }
        }

        private void SelectMission_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in dataGridView2.Rows)
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

        private void CmdAnnuler_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in dataGridView2.Rows)
            {
                dgvr.Cells[6].Value = DateFin.Text;
                break;
                MessageBox.Show("La modification a bien été prise en compte.");
            }
            
        }
    }
}
