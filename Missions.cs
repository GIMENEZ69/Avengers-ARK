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

        private void CmdAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Missions_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSet7.Super_hero'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.super_heroTableAdapter.Fill(this.projetHeroDataSet7.Super_hero);
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSet6.Incident'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.incidentTableAdapter.Fill(this.projetHeroDataSet6.Incident);

        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-TKJHI8I;Initial Catalog=ProjetHero;Integrated Security=True");
        private void textSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(textSearch.Text))
                    incidentBindingSource.Filter = string.Empty;
                else
                    incidentBindingSource.Filter = string.Format("{0}='{1}'", cboColonne.Text, textSearch.Text);
            }
        }

        private void CmdValider_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "INSERT INTO Mission (Titre, Date_debut, Date_fin, Urgence, Gravite, Nom_hero_mission)" +
                "VALUES(   '" + TitreIncident.Text + "', '" + Convert.ToDateTime(DateDebut.Text) + "', '" + Convert.ToDateTime(DateFin.Text) + "', '" + CmbUrgence.Text + "','" + CmbNivGravite.Text + "', '" + CmbInterSH.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("La mission a bien été créée");
        }
    }    
}
