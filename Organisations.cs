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
    public partial class Organisations : Form
    {
        public Organisations()
        {
            InitializeComponent();
        }

        private void Organisations_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSet4.Organisation'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.organisationTableAdapter.Fill(this.projetHeroDataSet4.Organisation);
            // TODO: cette ligne de code charge les données dans la table 'projetHeroDataSet3.Civil'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.civilTableAdapter.Fill(this.projetHeroDataSet3.Civil);
        }

        private void CmdQuitter_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-TKJHI8I;Initial Catalog=ProjetHero;Integrated Security=True");

        
        private void CmdCréer_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "INSERT INTO Organisation ( Nom_org, Siege_social, Id_civil_dirigeant, Membre, Ajout_orga, Modification_org) " +
                "VALUES(                            '" + Nom.Text +"', '" + Siegesocial.Text + "','" + comboBox1.Text + "', '" + Dirigeant.Text + "','" + Convert.ToDateTime(dateajout.Text) + "', '" + Convert.ToDateTime (datemodif.Text) + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("L'organisation a bien été créée");
            Id.Text = "";
            Nom.Text = "";
            Siegesocial.Text = "";
            comboBox1.Text = "";
            Dirigeant.Text = "";
        }

        private void CmdRead_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "SELECT * FROM Organisation";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            Id.Text = "";
            Nom.Text = "";
            Siegesocial.Text = "";
            comboBox1.Text = "";
            Dirigeant.Text = "";
        }

        private void CmdMaj_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "UPDATE Organisation SET Nom_org = '" + Nom.Text +"', Siege_social ='" + Siegesocial.Text + "',Id_civil_dirigeant = '" + comboBox1.Text + "', Membre = '" + Dirigeant.Text + "', Ajout_orga = '" + Convert.ToDateTime(dateajout.Text) + "', Modification_org = '" + Convert.ToDateTime(datemodif.Text) + "' WHERE Id_organisation = '" + Id.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("La modification a bien été prise en compte.");
            Id.Text = "";
            Nom.Text = "";
            Siegesocial.Text = "";
            comboBox1.Text = "";
            Dirigeant.Text = "";
        }

        private void CmdSupp_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "DELETE FROM Organisation where Id_organisation = '" + Id.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show(" L'identifiant a bien été supprimé");
            Id.Text = "";
            Nom.Text = "";
            Siegesocial.Text = "";
            comboBox1.Text = "";
            Dirigeant.Text = "";
        }

        private void dataGridView1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            Id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Nom.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Siegesocial.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            Dirigeant.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            dateajout.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            datemodif.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }
    }
}
