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
    public partial class Organisations : Form
    {
        public Organisations()
        {
            InitializeComponent();
        }

        private void Organisations_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projetHeroDataSet15.Organisation' table. You can move, or remove it, as needed.
            this.organisationTableAdapter2.Fill(this.projetHeroDataSet15.Organisation);
            // TODO: This line of code loads data into the 'projetHeroDataSet14.Civil' table. You can move, or remove it, as needed.
            this.civilTableAdapter2.Fill(this.projetHeroDataSet14.Civil);



        }

        private void CmdQuitter_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=MSI-UBI\MSSQLSERVER01;Initial Catalog=ProjetHero;Integrated Security=True");
        private void CmdCréer_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "INSERT INTO Organisation (Id_organisation,     Nom_org,             Siege_social,           Id_civil_dirigeant,         Membre,                 Ajout_orga,                                         Modification_org) " +
                "VALUES(                            '" + Id.Text + "', '" + Nom.Text + "','" + SiegeSocial.Text + "', '" + Dirigeant.Text + "','" + Membre.Text + "', '" + DateTimeAjout.Text + "', '" + DateTimeModif.Text+ "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("L'organisation a bien été créée");
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
        }

        private void CmdMaj_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "UPDATE Organisation SET Nom_org = '" + Nom.Text + "', Siege_social = '" + SiegeSocial.Text + "', Id_civil_dirigeant = '" + Dirigeant.Text + "', Membre = '" + Membre.Text + "', Ajout_orga = '" + DateTimeAjout.Text + "', Modification_org = '" + DateTimeModif.Text + "' WHERE Id_Organisation = '" + Id.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("La modification a bien été prise en compte.");
        }

        private void CmdSupp_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "DELETE FROM Organisation where Id_Organisation = '" + Id.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show(" L'identifiant a bien été supprimé");
        }

        private void dataGridView1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            Id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Nom.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            SiegeSocial.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Dirigeant.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            Membre.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            DateTimeAjout.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            DateTimeModif.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void Nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void Membre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
