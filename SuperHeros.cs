/**
 * Titre : Avengers
 * Créer par : RG / AS / DC / KT
 * Date : 06/07/2021
 **/
using System;
using System.Data;
using System.Data.SqlClient;
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
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSet12.Super_hero'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.super_heroTableAdapter2.Fill(this.projetHeroDataSet12.Super_hero);
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSetDataGridviewsuperhero.Super_hero'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.super_heroTableAdapter1.Fill(this.projetHeroDataSetDataGridviewsuperhero.Super_hero);
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSet2FkIdCivil.Civil'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.civilTableAdapter.Fill(this.projetHeroDataSet2FkIdCivil.Civil);
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSet1.Super_hero'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.super_heroTableAdapter.Fill(this.projetHeroDataSet1.Super_hero);
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-TKJHI8I;Initial Catalog=ProjetHero;Integrated Security=True");


        private void CmdCréer_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "INSERT INTO Super_hero ( Nom_hero, Pouvoir,Point_faible,Commentaire) " +
                "VALUES(                       '" + Nom.Text + "','" + Pouvoir.Text + "', '" + PointFaible.Text + "', '" + Commentaire.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Le Super-Héros a bien été créé");
            Id.Text = "";
            Nom.Text = "";
            Pouvoir.Text = "";
            PointFaible.Text = "";
            Commentaire.Text = "";
        }

        private void CmdRead_Click(object sender, EventArgs e)
        {
            
            conn.Open();
            string query = "SELECT * FROM Super_hero";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridViewSuperHeros.DataSource = dt;
            conn.Close();
            Id.Text = "";
            Nom.Text = "";
            Pouvoir.Text = "";
            PointFaible.Text = "";
            Commentaire.Text = "";
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Id.Text = dataGridViewSuperHeros.SelectedRows[0].Cells[0].Value.ToString();
            //comboBox1.Text = dataGridViewSuperHeros.SelectedRows[0].Cells[1].Value.ToString();
            Nom.Text = dataGridViewSuperHeros.SelectedRows[0].Cells[1].Value.ToString();
            Pouvoir.Text = dataGridViewSuperHeros.SelectedRows[0].Cells[2].Value.ToString();
            PointFaible.Text = dataGridViewSuperHeros.SelectedRows[0].Cells[3].Value.ToString();
            Commentaire.Text = dataGridViewSuperHeros.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void CmdMaj_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "UPDATE Super_hero SET Nom_hero = '" + Nom.Text + "', Pouvoir = '" + Pouvoir.Text + "', Point_Faible = '" + PointFaible.Text + "', Commentaire = '" + Commentaire.Text + "' WHERE Id_Super_hero = '" + Id.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("La modification a bien été prise en compte.");
            Id.Text = "";
            Nom.Text = "";
            Pouvoir.Text = "";
            PointFaible.Text = "";
            Commentaire.Text = "";
        }

        private void CmdSupp_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "DELETE FROM Super_hero WHERE Id_super_hero = '" + Id.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show(" L'identifiant a bien été supprimé");
            Id.Text = "";
            Nom.Text = "";
            Pouvoir.Text = "";
            PointFaible.Text = "";
            Commentaire.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
