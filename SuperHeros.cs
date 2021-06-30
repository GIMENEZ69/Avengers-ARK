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
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSet2FkIdCivil.Civil'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.civilTableAdapter.Fill(this.projetHeroDataSet2FkIdCivil.Civil);
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSet1.Super_hero'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.super_heroTableAdapter.Fill(this.projetHeroDataSet1.Super_hero);
            // TODO: cette ligne de code charge les données dans la table 'avengersDBDataSetCmbIdCivils.Civils'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.civilsTableAdapter1.Fill(this.avengersDBDataSetCmbIdCivils.Civils);
            // TODO: cette ligne de code charge les données dans la table 'avengersDBDataSetGridViewCivils2.SuperHeros'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.superHerosTableAdapter.Fill(this.avengersDBDataSetGridViewCivils2.SuperHeros);
            // TODO: cette ligne de code charge les données dans la table 'avengersDBDataSet1.SuperHeros'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.superHerosTableAdapter.Fill(this.avengersDBDataSet1.SuperHeros);
            // TODO: cette ligne de code charge les données dans la table 'avengersDBDataSet.Civils'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.civilsTableAdapter.Fill(this.avengersDBDataSet.Civils);



        }

        //SqlConnection conn = new SqlConnection(@"Data Source=AUDREY;Initial Catalog=AvengersDB;Integrated Security=True");
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-TKJHI8I;Initial Catalog=ProjetHero;Integrated Security=True");


        private void CmdCréer_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "INSERT INTO Super_hero (Id_super_hero, Nom_hero, Pouvoir,Point_faible,Commentaire,Id_civil) " +
                "VALUES(                      '" + Id.Text + "', '" + Nom.Text + "','" + Pouvoir.Text + "', '" + PointFaible.Text + "', '" + Commentaire.Text + "','" + comboBox1.Text +"')";
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
            dataGridViewSuperHeros.DataSource = dt;
            conn.Close();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Id.Text = dataGridViewSuperHeros.SelectedRows[0].Cells[0].Value.ToString();
            comboBox1.Text = dataGridViewSuperHeros.SelectedRows[0].Cells[1].Value.ToString();
            Nom.Text = dataGridViewSuperHeros.SelectedRows[0].Cells[2].Value.ToString();
            Pouvoir.Text = dataGridViewSuperHeros.SelectedRows[0].Cells[3].Value.ToString();
            PointFaible.Text = dataGridViewSuperHeros.SelectedRows[0].Cells[4].Value.ToString();
            Commentaire.Text = dataGridViewSuperHeros.SelectedRows[0].Cells[5].Value.ToString();
            
            
        }

        private void CmdMaj_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "UPDATE Super_hero SET Nom_hero = '" + Nom.Text + "', Pouvoir = '" + Pouvoir.Text + "', Point_Faible = '" + PointFaible.Text + "', Commentaire = '" + Commentaire.Text + "', Id_Civil = '" + comboBox1.Text + "' WHERE Id_Super_hero = '" + Id.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("La modification a bien été prise en compte.");
        }

        private void CmdSupp_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "DELETE FROM Super_hero WHERE Id_super_hero = '" + Id.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show(" L'identifiant a bien été supprimé");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
