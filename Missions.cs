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

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4E03TBFV\MYSQL;Initial Catalog=ProjetHero;Integrated Security=True");

        private void Missions_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSetMissionComboboxSuperHero2.Super_hero2'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.super_hero2TableAdapter.Fill(this.projetHeroDataSetMissionComboboxSuperHero2.Super_hero2);
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSetMissionComboNomSuperhero.Super_heo'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.super_heoTableAdapter1.Fill(this.projetHeroDataSetMissionComboNomSuperhero.Super_heo);
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSetIncidentDatagridview.Incident'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.incidentTableAdapter.Fill(this.projetHeroDataSetIncidentDatagridview.Incident);
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSet3superherocombobox.Super_heo'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.super_heoTableAdapter.Fill(this.projetHeroDataSet3superherocombobox.Super_heo);

            cboColumn.SelectedIndex = 1;

        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtSearch.Text))
                    incidentBindingSource.Filter = string.Empty;
                else
                    incidentBindingSource.Filter = string.Format("{0}='{1}'", cboColumn.Text, txtSearch.Text);
            }
        }

        private void ExtractBtn_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in dataGridView1.Rows)
            {
                //int id = Convert.ToInt32(dgvr.Cells[7].Value);
                txtNatureIncident.Text = dgvr.Cells[6].Value.ToString();
                dateDebut.Text = dgvr.Cells[5].Value.ToString();
                id_civil.Text = dgvr.Cells[1].Value.ToString();
                idIncident.Text = dgvr.Cells[0].Value.ToString();
                adresse.Text = dgvr.Cells[3].Value.ToString();
                break;
            }
        }

        private void CmdAnnuler_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.ShowDialog();
        }

        private void CmdValider_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO Mission (Id_Mission,                                        Id_incident,                                            Id_civil,                          Gravite,                                                  Itineraire,Nature,                                             Titre,                              Date_debut,                                               Date_fin, )" +
                    "VALUES('" +                                Convert.ToInt32(IdMission.Text) + "','" +Convert.ToInt32(idIncident.Text)+ "','" + Convert.ToInt32(id_civil.Text) + "','" + CmbNivGravite.Text + "','"+adresse.Text + "','" +txtNatureIncident.Text+ "','" +                  titreMission.Text +"','" + Convert.ToDateTime(dateDebut.Text) + "','" + Convert.ToDateTime(dateTimeFin.Text)+"','"+ CmbInterSH.Text+ "')";
                SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
                SDA.SelectCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("La mission a bien été créé");
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
    }
}
