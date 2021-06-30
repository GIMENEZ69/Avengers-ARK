using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Avergers
{
    public partial class SuperVilains : Form
    {
        public SuperVilains()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-TKJHI8I;Initial Catalog=ProjetHero;Integrated Security=True");


        private void CmdCreer_Clickk(object sender, EventArgs e)
        {
            conn.Open();
            string query = "INSERT INTO Super_vilain (Id_Super_vilain, Nom_vilain, Pouvoir, Commentaire, Id_civil) " +
                "VALUES(                      '" + Id.Text + "', '" + Nom.Text + "','" + Pouvoir.Text +"','" + Commentaire.Text + "','" + comboBox1.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Le Super-Vilain a bien été créé");
        }

        private void CmdRead_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "SELECT * FROM Super_vilain";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridViewSuperVilains.DataSource = dt;
            conn.Close();
        }

        private void CmdMaj_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "UPDATE Super_vilain SET Nom_vilain = '" + Nom.Text + "', Pouvoir = '" + Pouvoir.Text + "', Commentaire = '" + Commentaire.Text + "', Id_civil = '" + comboBox1.Text + "' WHERE Id_Super_vilain = '" + Id.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("La modification a bien été prise en compte.");
        }

        private void CmdSupp_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "DELETE FROM Super_vilain where Id_Super_vilain = '" + Id.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show(" L'identifiant a bien été supprimé");
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Id.Text = dataGridViewSuperVilains.SelectedRows[0].Cells[0].Value.ToString();
            comboBox1.Text = dataGridViewSuperVilains.SelectedRows[0].Cells[1].Value.ToString();
            Nom.Text = dataGridViewSuperVilains.SelectedRows[0].Cells[2].Value.ToString();
            Pouvoir.Text = dataGridViewSuperVilains.SelectedRows[0].Cells[3].Value.ToString();
            Commentaire.Text = dataGridViewSuperVilains.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSet2.Super_vilain'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.super_vilainTableAdapter.Fill(this.projetHeroDataSet2.Super_vilain);
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSet2FkIdCivil_2.Civil'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.civilTableAdapter.Fill(this.projetHeroDataSet2FkIdCivil_2.Civil);
            // TODO: cette ligne de code charge les données dans la table 'avengersDBDataSet.SuperVilains'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.superVilainsTableAdapter.Fill(this.avengersDBDataSet.SuperVilains);

        }
    }
}
