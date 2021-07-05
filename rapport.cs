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
    public partial class rapport : Form
    {
        public rapport()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4E03TBFV\MYSQL;Initial Catalog=ProjetHero;Integrated Security=True");

        private void rapport_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSet3MissionGRDV.Mission'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.missionTableAdapter1.Fill(this.projetHeroDataSet3MissionGRDV.Mission);
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSet3DataGridViewMissioninRapportForm.Mission'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.missionTableAdapter.Fill(this.projetHeroDataSet3DataGridViewMissioninRapportForm.Mission);
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSet3test.Civil'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.civilTableAdapter.Fill(this.projetHeroDataSet3test.Civil);

        }

        private void ValidRapport_Click(object sender, EventArgs e)
        {
            //Mission Dégats
            try
            {
                conn.Open();
                string query = "INSERT INTO Mission_degats (Id_mission_degats, Id_mission,                                         Id_incident,                                            Id_civil,                          Gravite,                                                  Itineraire,Nature,                                             Titre,                                          Date_debut,                                                Date_fin,                                                    Nom_hero)" +
                    "VALUES('" + Convert.ToInt32(IdMission.Text) + "','" + Convert.ToInt32(idIncident.Text) + "','" + Convert.ToInt32(id_civil.Text) + "','" + CmbNivGravite.Text + "','" + adresse.Text + "','" + txtNatureIncident.Text + "','" + titreMission.Text + "','" + Convert.ToDateTime(dateDebut.Text) + "','" + Convert.ToDateTime(dateTimeFin.Text) + "','" + CmbInterSH.Text + "')";
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
