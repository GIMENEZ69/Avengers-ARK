/**
 * Titre : Avengers
 * Créer par : RG / AS / DJ / KT
 * Date : 06/07/2021
 **/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Avergers
{
    public partial class Civils : Form
    {
        public Civils()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSet.Civil'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.civilTableAdapter.Fill(this.projetHeroDataSet.Civil);
        }

        private void CmdQuitter_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-TKJHI8I;Initial Catalog=ProjetHero;Integrated Security=True");
        
        private void CmdCréer_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "INSERT INTO Civil ( Nom, Prenom, Adresse, Date_naissance, Date_ajout, Date_modification) " +
                "VALUES(                      '" + Nom.Text + "','" + Prenom.Text + "','" + Adresse.Text + "','" + Convert.ToDateTime(Ddn2.Text) + "', '" + Convert.ToDateTime(Dateajout2.Text) + "', '" + Convert.ToDateTime(Datemodif2.Text) + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Le civil a bien été créé");
            Id.Text = "";
            Nom.Text = "";
            Prenom.Text = "";
            Adresse.Text = "";
            
        }

        private void CmdRead_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "SELECT * FROM Civil";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            Id.Text = "";
            Nom.Text = "";
            Prenom.Text = "";
            Adresse.Text = "";
        }

        private void CmdMaj_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "UPDATE Civil SET Nom = '" + Nom.Text + "', Prenom = '" + Prenom.Text + "', Adresse = '" + Adresse.Text + "', Date_naissance = '" + Convert.ToDateTime(Ddn2.Text) + "', Date_ajout = '" + Convert.ToDateTime(Dateajout2.Text) + "', Date_modification = '" + Convert.ToDateTime(Datemodif2.Text) + "' WHERE Id_civil = '" + Id.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("La modification a bien été prise en compte.");
            Id.Text = "";
            Nom.Text = "";
            Prenom.Text = "";
            Adresse.Text = "";
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Nom.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Prenom.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Adresse.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            Ddn2.Text  = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            //DateDeces2.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            Dateajout2.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            Datemodif2.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void CmdSupp_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "DELETE FROM Civil where Id_civil = '" + Id.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("L'identifiant a bien été supprimé");
            Id.Text = "";
            Nom.Text = "";
            Prenom.Text = "";
            Adresse.Text = "";
        }
    }
}
