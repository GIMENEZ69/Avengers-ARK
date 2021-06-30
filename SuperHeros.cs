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
    public partial class SuperHeros : Form
    {
        public SuperHeros()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSet3SuperHeroIdCivilCombo.Civil'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.civilTableAdapter1.Fill(this.projetHeroDataSet3SuperHeroIdCivilCombo.Civil);
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSet3SuperHeroGridView.Super_hero'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.super_heroTableAdapter1.Fill(this.projetHeroDataSet3SuperHeroGridView.Super_hero);
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSet2.Civil'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.civilTableAdapter.Fill(this.projetHeroDataSet2.Civil);
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSet1.Super_hero'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.super_heroTableAdapter.Fill(this.projetHeroDataSet1.Super_hero);

        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4E03TBFV\MYSQL;Initial Catalog=ProjetHero;Integrated Security=True");


        private void CmdCréer_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "INSERT INTO Super_hero (Id_super_hero,      Nom_hero,         Pouvoir,               Point_faible,               Commentaire,                   Id_civil) " +
                "VALUES(                      '" + Id.Text + "', '" + Nom.Text + "','" + Pouvoir.Text + "', '" + PointFaible.Text + "', '" + Commentaire.Text + "', '" + CmbIdCivils.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Le Super-Héros a bien été créé");
        }

        private void CmbIdCivils_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmdRead_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "SELECT * FROM Super_hero";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void CmdMaj_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "UPDATE Super_hero SET Nom_hero = '" + Nom.Text + "', Pouvoir = '" + Pouvoir.Text + "', Point_faible = '" + PointFaible.Text + "', Commentaire = '" + Commentaire.Text + "', Id_civil = '" + CmbIdCivils.Text + "' WHERE Id_super_hero = '" + Id.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("La modification a bien été prise en compte.");
        }

        private void CmdSupp_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "DELETE FROM Super_hero where Id_super_hero = '" + Id.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("L'identifiant a bien été supprimé");
        }

        private void CmdQuitter_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void dataGridView1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            Id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Nom.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Pouvoir.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            PointFaible.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            Commentaire.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            CmbIdCivils.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
